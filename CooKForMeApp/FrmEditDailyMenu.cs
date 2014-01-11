using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using CookForMe.Controllers;
using CookForMe.Model;
using CookForMe.Model.Repositories;

namespace CookForMeApp
{
    public partial class FrmEditDailyMenu : Form, IShow
    {


        private readonly MainWindowController               _mainController;

        private readonly DailyMenu                          _menu;
        private Dictionary<String, Dictionary<int, string>> _recipesId;

        private readonly string                             _error;
        private string                                      _text;




        public FrmEditDailyMenu(MainWindowController mainController, DailyMenu menu)
        {
            _mainController = mainController;

            _menu = menu;
            _recipesId = new Dictionary<string, Dictionary<int, string>>();

            _error = "Error";
            _text = "";

            InitializeComponent();
        }




        private void buttonShowRecipe_Click(object sender, EventArgs e)
        {
            if (null != treeViewSelectedRecipes.SelectedNode)
            {
                TreeNode node = treeViewSelectedRecipes.SelectedNode;
                if (node.Level == 1)
                {
                    try
                    {
                        var recipeIndexId = _recipesId[node.Parent.Text];
                        var recipe = _mainController.GetRecipeDetails(recipeIndexId[node.Index], node.Parent.Text);
                        var formShowRecipeDetails = new FrmShowRecipeDetails(_mainController, recipe);

                        formShowRecipeDetails.ShowDialog();
                    }
                    catch (ItemNotFoundException)
                    {
                        _text = "Selected recipe not found, please select again!";
                        MessageBox.Show(_text, _error,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    _text = "Select recipe from meal: " + node.Text + "!";
                    MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _text = "Select recipe to show!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            treeViewSelectedRecipes.SelectedNode = null;   
        }

        



        private void buttonSave_Click(object sender, EventArgs e)
        {
            var recipeForMenuMap = new Dictionary<string, List<string>>();
            foreach (TreeNode mealNode in treeViewSelectedRecipes.Nodes)
            {
                var recipeIDs = new List<string>();
                if (mealNode.Checked)
                {
                    GetRecipesForMeal(mealNode, recipeIDs);
                    if (recipeIDs.Count == 0)
                    {
                        _text = "No recipes were selected for the selected meal: " + mealNode.Text
                                + ". Please select at least one recipe!";
                        MessageBox.Show(_text, _error,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    recipeForMenuMap[mealNode.Text] = recipeIDs;
                }
                else
                {
                    GetRecipesForMeal(mealNode, recipeIDs);
                    if (recipeIDs.Count != 0)
                    {
                        recipeForMenuMap[mealNode.Text] = recipeIDs;
                    }
                }
            }
            try
            {
                _mainController.UpdateDailyMenu(_menu.Name, richTextBoxDescription.Text, recipeForMenuMap);
                Close();
            }
            catch (ItemNotFoundException)
            {
                _text = "Unable to update menu, menu: " + _menu.Name + " doesn't exist!";
                MessageBox.Show(_text, _error,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ParemeterEmptyException)
            {
                _text = "Select recipes for meals!";
                MessageBox.Show(_text, _error,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetRecipesForMeal(TreeNode mealNode, List<string> recipeIDs)
        {
            recipeIDs.AddRange(from TreeNode childNode in mealNode.Nodes
                               where childNode.Checked
                               let recipeIndexId = _recipesId[mealNode.Text]
                               select recipeIndexId[childNode.Index]);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }




        private void FrmEditDailyMenu_Load(object sender, EventArgs e)
        {
            richTextBoxDescription.Text = _menu.Description;
            labelMenuName.Text = _menu.Name;

            UpdateRecepieTreeView();
        }

        public void UpdateView()
        {
            UpdateRecepieTreeView();
        }

        private void UpdateRecepieTreeView()
        {
            treeViewSelectedRecipes.CheckBoxes = true;
            treeViewSelectedRecipes.Nodes.Clear();
            var meals = MealRepository.GetInstance().GetMealsName();

            meals.Sort();

            _recipesId = new Dictionary<String, Dictionary<int, string>>();

            foreach (String mealName in meals)
            {
                var recipesData = MealRepository.GetInstance().GetRecepieDataForMeal(mealName);

                var children = new List<TreeNode>();

                var recipeIndexIdMap = new Dictionary<int, string>();
                var recipesCounter = 0;

                var recipeDs = recipesData.Keys.ToList();
                foreach (var recipeId in recipeDs)
                {
                    var recipeName = recipesData[recipeId];
                    var childNode = new TreeNode(recipeName);

                    if (_menu.ContainsRecipeIdForMeal(mealName, recipeId))
                    {
                        childNode.Checked = true;
                    }

                    children.Add(childNode);
                    recipeIndexIdMap[recipesCounter] = recipeId;
                    recipesCounter++;
                }
                _recipesId[mealName] = recipeIndexIdMap;
                var treeNode = new TreeNode(mealName, children.ToArray());

                if (_menu.ContainsMeal(mealName))
                {
                    treeNode.Checked = true;
                }
                treeViewSelectedRecipes.Nodes.Add(treeNode);
            }
        }



        public void PresentDialog()
        {
            ShowDialog();
        }
    }
}

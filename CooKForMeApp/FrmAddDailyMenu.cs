using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using CookForMe.Model;
using CookForMe.Model.Repositories;
using CookForMe.Controllers;

namespace CookForMeApp
{
    public partial class FrmAddDailyMenu : Form, IShow
    {


        private readonly MainWindowController               _mainController;

        private Dictionary<String, Dictionary<int, string>> _recipesId;

        private readonly string                             _error;
        private string                                      _text;



        public FrmAddDailyMenu(MainWindowController mainController)
        {
            _mainController = mainController;

            _recipesId = new Dictionary<string, Dictionary<int, string>>();

            _error = "Error";
            _text = "";

            InitializeComponent();
        }




        private void buttonAddNewRecipe_Click(object sender, EventArgs e)
        {
            treeViewRecipes.SelectedNode = null;

            var formAddRecipe = new FrmAddRecipe(_mainController);

            _mainController.AddRecepie(formAddRecipe);
        }

        private void buttonShowRecipe_Click(object sender, EventArgs e)
        {
            if (null != treeViewRecipes.SelectedNode)
            {
                var node = treeViewRecipes.SelectedNode;
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
            treeViewRecipes.SelectedNode = null;
        }




        private void buttonSaveDailyMenu_Click(object sender, EventArgs e)
        {
            var recipeForMenuMap = new Dictionary<string, List<string>>();
            foreach (TreeNode mealNode in treeViewRecipes.Nodes)
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
                _mainController.CreateDailyMenu(textBoxName.Text, richTextBoxDescription.Text, recipeForMenuMap);
                Close();
            }
            catch (ItemAlreadyExistsException)
            {
                _text = "Daily menu with name: " + textBoxName.Text + " already exists!";
                MessageBox.Show(_text, _error,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ParemeterEmptyException)
            {
                _text = "One or more mandatory items empty!";
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





        private void FrmAddDailyMenu_Load(object sender, EventArgs e)
        {
            UpdateRecepieTreeView();
        }

        public void UpdateView()
        {
            UpdateRecepieTreeView();
        }

        private void UpdateRecepieTreeView()
        {
            treeViewRecipes.CheckBoxes = true;
            treeViewRecipes.Nodes.Clear();
            var meals = MealRepository.GetInstance().GetMealsName();

            meals.Sort();

            _recipesId = new Dictionary<String, Dictionary<int, string>>();

            foreach (String mealName in meals)
            {
                var recipesData = MealRepository.GetInstance().GetRecepieDataForMeal(mealName);

                var children = new List<TreeNode>();

                var recipeIndexIdMap = new Dictionary<int, string>();
                var recipesCounter = 0;

                var recepieIDs = recipesData.Keys.ToList();
                foreach (var recipeId in recepieIDs)
                {
                    var recipeName = recipesData[recipeId];

                    children.Add(new TreeNode(recipeName));
                    recipeIndexIdMap[recipesCounter] = recipeId;
                    recipesCounter++;
                }
                _recipesId[mealName] = recipeIndexIdMap;
                var treeNode = new TreeNode(mealName, children.ToArray());

                treeViewRecipes.Nodes.Add(treeNode);
            }
        }


        public void PresentDialog()
        {
            ShowDialog();
        }
    }
}

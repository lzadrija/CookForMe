using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using CookForMe.Model;
using CookForMe.Model.Repositories;
using CookForMe.Controllers;

namespace CookForMeApp
{
    public partial class FrmShowRecipes : Form, IShow
    {
        private readonly MainWindowController               _mainController;

        private Dictionary<String, Dictionary<int, string>> _recipesId;

        private readonly string                             _error;
        private string                                      _text;


        public FrmShowRecipes(MainWindowController mainController)
        {
            _mainController = mainController;

            _recipesId = new Dictionary<string, Dictionary<int, string>>();

            _error = "Error";
            _text = "";

            InitializeComponent();
        }




        private void buttonRecipesDetails_Click(object sender, EventArgs e)
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
                _text = "Please select a recipe";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FrmShowRecipes_Load(object sender, EventArgs e)
        {
            UpdateRecepieTreeView();
        }

        public void UpdateView()
        {
            UpdateRecepieTreeView();
        }

        private void UpdateRecepieTreeView()
        {
            treeViewRecipes.Nodes.Clear();
            var meals = MealRepository.GetInstance().GetMealsName();

            meals.Sort();

            _recipesId = new Dictionary<String, Dictionary<int, string>>();

            foreach (var mealName in meals)
            {
                var recipesData = MealRepository.GetInstance().GetRecepieDataForMeal(mealName);

                var children = new List<TreeNode>();

                var recipeIndexId = new Dictionary<int, string>();
                var recipesCounter = 0;

                var recepieIDs = recipesData.Keys.ToList();
                foreach (var recipeId in recepieIDs)
                {
                    var recipeName = recipesData[recipeId];
                    children.Add(new TreeNode(recipeName));
                    recipeIndexId[recipesCounter] = recipeId;
                    recipesCounter++;
                }
                _recipesId[mealName] = recipeIndexId;
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

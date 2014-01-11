using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

using CookForMe.Model;
using CookForMe.Model.Repositories;
using CookForMe.Controllers;

namespace CookForMeApp
{
    public partial class FrmGenerateDailyMenu : Form, IShow
    {
        private readonly MainWindowController    _mainController;

        private Dictionary<String, List<String>> _mealsIngredientsSelectionMap, _recipesForMealsMap;
        private Dictionary<String, int>          _mealsNumRecipesMap;

        private bool                             _isInitializing; 

        private readonly string                  _error;
        private string                           _text;



        public FrmGenerateDailyMenu(MainWindowController mainController)
        {
            _mainController = mainController;

            _mealsIngredientsSelectionMap = new Dictionary<string, List<string>>();
            _mealsNumRecipesMap = new Dictionary<string, int>();
            _recipesForMealsMap = new Dictionary<string, List<string>>();

            _isInitializing = true;

            _error = "Error";
            _text = "";

            InitializeComponent();
        }




        private void listBoxMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null == listBoxMeals.SelectedItem || _isInitializing)
            {
                _isInitializing = false;
                return;
            }

            string selectedMeal = listBoxMeals.SelectedItem.ToString();

            if (!_mealsIngredientsSelectionMap.Keys.Contains(selectedMeal))
            {
                _mealsIngredientsSelectionMap[selectedMeal] = new List<string>();
                _mealsNumRecipesMap[selectedMeal] = -1;
            }
            else
            {
                textBoxNumOfRecipesPerMeal.Text = _mealsNumRecipesMap[selectedMeal].ToString(CultureInfo.InvariantCulture);
            }
            UpdateSelectedMealsMap();

            textBoxNumOfRecipesPerMeal.SelectionStart = 0;
            textBoxNumOfRecipesPerMeal.SelectionLength = 0;
            textBoxNumOfRecipesPerMeal.Select();
        }

        private void listBoxSelectedMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMealName = listBoxSelectedMeals.SelectedItem.ToString();

            _text = "Select ingredients for " + selectedMealName + ":";
            labelIngredients.Text = _text;

            if (_mealsNumRecipesMap[selectedMealName] != -1)
            {
                textBoxNumOfRecipesPerMeal.Text = _mealsNumRecipesMap[selectedMealName].ToString(CultureInfo.InvariantCulture);
            }
            if (_mealsNumRecipesMap[selectedMealName] == -1)
            {
                textBoxNumOfRecipesPerMeal.Text = "";
            }

            var checkedIngredientsForMeal = _mealsIngredientsSelectionMap[selectedMealName];

            for (int ingredientIndex = 0; ingredientIndex < checkedListBoxIngredients.Items.Count; ingredientIndex++)
            {
                var ingredientName = checkedListBoxIngredients.Items[ingredientIndex];
                checkedListBoxIngredients.SetItemChecked(ingredientIndex,
                                                         checkedIngredientsForMeal.Contains(ingredientName));
            }
            textBoxNumOfRecipesPerMeal.SelectionStart = 0;
            textBoxNumOfRecipesPerMeal.SelectionLength = 0;
            textBoxNumOfRecipesPerMeal.Select();
        }





        private void buttonNumOfRecipes_Click(object sender, EventArgs e)
        {
            if (null != listBoxSelectedMeals.SelectedItem)
            {
                var selectedMealInDailyMenu = listBoxSelectedMeals.SelectedItem.ToString();
                try
                {
                    _mealsNumRecipesMap[selectedMealInDailyMenu] = Convert.ToInt32(textBoxNumOfRecipesPerMeal.Text);
                }
                catch (FormatException)
                {
                    _text = "Number of recipes must be integer!";
                    MessageBox.Show(_text, _error,
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _text = "Choose a meal from selected meals list!";
                MessageBox.Show(_text, _error,
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxNumOfRecipesPerMeal.Clear();
        }

        private void buttonRemoveSelectedMeal_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedMeals.Items.Count == 0)
            {
                _text = "A meal must be selected before it can be removed!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listBoxSelectedMeals.SelectedIndex == -1)
            {
                _text = "Select a meal from the selected meals list!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedMealInDailyMenu = listBoxSelectedMeals.SelectedItem.ToString();

            _mealsNumRecipesMap.Remove(selectedMealInDailyMenu);
            _mealsIngredientsSelectionMap.Remove(selectedMealInDailyMenu);

            UpdateSelectedMealsMap();
        }

        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            var formAddIngredient = new FrmAddIngredient(_mainController);

            _mainController.AddIngredient(formAddIngredient);
        }

        private void buttonSaveIngredientsForMeal_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedMeals.Items.Count == 0)
            {
                _text = "A meal must be selected before it can be removed!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listBoxSelectedMeals.SelectedIndex == -1)
            {
                _text = "Select a meal from the selected meals list!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedMealInDailyMenu = listBoxSelectedMeals.SelectedItem.ToString();

            var checkedIngredientsForMeal = new List<string>();
            foreach (int checkedItemIndex in checkedListBoxIngredients.CheckedIndices)
            {
                checkedIngredientsForMeal.Add(checkedListBoxIngredients.Items[checkedItemIndex].ToString());
                checkedListBoxIngredients.SetItemChecked(checkedItemIndex, false);
            }
            _mealsIngredientsSelectionMap[selectedMealInDailyMenu] = checkedIngredientsForMeal;
        }





        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            _recipesForMealsMap = _mainController.GenerateDailyMenu(_mealsIngredientsSelectionMap,
                                                                                    _mealsNumRecipesMap);

            _mealsIngredientsSelectionMap = new Dictionary<string, List<string>>();
            _mealsNumRecipesMap = new Dictionary<string, int>();

            UpdateSelectedMealsMap();
            foreach (int checkedItemIndex in checkedListBoxIngredients.CheckedIndices)
            {
                checkedListBoxIngredients.SetItemChecked(checkedItemIndex, false);
            }
            textBoxNumOfRecipesPerMeal.Clear();

            if (_recipesForMealsMap.Count == 0)
            {
                _text = "0 recipes were found for selected meals and ingredients";
                MessageBox.Show(_text);
            }
            else
            {
                GeneratedDailyMenuVisibility(true);
                UpdateGeneratedMenusMap();
            }
        }





        private void buttonShowRecipe_Click(object sender, EventArgs e)
        {
            var node = treeViewDailyMenuRecipes.SelectedNode;
            if (null == node)
            {
                _text = "Select recipe!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (node.Level == 1)
            {
                try
                {
                    var recipeId = _recipesForMealsMap[node.Parent.Text][node.Index];
                    var recipe = _mainController.GetRecipeDetails(recipeId, node.Parent.Text);

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
                _text = "Select recipe for " + node.Text + "!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveMenu_Click(object sender, EventArgs e)
        {
            GeneratedDailyMenuDetailsVisibility(true);
            buttonSaveMenu.Visible = false;
        }




        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                _mainController.CreateDailyMenu(richTextBoxMenuName.Text, richTextBoxDescription.Text, _recipesForMealsMap);

                _text = "Menu: " + richTextBoxMenuName.Text + " is saved!";
                MessageBox.Show(_text);

                GeneratedDailyMenuVisibility(false);
                GeneratedDailyMenuDetailsVisibility(false);
            }
            catch (ItemAlreadyExistsException)
            {
                _text = "Daily menu with name: " + richTextBoxMenuName.Text + " already exists!";
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

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            GeneratedDailyMenuVisibility(false);
            GeneratedDailyMenuDetailsVisibility(false);
        }







        private void FrmGenerateDailyMenu_Load(object sender, EventArgs e)
        {
            _isInitializing = true;

            GeneratedDailyMenuVisibility(false);
            GeneratedDailyMenuDetailsVisibility(false);

            UpdateSelectedMealsMap();
            UpdateMealsList();
            UpdateCheckListBoxIngredients();
        }

        public void UpdateView()
        {
            UpdateMealsList();
            UpdateCheckListBoxIngredients();
        }




        private void UpdateGeneratedMenusMap()
        {
            treeViewDailyMenuRecipes.Nodes.Clear();
            var mealsFromMenu = _recipesForMealsMap.Keys.ToList();

            mealsFromMenu.Sort();

            foreach (var mealName in mealsFromMenu)
            {
                var recipesIDs = _recipesForMealsMap[mealName];

                var treeNode = new TreeNode(mealName, recipesIDs.Select(recipeId =>
                    MealRepository.GetInstance().GetRecipeNameForMeal(recipeId, mealName)).Select(recipeName => new TreeNode(recipeName)).ToArray());
                treeViewDailyMenuRecipes.Nodes.Add(treeNode);
            }
        }

        private void UpdateSelectedMealsMap()
        {
            var selectedMealsNames = _mealsIngredientsSelectionMap.Keys.ToList();
            selectedMealsNames.Sort();
            listBoxSelectedMeals.DataSource = selectedMealsNames;
            listBoxSelectedMeals.SelectionMode = SelectionMode.One;
        }

        private void UpdateMealsList()
        {
            var mealsName = MealRepository.GetInstance().GetMealsName();
            mealsName.Sort();
            listBoxMeals.DataSource = mealsName;
            listBoxMeals.SelectionMode = SelectionMode.One;
        }

        private void UpdateCheckListBoxIngredients()
        {
            var ingredientsNames = FoodRepository.GetInstance().GetFoodsName();
            ingredientsNames.Sort();

            if (listBoxSelectedMeals.SelectedIndex != -1)
            {
                var selectedMealName = listBoxSelectedMeals.SelectedItem.ToString();
                var checkedIngredientsForMeal = _mealsIngredientsSelectionMap[selectedMealName];

                var ingredientCounter = 0;
                foreach (var ingredientName in ingredientsNames)
                {
                    checkedListBoxIngredients.Items.Add(ingredientName);
                    if (checkedIngredientsForMeal.Contains(ingredientName))
                    {
                        checkedListBoxIngredients.SetItemChecked(ingredientCounter, true);
                    }
                    ingredientCounter++;
                }
            }
            else
            {
                foreach (String ingredientName in ingredientsNames)
                {
                    checkedListBoxIngredients.Items.Add(ingredientName);

                }
            }
        }




        private void GeneratedDailyMenuVisibility(bool isVisible)
        {
            labelDailyMenu.Visible = isVisible;
            treeViewDailyMenuRecipes.Visible = isVisible;
            buttonSaveMenu.Visible = isVisible;
            buttonShowRecipe.Visible = isVisible;
        }

        private void GeneratedDailyMenuDetailsVisibility(bool isVisible)
        {
            labelName.Visible = isVisible;
            richTextBoxMenuName.Visible = isVisible;

            labelDescription.Visible = isVisible;
            richTextBoxDescription.Visible = isVisible;

            buttonSave.Visible = isVisible;
            buttonDiscard.Visible = isVisible;
        }




        public void PresentDialog()
        {
            ShowDialog();
        }
    }
}

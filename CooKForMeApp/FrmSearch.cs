using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using CookForMe.Model;
using CookForMe.Model.Repositories;
using CookForMe.Controllers;

namespace CookForMeApp
{
    public partial class FrmSearch : Form, IShow
    {

        private readonly MainWindowController _mainController;

        private readonly List<string>         _searchCategories;

        private List<string>                  _selectedSearchCategories,
                                              _resultsDailyMenuData,
                                              _resultsIngredientsData;

        private Dictionary<string, string>    _resultRecipeData;


        private readonly string               _error;
        private string                        _text;



        public FrmSearch(MainWindowController mainController)
        {
            _mainController = mainController;

            _searchCategories = new List<string>();
            _selectedSearchCategories = new List<string>();
            FillSearchCategories();

            _resultsDailyMenuData = new List<string>();
            _resultsIngredientsData = new List<string>();
            _resultRecipeData = new Dictionary<string, string>();

            _error = "Error";
            _text = "";

            InitializeComponent();
        }



        private void FillSearchCategories()
        {
            _searchCategories.Add("Ingredients");
            _searchCategories.Add("Recipes");
            _searchCategories.Add("Daily menus");
        }



        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchParameters = textBoxSearchParameters.Text;

            _selectedSearchCategories = new List<string>();
            foreach (int checkedItemIndex in checkedListBoxSearchCategories.CheckedIndices)
            {
                var selectedCategory = checkedListBoxSearchCategories.Items[checkedItemIndex].ToString();
                _selectedSearchCategories.Add(selectedCategory);
                checkedListBoxSearchCategories.SetItemChecked(checkedItemIndex, false);
            }
            textBoxSearchParameters.Clear();

            _resultsDailyMenuData = new List<string>();
            _resultsIngredientsData = new List<string>();
            _resultRecipeData = new Dictionary<string, string>();

            _mainController.PerformSearch(_selectedSearchCategories, searchParameters);

            _resultRecipeData = _mainController.GetResultRecipeData();
            _resultsIngredientsData = _mainController.GetResultIngredientData();
            _resultsDailyMenuData = _mainController.GetResultMenuData();

            if (_resultRecipeData.Count == 0 && _resultsIngredientsData.Count == 0 && _resultsDailyMenuData.Count == 0)
            {
                _text = "Your search " + searchParameters + " - did not find any match";
                MessageBox.Show(_text);
                return;
            }

            UpdateIngredients();
            UpdateRecipes();
            UpdateMenus();

            SetResultsVisibility(true);
        }




        private void buttonShowIngredient_Click(object sender, EventArgs e)
        {
            if (listBoxIngredients.Items.Count == 0)
            {
                return;
            }
            if (listBoxIngredients.SelectedIndex == -1)
            {
                _text = "Select an ingredient!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedIngradientName = listBoxIngredients.SelectedItem.ToString();
            try
            {
                var ingredient =  _mainController.GetIngredientDetails(selectedIngradientName);

                var formShowIngredientDetails = new FrmShowIngredientDetails(ingredient);

                formShowIngredientDetails.ShowDialog();
            }
            catch (ItemNotFoundException)
            {
                _text = "Details not found, please select another ingredient!";
                MessageBox.Show(_text, _error,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void buttonShowRecipe_Click(object sender, EventArgs e)
        {
            if (listBoxRecipes.Items.Count == 0)
            {
                return;
            }
            if (listBoxRecipes.SelectedIndex == -1)
            {
                _text = "Select a recipe!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRecipeName = listBoxRecipes.SelectedItem.ToString();
            var selectedRecipeId = _resultRecipeData.Where(kvp => kvp.Value == selectedRecipeName)
                                                                .Select(kvp => kvp.Key).FirstOrDefault();
            try
            {
                var recipe = _mainController.GetRecipeDetails(selectedRecipeId);

                var formShowRecipeDetails = new FrmShowRecipeDetails(_mainController, recipe);

                formShowRecipeDetails.ShowDialog();
            }
            catch (ItemNotFoundException)
            {
                _text = "Details not found, please select another recipe!";
                MessageBox.Show(_text, _error,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void buttonShowDailyMenu_Click(object sender, EventArgs e)
        {
            if (listBoxDailyMenus.Items.Count == 0)
            {
                return;
            }
            if (listBoxDailyMenus.SelectedIndex == -1)
            {
                _text = "Select a daily recipe!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedMenuName = listBoxDailyMenus.SelectedItem.ToString();

            try
            {
                var dailyMenu = _mainController.GetDailyMenu(selectedMenuName);

                var formEditDailyMenu = new FrmEditDailyMenu(_mainController, dailyMenu);

                formEditDailyMenu.ShowDialog();
            }
            catch (ItemNotFoundException)
            {
                _text = "Details not found, please select another daily menu!";
                MessageBox.Show(_text, _error,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void FrmSearch_Load(object sender, EventArgs e)
        {
            SetSearchCaregoriesCheckBoxList();
            SetResultsVisibility(false);
        }

        public void UpdateView()
        {
            UpdateMenus();
        }


        private void SetResultsVisibility(bool isVisible)
        {
            labelDailyMenus.Visible = isVisible;
            listBoxDailyMenus.Visible = isVisible;
            buttonShowDailyMenu.Visible = isVisible;

            labelIngredients.Visible = isVisible;
            listBoxIngredients.Visible = isVisible;
            buttonShowIngredient.Visible = isVisible;

            labelRecipes.Visible = isVisible;
            listBoxRecipes.Visible = isVisible;
            buttonShowRecipe.Visible = isVisible;
        }


        private void SetSearchCaregoriesCheckBoxList()
        {
            foreach (var category in _searchCategories)
            {
                checkedListBoxSearchCategories.Items.Add(category);
            }
        }


        private void UpdateMenus()
        {
            _resultsDailyMenuData.Sort();

            var menuNamesFromRepository = MenuRepository.GetInstance().GetDailyMenuNames();

            var foundMenusNames = _resultsDailyMenuData.Where(menuNamesFromRepository.Contains).ToList();

            listBoxDailyMenus.DataSource = foundMenusNames;
            listBoxDailyMenus.SelectionMode = SelectionMode.One;
        }

        private void UpdateRecipes()
        {
            var recipeNames = _resultRecipeData.Values.ToList();

            recipeNames.Sort();
            listBoxRecipes.DataSource = recipeNames;
            listBoxRecipes.SelectionMode = SelectionMode.One;
        }

        private void UpdateIngredients()
        {
            _resultsIngredientsData.Sort();

            listBoxIngredients.DataSource = _resultsIngredientsData;
            listBoxIngredients.SelectionMode = SelectionMode.One;
        }




        public void PresentDialog()
        {
            ShowDialog();
        }
    }
}

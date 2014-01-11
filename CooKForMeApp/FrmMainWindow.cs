using System;
using System.Windows.Forms;

using CookForMe.Controllers;


namespace CookForMeApp
{
    public partial class FrmMainWindow : Form
    {
        private readonly MainWindowController _mainController;


        public FrmMainWindow(MainWindowController mainController)
        {
            _mainController = mainController;

            InitializeComponent();
        }



        //INGREDIENTS------------------------------------------------------------------------------------------------------

        private void viewIngredientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formShowIngredients = new FrmShowIngredients(_mainController);

            _mainController.ShowIngredients(formShowIngredients);
        }

        private void addNewIngredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAddIngredient = new FrmAddIngredient(_mainController);

            _mainController.AddIngredient(formAddIngredient);
        }




        //RECIPES--------------------------------------------------------------------------------------------------------
        
        private void addNewRecepieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAddRecipe = new FrmAddRecipe(_mainController);

            _mainController.AddRecepie(formAddRecipe);
        }

        private void viewRecepiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formShowRecipes = new FrmShowRecipes(_mainController);

            _mainController.ShowRecipes(formShowRecipes);
        }




        //DAILY MENUS------------------------------------------------------------------------------------------------------

        private void addNewDailyMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAddDailyMenu = new FrmAddDailyMenu(_mainController);

            _mainController.AddNewDailyMenu(formAddDailyMenu);
        }

        private void viewDailyMenusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formShowDailyMenus = new FrmShowDailyMenus(_mainController);

            _mainController.ShowDailyMenus(formShowDailyMenus);
        }

        private void generateDailyMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formGenerateDailyMenu = new FrmGenerateDailyMenu(_mainController);

            _mainController.CollectDataForMenuGeneration(formGenerateDailyMenu);
        }

       




        //SEARCH------------------------------------------------------------------------------------------------------

        private void searchButton_Click(object sender, EventArgs e)
        {
            var formSearch = new FrmSearch(_mainController);

            _mainController.Search(formSearch);
        }
    }
}

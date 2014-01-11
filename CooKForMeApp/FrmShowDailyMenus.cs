using System;
using System.Windows.Forms;

using CookForMe.Model;
using CookForMe.Model.Repositories;
using CookForMe.Controllers;

namespace CookForMeApp
{
    public partial class FrmShowDailyMenus : Form, IShow
    {

        private readonly MainWindowController _mainController;

        private readonly string               _error;
        private string                        _text;



        public FrmShowDailyMenus(MainWindowController mainController)
        {
            _mainController = mainController;

            _error = "Error";
            _text = "";

            InitializeComponent();
        }



        private void buttonEditMenu_Click(object sender, EventArgs e)
        {
            if (listBoxDailyMenus.SelectedIndex == -1)
            {
                _text = "Please select daily menu to edit!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var menuName = listBoxDailyMenus.SelectedItem.ToString();

            try
            {
                var menu = _mainController.GetDailyMenu(menuName);

                var formEditDailyMenu = new FrmEditDailyMenu(_mainController, menu);

                MealRepository.GetInstance().Attach(formEditDailyMenu);

                formEditDailyMenu.ShowDialog();

                MealRepository.GetInstance().Detach(formEditDailyMenu);
            }
            catch (ItemNotFoundException)
            {
                _text = "Daily menu not found! Please select another menu!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxDailyMenus.SelectedIndex == -1)
            {
                _text = "Please select daily menu to delete!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var menuName = listBoxDailyMenus.SelectedItem.ToString();
            try
            {
                _mainController.DeleteDailyMenu(menuName);
            }
            catch (ItemNotFoundException)
            {
                _text = "Daily menu not found! Please select another menu!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FrmShowDailyMenus_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        public void UpdateView()
        {
            UpdateList();
        }

        private void UpdateList()
        {
            var menus = MenuRepository.GetInstance().GetDailyMenuNames();

            menus.Sort();

            listBoxDailyMenus.DataSource = menus;
            listBoxDailyMenus.SelectionMode = SelectionMode.One;
        }

        

        public void PresentDialog()
        {
            ShowDialog();
        }
    }
}

using System;
using System.Windows.Forms;

using CookForMe.Model;
using CookForMe.Controllers;

namespace CookForMeApp
{
    public partial class FrmAddNewMeal : Form
    {

        private readonly MainWindowController _mainController;

        private readonly string _error;
        private string _text;



        public FrmAddNewMeal(MainWindowController mainController)
        {
            _mainController = mainController;

            _error = "Error";
            _text = "";

            InitializeComponent();
        }



        private void buttonAddNewMeal_Click(object sender, EventArgs e)
        {
            try
            {
                _mainController.AddMeal(textBoxName.Text, richTextBoxDescription.Text);
                Close();
            }
            catch (ItemAlreadyExistsException)
            {
                _text = "Meal with the given name already exists!";
                MessageBox.Show(_text, _error,
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ParemeterEmptyException)
            {
                _text = "Meal name is not set!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

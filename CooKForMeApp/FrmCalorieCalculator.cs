using System;
using System.Windows.Forms;

using CookForMe.Model;
using CookForMe.Controllers;

namespace CookForMeApp
{
    public partial class FrmCalorieCalculator : Form
    {
        private readonly MainWindowController _mainController;

        private readonly Food                 _ingredient;


        private readonly string               _error;
        private string                        _text; 




        public FrmCalorieCalculator(MainWindowController mainController, Food ingredient)
        {
            _mainController = mainController;

            _ingredient = ingredient;

            _error = "Error";
            _text = "";

            InitializeComponent();
        }




        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _mainController.CalculateCalories(textBoxAmountNumber.Text, _ingredient.GetDefaultAmount(),
                                                                _ingredient.GetEnergyValue());
                _text = "Result: " + result + " (kcal)";
                MessageBox.Show(_text);
            }
            catch (InvalidNumberEntryException)
            {
                _text = "Ingredient amount not not valid";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ParemeterNegativeOrZeroException exception)
            {
                MessageBox.Show(exception.GetMessage, _error,
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                textBoxAmountNumber.Clear();
            }
        }

        
        
        
        private void FrmCalorieCalculator_Load(object sender, EventArgs e)
        {
            labelIngredientName.Text = _ingredient.Name;

            _text = "Energy value (" + _ingredient.GetDefaultAmount() + " g): ";
            labelDefaultEnergyValue.Text = _text;

            _text = _ingredient.GetEnergyValue() + " (kcal)";
            labelEnergyValueNumber.Text = _text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using CookForMe.Controllers;
using CookForMe.Model;
using CookForMe.Model.Repositories;

namespace CookForMeApp
{
    public partial class FrmShowIngredients : Form, IShow
    {

        private readonly MainWindowController  _mainController;
                
        private readonly string                _error;
        private string                         _text; 



        public FrmShowIngredients(MainWindowController mainController)
        {
            _mainController = mainController;

            _error = "Error";
            _text = "";

            InitializeComponent();
        }



        private void buttonCalorieCalculator_Click(object sender, EventArgs e)
        {
            var node = treeViewIngredients.SelectedNode;

            if (node.Level == 1)
            {
                var ingredient = _mainController.GetIngredientDetails(node.Parent.Text, node.Text);

                var formCalorieCalculator = new FrmCalorieCalculator(_mainController, ingredient);
                formCalorieCalculator.ShowDialog();
            }
            else
            {
                _text = "Please select an ingredient!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonIngredientDetails_Click(object sender, EventArgs e)
        {
            var node = treeViewIngredients.SelectedNode;
            if (node.Level == 1)
            {
                try
                {
                    var ingredient = _mainController.GetIngredientDetails(node.Parent.Text, node.Text);

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
            else
            {
                _text = "Please select an ingredient!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmShowIngredients_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void UpdateList()
        {
            treeViewIngredients.Nodes.Clear();
            var foodTypes = FoodRepository.GetInstance().GetFoodTypes();

            var foodTypesNames = foodTypes.ToList();

            foodTypesNames.Sort();

            foreach(var foodType in foodTypesNames)
            {
                List<string> foodsByType;
                try
                {
                    foodsByType = FoodRepository.GetInstance().GetFoodNamesByType(foodType);
                }
                catch (ItemNotFoundException)
                {
                    continue;
                }
                foodsByType.Sort();

                var treeNode = new TreeNode(foodType, foodsByType.Select(foodName => new TreeNode(foodName)).ToArray());

                treeViewIngredients.Nodes.Add(treeNode);
            }
        }

        public void UpdateView()
        {
            UpdateList();
        }




        public void PresentDialog()
        {
            ShowDialog();
        }
    }
}

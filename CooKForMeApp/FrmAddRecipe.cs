using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using CookForMe.Controllers;
using CookForMe.Model;
using CookForMe.Model.Repositories;

namespace CookForMeApp
{
    public partial class FrmAddRecipe : Form, IShow
    {
        private readonly MainWindowController       _mainController;

        private readonly Dictionary<String, String> _selectedIngredients;
        private readonly Dictionary<String, String> _photoFilenamesCaptions;
        private readonly Dictionary<String, String> _photoFilenamesPaths;

        private bool                                _isInitializing;

        private readonly string                     _error;
        private string                              _text;



        public FrmAddRecipe(MainWindowController mainController)
        {
            _mainController = mainController;

            _selectedIngredients = new Dictionary<string, string>();
            _photoFilenamesCaptions = new Dictionary<string, string>();
            _photoFilenamesPaths = new Dictionary<string, string>();

            _isInitializing = true;

            _error = "Error";
            _text = "";

            InitializeComponent();
        }




        private void buttonAddNewMeal_Click(object sender, EventArgs e)
        {
            var formAddMeal = new FrmAddNewMeal(_mainController);

            formAddMeal.ShowDialog();
        }





        private void listBoxIngredientsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null == listBoxIngredientsList.SelectedItem || _isInitializing)
            {
                _isInitializing = false;
                return;
            }
            listBoxSelectedIngredients.SelectedIndex = -1;

            string selectedIngredient = listBoxIngredientsList.SelectedItem.ToString();

            if (!_selectedIngredients.Keys.Contains(selectedIngredient))
            {
                _selectedIngredients[selectedIngredient] = "";
            }
            else
            {
                richTextBoxDosage.Text = _selectedIngredients[selectedIngredient];
            }

            UpdateSelectedItemsList();

            richTextBoxDosage.SelectionStart = 0;
            richTextBoxDosage.SelectionLength = 0;
            richTextBoxDosage.Select();
        }




        private void buttonSaveDosage_Click(object sender, EventArgs e)
        {
            String ingredient;
            if (listBoxIngredientsList.SelectedIndex != -1)
            {
                ingredient = listBoxIngredientsList.SelectedItem.ToString();
                _selectedIngredients[listBoxIngredientsList.SelectedItem.ToString()] = richTextBoxDosage.Text;
            }
            else if (listBoxSelectedIngredients.SelectedIndex != -1)
            {
                ingredient = listBoxSelectedIngredients.SelectedItem.ToString();
                _selectedIngredients[listBoxSelectedIngredients.SelectedItem.ToString()] = richTextBoxDosage.Text;
            }
            else
            {
                _text = "Select an ingredient to dosage!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            richTextBoxDosage.Clear();

            _text = "Dosage description for ingredient: " + ingredient + " is saved!";
            MessageBox.Show(_text);
        }




        private void listBoxSelectedIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null == listBoxSelectedIngredients.SelectedItem)
            {
                return;
            }

            listBoxIngredientsList.SelectedIndex = -1;

            var selectedIngredient = listBoxSelectedIngredients.SelectedItem.ToString();

            richTextBoxDosage.Text = _selectedIngredients[selectedIngredient];

            richTextBoxDosage.SelectionStart = 0;
            richTextBoxDosage.SelectionLength = 0;
            richTextBoxDosage.Select();
        }




        private void buttonAddNewIngredient_Click(object sender, EventArgs e)
        {
            var formAddNewIngredient = new FrmAddIngredient(_mainController);

            _mainController.AddIngredient(formAddNewIngredient);
        }

        private void buttonRemoveSelectedIngredient_Click(object sender, EventArgs e)
        {
            if (listBoxSelectedIngredients.Items.Count == 0)
            {
                _text = "An ingredient must be selected before it can be removed!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedIngredient = listBoxSelectedIngredients.SelectedItem.ToString();

            _selectedIngredients.Remove(selectedIngredient);

            UpdateSelectedItemsList();
        }






        private void buttonPhotoUpload_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                _text = "Open Image";
                dlg.Title = _text;
                _text = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";
                dlg.Filter = _text;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var photoFilenamePath = dlg.FileName;
                    var photoNamePart = dlg.FileName.Split('\\');
                    var photoName = photoNamePart.Last();

                    if (!_photoFilenamesCaptions.ContainsKey(photoFilenamePath))
                    {
                        _photoFilenamesCaptions[photoFilenamePath] = "";
                        _photoFilenamesPaths[photoName] = photoFilenamePath;
                    }

                    UpdateFileNamesList();
                }
            }

            richTextBoxCaption.SelectionStart = 0;
            richTextBoxCaption.SelectionLength = 0;
            richTextBoxCaption.Select();
        }

        private void buttonSaveCaption_Click(object sender, EventArgs e)
        {
            if (listBoxFileNames.SelectedIndex == -1)
            {
                _text = "Select or upload a photo!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var photoFileNamePath = _photoFilenamesPaths[listBoxFileNames.SelectedItem.ToString()];
            _photoFilenamesCaptions[photoFileNamePath] = richTextBoxCaption.Text;

            richTextBoxCaption.Clear();
            listBoxFileNames.SelectedIndex = -1;

            _text = "Photo caption saved!";
            MessageBox.Show(_text);
        }




        private void listBoxFileNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null == listBoxFileNames.SelectedItem)
            {
                return;
            }

            var photoFileNamePath = _photoFilenamesPaths[listBoxFileNames.SelectedItem.ToString()];

            richTextBoxCaption.Text = _photoFilenamesCaptions[photoFileNamePath];

            richTextBoxCaption.SelectionStart = 0;
            richTextBoxCaption.SelectionLength = 0;
            richTextBoxCaption.Select();
        }

        private void richTextBoxCaption_TextChanged(object sender, EventArgs e)
        {
            if (listBoxFileNames.SelectedIndex != -1) return;

            _text = "Select or upload a photo!";
            MessageBox.Show(_text, _error,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }






        private void buttonAddRecepie_Click(object sender, EventArgs e)
        {
            var isAnyItemChecked = false;
            for (var i = 0; i < checkedListBoxMeals.Items.Count; i++)
            {
                if (!checkedListBoxMeals.GetItemChecked(i)) continue;
                isAnyItemChecked = true;
                var mealName = checkedListBoxMeals.Items[i].ToString();
                try
                {
                    _mainController.CreateNewRecipe(textBoxName.Text, mealName, i, _selectedIngredients,
                                                    richTextBoxPreparation.Text, _photoFilenamesCaptions);
                }
                catch (ItemNotFoundException)
                {
                    _text = "Meal: " + mealName + " isn't defined!";
                    MessageBox.Show(_text, _error,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (ParemeterEmptyException)
                {
                    _text = "One or more mandatory paremeters left empty!";
                    MessageBox.Show(_text, _error,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (ItemAlreadyExistsException)
                {
                    _text = "Recepie: " + textBoxName.Text + " is already defined for meal: " + mealName + "!";
                    MessageBox.Show(_text, _error,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!isAnyItemChecked)
            {
                _text = "At least one meal must be selected for a recepie!";
                MessageBox.Show(_text, _error,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }





        private void FrmAddRecipe_Load(object sender, EventArgs e)
        {
            _isInitializing = true;

            UpdateSelectedItemsList();
            UpdateFileNamesList();

            UpdateLists();
        }

        public void UpdateView()
        {
            UpdateLists();
        }

        private void UpdateLists()
        {
            listBoxIngredientsList.DataSource = null;
            var foosdName = FoodRepository.GetInstance().GetFoodsName();
            foosdName.Sort();
            listBoxIngredientsList.DataSource = foosdName;
            listBoxIngredientsList.SelectionMode = SelectionMode.One;
            listBoxIngredientsList.SelectedIndex = -1;

            checkedListBoxMeals.DataSource = null;
            var mealsName = MealRepository.GetInstance().GetMealsName();
            mealsName.Sort();
            checkedListBoxMeals.DataSource = mealsName;
        }

        private void UpdateSelectedItemsList()
        {
            listBoxSelectedIngredients.DataSource = null;
            var selectedIngredients = _selectedIngredients.Keys.ToList();
            selectedIngredients.Sort();
            listBoxSelectedIngredients.DataSource = selectedIngredients;
            listBoxSelectedIngredients.SelectionMode = SelectionMode.One;
        }

        private void UpdateFileNamesList()
        {
            listBoxFileNames.DataSource = null;
            var filenames = _photoFilenamesPaths.Keys.ToList();
            filenames.Sort();

            listBoxFileNames.DataSource = filenames;
            listBoxFileNames.SelectionMode = SelectionMode.One;
        }



        public void PresentDialog()
        {
            ShowDialog();
        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;

using CookForMe.Model.Repositories;
using CookForMe.Model;
using CookForMe.Controllers;

namespace CookForMeApp
{
    public partial class FrmAddIngredient : Form, IShow
    {
        private readonly MainWindowController _mainController;

        private String                        _photoName;

        private readonly string               _error;
        private string                        _text; 


        public FrmAddIngredient(MainWindowController mainController)
        {
            _mainController = mainController;

            _photoName = "";

            _error = "Error";
            _text = "";

            InitializeComponent();
        }




        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            var ingredientCategory = listBoxIngredientCategory.SelectedIndex == -1 ? textBoxAddNewICategory.Text : 
                                                                                        listBoxIngredientCategory.Text;

            try
            {
                _mainController.CreateNewIngredient(textBoxName.Text, richTextBoxDescription.Text, ingredientCategory,
                                                    textBoxNVEnergy.Text, textBoxNVamount.Text, textBoxNVprotein.Text,
                                                    textBoxNVfat.Text, _photoName, richTextBoxCaption.Text);
                Close();
            }
            catch (ParemeterEmptyException)
            {
                _text = "One or more of the demanded parameters is not set!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidNumberEntryException)
            {
                _text = "One or more parameters is invalid!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ParemeterNegativeOrZeroException negOrZeroException)
            {
                MessageBox.Show(negOrZeroException.GetMessage, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidNutritionFactAmountException invalidNvAmount)
            {
                MessageBox.Show(invalidNvAmount.GetMessage, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ItemAlreadyExistsException)
            {
                _text = "Ingredient with the speciffied name already exists: " + textBoxName.Text;
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (PhotoNotUploadedException)
            {
                _text = "Photo caption is set, but photo is not uploaded!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                _text = "Open Image";
                dlg.Title = _text;
                _text = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";
                dlg.Filter = _text;

                if (dlg.ShowDialog() != DialogResult.OK) return;
                _photoName = dlg.FileName;

                var photoNameParts = _photoName.Split('\\');
                labelPictureFileName.Text = photoNameParts.Last();
                labelPictureFileName.Visible = true;
            }
        }



        private void textBoxAddNewICategory_TextChanged(object sender, EventArgs e)
        {
            listBoxIngredientCategory.ClearSelected();
        }



        private void FrmAddIngredient_Load(object sender, EventArgs e)
        {
            labelPictureFileName.Visible = false;
            UpdateList();
        }

        private void UpdateList()
        {
            listBoxIngredientCategory.DataSource = null;
            listBoxIngredientCategory.DataSource = FoodRepository.GetInstance().GetFoodTypes().ToList();
            listBoxIngredientCategory.SelectionMode = SelectionMode.One;
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

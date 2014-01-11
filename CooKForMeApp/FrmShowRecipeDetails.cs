using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using CookForMe.Model;
using CookForMe.Controllers;

namespace CookForMeApp
{
    public partial class FrmShowRecipeDetails : Form
    {

        private readonly MainWindowController _mainController;
        private readonly Recipe               _recipe;

        private readonly string               _error;
        private string                        _text;

        private bool                          _isInitializing;


        public FrmShowRecipeDetails(MainWindowController mainController, Recipe recipe)
        {
            _mainController = mainController;
            _recipe = recipe;

            _isInitializing = true;

            _error = "Error";
            _text = "";

            InitializeComponent();
        }




        private void listBoxFilenamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (null == listBoxFilenamesList.SelectedItem || _isInitializing)
            {
                _isInitializing = false;
                return;
            }

            labelPhoto.Visible = true;
            labelPhotoCaption.Visible = true;

            var photoFilenameShort = listBoxFilenamesList.SelectedItem.ToString();

            try
            {
                var photo = _recipe.GetImageFromSortFilename(photoFilenameShort);
                pictureBoxPhoto.Image = Image.FromFile(photo.Filename);

                pictureBoxPhoto.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBoxPhoto.Visible = true;

                labelPhotoCaption.Text = photo.Caption;

                labelPhotoCaption.Top = pictureBoxPhoto.Bottom;
            }
            catch (FileNotFoundException)
            {
                _text = "Photo not found, please select another photo!";
                MessageBox.Show(_text, _error,
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ItemNotFoundException)
            {
                _text = "Photo not found, please select another photo!";
                MessageBox.Show(_text, _error,
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void buttonShowIngredientDetails_Click(object sender, EventArgs e)
        {
            if (listBoxIngredients.SelectedIndex == -1)
            {
                _text = "Select an ingredient from list!";
                MessageBox.Show(_text, _error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var ingredientWithDosage = listBoxIngredients.SelectedItem.ToString();
                var ingredientParts = ingredientWithDosage.Split(',');

                var ingredientName = ingredientParts[0];

                var ingredient = _mainController.GetIngredientDetails(ingredientName);

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




        private void FrmShowRecipeDetails_Load(object sender, EventArgs e)
        {
            labelRecipeName.Text = _recipe.Name;

            richTextBoxPreparation.Text = _recipe.Preparation;
            richTextBoxPreparation.ReadOnly = true;

            pictureBoxPhoto.Visible = false;
            labelPhotoCaption.Visible = false;
            labelPhoto.Visible = false;

            _isInitializing = true;

            FillLists();
        }

        private void FillLists()
        {
            listBoxIngredients.DataSource = _recipe.GetIngredientsList();
            listBoxIngredients.SelectionMode = SelectionMode.One;

            listBoxFilenamesList.DataSource = _recipe.GetImagesFilenamesShort();
            listBoxFilenamesList.SelectionMode = SelectionMode.One;
            listBoxFilenamesList.Visible = true;
        }
    }
}

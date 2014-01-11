using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

using CookForMe.Model;

namespace CookForMeApp
{
    public partial class FrmShowIngredientDetails : Form
    {
        private readonly Food   _ingredient;

        private string          _text; 


        public FrmShowIngredientDetails(Food ingredient)
        {
            _ingredient = ingredient;

            _text = "";

            InitializeComponent();
        }




        private void FrmShowIngredientDetails_Load(object sender, EventArgs e)
        {
            labelNameText.Text = _ingredient.Name;
            labelCategoryText.Text = _ingredient.FoodType;

            _text = "Nutrition values " + "(" + _ingredient.GetDefaultAmount() + " g): ";

            labelNV.Text = _text;

            labelEnergyValue.Text = _ingredient.GetEnergyValue().ToString(CultureInfo.InvariantCulture);
            labelProteinValue.Text = _ingredient.GetProteinAmount().ToString(CultureInfo.InvariantCulture);
            labelFatValue.Text = _ingredient.GetFatAmount().ToString(CultureInfo.InvariantCulture);

            richTextBoxDescription.Text = _ingredient.Description;
            richTextBoxDescription.ReadOnly = true;

            if (_ingredient.IsImageSet())
            {
                try
                {
                    pictureBox.Image = Image.FromFile(_ingredient.Image.Filename);
                }
                catch (FileNotFoundException)
                {
                }
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox.Visible = true;

                labelPhotoCaption.Top = pictureBox.Bottom;

                labelPhotoCaption.Text = _ingredient.Image.Caption;
                labelPhotoCaption.Visible = true;
            }
            else
            {
                pictureBox.Visible = false;
                labelPhotoCaption.Visible = false;
            }
        }
    }
}

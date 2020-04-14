using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amporis.Xamarin.Forms.ColorPicker;
using Xamarin.Forms;

namespace ColorPickerExemplo
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private Color editedColor = Color.FromHex("#FFFF8000");

        public Color EditedColor
        {
            get => editedColor;
            set { editedColor = value; OnPropertyChanged(); }
        }

        async void popup_Clicked(System.Object sender, System.EventArgs e)
        {
            var color = await ColorPickerDialog.Show(principal, "ColorPickerDialog", Color.White, null);
        }
    }
}

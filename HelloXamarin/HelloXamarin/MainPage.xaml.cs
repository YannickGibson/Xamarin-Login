using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            if (Password.Text.Length < 8)
            {
                Application.Current.MainPage.DisplayAlert("Warning", "Password must have more than 8 characters", "Ok");
            }
            else if (Password.Text == "heslo123")
            {
                Application.Current.MainPage.DisplayAlert("Hello", Name.Text + " " + Password.Text, "Ok");
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Wrong password", "Wrong password", "Ok");
            }
        }
    }
}

using ProyectoFinalXamrin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinalXamrin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Entry_Username.Text = "";
            Entry_Password.Text = "";
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroudColor;
            Label_Username.TextColor = Constants.MainTextColor;
            Label_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_Username.Completed += (sender, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SingIn(s, e);


        }

        void SingIn(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "Ok");
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct, Check your Username or Paswword", "Ok");

            }
        }
        
    }
}
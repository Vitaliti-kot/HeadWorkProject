using System;
using Xamarin.Forms;

namespace HeadWorkProject.View
{
    public partial class MainPage : ContentPage
    {
        Entry _entryLogin;
        Entry _entryPassword;
        public MainPage()
        {
            InitializeComponent();
            this.Content.BackgroundColor = Color.LightBlue;
            this.UpdateChildrenLayout();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Command = buttonSign.Command;
            buttonSignUp.GestureRecognizers.Add(tap);
        }
        private void Tap_Tapped(object sender, EventArgs e)
        {
        }



        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void EntryLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            _entryLogin = entryLogin;
            Enabled_Disabled_Button();
        }

        private void EntryPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            _entryPassword = entryPassword;
            Enabled_Disabled_Button();
        }

        private void Enabled_Disabled_Button()
        {
            try
            {
                if (entryLogin.Text.Length > 4 && entryPassword.Text.Length > 4)

                {
                    buttonAutorization.IsEnabled = true;
                }
                else
                {
                    buttonAutorization.IsEnabled = false;
                }
            }
            catch
            {

            }

        }
        private void CheckInputData()
        {

        }
    }
}
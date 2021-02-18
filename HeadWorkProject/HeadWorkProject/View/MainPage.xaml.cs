using System;
using Xamarin.Forms;
using Prism.Navigation;
using System.Threading.Tasks;

namespace HeadWorkProject.View
{
    public partial class MainPage : ContentPage
    { 
        Entry entryLogin;
        Entry entryPassword;
        Button buttonLogIn;
        public MainPage()
        {
            InitializeComponent();
            buttonLogIn = new Button()
            {
                Text = "Авторизоваться",
                BackgroundColor = Color.Blue.WithSaturation(0.1),
                TextColor = Color.Lime,
                Opacity = 0.6,
                AnchorY = 10,
                IsEnabled = false
            };

            buttonLogIn.Clicked += Button_Clicked;
            entryLogin = new Entry()
            {
                Margin = 25,
                FontSize = 15,
                Placeholder = "введите логин",
                MaxLength = 16
            };
            entryLogin.TextChanged += EntryLogin_TextChanged;

            entryPassword = new Entry()
            {
                Margin = 25,
                FontSize = 15,
                Placeholder = "введите пароль",
                IsPassword = true,
                MaxLength = 16
            };
            entryPassword.TextChanged += EntryPassword_TextChanged;

            Label label = new Label()
            {
                Text = "Авторизация",
                TextColor = Color.Lime,
                BackgroundColor = Color.Blue,
                FontSize = 24,
                Margin = 10,
                Padding = 15,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                TextDecorations = TextDecorations.Underline
            };

            Label buttonSignUp = new Label()
            {
                Text = "ЗАРЕГЕСТРИРОВАТЬСЯ",
                TextColor = Color.Blue,
                TextDecorations = TextDecorations.Underline,
                FontSize = buttonLogIn.FontSize,
                HorizontalTextAlignment = TextAlignment.Center,
                Margin = 10
            };
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            StackLayout stack = new StackLayout();
            stack.Children.Add(label);
            stack.Children.Add(entryLogin);
            stack.Children.Add(entryPassword);
            stack.Children.Add(buttonLogIn);
            stack.Children.Add(buttonSignUp);
            buttonSignUp.GestureRecognizers.Add(tap);
            this.Content = stack;
            this.Content.BackgroundColor = Color.LightBlue;
            this.UpdateChildrenLayout();
        }
        private async void Tap_Tapped(object sender, EventArgs e)
        {
            //NavigationPage page = new NavigationPage();
            //await page.Navigation.PushAsync(new PageSignUp());
            //DisplayAlert(Title = "", message: "Неверный ввод данных...", cancel: "OK");
            // await service.NavigateAsync($"{nameof(PageSignUp)}");
           // N
        }



        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void EntryLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            Enabled_Disabled_Button();
        }

        private void EntryPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            Enabled_Disabled_Button();
        }

        private void Enabled_Disabled_Button()
        {
            try
            {
                if (entryLogin.Text.Length > 4 && entryPassword.Text.Length > 4)
                {
                    buttonLogIn.IsEnabled = true;
                }
                else
                {
                    buttonLogIn.IsEnabled = false;
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
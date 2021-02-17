using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HeadWorkProject
{
    public class FirstPage : ContentPage
    {
        public FirstPage()
        {
            Button buttonLogIn = new Button()
            {
                Text = "Авторизоваться",
                BackgroundColor = Color.Blue.WithSaturation(0.1),
                TextColor = Color.Lime,
                Opacity = 0.6,
                AnchorY = 10,
                IsEnabled = false
            };
            buttonLogIn.Clicked += Button_Clicked;
            Entry entryLogin = new Entry()
           {
               Margin = 25,
               FontSize = 15,
               Placeholder = "введите логин",
               MaxLength=16
           };
            entryLogin.TextChanged += EntryLogin_TextChanged;

            Entry entryPassword = new Entry()
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
                Text = "Зарегистрироваться",
                TextColor = Color.Blue,
                TextDecorations = TextDecorations.Underline,
                FontSize = buttonLogIn.FontSize
            };
            StackLayout stack = new StackLayout();
            stack.Children.Add(label);
            stack.Children.Add(entryLogin);
            stack.Children.Add(entryPassword);
            stack.Children.Add(buttonLogIn);
            stack.Children.Add(buttonSignUp);
            this.Content = stack;
            this.Content.BackgroundColor = Color.LightBlue;
           this.UpdateChildrenLayout();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EntryLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EntryPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
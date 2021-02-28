using HeadWorkProject.View;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace HeadWorkProject.ViewModel
{
   public class MainPageViewModel : BindableBase, INavigationAware, IDestructible
    {
        private string _login;
        private string _password;
        public string Login
        {
            get { return _login; }
            set
            {
                SetProperty(ref _login, value);
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                SetProperty(ref _password, value);
            }
        }
        public void Destroy()
        {
            throw new System.NotImplementedException();
        }

        public ICommand ButtonLogin => new Command(TapButtonLogin);

        private void TapButtonLogin(object obj)
        {
            //throw new NotImplementedException();
        }

        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand => _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        private readonly INavigationService _navigationService;
        async void ExecuteNavigateCommand()
        {
          await _navigationService.NavigateAsync($"{nameof(PageSignUp)}");
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            Login = parameters.GetValue<string>(nameof(_login));

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Login = parameters.GetValue<string>(nameof(_login));
        }
        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}

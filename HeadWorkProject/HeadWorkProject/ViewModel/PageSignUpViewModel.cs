using Acr.UserDialogs;
using HeadWorkProject.Srvices;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;
using Xamarin.Forms;

namespace HeadWorkProject.ViewModel
{
    public class PageSignUpViewModel : BindableBase, INavigationAware, IDestructible
    {
        private string _login;
        private string _password1;
        private string _password2;
        public string Login
        {
            get { return _login; }
            set
            {
                SetProperty(ref _login, value);
            }
        }

        public string Password1
        {
            get { return _password1; }
            set
            {
                SetProperty(ref _password1, value);
            }
        }
        public string Password2
        {
            get { return _password2; }
            set
            {
                SetProperty(ref _password2, value);
            }
        }

        public ICommand ButtonSignInCommand => new Command(OnButtonCommand);

        private void OnButtonCommand(object obj)
        {
            
            var check = new ChekingLogin().CheckLogin(Login);
             if (check != null) UserDialogs.Instance.ShowError(check,2000);
        }

        public void Destroy()
        {
            throw new System.NotImplementedException();
        }

        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateToMainPage => _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        private readonly INavigationService _navigationService;
        private void ExecuteNavigateCommand()
        {
            var v = new ChekingLogin();
            if (v.CheckLogin(Login) != null)
            {
                UserDialogs.Instance.ShowError(v.CheckLogin(Login));
            }
            else
            {
                if (v.CheckPassword(Password1) != null)
                {
                    UserDialogs.Instance.ShowError(v.CheckPassword(Password1));
                }
                else
                {

                    ReturnToPageSignIn();
                }
            }
        }

        async void ReturnToPageSignIn()
        {
            var param = new NavigationParameters();
            param.Add(nameof(_login), Login);
            await _navigationService.GoBackAsync(param);
        }
        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }
        public PageSignUpViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}

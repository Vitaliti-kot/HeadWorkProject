using Acr.UserDialogs;
using HeadWorkProject.Srvices;
using HeadWorkProject.Srvices.Repository;
using HeadWorkProject.View;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;
using Xamarin.Forms;

namespace HeadWorkProject.ViewModel
{
    public class PageSignUpViewModel : BindableBase, INavigationAware, IDestructible
    {
        private string _login="";
        private string _password1="";
        private string _password2="";
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

        public void Destroy()
        {
            throw new System.NotImplementedException();
        }

        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateToMainPage => _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        private INavigationService _navigationService;
        private void ExecuteNavigateCommand()
        {
            var repos = new Repository();
            var newUser = new Users(repos);
            var v = new ChekingLogin(newUser, repos);
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
                    AddNewUser(newUser);
                }
            }
        }

        private void AddNewUser(Users users)
        {
            users.AddUser(Login, Password1);
            ReturnToPageSignIn();
        }
        public async void ReturnToPageSignIn()
        {
            var parameters = new NavigationParameters();
            parameters.Add(nameof(Login), Login);
            await _navigationService.NavigateAsync($"{nameof(MainPage)}",parameters);

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

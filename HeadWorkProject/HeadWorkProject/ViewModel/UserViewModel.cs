using Prism.Mvvm;

namespace HeadWorkProject.ViewModel
{
    public class UserViewModel : BindableBase
    {
        private string _login;
        private string _password;
        public UserViewModel()
        {
        }
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
    }
}

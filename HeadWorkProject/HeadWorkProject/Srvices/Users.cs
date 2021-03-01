using HeadWorkProject.Model;
using HeadWorkProject.Srvices.Repository;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace HeadWorkProject.Srvices
{
    public class Users:BindableBase,IInitializeAsync
    {
        private IRepository _repository;

        public ObservableCollection<User> _users;

        public ObservableCollection<User> AllUsers
        {
            get => _users;
            set => SetProperty(ref _users, value);
        }
        public Users(IRepository repository)
        {
            _repository = repository;
        }

        public async Task InitializeAsync(INavigationParameters parameters)
        {
            var usersList = await _repository.GetAllAsync<User>();
            AllUsers = new ObservableCollection<User>(usersList);
        }

        public async void AddUser(string login, string password)
        {
            var newUser = new User();
            newUser.Login = login;
            newUser.Password = password;
            var id = await _repository.InsertAsync(newUser);
            newUser.Id = id;
            AllUsers.Add(newUser);
        }
    }
}

using HeadWorkProject.View;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;

namespace HeadWorkProject.ViewModel
{
    public class PageSignUpViewModel: BindableBase, INavigationAware, IDestructible
    {
        public void Destroy()
        {
            throw new System.NotImplementedException();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new System.NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}

using HeadWorkProject.Srvices.Setings;
using HeadWorkProject.View;
using HeadWorkProject.ViewModel;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;

namespace HeadWorkProject
{
    public partial class App : PrismApplication
    {
        public App()
        {
        }
        #region --- Overrides---
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance<ISettingsManager>(Container.Resolve<SettingsManager>());
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<PageSignUp>();

        }
        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync($"{nameof(MainPage)}");
        }
        #endregion
    }
}

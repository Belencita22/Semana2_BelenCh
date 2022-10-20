using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana2_BelenCh
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Login1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

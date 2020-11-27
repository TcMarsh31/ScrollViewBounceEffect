using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BounceEffect
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BounceTabbedPage();
            //sd
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

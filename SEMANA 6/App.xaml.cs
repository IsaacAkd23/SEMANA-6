using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEMANA_6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            var parametros = new System.Collections.Specialized.NameValueCollection();

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

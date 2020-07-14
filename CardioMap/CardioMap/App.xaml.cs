using CardioMap.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CardioMap
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //TODO - Modificar MainPage en caso de cambiar la primera Vista a mostar al abrir la app
            MainPage = new NavigationPage(new PerfilOpciones());
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

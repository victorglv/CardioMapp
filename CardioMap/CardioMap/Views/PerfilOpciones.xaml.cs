using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CardioMap.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PerfilOpciones : ContentPage
    {
        public PerfilOpciones()
        {
            InitializeComponent();
        }

        private void OnButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Perfil());
        }
    }
}
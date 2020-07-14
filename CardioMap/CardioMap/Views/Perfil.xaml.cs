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
    public partial class Perfil : ContentPage
    {
        public User NuevoUsuario { get; set; }

        public Perfil()
        {
            NuevoUsuario = new User();
            NuevoUsuario.Name = "Victor";
            NuevoUsuario.LastName = "Garcia";
            NuevoUsuario.DNI = "50906816L";
            NuevoUsuario.PhoneNumber = 675652398;
            NuevoUsuario.Email = "victorglv02@gmail.com";
            BindingContext = NuevoUsuario;
            InitializeComponent();
        }
    }
}
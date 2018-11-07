using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tearamisu.Mobile.Droid.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginViewModel : ContentPage
    {
        public LoginViewModel()
        {
            InitializeComponent();
        }
    }
}
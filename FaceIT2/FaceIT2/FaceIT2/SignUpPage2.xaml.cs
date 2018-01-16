using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FaceIT2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage2 : ContentPage
    {
        public SignUpPage2()
        {
            InitializeComponent();
        }

        async private void Button_CreateAcount(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
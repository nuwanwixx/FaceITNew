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
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        /*  async void Button_CreateAcc(object sender, EventArgs e)
          {
              await Navigation.PushModalAsync(new ProfilePage());

          }
          */

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
           
        }

       async private void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage2());
        }

         
    }
}
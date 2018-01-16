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
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }


       async void Button_Login(object sender, EventArgs e)
        {
            var email = EmailEntry.Text;

            if (email.Contains("@") & email.Contains(".com"))
            {
                await Navigation.PushAsync(new ProfilePage());
            }

            else {
                ErrorLabel.Text = "Email is not valid";
            }
        }


        async private void Button_ForgetPassword(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgetPasswordPage());
        }


    }
}
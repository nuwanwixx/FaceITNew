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
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            profile.Source = ImageSource.FromResource("FaceIT2.Images.beardface.png");
           myList.ItemsSource = new List<Contact> {
               new Contact {Name ="Description", Status ="Description about user goes here. User can edit this description at any time he wants.", ImageUrl = "http://lorempixel.com/100/100/people/1/" },
            new Contact { Name = "Designation", Status = "Software Engineer", ImageUrl = "http://lorempixel.com/100/100/people/2/" }
           };
           
        }
    }
}
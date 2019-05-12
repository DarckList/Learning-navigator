using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Learn_Navigation
{
    public partial class Login_Activity : ContentPage
    {
        public static string userName;
        public static string userSurname;
        public Login_Activity()
        {
            InitializeComponent();
        }

        private async void ChoiceSubjects_Clicked(object sender, EventArgs e)
        {
            if (Name.Text!=null && Name.Text !="Name" && Surname.Text!=null && Surname.Text != "Surname" )
            { 
                await Navigation.PushModalAsync(new Feedback_Activity());
            }
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            userName = Name.Text;
        }

        private void Surname_TextChanged(object sender, TextChangedEventArgs e)
        {
            userSurname = Surname.Text;
        }
    }
}

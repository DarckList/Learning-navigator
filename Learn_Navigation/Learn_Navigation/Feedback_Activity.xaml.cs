using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XLabs.Forms.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Learn_Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Feedback_Activity : ContentPage
	{
        private string[] qaString = { "qa1", "qa2", "qa3", "qa4" };
        private string[] devOpsString = { "devOps1", "devOps2", "devOps3", "devOps4" };
        
        public static string spesializationString;
        public static string subjecktString;
        public static string pullToCourseString;

        public Feedback_Activity ()
		{
			InitializeComponent ();
            questionWithName.Text = String.Format("Яку спеціалізацію ти обираєш, {0}?", Login_Activity.userName);
            
            ansPicker.ItemsSource = new[]
            {
                "QA",
                "DevOps",
            };
        }


        private void ansPicker_CheckedChanged(object sender, int e)
        {
            var radio = sender as CustomRadioButton;
            questionWithSubj.Text = String.Format("Що б ти хотів включити в {0} ?",radio.Text);
            spesializationString = radio.Text;
            if (radio.Text == "QA")
            {
                propPicker.IsVisible = true;
                chbLab.IsVisible = true;
                propPicker.ItemsSource = qaString;
               
            }
            else
            {
                propPicker.IsVisible = false;
                chbLab.IsVisible = false;
                subjecktString = "";
            }
        }

        private async void BtnImage_Clicked(object sender, EventArgs e)
        {
            if (chbLecturi.Checked) pullToCourseString = chbLecturi.Text;
            if (chbLecturi.Checked) pullToCourseString += ", "+chbPractic.Text;
            if (chbLecturi.Checked) pullToCourseString += ", "+chbLab.Text;
            await Navigation.PushModalAsync(new Receive_Activity());
        }

        private void PropPicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            subjecktString = String.Format("та обрав предмет: {0}",propPicker.SelectedItem);
        }
    }
}
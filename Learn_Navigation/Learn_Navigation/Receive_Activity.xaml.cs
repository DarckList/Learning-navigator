using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Learn_Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Receive_Activity : ContentPage
	{
		public Receive_Activity ()
		{
			InitializeComponent ();

            lbRezult.Text = String.Format("Студент: {0} {1} обрав спеціалізацію: {2} {3}." +
                        " Захотів включити в курс: {4}.",Login_Activity.userName, Login_Activity.userSurname,
                        Feedback_Activity.spesializationString, Feedback_Activity.subjecktString ,Feedback_Activity.pullToCourseString);
		}
	}
}
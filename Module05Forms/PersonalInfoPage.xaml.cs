using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace Module05Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalInfoPage : ContentPage
    {
        public PersonalInfoPage()
        {
            InitializeComponent();

            middleNameEntry.IsEnabled = middleNameSwitch.IsToggled;
            middleNameSwitch.Toggled += (sender, e) =>
            {
                middleNameEntry.IsEnabled = e.Value;
            };

            passwordEntry.IsPassword = true;
            repeatPasswordEntry.IsPassword = true;
        }

        private void BirthdatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime birthDate = birthdatePicker.Date;
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - birthDate.Year;
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }
            ageLabel.Text = age.ToString();
        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}


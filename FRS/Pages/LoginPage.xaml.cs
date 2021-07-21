
using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace FRS.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        /* public bool grayButton(Button button)
         {
             var email = EmailEntry.Text;
             var password = PasswordEntry.Text;

             if (email.Contains("@") & password.Length > 6)
             {
                 return button.IsEnabled = true;
             }
             else
             {
                 return button.IsEnabled = false;
             }
         }
     }

       */

        public void EntryButton_Clicked(System.Object sender, System.EventArgs e)
        {
            var email = EmailEntry.Text;
            var password = PasswordEntry.Text;

            var emailpattern = @"^\S+@\S+\.\S+$";

            if (email != null)
            {
                if (Regex.Match(email, emailpattern).Success)
                {
                    LableError.Text = "Email is valid";
                }
                else
                {
                    LableError.Text = "Email is not valid";
                }
            }
            else
            {
                LableError.Text = "You dont write email";
            }


            if (password != null)
            {
                if (password.Length > 6)
                {
                    LableErrorForPassword.Text = "Password is valid";
                }
                else
                {
                    LableErrorForPassword.Text = "Password is not valid";
                }
            }
            else
            {
                LableErrorForPassword.Text = "You dont write password";
            }

            if (email != null & password != null)
            {
                if (Regex.Match(email, emailpattern).Success & password.Length > 6)
                {
                    Navigation.PushAsync(new Page2());
                }
            }
        }
    }

    public class Model
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }


}
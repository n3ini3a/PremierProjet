using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace CRMMOBILE.ViewModels
{
    public class LoginViewModel: INotifyPropertyChanged
    {
       
        public event PropertyChangedEventHandler PropertyChanged = delegate {};
        public Action DisplayInvalidLoginPrompt;
        private string emailAddress;
        public string EmailAdress
        {
                get{
                return emailAddress;
                }
                set{
                emailAddress = value;
                PropertyChanged(this, new PropertyChangedEventArgs("EmailAdress"))
                    
                }
        }
        private string password;
        public string Password
        {
            get{
                return password;
            }
            set{
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }

        public void OnSubmit(){
            if ()
                DisplayInvalidLoginPrompt();
        }



    }
}

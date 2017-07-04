﻿using System;
using System.Collections.Generic;
using CRMMOBILE.Entities;
using CRMMOBILE.ViewModels;
using Xamarin.Forms;

namespace CRMMOBILE
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            var vm = new LoginViewModel();
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt +=()=>DisplayAlert("sorry","The credential you supplied are Invalid","Ok")
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //User user = new User(userName:TextCell, passwordEntry.Text);



        }
    }
}

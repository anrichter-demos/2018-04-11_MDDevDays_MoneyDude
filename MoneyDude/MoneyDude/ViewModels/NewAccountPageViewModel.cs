﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace MoneyDude.ViewModels
{
    public class NewAccountPageViewModel : ViewModelBase
    {
        public NewAccountPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Creat a new Account";
        }
    }
}

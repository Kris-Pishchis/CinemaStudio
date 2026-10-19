using CinemaStudio.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace CinemaStudio.ViewModel
{
    public partial class MenuViewModel : ObservableObject
    {
        private readonly WindowService _windowService = new WindowService();
        [RelayCommand]
        private void winStaff(System.Windows.Window currentWindow)
        {
            var staffWin = new CinemaStudio.View.StaffWindow();
            _windowService.SwitchWindow(staffWin, currentWindow);
        }
    }
}

using CinemaStudio.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;


namespace CinemaStudio.Services
{
    public class WindowService
    {
        public void SwitchWindow(Window windowToOpen, Window windowToClose)
        {
            windowToOpen?.Show();
            windowToClose?.Close();
        }
    }
}

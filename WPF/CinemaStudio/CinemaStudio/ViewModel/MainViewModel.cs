using CinemaStudio.Model;
using CinemaStudio.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace CinemaStudio.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly WindowService _windowService = new WindowService();
        [ObservableProperty]
        private string _inputLogin = string.Empty;

        [ObservableProperty]
        private string _inputPassword = string.Empty;
        public MainViewModel()
        {
            
        }
        [RelayCommand]
        private void Login(System.Windows.Window currentWindow)
        {
            if (string.IsNullOrWhiteSpace(InputLogin) || string.IsNullOrWhiteSpace(InputPassword))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка");
                return;
            }

            using (var db = new Model.ApplicationContext())
            {
                bool userExists = db.AccessRights.Any(x => x.Login == InputLogin && x.Password == InputPassword);

                if (userExists)
                {
                    MessageBox.Show("Авторизация успешна!");
                    var menuWin = new CinemaStudio.View.MenuWindow();
                    _windowService.SwitchWindow(menuWin, currentWindow);
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
            }
        }

    }
}

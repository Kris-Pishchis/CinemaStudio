using CinemaStudio.Model;
using CinemaStudio.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CinemaStudio.ViewModel
{
    public partial class StaffViewModel
    {
        private ApplicationContext _db = new ApplicationContext();
        private readonly WindowService _windowService = new WindowService();

        public ObservableCollection<Staff> StaffList { get; set; } = new();
        public StaffViewModel()
        {
            LoadData();
        }
        private void LoadData()
        {
            var list = _db.Staffs
                     .Include(e => e.AccessRight)
                     .Include(x => x.Rule)
                     .ToList();

            StaffList = new ObservableCollection<Staff>(list);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WpfApp1.ViewModels
{
    class MainViewModel
    {
        public Models.Greeting Greeting { get; set; }
        public ObservableCollection<string> Jobs { get; set; }

        public MainViewModel()
        {
            Greeting = new Models.Greeting();
            Jobs = new ObservableCollection<string>() { "Développeur", "Designer", "Chef de projet", "Analyste", "Administrateur" };
        }
    }
}

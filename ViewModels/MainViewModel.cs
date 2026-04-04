using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Text;

namespace WpfApp1.ViewModels
{
    class MainViewModel
    {
        public Models.Greeting Greeting { get; set; }
        public ObservableCollection<string> Jobs { get; set; }

        public ICommand GreetingCommand { get; set; }

        private void DisplayMessage()
        {
            Greeting.Message = $"Bienvenue {Greeting.Name} ({Greeting.Job})";
        }

        public MainViewModel()
        {
            Greeting = new Models.Greeting();
            Jobs = new ObservableCollection<string>() { "Développeur", "Designer", "Chef de projet", "Analyste", "Administrateur" };
            GreetingCommand = new RelayCommand(o => true, o => DisplayMessage());
        }
    }
}

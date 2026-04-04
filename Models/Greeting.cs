using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfApp1.Models
{
    class Greeting : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _message;
        private string _name;
        private string _job;

        public string Name
        {
            get { return _name; }

            set
            {
                if( _name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Job
        {
            get { return _job;}
            set
            {
                if(_job != value)
                {
                    _job = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Message
        {
            get {  return _message; }
            set
            {
                if(_message != value)
                {
                    _message = value;
                    OnPropertyChanged();
                }
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}

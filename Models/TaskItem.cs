using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApp.Models
{
    public class TaskItem : INotifyPropertyChanged
    {
        private bool _isCompleted;

        public bool IsCompleted
        {
            get => _isCompleted;
            set
            {
                _isCompleted = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsCompleted)));
            }
        }

        public string Title { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        public DateTime DateAdded { get; set; } = DateTime.Now;

    }

}



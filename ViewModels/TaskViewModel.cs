using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TaskApp.Helpers;
using TaskApp.Models;

namespace TaskApp.ViewModels
{
    public class TaskViewModel : INotifyPropertyChanged
    {

        public TaskViewModel()
        {
            AddTaskCommand = new RelayCommand(AddTask, CanAddTaskRun);

        }

       public ICommand AddTaskCommand { get; }

        public ObservableCollection<TaskItem> TaskList { get; } = new();
        
        private TaskItem _newTask = new();
        public TaskItem NewTask
        {
            get => _newTask;
            set
            {
                _newTask = value;
                OnPropertyChanged();
            }
        }


        public void AddTask(object? parameter)
        {
            
            string test = NewTask?.Title ?? string.Empty;
            if (string.IsNullOrEmpty(NewTask?.Title))
            {
                return;
            }

            TaskList.Insert(0, new TaskItem { Title = NewTask.Title, IsCompleted = NewTask.IsCompleted });

            NewTask = new TaskItem();

            OnPropertyChanged(nameof(NewTask));

        }

        public bool CanAddTaskRun(object? parameter)
        {
            return true;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}

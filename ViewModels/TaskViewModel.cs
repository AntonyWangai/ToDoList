using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Metadata;
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
            DeleteTaskCommand = new RelayCommand(DeleteTask, CanDeleteTaskRun); 
            System.Diagnostics.Debug.WriteLine("ViewModel created");

        }

        private bool CanDeleteTaskRun(object? arg)
        {
            return true;
        }

        private void DeleteTask(object? parameter)
        {
           if(parameter is TaskItem task)
            {
                TaskList.Remove(task);
            }
           Debug.WriteLine("DeleteTask executed");
        }

        public ICommand AddTaskCommand { get; }

       public ICommand DeleteTaskCommand { get; }

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
       
            if (string.IsNullOrEmpty(NewTask?.Title))
            {
                return;
            }

            TaskList.Insert(0, new TaskItem { Title = NewTask.Title, IsCompleted = NewTask.IsCompleted });

            NewTask = new TaskItem();
            Debug.WriteLine("This is a test");

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

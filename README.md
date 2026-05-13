Overview

This is a desktop Todo List application built using WinUI 3 and the MVVM (Model-View-ViewModel) design pattern.
It allows users to create, manage, and organize tasks with real-time updates and a clean modern interface.

The project is designed as a learning exercise to understand modern Windows desktop development, MVVM architecture, and data binding using WinUI.

Features
Add new tasks
Mark tasks as completed
Delete tasks
Display task history
Automatic task timestamp (date and time)
Responsive UI layout using Grid and StackPanel
Real-time UI updates using ObservableCollection

Architecture

The project follows the MVVM pattern:

Model

Represents the data structure of a task.

TaskItem
Title
IsCompleted
DateAdded
View

The UI layer built using XAML.

MainWindow.xaml
Uses data binding to display and interact with data
ViewModel

Handles application logic and state.

TaskViewModel
ObservableCollection for tasks
ICommand implementations for Add/Delete operations
Business logic for task management
Technologies Used
C#
WinUI 3
XAML
.NET
MVVM Pattern
INotifyPropertyChanged
ICommand (RelayCommand)
<img width="1897" height="981" alt="ToDoApp" src="https://github.com/user-attachments/assets/81cdda1d-f372-4fce-a2b2-df257ef25834" />


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Desktop.Model;

namespace Desktop.Window
{
    public partial class MainWindow
    {
        private ObservableCollection<CategoryModel> TasksCategory { get; set; }
        private ObservableCollection<TaskModel> Task { get; set; }
        private List<SolidColorBrush> Colors { get; set; }
        
        public MainWindow(string name = "")
        {
            InitializeComponent();
            
            UserNameTextBlock.Text = name;

            Colors = new List<SolidColorBrush>
            {
                new SolidColorBrush(System.Windows.Media.Colors.Yellow),
                new SolidColorBrush(System.Windows.Media.Colors.Red),
                new SolidColorBrush(System.Windows.Media.Colors.Blue),
                new SolidColorBrush(System.Windows.Media.Colors.Purple),
                new SolidColorBrush(System.Windows.Media.Colors.Coral),
                new SolidColorBrush(System.Windows.Media.Colors.Violet),
                new SolidColorBrush(System.Windows.Media.Colors.GreenYellow),
            };

            var random = new Random();
            
            TasksCategory = new ObservableCollection<CategoryModel>
            {
                new CategoryModel {Title = "Дом", TitleColor = Colors[random.Next(Colors.Count)]},
                new CategoryModel {Title = "Учеба", TitleColor = Colors[random.Next(Colors.Count)]},
                new CategoryModel {Title = "Отдых", TitleColor = Colors[random.Next(Colors.Count)]},
                new CategoryModel {Title = "Работа", TitleColor = Colors[random.Next(Colors.Count)]},
            };

            Task = new ObservableCollection<TaskModel>();
            
            for (var i = 0; i < 10; ++i)
            {
                Task.Add(
                    new TaskModel
                    {
                        Id = i,
                        IsChecked = false,
                        Title = ("task " + i),
                        Time = "22:00",
                        BackgroundColor = new SolidColorBrush(System.Windows.Media.Colors.White),
                        ColorBorder = new SolidColorBrush(System.Windows.Media.Colors.Blue)
                    }
                );
            }
            
            TaskCategoryListBox.ItemsSource = TasksCategory;
            TasksListBox.ItemsSource = Task;
        }

        private void AddTaskButton_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            var task = (TaskModel) TasksListBox.SelectedItem;
            Task.Remove(task);
        }

        private void TasksListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var task = (TaskModel) TasksListBox.SelectedItem;

            DetailDescriptionBlock.Visibility = Visibility.Visible;

            if (task != null)
            {
                TitleTextBlock.Text = task.Title;
                TimeTextBlock.Text = task.Time;
                DateTextBlock.Text = task.Time;   
            }
            else
            {
                DetailDescriptionBlock.Visibility = Visibility.Hidden;
            }
        }

        private void TaskListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void DoneButton_OnClick(object sender, RoutedEventArgs e)
        {
            var task = (TaskModel) TasksListBox.SelectedItem;
            task.IsChecked = true;
        }
    }
}
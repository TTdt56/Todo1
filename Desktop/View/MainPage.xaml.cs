using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Desktop.Model;
using Desktop.Repository;

namespace Desktop.View
{
    public partial class MainPage : Page
    {
        private static bool isCheked;
        private ObservableCollection<CategoryModel> TasksCategory { get; set; }
        private List<SolidColorBrush> Colors { get; set; }
        
        public MainPage(string name = "")
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

            TaskCategoryListBox.ItemsSource = TasksCategory;
            TasksListBox.ItemsSource = TasksRepository.GetTasksIsChecked(isCheked);
        }
        
        private void AddTaskButton_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new CreatePage());
        }

        private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            var task = (TaskModel) TasksListBox.SelectedItem;
            TasksRepository.DeleteTask(task);
        }

        private void TasksListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var task = (TaskModel) TasksListBox.SelectedItem;

            DetailDescriptionBlock.Visibility = Visibility.Visible;

            if (task != null)
            {
                TitleTextBlock.Text = task.Title;
                ContentTextBlock.Text = task.Content;
                TimeTextBlock.Text = task.Time;
                DateTextBlock.Text = task.Date;
            }
            else
            {
                DetailDescriptionBlock.Visibility = Visibility.Hidden;
            }
        }

        private void DoneButton_OnClick(object sender, RoutedEventArgs e)
        {
            var task = (TaskModel) TasksListBox.SelectedItem;
            task.IsChecked = true;
        }

        private void TasksConditionTextBlock_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            isCheked = false;
            TasksListBox.ItemsSource = TasksRepository.GetTasksIsChecked(isCheked);
        }

        private void HistoryConditionTextBlock_OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            isCheked = true;
            TasksListBox.ItemsSource = TasksRepository.GetTasksIsChecked(isCheked);
        }
        
        private void TaskListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
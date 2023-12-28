using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Media;
using Desktop.Model;

namespace Desktop.Repository
{
    public static class TasksRepository
    {
        private static readonly ObservableCollection<TaskModel> Tasks = new ObservableCollection<TaskModel>
        {
            new TaskModel
            {
                Id = 0, Title = "Task 0",
                Category = "Отдых", Content = "Описание задачи 0",
                Date = "28.03.2023", Time = "00:00", IsChecked = false,
                BackgroundColor = Brushes.White, ColorBorder = Brushes.Blue
            },
            new TaskModel
            {
                Id = 1, Title = "Task 1",
                Category = "Работа", Content = "Описание задачи 1",
                Date = "28.03.2023", Time = "01:00", IsChecked = true,
                BackgroundColor = Brushes.White, ColorBorder = Brushes.Blue
            },
            new TaskModel
            {
                Id = 2, Title = "Task 2",
                Category = "Отдых", Content = "Описание задачи 2",
                Date = "28.03.2023", Time = "02:00", IsChecked = true,
                BackgroundColor = Brushes.White, ColorBorder = Brushes.Blue
            },
            new TaskModel
            {
                Id = 3, Title = "Task 3",
                Category = "Отдых", Content = "Описание задачи 3",
                Date = "28.03.2023", Time = "03:00", IsChecked = false,
                BackgroundColor = Brushes.White, ColorBorder = Brushes.Blue
            },
            new TaskModel
            {
                Id = 4, Title = "Task 4",
                Category = "Учеба", Content = "Описание задачи 4",
                Date = "28.03.2023", Time = "04:00", IsChecked = false,
                BackgroundColor = Brushes.White, ColorBorder = Brushes.Blue
            },
            new TaskModel
            {
                Id = 5, Title = "Task 5",
                Category = "Учеба", Content = "Описание задачи 5",
                Date = "28.03.2023", Time = "05:00", IsChecked = false,
                BackgroundColor = Brushes.White, ColorBorder = Brushes.Blue
            },
            new TaskModel
            {
                Id = 6, Title = "Task 6",
                Category = "Работа", Content = "Описание задачи 6",
                Date = "28.03.2023", Time = "06:00", IsChecked = false,
                BackgroundColor = Brushes.White, ColorBorder = Brushes.Blue
            },
            new TaskModel
            {
                Id = 6, Title = "Task 7",
                Category = "Дом", Content = "Описание задачи 7",
                Date = "28.03.2023", Time = "07:00", IsChecked = true,
                BackgroundColor = Brushes.White, ColorBorder = Brushes.Blue
            }
        };

        public static bool GetIsCheckedTask(TaskModel task)
        {
            return task.IsChecked;
        }

        public static ObservableCollection<TaskModel> GetTasksIsChecked(bool isChecked)
        {
            var tasks = new ObservableCollection<TaskModel>();
            if (isChecked)
            {
                foreach (var task in Tasks)
                {
                    if (task.IsChecked)
                    {
                        tasks.Add(task);
                    }
                }
            }
            else
            {
                foreach (var task in Tasks)
                {
                    if (!task.IsChecked)
                    {
                        tasks.Add(task);
                    }
                }
            }

            return tasks;
        }

        public static ObservableCollection<TaskModel> GetTasks()
        {
            return Tasks;
        }

        public static void AddTask(TaskModel task)
        {
            Tasks.Add(task);
        }

        public static void AddAllTasks(List<TaskModel> tasks)
        {
            foreach (var task in tasks)
            {
                Tasks.Add(task);
            }
        }

        public static void DeleteTask(TaskModel task)
        {
            Tasks.Remove(task);
        }

        public static void IsCheckedTask(TaskModel task)
        {
            task.IsChecked = true;
        }
    }
}
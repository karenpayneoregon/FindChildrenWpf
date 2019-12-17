using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WpfAppExample1.Classes
{
    public enum TaskType 
    {
        Home,
        Work 
    }
    public class TaskItem
    {
        public string TaskName { get; set; }
        public string Description { get; set; }
        public TaskType TaskType { get; set; }
        public int Priority { get; set; } 
        public override string ToString()
        {
            return TaskName;
        }
    }

    public class Tasks
    {
        public ObservableCollection<TaskItem> List()
        {
            return new ObservableCollection<TaskItem>()
            {
                new TaskItem() {Priority = 2, TaskType = TaskType.Work, TaskName = "Unit test data operations", Description = "Delegate to junior developer"},
                new TaskItem() {Priority = 1, TaskType = TaskType.Work, TaskName = "Prototype dashboard", Description = "Put together dashboard prototype"},
                new TaskItem() {Priority = 3, TaskType = TaskType.Work, TaskName = "Single signon discussion", Description = "Discuss options"}
            };
        }
    }
}

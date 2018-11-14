using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CommandService
{
    public class ToDoCommandManager : IToDoCommandManager
    {
        private readonly ITaskCommandRepository taskCommandRepository = null;
        private readonly ICategoryCommandRepository categoryCommandRepository = null;
       
        public ToDoCommandManager()
        {
            categoryCommandRepository = new CategoryCommandRepository();
            taskCommandRepository = new TaskCommandRepository();
        }
        public void CreateTask(ToDoTask task)
        {
            taskCommandRepository.CreateTask(task);
        }
        public void CreateCategory(Category category)
        {
            categoryCommandRepository.CreateCategory(category);
        }
        public void DeleteTask(int id)
        {
            taskCommandRepository.DeleteTask(id);
        }
        public void UpdateaTask(ToDoTask task)
        {
            taskCommandRepository.UpdateTask(task);
        }
    }
}

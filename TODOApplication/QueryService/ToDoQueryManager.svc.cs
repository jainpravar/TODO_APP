using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QueryService
{
    public class ToDoQueryManager : IToDoQueryManager
    {
        private readonly ITaskQueryRepository taskQueryRepository = null;
        private readonly ICategoryQueryRepository categoryQueryRepository = null;

        public ToDoQueryManager()
        {
            taskQueryRepository = new TaskQueryRepository();
            categoryQueryRepository = new CategoryQueryRepository();
        }
        public ToDoTask GetTaskById(int id)
        {
            return taskQueryRepository.GetTaskById(id);
        }
        public List<ToDoTask> GetAllTask()
        {
            return taskQueryRepository.GetAllTask();
        }
        public List<Category> GetAllCategories()
        {
            return categoryQueryRepository.GetAllCategories();
        }
    }
}

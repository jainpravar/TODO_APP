using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QueryService
{
    [ServiceContract]
    public interface IToDoQueryManager
    {
        [OperationContract]
        ToDoTask GetTaskById(int id);
        [OperationContract]
        List<ToDoTask> GetAllTask();
        [OperationContract]
        List<Category> GetAllCategories();
    }
}

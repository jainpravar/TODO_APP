using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CommandService
{
    [ServiceContract]
    public interface IToDoCommandManager
    {
        [OperationContract]
        void CreateTask(ToDoTask task);
        [OperationContract]
        void DeleteTask(int id);
        [OperationContract]
        void UpdateaTask(ToDoTask task);
        [OperationContract]
        void CreateCategory(Category category);
    }
}

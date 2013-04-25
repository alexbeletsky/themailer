using System.Collections.Generic;

namespace TheMailer.Models.Repositories
{
    public class TasksRepository
    {
        private readonly static List<Task> _container;

        static TasksRepository()
        {
            _container = new List<Task>
                             {
                                 new Task
                                     {
                                         Desciption = "Prepare presentation for MSSWIIT",
                                         DueDate = "04/25/2013",
                                         Done = false
                                     },
                                 new Task
                                     {
                                         Desciption = "Write 'TheMailer' app to demo SPA concepts",
                                         DueDate = "04/25/2013",
                                     },
                                 new Task
                                     {
                                         Desciption = "Drink some beer after conference",
                                         DueDate = "04/25/2013"
                                     }
                             };
        }

        public IEnumerable<Task> All
        {
            get { return _container; }
        }
    }
}
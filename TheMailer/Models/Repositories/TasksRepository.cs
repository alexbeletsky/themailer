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
                                         Description = "Prepare presentation for MSSWIIT",
                                         DueDate = "04/25/2013",
                                         Done = "Yes"
                                     },
                                 new Task
                                     {
                                         Description = "Write 'TheMailer' app to demo SPA concepts",
                                         DueDate = "04/25/2013",
                                         Done = "Yes"
                                     },
                                 new Task
                                     {
                                         Description = "Drink some beer after conference",
                                         DueDate = "04/25/2013",
                                         Done = "No"
                                     }
                             };
        }

        public IEnumerable<Task> All
        {
            get { return _container; }
        }
    }
}
using System.Collections.Generic;
using System.Web.Http;
using TheMailer.Models;
using TheMailer.Models.Repositories;

namespace TheMailer.Api
{
    public class TasksController : ApiController
    {
        private TasksRepository _tasksRepository;

        public TasksController()
        {
            _tasksRepository = new TasksRepository();
        }

        public IEnumerable<Task> GetTasks()
        {
            return _tasksRepository.All;
        }
    }
}

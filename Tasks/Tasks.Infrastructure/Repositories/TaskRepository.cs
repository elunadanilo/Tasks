using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.Core.Entities;
using Tasks.Core.Interfaces;

namespace Tasks.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public async Task<IEnumerable<Tareas>> GetTask()
        {
            var tasks = Enumerable.Range(1, 10).Select(x => new Tareas
            {
                TaskId = x,
                Description = $"Description {x}",
                Date = DateTime.Now,
                Image = "https",
                UserId = x * 2
            });

            await Task.Delay(10);
            return tasks;
        }
    }
}

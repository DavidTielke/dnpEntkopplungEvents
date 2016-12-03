using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitTasksNaiv.DataClasses;
using MitTasksNaiv.Logic;
using Task = MitTasksNaiv.DataClasses.Task;

namespace _3MitTasksUndDecorator.Logic
{
    class BillTaskManager : IBillManager
    {
        private readonly IBillManager _innerManager;
        private readonly ITaskManager _taskManager;

        public BillTaskManager(IBillManager innerManager, ITaskManager taskManager)
        {
            _innerManager = innerManager;
            _taskManager = taskManager;
        }

        public void Add(Bill bill)
        {
            _innerManager.Add(bill);
            _taskManager.Add(new Task { Title = $"Fälligkeit {bill.Id} prüfen" });
        }
    }
}

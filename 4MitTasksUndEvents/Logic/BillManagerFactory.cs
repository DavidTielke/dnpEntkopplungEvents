using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitTasksNaiv.Data;
using MitTasksNaiv.Logic;
using Task = MitTasksNaiv.DataClasses.Task;

namespace _3MitTasksUndDecorator.Logic
{
    class BillManagerFactory
    {
        public IBillManager Create()
        {
            var billRepository = new BillRepository();
            var positionRepository = new BillPositionRepository();
            var billManager = new BillManager(billRepository, positionRepository);
            billManager.NewBill += (s, a) =>
            {
                var taskManager = new TaskManager();
                taskManager.Add(new Task { Title = $"Fälligkeit {a.NewBill.Id} prüfen" });
            };
            return billManager;
        }
    }
}

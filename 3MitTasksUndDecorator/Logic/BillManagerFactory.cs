using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitTasksNaiv.Data;
using MitTasksNaiv.Logic;

namespace _3MitTasksUndDecorator.Logic
{
    class BillManagerFactory
    {
        public IBillManager Create()
        {
            var billRepository = new BillRepository();
            var positionRepository = new BillPositionRepository();
            var billManager = new BillManager(billRepository, positionRepository);
            var taskManager = new TaskManager();
            var billTaskManager = new BillTaskManager(billManager, taskManager);
            return billTaskManager;
        }
    }
}

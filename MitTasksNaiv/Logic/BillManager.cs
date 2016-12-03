using MitTasksNaiv.Data;
using MitTasksNaiv.DataClasses;

namespace MitTasksNaiv.Logic
{
    class BillManager : IBillManager
    {
        private IBillRepository _billRepository;
        private IBillPositionRepository _positionRepository;
        private ITaskManager _taskManager;

        public BillManager(IBillRepository billRepository, IBillPositionRepository positionRepository, ITaskManager taskManager)
        {
            _billRepository = billRepository;
            _positionRepository = positionRepository;
            _taskManager = taskManager;
        }

        public void Add(Bill bill)
        {
            _billRepository.Insert(bill);
            _positionRepository.Insert(bill.Id, bill.Positions);
            _taskManager.Add(new Task {Title = $"Fälligkeit {bill.Id} prüfen"});
        }
    }
}
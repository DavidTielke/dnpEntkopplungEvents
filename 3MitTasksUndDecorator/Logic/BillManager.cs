using MitTasksNaiv.Data;
using MitTasksNaiv.DataClasses;

namespace MitTasksNaiv.Logic
{
    class BillManager : IBillManager
    {
        private IBillRepository _billRepository;
        private IBillPositionRepository _positionRepository;

        public BillManager(IBillRepository billRepository, IBillPositionRepository positionRepository)
        {
            _billRepository = billRepository;
            _positionRepository = positionRepository;
        }

        public void Add(Bill bill)
        {
            _billRepository.Insert(bill);
            _positionRepository.Insert(bill.Id, bill.Positions);
        }
    }
}
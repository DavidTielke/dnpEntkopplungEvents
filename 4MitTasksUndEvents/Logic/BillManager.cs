using System;
using MitTasksNaiv.Data;
using MitTasksNaiv.DataClasses;

namespace MitTasksNaiv.Logic
{
    class BillManager : IBillManager
    {
        private IBillRepository _billRepository;
        private IBillPositionRepository _positionRepository;

        public event EventHandler<NewBillEventArgs> NewBill; 

        public BillManager(IBillRepository billRepository, IBillPositionRepository positionRepository)
        {
            _billRepository = billRepository;
            _positionRepository = positionRepository;
        }

        public void Add(Bill bill)
        {
            _billRepository.Insert(bill);
            _positionRepository.Insert(bill.Id, bill.Positions);
            OnNewBill(bill);
        }

        protected virtual void OnNewBill(Bill bill)
        {
            NewBill?.Invoke(this, new NewBillEventArgs {NewBill = bill});
        }
    }
}
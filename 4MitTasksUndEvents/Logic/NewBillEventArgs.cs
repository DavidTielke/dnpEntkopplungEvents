using System;
using MitTasksNaiv.DataClasses;

namespace MitTasksNaiv.Logic
{
    class NewBillEventArgs : EventArgs
    {
        public Bill NewBill { get; set; }
    }
}
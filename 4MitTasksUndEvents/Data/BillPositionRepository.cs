using System.Collections.Generic;
using MitTasksNaiv.DataClasses;

namespace MitTasksNaiv.Data
{
    public class BillPositionRepository : IBillPositionRepository
    {
        public void Insert(int billId, IEnumerable<BillPosition> positions) { }
    }
}
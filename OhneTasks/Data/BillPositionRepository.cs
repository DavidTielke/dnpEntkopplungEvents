using System.Collections.Generic;
using OhneTasks.DataClasses;

namespace OhneTasks.Data
{
    public class BillPositionRepository : IBillPositionRepository
    {
        public void Insert(int billId, IEnumerable<BillPosition> positions) { }
    }
}
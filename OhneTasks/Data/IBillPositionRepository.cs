using System.Collections.Generic;
using OhneTasks.DataClasses;

namespace OhneTasks.Data
{
    public interface IBillPositionRepository
    {
        void Insert(int billId, IEnumerable<BillPosition> positions);
    }
}
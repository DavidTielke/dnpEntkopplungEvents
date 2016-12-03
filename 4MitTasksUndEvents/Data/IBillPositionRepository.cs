using System.Collections.Generic;
using MitTasksNaiv.DataClasses;

namespace MitTasksNaiv.Data
{
    public interface IBillPositionRepository
    {
        void Insert(int billId, IEnumerable<BillPosition> positions);
    }
}
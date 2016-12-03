using System.Collections.Generic;

namespace OhneTasks.DataClasses
{
    public class Bill
    {
        public int Id { get; set; }
        public string Reason { get; set; }
        public List<BillPosition> Positions { get; set; }
    }
}
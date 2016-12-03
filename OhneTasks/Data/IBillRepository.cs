using OhneTasks.DataClasses;

namespace OhneTasks.Data
{
    internal interface IBillRepository
    {
        void Insert(Bill bill);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitTasksNaiv.Data;
using MitTasksNaiv.DataClasses;
using MitTasksNaiv.Logic;
using _3MitTasksUndDecorator.Logic;

namespace _3MitTasksUndDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var bill = new Bill();

            var billTaskManager = new BillManagerFactory().Create();

            billTaskManager.Add(bill);
        }
    }
}

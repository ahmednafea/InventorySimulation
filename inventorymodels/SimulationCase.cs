using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class SimulationCase
    {
        public int Day { get; set; }
        public int Cycle { get; set; }
        public int DayWithinCycle { get; set; }
        public int BeginningInventory { get; set; }
        public int RandomDemand { get; set; }
        public int Demand { get; set; }
        public int EndingInventory { get; set; }
        public int ShortageQuantity { get; set; }
        public int OrderQuantity { get; set; }
        public int RandomLeadDays { get; set; }
        public int LeadDays { get; set; }
        public char DaysUntilLead { get; set; }
        public void setDaysUntilLead( int lead)
        {
               
            if (lead == 1)
                DaysUntilLead = '1';
            else if (lead==2)
                DaysUntilLead = '2';
            else
                DaysUntilLead = '-';
        }

        public int CalcShortageQuantity(int shortage)
        {
            return Math.Max(Demand -
                BeginningInventory, 0) + shortage;
        }
        public int CalcEndingInventory(int shortage)
        {
            return Math.Max(BeginningInventory -
                (Demand + shortage), 0);
        }
        public int ClacOrderQuantity(int OrderUpTo)
        {
            return OrderUpTo - EndingInventory + ShortageQuantity;

        }
        public int CheckShortage(int shortage)
        {
            return
                 BeginningInventory -
                 (Demand + shortage);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeDemp
{
    class LegionComponsite : LegionComponent
    {
        private String commander;
        private int quantity;
        private List<LegionComponent> legions = new List<LegionComponent>();

        public LegionComponsite(String commander, int quantity)
        {
            this.commander = commander;
            this.quantity = quantity;
        }

        public void Add(LegionComponent lc)
        {
            legions.Add(lc);
        }

        public override String GetCommanders()
        {
            String commanders = commander + ";";
            foreach (LegionComponent legion in legions)
            {
                commanders += legion.GetCommanders();
            }
            return commanders;
        }

        public override int GetQuantity()
        {
            int quantities = quantity;
            foreach (LegionComponent legion in legions)
            {
                quantities += legion.GetQuantity();
            }
            return quantities;
        }
    }
}

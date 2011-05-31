using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeDemp
{
    class Legion : LegionComponent
    {
        private String commander;
        private int quantity;

        public Legion(string commander, int quantity)
        {
            this.commander = commander;
            this.quantity = quantity;
        }

        public override String GetCommanders()
        {
            return commander + ";";
        }

        public override int GetQuantity()
        {
            return quantity;
        }
    }
}

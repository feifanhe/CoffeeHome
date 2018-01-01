using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHome
{
    public class TradeItem
    {
        public int TradeID
        {
            get
            {
                return this.m_TradeID;
            }
            set
            {
                this.m_TradeID = value;
            }
        }

        public int ItemID
        {
            get
            {
                return this.m_ItemID;
            }
            set
            {
                this.m_ItemID = value;
            }
        }

        public int Amount
        {
            get
            {
                return this.m_Amount;
            }
            set
            {
                this.m_Amount = value;
            }
        }

        public int RoastDegreeID
        {
            get
            {
                return this.m_RoastDegreeID;
            }
            set
            {
                this.m_RoastDegreeID = value;
            }
        }

        public TradeItem()
        {
        }

        private int m_TradeID;
        private int m_ItemID;
        private int m_Amount;
        private int m_RoastDegreeID;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyManager
{
    public class Membership
    {
        private Member _owner;
        private int _monthlyPrice;
        private int _months;
        public Member Owner { get { return _owner; } set { _owner = value; } }
        public int MonthlyPrice { get { return _monthlyPrice; } set { _monthlyPrice = value; } }
        public int Months { get { return _months; } set { _months = value; } }
        public Membership( Member owner, int monthlyPrice , int months)
        {
            _months = months;
            _owner = owner;
            _monthlyPrice = monthlyPrice;
        }
        public int TotalCost()
        {
        int idk =  Owner.Isstudent ?  (int)(MonthlyPrice * Months * 0.80) :  MonthlyPrice * Months;
            return idk;
        }
        public void Extend (int months)
        {
            _months += months;
        }
        public int PricePerVisit()
        {
            if(Owner .Visits == 0)
            {
                return TotalCost();
            }
            else
            {
                return TotalCost()/Owner.Visits;
            }
        }
        
    }
}


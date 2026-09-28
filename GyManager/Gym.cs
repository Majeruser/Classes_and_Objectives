using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyManager
{
    public class Gym
    {
        private string _name;
        private List<Membership> _memberships;
        public string Name { get { return _name; } set { _name = value; } }
        public List<Membership> Memberships { get { return _memberships; } set { _memberships = value; } }
        public Gym(string name) {
         _memberships = new List<Membership>();
         _name = name;
        }
        public void AddMembership(Membership membership)
        {
            Memberships.Add(membership);
        }
        public int TotalIncome()
        {
            int valtozo = 0;
            foreach(Membership item in Memberships)
            {
                valtozo += item.TotalCost();
            }
            return valtozo;
        }
        public Membership MostActive()
        {
            Membership valami = Memberships.First();
            foreach(Membership item in Memberships)
            {
                if(valami.Owner.Visits < item.Owner.Visits)
                {
                    valami = item;
                }
            }
            return valami;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyManager
{
    public class Member
    {
        private string _name;
        private int _age;
        private bool _isStudent;
        private int _visits;
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public bool Isstudent { get { return _isStudent; } set { _isStudent = value; } }
        public int Visits { get { return _visits; } set { _visits = value; } }
        public Member(string name, int age, bool isStudent)
        {
            _isStudent = isStudent;
            _name = name;
            _age = age;
            _visits = 0;
        }
        public void Checkin()
        {
            Visits++;
        }
        public string Describe()
        {
            string valami = Isstudent ? "Diak" : "nem diak";
            return $"{Name} - {Age} - {valami} - {Visits}";
        }
    }
}

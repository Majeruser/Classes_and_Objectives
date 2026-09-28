namespace GyManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member sophie = new Member("Shopie Rain", 22, false);
            Member Drake = new Member("Drake", 39, true);
            Member Bonie = new Member("Bonnie Blue", 25, true);
            Bonie.Checkin();
            sophie.Checkin();
            sophie.Checkin();
            Drake.Checkin();
            Drake.Checkin();
            Drake.Checkin();

            Console.WriteLine(Drake.Describe());
            Console.WriteLine(sophie.Describe());
            Console.WriteLine(Bonie.Describe());

            Membership m1 = new Membership(Drake, 1000, 2);
            Console.WriteLine("---------------------------------------------");
            Membership m2 = new Membership(sophie, 5000, 10);
            Console.WriteLine(m1.TotalCost());
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(m2.TotalCost());
            Console.WriteLine("---------------------------------------------");
            m1.Extend(10);
            Console.WriteLine(m1.TotalCost());
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(m1.PricePerVisit());
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(m2.PricePerVisit());
            Console.WriteLine("-----------------------------------------------------------------");
            Gym galaxy = new Gym("galaxy");
            galaxy.AddMembership(m1);
            galaxy.AddMembership(m2);
            Console.WriteLine(galaxy.TotalIncome());

        }
    }
}

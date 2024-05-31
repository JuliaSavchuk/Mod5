namespace Mod5
{
    class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string BusinessProfile { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public double Area { get; set; }

        public Store(string name, string address, string businessProfile, string contactPhone, string email, double area)
        {
            Name = name;
            Address = address;
            BusinessProfile = businessProfile;
            ContactPhone = contactPhone;
            Email = email;
            Area = area;
        }

        public void EnterData()
        {
            Console.Write("Enter the name of the store: ");
            Name = Console.ReadLine();

            Console.Write("Enter the address: ");
            Address = Console.ReadLine();

            Console.Write("Enter the business profile: ");
            BusinessProfile = Console.ReadLine();

            Console.Write("Enter the contact phone: ");
            ContactPhone = Console.ReadLine();

            Console.Write("Enter the email: ");
            Email = Console.ReadLine();

            Console.Write("Enter the area of the store: ");
            Area = double.Parse(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Business Profile: {BusinessProfile}");
            Console.WriteLine($"Contact Phone: {ContactPhone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Area: {Area}");
        }

        // Overload operators
        public static Store operator +(Store store, double area)
        {
            store.Area += area;
            return store;
        }

        public static Store operator -(Store store, double area)
        {
            store.Area -= area;
            return store;
        }

        public static bool operator ==(Store s1, Store s2)
        {
            return s1.Area == s2.Area;
        }

        public static bool operator !=(Store s1, Store s2)
        {
            return s1.Area != s2.Area;
        }

        public static bool operator <(Store s1, Store s2)
        {
            return s1.Area < s2.Area;
        }

        public static bool operator >(Store s1, Store s2)
        {
            return s1.Area > s2.Area;
        }

        public override bool Equals(object obj)
        {
            if (obj is Store store)
            {
                return this.Area == store.Area;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Area.GetHashCode();
        }
    }
}

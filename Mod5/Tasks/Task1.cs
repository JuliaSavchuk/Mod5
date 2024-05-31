namespace Mod5
{
    class Journal
    {
        public string Title { get; set; }
        public int YearOfFoundation { get; set; }
        public string Description { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public int NumberOfEmployees { get; set; }

        public Journal(string title, int yearOfFoundation, string description, string contactPhone, string email, int numberOfEmployees)
        {
            Title = title;
            YearOfFoundation = yearOfFoundation;
            Description = description;
            ContactPhone = contactPhone;
            Email = email;
            NumberOfEmployees = numberOfEmployees;
        }

        public void EnterData()
        {
            Console.Write("Enter the title of the journal: ");
            Title = Console.ReadLine();

            Console.Write("Enter the year of foundation: ");
            YearOfFoundation = int.Parse(Console.ReadLine());

            Console.Write("Enter the description of the journal: ");
            Description = Console.ReadLine();

            Console.Write("Enter the contact phone: ");
            ContactPhone = Console.ReadLine();

            Console.Write("Enter the email: ");
            Email = Console.ReadLine();

            Console.Write("Enter the number of employees: ");
            NumberOfEmployees = int.Parse(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Year of Foundation: {YearOfFoundation}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Contact Phone: {ContactPhone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Number of Employees: {NumberOfEmployees}");
        }

        // Overload operators
        public static Journal operator +(Journal journal, int employees)
        {
            journal.NumberOfEmployees += employees;
            return journal;
        }

        public static Journal operator -(Journal journal, int employees)
        {
            journal.NumberOfEmployees -= employees;
            return journal;
        }

        public static bool operator ==(Journal j1, Journal j2)
        {
            return j1.NumberOfEmployees == j2.NumberOfEmployees;
        }

        public static bool operator !=(Journal j1, Journal j2)
        {
            return j1.NumberOfEmployees != j2.NumberOfEmployees;
        }

        public static bool operator <(Journal j1, Journal j2)
        {
            return j1.NumberOfEmployees < j2.NumberOfEmployees;
        }

        public static bool operator >(Journal j1, Journal j2)
        {
            return j1.NumberOfEmployees > j2.NumberOfEmployees;
        }

        public override bool Equals(object obj)
        {
            if (obj is Journal journal)
            {
                return this.NumberOfEmployees == journal.NumberOfEmployees;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return NumberOfEmployees.GetHashCode();
        }
    }
}

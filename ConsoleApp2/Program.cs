class Vehicle
{
    string Name;
    int Carnumber;

    public int Totalspace = 25;
    public int Hourscarparked { get; set; }
    public int Bill { get; set; }
    public int Accountnumber { get; set; }
    public int Balance { get; set; }
    public void Message(string messagetype)
    {
        Console.WriteLine($"{messagetype} safeparking");
    }
    public void Vehicledetails()
    {
        Console.WriteLine("enter your name : ");
        Name = Console.ReadLine();
        Console.WriteLine("enter the car number : ");
        Carnumber = int.Parse(Console.ReadLine());
    }
    public void Printdetails()
    {
        Console.WriteLine($"Name              :   {Name}");
        Console.WriteLine($"Carnumber         :   {Carnumber}");
        Console.WriteLine("Fair for one hour :   1$");
    }
    public void Checkspaceforparking()
    {
        if (Totalspace > 0)
        {
            Console.WriteLine("please park the car");
            Totalspace -= 1;
        }
        else
        {
            Console.WriteLine("the parkin lot is full");
        }
    }
    public void entryprocess()
    {
        Message("Welcome to");
        Vehicledetails();
        Checkspaceforparking();
        Printdetails();
    }
    public void Billevaluation()
    {
        Console.WriteLine("total hours car parked");
        Hourscarparked = int.Parse(Console.ReadLine());
        Bill = Hourscarparked;
    }
    public void Transactioncheck()
    {
        Console.WriteLine("enter your account number : ");
        Accountnumber = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the account balance : ");
        Balance = int.Parse(Console.ReadLine());
        if (Balance > 0)
        {
            Balance -= Bill;
            Totalspace += 1;
        }
        else
        {
            Console.WriteLine("invalid transaction........");
        }
    }
    public void Membershipcard()
    {
        Console.WriteLine("do you have member ship card ");
        string s = Console.ReadLine();
        if (s == "yes")
        {
            Bill -= 1;
            Console.WriteLine("discount on card 1$");
        }
        else if (s == "no")
        {
            Console.WriteLine("do you want to puchase membership card : ");
            string choice = Console.ReadLine();

            if (choice == "yes")
            {
                Console.WriteLine("card fee : 150$");
                Bill += 150;
            }
        }
    }
    public void Exitprocess()
    {
        Console.WriteLine("--------------------------------------------------");
        Vehicledetails();
        Billevaluation();
        Membershipcard();
        Transactioncheck();
        Message("Goodbye from");
        Printdetails();
        Console.WriteLine($"Bill : {Bill}$");
    }
}

class Safeparking
{
    public static void Main()
    {
        Vehicle vehicle = new Vehicle();
        vehicle.entryprocess();
        vehicle.Exitprocess();

    }
}

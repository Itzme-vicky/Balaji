using oops;
using System.Security.Cryptography.X509Certificates;

public class Program {

   

    public static void Main(string[] args) {



        PaymentService Payment = new PaymentService();

        Payment Balaji = new CreditCardPayment();
        Payment.MakePayment(Balaji, 20000);

        Payment vignesh = new netBankingPayment();
        Payment.MakePayment(vignesh, 10000);

        Payment Tamil = new debitCardPayment();
        Payment.MakePayment(Tamil, 5000);

        //Encapsulation encapsulation = new Encapsulation();
        //encapsulation.Name = "Balaji";
        //encapsulation.Address = "Hyderabad";
        //encapsulation.Validate();



        //polymorphism2 Animal = new polymorphism2();
        //Animal.sound();
        //polymorphism2 dog = new Dog();
        //dog.sound();



        // Polymorphism poly = new Polymorphism();
        //var result = poly.add(10, 20);
        // Console.WriteLine(result);

        // var result2 = poly.add(10, 20, 30);
        // Console.WriteLine(result2);

        // var result3 = poly.add("Hello", "World");
        // Console.WriteLine(result3);



        //Employee emp1 =new Employee(1, "Balaji", "Hyderabad", 101, "Google", "USA");
        //emp1.EmployeeInfo();
        //emp1.CompanyInfo();

        //Salary emp2 = new Salary(2, "Ramesh", "Bangalore", 102, "Microsoft", "USA", 50000);
        //emp2.SalaryInfo();  
        //emp2.EmployeeInfo();
        //emp2.CompanyInfo();




        //Company emp1= new Company(1,"Balaji" ,"Google");

        //Company emp2 = new Company(2, "Ramesh");

        //Company emp3 = new Company { 
        //    Id = 3,
        //    Name = "Suresh", 
        //    CompanyName = "Microsoft"
        //};

        //List<Company> employees = new List<Company>
        //{
        //    new Company { Id = 5, Name = "John", CompanyName = "Facebook" },
        //    new Company { Id = 6, Name = "Jane", CompanyName = "Apple" },
        //    new Company { Id = 7, Name = "Bob", CompanyName = "Netflix" },
        //    new Company { Id = 8, Name = "Alice", CompanyName = "Tesla" }
        //};

        //foreach (var employee in employees)
        //{
        //    employee.EmployeeInfo();
        //}

        //Company emp4 = new Company();
        //emp4.Id = 4;
        //emp4.Name = "Kumar";
        //emp4.CompanyName = "Amazon";






    }
}

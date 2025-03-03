using EntityModels.Models;
using Microsoft.EntityFrameworkCore;
using Week3EntityFramework.Dtos;

var context = new IndustryConnectWeek2Context();

//var customer = new Customer
//{
//    DateOfBirth = DateTime.Now.AddYears(-20)
//};


//Console.WriteLine("Please enter the customer firstname?");

//customer.FirstName = Console.ReadLine();

//Console.WriteLine("Please enter the customer lastname?");

//customer.LastName = Console.ReadLine();


//var customers = context.Customers.ToList();

//foreach (Customer c in customers)
//{   
//    Console.WriteLine("Hello I'm " + c.FirstName);
//}

//Console.WriteLine($"Your new customer is {customer.FirstName} {customer.LastName}");

//Console.WriteLine("Do you want to save this customer to the database?");

//var response = Console.ReadLine();

//if (response?.ToLower() == "y")
//{
//    context.Customers.Add(customer);
//    context.SaveChanges();
//}


//--------------------------------------
//var sales = context.Sales.Include(c => c.Customer)
//    .Include(p => p.Product).ToList();

//var salesDto = new List<SaleDto>();

//foreach (Sale s in sales)
//{
//    salesDto.Add(new SaleDto(s));
//}
//------------------------------------


//context.Sales.Add(new Sale
//{
//    ProductId = 1,
//    CustomerId = 1,
//    StoreId = 1,
//    DateSold = DateTime.Now
//});


//context.SaveChanges();


//------------------

//Console.WriteLine("Which customer record would you like to update?");

//var response = Convert.ToInt32(Console.ReadLine());

//var customer = context.Customers.Include(s => s.Sales)
//    .ThenInclude(p => p.Product)
//    .FirstOrDefault(c => c.Id == response);


//var total = customer.Sales.Select(s => s.Product.Price).Sum();


//var customerSales = context.CustomerSales.ToList();

//-------------------------

//var totalsales = customer.Sales



//Console.WriteLine($"The customer you have retrieved is {customer?.FirstName} {customer?.LastName}");

//Console.WriteLine($"Would you like to updated the firstname? y/n");

//var updateResponse = Console.ReadLine();

//if (updateResponse?.ToLower() == "y")
//{

//    Console.WriteLine($"Please enter the new name");

//    customer.FirstName = Console.ReadLine();
//    context.Customers.Add(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
//    context.SaveChanges();
//}


//--Week 3 Software developer intern (Entity Framework)
//--1\Using the linq queries retrieve a list of all customers from the database who don't have sales

var customer = context.Customers.Where(s => !s.Sales.Any()).ToList();

foreach (var c in customer)
{
    Console.WriteLine($"{c.FirstName} {c.LastName}");
}

//--2\Insert a new customer with a sale record

context.Customers.Add(new Customer
{
    //Id = 9,
    FirstName = "Alice",
    LastName = "Brown",
    DateOfBirth = DateTime.Now.AddYears(-20)
});

context.Sales.Add(new Sale
{
    //Id = 3,
    CustomerId = 8,
    ProductId = 1,
    DateSold = DateTime.Now,
    StoreId = 1
});

context.SaveChanges();

//--3\Add a new store

context.Stores.Add(new Store
{
    Name = "London"
});

context.SaveChanges();

//--4\Find the list of all stores that have sales

var store = context.Stores.Where(c => c.Sales.Any()).ToList();

foreach (var s in store)
{
    Console.WriteLine($"{s.Id} {s.Name}");
}

Console.ReadLine();


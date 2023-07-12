//Interfaces Usecase - Diff Pdcts - Shopping Cart

using System;
using System.Collections.Generic;
					
public class Customer{

	public string Name {get; set;}
	
	public string Email {get; set;}
	
	public string Address {get; set;}
	
	public Customer(string name, string email, string address){
		this.Name = name;
		this.Email = email;
		this.Address = address;
	}

}

public interface IProduct{

	public string id {get; set;}
	
	public string Name {get; set;}
	
	public void ShipItem(Customer cust);
}

public interface IDigitalProduct : IProduct{

	public int downloadCount {get; set;}
}

public class PhysicalProduct : IProduct{

	public string id {get; set;}
	
	public string Name {get; set;}
	
	public PhysicalProduct(string title){
		this.Name = title;
	}
	
	public void ShipItem(Customer cust){
		Console.WriteLine($"Product {this.Name} is being shipped to {cust.Address}");
	}
}

public class DigitalProduct : IDigitalProduct{

	public string id {get; set;}
	
	public string Name {get; set;}
	
	//public int downloadCount_;
	
	//public int downloadCount {get => downloadCount; set => downloadCount = 5;}
	public int downloadCount {get; set;}
	
	public DigitalProduct(string title){
		this.Name = title;
		this.downloadCount = 6;
	}
	
	public void ShipItem(Customer cust){
		if(this.downloadCount > 1)
			Console.WriteLine($"Product {this.Name} is being emailed to {cust.Email}");
		
		this.downloadCount--;
		Console.WriteLine($"{this.downloadCount} downloads is left for {cust.Name}");
	}
}



public class CourseProduct : IProduct{

	public string id {get; set;}
	
	public string Name {get; set;}
	
	//public int downloadCount_;
	
	//public int downloadCount {get => downloadCount; set => downloadCount = 5;}
	//public int downloadCount {get; set;}
	
	public CourseProduct(string title){
		this.Name = title;
		//this.downloadCount = 6;
	}
	
	public void ShipItem(Customer cust){
		//if(this.downloadCount > 1)
			//Console.WriteLine($"Product {this.Name} is being emailed to {cust.Email}");
		
		//this.downloadCount--;
		Console.WriteLine($"{this.Name} course is now available for {cust.Name}");
	}
}

public class Program
{
	
	//public static List<PhysicalProduct> products {get; set;}
	
	public static void Main_()
	{
		Customer cust = new Customer("Some cust", "cuEmail", "cusAddr");
		List<IProduct> products = new List<IProduct>();
		//ShoppingCart cart = new ShoppingCart();
		var phyPdt = new PhysicalProduct("Phy Pdct 1");
		products.Add(phyPdt);
		products.Add(new PhysicalProduct("Phy Pdct 2"));
		
		products.Add(new DigitalProduct("Dig Pdct 1"));
		
		products.Add(new CourseProduct("Course Pdct 1"));
		
		//products.ForEach(prdct => prdct.ShipItem(cust));
		
		foreach(IProduct prdct in products){

			/*
			//for digital prdct check dload count
			if(prdct is IDigitalProduct digPdct){
				
				//prdct.downloadCount
			//	if(digPdct.downloadCount > 1)
					prdct.ShipItem(cust);
				
				//digPdct.downloadCount--;
				//Console.WriteLine($"{digPdct.downloadCount} is left for {cust.Name}");
			}
			else
				
				*/
				prdct.ShipItem(cust);
			
		}
		
		
		Console.WriteLine("Hello World");
	}
}

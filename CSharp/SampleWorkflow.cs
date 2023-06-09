using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class SampleWorkflow
    {

        static void main(string[] args) {

            List<PhysicalProduct> cart = AddSampleData();

            CustomerModel customer = new CustomerModel();

            foreach (PhysicalProduct product in cart)
                product.ShipItem(customer);


            Console.ReadLine();

        }


        private static CustomerModel NewCustomer() {

            return new CustomerModel
            {
                FirstName = "Raga",
                LastName = "Nagr",
                City = "Vancouver"

            };
        }



        private static List<PhysicalProduct> AddSampleData() { 
        
            List<PhysicalProduct> data = new List<PhysicalProduct>();

            data.Add(new PhysicalProduct { Title = "Product 1"});
            data.Add(new PhysicalProduct { Title = "Product 2"});

            return data;
        }

    }

}

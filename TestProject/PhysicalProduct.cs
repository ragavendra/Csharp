using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class PhysicalProduct : IProduct
    {
        public string Title { get; set; }

        public bool HasOrderCompleted { get; private set; }

        public void ShipItem(CustomerModel customerModel) {

            if (!HasOrderCompleted)
            {
                Console.WriteLine($"Order shipment of { Title } to { customerModel.City } has been completed");
                HasOrderCompleted = true;
            
            }
        
        
        }
    }
}

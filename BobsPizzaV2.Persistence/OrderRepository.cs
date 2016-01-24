using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobsPizzaV2.Persistence
{
    public class OrderRepository
    {
        public static void PlaceTestOrder()
        {
            Order testOrder = new Order();
            testOrder.Address = "Test Address 3";
            testOrder.Crust = DTO.Enums.CrustType.Thick;
            testOrder.GreenPeppers = true;
            testOrder.Name = "Test Name 3";
            testOrder.Onions = false;
            testOrder.OrderId = Guid.NewGuid();
            testOrder.PayementMethod = DTO.Enums.PaymentType.Credit;
            testOrder.Phone = "777-5555";
            testOrder.Size = DTO.Enums.SizeType.Medium;
            testOrder.TotalCost = 15.00M;
            testOrder.Zip = "99999";

            var db = new BobsPizzaDbEntities1();
            db.Orders.Add(testOrder);
            db.SaveChanges();
        }

        public static void AddNewOrder(DTO.DtoOrder pizza)
        {
            Order order = new Order();
            order.Address = pizza.Address;
            order.Completed = pizza.Completed;
            order.Crust = pizza.Crust;
            order.GreenPeppers = pizza.GreenPeppers;
            order.Name = pizza.Name;
            order.Onions = pizza.Onions;
            order.OrderId = pizza.OrderId;
            order.PayementMethod = pizza.PayementMethod;
            order.Pepperoni = pizza.Pepperoni;
            order.Phone = pizza.Phone;
            order.Sausage = pizza.Sausage;
            order.Size = pizza.Size;
            order.TotalCost = pizza.TotalCost;
            order.Zip = pizza.Zip;

            var db = new BobsPizzaDbEntities1();
            db.Orders.Add(order);
            db.SaveChanges();
        }

        public static List<DTO.DtoOrder> getOrders()
        {
            var db = new BobsPizzaDbEntities1();
            var orders = db.Orders.Where(p => p.Completed == false).ToList();
            var DTOorders = new List<DTO.DtoOrder>();

            foreach (var pizza in orders)
            {
                DTO.DtoOrder order = new DTO.DtoOrder();

                order.Address = pizza.Address;
                order.Completed = pizza.Completed;
                order.Crust = pizza.Crust;
                order.GreenPeppers = pizza.GreenPeppers;
                order.Name = pizza.Name;
                order.Onions = pizza.Onions;
                order.OrderId = pizza.OrderId;
                order.PayementMethod = pizza.PayementMethod;
                order.Pepperoni = pizza.Pepperoni;
                order.Phone = pizza.Phone;
                order.Sausage = pizza.Sausage;
                order.Size = pizza.Size;
                order.TotalCost = pizza.TotalCost;
                order.Zip = pizza.Zip;

                DTOorders.Add(order);
            }

            return DTOorders;
        }

        public static void MarkAsCompleted(Guid orderId)
        {
            var db = new BobsPizzaDbEntities1();
            var order = db.Orders.FirstOrDefault(p => p.OrderId == orderId);
            order.Completed = true;
            db.SaveChanges();
        }
    }
}

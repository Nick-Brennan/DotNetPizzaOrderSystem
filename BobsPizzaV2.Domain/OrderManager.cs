using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobsPizzaV2.Domain
{
    public class OrderManager
    {
        public static void PlaceTestOrder()
        {
            Persistence.OrderRepository.PlaceTestOrder();
        }

        public static void AddNewOrder(DTO.DtoOrder order)
        {
            order.OrderId = Guid.NewGuid();
            order.TotalCost = determinePrice(order);
            Persistence.OrderRepository.AddNewOrder(order);
        }

        public static decimal determinePrice(DTO.DtoOrder pizza)
        {
            var prices = Persistence.PriceRepository.getPrices();

            decimal pizzaCost = 0m;
            
            switch (pizza.Size)
            {
                case BobsPizzaV2.DTO.Enums.SizeType.Small:
                    pizzaCost += prices.Small;
                    break;
                case BobsPizzaV2.DTO.Enums.SizeType.Medium:
                    pizzaCost += prices.Medium;
                    break;
                case BobsPizzaV2.DTO.Enums.SizeType.Large:
                    pizzaCost += prices.Large;
                    break;
                default:
                    break;
            }

            pizzaCost += (pizza.Crust == DTO.Enums.CrustType.Thick) ? prices.Thick : 0;
            pizzaCost += (pizza.Sausage) ? prices.Sausage : 0;
            pizzaCost += (pizza.Pepperoni) ? prices.Pepperoni : 0;
            pizzaCost += (pizza.Onions) ? prices.Onions : 0;
            pizzaCost += (pizza.GreenPeppers) ? prices.GreenPeppers : 0;

            return pizzaCost;
        }

        public static List<DTO.DtoOrder> GetOrders()
        {
            return Persistence.OrderRepository.getOrders();
        }

        public static void MarkAsCompleted(Guid orderId)
        {
            Persistence.OrderRepository.MarkAsCompleted(orderId);
        }
    }
}

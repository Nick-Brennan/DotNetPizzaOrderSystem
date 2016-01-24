using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BobsPizzaV2.Persistence
{
    public class PriceRepository
    {
        public static DTO.PricesDTO getPrices()
        {
            var db = new BobsPizzaDbEntities1();
            var prices = db.Prices.First();

            DTO.PricesDTO pricesDTO = new DTO.PricesDTO();

            pricesDTO.Small = prices.Small;
            pricesDTO.Medium = prices.Medium;
            pricesDTO.Large = prices.Large;
            pricesDTO.Regular = prices.Regular;
            pricesDTO.Thin = prices.Thin;
            pricesDTO.Thick = prices.Thick;
            pricesDTO.Sausage = prices.Sausage;
            pricesDTO.Pepperoni = prices.Pepperoni;
            pricesDTO.Onions = prices.Onions;
            pricesDTO.GreenPeppers = prices.GreenPeppers;

            return pricesDTO;
        }
        
    }
}

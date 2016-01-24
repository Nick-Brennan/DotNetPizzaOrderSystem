﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobsPizzaV2.DTO
{
    public class DtoOrder
    {
        public System.Guid OrderId { get; set; }
        public BobsPizzaV2.DTO.Enums.SizeType Size { get; set; }
        public BobsPizzaV2.DTO.Enums.CrustType Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onions { get; set; }
        public bool GreenPeppers { get; set; }
        public decimal TotalCost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public BobsPizzaV2.DTO.Enums.PaymentType PayementMethod { get; set; }
        public bool Completed { get; set; }
    }
}
using System;

namespace MAD.API.Docketbook.Orders
{
    public class OrderLineDto
    {
        public string ItemDescription { get; set; }
        public string CustomerRef { get; set; }
        public double Quantity { get; set; }
        public string Status { get; set; }
        public Guid? Id { get; set; }
        public bool? Delete { get; set; }
    }
}
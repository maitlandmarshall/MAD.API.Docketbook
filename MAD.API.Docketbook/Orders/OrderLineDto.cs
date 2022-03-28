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

        public string SupplierRef { get; set; }

        public Guid? Resource { get; set; }
        public Guid? ResourceCategory { get; set; }

        public UomDto Uom { get; set; }

        public class UomDto
        {
            public Guid Id { get; set; }
            public string Abbreviation { get; set; }
            public string Description { get; set; }
            public Guid Organisation { get; set; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Docketbook.Orders
{
    public class OrderDto
    {
        public Guid OrganisationId { get; set; }
        public Guid GroupId { get; set; }
        public Guid? Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerRefNo { get; set; }

        public IEnumerable<OrderLineDto> LineItems { get; set; }

        public OrderContactDto CustomerContact { get; set; }
        public OrderContactDto SupplierContact { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Docketbook.Orders
{
    public partial class Order
    {
        public Guid OwnerOrganisation { get; set; }
        public Guid OwnerOrganisationGroup { get; set; }
    }
}

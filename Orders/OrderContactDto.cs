using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace MAD.API.Docketbook.Orders
{
    public class OrderContactDto
    {
        public IEnumerable<Address> Addresses { get; set; }
        public JObject ContactAddresses { get; set; }
        public string DisplayName { get; set; }
    }
}

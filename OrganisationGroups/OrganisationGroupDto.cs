using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MAD.API.Docketbook.OrganisationGroups
{
    public class OrganisationGroupDto
    {
        public IEnumerable<string> Owners { get; set; }
        public string Name { get; set; }
        public string PublicName { get; set; }
        public string Timezone { get; set; }

        public Guid Organisation { get; set; }
        public Guid? Parent { get; set; }
        public Guid? OrganisationGroupId { get; set; }

        public string Prefix { get; set; }

        public string Description { get; set; }
        public string TimeFormat { get; set; }
        public AddressDto Address { get; set; }

        public Guid? DefaultTemplate { get; set; }

        public class AddressDto
        {
            [JsonProperty("streetName")]
            public string StreetName { get; set; }

            [JsonProperty("suburb")]
            public string Suburb { get; set; }

            [JsonProperty("state")]
            public string State { get; set; }

            [JsonProperty("postCode")]
            public string PostCode { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("designation")]
            public string Designation { get; set; }

            [JsonProperty("num", NullValueHandling = NullValueHandling.Ignore)]
            public string Num { get; set; }

            [JsonProperty("streetNum", NullValueHandling = NullValueHandling.Ignore)]
            public string StreetNum { get; set; }
        }

    }
}

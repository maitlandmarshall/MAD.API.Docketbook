namespace MAD.API.Docketbook.OrganisationGroups
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public partial class OrganisationGroup
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organisation")]
        public Guid Organisation { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("emailAddresses")]
        public List<string> EmailAddresses { get; set; }

        [JsonProperty("parent")]
        public Guid? Parent { get; set; }

        [JsonProperty("parents")]
        public List<Guid> Parents { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefix { get; set; }

        [JsonProperty("orderPrefix")]
        public string OrderPrefix { get; set; }

        [JsonProperty("jobPrefix")]
        public string JobPrefix { get; set; }

        [JsonProperty("docketPrefix")]
        public string DocketPrefix { get; set; }

        [JsonProperty("publicName")]
        public string PublicName { get; set; }

        [JsonProperty("members")]
        public List<OrganisationGroupMember> Members { get; set; }

        [JsonProperty("owners")]
        public List<Guid> Owners { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("inheritsPermissions")]
        public bool InheritsPermissions { get; set; }

        [JsonProperty("inheritsAddressBook")]
        public bool InheritsAddressBook { get; set; }

        [JsonProperty("defaultTemplate")]
        public string DefaultTemplate { get; set; }

        [JsonProperty("monitors")]
        public JArray Monitors { get; set; }

        [JsonProperty("root")]
        public bool Root { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timeFormat")]
        public string TimeFormat { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

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

    public partial class OrganisationGroupMember
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("user")]
        public Guid User { get; set; }

        [JsonProperty("role")]
        public Guid Role { get; set; }
    }
}

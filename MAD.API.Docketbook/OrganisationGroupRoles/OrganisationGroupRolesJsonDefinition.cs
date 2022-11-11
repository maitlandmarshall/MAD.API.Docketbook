namespace MAD.API.Docketbook.OrganisationGroupRoles
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public partial class OrganisationGroupRole
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("organisation")]
        public Guid Organisation { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("global")]
        public bool Global { get; set; }

        [JsonProperty("permissions")]
        public List<OrganisationGroupRolePermission> Permissions { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class OrganisationGroupRolePermission
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }

        [JsonProperty("deny")]
        public bool Deny { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }
}

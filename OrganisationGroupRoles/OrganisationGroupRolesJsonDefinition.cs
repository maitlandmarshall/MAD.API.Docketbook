namespace MAD.API.Docketbook.OrganisationGroupRoles
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

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
    }

    public partial class OrganisationGroupRolePermission
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }

        [JsonProperty("deny")]
        public bool Deny { get; set; }
    }
}

namespace MAD.API.Docketbook.OrganisationGroupMembers
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public partial class OrganisationGroupMember
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("invitationPending")]
        public bool InvitationPending { get; set; }

        [JsonProperty("emailAddresses")]
        public List<string> EmailAddresses { get; set; }

        [JsonProperty("forwardingAddresses")]
        public List<string> ForwardingAddresses { get; set; }

        [JsonProperty("preferEmailNotifications")]
        public bool PreferEmailNotifications { get; set; }

        [JsonProperty("docketPdfInNotifications")]
        public bool DocketPdfInNotifications { get; set; }

        [JsonProperty("receiveOrderNotifications")]
        public bool ReceiveOrderNotifications { get; set; }

        [JsonProperty("receiveSelfNotifications")]
        public bool ReceiveSelfNotifications { get; set; }

        [JsonProperty("unverifiedPrincipals")]
        public List<string> UnverifiedPrincipals { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("restricted")]
        public bool Restricted { get; set; }

        [JsonProperty("onDocketbook")]
        public bool OnDocketbook { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class Name
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("full")]
        public string Full { get; set; }
    }
}

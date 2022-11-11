namespace MAD.API.Docketbook.Organisations
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;

    public partial class Organisation
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("dnsName")]
        public string DnsName { get; set; }

        [JsonProperty("primaryDnsName")]
        public string PrimaryDnsName { get; set; }

        [JsonProperty("globalAdministrators")]
        public List<Guid> GlobalAdministrators { get; set; }

        [JsonProperty("contacts")]
        public List<OrganisationContact> Contacts { get; set; }

        [JsonProperty("currentPlanId")]
        public string CurrentPlanId { get; set; }

        [JsonProperty("accessAllowed")]
        public bool AccessAllowed { get; set; }

        [JsonProperty("accessReason")]
        public string AccessReason { get; set; }

        [JsonProperty("betaAllowed")]
        public bool BetaAllowed { get; set; }

        [JsonProperty("logoAttachmentName")]
        public string LogoAttachmentName { get; set; }

        [JsonProperty("features")]
        public Dictionary<string, object> Features { get; set; }

        [JsonProperty("identities")]
        public JObject Identities { get; set; }

        [JsonProperty("groups")]
        public List<Group> Groups { get; set; }

        [JsonProperty("plan")]
        public OrganisationPlan Plan { get; set; }

        [JsonProperty("trial_end")]
        public long TrialEnd { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class OrganisationContact
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contactType")]
        public string ContactType { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class Group
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

        [JsonProperty("orderPrefix")]
        public string OrderPrefix { get; set; }

        [JsonProperty("jobPrefix")]
        public string JobPrefix { get; set; }

        [JsonProperty("docketPrefix")]
        public string DocketPrefix { get; set; }

        [JsonProperty("publicName")]
        public string PublicName { get; set; }

        [JsonProperty("members")]
        public List<Member> Members { get; set; }

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

        [JsonProperty("prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefix { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class Address
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("num", NullValueHandling = NullValueHandling.Ignore)]
        public string Num { get; set; }

        [JsonProperty("streetNum", NullValueHandling = NullValueHandling.Ignore)]
        public string StreetNum { get; set; }

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

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class Member
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("user")]
        public Guid User { get; set; }

        [JsonProperty("role")]
        public Guid Role { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class OrganisationPlan
    {
        [JsonProperty("features")]
        public PlanFeatures Features { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class PlanFeatures
    {
        [JsonProperty("accountingIntegrationEnabled")]
        public string AccountingIntegrationEnabled { get; set; }

        [JsonProperty("docketsCreate")]
        public string DocketsCreate { get; set; }

        [JsonProperty("docketsCreateBatches")]
        public string DocketsCreateBatches { get; set; }

        [JsonProperty("docketsCreateFromJob")]
        public string DocketsCreateFromJob { get; set; }

        [JsonProperty("docketsEnabled")]
        public string DocketsEnabled { get; set; }

        [JsonProperty("docketsFiling")]
        public string DocketsFiling { get; set; }

        [JsonProperty("docketsHistoricalDateLimit")]
        public string DocketsHistoricalDateLimit { get; set; }

        [JsonProperty("docketsReports")]
        public string DocketsReports { get; set; }

        [JsonProperty("docketsTimesheetsView")]
        public string DocketsTimesheetsView { get; set; }

        [JsonProperty("docketsViewBatches")]
        public string DocketsViewBatches { get; set; }

        [JsonProperty("includedDockets")]
        public string IncludedDockets { get; set; }

        [JsonProperty("includedOrganisationGroups")]
        public string IncludedOrganisationGroups { get; set; }

        [JsonProperty("includedUsers")]
        public string IncludedUsers { get; set; }

        [JsonProperty("invoicesEnabled")]
        public string InvoicesEnabled { get; set; }

        [JsonProperty("jobsAllocationsView")]
        public string JobsAllocationsView { get; set; }

        [JsonProperty("jobsCreate")]
        public string JobsCreate { get; set; }

        [JsonProperty("jobsEnabled")]
        public string JobsEnabled { get; set; }

        [JsonProperty("jobsSubcontractorAllocation")]
        public string JobsSubcontractorAllocation { get; set; }

        [JsonProperty("ordersCreate")]
        public string OrdersCreate { get; set; }

        [JsonProperty("ordersEnabled")]
        public string OrdersEnabled { get; set; }

        [JsonProperty("perDocketPrice")]
        public string PerDocketPrice { get; set; }

        [JsonProperty("reportingEnabled")]
        public string ReportingEnabled { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }
}

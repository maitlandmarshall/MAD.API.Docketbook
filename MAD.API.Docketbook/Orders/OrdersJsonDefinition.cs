using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace MAD.API.Docketbook.Orders
{
    public partial class Order
    {
        [JsonProperty("accessControl")]
        public JObject AccessControl { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("customerContact")]
        public Contact CustomerContact { get; set; }

        [JsonProperty("customerRefNo")]
        public string CustomerRefNo { get; set; }

        [JsonProperty("docketPrefillValueStore")]
        public JObject DocketPrefillValueStore { get; set; }

        [JsonProperty("docketsVisibleInDraft")]
        public bool DocketsVisibleInDraft { get; set; }

        [JsonProperty("endDate")]
        public DateTimeOffset EndDate { get; set; }

        [JsonProperty("eventLog")]
        public List<OrderEventLog> EventLog { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("jobPop")]
        public JArray JobPop { get; set; }

        [JsonProperty("lineItems")]
        public List<OrderItem> LineItems { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("orderNumber")]
        public string OrderNumber { get; set; }

        [JsonProperty("organisation")]
        public Guid Organisation { get; set; }

        [JsonProperty("organisationGroup")]
        public Guid OrganisationGroup { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("supplierContact")]
        public Contact SupplierContact { get; set; }

        [JsonProperty("supplierRefNo")]
        public string SupplierRefNo { get; set; }

        [JsonProperty("template")]
        public Guid Template { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("tracked")]
        public bool Tracked { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class OrderItem
    {
        [JsonProperty("fields")]
        public JArray Fields { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("itemDescription")]
        public string ItemDescription { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("resource")]
        public Resource Resource { get; set; }

        [JsonProperty("supplierRef")]
        public string SupplierRef { get; set; }

        [JsonProperty("customerRef")]
        public string CustomerRef { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class Resource
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("tags")]
        public JArray Tags { get; set; }

        [JsonProperty("uomId")]
        public Guid UomId { get; set; }

        [JsonProperty("categoryId")]
        public Guid CategoryId { get; set; }

        [JsonProperty("organisation")]
        public Guid Organisation { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("externalIdentifiers")]
        public JArray ExternalIdentifiers { get; set; }

        [JsonProperty("uom")]
        public Uom Uom { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class Category
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("organisation")]
        public Guid Organisation { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class Uom
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("organisation")]
        public Guid Organisation { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isTime")]
        public bool IsTime { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class OrderEventLog
    {
        [JsonProperty("addedOn")]
        public DateTimeOffset AddedOn { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("user")]
        public Guid User { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class Contact
    {
        [JsonProperty("addresses")]
        public List<Address> Addresses { get; set; }

        [JsonProperty("contactAddresses")]
        public JObject ContactAddresses { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("reassignments")]
        public JArray Reassignments { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class Address
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("postCode")]
        public string PostCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        [JsonProperty("streetNum")]
        public string StreetNum { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("num", NullValueHandling = NullValueHandling.Ignore)]
        public string Num { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }
}

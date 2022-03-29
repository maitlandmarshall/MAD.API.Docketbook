using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace MAD.API.Docketbook.Dockets
{
    public partial class Docket
    {
        [JsonProperty("accessControl")]
        public JObject AccessControl { get; set; }

        [JsonProperty("additionalContacts")]
        public List<object> AdditionalContacts { get; set; }

        [JsonProperty("attachments")]
        public List<Attachment> Attachments { get; set; }

        [JsonProperty("author")]
        public Guid Author { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("breakTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? BreakTime { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("customerContact", NullValueHandling = NullValueHandling.Ignore)]
        public CustomerContact CustomerContact { get; set; }

        [JsonProperty("customerRefNo", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerRefNo { get; set; }

        [JsonProperty("customerSignatureName", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerSignatureName { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("docketNumber")]
        public string DocketNumber { get; set; }

        [JsonProperty("endTime")]
        public DateTimeOffset? EndTime { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("orderRef", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrderRef { get; set; }

        [JsonProperty("organisation")]
        public Guid Organisation { get; set; }

        [JsonProperty("organisationGroup")]
        public Guid OrganisationGroup { get; set; }

        [JsonProperty("resources")]
        public List<DocketResource> Resources { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subDockets")]
        public List<object> SubDockets { get; set; }

        [JsonProperty("supplierContact")]
        public SupplierContact SupplierContact { get; set; }

        [JsonProperty("startTime")]
        public DateTimeOffset? StartTime { get; set; }

        [JsonProperty("supplierRefNo", NullValueHandling = NullValueHandling.Ignore)]
        public string SupplierRefNo { get; set; }

        [JsonProperty("template")]
        public Template Template { get; set; }

        [JsonProperty("tracked")]
        public bool Tracked { get; set; }

        [JsonProperty("travelTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? TravelTime { get; set; }

        [JsonProperty("updateHash")]
        public string UpdateHash { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("visibleInDraft")]
        public bool VisibleInDraft { get; set; }

        [JsonProperty("jobRef", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? JobRef { get; set; }

        [JsonProperty("acceptedBy", NullValueHandling = NullValueHandling.Ignore)]
        public AcceptedBy AcceptedBy { get; set; }

        [JsonProperty("rejectionComment", NullValueHandling = NullValueHandling.Ignore)]
        public string RejectionComment { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public class DocketTemplateValueStore
    {
        [JsonProperty("templateValueStore")]
        public JObject TemplateValueStore { get; set; }
    }

    public partial class AcceptedBy
    {
        [JsonProperty("organisation")]
        public string Organisation { get; set; }

        [JsonProperty("organisationGroup")]
        public string OrganisationGroup { get; set; }

        [JsonProperty("organisationGroupId")]
        public Guid OrganisationGroupId { get; set; }

        [JsonProperty("organisationId")]
        public Guid OrganisationId { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("userId")]
        public Guid UserId { get; set; }
    }

    public partial class Attachment
    {
        [JsonProperty("author")]
        public Guid Author { get; set; }

        [JsonProperty("authorName")]
        public string AuthorName { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }
    }

    public partial class CustomerContact
    {
        [JsonProperty("addresses")]
        public List<CustomerContactAddress> Addresses { get; set; }

        [JsonProperty("contactAddresses")]
        public JObject ContactAddresses { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("reassignments")]
        public List<object> Reassignments { get; set; }
    }

    public partial class CustomerContactAddress
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
    }


    public partial class DocketResource
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("interactions")]
        public List<Interaction> Interactions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("orderItemId")]
        public Guid OrderItemId { get; set; }

        [JsonProperty("resource")]
        public Resource Resource { get; set; }

        [JsonProperty("uniqueIdentifier", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueIdentifier { get; set; }
    }

    public partial class Interaction
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("customFields")]
        public JObject CustomFields { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("interactionName")]
        public string InteractionName { get; set; }

        [JsonProperty("interactionTemplate")]
        public InteractionInteractionTemplate InteractionTemplate { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("resource")]
        public Resource Resource { get; set; }

        [JsonProperty("resourceIsParent")]
        public bool ResourceIsParent { get; set; }
    }

    public partial class InteractionInteractionTemplate
    {
        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("fields")]
        public List<InteractionTemplateField> Fields { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("refersParent")]
        public bool RefersParent { get; set; }

        [JsonProperty("xeroQuantity")]
        public bool XeroQuantity { get; set; }
    }

    public partial class InteractionTemplateField
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("mandatory")]
        public bool Mandatory { get; set; }

        [JsonProperty("selectionFields")]
        public List<object> SelectionFields { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Resource
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("categoryId")]
        public Guid CategoryId { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organisation")]
        public Guid Organisation { get; set; }

        [JsonProperty("uom")]
        public Uom Uom { get; set; }

        [JsonProperty("uomId")]
        public Guid UomId { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organisation")]
        public Guid Organisation { get; set; }
    }

    public partial class Uom
    {
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("isTime")]
        public bool IsTime { get; set; }

        [JsonProperty("organisation")]
        public Guid Organisation { get; set; }
    }

    public partial class SupplierContact
    {
        [JsonProperty("addresses")]
        public List<SupplierContactAddress> Addresses { get; set; }

        [JsonProperty("contactAddresses")]
        public JObject ContactAddresses { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("reassignments")]
        public List<object> Reassignments { get; set; }
    }

    public partial class SupplierContactAddress
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("num")]
        public string Num { get; set; }

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
    }

    public partial class Template
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("additionalContactNames")]
        public List<object> AdditionalContactNames { get; set; }

        [JsonProperty("attachments")]
        public List<object> Attachments { get; set; }

        [JsonProperty("blocks")]
        public List<Block> Blocks { get; set; }

        [JsonProperty("checklistContainers")]
        public List<ChecklistContainer> ChecklistContainers { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("interactionTemplates")]
        public List<InteractionTemplateElement> InteractionTemplates { get; set; }

        [JsonProperty("minimumInteractionRequired")]
        public bool MinimumInteractionRequired { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("populateResourcesFromJob")]
        public bool PopulateResourcesFromJob { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("signature")]
        public bool Signature { get; set; }

        [JsonProperty("organisation", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Organisation { get; set; }
    }

    public partial class Block
    {
        [JsonProperty("fields")]
        public List<BlockField> Fields { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("location")]
        public long Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class BlockField
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("mandatory")]
        public bool Mandatory { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }

        [JsonProperty("referenceName")]
        public string ReferenceName { get; set; }

        [JsonProperty("selectionFields")]
        public List<object> SelectionFields { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; } = new Dictionary<string, object>();
    }

    public partial class ChecklistContainer
    {
        [JsonProperty("checklistTemplate")]
        public ChecklistTemplate ChecklistTemplate { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("location")]
        public long Location { get; set; }

        [JsonProperty("rule")]
        public string Rule { get; set; }
    }

    public partial class ChecklistTemplate
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("fields")]
        public List<ChecklistTemplateField> Fields { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organisation")]
        public Guid Organisation { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class ChecklistTemplateField
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }
    }

    public partial class InteractionTemplateElement
    {
        [JsonProperty("actorCategories")]
        public List<Category> ActorCategories { get; set; }

        [JsonProperty("actorFromOrder")]
        public bool ActorFromOrder { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("categories")]
        public List<object> Categories { get; set; }

        [JsonProperty("childFromOrder")]
        public bool ChildFromOrder { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields")]
        public List<InteractionTemplateField> Fields { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("refersParent")]
        public bool RefersParent { get; set; }

        [JsonProperty("xeroQuantity")]
        public bool XeroQuantity { get; set; }
    }
}

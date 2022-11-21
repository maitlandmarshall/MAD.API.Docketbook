namespace MAD.API.Docketbook.FileCodes
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;

    public partial class DocketFile
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("docketRef")]
        public Guid DocketRef { get; set; }

        [JsonProperty("fileMethod")]
        public string FileMethod { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("lineCodes")]
        public List<DocketFileLineCode> LineCodes { get; set; }

        [JsonProperty("orderRef")]
        public Guid OrderRef { get; set; }

        [JsonProperty("organisation")]
        public Guid Organisation { get; set; }

        [JsonProperty("organisationGroup")]
        public Guid OrganisationGroup { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public partial class DocketFileLineCode
    {
        [JsonProperty("fileCodes")]
        public Dictionary<string, long> FileCodes { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("interaction")]
        public Interaction Interaction { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("resource")]
        public DflResource Resource { get; set; }

        public partial class DflResource
        {
            [JsonProperty("active")]
            public bool Active { get; set; }

            [JsonProperty("category")]
            public RscCategory Category { get; set; }

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
            public RscUom Uom { get; set; }

            [JsonProperty("uomId")]
            public Guid UomId { get; set; }

            public partial class RscCategory
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

            public partial class RscUom
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
        }
    }

    public partial class Interaction
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("customFields")]
        public JToken CustomFields { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("interactionName")]
        public string InteractionName { get; set; }

        [JsonProperty("interactionTemplate")]
        public InteractionTemplate InteractionTemplate { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("long")]
        public double Long { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("resource")]
        public InteractionResource Resource { get; set; }

        [JsonProperty("resourceIsParent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResourceIsParent { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }


        public partial class InteractionResource
        {
            [JsonProperty("active")]
            public bool Active { get; set; }

            [JsonProperty("category")]
            public RscCategory Category { get; set; }

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
            public RscUom Uom { get; set; }

            [JsonProperty("uomId")]
            public Guid UomId { get; set; }

            public partial class RscCategory
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

            public partial class RscUom
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
        }
    }

    public partial class InteractionTemplate
    {
        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("fields")]
        public List<Field> Fields { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("refersParent")]
        public bool RefersParent { get; set; }

        [JsonProperty("xeroQuantity")]
        public bool XeroQuantity { get; set; }

        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Categories { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    public partial class Field
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

}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Docketbook.FileCodes
{
    public class FileCode
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organisation")]
        public Guid Organisation { get; set; }

        [JsonProperty("organisationGroup")]
        public Guid OrganisationGroup { get; set; }

        [JsonProperty("uniqueIdentifier")]
        public Guid UniqueIdentifier { get; set; }

        [JsonProperty("fileCode")]
        public string FileCodeName { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("costCode")]
        public string CostCode { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}

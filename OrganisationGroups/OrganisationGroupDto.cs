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
    }
}

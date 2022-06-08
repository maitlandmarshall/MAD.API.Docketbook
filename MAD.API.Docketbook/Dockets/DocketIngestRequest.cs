using System;
using System.Collections.Generic;

namespace MAD.API.Docketbook.Dockets
{
    public class DocketIngestRequest
    {
        public Guid SourceOrganisationGroupId { get; set; }
        public Guid OrganisationId { get; set; }

        public IEnumerable<DocketIngestDto> Dockets { get; set; }
    }
}

using System.Collections.Generic;

namespace MAD.API.Docketbook.Dockets
{
    public class DocketIngestResponseDto
    {
        public string Id { get; set; }
        public IEnumerable<DocketIngestResponseDocketDto> Dockets { get; set; }
    }
}

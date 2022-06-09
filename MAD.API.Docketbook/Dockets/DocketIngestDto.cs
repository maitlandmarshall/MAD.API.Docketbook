using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Docketbook.Dockets
{
    public class DocketIngestDto
    {
        [JsonConverter(typeof(DocketIngestDtoDateTimeConverter))]
        public DateTime Date { get; set; }
        public string Operator { get; set; }
        public string DocketNumber { get; set; }
        public string CustomerRefNo { get; set; }

        public IEnumerable<DocketIngestItemDto> Items { get; set; }
    }
}

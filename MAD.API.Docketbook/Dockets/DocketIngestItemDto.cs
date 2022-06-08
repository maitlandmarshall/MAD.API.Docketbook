using System;

namespace MAD.API.Docketbook.Dockets
{
    public class DocketIngestItemDto
    {
        public string ResourceName { get; set; }
        public string ResourceId { get; set; }
        public string UnitOfMeasure { get; set; }
        public double Quantity { get; set; }

        public DateTimeOffset Timestamp { get; set; }
    }
}
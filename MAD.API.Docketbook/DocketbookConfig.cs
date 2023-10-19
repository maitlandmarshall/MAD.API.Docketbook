namespace MAD.API.Docketbook
{
    public class DocketbookConfig
    {
        public string DbSharedKeyId { get; set; }
        public string DbSharedKey { get; set; }
        public string ApiUrl { get; set; } = "https://my.docketbook.com.au/v1/";
        public string IngestorApiUrl { get; set; } = "https://ingestor.docketbook.io/";
    }
}

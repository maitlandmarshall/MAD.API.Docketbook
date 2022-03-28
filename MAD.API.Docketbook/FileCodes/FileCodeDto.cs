using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAD.API.Docketbook.FileCodes
{
    public class FileCodeDto
    {
        public Guid Organisation { get; set; }
        public Guid OrganisationGroup { get; set; }

        public string FileCode { get; set; }
        public string FileName { get; set; }
        public string CostCode { get; set; }
        public bool Active { get; set; }
        public JObject SystemCodes { get; set; }
    }
}

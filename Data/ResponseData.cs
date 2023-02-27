using System.Collections;
using System.Collections.Generic;

namespace fullstack.Data
{
    public class ResponseData
    {
        public string? response { get; set; }

        public ResponseData(string? response)
        {
            this.response = response;
        }
    }
}

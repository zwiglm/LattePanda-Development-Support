using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiFirmata.Domain;

namespace ZiFirmata.Container
{
    public class StringResult
    {
        public StringResult(string wholeResult) {
            string[] stringParts = wholeResult.Split(GlobalConstants.STRING_DELIMITER);
            this.Key = stringParts[0];
            this.Value01 = stringParts[1];
            this.Value02 = stringParts[2];
        }

        public string Key { get; set; }
        public string Value01 { get; set; }
        public string Value02 { get; set; }
    }
}

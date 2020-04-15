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
            this.Value = stringParts[1];
        }

        public string Key { get; set; }
        public string Value { get; set; }
    }
}

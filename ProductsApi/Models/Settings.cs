using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Models
{
    public class Settings
    {
        public string StringValue { get; set; }
        public int IntegerValue { get; set; }
        public DateTime DateTimeValue { get; set; }
        public bool BooleanValue { get; set; }
        public TimeSpan TimeSpanValue { get; set; }
    }
}

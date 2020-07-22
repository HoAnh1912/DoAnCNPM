using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sql_anh_api.Models
{
    public class Weather
    {
        public long Id { get; set; }
        public string City { get; set; }
        public long TempC { get; set; }
        public long Humidity { get; set; }
        public string Datetime { get; set; }
    }
}

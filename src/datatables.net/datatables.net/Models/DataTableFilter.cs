using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTables.Net.Models
{
    public class DataTableFilter
    {
        public string Name { get; set; }
        public DataTableFilterOperators Operator { get; set; }
        public object Value { get; set; }
    }
}

using DataTables.Net.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTables.Net
{
    public class DataTableRequest
    {
        public string Name { get; set; }
        public int Draw { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }
        public DataTableColumn[] Columns { get; set; }
        public DataTableOrder[] Order { get; set; }
        public DataTableSearch Search { get; set; }
        public DataTableFilter[] filters { get; set; }
    }
}

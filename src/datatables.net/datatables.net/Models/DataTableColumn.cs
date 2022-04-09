using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTables.Net
{
    public class DataTableColumn
    {
        public string Data { get; set; }
        public string Name { get; set; }
        public bool Searchable { get; set; }
        public bool Orderable { get; set; }
        public bool Visible { get; set; }
        public string Title { get; set; }
        public DataTableSearch Search { get; set; }
    }
}

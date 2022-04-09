using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTables.Net
{
    public class DataTableOrder
    {
        /// <summary>
        /// Column Index
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        /// Order Direction, supported vals is asc/desc
        /// </summary>
        public string Dir { get; set; }
    }
}

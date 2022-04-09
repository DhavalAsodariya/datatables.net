using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace DataTables.Net
{
    public static class DataTableExtensions
    {
        public static DataTableResponse<T> ToDataTableResponse<T>(this IQueryable<T> query, DataTableRequest dataTableRequest)
        {
            

            // total records
            var recordsTotal = query.Count();

            // TODO: do column filter if any

            // TODO: do power search if not null or empty

            // TODO: do custom filter 

            // sorting
            if (dataTableRequest.Order?.Length > 0)
                query = query.OrderBy(string.Join(", ", dataTableRequest.Order.Select(o => $"{dataTableRequest.Columns[o.Column].Name} {o.Dir}")));

            // filtered records
            var recordsFiltered = query.Count();

            // paging
            if(dataTableRequest.Length != -1)
                query = query.Skip(dataTableRequest.Start).Take(dataTableRequest.Length);

            // prepare datatable response
            DataTableResponse<T> response = new DataTableResponse<T>
            {
                Draw = dataTableRequest.Draw,
                RecordsTotal = recordsTotal,
                RecordsFiltered = recordsFiltered,
                Data = query.ToArray()
            };

            return response;
        }
    }
}

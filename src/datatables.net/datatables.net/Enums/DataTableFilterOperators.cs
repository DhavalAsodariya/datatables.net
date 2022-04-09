using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTables.Net
{
    public enum DataTableFilterOperators
    {
        [SupportedTypes(typeof(string), typeof(int), typeof(DateTime))]
        [Description("Is equal to")]
        IsEqualTo,

        [SupportedTypes(typeof(string), typeof(int), typeof(DateTime))]
        [Description("")]
        IsNotEqualTo,

        [SupportedTypes(typeof(int), typeof(DateTime))]
        [Description("Is greater than or equal to")]
        IsGreaterThanOrEqualTo,

        [SupportedTypes(typeof(int), typeof(DateTime))]
        [Description("Is greater than")]
        IsGreaterThan,

        [SupportedTypes(typeof(int), typeof(DateTime))]
        [Description("Is less than or equal to")]
        IsLessThanOrEqualTo,

        [SupportedTypes(typeof(int), typeof(DateTime))]
        [Description("Is less than")]
        IsLessThan,

        [SupportedTypes(typeof(string))]
        [Description("Starts with")]
        StartsWith,

        [SupportedTypes(typeof(string))]
        [Description("Contains")]
        Contains,

        [SupportedTypes(typeof(string))]
        [Description("Does not contain")]
        DoesNotContain,

        [SupportedTypes(typeof(string))]
        [Description("Ends with")]
        EndsWith,

        [SupportedTypes(typeof(string), typeof(int), typeof(DateTime))]
        [Description("Is null")]
        IsNull,

        [SupportedTypes(typeof(string), typeof(int), typeof(DateTime))]
        [Description("Is not null")]
        IsNotNull,

        [SupportedTypes(typeof(string))]
        [Description("Is empty")]
        IsEmpty,

        [SupportedTypes(typeof(string))]
        [Description("Is not empty")]
        IsNotEmpty,

        [SupportedTypes(typeof(string))]
        [Description("Has no value")]
        HasNoValue,

        [SupportedTypes(typeof(string))]
        [Description("Has value")]
        HasValue,

        [SupportedTypes(typeof(int), typeof(DateTime))]
        [Description("Between")]
        Between,
    }
}

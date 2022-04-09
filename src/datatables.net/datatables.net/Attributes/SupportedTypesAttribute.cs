
namespace DataTables.Net
{
    internal class SupportedTypesAttribute : Attribute
    {
        public Type[] types { get; set; }

        public SupportedTypesAttribute(params Type[] types)
        {
            this.types = types;
        } 
    }
}
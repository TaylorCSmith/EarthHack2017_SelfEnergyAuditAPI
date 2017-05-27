using System;

namespace EnergyAudit.Data.DocumentDb.Extensions
{
    public static class DocumentDbExtensions
    {
        public static string GetCollectionId(this Type value)
        {
            return value.Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStore.DataLayer
{
    public static class StoredProcedures
    {
        public const string Lead_Add = "Lead_Add";
        public const string Lead_Delete = "Lead_Delete";
        public const string Lead_GetAll = "Lead_GetAll";
        public const string Lead_GetById = "Lead_GetById";
        public const string Lead_Update = "Lead_Update";

        public const string Service_Add = "Service_Add";
        public const string Service_Delete = "Service_Delete";
        public const string Service_GetAll = "Service_GetAll";
        public const string Service_GetById = "Service_GetById";
        public const string Service_Update = "Service_Update";
    }
}

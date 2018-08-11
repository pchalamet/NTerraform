using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_storage_account_sas : NTerraform.data
    {
        public class permissions
        {
            public permissions(bool @add,
                               bool @create,
                               bool @delete,
                               bool @list,
                               bool @process,
                               bool @read,
                               bool @update,
                               bool @write)
            {
                @Add = @add;
                @Create = @create;
                @Delete = @delete;
                @List = @list;
                @Process = @process;
                @Read = @read;
                @Update = @update;
                @Write = @write;
            }

            public bool @Add { get; }
            public bool @Create { get; }
            public bool @Delete { get; }
            public bool @List { get; }
            public bool @Process { get; }
            public bool @Read { get; }
            public bool @Update { get; }
            public bool @Write { get; }
        }

        public class resource_types
        {
            public resource_types(bool @container,
                                  bool @object,
                                  bool @service)
            {
                @Container = @container;
                @Object = @object;
                @Service = @service;
            }

            public bool @Container { get; }
            public bool @Object { get; }
            public bool @Service { get; }
        }

        public class services
        {
            public services(bool @blob,
                            bool @file,
                            bool @queue,
                            bool @table)
            {
                @Blob = @blob;
                @File = @file;
                @Queue = @queue;
                @Table = @table;
            }

            public bool @Blob { get; }
            public bool @File { get; }
            public bool @Queue { get; }
            public bool @Table { get; }
        }

        public azurerm_storage_account_sas(string @connectionString,
                                           string @expiry,
                                           permissions[] @permissions,
                                           resource_types[] @resourceTypes,
                                           services[] @services,
                                           string @start,
                                           bool? @httpsOnly = null)
        {
            @ConnectionString = @connectionString;
            @Expiry = @expiry;
            @Permissions = @permissions;
            @ResourceTypes = @resourceTypes;
            @Services = @services;
            @Start = @start;
            @HttpsOnly = @httpsOnly;
        }

        public string @ConnectionString { get; }
        public string @Expiry { get; }
        public permissions[] @Permissions { get; }
        public resource_types[] @ResourceTypes { get; }
        public services[] @Services { get; }
        public string @Start { get; }
        public bool? @HttpsOnly { get; }
        public string @Sas { get; }
    }

}

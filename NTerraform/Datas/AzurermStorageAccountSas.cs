using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_storage_account_sas")]
    public sealed class azurerm_storage_account_sas : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "resource_types")]
        public sealed class resource_types
        {
            public resource_types(bool @container,
                                  bool @object,
                                  bool @service)
            {
                @Container = @container;
                @Object = @object;
                @Service = @service;
            }

            [TerraformProperty(name: "container", @out: false, nested: false, min: 1, max: 1)]
            public bool @Container { get; }

            [TerraformProperty(name: "object", @out: false, nested: false, min: 1, max: 1)]
            public bool @Object { get; }

            [TerraformProperty(name: "service", @out: false, nested: false, min: 1, max: 1)]
            public bool @Service { get; }
        }

        [TerraformStructure(category: "", typeName: "services")]
        public sealed class services
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

            [TerraformProperty(name: "blob", @out: false, nested: false, min: 1, max: 1)]
            public bool @Blob { get; }

            [TerraformProperty(name: "file", @out: false, nested: false, min: 1, max: 1)]
            public bool @File { get; }

            [TerraformProperty(name: "queue", @out: false, nested: false, min: 1, max: 1)]
            public bool @Queue { get; }

            [TerraformProperty(name: "table", @out: false, nested: false, min: 1, max: 1)]
            public bool @Table { get; }
        }

        [TerraformStructure(category: "", typeName: "permissions")]
        public sealed class permissions
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

            [TerraformProperty(name: "add", @out: false, nested: false, min: 1, max: 1)]
            public bool @Add { get; }

            [TerraformProperty(name: "create", @out: false, nested: false, min: 1, max: 1)]
            public bool @Create { get; }

            [TerraformProperty(name: "delete", @out: false, nested: false, min: 1, max: 1)]
            public bool @Delete { get; }

            [TerraformProperty(name: "list", @out: false, nested: false, min: 1, max: 1)]
            public bool @List { get; }

            [TerraformProperty(name: "process", @out: false, nested: false, min: 1, max: 1)]
            public bool @Process { get; }

            [TerraformProperty(name: "read", @out: false, nested: false, min: 1, max: 1)]
            public bool @Read { get; }

            [TerraformProperty(name: "update", @out: false, nested: false, min: 1, max: 1)]
            public bool @Update { get; }

            [TerraformProperty(name: "write", @out: false, nested: false, min: 1, max: 1)]
            public bool @Write { get; }
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

        [TerraformProperty(name: "connection_string", @out: false, nested: true, min: 1, max: 1)]
        public string @ConnectionString { get; }

        [TerraformProperty(name: "expiry", @out: false, nested: true, min: 1, max: 1)]
        public string @Expiry { get; }

        [TerraformProperty(name: "permissions", @out: false, nested: true, min: 1, max: 1)]
        public permissions[] @Permissions { get; }

        [TerraformProperty(name: "resource_types", @out: false, nested: true, min: 1, max: 1)]
        public resource_types[] @ResourceTypes { get; }

        [TerraformProperty(name: "services", @out: false, nested: true, min: 1, max: 1)]
        public services[] @Services { get; }

        [TerraformProperty(name: "start", @out: false, nested: true, min: 1, max: 1)]
        public string @Start { get; }

        [TerraformProperty(name: "https_only", @out: false, nested: true, min: 0, max: 1)]
        public bool? @HttpsOnly { get; }

        [TerraformProperty(name: "sas", @out: true, nested: true, min: 0, max: 1)]
        public string @Sas { get; }
    }

}

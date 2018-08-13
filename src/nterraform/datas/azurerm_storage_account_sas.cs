using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_storage_account_sas")]
    public sealed class azurerm_storage_account_sas : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "resource_types")]
        public sealed class resource_types : nterraform.structure
        {
            public resource_types(bool @container,
                                  bool @object,
                                  bool @service)
            {
                @Container = @container;
                @Object = @object;
                @Service = @service;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "container", @out: false, min: 1, max: 1)]
            public bool @Container { get; }

            [nterraform.TerraformProperty(name: "object", @out: false, min: 1, max: 1)]
            public bool @Object { get; }

            [nterraform.TerraformProperty(name: "service", @out: false, min: 1, max: 1)]
            public bool @Service { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "services")]
        public sealed class services : nterraform.structure
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "blob", @out: false, min: 1, max: 1)]
            public bool @Blob { get; }

            [nterraform.TerraformProperty(name: "file", @out: false, min: 1, max: 1)]
            public bool @File { get; }

            [nterraform.TerraformProperty(name: "queue", @out: false, min: 1, max: 1)]
            public bool @Queue { get; }

            [nterraform.TerraformProperty(name: "table", @out: false, min: 1, max: 1)]
            public bool @Table { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "permissions")]
        public sealed class permissions : nterraform.structure
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "add", @out: false, min: 1, max: 1)]
            public bool @Add { get; }

            [nterraform.TerraformProperty(name: "create", @out: false, min: 1, max: 1)]
            public bool @Create { get; }

            [nterraform.TerraformProperty(name: "delete", @out: false, min: 1, max: 1)]
            public bool @Delete { get; }

            [nterraform.TerraformProperty(name: "list", @out: false, min: 1, max: 1)]
            public bool @List { get; }

            [nterraform.TerraformProperty(name: "process", @out: false, min: 1, max: 1)]
            public bool @Process { get; }

            [nterraform.TerraformProperty(name: "read", @out: false, min: 1, max: 1)]
            public bool @Read { get; }

            [nterraform.TerraformProperty(name: "update", @out: false, min: 1, max: 1)]
            public bool @Update { get; }

            [nterraform.TerraformProperty(name: "write", @out: false, min: 1, max: 1)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "connection_string", @out: false, min: 1, max: 1)]
        public string @ConnectionString { get; }

        [nterraform.TerraformProperty(name: "expiry", @out: false, min: 1, max: 1)]
        public string @Expiry { get; }

        [nterraform.TerraformProperty(name: "permissions", @out: false, min: 1, max: 1)]
        public permissions[] @Permissions { get; }

        [nterraform.TerraformProperty(name: "resource_types", @out: false, min: 1, max: 1)]
        public resource_types[] @ResourceTypes { get; }

        [nterraform.TerraformProperty(name: "services", @out: false, min: 1, max: 1)]
        public services[] @Services { get; }

        [nterraform.TerraformProperty(name: "start", @out: false, min: 1, max: 1)]
        public string @Start { get; }

        [nterraform.TerraformProperty(name: "https_only", @out: false, min: 0, max: 1)]
        public bool? @HttpsOnly { get; }

        [nterraform.TerraformProperty(name: "sas", @out: true, min: 0, max: 1)]
        public string @Sas { get; }
    }

}

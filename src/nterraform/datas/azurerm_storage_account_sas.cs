using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_storage_account_sas")]
    public sealed class azurerm_storage_account_sas : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "services")]
        public sealed class services : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "blob", @out: false, min: 1, max: 1)]
            public bool @Blob { get; }

            [nterraform.Core.TerraformProperty(name: "file", @out: false, min: 1, max: 1)]
            public bool @File { get; }

            [nterraform.Core.TerraformProperty(name: "queue", @out: false, min: 1, max: 1)]
            public bool @Queue { get; }

            [nterraform.Core.TerraformProperty(name: "table", @out: false, min: 1, max: 1)]
            public bool @Table { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "resource_types")]
        public sealed class resource_types : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "container", @out: false, min: 1, max: 1)]
            public bool @Container { get; }

            [nterraform.Core.TerraformProperty(name: "object", @out: false, min: 1, max: 1)]
            public bool @Object { get; }

            [nterraform.Core.TerraformProperty(name: "service", @out: false, min: 1, max: 1)]
            public bool @Service { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "permissions")]
        public sealed class permissions : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "add", @out: false, min: 1, max: 1)]
            public bool @Add { get; }

            [nterraform.Core.TerraformProperty(name: "create", @out: false, min: 1, max: 1)]
            public bool @Create { get; }

            [nterraform.Core.TerraformProperty(name: "delete", @out: false, min: 1, max: 1)]
            public bool @Delete { get; }

            [nterraform.Core.TerraformProperty(name: "list", @out: false, min: 1, max: 1)]
            public bool @List { get; }

            [nterraform.Core.TerraformProperty(name: "process", @out: false, min: 1, max: 1)]
            public bool @Process { get; }

            [nterraform.Core.TerraformProperty(name: "read", @out: false, min: 1, max: 1)]
            public bool @Read { get; }

            [nterraform.Core.TerraformProperty(name: "update", @out: false, min: 1, max: 1)]
            public bool @Update { get; }

            [nterraform.Core.TerraformProperty(name: "write", @out: false, min: 1, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "connection_string", @out: false, min: 1, max: 1)]
        public string @ConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "expiry", @out: false, min: 1, max: 1)]
        public string @Expiry { get; }

        [nterraform.Core.TerraformProperty(name: "permissions", @out: false, min: 1, max: 1)]
        public permissions[] @Permissions { get; }

        [nterraform.Core.TerraformProperty(name: "resource_types", @out: false, min: 1, max: 1)]
        public resource_types[] @ResourceTypes { get; }

        [nterraform.Core.TerraformProperty(name: "services", @out: false, min: 1, max: 1)]
        public services[] @Services { get; }

        [nterraform.Core.TerraformProperty(name: "start", @out: false, min: 1, max: 1)]
        public string @Start { get; }

        [nterraform.Core.TerraformProperty(name: "https_only", @out: false, min: 0, max: 1)]
        public bool? @HttpsOnly { get; }

        [nterraform.Core.TerraformProperty(name: "sas", @out: true, min: 0, max: 1)]
        public string @Sas { get; }
    }

}

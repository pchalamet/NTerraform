using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "consul_catalog_entry")]
    public sealed class consul_catalog_entry : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "service")]
        public sealed class service
        {
            public service(string @name,
                           string @address = null,
                           int? @port = null,
                           string[] @tags = null)
            {
                @Name = @name;
                @Address = @address;
                @Port = @port;
                @Tags = @tags;
            }

            [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "address", @out: false, nested: false, min: 0, max: 1)]
            public string @Address { get; }

            [TerraformProperty(name: "id", @out: true, nested: false, min: 0, max: 1)]
            public string @Id { get; }

            [TerraformProperty(name: "port", @out: false, nested: false, min: 0, max: 1)]
            public int? @Port { get; }

            [TerraformProperty(name: "tags", @out: false, nested: false, min: 0, max: 1)]
            public string[] @Tags { get; }
        }

        public consul_catalog_entry(string @address,
                                    string @node,
                                    service[] @service = null,
                                    string @token = null)
        {
            @Address = @address;
            @Node = @node;
            @Service = @service;
            @Token = @token;
        }

        [TerraformProperty(name: "address", @out: false, nested: true, min: 1, max: 1)]
        public string @Address { get; }

        [TerraformProperty(name: "node", @out: false, nested: true, min: 1, max: 1)]
        public string @Node { get; }

        [TerraformProperty(name: "datacenter", @out: true, nested: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [TerraformProperty(name: "service", @out: false, nested: true, min: 0, max: 0)]
        public service[] @Service { get; }

        [TerraformProperty(name: "token", @out: false, nested: true, min: 0, max: 1)]
        public string @Token { get; }
    }

}

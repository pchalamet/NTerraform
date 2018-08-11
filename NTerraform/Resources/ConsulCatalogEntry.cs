using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "consul_catalog_entry")]
    public sealed class consul_catalog_entry : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "service")]
        public sealed class service: NTerraform.structure
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
                base._validate_();
            }

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "address", @out: false, min: 0, max: 1)]
            public string @Address { get; }

            [TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
            public int? @Port { get; }

            [TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
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
            base._validate_();
        }

        [TerraformProperty(name: "address", @out: false, min: 1, max: 1)]
        public string @Address { get; }

        [TerraformProperty(name: "node", @out: false, min: 1, max: 1)]
        public string @Node { get; }

        [TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [TerraformProperty(name: "service", @out: false, min: 0, max: 0)]
        public service[] @Service { get; }

        [TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }
    }

}

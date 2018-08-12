using System.Collections.Generic;

namespace nterraform.resources.consul
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "consul_catalog_entry")]
    public sealed class consul_catalog_entry : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "service")]
        public sealed class service : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "address", @out: false, min: 0, max: 1)]
            public string @Address { get; }

            [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
            public int? @Port { get; }

            [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "address", @out: false, min: 1, max: 1)]
        public string @Address { get; }

        [nterraform.Core.TerraformProperty(name: "node", @out: false, min: 1, max: 1)]
        public string @Node { get; }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: true, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "service", @out: false, min: 0, max: 0)]
        public service[] @Service { get; }

        [nterraform.Core.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }
    }

}

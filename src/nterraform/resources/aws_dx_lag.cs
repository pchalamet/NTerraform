using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_dx_lag")]
    public sealed class aws_dx_lag : nterraform.Core.resource
    {
        public aws_dx_lag(string @connectionsBandwidth,
                          string @location,
                          string @name,
                          bool? @forceDestroy = null,
                          Dictionary<string,string> @tags = null)
        {
            @ConnectionsBandwidth = @connectionsBandwidth;
            @Location = @location;
            @Name = @name;
            @ForceDestroy = @forceDestroy;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "connections_bandwidth", @out: false, min: 1, max: 1)]
        public string @ConnectionsBandwidth { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "force_destroy", @out: false, min: 0, max: 1)]
        public bool? @ForceDestroy { get; }

        [nterraform.Core.TerraformProperty(name: "number_of_connections", @out: true, min: 0, max: 1)]
        public int? @NumberOfConnections { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}

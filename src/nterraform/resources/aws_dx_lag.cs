using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_dx_lag")]
    public sealed class aws_dx_lag : nterraform.resource
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

        [nterraform.TerraformProperty(name: "connections_bandwidth", @out: false, min: 1, max: 1)]
        public string @ConnectionsBandwidth { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "force_destroy", @out: false, min: 0, max: 1)]
        public bool? @ForceDestroy { get; }

        [nterraform.TerraformProperty(name: "number_of_connections", @out: true, min: 0, max: 1)]
        public int? @NumberOfConnections { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_dx_connection")]
    public sealed class aws_dx_connection : nterraform.Core.resource
    {
        public aws_dx_connection(string @bandwidth,
                                 string @location,
                                 string @name,
                                 Dictionary<string,string> @tags = null)
        {
            @Bandwidth = @bandwidth;
            @Location = @location;
            @Name = @name;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "bandwidth", @out: false, min: 1, max: 1)]
        public string @Bandwidth { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
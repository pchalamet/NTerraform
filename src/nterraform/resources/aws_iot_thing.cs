using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iot_thing")]
    public sealed class aws_iot_thing : nterraform.Core.resource
    {
        public aws_iot_thing(string @name,
                             Dictionary<string,string> @attributes = null,
                             string @thingTypeName = null)
        {
            @Name = @name;
            @Attributes = @attributes;
            @ThingTypeName = @thingTypeName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "attributes", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Attributes { get; }

        [nterraform.Core.TerraformProperty(name: "default_client_id", @out: true, min: 0, max: 1)]
        public string @DefaultClientId { get; }

        [nterraform.Core.TerraformProperty(name: "thing_type_name", @out: false, min: 0, max: 1)]
        public string @ThingTypeName { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public int? @Version { get; }
    }

}

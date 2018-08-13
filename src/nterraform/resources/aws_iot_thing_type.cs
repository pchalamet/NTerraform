using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iot_thing_type")]
    public sealed class aws_iot_thing_type : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "properties")]
        public sealed class properties : nterraform.Core.structure
        {
            public properties(string @description = null)
            {
                @Description = @description;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
            public string @Description { get; }

            [nterraform.Core.TerraformProperty(name: "searchable_attributes", @out: true, min: 0, max: 1)]
            public string[] @SearchableAttributes { get; }
        }

        public aws_iot_thing_type(string @name,
                                  bool? @deprecated = null,
                                  properties[] @properties = null)
        {
            @Name = @name;
            @Deprecated = @deprecated;
            @Properties = @properties;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "deprecated", @out: false, min: 0, max: 1)]
        public bool? @Deprecated { get; }

        [nterraform.Core.TerraformProperty(name: "properties", @out: false, min: 0, max: 1)]
        public properties[] @Properties { get; }
    }

}

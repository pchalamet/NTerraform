using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_waf_ipset")]
    public sealed class aws_waf_ipset : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "ip_set_descriptors")]
        public sealed class ip_set_descriptors : nterraform.structure
        {
            public ip_set_descriptors(string @type,
                                      string @value)
            {
                @Type = @type;
                @Value = @value;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }
        }

        public aws_waf_ipset(string @name,
                             ip_set_descriptors[] @ipSetDescriptors = null)
        {
            @Name = @name;
            @IpSetDescriptors = @ipSetDescriptors;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "ip_set_descriptors", @out: false, min: 0, max: 0)]
        public ip_set_descriptors[] @IpSetDescriptors { get; }
    }

}

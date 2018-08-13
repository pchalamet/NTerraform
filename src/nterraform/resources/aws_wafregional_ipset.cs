using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_wafregional_ipset")]
    public sealed class aws_wafregional_ipset : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "ip_set_descriptor")]
        public sealed class ip_set_descriptor : nterraform.structure
        {
            public ip_set_descriptor(string @type,
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

        public aws_wafregional_ipset(string @name,
                                     ip_set_descriptor[] @ipSetDescriptor = null)
        {
            @Name = @name;
            @IpSetDescriptor = @ipSetDescriptor;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "ip_set_descriptor", @out: false, min: 0, max: 0)]
        public ip_set_descriptor[] @IpSetDescriptor { get; }
    }

}

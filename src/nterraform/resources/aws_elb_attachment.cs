using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_elb_attachment")]
    public sealed class aws_elb_attachment : nterraform.Core.resource
    {
        public aws_elb_attachment(string @elb,
                                  string @instance)
        {
            @Elb = @elb;
            @Instance = @instance;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "elb", @out: false, min: 1, max: 1)]
        public string @Elb { get; }

        [nterraform.Core.TerraformProperty(name: "instance", @out: false, min: 1, max: 1)]
        public string @Instance { get; }
    }

}

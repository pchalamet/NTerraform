using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_elb_attachment")]
    public sealed class aws_elb_attachment : nterraform.resource
    {
        public aws_elb_attachment(string @elb,
                                  string @instance)
        {
            @Elb = @elb;
            @Instance = @instance;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "elb", @out: false, min: 1, max: 1)]
        public string @Elb { get; }

        [nterraform.TerraformProperty(name: "instance", @out: false, min: 1, max: 1)]
        public string @Instance { get; }
    }

}

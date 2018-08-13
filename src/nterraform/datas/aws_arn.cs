using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_arn")]
    public sealed class aws_arn : nterraform.data
    {
        public aws_arn(string @arn)
        {
            @Arn = @arn;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: false, min: 1, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "account", @out: true, min: 0, max: 1)]
        public string @Account { get; }

        [nterraform.TerraformProperty(name: "partition", @out: true, min: 0, max: 1)]
        public string @Partition { get; }

        [nterraform.TerraformProperty(name: "region", @out: true, min: 0, max: 1)]
        public string @Region { get; }

        [nterraform.TerraformProperty(name: "resource", @out: true, min: 0, max: 1)]
        public string @Resource { get; }

        [nterraform.TerraformProperty(name: "service", @out: true, min: 0, max: 1)]
        public string @Service { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_arn")]
    public sealed class aws_arn : nterraform.Core.data
    {
        public aws_arn(string @arn)
        {
            @Arn = @arn;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: false, min: 1, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "account", @out: true, min: 0, max: 1)]
        public string @Account { get; }

        [nterraform.Core.TerraformProperty(name: "partition", @out: true, min: 0, max: 1)]
        public string @Partition { get; }

        [nterraform.Core.TerraformProperty(name: "region", @out: true, min: 0, max: 1)]
        public string @Region { get; }

        [nterraform.Core.TerraformProperty(name: "resource", @out: true, min: 0, max: 1)]
        public string @Resource { get; }

        [nterraform.Core.TerraformProperty(name: "service", @out: true, min: 0, max: 1)]
        public string @Service { get; }
    }

}

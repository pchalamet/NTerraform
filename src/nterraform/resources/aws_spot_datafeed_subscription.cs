using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_spot_datafeed_subscription")]
    public sealed class aws_spot_datafeed_subscription : nterraform.resource
    {
        public aws_spot_datafeed_subscription(string @bucket,
                                              string @prefix = null)
        {
            @Bucket = @bucket;
            @Prefix = @prefix;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
        public string @Bucket { get; }

        [nterraform.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
        public string @Prefix { get; }
    }

}

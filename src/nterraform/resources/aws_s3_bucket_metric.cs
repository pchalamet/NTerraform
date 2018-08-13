using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_s3_bucket_metric")]
    public sealed class aws_s3_bucket_metric : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "filter")]
        public sealed class filter : nterraform.Core.structure
        {
            public filter(string @prefix = null,
                          Dictionary<string,string> @tags = null)
            {
                @Prefix = @prefix;
                @Tags = @tags;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "prefix", @out: false, min: 0, max: 1)]
            public string @Prefix { get; }

            [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Tags { get; }
        }

        public aws_s3_bucket_metric(string @bucket,
                                    string @name,
                                    filter[] @filter = null)
        {
            @Bucket = @bucket;
            @Name = @name;
            @Filter = @filter;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
        public string @Bucket { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 1)]
        public filter[] @Filter { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_athena_database")]
    public sealed class aws_athena_database : nterraform.resource
    {
        public aws_athena_database(string @bucket,
                                   string @name,
                                   bool? @forceDestroy = null)
        {
            @Bucket = @bucket;
            @Name = @name;
            @ForceDestroy = @forceDestroy;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
        public string @Bucket { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "force_destroy", @out: false, min: 0, max: 1)]
        public bool? @ForceDestroy { get; }
    }

}

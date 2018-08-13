using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_elastic_beanstalk_application_version")]
    public sealed class aws_elastic_beanstalk_application_version : nterraform.resource
    {
        public aws_elastic_beanstalk_application_version(string @application,
                                                         string @bucket,
                                                         string @key,
                                                         string @name,
                                                         string @description = null,
                                                         bool? @forceDelete = null)
        {
            @Application = @application;
            @Bucket = @bucket;
            @Key = @key;
            @Name = @name;
            @Description = @description;
            @ForceDelete = @forceDelete;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "application", @out: false, min: 1, max: 1)]
        public string @Application { get; }

        [nterraform.TerraformProperty(name: "bucket", @out: false, min: 1, max: 1)]
        public string @Bucket { get; }

        [nterraform.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
        public string @Key { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "force_delete", @out: false, min: 0, max: 1)]
        public bool? @ForceDelete { get; }
    }

}

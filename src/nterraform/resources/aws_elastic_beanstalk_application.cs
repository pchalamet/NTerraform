using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_elastic_beanstalk_application")]
    public sealed class aws_elastic_beanstalk_application : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "appversion_lifecycle")]
        public sealed class appversion_lifecycle : nterraform.Core.structure
        {
            public appversion_lifecycle(string @serviceRole,
                                        bool? @deleteSourceFromS3 = null,
                                        int? @maxAgeInDays = null,
                                        int? @maxCount = null)
            {
                @ServiceRole = @serviceRole;
                @DeleteSourceFromS3 = @deleteSourceFromS3;
                @MaxAgeInDays = @maxAgeInDays;
                @MaxCount = @maxCount;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "service_role", @out: false, min: 1, max: 1)]
            public string @ServiceRole { get; }

            [nterraform.Core.TerraformProperty(name: "delete_source_from_s3", @out: false, min: 0, max: 1)]
            public bool? @DeleteSourceFromS3 { get; }

            [nterraform.Core.TerraformProperty(name: "max_age_in_days", @out: false, min: 0, max: 1)]
            public int? @MaxAgeInDays { get; }

            [nterraform.Core.TerraformProperty(name: "max_count", @out: false, min: 0, max: 1)]
            public int? @MaxCount { get; }
        }

        public aws_elastic_beanstalk_application(string @name,
                                                 appversion_lifecycle[] @appversionLifecycle = null,
                                                 string @description = null)
        {
            @Name = @name;
            @AppversionLifecycle = @appversionLifecycle;
            @Description = @description;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "appversion_lifecycle", @out: false, min: 0, max: 1)]
        public appversion_lifecycle[] @AppversionLifecycle { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }
    }

}

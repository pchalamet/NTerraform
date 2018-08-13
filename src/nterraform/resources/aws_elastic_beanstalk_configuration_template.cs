using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_elastic_beanstalk_configuration_template")]
    public sealed class aws_elastic_beanstalk_configuration_template : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "setting")]
        public sealed class setting : nterraform.structure
        {
            public setting(string @name,
                           string @namespace,
                           string @value,
                           string @resource = null)
            {
                @Name = @name;
                @Namespace = @namespace;
                @Value = @value;
                @Resource = @resource;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "namespace", @out: false, min: 1, max: 1)]
            public string @Namespace { get; }

            [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }

            [nterraform.TerraformProperty(name: "resource", @out: false, min: 0, max: 1)]
            public string @Resource { get; }
        }

        public aws_elastic_beanstalk_configuration_template(string @application,
                                                            string @name,
                                                            string @description = null,
                                                            string @environmentId = null,
                                                            setting[] @setting = null,
                                                            string @solutionStackName = null)
        {
            @Application = @application;
            @Name = @name;
            @Description = @description;
            @EnvironmentId = @environmentId;
            @Setting = @setting;
            @SolutionStackName = @solutionStackName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "application", @out: false, min: 1, max: 1)]
        public string @Application { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "environment_id", @out: false, min: 0, max: 1)]
        public string @EnvironmentId { get; }

        [nterraform.TerraformProperty(name: "setting", @out: false, min: 0, max: 0)]
        public setting[] @Setting { get; }

        [nterraform.TerraformProperty(name: "solution_stack_name", @out: false, min: 0, max: 1)]
        public string @SolutionStackName { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_cloudformation_stack")]
    public sealed class aws_cloudformation_stack : nterraform.Core.data
    {
        public aws_cloudformation_stack(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "capabilities", @out: true, min: 0, max: 1)]
        public string[] @Capabilities { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "disable_rollback", @out: true, min: 0, max: 1)]
        public bool? @DisableRollback { get; }

        [nterraform.Core.TerraformProperty(name: "iam_role_arn", @out: true, min: 0, max: 1)]
        public string @IamRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "notification_arns", @out: true, min: 0, max: 1)]
        public string[] @NotificationArns { get; }

        [nterraform.Core.TerraformProperty(name: "outputs", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Outputs { get; }

        [nterraform.Core.TerraformProperty(name: "parameters", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Parameters { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "template_body", @out: true, min: 0, max: 1)]
        public string @TemplateBody { get; }

        [nterraform.Core.TerraformProperty(name: "timeout_in_minutes", @out: true, min: 0, max: 1)]
        public int? @TimeoutInMinutes { get; }
    }

}

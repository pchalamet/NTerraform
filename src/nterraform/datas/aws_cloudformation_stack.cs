using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_cloudformation_stack")]
    public sealed class aws_cloudformation_stack : nterraform.data
    {
        public aws_cloudformation_stack(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "capabilities", @out: true, min: 0, max: 1)]
        public string[] @Capabilities { get; }

        [nterraform.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "disable_rollback", @out: true, min: 0, max: 1)]
        public bool? @DisableRollback { get; }

        [nterraform.TerraformProperty(name: "iam_role_arn", @out: true, min: 0, max: 1)]
        public string @IamRoleArn { get; }

        [nterraform.TerraformProperty(name: "notification_arns", @out: true, min: 0, max: 1)]
        public string[] @NotificationArns { get; }

        [nterraform.TerraformProperty(name: "outputs", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Outputs { get; }

        [nterraform.TerraformProperty(name: "parameters", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Parameters { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "template_body", @out: true, min: 0, max: 1)]
        public string @TemplateBody { get; }

        [nterraform.TerraformProperty(name: "timeout_in_minutes", @out: true, min: 0, max: 1)]
        public int? @TimeoutInMinutes { get; }
    }

}

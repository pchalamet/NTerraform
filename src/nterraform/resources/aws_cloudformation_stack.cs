using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cloudformation_stack")]
    public sealed class aws_cloudformation_stack : nterraform.Core.resource
    {
        public aws_cloudformation_stack(string @name,
                                        string[] @capabilities = null,
                                        bool? @disableRollback = null,
                                        string @iamRoleArn = null,
                                        string[] @notificationArns = null,
                                        string @onFailure = null,
                                        string @policyUrl = null,
                                        Dictionary<string,string> @tags = null,
                                        string @templateUrl = null,
                                        int? @timeoutInMinutes = null)
        {
            @Name = @name;
            @Capabilities = @capabilities;
            @DisableRollback = @disableRollback;
            @IamRoleArn = @iamRoleArn;
            @NotificationArns = @notificationArns;
            @OnFailure = @onFailure;
            @PolicyUrl = @policyUrl;
            @Tags = @tags;
            @TemplateUrl = @templateUrl;
            @TimeoutInMinutes = @timeoutInMinutes;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "capabilities", @out: false, min: 0, max: 1)]
        public string[] @Capabilities { get; }

        [nterraform.Core.TerraformProperty(name: "disable_rollback", @out: false, min: 0, max: 1)]
        public bool? @DisableRollback { get; }

        [nterraform.Core.TerraformProperty(name: "iam_role_arn", @out: false, min: 0, max: 1)]
        public string @IamRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "notification_arns", @out: false, min: 0, max: 1)]
        public string[] @NotificationArns { get; }

        [nterraform.Core.TerraformProperty(name: "on_failure", @out: false, min: 0, max: 1)]
        public string @OnFailure { get; }

        [nterraform.Core.TerraformProperty(name: "outputs", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Outputs { get; }

        [nterraform.Core.TerraformProperty(name: "parameters", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Parameters { get; }

        [nterraform.Core.TerraformProperty(name: "policy_body", @out: true, min: 0, max: 1)]
        public string @PolicyBody { get; }

        [nterraform.Core.TerraformProperty(name: "policy_url", @out: false, min: 0, max: 1)]
        public string @PolicyUrl { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "template_body", @out: true, min: 0, max: 1)]
        public string @TemplateBody { get; }

        [nterraform.Core.TerraformProperty(name: "template_url", @out: false, min: 0, max: 1)]
        public string @TemplateUrl { get; }

        [nterraform.Core.TerraformProperty(name: "timeout_in_minutes", @out: false, min: 0, max: 1)]
        public int? @TimeoutInMinutes { get; }
    }

}

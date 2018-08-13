using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_iam_service_linked_role")]
    public sealed class aws_iam_service_linked_role : nterraform.resource
    {
        public aws_iam_service_linked_role(string @awsServiceName,
                                           string @customSuffix = null,
                                           string @description = null)
        {
            @AwsServiceName = @awsServiceName;
            @CustomSuffix = @customSuffix;
            @Description = @description;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "aws_service_name", @out: false, min: 1, max: 1)]
        public string @AwsServiceName { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "create_date", @out: true, min: 0, max: 1)]
        public string @CreateDate { get; }

        [nterraform.TerraformProperty(name: "custom_suffix", @out: false, min: 0, max: 1)]
        public string @CustomSuffix { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
        public string @Path { get; }

        [nterraform.TerraformProperty(name: "unique_id", @out: true, min: 0, max: 1)]
        public string @UniqueId { get; }
    }

}

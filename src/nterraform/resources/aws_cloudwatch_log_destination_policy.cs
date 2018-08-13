using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_log_destination_policy")]
    public sealed class aws_cloudwatch_log_destination_policy : nterraform.resource
    {
        public aws_cloudwatch_log_destination_policy(string @accessPolicy,
                                                     string @destinationName)
        {
            @AccessPolicy = @accessPolicy;
            @DestinationName = @destinationName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "access_policy", @out: false, min: 1, max: 1)]
        public string @AccessPolicy { get; }

        [nterraform.TerraformProperty(name: "destination_name", @out: false, min: 1, max: 1)]
        public string @DestinationName { get; }
    }

}

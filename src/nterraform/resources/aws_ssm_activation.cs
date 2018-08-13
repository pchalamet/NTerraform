using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ssm_activation")]
    public sealed class aws_ssm_activation : nterraform.Core.resource
    {
        public aws_ssm_activation(string @iamRole,
                                  string @description = null,
                                  string @expirationDate = null,
                                  string @name = null,
                                  int? @registrationLimit = null)
        {
            @IamRole = @iamRole;
            @Description = @description;
            @ExpirationDate = @expirationDate;
            @Name = @name;
            @RegistrationLimit = @registrationLimit;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "iam_role", @out: false, min: 1, max: 1)]
        public string @IamRole { get; }

        [nterraform.Core.TerraformProperty(name: "activation_code", @out: true, min: 0, max: 1)]
        public string @ActivationCode { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "expiration_date", @out: false, min: 0, max: 1)]
        public string @ExpirationDate { get; }

        [nterraform.Core.TerraformProperty(name: "expired", @out: true, min: 0, max: 1)]
        public string @Expired { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "registration_count", @out: true, min: 0, max: 1)]
        public int? @RegistrationCount { get; }

        [nterraform.Core.TerraformProperty(name: "registration_limit", @out: false, min: 0, max: 1)]
        public int? @RegistrationLimit { get; }
    }

}

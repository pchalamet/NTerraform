using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ssm_activation")]
    public sealed class aws_ssm_activation : nterraform.resource
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

        [nterraform.TerraformProperty(name: "iam_role", @out: false, min: 1, max: 1)]
        public string @IamRole { get; }

        [nterraform.TerraformProperty(name: "activation_code", @out: true, min: 0, max: 1)]
        public string @ActivationCode { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "expiration_date", @out: false, min: 0, max: 1)]
        public string @ExpirationDate { get; }

        [nterraform.TerraformProperty(name: "expired", @out: true, min: 0, max: 1)]
        public string @Expired { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "registration_count", @out: true, min: 0, max: 1)]
        public int? @RegistrationCount { get; }

        [nterraform.TerraformProperty(name: "registration_limit", @out: false, min: 0, max: 1)]
        public int? @RegistrationLimit { get; }
    }

}

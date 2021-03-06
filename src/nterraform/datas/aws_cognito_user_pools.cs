using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_cognito_user_pools")]
    public sealed class aws_cognito_user_pools : nterraform.data
    {
        public aws_cognito_user_pools(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arns", @out: true, min: 0, max: 1)]
        public string[] @Arns { get; }

        [nterraform.TerraformProperty(name: "ids", @out: true, min: 0, max: 1)]
        public string[] @Ids { get; }
    }

}

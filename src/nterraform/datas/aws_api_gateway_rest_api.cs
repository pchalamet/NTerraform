using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_api_gateway_rest_api")]
    public sealed class aws_api_gateway_rest_api : nterraform.Core.data
    {
        public aws_api_gateway_rest_api(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "root_resource_id", @out: true, min: 0, max: 1)]
        public string @RootResourceId { get; }
    }

}

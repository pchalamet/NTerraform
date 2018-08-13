using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_appsync_api_key")]
    public sealed class aws_appsync_api_key : nterraform.resource
    {
        public aws_appsync_api_key(string @apiId,
                                   string @description = null,
                                   string @expires = null)
        {
            @ApiId = @apiId;
            @Description = @description;
            @Expires = @expires;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "api_id", @out: false, min: 1, max: 1)]
        public string @ApiId { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "expires", @out: false, min: 0, max: 1)]
        public string @Expires { get; }

        [nterraform.TerraformProperty(name: "key", @out: true, min: 0, max: 1)]
        public string @Key { get; }
    }

}

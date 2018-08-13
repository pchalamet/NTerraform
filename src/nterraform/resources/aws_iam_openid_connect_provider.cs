using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_openid_connect_provider")]
    public sealed class aws_iam_openid_connect_provider : nterraform.Core.resource
    {
        public aws_iam_openid_connect_provider(string[] @clientIdList,
                                               string[] @thumbprintList,
                                               string @url)
        {
            @ClientIdList = @clientIdList;
            @ThumbprintList = @thumbprintList;
            @Url = @url;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "client_id_list", @out: false, min: 1, max: 1)]
        public string[] @ClientIdList { get; }

        [nterraform.Core.TerraformProperty(name: "thumbprint_list", @out: false, min: 1, max: 1)]
        public string[] @ThumbprintList { get; }

        [nterraform.Core.TerraformProperty(name: "url", @out: false, min: 1, max: 1)]
        public string @Url { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}

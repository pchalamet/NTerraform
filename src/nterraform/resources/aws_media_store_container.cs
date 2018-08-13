using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_media_store_container")]
    public sealed class aws_media_store_container : nterraform.Core.resource
    {
        public aws_media_store_container(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_servicecatalog_portfolio")]
    public sealed class aws_servicecatalog_portfolio : nterraform.Core.resource
    {
        public aws_servicecatalog_portfolio(string @name,
                                            string @providerName = null,
                                            Dictionary<string,string> @tags = null)
        {
            @Name = @name;
            @ProviderName = @providerName;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "created_time", @out: true, min: 0, max: 1)]
        public string @CreatedTime { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "provider_name", @out: false, min: 0, max: 1)]
        public string @ProviderName { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_emr_security_configuration")]
    public sealed class aws_emr_security_configuration : nterraform.Core.resource
    {
        public aws_emr_security_configuration(string @configuration,
                                              string @namePrefix = null)
        {
            @Configuration = @configuration;
            @NamePrefix = @namePrefix;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "configuration", @out: false, min: 1, max: 1)]
        public string @Configuration { get; }

        [nterraform.Core.TerraformProperty(name: "creation_date", @out: true, min: 0, max: 1)]
        public string @CreationDate { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }
    }

}

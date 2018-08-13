using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_internet_gateway")]
    public sealed class aws_internet_gateway : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "filter")]
        public sealed class filter : nterraform.structure
        {
            public filter(string @name,
                          string[] @values)
            {
                @Name = @name;
                @Values = @values;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "attachments")]
        public sealed class attachments : nterraform.structure
        {
            public attachments()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
            public string @State { get; }

            [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
            public string @VpcId { get; }
        }

        public aws_internet_gateway(attachments[] @attachments = null,
                                    filter[] @filter = null)
        {
            @Attachments = @attachments;
            @Filter = @filter;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "attachments", @out: false, min: 0, max: 0)]
        public attachments[] @Attachments { get; }

        [nterraform.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.TerraformProperty(name: "internet_gateway_id", @out: true, min: 0, max: 1)]
        public string @InternetGatewayId { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}

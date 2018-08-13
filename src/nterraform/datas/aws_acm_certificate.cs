using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_acm_certificate")]
    public sealed class aws_acm_certificate : nterraform.Core.data
    {
        public aws_acm_certificate(string @domain,
                                   bool? @mostRecent = null,
                                   string[] @statuses = null,
                                   string[] @types = null)
        {
            @Domain = @domain;
            @MostRecent = @mostRecent;
            @Statuses = @statuses;
            @Types = @types;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "domain", @out: false, min: 1, max: 1)]
        public string @Domain { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "most_recent", @out: false, min: 0, max: 1)]
        public bool? @MostRecent { get; }

        [nterraform.Core.TerraformProperty(name: "statuses", @out: false, min: 0, max: 1)]
        public string[] @Statuses { get; }

        [nterraform.Core.TerraformProperty(name: "types", @out: false, min: 0, max: 1)]
        public string[] @Types { get; }
    }

}

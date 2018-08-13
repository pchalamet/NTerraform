using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_route53_zone")]
    public sealed class aws_route53_zone : nterraform.Core.data
    {
        public aws_route53_zone(bool? @privateZone = null)
        {
            @PrivateZone = @privateZone;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "caller_reference", @out: true, min: 0, max: 1)]
        public string @CallerReference { get; }

        [nterraform.Core.TerraformProperty(name: "comment", @out: true, min: 0, max: 1)]
        public string @Comment { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_servers", @out: true, min: 0, max: 1)]
        public string[] @NameServers { get; }

        [nterraform.Core.TerraformProperty(name: "private_zone", @out: false, min: 0, max: 1)]
        public bool? @PrivateZone { get; }

        [nterraform.Core.TerraformProperty(name: "resource_record_set_count", @out: true, min: 0, max: 1)]
        public int? @ResourceRecordSetCount { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }

        [nterraform.Core.TerraformProperty(name: "zone_id", @out: true, min: 0, max: 1)]
        public string @ZoneId { get; }
    }

}

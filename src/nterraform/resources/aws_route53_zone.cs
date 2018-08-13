using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_route53_zone")]
    public sealed class aws_route53_zone : nterraform.resource
    {
        public aws_route53_zone(string @name,
                                string @comment = null,
                                string @delegationSetId = null,
                                bool? @forceDestroy = null,
                                Dictionary<string,string> @tags = null,
                                string @vpcId = null)
        {
            @Name = @name;
            @Comment = @comment;
            @DelegationSetId = @delegationSetId;
            @ForceDestroy = @forceDestroy;
            @Tags = @tags;
            @VpcId = @vpcId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "comment", @out: false, min: 0, max: 1)]
        public string @Comment { get; }

        [nterraform.TerraformProperty(name: "delegation_set_id", @out: false, min: 0, max: 1)]
        public string @DelegationSetId { get; }

        [nterraform.TerraformProperty(name: "force_destroy", @out: false, min: 0, max: 1)]
        public bool? @ForceDestroy { get; }

        [nterraform.TerraformProperty(name: "name_servers", @out: true, min: 0, max: 1)]
        public string[] @NameServers { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: false, min: 0, max: 1)]
        public string @VpcId { get; }

        [nterraform.TerraformProperty(name: "vpc_region", @out: true, min: 0, max: 1)]
        public string @VpcRegion { get; }

        [nterraform.TerraformProperty(name: "zone_id", @out: true, min: 0, max: 1)]
        public string @ZoneId { get; }
    }

}

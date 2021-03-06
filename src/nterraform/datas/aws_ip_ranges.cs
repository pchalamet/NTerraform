using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_ip_ranges")]
    public sealed class aws_ip_ranges : nterraform.data
    {
        public aws_ip_ranges(string[] @services,
                             string[] @regions = null)
        {
            @Services = @services;
            @Regions = @regions;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "services", @out: false, min: 1, max: 1)]
        public string[] @Services { get; }

        [nterraform.TerraformProperty(name: "cidr_blocks", @out: true, min: 0, max: 1)]
        public string[] @CidrBlocks { get; }

        [nterraform.TerraformProperty(name: "create_date", @out: true, min: 0, max: 1)]
        public string @CreateDate { get; }

        [nterraform.TerraformProperty(name: "regions", @out: false, min: 0, max: 1)]
        public string[] @Regions { get; }

        [nterraform.TerraformProperty(name: "sync_token", @out: true, min: 0, max: 1)]
        public int? @SyncToken { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_config_configuration_aggregator")]
    public sealed class aws_config_configuration_aggregator : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "account_aggregation_source")]
        public sealed class account_aggregation_source : nterraform.Core.structure
        {
            public account_aggregation_source(string[] @accountIds,
                                              bool? @allRegions = null,
                                              string[] @regions = null)
            {
                @AccountIds = @accountIds;
                @AllRegions = @allRegions;
                @Regions = @regions;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "account_ids", @out: false, min: 1, max: 1)]
            public string[] @AccountIds { get; }

            [nterraform.Core.TerraformProperty(name: "all_regions", @out: false, min: 0, max: 1)]
            public bool? @AllRegions { get; }

            [nterraform.Core.TerraformProperty(name: "regions", @out: false, min: 0, max: 1)]
            public string[] @Regions { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "organization_aggregation_source")]
        public sealed class organization_aggregation_source : nterraform.Core.structure
        {
            public organization_aggregation_source(string @roleArn,
                                                   bool? @allRegions = null,
                                                   string[] @regions = null)
            {
                @RoleArn = @roleArn;
                @AllRegions = @allRegions;
                @Regions = @regions;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.Core.TerraformProperty(name: "all_regions", @out: false, min: 0, max: 1)]
            public bool? @AllRegions { get; }

            [nterraform.Core.TerraformProperty(name: "regions", @out: false, min: 0, max: 1)]
            public string[] @Regions { get; }
        }

        public aws_config_configuration_aggregator(string @name,
                                                   account_aggregation_source[] @accountAggregationSource = null,
                                                   organization_aggregation_source[] @organizationAggregationSource = null)
        {
            @Name = @name;
            @AccountAggregationSource = @accountAggregationSource;
            @OrganizationAggregationSource = @organizationAggregationSource;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "account_aggregation_source", @out: false, min: 0, max: 1)]
        public account_aggregation_source[] @AccountAggregationSource { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "organization_aggregation_source", @out: false, min: 0, max: 1)]
        public organization_aggregation_source[] @OrganizationAggregationSource { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_config_configuration_aggregator")]
    public sealed class aws_config_configuration_aggregator : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "account_aggregation_source")]
        public sealed class account_aggregation_source : nterraform.structure
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

            [nterraform.TerraformProperty(name: "account_ids", @out: false, min: 1, max: 1)]
            public string[] @AccountIds { get; }

            [nterraform.TerraformProperty(name: "all_regions", @out: false, min: 0, max: 1)]
            public bool? @AllRegions { get; }

            [nterraform.TerraformProperty(name: "regions", @out: false, min: 0, max: 1)]
            public string[] @Regions { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "organization_aggregation_source")]
        public sealed class organization_aggregation_source : nterraform.structure
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

            [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
            public string @RoleArn { get; }

            [nterraform.TerraformProperty(name: "all_regions", @out: false, min: 0, max: 1)]
            public bool? @AllRegions { get; }

            [nterraform.TerraformProperty(name: "regions", @out: false, min: 0, max: 1)]
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "account_aggregation_source", @out: false, min: 0, max: 1)]
        public account_aggregation_source[] @AccountAggregationSource { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "organization_aggregation_source", @out: false, min: 0, max: 1)]
        public organization_aggregation_source[] @OrganizationAggregationSource { get; }
    }

}

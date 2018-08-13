using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_api_gateway_usage_plan")]
    public sealed class aws_api_gateway_usage_plan : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "api_stages")]
        public sealed class api_stages : nterraform.structure
        {
            public api_stages(string @apiId,
                              string @stage)
            {
                @ApiId = @apiId;
                @Stage = @stage;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "api_id", @out: false, min: 1, max: 1)]
            public string @ApiId { get; }

            [nterraform.TerraformProperty(name: "stage", @out: false, min: 1, max: 1)]
            public string @Stage { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "quota_settings")]
        public sealed class quota_settings : nterraform.structure
        {
            public quota_settings(int @limit,
                                  string @period,
                                  int? @offset = null)
            {
                @Limit = @limit;
                @Period = @period;
                @Offset = @offset;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "limit", @out: false, min: 1, max: 1)]
            public int @Limit { get; }

            [nterraform.TerraformProperty(name: "period", @out: false, min: 1, max: 1)]
            public string @Period { get; }

            [nterraform.TerraformProperty(name: "offset", @out: false, min: 0, max: 1)]
            public int? @Offset { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "throttle_settings")]
        public sealed class throttle_settings : nterraform.structure
        {
            public throttle_settings(int? @burstLimit = null,
                                     int? @rateLimit = null)
            {
                @BurstLimit = @burstLimit;
                @RateLimit = @rateLimit;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "burst_limit", @out: false, min: 0, max: 1)]
            public int? @BurstLimit { get; }

            [nterraform.TerraformProperty(name: "rate_limit", @out: false, min: 0, max: 1)]
            public int? @RateLimit { get; }
        }

        public aws_api_gateway_usage_plan(string @name,
                                          api_stages[] @apiStages = null,
                                          string @description = null,
                                          string @productCode = null,
                                          quota_settings[] @quotaSettings = null,
                                          throttle_settings[] @throttleSettings = null)
        {
            @Name = @name;
            @ApiStages = @apiStages;
            @Description = @description;
            @ProductCode = @productCode;
            @QuotaSettings = @quotaSettings;
            @ThrottleSettings = @throttleSettings;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "api_stages", @out: false, min: 0, max: 0)]
        public api_stages[] @ApiStages { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "product_code", @out: false, min: 0, max: 1)]
        public string @ProductCode { get; }

        [nterraform.TerraformProperty(name: "quota_settings", @out: false, min: 0, max: 1)]
        public quota_settings[] @QuotaSettings { get; }

        [nterraform.TerraformProperty(name: "throttle_settings", @out: false, min: 0, max: 1)]
        public throttle_settings[] @ThrottleSettings { get; }
    }

}

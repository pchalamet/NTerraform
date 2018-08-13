using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_dashboard")]
    public sealed class aws_cloudwatch_dashboard : nterraform.resource
    {
        public aws_cloudwatch_dashboard(string @dashboardBody,
                                        string @dashboardName)
        {
            @DashboardBody = @dashboardBody;
            @DashboardName = @dashboardName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "dashboard_body", @out: false, min: 1, max: 1)]
        public string @DashboardBody { get; }

        [nterraform.TerraformProperty(name: "dashboard_name", @out: false, min: 1, max: 1)]
        public string @DashboardName { get; }

        [nterraform.TerraformProperty(name: "dashboard_arn", @out: true, min: 0, max: 1)]
        public string @DashboardArn { get; }
    }

}

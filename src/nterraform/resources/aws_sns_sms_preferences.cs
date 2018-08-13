using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_sns_sms_preferences")]
    public sealed class aws_sns_sms_preferences : nterraform.Core.resource
    {
        public aws_sns_sms_preferences(string @defaultSenderId = null,
                                       string @defaultSmsType = null,
                                       string @deliveryStatusIamRoleArn = null,
                                       string @deliveryStatusSuccessSamplingRate = null,
                                       string @monthlySpendLimit = null,
                                       string @usageReportS3Bucket = null)
        {
            @DefaultSenderId = @defaultSenderId;
            @DefaultSmsType = @defaultSmsType;
            @DeliveryStatusIamRoleArn = @deliveryStatusIamRoleArn;
            @DeliveryStatusSuccessSamplingRate = @deliveryStatusSuccessSamplingRate;
            @MonthlySpendLimit = @monthlySpendLimit;
            @UsageReportS3Bucket = @usageReportS3Bucket;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "default_sender_id", @out: false, min: 0, max: 1)]
        public string @DefaultSenderId { get; }

        [nterraform.Core.TerraformProperty(name: "default_sms_type", @out: false, min: 0, max: 1)]
        public string @DefaultSmsType { get; }

        [nterraform.Core.TerraformProperty(name: "delivery_status_iam_role_arn", @out: false, min: 0, max: 1)]
        public string @DeliveryStatusIamRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "delivery_status_success_sampling_rate", @out: false, min: 0, max: 1)]
        public string @DeliveryStatusSuccessSamplingRate { get; }

        [nterraform.Core.TerraformProperty(name: "monthly_spend_limit", @out: false, min: 0, max: 1)]
        public string @MonthlySpendLimit { get; }

        [nterraform.Core.TerraformProperty(name: "usage_report_s3_bucket", @out: false, min: 0, max: 1)]
        public string @UsageReportS3Bucket { get; }
    }

}

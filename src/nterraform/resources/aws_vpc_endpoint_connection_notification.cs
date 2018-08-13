using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_vpc_endpoint_connection_notification")]
    public sealed class aws_vpc_endpoint_connection_notification : nterraform.resource
    {
        public aws_vpc_endpoint_connection_notification(string[] @connectionEvents,
                                                        string @connectionNotificationArn,
                                                        string @vpcEndpointId = null,
                                                        string @vpcEndpointServiceId = null)
        {
            @ConnectionEvents = @connectionEvents;
            @ConnectionNotificationArn = @connectionNotificationArn;
            @VpcEndpointId = @vpcEndpointId;
            @VpcEndpointServiceId = @vpcEndpointServiceId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "connection_events", @out: false, min: 1, max: 1)]
        public string[] @ConnectionEvents { get; }

        [nterraform.TerraformProperty(name: "connection_notification_arn", @out: false, min: 1, max: 1)]
        public string @ConnectionNotificationArn { get; }

        [nterraform.TerraformProperty(name: "notification_type", @out: true, min: 0, max: 1)]
        public string @NotificationType { get; }

        [nterraform.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.TerraformProperty(name: "vpc_endpoint_id", @out: false, min: 0, max: 1)]
        public string @VpcEndpointId { get; }

        [nterraform.TerraformProperty(name: "vpc_endpoint_service_id", @out: false, min: 0, max: 1)]
        public string @VpcEndpointServiceId { get; }
    }

}

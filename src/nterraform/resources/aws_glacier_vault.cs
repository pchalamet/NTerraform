using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_glacier_vault")]
    public sealed class aws_glacier_vault : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "notification")]
        public sealed class notification : nterraform.structure
        {
            public notification(string[] @events,
                                string @snsTopic)
            {
                @Events = @events;
                @SnsTopic = @snsTopic;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "events", @out: false, min: 1, max: 1)]
            public string[] @Events { get; }

            [nterraform.TerraformProperty(name: "sns_topic", @out: false, min: 1, max: 1)]
            public string @SnsTopic { get; }
        }

        public aws_glacier_vault(string @name,
                                 string @accessPolicy = null,
                                 notification[] @notification = null,
                                 Dictionary<string,string> @tags = null)
        {
            @Name = @name;
            @AccessPolicy = @accessPolicy;
            @Notification = @notification;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "access_policy", @out: false, min: 0, max: 1)]
        public string @AccessPolicy { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "notification", @out: false, min: 0, max: 0)]
        public notification[] @Notification { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}

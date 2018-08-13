using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_codecommit_trigger")]
    public sealed class aws_codecommit_trigger : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "trigger")]
        public sealed class trigger : nterraform.structure
        {
            public trigger(string @destinationArn,
                           string[] @events,
                           string @name,
                           string[] @branches = null,
                           string @customData = null)
            {
                @DestinationArn = @destinationArn;
                @Events = @events;
                @Name = @name;
                @Branches = @branches;
                @CustomData = @customData;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "destination_arn", @out: false, min: 1, max: 1)]
            public string @DestinationArn { get; }

            [nterraform.TerraformProperty(name: "events", @out: false, min: 1, max: 1)]
            public string[] @Events { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "branches", @out: false, min: 0, max: 1)]
            public string[] @Branches { get; }

            [nterraform.TerraformProperty(name: "custom_data", @out: false, min: 0, max: 1)]
            public string @CustomData { get; }
        }

        public aws_codecommit_trigger(string @repositoryName,
                                      trigger[] @trigger)
        {
            @RepositoryName = @repositoryName;
            @Trigger = @trigger;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "repository_name", @out: false, min: 1, max: 1)]
        public string @RepositoryName { get; }

        [nterraform.TerraformProperty(name: "trigger", @out: false, min: 1, max: 10)]
        public trigger[] @Trigger { get; }

        [nterraform.TerraformProperty(name: "configuration_id", @out: true, min: 0, max: 1)]
        public string @ConfigurationId { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_gamelift_alias")]
    public sealed class aws_gamelift_alias : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "routing_strategy")]
        public sealed class routing_strategy : nterraform.structure
        {
            public routing_strategy(string @type,
                                    string @fleetId = null,
                                    string @message = null)
            {
                @Type = @type;
                @FleetId = @fleetId;
                @Message = @message;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "fleet_id", @out: false, min: 0, max: 1)]
            public string @FleetId { get; }

            [nterraform.TerraformProperty(name: "message", @out: false, min: 0, max: 1)]
            public string @Message { get; }
        }

        public aws_gamelift_alias(string @name,
                                  routing_strategy[] @routingStrategy,
                                  string @description = null)
        {
            @Name = @name;
            @RoutingStrategy = @routingStrategy;
            @Description = @description;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "routing_strategy", @out: false, min: 1, max: 1)]
        public routing_strategy[] @RoutingStrategy { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }
    }

}

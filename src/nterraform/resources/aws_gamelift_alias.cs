using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_gamelift_alias")]
    public sealed class aws_gamelift_alias : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "routing_strategy")]
        public sealed class routing_strategy : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "fleet_id", @out: false, min: 0, max: 1)]
            public string @FleetId { get; }

            [nterraform.Core.TerraformProperty(name: "message", @out: false, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "routing_strategy", @out: false, min: 1, max: 1)]
        public routing_strategy[] @RoutingStrategy { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }
    }

}

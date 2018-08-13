using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ssm_maintenance_window_target")]
    public sealed class aws_ssm_maintenance_window_target : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "targets")]
        public sealed class targets : nterraform.structure
        {
            public targets(string @key,
                           string[] @values)
            {
                @Key = @key;
                @Values = @values;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
            public string @Key { get; }

            [nterraform.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        public aws_ssm_maintenance_window_target(string @resourceType,
                                                 targets[] @targets,
                                                 string @windowId,
                                                 string @ownerInformation = null)
        {
            @ResourceType = @resourceType;
            @Targets = @targets;
            @WindowId = @windowId;
            @OwnerInformation = @ownerInformation;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "resource_type", @out: false, min: 1, max: 1)]
        public string @ResourceType { get; }

        [nterraform.TerraformProperty(name: "targets", @out: false, min: 1, max: 5)]
        public targets[] @Targets { get; }

        [nterraform.TerraformProperty(name: "window_id", @out: false, min: 1, max: 1)]
        public string @WindowId { get; }

        [nterraform.TerraformProperty(name: "owner_information", @out: false, min: 0, max: 1)]
        public string @OwnerInformation { get; }
    }

}

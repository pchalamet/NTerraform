using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_glue_connection")]
    public sealed class aws_glue_connection : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "physical_connection_requirements")]
        public sealed class physical_connection_requirements : nterraform.structure
        {
            public physical_connection_requirements(string @availabilityZone = null,
                                                    string[] @securityGroupIdList = null,
                                                    string @subnetId = null)
            {
                @AvailabilityZone = @availabilityZone;
                @SecurityGroupIdList = @securityGroupIdList;
                @SubnetId = @subnetId;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "availability_zone", @out: false, min: 0, max: 1)]
            public string @AvailabilityZone { get; }

            [nterraform.TerraformProperty(name: "security_group_id_list", @out: false, min: 0, max: 1)]
            public string[] @SecurityGroupIdList { get; }

            [nterraform.TerraformProperty(name: "subnet_id", @out: false, min: 0, max: 1)]
            public string @SubnetId { get; }
        }

        public aws_glue_connection(Dictionary<string,string> @connectionProperties,
                                   string @name,
                                   string @connectionType = null,
                                   string @description = null,
                                   string[] @matchCriteria = null,
                                   physical_connection_requirements[] @physicalConnectionRequirements = null)
        {
            @ConnectionProperties = @connectionProperties;
            @Name = @name;
            @ConnectionType = @connectionType;
            @Description = @description;
            @MatchCriteria = @matchCriteria;
            @PhysicalConnectionRequirements = @physicalConnectionRequirements;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "connection_properties", @out: false, min: 1, max: 1)]
        public Dictionary<string,string> @ConnectionProperties { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "catalog_id", @out: true, min: 0, max: 1)]
        public string @CatalogId { get; }

        [nterraform.TerraformProperty(name: "connection_type", @out: false, min: 0, max: 1)]
        public string @ConnectionType { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "match_criteria", @out: false, min: 0, max: 1)]
        public string[] @MatchCriteria { get; }

        [nterraform.TerraformProperty(name: "physical_connection_requirements", @out: false, min: 0, max: 1)]
        public physical_connection_requirements[] @PhysicalConnectionRequirements { get; }
    }

}

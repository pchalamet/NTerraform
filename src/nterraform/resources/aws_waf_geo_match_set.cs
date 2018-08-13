using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_waf_geo_match_set")]
    public sealed class aws_waf_geo_match_set : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "geo_match_constraint")]
        public sealed class geo_match_constraint : nterraform.structure
        {
            public geo_match_constraint(string @type,
                                        string @value)
            {
                @Type = @type;
                @Value = @value;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }
        }

        public aws_waf_geo_match_set(string @name,
                                     geo_match_constraint[] @geoMatchConstraint = null)
        {
            @Name = @name;
            @GeoMatchConstraint = @geoMatchConstraint;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "geo_match_constraint", @out: false, min: 0, max: 0)]
        public geo_match_constraint[] @GeoMatchConstraint { get; }
    }

}

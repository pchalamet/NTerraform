using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_wafregional_sql_injection_match_set")]
    public sealed class aws_wafregional_sql_injection_match_set : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "sql_injection_match_tuple")]
        public sealed class sql_injection_match_tuple : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "field_to_match")]
            public sealed class field_to_match : nterraform.structure
            {
                public field_to_match(string @type,
                                      string @data = null)
                {
                    @Type = @type;
                    @Data = @data;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                public string @Type { get; }

                [nterraform.TerraformProperty(name: "data", @out: false, min: 0, max: 1)]
                public string @Data { get; }
            }

            public sql_injection_match_tuple(field_to_match[] @fieldToMatch,
                                             string @textTransformation)
            {
                @FieldToMatch = @fieldToMatch;
                @TextTransformation = @textTransformation;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "field_to_match", @out: false, min: 1, max: 1)]
            public field_to_match[] @FieldToMatch { get; }

            [nterraform.TerraformProperty(name: "text_transformation", @out: false, min: 1, max: 1)]
            public string @TextTransformation { get; }
        }

        public aws_wafregional_sql_injection_match_set(string @name,
                                                       sql_injection_match_tuple[] @sqlInjectionMatchTuple = null)
        {
            @Name = @name;
            @SqlInjectionMatchTuple = @sqlInjectionMatchTuple;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "sql_injection_match_tuple", @out: false, min: 0, max: 0)]
        public sql_injection_match_tuple[] @SqlInjectionMatchTuple { get; }
    }

}

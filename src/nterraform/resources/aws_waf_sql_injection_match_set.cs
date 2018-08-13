using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_waf_sql_injection_match_set")]
    public sealed class aws_waf_sql_injection_match_set : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "sql_injection_match_tuples")]
        public sealed class sql_injection_match_tuples : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "field_to_match")]
            public sealed class field_to_match : nterraform.Core.structure
            {
                public field_to_match(string @type,
                                      string @data = null)
                {
                    @Type = @type;
                    @Data = @data;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                public string @Type { get; }

                [nterraform.Core.TerraformProperty(name: "data", @out: false, min: 0, max: 1)]
                public string @Data { get; }
            }

            public sql_injection_match_tuples(field_to_match[] @fieldToMatch,
                                              string @textTransformation)
            {
                @FieldToMatch = @fieldToMatch;
                @TextTransformation = @textTransformation;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "field_to_match", @out: false, min: 1, max: 1)]
            public field_to_match[] @FieldToMatch { get; }

            [nterraform.Core.TerraformProperty(name: "text_transformation", @out: false, min: 1, max: 1)]
            public string @TextTransformation { get; }
        }

        public aws_waf_sql_injection_match_set(string @name,
                                               sql_injection_match_tuples[] @sqlInjectionMatchTuples = null)
        {
            @Name = @name;
            @SqlInjectionMatchTuples = @sqlInjectionMatchTuples;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "sql_injection_match_tuples", @out: false, min: 0, max: 0)]
        public sql_injection_match_tuples[] @SqlInjectionMatchTuples { get; }
    }

}

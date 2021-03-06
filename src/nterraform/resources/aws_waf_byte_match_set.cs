using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_waf_byte_match_set")]
    public sealed class aws_waf_byte_match_set : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "byte_match_tuples")]
        public sealed class byte_match_tuples : nterraform.structure
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

            public byte_match_tuples(field_to_match[] @fieldToMatch,
                                     string @positionalConstraint,
                                     string @textTransformation,
                                     string @targetString = null)
            {
                @FieldToMatch = @fieldToMatch;
                @PositionalConstraint = @positionalConstraint;
                @TextTransformation = @textTransformation;
                @TargetString = @targetString;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "field_to_match", @out: false, min: 1, max: 1)]
            public field_to_match[] @FieldToMatch { get; }

            [nterraform.TerraformProperty(name: "positional_constraint", @out: false, min: 1, max: 1)]
            public string @PositionalConstraint { get; }

            [nterraform.TerraformProperty(name: "text_transformation", @out: false, min: 1, max: 1)]
            public string @TextTransformation { get; }

            [nterraform.TerraformProperty(name: "target_string", @out: false, min: 0, max: 1)]
            public string @TargetString { get; }
        }

        public aws_waf_byte_match_set(string @name,
                                      byte_match_tuples[] @byteMatchTuples = null)
        {
            @Name = @name;
            @ByteMatchTuples = @byteMatchTuples;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "byte_match_tuples", @out: false, min: 0, max: 0)]
        public byte_match_tuples[] @ByteMatchTuples { get; }
    }

}

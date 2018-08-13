using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_wafregional_byte_match_set")]
    public sealed class aws_wafregional_byte_match_set : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "byte_match_tuples")]
        public sealed class byte_match_tuples : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "field_to_match", @out: false, min: 1, max: 1)]
            public field_to_match[] @FieldToMatch { get; }

            [nterraform.Core.TerraformProperty(name: "positional_constraint", @out: false, min: 1, max: 1)]
            public string @PositionalConstraint { get; }

            [nterraform.Core.TerraformProperty(name: "text_transformation", @out: false, min: 1, max: 1)]
            public string @TextTransformation { get; }

            [nterraform.Core.TerraformProperty(name: "target_string", @out: false, min: 0, max: 1)]
            public string @TargetString { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "byte_match_tuple")]
        public sealed class byte_match_tuple : nterraform.Core.structure
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

            public byte_match_tuple(field_to_match[] @fieldToMatch,
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

            [nterraform.Core.TerraformProperty(name: "field_to_match", @out: false, min: 1, max: 1)]
            public field_to_match[] @FieldToMatch { get; }

            [nterraform.Core.TerraformProperty(name: "positional_constraint", @out: false, min: 1, max: 1)]
            public string @PositionalConstraint { get; }

            [nterraform.Core.TerraformProperty(name: "text_transformation", @out: false, min: 1, max: 1)]
            public string @TextTransformation { get; }

            [nterraform.Core.TerraformProperty(name: "target_string", @out: false, min: 0, max: 1)]
            public string @TargetString { get; }
        }

        public aws_wafregional_byte_match_set(string @name,
                                              byte_match_tuple[] @byteMatchTuple = null,
                                              byte_match_tuples[] @byteMatchTuples = null)
        {
            @Name = @name;
            @ByteMatchTuple = @byteMatchTuple;
            @ByteMatchTuples = @byteMatchTuples;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "byte_match_tuple", @out: false, min: 0, max: 0)]
        public byte_match_tuple[] @ByteMatchTuple { get; }

        [nterraform.Core.TerraformProperty(name: "byte_match_tuples", @out: false, min: 0, max: 0)]
        public byte_match_tuples[] @ByteMatchTuples { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_wafregional_size_constraint_set")]
    public sealed class aws_wafregional_size_constraint_set : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "size_constraints")]
        public sealed class size_constraints : nterraform.Core.structure
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

            public size_constraints(string @comparisonOperator,
                                    field_to_match[] @fieldToMatch,
                                    int @size,
                                    string @textTransformation)
            {
                @ComparisonOperator = @comparisonOperator;
                @FieldToMatch = @fieldToMatch;
                @Size = @size;
                @TextTransformation = @textTransformation;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "comparison_operator", @out: false, min: 1, max: 1)]
            public string @ComparisonOperator { get; }

            [nterraform.Core.TerraformProperty(name: "field_to_match", @out: false, min: 1, max: 1)]
            public field_to_match[] @FieldToMatch { get; }

            [nterraform.Core.TerraformProperty(name: "size", @out: false, min: 1, max: 1)]
            public int @Size { get; }

            [nterraform.Core.TerraformProperty(name: "text_transformation", @out: false, min: 1, max: 1)]
            public string @TextTransformation { get; }
        }

        public aws_wafregional_size_constraint_set(string @name,
                                                   size_constraints[] @sizeConstraints = null)
        {
            @Name = @name;
            @SizeConstraints = @sizeConstraints;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "size_constraints", @out: false, min: 0, max: 0)]
        public size_constraints[] @SizeConstraints { get; }
    }

}

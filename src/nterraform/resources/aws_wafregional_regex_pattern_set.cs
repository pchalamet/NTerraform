using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_wafregional_regex_pattern_set")]
    public sealed class aws_wafregional_regex_pattern_set : nterraform.Core.resource
    {
        public aws_wafregional_regex_pattern_set(string @name,
                                                 string[] @regexPatternStrings = null)
        {
            @Name = @name;
            @RegexPatternStrings = @regexPatternStrings;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "regex_pattern_strings", @out: false, min: 0, max: 1)]
        public string[] @RegexPatternStrings { get; }
    }

}

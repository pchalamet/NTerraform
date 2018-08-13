using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_glue_classifier")]
    public sealed class aws_glue_classifier : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "json_classifier")]
        public sealed class json_classifier : nterraform.Core.structure
        {
            public json_classifier(string @jsonPath)
            {
                @JsonPath = @jsonPath;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "json_path", @out: false, min: 1, max: 1)]
            public string @JsonPath { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "xml_classifier")]
        public sealed class xml_classifier : nterraform.Core.structure
        {
            public xml_classifier(string @classification,
                                  string @rowTag)
            {
                @Classification = @classification;
                @RowTag = @rowTag;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "classification", @out: false, min: 1, max: 1)]
            public string @Classification { get; }

            [nterraform.Core.TerraformProperty(name: "row_tag", @out: false, min: 1, max: 1)]
            public string @RowTag { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "grok_classifier")]
        public sealed class grok_classifier : nterraform.Core.structure
        {
            public grok_classifier(string @classification,
                                   string @grokPattern,
                                   string @customPatterns = null)
            {
                @Classification = @classification;
                @GrokPattern = @grokPattern;
                @CustomPatterns = @customPatterns;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "classification", @out: false, min: 1, max: 1)]
            public string @Classification { get; }

            [nterraform.Core.TerraformProperty(name: "grok_pattern", @out: false, min: 1, max: 1)]
            public string @GrokPattern { get; }

            [nterraform.Core.TerraformProperty(name: "custom_patterns", @out: false, min: 0, max: 1)]
            public string @CustomPatterns { get; }
        }

        public aws_glue_classifier(string @name,
                                   grok_classifier[] @grokClassifier = null,
                                   json_classifier[] @jsonClassifier = null,
                                   xml_classifier[] @xmlClassifier = null)
        {
            @Name = @name;
            @GrokClassifier = @grokClassifier;
            @JsonClassifier = @jsonClassifier;
            @XmlClassifier = @xmlClassifier;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "grok_classifier", @out: false, min: 0, max: 1)]
        public grok_classifier[] @GrokClassifier { get; }

        [nterraform.Core.TerraformProperty(name: "json_classifier", @out: false, min: 0, max: 1)]
        public json_classifier[] @JsonClassifier { get; }

        [nterraform.Core.TerraformProperty(name: "xml_classifier", @out: false, min: 0, max: 1)]
        public xml_classifier[] @XmlClassifier { get; }
    }

}

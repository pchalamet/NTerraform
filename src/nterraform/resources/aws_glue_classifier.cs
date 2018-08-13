using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_glue_classifier")]
    public sealed class aws_glue_classifier : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "json_classifier")]
        public sealed class json_classifier : nterraform.structure
        {
            public json_classifier(string @jsonPath)
            {
                @JsonPath = @jsonPath;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "json_path", @out: false, min: 1, max: 1)]
            public string @JsonPath { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "xml_classifier")]
        public sealed class xml_classifier : nterraform.structure
        {
            public xml_classifier(string @classification,
                                  string @rowTag)
            {
                @Classification = @classification;
                @RowTag = @rowTag;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "classification", @out: false, min: 1, max: 1)]
            public string @Classification { get; }

            [nterraform.TerraformProperty(name: "row_tag", @out: false, min: 1, max: 1)]
            public string @RowTag { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "grok_classifier")]
        public sealed class grok_classifier : nterraform.structure
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

            [nterraform.TerraformProperty(name: "classification", @out: false, min: 1, max: 1)]
            public string @Classification { get; }

            [nterraform.TerraformProperty(name: "grok_pattern", @out: false, min: 1, max: 1)]
            public string @GrokPattern { get; }

            [nterraform.TerraformProperty(name: "custom_patterns", @out: false, min: 0, max: 1)]
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "grok_classifier", @out: false, min: 0, max: 1)]
        public grok_classifier[] @GrokClassifier { get; }

        [nterraform.TerraformProperty(name: "json_classifier", @out: false, min: 0, max: 1)]
        public json_classifier[] @JsonClassifier { get; }

        [nterraform.TerraformProperty(name: "xml_classifier", @out: false, min: 0, max: 1)]
        public xml_classifier[] @XmlClassifier { get; }
    }

}

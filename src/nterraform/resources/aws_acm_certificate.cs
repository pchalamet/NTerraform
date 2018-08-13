using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_acm_certificate")]
    public sealed class aws_acm_certificate : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "domain_validation_options")]
        public sealed class domain_validation_options : nterraform.structure
        {
            public domain_validation_options()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "domain_name", @out: true, min: 0, max: 1)]
            public string @DomainName { get; }

            [nterraform.TerraformProperty(name: "resource_record_name", @out: true, min: 0, max: 1)]
            public string @ResourceRecordName { get; }

            [nterraform.TerraformProperty(name: "resource_record_type", @out: true, min: 0, max: 1)]
            public string @ResourceRecordType { get; }

            [nterraform.TerraformProperty(name: "resource_record_value", @out: true, min: 0, max: 1)]
            public string @ResourceRecordValue { get; }
        }

        public aws_acm_certificate(string @domainName,
                                   string @validationMethod,
                                   domain_validation_options[] @domainValidationOptions = null,
                                   string[] @subjectAlternativeNames = null,
                                   Dictionary<string,string> @tags = null)
        {
            @DomainName = @domainName;
            @ValidationMethod = @validationMethod;
            @DomainValidationOptions = @domainValidationOptions;
            @SubjectAlternativeNames = @subjectAlternativeNames;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "domain_name", @out: false, min: 1, max: 1)]
        public string @DomainName { get; }

        [nterraform.TerraformProperty(name: "validation_method", @out: false, min: 1, max: 1)]
        public string @ValidationMethod { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "domain_validation_options", @out: false, min: 0, max: 0)]
        public domain_validation_options[] @DomainValidationOptions { get; }

        [nterraform.TerraformProperty(name: "subject_alternative_names", @out: false, min: 0, max: 1)]
        public string[] @SubjectAlternativeNames { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "validation_emails", @out: true, min: 0, max: 1)]
        public string[] @ValidationEmails { get; }
    }

}

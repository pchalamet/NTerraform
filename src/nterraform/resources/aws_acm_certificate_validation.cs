using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_acm_certificate_validation")]
    public sealed class aws_acm_certificate_validation : nterraform.resource
    {
        public aws_acm_certificate_validation(string @certificateArn,
                                              string[] @validationRecordFqdns = null)
        {
            @CertificateArn = @certificateArn;
            @ValidationRecordFqdns = @validationRecordFqdns;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "certificate_arn", @out: false, min: 1, max: 1)]
        public string @CertificateArn { get; }

        [nterraform.TerraformProperty(name: "validation_record_fqdns", @out: false, min: 0, max: 1)]
        public string[] @ValidationRecordFqdns { get; }
    }

}

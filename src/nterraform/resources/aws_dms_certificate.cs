using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_dms_certificate")]
    public sealed class aws_dms_certificate : nterraform.resource
    {
        public aws_dms_certificate(string @certificateId,
                                   string @certificatePem = null,
                                   string @certificateWallet = null)
        {
            @CertificateId = @certificateId;
            @CertificatePem = @certificatePem;
            @CertificateWallet = @certificateWallet;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "certificate_id", @out: false, min: 1, max: 1)]
        public string @CertificateId { get; }

        [nterraform.TerraformProperty(name: "certificate_arn", @out: true, min: 0, max: 1)]
        public string @CertificateArn { get; }

        [nterraform.TerraformProperty(name: "certificate_pem", @out: false, min: 0, max: 1)]
        public string @CertificatePem { get; }

        [nterraform.TerraformProperty(name: "certificate_wallet", @out: false, min: 0, max: 1)]
        public string @CertificateWallet { get; }
    }

}

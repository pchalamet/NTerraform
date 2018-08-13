using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_api_gateway_client_certificate")]
    public sealed class aws_api_gateway_client_certificate : nterraform.resource
    {
        public aws_api_gateway_client_certificate(string @description = null)
        {
            @Description = @description;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "created_date", @out: true, min: 0, max: 1)]
        public string @CreatedDate { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "expiration_date", @out: true, min: 0, max: 1)]
        public string @ExpirationDate { get; }

        [nterraform.TerraformProperty(name: "pem_encoded_certificate", @out: true, min: 0, max: 1)]
        public string @PemEncodedCertificate { get; }
    }

}

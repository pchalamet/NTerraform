using System.Collections.Generic;

namespace nterraform.providers
{
    [nterraform.TerraformStructure(category: "provider", typeName: "consul")]
    public sealed class consul : nterraform.provider
    {
        public consul(string @address = null,
                      string @caFile = null,
                      string @certFile = null,
                      string @datacenter = null,
                      string @httpAuth = null,
                      bool? @insecureHttps = null,
                      string @keyFile = null,
                      string @scheme = null,
                      string @token = null)
        {
            @Address = @address;
            @CaFile = @caFile;
            @CertFile = @certFile;
            @Datacenter = @datacenter;
            @HttpAuth = @httpAuth;
            @InsecureHttps = @insecureHttps;
            @KeyFile = @keyFile;
            @Scheme = @scheme;
            @Token = @token;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "address", @out: false, min: 0, max: 1)]
        public string @Address { get; }

        [nterraform.TerraformProperty(name: "ca_file", @out: false, min: 0, max: 1)]
        public string @CaFile { get; }

        [nterraform.TerraformProperty(name: "cert_file", @out: false, min: 0, max: 1)]
        public string @CertFile { get; }

        [nterraform.TerraformProperty(name: "datacenter", @out: false, min: 0, max: 1)]
        public string @Datacenter { get; }

        [nterraform.TerraformProperty(name: "http_auth", @out: false, min: 0, max: 1)]
        public string @HttpAuth { get; }

        [nterraform.TerraformProperty(name: "insecure_https", @out: false, min: 0, max: 1)]
        public bool? @InsecureHttps { get; }

        [nterraform.TerraformProperty(name: "key_file", @out: false, min: 0, max: 1)]
        public string @KeyFile { get; }

        [nterraform.TerraformProperty(name: "scheme", @out: false, min: 0, max: 1)]
        public string @Scheme { get; }

        [nterraform.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }
    }

}

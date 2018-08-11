using System.Collections.Generic;

namespace NTerraform.Providers
{
    [TerraformStructure(category: "provider", typeName: "consul")]
    public sealed class consul : NTerraform.provider
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
        }

        [TerraformProperty(name: "address", @out: false, min: 0, max: 1)]
        public string @Address { get; }

        [TerraformProperty(name: "ca_file", @out: false, min: 0, max: 1)]
        public string @CaFile { get; }

        [TerraformProperty(name: "cert_file", @out: false, min: 0, max: 1)]
        public string @CertFile { get; }

        [TerraformProperty(name: "datacenter", @out: false, min: 0, max: 1)]
        public string @Datacenter { get; }

        [TerraformProperty(name: "http_auth", @out: false, min: 0, max: 1)]
        public string @HttpAuth { get; }

        [TerraformProperty(name: "insecure_https", @out: false, min: 0, max: 1)]
        public bool? @InsecureHttps { get; }

        [TerraformProperty(name: "key_file", @out: false, min: 0, max: 1)]
        public string @KeyFile { get; }

        [TerraformProperty(name: "scheme", @out: false, min: 0, max: 1)]
        public string @Scheme { get; }

        [TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public string @Token { get; }
    }

}

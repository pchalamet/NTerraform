using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.providers
{
    [nterraform.Core.TerraformStructure(category: "provider", typeName: "consul")]
    public sealed class consul : nterraform.Core.provider
    {
        public consul(FSharpOption<string> @address = null,
                      FSharpOption<string> @caFile = null,
                      FSharpOption<string> @certFile = null,
                      FSharpOption<string> @datacenter = null,
                      FSharpOption<string> @httpAuth = null,
                      FSharpOption<bool> @insecureHttps = null,
                      FSharpOption<string> @keyFile = null,
                      FSharpOption<string> @scheme = null,
                      FSharpOption<string> @token = null)
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

        [nterraform.Core.TerraformProperty(name: "address", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Address { get; }

        [nterraform.Core.TerraformProperty(name: "ca_file", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @CaFile { get; }

        [nterraform.Core.TerraformProperty(name: "cert_file", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @CertFile { get; }

        [nterraform.Core.TerraformProperty(name: "datacenter", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Datacenter { get; }

        [nterraform.Core.TerraformProperty(name: "http_auth", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @HttpAuth { get; }

        [nterraform.Core.TerraformProperty(name: "insecure_https", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @InsecureHttps { get; }

        [nterraform.Core.TerraformProperty(name: "key_file", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @KeyFile { get; }

        [nterraform.Core.TerraformProperty(name: "scheme", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Scheme { get; }

        [nterraform.Core.TerraformProperty(name: "token", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Token { get; }
    }

}

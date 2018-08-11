using System.Collections.Generic;

namespace NTerraform.Providers
{
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

        public string @Address { get; }
        public string @CaFile { get; }
        public string @CertFile { get; }
        public string @Datacenter { get; }
        public string @HttpAuth { get; }
        public bool? @InsecureHttps { get; }
        public string @KeyFile { get; }
        public string @Scheme { get; }
        public string @Token { get; }
    }

}

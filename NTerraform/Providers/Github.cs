using System.Collections.Generic;

namespace NTerraform.Providers
{
    [TerraformStructure(category: "provider", typeName: "github")]
    public sealed class github : NTerraform.provider
    {
        public github(string @organization,
                      string @token,
                      string @baseUrl = null)
        {
            @Organization = @organization;
            @Token = @token;
            @BaseUrl = @baseUrl;
            base._validate_();
        }

        [TerraformProperty(name: "organization", @out: false, min: 1, max: 1)]
        public string @Organization { get; }

        [TerraformProperty(name: "token", @out: false, min: 1, max: 1)]
        public string @Token { get; }

        [TerraformProperty(name: "base_url", @out: false, min: 0, max: 1)]
        public string @BaseUrl { get; }
    }

}

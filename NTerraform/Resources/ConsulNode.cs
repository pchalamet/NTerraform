using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class consul_node : NTerraform.resource
    {
        public consul_node(string @address,
                           string @name,
                           string @token = null)
        {
            @Address = @address;
            @Name = @name;
            @Token = @token;
        }

        public string @Address { get; }
        public string @Name { get; }
        public string @Datacenter { get; }
        public string @Token { get; }
    }

}

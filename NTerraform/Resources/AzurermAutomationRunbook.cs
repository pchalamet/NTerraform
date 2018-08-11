using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_automation_runbook : NTerraform.resource
    {
        public class publish_content_link
        {
            public class hash
            {
                public hash(string @algorithm,
                            string @value)
                {
                    @Algorithm = @algorithm;
                    @Value = @value;
                }

                public string @Algorithm { get; }
                public string @Value { get; }
            }

            public publish_content_link(string @uri,
                                        hash[] @hash = null,
                                        string @version = null)
            {
                @Uri = @uri;
                @Hash = @hash;
                @Version = @version;
            }

            public string @Uri { get; }
            public hash[] @Hash { get; }
            public string @Version { get; }
        }

        public azurerm_automation_runbook(string @accountName,
                                          string @location,
                                          bool @logProgress,
                                          bool @logVerbose,
                                          string @name,
                                          publish_content_link[] @publishContentLink,
                                          string @resourceGroupName,
                                          string @runbookType,
                                          string @description = null)
        {
            @AccountName = @accountName;
            @Location = @location;
            @LogProgress = @logProgress;
            @LogVerbose = @logVerbose;
            @Name = @name;
            @PublishContentLink = @publishContentLink;
            @ResourceGroupName = @resourceGroupName;
            @RunbookType = @runbookType;
            @Description = @description;
        }

        public string @AccountName { get; }
        public string @Location { get; }
        public bool @LogProgress { get; }
        public bool @LogVerbose { get; }
        public string @Name { get; }
        public publish_content_link[] @PublishContentLink { get; }
        public string @ResourceGroupName { get; }
        public string @RunbookType { get; }
        public string @Description { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}

using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_automation_runbook")]
    public sealed class azurerm_automation_runbook : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "publish_content_link")]
        public sealed class publish_content_link
        {
            [TerraformStructure(category: "", typeName: "hash")]
            public sealed class hash
            {
                public hash(string @algorithm,
                            string @value)
                {
                    @Algorithm = @algorithm;
                    @Value = @value;
                }

                [TerraformProperty(name: "algorithm", @out: false, nested: false, min: 1, max: 1)]
                public string @Algorithm { get; }

                [TerraformProperty(name: "value", @out: false, nested: false, min: 1, max: 1)]
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

            [TerraformProperty(name: "uri", @out: false, nested: false, min: 1, max: 1)]
            public string @Uri { get; }

            [TerraformProperty(name: "hash", @out: false, nested: false, min: 0, max: 1)]
            public hash[] @Hash { get; }

            [TerraformProperty(name: "version", @out: false, nested: false, min: 0, max: 1)]
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

        [TerraformProperty(name: "account_name", @out: false, nested: true, min: 1, max: 1)]
        public string @AccountName { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "log_progress", @out: false, nested: true, min: 1, max: 1)]
        public bool @LogProgress { get; }

        [TerraformProperty(name: "log_verbose", @out: false, nested: true, min: 1, max: 1)]
        public bool @LogVerbose { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "publish_content_link", @out: false, nested: true, min: 1, max: 1)]
        public publish_content_link[] @PublishContentLink { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "runbook_type", @out: false, nested: true, min: 1, max: 1)]
        public string @RunbookType { get; }

        [TerraformProperty(name: "description", @out: false, nested: true, min: 0, max: 1)]
        public string @Description { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}

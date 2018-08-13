using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_automation_runbook")]
    public sealed class azurerm_automation_runbook : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "publish_content_link")]
        public sealed class publish_content_link : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "hash")]
            public sealed class hash : nterraform.structure
            {
                public hash(string @algorithm,
                            string @value)
                {
                    @Algorithm = @algorithm;
                    @Value = @value;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "algorithm", @out: false, min: 1, max: 1)]
                public string @Algorithm { get; }

                [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
                public string @Value { get; }
            }

            public publish_content_link(string @uri,
                                        hash[] @hash = null,
                                        string @version = null)
            {
                @Uri = @uri;
                @Hash = @hash;
                @Version = @version;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "uri", @out: false, min: 1, max: 1)]
            public string @Uri { get; }

            [nterraform.TerraformProperty(name: "hash", @out: false, min: 0, max: 1)]
            public hash[] @Hash { get; }

            [nterraform.TerraformProperty(name: "version", @out: false, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "account_name", @out: false, min: 1, max: 1)]
        public string @AccountName { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "log_progress", @out: false, min: 1, max: 1)]
        public bool @LogProgress { get; }

        [nterraform.TerraformProperty(name: "log_verbose", @out: false, min: 1, max: 1)]
        public bool @LogVerbose { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "publish_content_link", @out: false, min: 1, max: 1)]
        public publish_content_link[] @PublishContentLink { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "runbook_type", @out: false, min: 1, max: 1)]
        public string @RunbookType { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}

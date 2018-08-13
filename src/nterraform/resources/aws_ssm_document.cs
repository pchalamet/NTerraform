using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ssm_document")]
    public sealed class aws_ssm_document : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "parameter")]
        public sealed class parameter : nterraform.Core.structure
        {
            public parameter(string @defaultValue = null,
                             string @description = null,
                             string @name = null,
                             string @type = null)
            {
                @DefaultValue = @defaultValue;
                @Description = @description;
                @Name = @name;
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "default_value", @out: false, min: 0, max: 1)]
            public string @DefaultValue { get; }

            [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
            public string @Description { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
            public string @Type { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "permissions")]
        public sealed class permissions : nterraform.Core.structure
        {
            public permissions(string @accountIds,
                               string @type)
            {
                @AccountIds = @accountIds;
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "account_ids", @out: false, min: 1, max: 1)]
            public string @AccountIds { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        public aws_ssm_document(string @content,
                                string @documentType,
                                string @name,
                                string @documentFormat = null,
                                parameter[] @parameter = null,
                                Dictionary<string,permissions> @permissions = null,
                                Dictionary<string,string> @tags = null)
        {
            @Content = @content;
            @DocumentType = @documentType;
            @Name = @name;
            @DocumentFormat = @documentFormat;
            @Parameter = @parameter;
            @Permissions = @permissions;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "content", @out: false, min: 1, max: 1)]
        public string @Content { get; }

        [nterraform.Core.TerraformProperty(name: "document_type", @out: false, min: 1, max: 1)]
        public string @DocumentType { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "created_date", @out: true, min: 0, max: 1)]
        public string @CreatedDate { get; }

        [nterraform.Core.TerraformProperty(name: "default_version", @out: true, min: 0, max: 1)]
        public string @DefaultVersion { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "document_format", @out: false, min: 0, max: 1)]
        public string @DocumentFormat { get; }

        [nterraform.Core.TerraformProperty(name: "hash", @out: true, min: 0, max: 1)]
        public string @Hash { get; }

        [nterraform.Core.TerraformProperty(name: "hash_type", @out: true, min: 0, max: 1)]
        public string @HashType { get; }

        [nterraform.Core.TerraformProperty(name: "latest_version", @out: true, min: 0, max: 1)]
        public string @LatestVersion { get; }

        [nterraform.Core.TerraformProperty(name: "owner", @out: true, min: 0, max: 1)]
        public string @Owner { get; }

        [nterraform.Core.TerraformProperty(name: "parameter", @out: false, min: 0, max: 0)]
        public parameter[] @Parameter { get; }

        [nterraform.Core.TerraformProperty(name: "permissions", @out: false, min: 0, max: 0)]
        public Dictionary<string,permissions> @Permissions { get; }

        [nterraform.Core.TerraformProperty(name: "platform_types", @out: true, min: 0, max: 1)]
        public string[] @PlatformTypes { get; }

        [nterraform.Core.TerraformProperty(name: "schema_version", @out: true, min: 0, max: 1)]
        public string @SchemaVersion { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}

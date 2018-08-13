using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ssm_document")]
    public sealed class aws_ssm_document : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "parameter")]
        public sealed class parameter : nterraform.structure
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

            [nterraform.TerraformProperty(name: "default_value", @out: false, min: 0, max: 1)]
            public string @DefaultValue { get; }

            [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
            public string @Description { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
            public string @Type { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "permissions")]
        public sealed class permissions : nterraform.structure
        {
            public permissions(string @accountIds,
                               string @type)
            {
                @AccountIds = @accountIds;
                @Type = @type;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "account_ids", @out: false, min: 1, max: 1)]
            public string @AccountIds { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
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

        [nterraform.TerraformProperty(name: "content", @out: false, min: 1, max: 1)]
        public string @Content { get; }

        [nterraform.TerraformProperty(name: "document_type", @out: false, min: 1, max: 1)]
        public string @DocumentType { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "created_date", @out: true, min: 0, max: 1)]
        public string @CreatedDate { get; }

        [nterraform.TerraformProperty(name: "default_version", @out: true, min: 0, max: 1)]
        public string @DefaultVersion { get; }

        [nterraform.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "document_format", @out: false, min: 0, max: 1)]
        public string @DocumentFormat { get; }

        [nterraform.TerraformProperty(name: "hash", @out: true, min: 0, max: 1)]
        public string @Hash { get; }

        [nterraform.TerraformProperty(name: "hash_type", @out: true, min: 0, max: 1)]
        public string @HashType { get; }

        [nterraform.TerraformProperty(name: "latest_version", @out: true, min: 0, max: 1)]
        public string @LatestVersion { get; }

        [nterraform.TerraformProperty(name: "owner", @out: true, min: 0, max: 1)]
        public string @Owner { get; }

        [nterraform.TerraformProperty(name: "parameter", @out: false, min: 0, max: 0)]
        public parameter[] @Parameter { get; }

        [nterraform.TerraformProperty(name: "permissions", @out: false, min: 0, max: 0)]
        public Dictionary<string,permissions> @Permissions { get; }

        [nterraform.TerraformProperty(name: "platform_types", @out: true, min: 0, max: 1)]
        public string[] @PlatformTypes { get; }

        [nterraform.TerraformProperty(name: "schema_version", @out: true, min: 0, max: 1)]
        public string @SchemaVersion { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_codepipeline")]
    public sealed class aws_codepipeline : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "stage")]
        public sealed class stage : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "action")]
            public sealed class action : nterraform.Core.structure
            {
                public action(string @category,
                              string @name,
                              string @owner,
                              string @provider,
                              string @version,
                              Dictionary<string,string> @configuration = null,
                              string[] @inputArtifacts = null,
                              string[] @outputArtifacts = null,
                              string @roleArn = null)
                {
                    @Category = @category;
                    @Name = @name;
                    @Owner = @owner;
                    @Provider = @provider;
                    @Version = @version;
                    @Configuration = @configuration;
                    @InputArtifacts = @inputArtifacts;
                    @OutputArtifacts = @outputArtifacts;
                    @RoleArn = @roleArn;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "category", @out: false, min: 1, max: 1)]
                public string @Category { get; }

                [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.Core.TerraformProperty(name: "owner", @out: false, min: 1, max: 1)]
                public string @Owner { get; }

                [nterraform.Core.TerraformProperty(name: "provider", @out: false, min: 1, max: 1)]
                public string @Provider { get; }

                [nterraform.Core.TerraformProperty(name: "version", @out: false, min: 1, max: 1)]
                public string @Version { get; }

                [nterraform.Core.TerraformProperty(name: "configuration", @out: false, min: 0, max: 1)]
                public Dictionary<string,string> @Configuration { get; }

                [nterraform.Core.TerraformProperty(name: "input_artifacts", @out: false, min: 0, max: 1)]
                public string[] @InputArtifacts { get; }

                [nterraform.Core.TerraformProperty(name: "output_artifacts", @out: false, min: 0, max: 1)]
                public string[] @OutputArtifacts { get; }

                [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 0, max: 1)]
                public string @RoleArn { get; }

                [nterraform.Core.TerraformProperty(name: "run_order", @out: true, min: 0, max: 1)]
                public int? @RunOrder { get; }
            }

            public stage(action[] @action,
                         string @name)
            {
                @Action = @action;
                @Name = @name;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "action", @out: false, min: 1, max: 0)]
            public action[] @Action { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "artifact_store")]
        public sealed class artifact_store : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "encryption_key")]
            public sealed class encryption_key : nterraform.Core.structure
            {
                public encryption_key(string @id,
                                      string @type)
                {
                    @Id = @id;
                    @Type = @type;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "id", @out: false, min: 1, max: 1)]
                public string @Id { get; }

                [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                public string @Type { get; }
            }

            public artifact_store(string @location,
                                  string @type,
                                  encryption_key[] @encryptionKey = null)
            {
                @Location = @location;
                @Type = @type;
                @EncryptionKey = @encryptionKey;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
            public string @Location { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "encryption_key", @out: false, min: 0, max: 1)]
            public encryption_key[] @EncryptionKey { get; }
        }

        public aws_codepipeline(artifact_store[] @artifactStore,
                                string @name,
                                string @roleArn,
                                stage[] @stage)
        {
            @ArtifactStore = @artifactStore;
            @Name = @name;
            @RoleArn = @roleArn;
            @Stage = @stage;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "artifact_store", @out: false, min: 1, max: 1)]
        public artifact_store[] @ArtifactStore { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
        public string @RoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "stage", @out: false, min: 2, max: 0)]
        public stage[] @Stage { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}

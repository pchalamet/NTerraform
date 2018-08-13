using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_codepipeline")]
    public sealed class aws_codepipeline : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "artifact_store")]
        public sealed class artifact_store : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "encryption_key")]
            public sealed class encryption_key : nterraform.structure
            {
                public encryption_key(string @id,
                                      string @type)
                {
                    @Id = @id;
                    @Type = @type;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "id", @out: false, min: 1, max: 1)]
                public string @Id { get; }

                [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
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

            [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
            public string @Location { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "encryption_key", @out: false, min: 0, max: 1)]
            public encryption_key[] @EncryptionKey { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "stage")]
        public sealed class stage : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "action")]
            public sealed class action : nterraform.structure
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

                [nterraform.TerraformProperty(name: "category", @out: false, min: 1, max: 1)]
                public string @Category { get; }

                [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.TerraformProperty(name: "owner", @out: false, min: 1, max: 1)]
                public string @Owner { get; }

                [nterraform.TerraformProperty(name: "provider", @out: false, min: 1, max: 1)]
                public string @Provider { get; }

                [nterraform.TerraformProperty(name: "version", @out: false, min: 1, max: 1)]
                public string @Version { get; }

                [nterraform.TerraformProperty(name: "configuration", @out: false, min: 0, max: 1)]
                public Dictionary<string,string> @Configuration { get; }

                [nterraform.TerraformProperty(name: "input_artifacts", @out: false, min: 0, max: 1)]
                public string[] @InputArtifacts { get; }

                [nterraform.TerraformProperty(name: "output_artifacts", @out: false, min: 0, max: 1)]
                public string[] @OutputArtifacts { get; }

                [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 0, max: 1)]
                public string @RoleArn { get; }

                [nterraform.TerraformProperty(name: "run_order", @out: true, min: 0, max: 1)]
                public int? @RunOrder { get; }
            }

            public stage(action[] @action,
                         string @name)
            {
                @Action = @action;
                @Name = @name;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "action", @out: false, min: 1, max: 0)]
            public action[] @Action { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }
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

        [nterraform.TerraformProperty(name: "artifact_store", @out: false, min: 1, max: 1)]
        public artifact_store[] @ArtifactStore { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
        public string @RoleArn { get; }

        [nterraform.TerraformProperty(name: "stage", @out: false, min: 2, max: 0)]
        public stage[] @Stage { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}

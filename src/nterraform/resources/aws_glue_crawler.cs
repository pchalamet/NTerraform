using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_glue_crawler")]
    public sealed class aws_glue_crawler : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "dynamodb_target")]
        public sealed class dynamodb_target : nterraform.structure
        {
            public dynamodb_target(string @path)
            {
                @Path = @path;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "path", @out: false, min: 1, max: 1)]
            public string @Path { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "jdbc_target")]
        public sealed class jdbc_target : nterraform.structure
        {
            public jdbc_target(string @connectionName,
                               string @path,
                               string[] @exclusions = null)
            {
                @ConnectionName = @connectionName;
                @Path = @path;
                @Exclusions = @exclusions;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "connection_name", @out: false, min: 1, max: 1)]
            public string @ConnectionName { get; }

            [nterraform.TerraformProperty(name: "path", @out: false, min: 1, max: 1)]
            public string @Path { get; }

            [nterraform.TerraformProperty(name: "exclusions", @out: false, min: 0, max: 1)]
            public string[] @Exclusions { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "schema_change_policy")]
        public sealed class schema_change_policy : nterraform.structure
        {
            public schema_change_policy(string @deleteBehavior = null,
                                        string @updateBehavior = null)
            {
                @DeleteBehavior = @deleteBehavior;
                @UpdateBehavior = @updateBehavior;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "delete_behavior", @out: false, min: 0, max: 1)]
            public string @DeleteBehavior { get; }

            [nterraform.TerraformProperty(name: "update_behavior", @out: false, min: 0, max: 1)]
            public string @UpdateBehavior { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "s3_target")]
        public sealed class s3_target : nterraform.structure
        {
            public s3_target(string @path,
                             string[] @exclusions = null)
            {
                @Path = @path;
                @Exclusions = @exclusions;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "path", @out: false, min: 1, max: 1)]
            public string @Path { get; }

            [nterraform.TerraformProperty(name: "exclusions", @out: false, min: 0, max: 1)]
            public string[] @Exclusions { get; }
        }

        public aws_glue_crawler(string @databaseName,
                                dynamodb_target[] @dynamodbTarget,
                                jdbc_target[] @jdbcTarget,
                                string @name,
                                string @role,
                                s3_target[] @s3Target,
                                string[] @classifiers = null,
                                string @configuration = null,
                                string @description = null,
                                string @schedule = null,
                                schema_change_policy[] @schemaChangePolicy = null,
                                string @tablePrefix = null)
        {
            @DatabaseName = @databaseName;
            @DynamodbTarget = @dynamodbTarget;
            @JdbcTarget = @jdbcTarget;
            @Name = @name;
            @Role = @role;
            @S3Target = @s3Target;
            @Classifiers = @classifiers;
            @Configuration = @configuration;
            @Description = @description;
            @Schedule = @schedule;
            @SchemaChangePolicy = @schemaChangePolicy;
            @TablePrefix = @tablePrefix;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "database_name", @out: false, min: 1, max: 1)]
        public string @DatabaseName { get; }

        [nterraform.TerraformProperty(name: "dynamodb_target", @out: false, min: 1, max: 0)]
        public dynamodb_target[] @DynamodbTarget { get; }

        [nterraform.TerraformProperty(name: "jdbc_target", @out: false, min: 1, max: 0)]
        public jdbc_target[] @JdbcTarget { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "role", @out: false, min: 1, max: 1)]
        public string @Role { get; }

        [nterraform.TerraformProperty(name: "s3_target", @out: false, min: 1, max: 0)]
        public s3_target[] @S3Target { get; }

        [nterraform.TerraformProperty(name: "classifiers", @out: false, min: 0, max: 1)]
        public string[] @Classifiers { get; }

        [nterraform.TerraformProperty(name: "configuration", @out: false, min: 0, max: 1)]
        public string @Configuration { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "schedule", @out: false, min: 0, max: 1)]
        public string @Schedule { get; }

        [nterraform.TerraformProperty(name: "schema_change_policy", @out: false, min: 0, max: 1)]
        public schema_change_policy[] @SchemaChangePolicy { get; }

        [nterraform.TerraformProperty(name: "table_prefix", @out: false, min: 0, max: 1)]
        public string @TablePrefix { get; }
    }

}

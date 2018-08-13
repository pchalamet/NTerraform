using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_opsworks_application")]
    public sealed class aws_opsworks_application : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "app_source")]
        public sealed class app_source : nterraform.structure
        {
            public app_source(string @type,
                              string @password = null,
                              string @revision = null,
                              string @sshKey = null,
                              string @url = null,
                              string @username = null)
            {
                @Type = @type;
                @Password = @password;
                @Revision = @revision;
                @SshKey = @sshKey;
                @Url = @url;
                @Username = @username;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "password", @out: false, min: 0, max: 1)]
            public string @Password { get; }

            [nterraform.TerraformProperty(name: "revision", @out: false, min: 0, max: 1)]
            public string @Revision { get; }

            [nterraform.TerraformProperty(name: "ssh_key", @out: false, min: 0, max: 1)]
            public string @SshKey { get; }

            [nterraform.TerraformProperty(name: "url", @out: false, min: 0, max: 1)]
            public string @Url { get; }

            [nterraform.TerraformProperty(name: "username", @out: false, min: 0, max: 1)]
            public string @Username { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "environment")]
        public sealed class environment : nterraform.structure
        {
            public environment(string @key,
                               string @value,
                               bool? @secure = null)
            {
                @Key = @key;
                @Value = @value;
                @Secure = @secure;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
            public string @Key { get; }

            [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }

            [nterraform.TerraformProperty(name: "secure", @out: false, min: 0, max: 1)]
            public bool? @Secure { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "ssl_configuration")]
        public sealed class ssl_configuration : nterraform.structure
        {
            public ssl_configuration(string @certificate,
                                     string @privateKey,
                                     string @chain = null)
            {
                @Certificate = @certificate;
                @PrivateKey = @privateKey;
                @Chain = @chain;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "certificate", @out: false, min: 1, max: 1)]
            public string @Certificate { get; }

            [nterraform.TerraformProperty(name: "private_key", @out: false, min: 1, max: 1)]
            public string @PrivateKey { get; }

            [nterraform.TerraformProperty(name: "chain", @out: false, min: 0, max: 1)]
            public string @Chain { get; }
        }

        public aws_opsworks_application(string @name,
                                        string @stackId,
                                        string @type,
                                        app_source[] @appSource = null,
                                        string @autoBundleOnDeploy = null,
                                        string @awsFlowRubySettings = null,
                                        string @dataSourceArn = null,
                                        string @dataSourceDatabaseName = null,
                                        string @dataSourceType = null,
                                        string @description = null,
                                        string @documentRoot = null,
                                        string[] @domains = null,
                                        bool? @enableSsl = null,
                                        environment[] @environment = null,
                                        string @railsEnv = null,
                                        ssl_configuration[] @sslConfiguration = null)
        {
            @Name = @name;
            @StackId = @stackId;
            @Type = @type;
            @AppSource = @appSource;
            @AutoBundleOnDeploy = @autoBundleOnDeploy;
            @AwsFlowRubySettings = @awsFlowRubySettings;
            @DataSourceArn = @dataSourceArn;
            @DataSourceDatabaseName = @dataSourceDatabaseName;
            @DataSourceType = @dataSourceType;
            @Description = @description;
            @DocumentRoot = @documentRoot;
            @Domains = @domains;
            @EnableSsl = @enableSsl;
            @Environment = @environment;
            @RailsEnv = @railsEnv;
            @SslConfiguration = @sslConfiguration;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "stack_id", @out: false, min: 1, max: 1)]
        public string @StackId { get; }

        [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.TerraformProperty(name: "app_source", @out: false, min: 0, max: 0)]
        public app_source[] @AppSource { get; }

        [nterraform.TerraformProperty(name: "auto_bundle_on_deploy", @out: false, min: 0, max: 1)]
        public string @AutoBundleOnDeploy { get; }

        [nterraform.TerraformProperty(name: "aws_flow_ruby_settings", @out: false, min: 0, max: 1)]
        public string @AwsFlowRubySettings { get; }

        [nterraform.TerraformProperty(name: "data_source_arn", @out: false, min: 0, max: 1)]
        public string @DataSourceArn { get; }

        [nterraform.TerraformProperty(name: "data_source_database_name", @out: false, min: 0, max: 1)]
        public string @DataSourceDatabaseName { get; }

        [nterraform.TerraformProperty(name: "data_source_type", @out: false, min: 0, max: 1)]
        public string @DataSourceType { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "document_root", @out: false, min: 0, max: 1)]
        public string @DocumentRoot { get; }

        [nterraform.TerraformProperty(name: "domains", @out: false, min: 0, max: 1)]
        public string[] @Domains { get; }

        [nterraform.TerraformProperty(name: "enable_ssl", @out: false, min: 0, max: 1)]
        public bool? @EnableSsl { get; }

        [nterraform.TerraformProperty(name: "environment", @out: false, min: 0, max: 0)]
        public environment[] @Environment { get; }

        [nterraform.TerraformProperty(name: "rails_env", @out: false, min: 0, max: 1)]
        public string @RailsEnv { get; }

        [nterraform.TerraformProperty(name: "short_name", @out: true, min: 0, max: 1)]
        public string @ShortName { get; }

        [nterraform.TerraformProperty(name: "ssl_configuration", @out: false, min: 0, max: 0)]
        public ssl_configuration[] @SslConfiguration { get; }
    }

}

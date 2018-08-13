using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cognito_user_pool")]
    public sealed class aws_cognito_user_pool : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "admin_create_user_config")]
        public sealed class admin_create_user_config : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "invite_message_template")]
            public sealed class invite_message_template : nterraform.structure
            {
                public invite_message_template(string @emailMessage = null,
                                               string @emailSubject = null,
                                               string @smsMessage = null)
                {
                    @EmailMessage = @emailMessage;
                    @EmailSubject = @emailSubject;
                    @SmsMessage = @smsMessage;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "email_message", @out: false, min: 0, max: 1)]
                public string @EmailMessage { get; }

                [nterraform.TerraformProperty(name: "email_subject", @out: false, min: 0, max: 1)]
                public string @EmailSubject { get; }

                [nterraform.TerraformProperty(name: "sms_message", @out: false, min: 0, max: 1)]
                public string @SmsMessage { get; }
            }

            public admin_create_user_config(bool? @allowAdminCreateUserOnly = null,
                                            invite_message_template[] @inviteMessageTemplate = null,
                                            int? @unusedAccountValidityDays = null)
            {
                @AllowAdminCreateUserOnly = @allowAdminCreateUserOnly;
                @InviteMessageTemplate = @inviteMessageTemplate;
                @UnusedAccountValidityDays = @unusedAccountValidityDays;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "allow_admin_create_user_only", @out: false, min: 0, max: 1)]
            public bool? @AllowAdminCreateUserOnly { get; }

            [nterraform.TerraformProperty(name: "invite_message_template", @out: false, min: 0, max: 1)]
            public invite_message_template[] @InviteMessageTemplate { get; }

            [nterraform.TerraformProperty(name: "unused_account_validity_days", @out: false, min: 0, max: 1)]
            public int? @UnusedAccountValidityDays { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "device_configuration")]
        public sealed class device_configuration : nterraform.structure
        {
            public device_configuration(bool? @challengeRequiredOnNewDevice = null,
                                        bool? @deviceOnlyRememberedOnUserPrompt = null)
            {
                @ChallengeRequiredOnNewDevice = @challengeRequiredOnNewDevice;
                @DeviceOnlyRememberedOnUserPrompt = @deviceOnlyRememberedOnUserPrompt;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "challenge_required_on_new_device", @out: false, min: 0, max: 1)]
            public bool? @ChallengeRequiredOnNewDevice { get; }

            [nterraform.TerraformProperty(name: "device_only_remembered_on_user_prompt", @out: false, min: 0, max: 1)]
            public bool? @DeviceOnlyRememberedOnUserPrompt { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "lambda_config")]
        public sealed class lambda_config : nterraform.structure
        {
            public lambda_config(string @createAuthChallenge = null,
                                 string @customMessage = null,
                                 string @defineAuthChallenge = null,
                                 string @postAuthentication = null,
                                 string @postConfirmation = null,
                                 string @preAuthentication = null,
                                 string @preSignUp = null,
                                 string @preTokenGeneration = null,
                                 string @userMigration = null,
                                 string @verifyAuthChallengeResponse = null)
            {
                @CreateAuthChallenge = @createAuthChallenge;
                @CustomMessage = @customMessage;
                @DefineAuthChallenge = @defineAuthChallenge;
                @PostAuthentication = @postAuthentication;
                @PostConfirmation = @postConfirmation;
                @PreAuthentication = @preAuthentication;
                @PreSignUp = @preSignUp;
                @PreTokenGeneration = @preTokenGeneration;
                @UserMigration = @userMigration;
                @VerifyAuthChallengeResponse = @verifyAuthChallengeResponse;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "create_auth_challenge", @out: false, min: 0, max: 1)]
            public string @CreateAuthChallenge { get; }

            [nterraform.TerraformProperty(name: "custom_message", @out: false, min: 0, max: 1)]
            public string @CustomMessage { get; }

            [nterraform.TerraformProperty(name: "define_auth_challenge", @out: false, min: 0, max: 1)]
            public string @DefineAuthChallenge { get; }

            [nterraform.TerraformProperty(name: "post_authentication", @out: false, min: 0, max: 1)]
            public string @PostAuthentication { get; }

            [nterraform.TerraformProperty(name: "post_confirmation", @out: false, min: 0, max: 1)]
            public string @PostConfirmation { get; }

            [nterraform.TerraformProperty(name: "pre_authentication", @out: false, min: 0, max: 1)]
            public string @PreAuthentication { get; }

            [nterraform.TerraformProperty(name: "pre_sign_up", @out: false, min: 0, max: 1)]
            public string @PreSignUp { get; }

            [nterraform.TerraformProperty(name: "pre_token_generation", @out: false, min: 0, max: 1)]
            public string @PreTokenGeneration { get; }

            [nterraform.TerraformProperty(name: "user_migration", @out: false, min: 0, max: 1)]
            public string @UserMigration { get; }

            [nterraform.TerraformProperty(name: "verify_auth_challenge_response", @out: false, min: 0, max: 1)]
            public string @VerifyAuthChallengeResponse { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "email_configuration")]
        public sealed class email_configuration : nterraform.structure
        {
            public email_configuration(string @replyToEmailAddress = null,
                                       string @sourceArn = null)
            {
                @ReplyToEmailAddress = @replyToEmailAddress;
                @SourceArn = @sourceArn;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "reply_to_email_address", @out: false, min: 0, max: 1)]
            public string @ReplyToEmailAddress { get; }

            [nterraform.TerraformProperty(name: "source_arn", @out: false, min: 0, max: 1)]
            public string @SourceArn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "password_policy")]
        public sealed class password_policy : nterraform.structure
        {
            public password_policy(int? @minimumLength = null,
                                   bool? @requireLowercase = null,
                                   bool? @requireNumbers = null,
                                   bool? @requireSymbols = null,
                                   bool? @requireUppercase = null)
            {
                @MinimumLength = @minimumLength;
                @RequireLowercase = @requireLowercase;
                @RequireNumbers = @requireNumbers;
                @RequireSymbols = @requireSymbols;
                @RequireUppercase = @requireUppercase;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "minimum_length", @out: false, min: 0, max: 1)]
            public int? @MinimumLength { get; }

            [nterraform.TerraformProperty(name: "require_lowercase", @out: false, min: 0, max: 1)]
            public bool? @RequireLowercase { get; }

            [nterraform.TerraformProperty(name: "require_numbers", @out: false, min: 0, max: 1)]
            public bool? @RequireNumbers { get; }

            [nterraform.TerraformProperty(name: "require_symbols", @out: false, min: 0, max: 1)]
            public bool? @RequireSymbols { get; }

            [nterraform.TerraformProperty(name: "require_uppercase", @out: false, min: 0, max: 1)]
            public bool? @RequireUppercase { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "schema")]
        public sealed class schema : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "string_attribute_constraints")]
            public sealed class string_attribute_constraints : nterraform.structure
            {
                public string_attribute_constraints(string @maxLength = null,
                                                    string @minLength = null)
                {
                    @MaxLength = @maxLength;
                    @MinLength = @minLength;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "max_length", @out: false, min: 0, max: 1)]
                public string @MaxLength { get; }

                [nterraform.TerraformProperty(name: "min_length", @out: false, min: 0, max: 1)]
                public string @MinLength { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "number_attribute_constraints")]
            public sealed class number_attribute_constraints : nterraform.structure
            {
                public number_attribute_constraints(string @maxValue = null,
                                                    string @minValue = null)
                {
                    @MaxValue = @maxValue;
                    @MinValue = @minValue;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "max_value", @out: false, min: 0, max: 1)]
                public string @MaxValue { get; }

                [nterraform.TerraformProperty(name: "min_value", @out: false, min: 0, max: 1)]
                public string @MinValue { get; }
            }

            public schema(string @attributeDataType,
                          string @name,
                          bool? @developerOnlyAttribute = null,
                          bool? @mutable = null,
                          number_attribute_constraints[] @numberAttributeConstraints = null,
                          bool? @required = null,
                          string_attribute_constraints[] @stringAttributeConstraints = null)
            {
                @AttributeDataType = @attributeDataType;
                @Name = @name;
                @DeveloperOnlyAttribute = @developerOnlyAttribute;
                @Mutable = @mutable;
                @NumberAttributeConstraints = @numberAttributeConstraints;
                @Required = @required;
                @StringAttributeConstraints = @stringAttributeConstraints;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "attribute_data_type", @out: false, min: 1, max: 1)]
            public string @AttributeDataType { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "developer_only_attribute", @out: false, min: 0, max: 1)]
            public bool? @DeveloperOnlyAttribute { get; }

            [nterraform.TerraformProperty(name: "mutable", @out: false, min: 0, max: 1)]
            public bool? @Mutable { get; }

            [nterraform.TerraformProperty(name: "number_attribute_constraints", @out: false, min: 0, max: 1)]
            public number_attribute_constraints[] @NumberAttributeConstraints { get; }

            [nterraform.TerraformProperty(name: "required", @out: false, min: 0, max: 1)]
            public bool? @Required { get; }

            [nterraform.TerraformProperty(name: "string_attribute_constraints", @out: false, min: 0, max: 1)]
            public string_attribute_constraints[] @StringAttributeConstraints { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "sms_configuration")]
        public sealed class sms_configuration : nterraform.structure
        {
            public sms_configuration(string @externalId,
                                     string @snsCallerArn)
            {
                @ExternalId = @externalId;
                @SnsCallerArn = @snsCallerArn;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "external_id", @out: false, min: 1, max: 1)]
            public string @ExternalId { get; }

            [nterraform.TerraformProperty(name: "sns_caller_arn", @out: false, min: 1, max: 1)]
            public string @SnsCallerArn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "verification_message_template")]
        public sealed class verification_message_template : nterraform.structure
        {
            public verification_message_template(string @defaultEmailOption = null)
            {
                @DefaultEmailOption = @defaultEmailOption;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "default_email_option", @out: false, min: 0, max: 1)]
            public string @DefaultEmailOption { get; }

            [nterraform.TerraformProperty(name: "email_message", @out: true, min: 0, max: 1)]
            public string @EmailMessage { get; }

            [nterraform.TerraformProperty(name: "email_message_by_link", @out: true, min: 0, max: 1)]
            public string @EmailMessageByLink { get; }

            [nterraform.TerraformProperty(name: "email_subject", @out: true, min: 0, max: 1)]
            public string @EmailSubject { get; }

            [nterraform.TerraformProperty(name: "email_subject_by_link", @out: true, min: 0, max: 1)]
            public string @EmailSubjectByLink { get; }

            [nterraform.TerraformProperty(name: "sms_message", @out: true, min: 0, max: 1)]
            public string @SmsMessage { get; }
        }

        public aws_cognito_user_pool(string @name,
                                     schema[] @schema,
                                     admin_create_user_config[] @adminCreateUserConfig = null,
                                     string[] @aliasAttributes = null,
                                     string[] @autoVerifiedAttributes = null,
                                     device_configuration[] @deviceConfiguration = null,
                                     email_configuration[] @emailConfiguration = null,
                                     lambda_config[] @lambdaConfig = null,
                                     string @mfaConfiguration = null,
                                     password_policy[] @passwordPolicy = null,
                                     string @smsAuthenticationMessage = null,
                                     sms_configuration[] @smsConfiguration = null,
                                     string @smsVerificationMessage = null,
                                     Dictionary<string,string> @tags = null,
                                     string[] @usernameAttributes = null,
                                     verification_message_template[] @verificationMessageTemplate = null)
        {
            @Name = @name;
            @Schema = @schema;
            @AdminCreateUserConfig = @adminCreateUserConfig;
            @AliasAttributes = @aliasAttributes;
            @AutoVerifiedAttributes = @autoVerifiedAttributes;
            @DeviceConfiguration = @deviceConfiguration;
            @EmailConfiguration = @emailConfiguration;
            @LambdaConfig = @lambdaConfig;
            @MfaConfiguration = @mfaConfiguration;
            @PasswordPolicy = @passwordPolicy;
            @SmsAuthenticationMessage = @smsAuthenticationMessage;
            @SmsConfiguration = @smsConfiguration;
            @SmsVerificationMessage = @smsVerificationMessage;
            @Tags = @tags;
            @UsernameAttributes = @usernameAttributes;
            @VerificationMessageTemplate = @verificationMessageTemplate;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "schema", @out: false, min: 1, max: 50)]
        public schema[] @Schema { get; }

        [nterraform.TerraformProperty(name: "admin_create_user_config", @out: false, min: 0, max: 1)]
        public admin_create_user_config[] @AdminCreateUserConfig { get; }

        [nterraform.TerraformProperty(name: "alias_attributes", @out: false, min: 0, max: 1)]
        public string[] @AliasAttributes { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "auto_verified_attributes", @out: false, min: 0, max: 1)]
        public string[] @AutoVerifiedAttributes { get; }

        [nterraform.TerraformProperty(name: "creation_date", @out: true, min: 0, max: 1)]
        public string @CreationDate { get; }

        [nterraform.TerraformProperty(name: "device_configuration", @out: false, min: 0, max: 1)]
        public device_configuration[] @DeviceConfiguration { get; }

        [nterraform.TerraformProperty(name: "email_configuration", @out: false, min: 0, max: 1)]
        public email_configuration[] @EmailConfiguration { get; }

        [nterraform.TerraformProperty(name: "email_verification_message", @out: true, min: 0, max: 1)]
        public string @EmailVerificationMessage { get; }

        [nterraform.TerraformProperty(name: "email_verification_subject", @out: true, min: 0, max: 1)]
        public string @EmailVerificationSubject { get; }

        [nterraform.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.TerraformProperty(name: "lambda_config", @out: false, min: 0, max: 1)]
        public lambda_config[] @LambdaConfig { get; }

        [nterraform.TerraformProperty(name: "last_modified_date", @out: true, min: 0, max: 1)]
        public string @LastModifiedDate { get; }

        [nterraform.TerraformProperty(name: "mfa_configuration", @out: false, min: 0, max: 1)]
        public string @MfaConfiguration { get; }

        [nterraform.TerraformProperty(name: "password_policy", @out: false, min: 0, max: 1)]
        public password_policy[] @PasswordPolicy { get; }

        [nterraform.TerraformProperty(name: "sms_authentication_message", @out: false, min: 0, max: 1)]
        public string @SmsAuthenticationMessage { get; }

        [nterraform.TerraformProperty(name: "sms_configuration", @out: false, min: 0, max: 1)]
        public sms_configuration[] @SmsConfiguration { get; }

        [nterraform.TerraformProperty(name: "sms_verification_message", @out: false, min: 0, max: 1)]
        public string @SmsVerificationMessage { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "username_attributes", @out: false, min: 0, max: 1)]
        public string[] @UsernameAttributes { get; }

        [nterraform.TerraformProperty(name: "verification_message_template", @out: false, min: 0, max: 1)]
        public verification_message_template[] @VerificationMessageTemplate { get; }
    }

}

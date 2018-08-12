using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_scheduler_job")]
    public sealed class azurerm_scheduler_job : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "error_action_web")]
        public sealed class error_action_web : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "authentication_basic")]
            public sealed class authentication_basic : nterraform.Core.structure
            {
                public authentication_basic(string @password,
                                            string @username)
                {
                    @Password = @password;
                    @Username = @username;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
                public string @Password { get; }

                [nterraform.Core.TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
                public string @Username { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "authentication_certificate")]
            public sealed class authentication_certificate : nterraform.Core.structure
            {
                public authentication_certificate(string @password,
                                                  string @pfx)
                {
                    @Password = @password;
                    @Pfx = @pfx;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
                public string @Password { get; }

                [nterraform.Core.TerraformProperty(name: "pfx", @out: false, min: 1, max: 1)]
                public string @Pfx { get; }

                [nterraform.Core.TerraformProperty(name: "expiration", @out: true, min: 0, max: 1)]
                public FSharpOption<string> @Expiration { get; }

                [nterraform.Core.TerraformProperty(name: "subject_name", @out: true, min: 0, max: 1)]
                public FSharpOption<string> @SubjectName { get; }

                [nterraform.Core.TerraformProperty(name: "thumbprint", @out: true, min: 0, max: 1)]
                public FSharpOption<string> @Thumbprint { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "authentication_active_directory")]
            public sealed class authentication_active_directory : nterraform.Core.structure
            {
                public authentication_active_directory(string @clientId,
                                                       string @secret,
                                                       string @tenantId)
                {
                    @ClientId = @clientId;
                    @Secret = @secret;
                    @TenantId = @tenantId;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "client_id", @out: false, min: 1, max: 1)]
                public string @ClientId { get; }

                [nterraform.Core.TerraformProperty(name: "secret", @out: false, min: 1, max: 1)]
                public string @Secret { get; }

                [nterraform.Core.TerraformProperty(name: "tenant_id", @out: false, min: 1, max: 1)]
                public string @TenantId { get; }

                [nterraform.Core.TerraformProperty(name: "audience", @out: true, min: 0, max: 1)]
                public FSharpOption<string> @Audience { get; }
            }

            public error_action_web(string @method,
                                    string @url,
                                    FSharpOption<FSharpList<authentication_active_directory>> @authenticationActiveDirectory = null,
                                    FSharpOption<FSharpList<authentication_basic>> @authenticationBasic = null,
                                    FSharpOption<FSharpList<authentication_certificate>> @authenticationCertificate = null,
                                    FSharpOption<string> @body = null,
                                    FSharpOption<FSharpMap<string,string>> @headers = null)
            {
                @Method = @method;
                @Url = @url;
                @AuthenticationActiveDirectory = @authenticationActiveDirectory ?? FSharpList<authentication_active_directory>.Empty;
                @AuthenticationBasic = @authenticationBasic ?? FSharpList<authentication_basic>.Empty;
                @AuthenticationCertificate = @authenticationCertificate ?? FSharpList<authentication_certificate>.Empty;
                @Body = @body;
                @Headers = @headers ?? MapModule.Empty<string,string>();
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "method", @out: false, min: 1, max: 1)]
            public string @Method { get; }

            [nterraform.Core.TerraformProperty(name: "url", @out: false, min: 1, max: 1)]
            public string @Url { get; }

            [nterraform.Core.TerraformProperty(name: "authentication_active_directory", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<authentication_active_directory>> @AuthenticationActiveDirectory { get; }

            [nterraform.Core.TerraformProperty(name: "authentication_basic", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<authentication_basic>> @AuthenticationBasic { get; }

            [nterraform.Core.TerraformProperty(name: "authentication_certificate", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<authentication_certificate>> @AuthenticationCertificate { get; }

            [nterraform.Core.TerraformProperty(name: "body", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Body { get; }

            [nterraform.Core.TerraformProperty(name: "headers", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpMap<string,string>> @Headers { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "recurrence")]
        public sealed class recurrence : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "monthly_occurrences")]
            public sealed class monthly_occurrences : nterraform.Core.structure
            {
                public monthly_occurrences(string @day,
                                           int @occurrence)
                {
                    @Day = @day;
                    @Occurrence = @occurrence;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "day", @out: false, min: 1, max: 1)]
                public string @Day { get; }

                [nterraform.Core.TerraformProperty(name: "occurrence", @out: false, min: 1, max: 1)]
                public int @Occurrence { get; }
            }

            public recurrence(string @frequency,
                              FSharpList<monthly_occurrences> @monthlyOccurrences,
                              FSharpOption<int> @count = null,
                              FSharpOption<FSharpList<int>> @hours = null,
                              FSharpOption<int> @interval = null,
                              FSharpOption<FSharpList<int>> @minutes = null,
                              FSharpOption<FSharpList<int>> @monthDays = null,
                              FSharpOption<FSharpList<string>> @weekDays = null)
            {
                @Frequency = @frequency;
                @MonthlyOccurrences = @monthlyOccurrences;
                @Count = @count;
                @Hours = @hours ?? FSharpList<int>.Empty;
                @Interval = @interval;
                @Minutes = @minutes ?? FSharpList<int>.Empty;
                @MonthDays = @monthDays ?? FSharpList<int>.Empty;
                @WeekDays = @weekDays ?? FSharpList<string>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "frequency", @out: false, min: 1, max: 1)]
            public string @Frequency { get; }

            [nterraform.Core.TerraformProperty(name: "monthly_occurrences", @out: false, min: 1, max: 0)]
            public FSharpList<monthly_occurrences> @MonthlyOccurrences { get; }

            [nterraform.Core.TerraformProperty(name: "count", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @Count { get; }

            [nterraform.Core.TerraformProperty(name: "end_time", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @EndTime { get; }

            [nterraform.Core.TerraformProperty(name: "hours", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<int>> @Hours { get; }

            [nterraform.Core.TerraformProperty(name: "interval", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @Interval { get; }

            [nterraform.Core.TerraformProperty(name: "minutes", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<int>> @Minutes { get; }

            [nterraform.Core.TerraformProperty(name: "month_days", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<int>> @MonthDays { get; }

            [nterraform.Core.TerraformProperty(name: "week_days", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @WeekDays { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "action_web")]
        public sealed class action_web : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "authentication_active_directory")]
            public sealed class authentication_active_directory : nterraform.Core.structure
            {
                public authentication_active_directory(string @clientId,
                                                       string @secret,
                                                       string @tenantId)
                {
                    @ClientId = @clientId;
                    @Secret = @secret;
                    @TenantId = @tenantId;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "client_id", @out: false, min: 1, max: 1)]
                public string @ClientId { get; }

                [nterraform.Core.TerraformProperty(name: "secret", @out: false, min: 1, max: 1)]
                public string @Secret { get; }

                [nterraform.Core.TerraformProperty(name: "tenant_id", @out: false, min: 1, max: 1)]
                public string @TenantId { get; }

                [nterraform.Core.TerraformProperty(name: "audience", @out: true, min: 0, max: 1)]
                public FSharpOption<string> @Audience { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "authentication_basic")]
            public sealed class authentication_basic : nterraform.Core.structure
            {
                public authentication_basic(string @password,
                                            string @username)
                {
                    @Password = @password;
                    @Username = @username;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
                public string @Password { get; }

                [nterraform.Core.TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
                public string @Username { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "authentication_certificate")]
            public sealed class authentication_certificate : nterraform.Core.structure
            {
                public authentication_certificate(string @password,
                                                  string @pfx)
                {
                    @Password = @password;
                    @Pfx = @pfx;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
                public string @Password { get; }

                [nterraform.Core.TerraformProperty(name: "pfx", @out: false, min: 1, max: 1)]
                public string @Pfx { get; }

                [nterraform.Core.TerraformProperty(name: "expiration", @out: true, min: 0, max: 1)]
                public FSharpOption<string> @Expiration { get; }

                [nterraform.Core.TerraformProperty(name: "subject_name", @out: true, min: 0, max: 1)]
                public FSharpOption<string> @SubjectName { get; }

                [nterraform.Core.TerraformProperty(name: "thumbprint", @out: true, min: 0, max: 1)]
                public FSharpOption<string> @Thumbprint { get; }
            }

            public action_web(string @method,
                              string @url,
                              FSharpOption<FSharpList<authentication_active_directory>> @authenticationActiveDirectory = null,
                              FSharpOption<FSharpList<authentication_basic>> @authenticationBasic = null,
                              FSharpOption<FSharpList<authentication_certificate>> @authenticationCertificate = null,
                              FSharpOption<string> @body = null,
                              FSharpOption<FSharpMap<string,string>> @headers = null)
            {
                @Method = @method;
                @Url = @url;
                @AuthenticationActiveDirectory = @authenticationActiveDirectory ?? FSharpList<authentication_active_directory>.Empty;
                @AuthenticationBasic = @authenticationBasic ?? FSharpList<authentication_basic>.Empty;
                @AuthenticationCertificate = @authenticationCertificate ?? FSharpList<authentication_certificate>.Empty;
                @Body = @body;
                @Headers = @headers ?? MapModule.Empty<string,string>();
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "method", @out: false, min: 1, max: 1)]
            public string @Method { get; }

            [nterraform.Core.TerraformProperty(name: "url", @out: false, min: 1, max: 1)]
            public string @Url { get; }

            [nterraform.Core.TerraformProperty(name: "authentication_active_directory", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<authentication_active_directory>> @AuthenticationActiveDirectory { get; }

            [nterraform.Core.TerraformProperty(name: "authentication_basic", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<authentication_basic>> @AuthenticationBasic { get; }

            [nterraform.Core.TerraformProperty(name: "authentication_certificate", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<authentication_certificate>> @AuthenticationCertificate { get; }

            [nterraform.Core.TerraformProperty(name: "body", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Body { get; }

            [nterraform.Core.TerraformProperty(name: "headers", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpMap<string,string>> @Headers { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "error_action_storage_queue")]
        public sealed class error_action_storage_queue : nterraform.Core.structure
        {
            public error_action_storage_queue(string @message,
                                              string @sasToken,
                                              string @storageAccountName,
                                              string @storageQueueName)
            {
                @Message = @message;
                @SasToken = @sasToken;
                @StorageAccountName = @storageAccountName;
                @StorageQueueName = @storageQueueName;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "message", @out: false, min: 1, max: 1)]
            public string @Message { get; }

            [nterraform.Core.TerraformProperty(name: "sas_token", @out: false, min: 1, max: 1)]
            public string @SasToken { get; }

            [nterraform.Core.TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
            public string @StorageAccountName { get; }

            [nterraform.Core.TerraformProperty(name: "storage_queue_name", @out: false, min: 1, max: 1)]
            public string @StorageQueueName { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "retry")]
        public sealed class retry : nterraform.Core.structure
        {
            public retry(FSharpOption<int> @count = null,
                         FSharpOption<string> @interval = null)
            {
                @Count = @count;
                @Interval = @interval;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "count", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @Count { get; }

            [nterraform.Core.TerraformProperty(name: "interval", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Interval { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "action_storage_queue")]
        public sealed class action_storage_queue : nterraform.Core.structure
        {
            public action_storage_queue(string @message,
                                        string @sasToken,
                                        string @storageAccountName,
                                        string @storageQueueName)
            {
                @Message = @message;
                @SasToken = @sasToken;
                @StorageAccountName = @storageAccountName;
                @StorageQueueName = @storageQueueName;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "message", @out: false, min: 1, max: 1)]
            public string @Message { get; }

            [nterraform.Core.TerraformProperty(name: "sas_token", @out: false, min: 1, max: 1)]
            public string @SasToken { get; }

            [nterraform.Core.TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
            public string @StorageAccountName { get; }

            [nterraform.Core.TerraformProperty(name: "storage_queue_name", @out: false, min: 1, max: 1)]
            public string @StorageQueueName { get; }
        }

        public azurerm_scheduler_job(string @jobCollectionName,
                                     string @name,
                                     FSharpList<recurrence> @recurrence,
                                     string @resourceGroupName,
                                     FSharpOption<FSharpList<action_storage_queue>> @actionStorageQueue = null,
                                     FSharpOption<FSharpList<action_web>> @actionWeb = null,
                                     FSharpOption<FSharpList<error_action_storage_queue>> @errorActionStorageQueue = null,
                                     FSharpOption<FSharpList<error_action_web>> @errorActionWeb = null,
                                     FSharpOption<FSharpList<retry>> @retry = null)
        {
            @JobCollectionName = @jobCollectionName;
            @Name = @name;
            @Recurrence = @recurrence;
            @ResourceGroupName = @resourceGroupName;
            @ActionStorageQueue = @actionStorageQueue ?? FSharpList<action_storage_queue>.Empty;
            @ActionWeb = @actionWeb ?? FSharpList<action_web>.Empty;
            @ErrorActionStorageQueue = @errorActionStorageQueue ?? FSharpList<error_action_storage_queue>.Empty;
            @ErrorActionWeb = @errorActionWeb ?? FSharpList<error_action_web>.Empty;
            @Retry = @retry ?? FSharpList<retry>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "job_collection_name", @out: false, min: 1, max: 1)]
        public string @JobCollectionName { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "recurrence", @out: false, min: 1, max: 1)]
        public FSharpList<recurrence> @Recurrence { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "action_storage_queue", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<action_storage_queue>> @ActionStorageQueue { get; }

        [nterraform.Core.TerraformProperty(name: "action_web", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<action_web>> @ActionWeb { get; }

        [nterraform.Core.TerraformProperty(name: "error_action_storage_queue", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<error_action_storage_queue>> @ErrorActionStorageQueue { get; }

        [nterraform.Core.TerraformProperty(name: "error_action_web", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<error_action_web>> @ErrorActionWeb { get; }

        [nterraform.Core.TerraformProperty(name: "retry", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<retry>> @Retry { get; }

        [nterraform.Core.TerraformProperty(name: "start_time", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @StartTime { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @State { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_scheduler_job")]
    public sealed class azurerm_scheduler_job : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "retry")]
        public sealed class retry : nterraform.structure
        {
            public retry(int? @count = null,
                         string @interval = null)
            {
                @Count = @count;
                @Interval = @interval;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "count", @out: false, min: 0, max: 1)]
            public int? @Count { get; }

            [nterraform.TerraformProperty(name: "interval", @out: false, min: 0, max: 1)]
            public string @Interval { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "recurrence")]
        public sealed class recurrence : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "monthly_occurrences")]
            public sealed class monthly_occurrences : nterraform.structure
            {
                public monthly_occurrences(string @day,
                                           int @occurrence)
                {
                    @Day = @day;
                    @Occurrence = @occurrence;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "day", @out: false, min: 1, max: 1)]
                public string @Day { get; }

                [nterraform.TerraformProperty(name: "occurrence", @out: false, min: 1, max: 1)]
                public int @Occurrence { get; }
            }

            public recurrence(string @frequency,
                              monthly_occurrences[] @monthlyOccurrences,
                              int? @count = null,
                              int[] @hours = null,
                              int? @interval = null,
                              int[] @minutes = null,
                              int[] @monthDays = null,
                              string[] @weekDays = null)
            {
                @Frequency = @frequency;
                @MonthlyOccurrences = @monthlyOccurrences;
                @Count = @count;
                @Hours = @hours;
                @Interval = @interval;
                @Minutes = @minutes;
                @MonthDays = @monthDays;
                @WeekDays = @weekDays;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "frequency", @out: false, min: 1, max: 1)]
            public string @Frequency { get; }

            [nterraform.TerraformProperty(name: "monthly_occurrences", @out: false, min: 1, max: 0)]
            public monthly_occurrences[] @MonthlyOccurrences { get; }

            [nterraform.TerraformProperty(name: "count", @out: false, min: 0, max: 1)]
            public int? @Count { get; }

            [nterraform.TerraformProperty(name: "end_time", @out: true, min: 0, max: 1)]
            public string @EndTime { get; }

            [nterraform.TerraformProperty(name: "hours", @out: false, min: 0, max: 1)]
            public int[] @Hours { get; }

            [nterraform.TerraformProperty(name: "interval", @out: false, min: 0, max: 1)]
            public int? @Interval { get; }

            [nterraform.TerraformProperty(name: "minutes", @out: false, min: 0, max: 1)]
            public int[] @Minutes { get; }

            [nterraform.TerraformProperty(name: "month_days", @out: false, min: 0, max: 1)]
            public int[] @MonthDays { get; }

            [nterraform.TerraformProperty(name: "week_days", @out: false, min: 0, max: 1)]
            public string[] @WeekDays { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "action_storage_queue")]
        public sealed class action_storage_queue : nterraform.structure
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

            [nterraform.TerraformProperty(name: "message", @out: false, min: 1, max: 1)]
            public string @Message { get; }

            [nterraform.TerraformProperty(name: "sas_token", @out: false, min: 1, max: 1)]
            public string @SasToken { get; }

            [nterraform.TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
            public string @StorageAccountName { get; }

            [nterraform.TerraformProperty(name: "storage_queue_name", @out: false, min: 1, max: 1)]
            public string @StorageQueueName { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "action_web")]
        public sealed class action_web : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "authentication_active_directory")]
            public sealed class authentication_active_directory : nterraform.structure
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

                [nterraform.TerraformProperty(name: "client_id", @out: false, min: 1, max: 1)]
                public string @ClientId { get; }

                [nterraform.TerraformProperty(name: "secret", @out: false, min: 1, max: 1)]
                public string @Secret { get; }

                [nterraform.TerraformProperty(name: "tenant_id", @out: false, min: 1, max: 1)]
                public string @TenantId { get; }

                [nterraform.TerraformProperty(name: "audience", @out: true, min: 0, max: 1)]
                public string @Audience { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "authentication_basic")]
            public sealed class authentication_basic : nterraform.structure
            {
                public authentication_basic(string @password,
                                            string @username)
                {
                    @Password = @password;
                    @Username = @username;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
                public string @Password { get; }

                [nterraform.TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
                public string @Username { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "authentication_certificate")]
            public sealed class authentication_certificate : nterraform.structure
            {
                public authentication_certificate(string @password,
                                                  string @pfx)
                {
                    @Password = @password;
                    @Pfx = @pfx;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
                public string @Password { get; }

                [nterraform.TerraformProperty(name: "pfx", @out: false, min: 1, max: 1)]
                public string @Pfx { get; }

                [nterraform.TerraformProperty(name: "expiration", @out: true, min: 0, max: 1)]
                public string @Expiration { get; }

                [nterraform.TerraformProperty(name: "subject_name", @out: true, min: 0, max: 1)]
                public string @SubjectName { get; }

                [nterraform.TerraformProperty(name: "thumbprint", @out: true, min: 0, max: 1)]
                public string @Thumbprint { get; }
            }

            public action_web(string @method,
                              string @url,
                              authentication_active_directory[] @authenticationActiveDirectory = null,
                              authentication_basic[] @authenticationBasic = null,
                              authentication_certificate[] @authenticationCertificate = null,
                              string @body = null,
                              Dictionary<string,string> @headers = null)
            {
                @Method = @method;
                @Url = @url;
                @AuthenticationActiveDirectory = @authenticationActiveDirectory;
                @AuthenticationBasic = @authenticationBasic;
                @AuthenticationCertificate = @authenticationCertificate;
                @Body = @body;
                @Headers = @headers;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "method", @out: false, min: 1, max: 1)]
            public string @Method { get; }

            [nterraform.TerraformProperty(name: "url", @out: false, min: 1, max: 1)]
            public string @Url { get; }

            [nterraform.TerraformProperty(name: "authentication_active_directory", @out: false, min: 0, max: 1)]
            public authentication_active_directory[] @AuthenticationActiveDirectory { get; }

            [nterraform.TerraformProperty(name: "authentication_basic", @out: false, min: 0, max: 1)]
            public authentication_basic[] @AuthenticationBasic { get; }

            [nterraform.TerraformProperty(name: "authentication_certificate", @out: false, min: 0, max: 1)]
            public authentication_certificate[] @AuthenticationCertificate { get; }

            [nterraform.TerraformProperty(name: "body", @out: false, min: 0, max: 1)]
            public string @Body { get; }

            [nterraform.TerraformProperty(name: "headers", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Headers { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "error_action_web")]
        public sealed class error_action_web : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "authentication_certificate")]
            public sealed class authentication_certificate : nterraform.structure
            {
                public authentication_certificate(string @password,
                                                  string @pfx)
                {
                    @Password = @password;
                    @Pfx = @pfx;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
                public string @Password { get; }

                [nterraform.TerraformProperty(name: "pfx", @out: false, min: 1, max: 1)]
                public string @Pfx { get; }

                [nterraform.TerraformProperty(name: "expiration", @out: true, min: 0, max: 1)]
                public string @Expiration { get; }

                [nterraform.TerraformProperty(name: "subject_name", @out: true, min: 0, max: 1)]
                public string @SubjectName { get; }

                [nterraform.TerraformProperty(name: "thumbprint", @out: true, min: 0, max: 1)]
                public string @Thumbprint { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "authentication_active_directory")]
            public sealed class authentication_active_directory : nterraform.structure
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

                [nterraform.TerraformProperty(name: "client_id", @out: false, min: 1, max: 1)]
                public string @ClientId { get; }

                [nterraform.TerraformProperty(name: "secret", @out: false, min: 1, max: 1)]
                public string @Secret { get; }

                [nterraform.TerraformProperty(name: "tenant_id", @out: false, min: 1, max: 1)]
                public string @TenantId { get; }

                [nterraform.TerraformProperty(name: "audience", @out: true, min: 0, max: 1)]
                public string @Audience { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "authentication_basic")]
            public sealed class authentication_basic : nterraform.structure
            {
                public authentication_basic(string @password,
                                            string @username)
                {
                    @Password = @password;
                    @Username = @username;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
                public string @Password { get; }

                [nterraform.TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
                public string @Username { get; }
            }

            public error_action_web(string @method,
                                    string @url,
                                    authentication_active_directory[] @authenticationActiveDirectory = null,
                                    authentication_basic[] @authenticationBasic = null,
                                    authentication_certificate[] @authenticationCertificate = null,
                                    string @body = null,
                                    Dictionary<string,string> @headers = null)
            {
                @Method = @method;
                @Url = @url;
                @AuthenticationActiveDirectory = @authenticationActiveDirectory;
                @AuthenticationBasic = @authenticationBasic;
                @AuthenticationCertificate = @authenticationCertificate;
                @Body = @body;
                @Headers = @headers;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "method", @out: false, min: 1, max: 1)]
            public string @Method { get; }

            [nterraform.TerraformProperty(name: "url", @out: false, min: 1, max: 1)]
            public string @Url { get; }

            [nterraform.TerraformProperty(name: "authentication_active_directory", @out: false, min: 0, max: 1)]
            public authentication_active_directory[] @AuthenticationActiveDirectory { get; }

            [nterraform.TerraformProperty(name: "authentication_basic", @out: false, min: 0, max: 1)]
            public authentication_basic[] @AuthenticationBasic { get; }

            [nterraform.TerraformProperty(name: "authentication_certificate", @out: false, min: 0, max: 1)]
            public authentication_certificate[] @AuthenticationCertificate { get; }

            [nterraform.TerraformProperty(name: "body", @out: false, min: 0, max: 1)]
            public string @Body { get; }

            [nterraform.TerraformProperty(name: "headers", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Headers { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "error_action_storage_queue")]
        public sealed class error_action_storage_queue : nterraform.structure
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

            [nterraform.TerraformProperty(name: "message", @out: false, min: 1, max: 1)]
            public string @Message { get; }

            [nterraform.TerraformProperty(name: "sas_token", @out: false, min: 1, max: 1)]
            public string @SasToken { get; }

            [nterraform.TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
            public string @StorageAccountName { get; }

            [nterraform.TerraformProperty(name: "storage_queue_name", @out: false, min: 1, max: 1)]
            public string @StorageQueueName { get; }
        }

        public azurerm_scheduler_job(string @jobCollectionName,
                                     string @name,
                                     recurrence[] @recurrence,
                                     string @resourceGroupName,
                                     action_storage_queue[] @actionStorageQueue = null,
                                     action_web[] @actionWeb = null,
                                     error_action_storage_queue[] @errorActionStorageQueue = null,
                                     error_action_web[] @errorActionWeb = null,
                                     retry[] @retry = null)
        {
            @JobCollectionName = @jobCollectionName;
            @Name = @name;
            @Recurrence = @recurrence;
            @ResourceGroupName = @resourceGroupName;
            @ActionStorageQueue = @actionStorageQueue;
            @ActionWeb = @actionWeb;
            @ErrorActionStorageQueue = @errorActionStorageQueue;
            @ErrorActionWeb = @errorActionWeb;
            @Retry = @retry;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "job_collection_name", @out: false, min: 1, max: 1)]
        public string @JobCollectionName { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "recurrence", @out: false, min: 1, max: 1)]
        public recurrence[] @Recurrence { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "action_storage_queue", @out: false, min: 0, max: 1)]
        public action_storage_queue[] @ActionStorageQueue { get; }

        [nterraform.TerraformProperty(name: "action_web", @out: false, min: 0, max: 1)]
        public action_web[] @ActionWeb { get; }

        [nterraform.TerraformProperty(name: "error_action_storage_queue", @out: false, min: 0, max: 1)]
        public error_action_storage_queue[] @ErrorActionStorageQueue { get; }

        [nterraform.TerraformProperty(name: "error_action_web", @out: false, min: 0, max: 1)]
        public error_action_web[] @ErrorActionWeb { get; }

        [nterraform.TerraformProperty(name: "retry", @out: false, min: 0, max: 1)]
        public retry[] @Retry { get; }

        [nterraform.TerraformProperty(name: "start_time", @out: true, min: 0, max: 1)]
        public string @StartTime { get; }

        [nterraform.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }
    }

}

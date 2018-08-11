using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_scheduler_job")]
    public sealed class azurerm_scheduler_job : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "error_action_web")]
        public sealed class error_action_web
        {
            [TerraformStructure(category: "", typeName: "authentication_basic")]
            public sealed class authentication_basic
            {
                public authentication_basic(string @password,
                                            string @username)
                {
                    @Password = @password;
                    @Username = @username;
                }

                [TerraformProperty(name: "password", @out: false, nested: false, min: 1, max: 1)]
                public string @Password { get; }

                [TerraformProperty(name: "username", @out: false, nested: false, min: 1, max: 1)]
                public string @Username { get; }
            }

            [TerraformStructure(category: "", typeName: "authentication_certificate")]
            public sealed class authentication_certificate
            {
                public authentication_certificate(string @password,
                                                  string @pfx)
                {
                    @Password = @password;
                    @Pfx = @pfx;
                }

                [TerraformProperty(name: "password", @out: false, nested: false, min: 1, max: 1)]
                public string @Password { get; }

                [TerraformProperty(name: "pfx", @out: false, nested: false, min: 1, max: 1)]
                public string @Pfx { get; }

                [TerraformProperty(name: "expiration", @out: true, nested: false, min: 0, max: 1)]
                public string @Expiration { get; }

                [TerraformProperty(name: "subject_name", @out: true, nested: false, min: 0, max: 1)]
                public string @SubjectName { get; }

                [TerraformProperty(name: "thumbprint", @out: true, nested: false, min: 0, max: 1)]
                public string @Thumbprint { get; }
            }

            [TerraformStructure(category: "", typeName: "authentication_active_directory")]
            public sealed class authentication_active_directory
            {
                public authentication_active_directory(string @clientId,
                                                       string @secret,
                                                       string @tenantId)
                {
                    @ClientId = @clientId;
                    @Secret = @secret;
                    @TenantId = @tenantId;
                }

                [TerraformProperty(name: "client_id", @out: false, nested: false, min: 1, max: 1)]
                public string @ClientId { get; }

                [TerraformProperty(name: "secret", @out: false, nested: false, min: 1, max: 1)]
                public string @Secret { get; }

                [TerraformProperty(name: "tenant_id", @out: false, nested: false, min: 1, max: 1)]
                public string @TenantId { get; }

                [TerraformProperty(name: "audience", @out: true, nested: false, min: 0, max: 1)]
                public string @Audience { get; }
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
            }

            [TerraformProperty(name: "method", @out: false, nested: false, min: 1, max: 1)]
            public string @Method { get; }

            [TerraformProperty(name: "url", @out: false, nested: false, min: 1, max: 1)]
            public string @Url { get; }

            [TerraformProperty(name: "authentication_active_directory", @out: false, nested: false, min: 0, max: 1)]
            public authentication_active_directory[] @AuthenticationActiveDirectory { get; }

            [TerraformProperty(name: "authentication_basic", @out: false, nested: false, min: 0, max: 1)]
            public authentication_basic[] @AuthenticationBasic { get; }

            [TerraformProperty(name: "authentication_certificate", @out: false, nested: false, min: 0, max: 1)]
            public authentication_certificate[] @AuthenticationCertificate { get; }

            [TerraformProperty(name: "body", @out: false, nested: false, min: 0, max: 1)]
            public string @Body { get; }

            [TerraformProperty(name: "headers", @out: false, nested: false, min: 0, max: 1)]
            public Dictionary<string,string> @Headers { get; }
        }

        [TerraformStructure(category: "", typeName: "error_action_storage_queue")]
        public sealed class error_action_storage_queue
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
            }

            [TerraformProperty(name: "message", @out: false, nested: false, min: 1, max: 1)]
            public string @Message { get; }

            [TerraformProperty(name: "sas_token", @out: false, nested: false, min: 1, max: 1)]
            public string @SasToken { get; }

            [TerraformProperty(name: "storage_account_name", @out: false, nested: false, min: 1, max: 1)]
            public string @StorageAccountName { get; }

            [TerraformProperty(name: "storage_queue_name", @out: false, nested: false, min: 1, max: 1)]
            public string @StorageQueueName { get; }
        }

        [TerraformStructure(category: "", typeName: "retry")]
        public sealed class retry
        {
            public retry(int? @count = null,
                         string @interval = null)
            {
                @Count = @count;
                @Interval = @interval;
            }

            [TerraformProperty(name: "count", @out: false, nested: false, min: 0, max: 1)]
            public int? @Count { get; }

            [TerraformProperty(name: "interval", @out: false, nested: false, min: 0, max: 1)]
            public string @Interval { get; }
        }

        [TerraformStructure(category: "", typeName: "recurrence")]
        public sealed class recurrence
        {
            [TerraformStructure(category: "", typeName: "monthly_occurrences")]
            public sealed class monthly_occurrences
            {
                public monthly_occurrences(string @day,
                                           int @occurrence)
                {
                    @Day = @day;
                    @Occurrence = @occurrence;
                }

                [TerraformProperty(name: "day", @out: false, nested: false, min: 1, max: 1)]
                public string @Day { get; }

                [TerraformProperty(name: "occurrence", @out: false, nested: false, min: 1, max: 1)]
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
            }

            [TerraformProperty(name: "frequency", @out: false, nested: false, min: 1, max: 1)]
            public string @Frequency { get; }

            [TerraformProperty(name: "monthly_occurrences", @out: false, nested: false, min: 1, max: 0)]
            public monthly_occurrences[] @MonthlyOccurrences { get; }

            [TerraformProperty(name: "count", @out: false, nested: false, min: 0, max: 1)]
            public int? @Count { get; }

            [TerraformProperty(name: "end_time", @out: true, nested: false, min: 0, max: 1)]
            public string @EndTime { get; }

            [TerraformProperty(name: "hours", @out: false, nested: false, min: 0, max: 1)]
            public int[] @Hours { get; }

            [TerraformProperty(name: "interval", @out: false, nested: false, min: 0, max: 1)]
            public int? @Interval { get; }

            [TerraformProperty(name: "minutes", @out: false, nested: false, min: 0, max: 1)]
            public int[] @Minutes { get; }

            [TerraformProperty(name: "month_days", @out: false, nested: false, min: 0, max: 1)]
            public int[] @MonthDays { get; }

            [TerraformProperty(name: "week_days", @out: false, nested: false, min: 0, max: 1)]
            public string[] @WeekDays { get; }
        }

        [TerraformStructure(category: "", typeName: "action_web")]
        public sealed class action_web
        {
            [TerraformStructure(category: "", typeName: "authentication_basic")]
            public sealed class authentication_basic
            {
                public authentication_basic(string @password,
                                            string @username)
                {
                    @Password = @password;
                    @Username = @username;
                }

                [TerraformProperty(name: "password", @out: false, nested: false, min: 1, max: 1)]
                public string @Password { get; }

                [TerraformProperty(name: "username", @out: false, nested: false, min: 1, max: 1)]
                public string @Username { get; }
            }

            [TerraformStructure(category: "", typeName: "authentication_certificate")]
            public sealed class authentication_certificate
            {
                public authentication_certificate(string @password,
                                                  string @pfx)
                {
                    @Password = @password;
                    @Pfx = @pfx;
                }

                [TerraformProperty(name: "password", @out: false, nested: false, min: 1, max: 1)]
                public string @Password { get; }

                [TerraformProperty(name: "pfx", @out: false, nested: false, min: 1, max: 1)]
                public string @Pfx { get; }

                [TerraformProperty(name: "expiration", @out: true, nested: false, min: 0, max: 1)]
                public string @Expiration { get; }

                [TerraformProperty(name: "subject_name", @out: true, nested: false, min: 0, max: 1)]
                public string @SubjectName { get; }

                [TerraformProperty(name: "thumbprint", @out: true, nested: false, min: 0, max: 1)]
                public string @Thumbprint { get; }
            }

            [TerraformStructure(category: "", typeName: "authentication_active_directory")]
            public sealed class authentication_active_directory
            {
                public authentication_active_directory(string @clientId,
                                                       string @secret,
                                                       string @tenantId)
                {
                    @ClientId = @clientId;
                    @Secret = @secret;
                    @TenantId = @tenantId;
                }

                [TerraformProperty(name: "client_id", @out: false, nested: false, min: 1, max: 1)]
                public string @ClientId { get; }

                [TerraformProperty(name: "secret", @out: false, nested: false, min: 1, max: 1)]
                public string @Secret { get; }

                [TerraformProperty(name: "tenant_id", @out: false, nested: false, min: 1, max: 1)]
                public string @TenantId { get; }

                [TerraformProperty(name: "audience", @out: true, nested: false, min: 0, max: 1)]
                public string @Audience { get; }
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
            }

            [TerraformProperty(name: "method", @out: false, nested: false, min: 1, max: 1)]
            public string @Method { get; }

            [TerraformProperty(name: "url", @out: false, nested: false, min: 1, max: 1)]
            public string @Url { get; }

            [TerraformProperty(name: "authentication_active_directory", @out: false, nested: false, min: 0, max: 1)]
            public authentication_active_directory[] @AuthenticationActiveDirectory { get; }

            [TerraformProperty(name: "authentication_basic", @out: false, nested: false, min: 0, max: 1)]
            public authentication_basic[] @AuthenticationBasic { get; }

            [TerraformProperty(name: "authentication_certificate", @out: false, nested: false, min: 0, max: 1)]
            public authentication_certificate[] @AuthenticationCertificate { get; }

            [TerraformProperty(name: "body", @out: false, nested: false, min: 0, max: 1)]
            public string @Body { get; }

            [TerraformProperty(name: "headers", @out: false, nested: false, min: 0, max: 1)]
            public Dictionary<string,string> @Headers { get; }
        }

        [TerraformStructure(category: "", typeName: "action_storage_queue")]
        public sealed class action_storage_queue
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
            }

            [TerraformProperty(name: "message", @out: false, nested: false, min: 1, max: 1)]
            public string @Message { get; }

            [TerraformProperty(name: "sas_token", @out: false, nested: false, min: 1, max: 1)]
            public string @SasToken { get; }

            [TerraformProperty(name: "storage_account_name", @out: false, nested: false, min: 1, max: 1)]
            public string @StorageAccountName { get; }

            [TerraformProperty(name: "storage_queue_name", @out: false, nested: false, min: 1, max: 1)]
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
        }

        [TerraformProperty(name: "job_collection_name", @out: false, nested: true, min: 1, max: 1)]
        public string @JobCollectionName { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "recurrence", @out: false, nested: true, min: 1, max: 1)]
        public recurrence[] @Recurrence { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "action_storage_queue", @out: false, nested: true, min: 0, max: 1)]
        public action_storage_queue[] @ActionStorageQueue { get; }

        [TerraformProperty(name: "action_web", @out: false, nested: true, min: 0, max: 1)]
        public action_web[] @ActionWeb { get; }

        [TerraformProperty(name: "error_action_storage_queue", @out: false, nested: true, min: 0, max: 1)]
        public error_action_storage_queue[] @ErrorActionStorageQueue { get; }

        [TerraformProperty(name: "error_action_web", @out: false, nested: true, min: 0, max: 1)]
        public error_action_web[] @ErrorActionWeb { get; }

        [TerraformProperty(name: "retry", @out: false, nested: true, min: 0, max: 1)]
        public retry[] @Retry { get; }

        [TerraformProperty(name: "start_time", @out: true, nested: true, min: 0, max: 1)]
        public string @StartTime { get; }

        [TerraformProperty(name: "state", @out: true, nested: true, min: 0, max: 1)]
        public string @State { get; }
    }

}

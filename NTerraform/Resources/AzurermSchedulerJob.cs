using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_scheduler_job : NTerraform.resource
    {
        public sealed class retry
        {
            public retry(int? @count = null,
                         string @interval = null)
            {
                @Count = @count;
                @Interval = @interval;
            }

            public int? @Count { get; }
            public string @Interval { get; }
        }

        public sealed class recurrence
        {
            public sealed class monthly_occurrences
            {
                public monthly_occurrences(string @day,
                                           int @occurrence)
                {
                    @Day = @day;
                    @Occurrence = @occurrence;
                }

                public string @Day { get; }
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

            public string @Frequency { get; }
            public monthly_occurrences[] @MonthlyOccurrences { get; }
            public int? @Count { get; }
            public string @EndTime { get; }
            public int[] @Hours { get; }
            public int? @Interval { get; }
            public int[] @Minutes { get; }
            public int[] @MonthDays { get; }
            public string[] @WeekDays { get; }
        }

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

            public string @Message { get; }
            public string @SasToken { get; }
            public string @StorageAccountName { get; }
            public string @StorageQueueName { get; }
        }

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

            public string @Message { get; }
            public string @SasToken { get; }
            public string @StorageAccountName { get; }
            public string @StorageQueueName { get; }
        }

        public sealed class action_web
        {
            public sealed class authentication_basic
            {
                public authentication_basic(string @password,
                                            string @username)
                {
                    @Password = @password;
                    @Username = @username;
                }

                public string @Password { get; }
                public string @Username { get; }
            }

            public sealed class authentication_certificate
            {
                public authentication_certificate(string @password,
                                                  string @pfx)
                {
                    @Password = @password;
                    @Pfx = @pfx;
                }

                public string @Password { get; }
                public string @Pfx { get; }
                public string @Expiration { get; }
                public string @SubjectName { get; }
                public string @Thumbprint { get; }
            }

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

                public string @ClientId { get; }
                public string @Secret { get; }
                public string @TenantId { get; }
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

            public string @Method { get; }
            public string @Url { get; }
            public authentication_active_directory[] @AuthenticationActiveDirectory { get; }
            public authentication_basic[] @AuthenticationBasic { get; }
            public authentication_certificate[] @AuthenticationCertificate { get; }
            public string @Body { get; }
            public Dictionary<string,string> @Headers { get; }
        }

        public sealed class error_action_web
        {
            public sealed class authentication_basic
            {
                public authentication_basic(string @password,
                                            string @username)
                {
                    @Password = @password;
                    @Username = @username;
                }

                public string @Password { get; }
                public string @Username { get; }
            }

            public sealed class authentication_certificate
            {
                public authentication_certificate(string @password,
                                                  string @pfx)
                {
                    @Password = @password;
                    @Pfx = @pfx;
                }

                public string @Password { get; }
                public string @Pfx { get; }
                public string @Expiration { get; }
                public string @SubjectName { get; }
                public string @Thumbprint { get; }
            }

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

                public string @ClientId { get; }
                public string @Secret { get; }
                public string @TenantId { get; }
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

            public string @Method { get; }
            public string @Url { get; }
            public authentication_active_directory[] @AuthenticationActiveDirectory { get; }
            public authentication_basic[] @AuthenticationBasic { get; }
            public authentication_certificate[] @AuthenticationCertificate { get; }
            public string @Body { get; }
            public Dictionary<string,string> @Headers { get; }
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

        public string @JobCollectionName { get; }
        public string @Name { get; }
        public recurrence[] @Recurrence { get; }
        public string @ResourceGroupName { get; }
        public action_storage_queue[] @ActionStorageQueue { get; }
        public action_web[] @ActionWeb { get; }
        public error_action_storage_queue[] @ErrorActionStorageQueue { get; }
        public error_action_web[] @ErrorActionWeb { get; }
        public retry[] @Retry { get; }
        public string @StartTime { get; }
        public string @State { get; }
    }

}

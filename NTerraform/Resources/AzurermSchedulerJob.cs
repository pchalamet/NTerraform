using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_scheduler_job : NTerraform.resource
    {
        public class action_web
        {
            public class authentication_active_directory
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

            public class authentication_basic
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

            public class authentication_certificate
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

            public action_web(string @method,
                              string @url,
                              List<authentication_active_directory> @authenticationActiveDirectory = null,
                              List<authentication_basic> @authenticationBasic = null,
                              List<authentication_certificate> @authenticationCertificate = null,
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
            public List<authentication_active_directory> @AuthenticationActiveDirectory { get; }
            public List<authentication_basic> @AuthenticationBasic { get; }
            public List<authentication_certificate> @AuthenticationCertificate { get; }
            public string @Body { get; }
            public Dictionary<string,string> @Headers { get; }
        }

        public class error_action_storage_queue
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

        public class recurrence
        {
            public class monthly_occurrences
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
                              HashSet<monthly_occurrences> @monthlyOccurrences,
                              int? @count = null,
                              HashSet<int> @hours = null,
                              int? @interval = null,
                              HashSet<int> @minutes = null,
                              HashSet<int> @monthDays = null,
                              HashSet<string> @weekDays = null)
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
            public HashSet<monthly_occurrences> @MonthlyOccurrences { get; }
            public int? @Count { get; }
            public string @EndTime { get; }
            public HashSet<int> @Hours { get; }
            public int? @Interval { get; }
            public HashSet<int> @Minutes { get; }
            public HashSet<int> @MonthDays { get; }
            public HashSet<string> @WeekDays { get; }
        }

        public class action_storage_queue
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

        public class error_action_web
        {
            public class authentication_basic
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

            public class authentication_certificate
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

            public class authentication_active_directory
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
                                    List<authentication_active_directory> @authenticationActiveDirectory = null,
                                    List<authentication_basic> @authenticationBasic = null,
                                    List<authentication_certificate> @authenticationCertificate = null,
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
            public List<authentication_active_directory> @AuthenticationActiveDirectory { get; }
            public List<authentication_basic> @AuthenticationBasic { get; }
            public List<authentication_certificate> @AuthenticationCertificate { get; }
            public string @Body { get; }
            public Dictionary<string,string> @Headers { get; }
        }

        public class retry
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

        public azurerm_scheduler_job(string @jobCollectionName,
                                     string @name,
                                     List<recurrence> @recurrence,
                                     string @resourceGroupName,
                                     List<action_storage_queue> @actionStorageQueue = null,
                                     List<action_web> @actionWeb = null,
                                     List<error_action_storage_queue> @errorActionStorageQueue = null,
                                     List<error_action_web> @errorActionWeb = null,
                                     List<retry> @retry = null)
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
        public List<recurrence> @Recurrence { get; }
        public string @ResourceGroupName { get; }
        public List<action_storage_queue> @ActionStorageQueue { get; }
        public List<action_web> @ActionWeb { get; }
        public List<error_action_storage_queue> @ErrorActionStorageQueue { get; }
        public List<error_action_web> @ErrorActionWeb { get; }
        public List<retry> @Retry { get; }
        public string @StartTime { get; }
        public string @State { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_lambda_permission")]
    public sealed class aws_lambda_permission : nterraform.resource
    {
        public aws_lambda_permission(string @action,
                                     string @functionName,
                                     string @principal,
                                     string @eventSourceToken = null,
                                     string @qualifier = null,
                                     string @sourceAccount = null,
                                     string @sourceArn = null,
                                     string @statementIdPrefix = null)
        {
            @Action = @action;
            @FunctionName = @functionName;
            @Principal = @principal;
            @EventSourceToken = @eventSourceToken;
            @Qualifier = @qualifier;
            @SourceAccount = @sourceAccount;
            @SourceArn = @sourceArn;
            @StatementIdPrefix = @statementIdPrefix;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "action", @out: false, min: 1, max: 1)]
        public string @Action { get; }

        [nterraform.TerraformProperty(name: "function_name", @out: false, min: 1, max: 1)]
        public string @FunctionName { get; }

        [nterraform.TerraformProperty(name: "principal", @out: false, min: 1, max: 1)]
        public string @Principal { get; }

        [nterraform.TerraformProperty(name: "event_source_token", @out: false, min: 0, max: 1)]
        public string @EventSourceToken { get; }

        [nterraform.TerraformProperty(name: "qualifier", @out: false, min: 0, max: 1)]
        public string @Qualifier { get; }

        [nterraform.TerraformProperty(name: "source_account", @out: false, min: 0, max: 1)]
        public string @SourceAccount { get; }

        [nterraform.TerraformProperty(name: "source_arn", @out: false, min: 0, max: 1)]
        public string @SourceArn { get; }

        [nterraform.TerraformProperty(name: "statement_id", @out: true, min: 0, max: 1)]
        public string @StatementId { get; }

        [nterraform.TerraformProperty(name: "statement_id_prefix", @out: false, min: 0, max: 1)]
        public string @StatementIdPrefix { get; }
    }

}

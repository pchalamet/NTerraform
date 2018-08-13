using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_lambda_invocation")]
    public sealed class aws_lambda_invocation : nterraform.data
    {
        public aws_lambda_invocation(string @functionName,
                                     string @input,
                                     string @qualifier = null)
        {
            @FunctionName = @functionName;
            @Input = @input;
            @Qualifier = @qualifier;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "function_name", @out: false, min: 1, max: 1)]
        public string @FunctionName { get; }

        [nterraform.TerraformProperty(name: "input", @out: false, min: 1, max: 1)]
        public string @Input { get; }

        [nterraform.TerraformProperty(name: "qualifier", @out: false, min: 0, max: 1)]
        public string @Qualifier { get; }

        [nterraform.TerraformProperty(name: "result", @out: true, min: 0, max: 1)]
        public string @Result { get; }

        [nterraform.TerraformProperty(name: "result_map", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @ResultMap { get; }
    }

}

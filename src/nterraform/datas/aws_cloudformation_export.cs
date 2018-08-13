using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_cloudformation_export")]
    public sealed class aws_cloudformation_export : nterraform.data
    {
        public aws_cloudformation_export(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "exporting_stack_id", @out: true, min: 0, max: 1)]
        public string @ExportingStackId { get; }

        [nterraform.TerraformProperty(name: "value", @out: true, min: 0, max: 1)]
        public string @Value { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_dynamodb_table_item")]
    public sealed class aws_dynamodb_table_item : nterraform.Core.resource
    {
        public aws_dynamodb_table_item(string @hashKey,
                                       string @item,
                                       string @tableName,
                                       string @rangeKey = null)
        {
            @HashKey = @hashKey;
            @Item = @item;
            @TableName = @tableName;
            @RangeKey = @rangeKey;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "hash_key", @out: false, min: 1, max: 1)]
        public string @HashKey { get; }

        [nterraform.Core.TerraformProperty(name: "item", @out: false, min: 1, max: 1)]
        public string @Item { get; }

        [nterraform.Core.TerraformProperty(name: "table_name", @out: false, min: 1, max: 1)]
        public string @TableName { get; }

        [nterraform.Core.TerraformProperty(name: "range_key", @out: false, min: 0, max: 1)]
        public string @RangeKey { get; }
    }

}

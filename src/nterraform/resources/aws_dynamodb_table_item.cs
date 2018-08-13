using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_dynamodb_table_item")]
    public sealed class aws_dynamodb_table_item : nterraform.resource
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

        [nterraform.TerraformProperty(name: "hash_key", @out: false, min: 1, max: 1)]
        public string @HashKey { get; }

        [nterraform.TerraformProperty(name: "item", @out: false, min: 1, max: 1)]
        public string @Item { get; }

        [nterraform.TerraformProperty(name: "table_name", @out: false, min: 1, max: 1)]
        public string @TableName { get; }

        [nterraform.TerraformProperty(name: "range_key", @out: false, min: 0, max: 1)]
        public string @RangeKey { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_athena_named_query")]
    public sealed class aws_athena_named_query : nterraform.Core.resource
    {
        public aws_athena_named_query(string @database,
                                      string @name,
                                      string @query,
                                      string @description = null)
        {
            @Database = @database;
            @Name = @name;
            @Query = @query;
            @Description = @description;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "database", @out: false, min: 1, max: 1)]
        public string @Database { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "query", @out: false, min: 1, max: 1)]
        public string @Query { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }
    }

}

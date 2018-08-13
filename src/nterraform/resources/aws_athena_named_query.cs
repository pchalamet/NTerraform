using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_athena_named_query")]
    public sealed class aws_athena_named_query : nterraform.resource
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

        [nterraform.TerraformProperty(name: "database", @out: false, min: 1, max: 1)]
        public string @Database { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "query", @out: false, min: 1, max: 1)]
        public string @Query { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }
    }

}

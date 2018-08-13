using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_glue_catalog_database")]
    public sealed class aws_glue_catalog_database : nterraform.Core.resource
    {
        public aws_glue_catalog_database(string @name,
                                         string @description = null,
                                         string @locationUri = null,
                                         Dictionary<string,string> @parameters = null)
        {
            @Name = @name;
            @Description = @description;
            @LocationUri = @locationUri;
            @Parameters = @parameters;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "catalog_id", @out: true, min: 0, max: 1)]
        public string @CatalogId { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "location_uri", @out: false, min: 0, max: 1)]
        public string @LocationUri { get; }

        [nterraform.Core.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Parameters { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_pricing_product")]
    public sealed class aws_pricing_product : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "filters")]
        public sealed class filters : nterraform.structure
        {
            public filters(string @field,
                           string @value)
            {
                @Field = @field;
                @Value = @value;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "field", @out: false, min: 1, max: 1)]
            public string @Field { get; }

            [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }
        }

        public aws_pricing_product(filters[] @filters,
                                   string @serviceCode)
        {
            @Filters = @filters;
            @ServiceCode = @serviceCode;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "filters", @out: false, min: 1, max: 0)]
        public filters[] @Filters { get; }

        [nterraform.TerraformProperty(name: "service_code", @out: false, min: 1, max: 1)]
        public string @ServiceCode { get; }

        [nterraform.TerraformProperty(name: "result", @out: true, min: 0, max: 1)]
        public string @Result { get; }
    }

}

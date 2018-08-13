using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_pricing_product")]
    public sealed class aws_pricing_product : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "filters")]
        public sealed class filters : nterraform.Core.structure
        {
            public filters(string @field,
                           string @value)
            {
                @Field = @field;
                @Value = @value;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "field", @out: false, min: 1, max: 1)]
            public string @Field { get; }

            [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }
        }

        public aws_pricing_product(filters[] @filters,
                                   string @serviceCode)
        {
            @Filters = @filters;
            @ServiceCode = @serviceCode;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "filters", @out: false, min: 1, max: 0)]
        public filters[] @Filters { get; }

        [nterraform.Core.TerraformProperty(name: "service_code", @out: false, min: 1, max: 1)]
        public string @ServiceCode { get; }

        [nterraform.Core.TerraformProperty(name: "result", @out: true, min: 0, max: 1)]
        public string @Result { get; }
    }

}

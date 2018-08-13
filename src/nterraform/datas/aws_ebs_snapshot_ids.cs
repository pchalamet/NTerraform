using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_ebs_snapshot_ids")]
    public sealed class aws_ebs_snapshot_ids : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "filter")]
        public sealed class filter : nterraform.Core.structure
        {
            public filter(string @name,
                          string[] @values)
            {
                @Name = @name;
                @Values = @values;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        public aws_ebs_snapshot_ids(filter[] @filter = null,
                                    string[] @owners = null,
                                    string[] @restorableByUserIds = null)
        {
            @Filter = @filter;
            @Owners = @owners;
            @RestorableByUserIds = @restorableByUserIds;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.Core.TerraformProperty(name: "ids", @out: true, min: 0, max: 1)]
        public string[] @Ids { get; }

        [nterraform.Core.TerraformProperty(name: "owners", @out: false, min: 0, max: 1)]
        public string[] @Owners { get; }

        [nterraform.Core.TerraformProperty(name: "restorable_by_user_ids", @out: false, min: 0, max: 1)]
        public string[] @RestorableByUserIds { get; }
    }

}

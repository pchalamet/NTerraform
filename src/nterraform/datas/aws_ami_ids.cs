using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_ami_ids")]
    public sealed class aws_ami_ids : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "filter")]
        public sealed class filter : nterraform.structure
        {
            public filter(string @name,
                          string[] @values)
            {
                @Name = @name;
                @Values = @values;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        public aws_ami_ids(string[] @executableUsers = null,
                           filter[] @filter = null,
                           string @nameRegex = null,
                           string[] @owners = null)
        {
            @ExecutableUsers = @executableUsers;
            @Filter = @filter;
            @NameRegex = @nameRegex;
            @Owners = @owners;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "executable_users", @out: false, min: 0, max: 1)]
        public string[] @ExecutableUsers { get; }

        [nterraform.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.TerraformProperty(name: "ids", @out: true, min: 0, max: 1)]
        public string[] @Ids { get; }

        [nterraform.TerraformProperty(name: "name_regex", @out: false, min: 0, max: 1)]
        public string @NameRegex { get; }

        [nterraform.TerraformProperty(name: "owners", @out: false, min: 0, max: 1)]
        public string[] @Owners { get; }
    }

}

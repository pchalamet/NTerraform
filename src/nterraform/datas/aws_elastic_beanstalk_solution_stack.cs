using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_elastic_beanstalk_solution_stack")]
    public sealed class aws_elastic_beanstalk_solution_stack : nterraform.Core.data
    {
        public aws_elastic_beanstalk_solution_stack(string @nameRegex,
                                                    bool? @mostRecent = null)
        {
            @NameRegex = @nameRegex;
            @MostRecent = @mostRecent;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name_regex", @out: false, min: 1, max: 1)]
        public string @NameRegex { get; }

        [nterraform.Core.TerraformProperty(name: "most_recent", @out: false, min: 0, max: 1)]
        public bool? @MostRecent { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }
    }

}

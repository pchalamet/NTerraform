using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_glue_script")]
    public sealed class aws_glue_script : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "dag_edge")]
        public sealed class dag_edge : nterraform.Core.structure
        {
            public dag_edge(string @source,
                            string @target,
                            string @targetParameter = null)
            {
                @Source = @source;
                @Target = @target;
                @TargetParameter = @targetParameter;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "source", @out: false, min: 1, max: 1)]
            public string @Source { get; }

            [nterraform.Core.TerraformProperty(name: "target", @out: false, min: 1, max: 1)]
            public string @Target { get; }

            [nterraform.Core.TerraformProperty(name: "target_parameter", @out: false, min: 0, max: 1)]
            public string @TargetParameter { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "dag_node")]
        public sealed class dag_node : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "data", typeName: "args")]
            public sealed class args : nterraform.Core.structure
            {
                public args(string @name,
                            string @value,
                            bool? @param = null)
                {
                    @Name = @name;
                    @Value = @value;
                    @Param = @param;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
                public string @Value { get; }

                [nterraform.Core.TerraformProperty(name: "param", @out: false, min: 0, max: 1)]
                public bool? @Param { get; }
            }

            public dag_node(args[] @args,
                            string @id,
                            string @nodeType,
                            int? @lineNumber = null)
            {
                @Args = @args;
                @Id = @id;
                @NodeType = @nodeType;
                @LineNumber = @lineNumber;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "args", @out: false, min: 1, max: 0)]
            public args[] @Args { get; }

            [nterraform.Core.TerraformProperty(name: "id", @out: false, min: 1, max: 1)]
            public string @Id { get; }

            [nterraform.Core.TerraformProperty(name: "node_type", @out: false, min: 1, max: 1)]
            public string @NodeType { get; }

            [nterraform.Core.TerraformProperty(name: "line_number", @out: false, min: 0, max: 1)]
            public int? @LineNumber { get; }
        }

        public aws_glue_script(dag_edge[] @dagEdge,
                               dag_node[] @dagNode,
                               string @language = null)
        {
            @DagEdge = @dagEdge;
            @DagNode = @dagNode;
            @Language = @language;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "dag_edge", @out: false, min: 1, max: 0)]
        public dag_edge[] @DagEdge { get; }

        [nterraform.Core.TerraformProperty(name: "dag_node", @out: false, min: 1, max: 0)]
        public dag_node[] @DagNode { get; }

        [nterraform.Core.TerraformProperty(name: "language", @out: false, min: 0, max: 1)]
        public string @Language { get; }

        [nterraform.Core.TerraformProperty(name: "python_script", @out: true, min: 0, max: 1)]
        public string @PythonScript { get; }

        [nterraform.Core.TerraformProperty(name: "scala_code", @out: true, min: 0, max: 1)]
        public string @ScalaCode { get; }
    }

}

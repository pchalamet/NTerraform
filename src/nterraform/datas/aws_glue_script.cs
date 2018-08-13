using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_glue_script")]
    public sealed class aws_glue_script : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "dag_edge")]
        public sealed class dag_edge : nterraform.structure
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

            [nterraform.TerraformProperty(name: "source", @out: false, min: 1, max: 1)]
            public string @Source { get; }

            [nterraform.TerraformProperty(name: "target", @out: false, min: 1, max: 1)]
            public string @Target { get; }

            [nterraform.TerraformProperty(name: "target_parameter", @out: false, min: 0, max: 1)]
            public string @TargetParameter { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "dag_node")]
        public sealed class dag_node : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "data", typeName: "args")]
            public sealed class args : nterraform.structure
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

                [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
                public string @Value { get; }

                [nterraform.TerraformProperty(name: "param", @out: false, min: 0, max: 1)]
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

            [nterraform.TerraformProperty(name: "args", @out: false, min: 1, max: 0)]
            public args[] @Args { get; }

            [nterraform.TerraformProperty(name: "id", @out: false, min: 1, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "node_type", @out: false, min: 1, max: 1)]
            public string @NodeType { get; }

            [nterraform.TerraformProperty(name: "line_number", @out: false, min: 0, max: 1)]
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

        [nterraform.TerraformProperty(name: "dag_edge", @out: false, min: 1, max: 0)]
        public dag_edge[] @DagEdge { get; }

        [nterraform.TerraformProperty(name: "dag_node", @out: false, min: 1, max: 0)]
        public dag_node[] @DagNode { get; }

        [nterraform.TerraformProperty(name: "language", @out: false, min: 0, max: 1)]
        public string @Language { get; }

        [nterraform.TerraformProperty(name: "python_script", @out: true, min: 0, max: 1)]
        public string @PythonScript { get; }

        [nterraform.TerraformProperty(name: "scala_code", @out: true, min: 0, max: 1)]
        public string @ScalaCode { get; }
    }

}

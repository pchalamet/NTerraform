using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_dynamodb_table")]
    public sealed class aws_dynamodb_table : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "attribute")]
        public sealed class attribute : nterraform.Core.structure
        {
            public attribute(string @name,
                             string @type)
            {
                @Name = @name;
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "global_secondary_index")]
        public sealed class global_secondary_index : nterraform.Core.structure
        {
            public global_secondary_index(string @hashKey,
                                          string @name,
                                          string @projectionType,
                                          int @readCapacity,
                                          int @writeCapacity,
                                          string[] @nonKeyAttributes = null,
                                          string @rangeKey = null)
            {
                @HashKey = @hashKey;
                @Name = @name;
                @ProjectionType = @projectionType;
                @ReadCapacity = @readCapacity;
                @WriteCapacity = @writeCapacity;
                @NonKeyAttributes = @nonKeyAttributes;
                @RangeKey = @rangeKey;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "hash_key", @out: false, min: 1, max: 1)]
            public string @HashKey { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "projection_type", @out: false, min: 1, max: 1)]
            public string @ProjectionType { get; }

            [nterraform.Core.TerraformProperty(name: "read_capacity", @out: false, min: 1, max: 1)]
            public int @ReadCapacity { get; }

            [nterraform.Core.TerraformProperty(name: "write_capacity", @out: false, min: 1, max: 1)]
            public int @WriteCapacity { get; }

            [nterraform.Core.TerraformProperty(name: "non_key_attributes", @out: false, min: 0, max: 1)]
            public string[] @NonKeyAttributes { get; }

            [nterraform.Core.TerraformProperty(name: "range_key", @out: false, min: 0, max: 1)]
            public string @RangeKey { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "local_secondary_index")]
        public sealed class local_secondary_index : nterraform.Core.structure
        {
            public local_secondary_index(string @name,
                                         string @projectionType,
                                         string @rangeKey,
                                         string[] @nonKeyAttributes = null)
            {
                @Name = @name;
                @ProjectionType = @projectionType;
                @RangeKey = @rangeKey;
                @NonKeyAttributes = @nonKeyAttributes;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "projection_type", @out: false, min: 1, max: 1)]
            public string @ProjectionType { get; }

            [nterraform.Core.TerraformProperty(name: "range_key", @out: false, min: 1, max: 1)]
            public string @RangeKey { get; }

            [nterraform.Core.TerraformProperty(name: "non_key_attributes", @out: false, min: 0, max: 1)]
            public string[] @NonKeyAttributes { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "server_side_encryption")]
        public sealed class server_side_encryption : nterraform.Core.structure
        {
            public server_side_encryption(bool @enabled)
            {
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ttl")]
        public sealed class ttl : nterraform.Core.structure
        {
            public ttl(string @attributeName,
                       bool @enabled)
            {
                @AttributeName = @attributeName;
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "attribute_name", @out: false, min: 1, max: 1)]
            public string @AttributeName { get; }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "point_in_time_recovery")]
        public sealed class point_in_time_recovery : nterraform.Core.structure
        {
            public point_in_time_recovery(bool @enabled)
            {
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }
        }

        public aws_dynamodb_table(attribute[] @attribute,
                                  string @hashKey,
                                  string @name,
                                  int @readCapacity,
                                  int @writeCapacity,
                                  global_secondary_index[] @globalSecondaryIndex = null,
                                  local_secondary_index[] @localSecondaryIndex = null,
                                  point_in_time_recovery[] @pointInTimeRecovery = null,
                                  string @rangeKey = null,
                                  server_side_encryption[] @serverSideEncryption = null,
                                  bool? @streamEnabled = null,
                                  Dictionary<string,string> @tags = null,
                                  ttl[] @ttl = null)
        {
            @Attribute = @attribute;
            @HashKey = @hashKey;
            @Name = @name;
            @ReadCapacity = @readCapacity;
            @WriteCapacity = @writeCapacity;
            @GlobalSecondaryIndex = @globalSecondaryIndex;
            @LocalSecondaryIndex = @localSecondaryIndex;
            @PointInTimeRecovery = @pointInTimeRecovery;
            @RangeKey = @rangeKey;
            @ServerSideEncryption = @serverSideEncryption;
            @StreamEnabled = @streamEnabled;
            @Tags = @tags;
            @Ttl = @ttl;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "attribute", @out: false, min: 1, max: 0)]
        public attribute[] @Attribute { get; }

        [nterraform.Core.TerraformProperty(name: "hash_key", @out: false, min: 1, max: 1)]
        public string @HashKey { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "read_capacity", @out: false, min: 1, max: 1)]
        public int @ReadCapacity { get; }

        [nterraform.Core.TerraformProperty(name: "write_capacity", @out: false, min: 1, max: 1)]
        public int @WriteCapacity { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "global_secondary_index", @out: false, min: 0, max: 0)]
        public global_secondary_index[] @GlobalSecondaryIndex { get; }

        [nterraform.Core.TerraformProperty(name: "local_secondary_index", @out: false, min: 0, max: 0)]
        public local_secondary_index[] @LocalSecondaryIndex { get; }

        [nterraform.Core.TerraformProperty(name: "point_in_time_recovery", @out: false, min: 0, max: 1)]
        public point_in_time_recovery[] @PointInTimeRecovery { get; }

        [nterraform.Core.TerraformProperty(name: "range_key", @out: false, min: 0, max: 1)]
        public string @RangeKey { get; }

        [nterraform.Core.TerraformProperty(name: "server_side_encryption", @out: false, min: 0, max: 1)]
        public server_side_encryption[] @ServerSideEncryption { get; }

        [nterraform.Core.TerraformProperty(name: "stream_arn", @out: true, min: 0, max: 1)]
        public string @StreamArn { get; }

        [nterraform.Core.TerraformProperty(name: "stream_enabled", @out: false, min: 0, max: 1)]
        public bool? @StreamEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "stream_label", @out: true, min: 0, max: 1)]
        public string @StreamLabel { get; }

        [nterraform.Core.TerraformProperty(name: "stream_view_type", @out: true, min: 0, max: 1)]
        public string @StreamViewType { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "ttl", @out: false, min: 0, max: 1)]
        public ttl[] @Ttl { get; }
    }

}

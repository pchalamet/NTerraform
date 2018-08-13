using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_dynamodb_table")]
    public sealed class aws_dynamodb_table : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "attribute")]
        public sealed class attribute : nterraform.structure
        {
            public attribute(string @name,
                             string @type)
            {
                @Name = @name;
                @Type = @type;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "point_in_time_recovery")]
        public sealed class point_in_time_recovery : nterraform.structure
        {
            public point_in_time_recovery(bool @enabled)
            {
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "ttl")]
        public sealed class ttl : nterraform.structure
        {
            public ttl(string @attributeName,
                       bool @enabled)
            {
                @AttributeName = @attributeName;
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "attribute_name", @out: false, min: 1, max: 1)]
            public string @AttributeName { get; }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "local_secondary_index")]
        public sealed class local_secondary_index : nterraform.structure
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

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "projection_type", @out: false, min: 1, max: 1)]
            public string @ProjectionType { get; }

            [nterraform.TerraformProperty(name: "range_key", @out: false, min: 1, max: 1)]
            public string @RangeKey { get; }

            [nterraform.TerraformProperty(name: "non_key_attributes", @out: false, min: 0, max: 1)]
            public string[] @NonKeyAttributes { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "server_side_encryption")]
        public sealed class server_side_encryption : nterraform.structure
        {
            public server_side_encryption(bool @enabled)
            {
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "global_secondary_index")]
        public sealed class global_secondary_index : nterraform.structure
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

            [nterraform.TerraformProperty(name: "hash_key", @out: false, min: 1, max: 1)]
            public string @HashKey { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "projection_type", @out: false, min: 1, max: 1)]
            public string @ProjectionType { get; }

            [nterraform.TerraformProperty(name: "read_capacity", @out: false, min: 1, max: 1)]
            public int @ReadCapacity { get; }

            [nterraform.TerraformProperty(name: "write_capacity", @out: false, min: 1, max: 1)]
            public int @WriteCapacity { get; }

            [nterraform.TerraformProperty(name: "non_key_attributes", @out: false, min: 0, max: 1)]
            public string[] @NonKeyAttributes { get; }

            [nterraform.TerraformProperty(name: "range_key", @out: false, min: 0, max: 1)]
            public string @RangeKey { get; }
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

        [nterraform.TerraformProperty(name: "attribute", @out: false, min: 1, max: 0)]
        public attribute[] @Attribute { get; }

        [nterraform.TerraformProperty(name: "hash_key", @out: false, min: 1, max: 1)]
        public string @HashKey { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "read_capacity", @out: false, min: 1, max: 1)]
        public int @ReadCapacity { get; }

        [nterraform.TerraformProperty(name: "write_capacity", @out: false, min: 1, max: 1)]
        public int @WriteCapacity { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "global_secondary_index", @out: false, min: 0, max: 0)]
        public global_secondary_index[] @GlobalSecondaryIndex { get; }

        [nterraform.TerraformProperty(name: "local_secondary_index", @out: false, min: 0, max: 0)]
        public local_secondary_index[] @LocalSecondaryIndex { get; }

        [nterraform.TerraformProperty(name: "point_in_time_recovery", @out: false, min: 0, max: 1)]
        public point_in_time_recovery[] @PointInTimeRecovery { get; }

        [nterraform.TerraformProperty(name: "range_key", @out: false, min: 0, max: 1)]
        public string @RangeKey { get; }

        [nterraform.TerraformProperty(name: "server_side_encryption", @out: false, min: 0, max: 1)]
        public server_side_encryption[] @ServerSideEncryption { get; }

        [nterraform.TerraformProperty(name: "stream_arn", @out: true, min: 0, max: 1)]
        public string @StreamArn { get; }

        [nterraform.TerraformProperty(name: "stream_enabled", @out: false, min: 0, max: 1)]
        public bool? @StreamEnabled { get; }

        [nterraform.TerraformProperty(name: "stream_label", @out: true, min: 0, max: 1)]
        public string @StreamLabel { get; }

        [nterraform.TerraformProperty(name: "stream_view_type", @out: true, min: 0, max: 1)]
        public string @StreamViewType { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "ttl", @out: false, min: 0, max: 1)]
        public ttl[] @Ttl { get; }
    }

}

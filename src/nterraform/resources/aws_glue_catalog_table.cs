using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_glue_catalog_table")]
    public sealed class aws_glue_catalog_table : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "storage_descriptor")]
        public sealed class storage_descriptor : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "sort_columns")]
            public sealed class sort_columns : nterraform.Core.structure
            {
                public sort_columns(string @column,
                                    int @sortOrder)
                {
                    @Column = @column;
                    @SortOrder = @sortOrder;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "column", @out: false, min: 1, max: 1)]
                public string @Column { get; }

                [nterraform.Core.TerraformProperty(name: "sort_order", @out: false, min: 1, max: 1)]
                public int @SortOrder { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "columns")]
            public sealed class columns : nterraform.Core.structure
            {
                public columns(string @name,
                               string @comment = null,
                               string @type = null)
                {
                    @Name = @name;
                    @Comment = @comment;
                    @Type = @type;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.Core.TerraformProperty(name: "comment", @out: false, min: 0, max: 1)]
                public string @Comment { get; }

                [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
                public string @Type { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "ser_de_info")]
            public sealed class ser_de_info : nterraform.Core.structure
            {
                public ser_de_info(string @name = null,
                                   Dictionary<string,string> @parameters = null,
                                   string @serializationLibrary = null)
                {
                    @Name = @name;
                    @Parameters = @parameters;
                    @SerializationLibrary = @serializationLibrary;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
                public string @Name { get; }

                [nterraform.Core.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
                public Dictionary<string,string> @Parameters { get; }

                [nterraform.Core.TerraformProperty(name: "serialization_library", @out: false, min: 0, max: 1)]
                public string @SerializationLibrary { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "skewed_info")]
            public sealed class skewed_info : nterraform.Core.structure
            {
                public skewed_info(string[] @skewedColumnNames = null,
                                   Dictionary<string,string> @skewedColumnValueLocationMaps = null,
                                   string[] @skewedColumnValues = null)
                {
                    @SkewedColumnNames = @skewedColumnNames;
                    @SkewedColumnValueLocationMaps = @skewedColumnValueLocationMaps;
                    @SkewedColumnValues = @skewedColumnValues;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "skewed_column_names", @out: false, min: 0, max: 1)]
                public string[] @SkewedColumnNames { get; }

                [nterraform.Core.TerraformProperty(name: "skewed_column_value_location_maps", @out: false, min: 0, max: 1)]
                public Dictionary<string,string> @SkewedColumnValueLocationMaps { get; }

                [nterraform.Core.TerraformProperty(name: "skewed_column_values", @out: false, min: 0, max: 1)]
                public string[] @SkewedColumnValues { get; }
            }

            public storage_descriptor(string[] @bucketColumns = null,
                                      columns[] @columns = null,
                                      bool? @compressed = null,
                                      string @inputFormat = null,
                                      string @location = null,
                                      int? @numberOfBuckets = null,
                                      string @outputFormat = null,
                                      Dictionary<string,string> @parameters = null,
                                      ser_de_info[] @serDeInfo = null,
                                      skewed_info[] @skewedInfo = null,
                                      sort_columns[] @sortColumns = null,
                                      bool? @storedAsSubDirectories = null)
            {
                @BucketColumns = @bucketColumns;
                @Columns = @columns;
                @Compressed = @compressed;
                @InputFormat = @inputFormat;
                @Location = @location;
                @NumberOfBuckets = @numberOfBuckets;
                @OutputFormat = @outputFormat;
                @Parameters = @parameters;
                @SerDeInfo = @serDeInfo;
                @SkewedInfo = @skewedInfo;
                @SortColumns = @sortColumns;
                @StoredAsSubDirectories = @storedAsSubDirectories;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "bucket_columns", @out: false, min: 0, max: 1)]
            public string[] @BucketColumns { get; }

            [nterraform.Core.TerraformProperty(name: "columns", @out: false, min: 0, max: 0)]
            public columns[] @Columns { get; }

            [nterraform.Core.TerraformProperty(name: "compressed", @out: false, min: 0, max: 1)]
            public bool? @Compressed { get; }

            [nterraform.Core.TerraformProperty(name: "input_format", @out: false, min: 0, max: 1)]
            public string @InputFormat { get; }

            [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
            public string @Location { get; }

            [nterraform.Core.TerraformProperty(name: "number_of_buckets", @out: false, min: 0, max: 1)]
            public int? @NumberOfBuckets { get; }

            [nterraform.Core.TerraformProperty(name: "output_format", @out: false, min: 0, max: 1)]
            public string @OutputFormat { get; }

            [nterraform.Core.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Parameters { get; }

            [nterraform.Core.TerraformProperty(name: "ser_de_info", @out: false, min: 0, max: 1)]
            public ser_de_info[] @SerDeInfo { get; }

            [nterraform.Core.TerraformProperty(name: "skewed_info", @out: false, min: 0, max: 1)]
            public skewed_info[] @SkewedInfo { get; }

            [nterraform.Core.TerraformProperty(name: "sort_columns", @out: false, min: 0, max: 0)]
            public sort_columns[] @SortColumns { get; }

            [nterraform.Core.TerraformProperty(name: "stored_as_sub_directories", @out: false, min: 0, max: 1)]
            public bool? @StoredAsSubDirectories { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "partition_keys")]
        public sealed class partition_keys : nterraform.Core.structure
        {
            public partition_keys(string @name,
                                  string @comment = null,
                                  string @type = null)
            {
                @Name = @name;
                @Comment = @comment;
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "comment", @out: false, min: 0, max: 1)]
            public string @Comment { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
            public string @Type { get; }
        }

        public aws_glue_catalog_table(string @databaseName,
                                      string @name,
                                      string @description = null,
                                      string @owner = null,
                                      Dictionary<string,string> @parameters = null,
                                      partition_keys[] @partitionKeys = null,
                                      int? @retention = null,
                                      storage_descriptor[] @storageDescriptor = null,
                                      string @tableType = null,
                                      string @viewExpandedText = null,
                                      string @viewOriginalText = null)
        {
            @DatabaseName = @databaseName;
            @Name = @name;
            @Description = @description;
            @Owner = @owner;
            @Parameters = @parameters;
            @PartitionKeys = @partitionKeys;
            @Retention = @retention;
            @StorageDescriptor = @storageDescriptor;
            @TableType = @tableType;
            @ViewExpandedText = @viewExpandedText;
            @ViewOriginalText = @viewOriginalText;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "database_name", @out: false, min: 1, max: 1)]
        public string @DatabaseName { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "catalog_id", @out: true, min: 0, max: 1)]
        public string @CatalogId { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "owner", @out: false, min: 0, max: 1)]
        public string @Owner { get; }

        [nterraform.Core.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Parameters { get; }

        [nterraform.Core.TerraformProperty(name: "partition_keys", @out: false, min: 0, max: 0)]
        public partition_keys[] @PartitionKeys { get; }

        [nterraform.Core.TerraformProperty(name: "retention", @out: false, min: 0, max: 1)]
        public int? @Retention { get; }

        [nterraform.Core.TerraformProperty(name: "storage_descriptor", @out: false, min: 0, max: 1)]
        public storage_descriptor[] @StorageDescriptor { get; }

        [nterraform.Core.TerraformProperty(name: "table_type", @out: false, min: 0, max: 1)]
        public string @TableType { get; }

        [nterraform.Core.TerraformProperty(name: "view_expanded_text", @out: false, min: 0, max: 1)]
        public string @ViewExpandedText { get; }

        [nterraform.Core.TerraformProperty(name: "view_original_text", @out: false, min: 0, max: 1)]
        public string @ViewOriginalText { get; }
    }

}

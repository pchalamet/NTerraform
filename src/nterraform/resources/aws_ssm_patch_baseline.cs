using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ssm_patch_baseline")]
    public sealed class aws_ssm_patch_baseline : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "approval_rule")]
        public sealed class approval_rule : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "patch_filter")]
            public sealed class patch_filter : nterraform.structure
            {
                public patch_filter(string @key,
                                    string[] @values)
                {
                    @Key = @key;
                    @Values = @values;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
                public string @Key { get; }

                [nterraform.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
                public string[] @Values { get; }
            }

            public approval_rule(int @approveAfterDays,
                                 patch_filter[] @patchFilter,
                                 string @complianceLevel = null,
                                 bool? @enableNonSecurity = null)
            {
                @ApproveAfterDays = @approveAfterDays;
                @PatchFilter = @patchFilter;
                @ComplianceLevel = @complianceLevel;
                @EnableNonSecurity = @enableNonSecurity;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "approve_after_days", @out: false, min: 1, max: 1)]
            public int @ApproveAfterDays { get; }

            [nterraform.TerraformProperty(name: "patch_filter", @out: false, min: 1, max: 10)]
            public patch_filter[] @PatchFilter { get; }

            [nterraform.TerraformProperty(name: "compliance_level", @out: false, min: 0, max: 1)]
            public string @ComplianceLevel { get; }

            [nterraform.TerraformProperty(name: "enable_non_security", @out: false, min: 0, max: 1)]
            public bool? @EnableNonSecurity { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "global_filter")]
        public sealed class global_filter : nterraform.structure
        {
            public global_filter(string @key,
                                 string[] @values)
            {
                @Key = @key;
                @Values = @values;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
            public string @Key { get; }

            [nterraform.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        public aws_ssm_patch_baseline(string @name,
                                      approval_rule[] @approvalRule = null,
                                      string[] @approvedPatches = null,
                                      string @approvedPatchesComplianceLevel = null,
                                      string @description = null,
                                      global_filter[] @globalFilter = null,
                                      string @operatingSystem = null,
                                      string[] @rejectedPatches = null)
        {
            @Name = @name;
            @ApprovalRule = @approvalRule;
            @ApprovedPatches = @approvedPatches;
            @ApprovedPatchesComplianceLevel = @approvedPatchesComplianceLevel;
            @Description = @description;
            @GlobalFilter = @globalFilter;
            @OperatingSystem = @operatingSystem;
            @RejectedPatches = @rejectedPatches;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "approval_rule", @out: false, min: 0, max: 0)]
        public approval_rule[] @ApprovalRule { get; }

        [nterraform.TerraformProperty(name: "approved_patches", @out: false, min: 0, max: 1)]
        public string[] @ApprovedPatches { get; }

        [nterraform.TerraformProperty(name: "approved_patches_compliance_level", @out: false, min: 0, max: 1)]
        public string @ApprovedPatchesComplianceLevel { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "global_filter", @out: false, min: 0, max: 4)]
        public global_filter[] @GlobalFilter { get; }

        [nterraform.TerraformProperty(name: "operating_system", @out: false, min: 0, max: 1)]
        public string @OperatingSystem { get; }

        [nterraform.TerraformProperty(name: "rejected_patches", @out: false, min: 0, max: 1)]
        public string[] @RejectedPatches { get; }
    }

}

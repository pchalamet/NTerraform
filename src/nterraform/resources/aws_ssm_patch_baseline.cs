using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ssm_patch_baseline")]
    public sealed class aws_ssm_patch_baseline : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "approval_rule")]
        public sealed class approval_rule : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "patch_filter")]
            public sealed class patch_filter : nterraform.Core.structure
            {
                public patch_filter(string @key,
                                    string[] @values)
                {
                    @Key = @key;
                    @Values = @values;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
                public string @Key { get; }

                [nterraform.Core.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
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

            [nterraform.Core.TerraformProperty(name: "approve_after_days", @out: false, min: 1, max: 1)]
            public int @ApproveAfterDays { get; }

            [nterraform.Core.TerraformProperty(name: "patch_filter", @out: false, min: 1, max: 10)]
            public patch_filter[] @PatchFilter { get; }

            [nterraform.Core.TerraformProperty(name: "compliance_level", @out: false, min: 0, max: 1)]
            public string @ComplianceLevel { get; }

            [nterraform.Core.TerraformProperty(name: "enable_non_security", @out: false, min: 0, max: 1)]
            public bool? @EnableNonSecurity { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "global_filter")]
        public sealed class global_filter : nterraform.Core.structure
        {
            public global_filter(string @key,
                                 string[] @values)
            {
                @Key = @key;
                @Values = @values;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
            public string @Key { get; }

            [nterraform.Core.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "approval_rule", @out: false, min: 0, max: 0)]
        public approval_rule[] @ApprovalRule { get; }

        [nterraform.Core.TerraformProperty(name: "approved_patches", @out: false, min: 0, max: 1)]
        public string[] @ApprovedPatches { get; }

        [nterraform.Core.TerraformProperty(name: "approved_patches_compliance_level", @out: false, min: 0, max: 1)]
        public string @ApprovedPatchesComplianceLevel { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "global_filter", @out: false, min: 0, max: 4)]
        public global_filter[] @GlobalFilter { get; }

        [nterraform.Core.TerraformProperty(name: "operating_system", @out: false, min: 0, max: 1)]
        public string @OperatingSystem { get; }

        [nterraform.Core.TerraformProperty(name: "rejected_patches", @out: false, min: 0, max: 1)]
        public string[] @RejectedPatches { get; }
    }

}

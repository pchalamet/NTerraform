using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "github_branch_protection")]
    public sealed class github_branch_protection : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "required_status_checks")]
        public sealed class required_status_checks: NTerraform.structure
        {
            public required_status_checks(string[] @contexts = null,
                                          bool? @includeAdmins = null,
                                          bool? @strict = null)
            {
                @Contexts = @contexts;
                @IncludeAdmins = @includeAdmins;
                @Strict = @strict;
                base._validate_();
            }

            [TerraformProperty(name: "contexts", @out: false, min: 0, max: 1)]
            public string[] @Contexts { get; }

            [TerraformProperty(name: "include_admins", @out: false, min: 0, max: 1)]
            public bool? @IncludeAdmins { get; }

            [TerraformProperty(name: "strict", @out: false, min: 0, max: 1)]
            public bool? @Strict { get; }
        }

        [TerraformStructure(category: "", typeName: "required_pull_request_reviews")]
        public sealed class required_pull_request_reviews: NTerraform.structure
        {
            public required_pull_request_reviews(bool? @dismissStaleReviews = null,
                                                 string[] @dismissalTeams = null,
                                                 string[] @dismissalUsers = null,
                                                 bool? @includeAdmins = null,
                                                 bool? @requireCodeOwnerReviews = null)
            {
                @DismissStaleReviews = @dismissStaleReviews;
                @DismissalTeams = @dismissalTeams;
                @DismissalUsers = @dismissalUsers;
                @IncludeAdmins = @includeAdmins;
                @RequireCodeOwnerReviews = @requireCodeOwnerReviews;
                base._validate_();
            }

            [TerraformProperty(name: "dismiss_stale_reviews", @out: false, min: 0, max: 1)]
            public bool? @DismissStaleReviews { get; }

            [TerraformProperty(name: "dismissal_teams", @out: false, min: 0, max: 1)]
            public string[] @DismissalTeams { get; }

            [TerraformProperty(name: "dismissal_users", @out: false, min: 0, max: 1)]
            public string[] @DismissalUsers { get; }

            [TerraformProperty(name: "include_admins", @out: false, min: 0, max: 1)]
            public bool? @IncludeAdmins { get; }

            [TerraformProperty(name: "require_code_owner_reviews", @out: false, min: 0, max: 1)]
            public bool? @RequireCodeOwnerReviews { get; }
        }

        [TerraformStructure(category: "", typeName: "restrictions")]
        public sealed class restrictions: NTerraform.structure
        {
            public restrictions(string[] @teams = null,
                                string[] @users = null)
            {
                @Teams = @teams;
                @Users = @users;
                base._validate_();
            }

            [TerraformProperty(name: "teams", @out: false, min: 0, max: 1)]
            public string[] @Teams { get; }

            [TerraformProperty(name: "users", @out: false, min: 0, max: 1)]
            public string[] @Users { get; }
        }

        public github_branch_protection(string @branch,
                                        string @repository,
                                        bool? @enforceAdmins = null,
                                        required_pull_request_reviews[] @requiredPullRequestReviews = null,
                                        required_status_checks[] @requiredStatusChecks = null,
                                        restrictions[] @restrictions = null)
        {
            @Branch = @branch;
            @Repository = @repository;
            @EnforceAdmins = @enforceAdmins;
            @RequiredPullRequestReviews = @requiredPullRequestReviews;
            @RequiredStatusChecks = @requiredStatusChecks;
            @Restrictions = @restrictions;
            base._validate_();
        }

        [TerraformProperty(name: "branch", @out: false, min: 1, max: 1)]
        public string @Branch { get; }

        [TerraformProperty(name: "repository", @out: false, min: 1, max: 1)]
        public string @Repository { get; }

        [TerraformProperty(name: "enforce_admins", @out: false, min: 0, max: 1)]
        public bool? @EnforceAdmins { get; }

        [TerraformProperty(name: "required_pull_request_reviews", @out: false, min: 0, max: 1)]
        public required_pull_request_reviews[] @RequiredPullRequestReviews { get; }

        [TerraformProperty(name: "required_status_checks", @out: false, min: 0, max: 1)]
        public required_status_checks[] @RequiredStatusChecks { get; }

        [TerraformProperty(name: "restrictions", @out: false, min: 0, max: 1)]
        public restrictions[] @Restrictions { get; }
    }

}

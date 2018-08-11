using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "github_repository")]
    public sealed class github_repository : NTerraform.resource
    {
        public github_repository(string @name,
                                 bool? @allowMergeCommit = null,
                                 bool? @allowRebaseMerge = null,
                                 bool? @allowSquashMerge = null,
                                 bool? @archived = null,
                                 bool? @autoInit = null,
                                 string @description = null,
                                 string @gitignoreTemplate = null,
                                 bool? @hasDownloads = null,
                                 bool? @hasIssues = null,
                                 bool? @hasProjects = null,
                                 bool? @hasWiki = null,
                                 string @homepageUrl = null,
                                 string @licenseTemplate = null,
                                 bool? @private = null)
        {
            @Name = @name;
            @AllowMergeCommit = @allowMergeCommit;
            @AllowRebaseMerge = @allowRebaseMerge;
            @AllowSquashMerge = @allowSquashMerge;
            @Archived = @archived;
            @AutoInit = @autoInit;
            @Description = @description;
            @GitignoreTemplate = @gitignoreTemplate;
            @HasDownloads = @hasDownloads;
            @HasIssues = @hasIssues;
            @HasProjects = @hasProjects;
            @HasWiki = @hasWiki;
            @HomepageUrl = @homepageUrl;
            @LicenseTemplate = @licenseTemplate;
            @Private = @private;
            base._validate_();
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "allow_merge_commit", @out: false, min: 0, max: 1)]
        public bool? @AllowMergeCommit { get; }

        [TerraformProperty(name: "allow_rebase_merge", @out: false, min: 0, max: 1)]
        public bool? @AllowRebaseMerge { get; }

        [TerraformProperty(name: "allow_squash_merge", @out: false, min: 0, max: 1)]
        public bool? @AllowSquashMerge { get; }

        [TerraformProperty(name: "archived", @out: false, min: 0, max: 1)]
        public bool? @Archived { get; }

        [TerraformProperty(name: "auto_init", @out: false, min: 0, max: 1)]
        public bool? @AutoInit { get; }

        [TerraformProperty(name: "default_branch", @out: true, min: 0, max: 1)]
        public string @DefaultBranch { get; }

        [TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [TerraformProperty(name: "full_name", @out: true, min: 0, max: 1)]
        public string @FullName { get; }

        [TerraformProperty(name: "git_clone_url", @out: true, min: 0, max: 1)]
        public string @GitCloneUrl { get; }

        [TerraformProperty(name: "gitignore_template", @out: false, min: 0, max: 1)]
        public string @GitignoreTemplate { get; }

        [TerraformProperty(name: "has_downloads", @out: false, min: 0, max: 1)]
        public bool? @HasDownloads { get; }

        [TerraformProperty(name: "has_issues", @out: false, min: 0, max: 1)]
        public bool? @HasIssues { get; }

        [TerraformProperty(name: "has_projects", @out: false, min: 0, max: 1)]
        public bool? @HasProjects { get; }

        [TerraformProperty(name: "has_wiki", @out: false, min: 0, max: 1)]
        public bool? @HasWiki { get; }

        [TerraformProperty(name: "homepage_url", @out: false, min: 0, max: 1)]
        public string @HomepageUrl { get; }

        [TerraformProperty(name: "html_url", @out: true, min: 0, max: 1)]
        public string @HtmlUrl { get; }

        [TerraformProperty(name: "http_clone_url", @out: true, min: 0, max: 1)]
        public string @HttpCloneUrl { get; }

        [TerraformProperty(name: "license_template", @out: false, min: 0, max: 1)]
        public string @LicenseTemplate { get; }

        [TerraformProperty(name: "private", @out: false, min: 0, max: 1)]
        public bool? @Private { get; }

        [TerraformProperty(name: "ssh_clone_url", @out: true, min: 0, max: 1)]
        public string @SshCloneUrl { get; }

        [TerraformProperty(name: "svn_url", @out: true, min: 0, max: 1)]
        public string @SvnUrl { get; }
    }

}

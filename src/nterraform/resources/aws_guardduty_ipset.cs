using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_guardduty_ipset")]
    public sealed class aws_guardduty_ipset : nterraform.Core.resource
    {
        public aws_guardduty_ipset(bool @activate,
                                   string @detectorId,
                                   string @format,
                                   string @location,
                                   string @name)
        {
            @Activate = @activate;
            @DetectorId = @detectorId;
            @Format = @format;
            @Location = @location;
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "activate", @out: false, min: 1, max: 1)]
        public bool @Activate { get; }

        [nterraform.Core.TerraformProperty(name: "detector_id", @out: false, min: 1, max: 1)]
        public string @DetectorId { get; }

        [nterraform.Core.TerraformProperty(name: "format", @out: false, min: 1, max: 1)]
        public string @Format { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }
    }

}

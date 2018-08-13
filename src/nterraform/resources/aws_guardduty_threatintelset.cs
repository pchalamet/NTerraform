using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_guardduty_threatintelset")]
    public sealed class aws_guardduty_threatintelset : nterraform.resource
    {
        public aws_guardduty_threatintelset(bool @activate,
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

        [nterraform.TerraformProperty(name: "activate", @out: false, min: 1, max: 1)]
        public bool @Activate { get; }

        [nterraform.TerraformProperty(name: "detector_id", @out: false, min: 1, max: 1)]
        public string @DetectorId { get; }

        [nterraform.TerraformProperty(name: "format", @out: false, min: 1, max: 1)]
        public string @Format { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }
    }

}

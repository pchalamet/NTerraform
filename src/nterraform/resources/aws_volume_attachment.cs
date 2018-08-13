using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_volume_attachment")]
    public sealed class aws_volume_attachment : nterraform.Core.resource
    {
        public aws_volume_attachment(string @deviceName,
                                     string @instanceId,
                                     string @volumeId,
                                     bool? @forceDetach = null,
                                     bool? @skipDestroy = null)
        {
            @DeviceName = @deviceName;
            @InstanceId = @instanceId;
            @VolumeId = @volumeId;
            @ForceDetach = @forceDetach;
            @SkipDestroy = @skipDestroy;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "device_name", @out: false, min: 1, max: 1)]
        public string @DeviceName { get; }

        [nterraform.Core.TerraformProperty(name: "instance_id", @out: false, min: 1, max: 1)]
        public string @InstanceId { get; }

        [nterraform.Core.TerraformProperty(name: "volume_id", @out: false, min: 1, max: 1)]
        public string @VolumeId { get; }

        [nterraform.Core.TerraformProperty(name: "force_detach", @out: false, min: 0, max: 1)]
        public bool? @ForceDetach { get; }

        [nterraform.Core.TerraformProperty(name: "skip_destroy", @out: false, min: 0, max: 1)]
        public bool? @SkipDestroy { get; }
    }

}

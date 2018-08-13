using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_volume_attachment")]
    public sealed class aws_volume_attachment : nterraform.resource
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

        [nterraform.TerraformProperty(name: "device_name", @out: false, min: 1, max: 1)]
        public string @DeviceName { get; }

        [nterraform.TerraformProperty(name: "instance_id", @out: false, min: 1, max: 1)]
        public string @InstanceId { get; }

        [nterraform.TerraformProperty(name: "volume_id", @out: false, min: 1, max: 1)]
        public string @VolumeId { get; }

        [nterraform.TerraformProperty(name: "force_detach", @out: false, min: 0, max: 1)]
        public bool? @ForceDetach { get; }

        [nterraform.TerraformProperty(name: "skip_destroy", @out: false, min: 0, max: 1)]
        public bool? @SkipDestroy { get; }
    }

}

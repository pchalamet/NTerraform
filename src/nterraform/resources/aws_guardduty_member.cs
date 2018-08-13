using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_guardduty_member")]
    public sealed class aws_guardduty_member : nterraform.Core.resource
    {
        public aws_guardduty_member(string @accountId,
                                    string @detectorId,
                                    string @email,
                                    bool? @disableEmailNotification = null,
                                    string @invitationMessage = null,
                                    bool? @invite = null)
        {
            @AccountId = @accountId;
            @DetectorId = @detectorId;
            @Email = @email;
            @DisableEmailNotification = @disableEmailNotification;
            @InvitationMessage = @invitationMessage;
            @Invite = @invite;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "account_id", @out: false, min: 1, max: 1)]
        public string @AccountId { get; }

        [nterraform.Core.TerraformProperty(name: "detector_id", @out: false, min: 1, max: 1)]
        public string @DetectorId { get; }

        [nterraform.Core.TerraformProperty(name: "email", @out: false, min: 1, max: 1)]
        public string @Email { get; }

        [nterraform.Core.TerraformProperty(name: "disable_email_notification", @out: false, min: 0, max: 1)]
        public bool? @DisableEmailNotification { get; }

        [nterraform.Core.TerraformProperty(name: "invitation_message", @out: false, min: 0, max: 1)]
        public string @InvitationMessage { get; }

        [nterraform.Core.TerraformProperty(name: "invite", @out: false, min: 0, max: 1)]
        public bool? @Invite { get; }

        [nterraform.Core.TerraformProperty(name: "relationship_status", @out: true, min: 0, max: 1)]
        public string @RelationshipStatus { get; }
    }

}

using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ses_template")]
    public sealed class aws_ses_template : nterraform.Core.resource
    {
        public aws_ses_template(string @name,
                                string @html = null,
                                string @subject = null,
                                string @text = null)
        {
            @Name = @name;
            @Html = @html;
            @Subject = @subject;
            @Text = @text;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "html", @out: false, min: 0, max: 1)]
        public string @Html { get; }

        [nterraform.Core.TerraformProperty(name: "subject", @out: false, min: 0, max: 1)]
        public string @Subject { get; }

        [nterraform.Core.TerraformProperty(name: "text", @out: false, min: 0, max: 1)]
        public string @Text { get; }
    }

}

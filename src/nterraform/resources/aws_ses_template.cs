using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ses_template")]
    public sealed class aws_ses_template : nterraform.resource
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "html", @out: false, min: 0, max: 1)]
        public string @Html { get; }

        [nterraform.TerraformProperty(name: "subject", @out: false, min: 0, max: 1)]
        public string @Subject { get; }

        [nterraform.TerraformProperty(name: "text", @out: false, min: 0, max: 1)]
        public string @Text { get; }
    }

}

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace RegistrationForm.TagHelpers
{
    public class TimerTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "timer";
            output.Content.SetContent(DateTime.Now.ToString());
        }
    }
}

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beckysbookstore.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-change")]
    public class PaginationTagHelper :TagHelper
    {
        
    }
}

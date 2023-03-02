using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Bookstore.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-blah")]

    // dynamically create the page links for us
    public class PaginationTagHelpers : TagHelper
    {

    }
}


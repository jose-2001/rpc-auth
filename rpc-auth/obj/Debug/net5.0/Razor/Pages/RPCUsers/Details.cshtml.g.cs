#pragma checksum "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87c101efe7f1c255a1b94aa6e207023f48aa9299"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(rpc_auth.Pages.RPCUsers.Pages_RPCUsers_Details), @"mvc.1.0.razor-page", @"/Pages/RPCUsers/Details.cshtml")]
namespace rpc_auth.Pages.RPCUsers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\_ViewImports.cshtml"
using rpc_auth;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87c101efe7f1c255a1b94aa6e207023f48aa9299", @"/Pages/RPCUsers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2316c4ef98b1cf1a4ff181a72351cb6cdfca5414", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RPCUsers_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n");
#nullable restore
#line 9 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
 if (rpc_auth.Pages.RPCUsers.IndexModel.SignedIn)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h4>RPCUser</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 16 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.RPCUser.username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 19 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
           Write(Html.DisplayFor(model => model.RPCUser.username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 22 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.RPCUser.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 25 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
           Write(Html.DisplayFor(model => model.RPCUser.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 28 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.RPCUser.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 31 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
           Write(Html.DisplayFor(model => model.RPCUser.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 34 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.RPCUser.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 37 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
           Write(Html.DisplayFor(model => model.RPCUser.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 40 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.RPCUser.Birthdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 43 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
           Write(Html.DisplayFor(model => model.RPCUser.Birthdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c101efe7f1c255a1b94aa6e207023f48aa92998510", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
                               WriteLiteral(Model.RPCUser.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87c101efe7f1c255a1b94aa6e207023f48aa929910723", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 51 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Login pls</h1>\r\n");
#nullable restore
#line 55 "C:\Users\User\Documents\ICESI\5to semestre\Proyecto integrador\VS workspace\TallerAspDotNet06Sept\rpc-auth\Pages\RPCUsers\Details.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<rpc_auth.Pages.RPCUsers.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<rpc_auth.Pages.RPCUsers.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<rpc_auth.Pages.RPCUsers.DetailsModel>)PageContext?.ViewData;
        public rpc_auth.Pages.RPCUsers.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\mana\source\repos\WebApp1\WebApp1\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89665e1779b38f68cfbd6ee4057810eb69b609d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp1.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace WebApp1.Pages
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
#line 1 "C:\Users\mana\source\repos\WebApp1\WebApp1\Pages\_ViewImports.cshtml"
using WebApp1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89665e1779b38f68cfbd6ee4057810eb69b609d3", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d607b24827a0c29004a89eca4de0343ff91f4c8b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mana\source\repos\WebApp1\WebApp1\Pages\Index.cshtml"
  
  ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"position-relative overflow-hidden p-3 p-md-5 m-md-3 text-center bg-light\">\r\n  <div class=\"col-md-5 p-lg-5 mx-auto my-5\">\r\n    <!-- Multi-statement block -->\r\n");
#nullable restore
#line 11 "C:\Users\mana\source\repos\WebApp1\WebApp1\Pages\Index.cshtml"
      
      var txt = "";
      if (DateTime.Now.Hour > 12)
      { txt = "Good Evening"; }
      else
      { txt = "Good Morning"; }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\mana\source\repos\WebApp1\WebApp1\Pages\Index.cshtml"
      
      var greeting = "Welcome to my website!";
      var weekDay = DateTime.Now.DayOfWeek;
      var greetingMessage = greeting + " Here in Toronto it is: " + weekDay;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"display-5\"> ");
#nullable restore
#line 23 "C:\Users\mana\source\repos\WebApp1\WebApp1\Pages\Index.cshtml"
                      Write(txt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n    <h1> ");
#nullable restore
#line 25 "C:\Users\mana\source\repos\WebApp1\WebApp1\Pages\Index.cshtml"
    Write(greetingMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <a class=""btn btn-outline-secondary"" href=""#"">Coming soon</a>
  </div>
  <div class=""product-device box-shadow d-none d-md-block""></div>
  <div class=""product-device product-device-2 box-shadow d-none d-md-block""></div>
</div>

<div class=""d-md-flex flex-md-equal w-100 my-md-3 pl-md-3"">
  <div class=""bg-dark mr-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center text-white overflow-hidden"">
    <div class=""my-3 py-3"">
      <h2 class=""display-5"">Another headline</h2>
      <p class=""lead"">And an even wittier subheading.</p>
    </div>
    <div class=""bg-light box-shadow mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
  </div>
  <div class=""bg-light mr-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
    <div class=""my-3 p-3"">
      <h2 class=""display-5"">Another headline</h2>
      <p class=""lead"">And an even wittier subheading.</p>
    </div>
    <div class=""bg-dark box-shadow mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px ");
            WriteLiteral(@"0 0;""></div>
  </div>
</div>

<div class=""d-md-flex flex-md-equal w-100 my-md-3 pl-md-3"">
  <div class=""bg-light mr-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
    <div class=""my-3 p-3"">
      <h2 class=""display-5"">Another headline</h2>
      <p class=""lead"">And an even wittier subheading.</p>
    </div>
    <div class=""bg-dark box-shadow mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
  </div>
  <div class=""bg-primary mr-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center text-white overflow-hidden"">
    <div class=""my-3 py-3"">
      <h2 class=""display-5"">Another headline</h2>
      <p class=""lead"">And an even wittier subheading.</p>
    </div>
    <div class=""bg-light box-shadow mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
  </div>
</div>

<div class=""d-md-flex flex-md-equal w-100 my-md-3 pl-md-3"">
  <div class=""bg-light mr-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
    <div class=""my-3 p-3""");
            WriteLiteral(@">
      <h2 class=""display-5"">Another headline</h2>
      <p class=""lead"">And an even wittier subheading.</p>
    </div>
    <div class=""bg-white box-shadow mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
  </div>
  <div class=""bg-light mr-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden"">
    <div class=""my-3 py-3"">
      <h2 class=""display-5"">Another headline</h2>
      <p class=""lead"">And an even wittier subheading.</p>
    </div>
    <div class=""bg-white box-shadow mx-auto"" style=""width: 80%; height: 300px; border-radius: 21px 21px 0 0;""></div>
  </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

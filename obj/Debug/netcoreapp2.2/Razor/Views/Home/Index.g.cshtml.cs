#pragma checksum "C:\Users\saurav.srivastava\Desktop\HCLPaaSCOE\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6334454d46f1ce1cbab982010de2f9bb020f6710"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\saurav.srivastava\Desktop\HCLPaaSCOE\Views\_ViewImports.cshtml"
using HCLPaaSCOE;

#line default
#line hidden
#line 2 "C:\Users\saurav.srivastava\Desktop\HCLPaaSCOE\Views\_ViewImports.cshtml"
using HCLPaaSCOE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6334454d46f1ce1cbab982010de2f9bb020f6710", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e5aa054e2778ee11c071b26c11ffa08c2e182e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\saurav.srivastava\Desktop\HCLPaaSCOE\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 100, true);
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h2 class=\"display-4\">Welcome To HCLPaasCoe-AKS Demo</h2>\r\n");
            EndContext();
            BeginContext(267, 613, true);
            WriteLiteral(@"        <p><h1>Table of Contents</h1></p>
        <ul style=""list-style-type:none;"">
            <li><p>             Day1. Developemnt Using PWD and Katakoda. </p></li>
            <li><p>Day2. Moving to Managed AKS Cluster(UAT & Production). </p></li>
            <li><p> Day3. HELM Package Manager for Deployment of YAML Files. </p></li>
            <li><p> Day4. Monitoring of Cluster using Helm Package Manager. </p></li>
            <li><p>Day5. CI-CD using Azure DevOps and Jenkins.</p></li>
            <li><p> Day6. Bonus- Deployment Strategies in Kubernetes. </p></li>
        </ul>
    </div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

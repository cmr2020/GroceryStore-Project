#pragma checksum "E:\GroceryStore\GroceryStore\ServiceHost\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "506470732836e46601713b96ffbf37fd9c922f2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ServiceHost.Pages
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
#line 1 "E:\GroceryStore\GroceryStore\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"506470732836e46601713b96ffbf37fd9c922f2a", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mc-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mc-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\GroceryStore\GroceryStore\ServiceHost\Pages\Index.cshtml"
  
    ViewData["Title"] = "ریمال";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "E:\GroceryStore\GroceryStore\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("Slide"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 11 "E:\GroceryStore\GroceryStore\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("ProductCategory"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 13 "E:\GroceryStore\GroceryStore\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("ProductCategoryWithProduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "E:\GroceryStore\GroceryStore\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("LatestArrivals"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""banner-hover-area section-space"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">

                <div class=""banner-hover-wrapper"">
                    <div class=""row"">
                        <div class=""col-md-6"">

                            <div class=""single-hover-banner"">
                                <div class=""single-hover-banner__image"">
                                    <a href=""shop-left-sidebar.html"">
                                        <img src=""/Theme/assets/img/banners/img1-middle-eposi1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", "\r\n                                             alt=\"", 889, "\"", 941, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </a>
                                    <div class=""single-hover-banner__content"">
                                        <h4 class=""small-text"">Black Friday</h4>
                                        <h3 class=""big-text"">Save Up To 50% Off</h3>
                                        <a class=""banner-link"" href=""shop-left-sidebar.html"">SHOP NOW</a>
                                    </div>
                                </div>
                            </div>

                        </div>

                        <div class=""col-md-6"">

                            <div class=""single-hover-banner"">
                                <div class=""single-hover-banner__image"">
                                    <a href=""shop-left-sidebar.html"">
                                        <img src=""/Theme/assets/img/banners/img2-middle-eposi1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", "\r\n                                             alt=\"", 1873, "\"", 1925, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </a>
                                    <div class=""single-hover-banner__content"">
                                        <h4 class=""small-text"">Best Selling !</h4>
                                        <h3 class=""big-text"">Living Room Up To 70% Off</h3>
                                        <a class=""banner-link"" href=""shop-left-sidebar.html"">SHOP NOW</a>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>

<div class=""feature-logo-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">

                <div class=""feature-logo-wrapper section-space--inner-bottom"">
                    <div class=""row"">
                        <div class=""col-md-4"">

                            <div class=""single-featu");
            WriteLiteral("re-logo\">\r\n                                <div class=\"single-feature-logo__image\">\r\n                                    <img src=\"/Theme/assets/img/icons/free_shipping.png\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 3141, "\"", 3147, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""single-feature-logo__content"">
                                    <h4 class=""title"">FREE SHIPPING WORLDWIDE</h4>
                                    <p class=""short-desc"">
                                        We offer free shipping via Standard Shipping on orders
                                        over $200.00
                                    </p>
                                </div>
                            </div>

                        </div>
                        <div class=""col-md-4"">

                            <div class=""single-feature-logo"">
                                <div class=""single-feature-logo__image"">
                                    <img src=""/Theme/assets/img/icons/money_back.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 4003, "\"", 4009, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""single-feature-logo__content"">
                                    <h4 class=""title"">MONEY BACK GUARANTEE</h4>
                                    <p class=""short-desc"">
                                        If you're not satisfied with our product, we'll refund the
                                        purchase price*.
                                    </p>
                                </div>
                            </div>

                        </div>
                        <div class=""col-md-4"">

                            <div class=""single-feature-logo"">
                                <div class=""single-feature-logo__image"">
                                    <img src=""/Theme/assets/img/icons/support247.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 4870, "\"", 4876, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""single-feature-logo__content"">
                                    <h4 class=""title"">ONLINE SUPPORT 24/7</h4>
                                    <p class=""short-desc"">
                                        Our friendly support team is available to help you 24
                                        hours a day, seven days a week
                                    </p>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</div>

");
#nullable restore
#line 132 "E:\GroceryStore\GroceryStore\ServiceHost\Pages\Index.cshtml"
Write(await Component.InvokeAsync("LatestArticles"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--====================  End of blog post slider area  ====================-->
<!--====================  newsletter area ====================-->
<div class=""newsletter-area section-space--inner"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 offset-lg-2"">
                <div class=""newsletter-wrapper"">
                    <p class=""small-text"">Special Ofers For Subscribers</p>
                    <h3 class=""title"">Ten Percent Member Discount</h3>
                    <p class=""short-desc"">
                        Subscribe to our newsletters now and stay up to date with new collections,
                        the latest lookbooks and exclusive offers.
                    </p>

                    <div class=""newsletter-form"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "506470732836e46601713b96ffbf37fd9c922f2a11974", async() => {
                WriteLiteral("\r\n                            <input type=\"email\" placeholder=\"Enter Your Email Address Here...\" required>\r\n                            <button type=\"submit\" value=\"submit\">SUBSCRIBE</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    </div>
                    <!-- mailchimp-alerts Start -->
                    <div class=""mailchimp-alerts"">
                        <div class=""mailchimp-submitting""></div><!-- mailchimp-submitting end -->
                        <div class=""mailchimp-success""></div><!-- mailchimp-success end -->
                        <div class=""mailchimp-error""></div><!-- mailchimp-error end -->
                    </div>
                    <!-- mailchimp-alerts end -->
                </div>
            </div>
        </div>
    </div>
</div>
<!--====================  End of newsletter area  ====================-->
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

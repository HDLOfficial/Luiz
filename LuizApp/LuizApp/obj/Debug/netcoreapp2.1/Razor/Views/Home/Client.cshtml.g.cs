#pragma checksum "C:\Users\djree\source\repos\Luiz\LuizApp\LuizApp\Views\Home\Client.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3323abb00039c69cd08414901ae587bfcf16b159"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Client), @"mvc.1.0.view", @"/Views/Home/Client.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Client.cshtml", typeof(AspNetCore.Views_Home_Client))]
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
#line 1 "C:\Users\djree\source\repos\Luiz\LuizApp\LuizApp\Views\_ViewImports.cshtml"
using LuizApp;

#line default
#line hidden
#line 2 "C:\Users\djree\source\repos\Luiz\LuizApp\LuizApp\Views\_ViewImports.cshtml"
using LuizApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3323abb00039c69cd08414901ae587bfcf16b159", @"/Views/Home/Client.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e24ec20d155bf4a7d8815432c69aa798990b8eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Client : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#EEEEEE"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("answerstatus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\djree\source\repos\Luiz\LuizApp\LuizApp\Views\Home\Client.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 1352, true);
            WriteLiteral(@"<style>
    .*{
        margin:0px;
    }
    .answerbutton{
        width:100%;
        height:100%;
        font-size:200px;
        font-weight:900;
        color:white;
        border:0px solid #EEEEEE
    }
    .answerbutton:hover{
        filter: brightness(85%);
    }
    .answerbutton:active{
        filter: brightness(60%);
    }
    .fullscreendiv{
        padding:30px;
    }
    .smallstatusicons {
        height: 50px;
        width: 50px;
        background-color:lightblue;
        border-radius: 50%;
        display: inline-block;
        border:4px solid gray
    }
    .body{
        padding:0;
        margin:0;
    }
</style>
<nav class=""navbar navbar-inverse navbar-fixed-top"" style=""background-color:deepskyblue;border:none"">
    <div class=""container"" style=""text-align:center"">
        <span style=""font-weight:800;text-align:left;color:white;padding:10px;font-size:40px;float:left"">Luiz</span>
        <span id=""currentscore""style=""background-color:black;col");
            WriteLiteral(@"or:white;padding:5px;font-size:30px;font-weight:600;border-radius:4px;float:right;margin-top:10px"">0000000</span>
        <span id=""currentstreak"" style=""background-color:orange;color:white;padding:5px;font-size:30px;font-weight:600;border-radius:4px;float:right;margin-top:10px;margin-right:5px"">0</span>
    </div>
</nav>
");
            EndContext();
            BeginContext(1395, 1772, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "202fa9f5fd32401ba83fb9cdb08dbda5", async() => {
                BeginContext(1452, 1708, true);
                WriteLiteral(@"
    <div class=""fullscreendiv"" id=""fullscreenthis"" style=""margin:0"">
        <div id=""question"" hidden style=""margin:0"">
            <table style=""width:100%;height:80vh"">
                <tr>
                    <td style=""width:25%;padding-bottom:5px"">
                        <input type=""button"" class=""answer answerbutton"" id=""a1"" value=""1"" style=""background-color:#42c5f5"" />
                    </td>
                    <td style=""width:25%;padding-left:5px;padding-bottom:5px"">
                        <input type=""button"" class=""answer answerbutton"" id=""a2"" value=""2"" style=""background-color:#f54284"" />
                    </td>
                </tr>
                <tr>
                    <td style=""width:25%"">
                        <input type=""button"" class=""answer answerbutton"" id=""a3"" value=""3"" style=""background-color:#3ce663"" />
                    </td>
                    <td style=""width:25%;padding-left:5px"">
                        <input type=""button"" class=""answer answerbu");
                WriteLiteral(@"tton"" id=""a4"" value=""4"" style=""background-color:#e6c73c"" />
                    </td>
                </tr>
            </table>
            <div style=""margin-top:15px;text-align:center"" id=""userinfo"">
                <span >0008888</span>
            </div>
        </div>
        <div id=""login"" style=""margin:0"">
            <input type=""text"" placeholder=""Username"" id=""usernametouse""/>
            <input type=""button"" value=""Submit"" id=""logintoserver""/>
        </div>
        <div id=""waitingothers"" style=""margin:0"" hidden>
            
        </div>
        <div id=""youranswer"" style=""margin:0"" hidden>
            w
        </div>
    

    </div>  
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3167, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(3171, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4ede4d01b9f4469b6b64e9fea9d7adb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3232, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3234, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a88eb4595964e8ab3467a5520ca22db", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3285, 3901, true);
            WriteLiteral(@"
<script>
    $('#toggle_fullscreen').on('click', function () {
        // if already full screen; exit
        // else go fullscreen
        if (
            document.fullscreenElement ||
            document.webkitFullscreenElement ||
            document.mozFullScreenElement ||
            document.msFullscreenElement
        ) {
            if (document.exitFullscreen) {
                document.exitFullscreen();
            } else if (document.mozCancelFullScreen) {
                document.mozCancelFullScreen();
            } else if (document.webkitExitFullscreen) {
                document.webkitExitFullscreen();
            } else if (document.msExitFullscreen) {
                document.msExitFullscreen();
            }
        } else {
            element = $('#fullscreenthis').get(0);
            if (element.requestFullscreen) {
                element.requestFullscreen();
            } else if (element.mozRequestFullScreen) {
                element.mozRequestFullScreen();
            } else if");
            WriteLiteral(@" (element.webkitRequestFullscreen) {
                element.webkitRequestFullscreen(Element.ALLOW_KEYBOARD_INPUT);
            } else if (element.msRequestFullscreen) {
                element.msRequestFullscreen();
            }
            
        }
    });
</script>
<script>
    
    function UUIDGenerate() {
        return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function(c) {
            var r = Math.random()*16|0, v = c == 'x' ? r : (r&0x3|0x8);
            return v.toString(16);
        });
    }
    var quiz = new signalR.HubConnectionBuilder().withUrl(""/quizHub"").build();
    var userID = """";
    var userName = ""anon"";
    var currentscore = 0;
    var currentstreak = 0;
    var correct = false;
    currentanswer = 0;
    $(document).ready(function () {
        userID = UUIDGenerate();
    });
    quiz.on(""toggleScore"", function (ReviewScore) {

    });
    quiz.on(""signedIn"", function () {
        $(""#question"").attr(""hidden"", false);
        $(""#login"").att");
            WriteLiteral(@"r(""hidden"", true);
    });
    quiz.on(""answerStatus"", function (Score, Correct, Streak) {
        
        if (Correct == true) {
            correct = true;
        }
        
    });
    quiz.on(""clientScoreSend"", function (Score, Streak) {
        currentscore = Score;
        currentstreak = Streak;
        $(""#currentstreak"").html(currentstreak);
        $(""#currentscore"").html(currentscore);
        if (correct == true) {
            $(""#youranswer"").css(""background-color"", ""MediumSeaGreen"")
            $(""#answerstatus"").css(""background-color"", ""MediumSeaGreen"")
        } else {
            $(""#youranswer"").css(""background-color"", ""Tomato"")
            $(""#answerstatus"").css(""background-color"", ""Tomato"")
        }
        correct = false;
        $(""#question"").attr(""hidden"", true);
        $(""#login"").attr(""hidden"", true);
        $(""#waitingothers"").attr(""hidden"", true);
        $(""#youranswer"").attr(""hidden"", false);
    });
    quiz.on(""nextQuestion"", function () {
    ");
            WriteLiteral(@"    $(""#question"").attr(""hidden"", false);
        $(""#login"").attr(""hidden"", true);
        $(""#waitingothers"").attr(""hidden"", true);
        $(""#youranswer"").attr(""hidden"", true);
        $(""#answerstatus"").css(""background-color"", ""#EEEEEE"");
    });
    quiz.start().then(function () {
        $(""#logintoserver"").click(function () {
            userName = $(""#usernametouse"").val();
            quiz.invoke(""connectToServer"", userID, userName, true)
        }); 
        $("".answerbutton"").click(function () {
            
            currentanswer = $(this).val();
            quiz.invoke(""answerQuestion"", userID, currentanswer);
            $(""#question"").attr(""hidden"", true);
            $(""#login"").attr(""hidden"", true);
            $(""#waitingothers"").attr(""hidden"", false);
        });
    });
</script>");
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

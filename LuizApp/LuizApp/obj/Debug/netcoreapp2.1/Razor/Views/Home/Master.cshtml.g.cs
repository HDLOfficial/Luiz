#pragma checksum "/Users/daviado/Downloads/Luiz/LuizApp/LuizApp/Views/Home/Master.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "219ddac5eec57dad45ebdd8ac548b29ea269a54c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Master), @"mvc.1.0.view", @"/Views/Home/Master.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Master.cshtml", typeof(AspNetCore.Views_Home_Master))]
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
#line 1 "/Users/daviado/Downloads/Luiz/LuizApp/LuizApp/Views/_ViewImports.cshtml"
using LuizApp;

#line default
#line hidden
#line 2 "/Users/daviado/Downloads/Luiz/LuizApp/LuizApp/Views/_ViewImports.cshtml"
using LuizApp.Models;

#line default
#line hidden
#line 1 "/Users/daviado/Downloads/Luiz/LuizApp/LuizApp/Views/Home/Master.cshtml"
using System.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"219ddac5eec57dad45ebdd8ac548b29ea269a54c", @"/Views/Home/Master.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"439698069bbdf602bab9e3246ba330095c6c95da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Master : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Question>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/daviado/Downloads/Luiz/LuizApp/LuizApp/Views/Home/Master.cshtml"
  
    ViewData["Title"] = "Master";

#line default
#line hidden
            BeginContext(84, 2583, true);
            WriteLiteral(@"<style>

    .* {
        margin: 0px;
    }

    .answerbutton {
        width: 100%;
        height: 100%;
        font-size: 200px;
        font-weight: 900;
        color: white;
        border: 0px solid #EEEEEE
    }

        .answerbutton:hover {
            filter: brightness(85%);
        }

        .answerbutton:active {
            filter: brightness(60%);
        }

    .fullscreendiv {
        background-color: #EEEEEE;
        padding: 30px;
        display: none;
    }

        .fullscreendiv:fullscreen {
            display: inline;
        }

    .smallstatusicons {
        height: 50px;
        width: 50px;
        background-color: lightblue;
        border-radius: 50%;
        display: inline-block;
        border: 4px solid gray
    }

    .rank1leaderboard {
        background: rgb(0,2,177);
        background: linear-gradient(145deg, rgba(0,2,177,1) 0%, rgba(0,191,255,1) 100%);
    }

    .rank23leaderboard {
        background: rgb(0,191,");
            WriteLiteral(@"255);
        width:100%;
        padding:15px;
        margin-bottom:10px;
        border-radius:8px;
    }

    .rank4567leaderboard {
        background: rgb(0,191,255);
    }
    .hidethisbar{
        display:none;
        height:2px;
    }
    .infobox{
        background:rgba(0,0,0,0.5);
    }
    .powerorb {
        background: rgb(0,255,207);
        background: linear-gradient(161deg, rgba(0,255,207,1) 0%, rgba(16,111,236,1) 100%);
        height: 20px;
        width: 20px;
        border-radius: 50%;
        display: inline-block;
    }
    .correctmarker {
        background-color: green;
        height: 20px;
        width: 20px;
        border-radius: 50%;
        display: inline-block;
    }
    .progressbar{
        transition: width 1s, background-color 1s;
    }
    .footer {
        position: fixed;
        left: 0;
        bottom: 0;
        width: 100%;
        text-align: center;
    }
    .name {
        position: relative;
        display: inl");
            WriteLiteral(@"ine-block;
        text-align:left;
        width: 75%;
        line-height: 45px;
        color:white;
        font-size:40px;
        font-weight:600;
    }

    .score {
        position: relative;
        display: inline-block;
        text-align: right;
        width: 25%;
        color: white;
        font-size: 40px;
        font-weight: 600;
    }
    .container{
        border-collapse:separate;
        border-spacing:10px 0px;
    }
    .screen{
        transition: display 2s;
    }
</style>

");
            EndContext();
#line 125 "/Users/daviado/Downloads/Luiz/LuizApp/LuizApp/Views/Home/Master.cshtml"
  
    string questionlist = "";

#line default
#line hidden
#line 128 "/Users/daviado/Downloads/Luiz/LuizApp/LuizApp/Views/Home/Master.cshtml"
 foreach (var question in Model.Take(1))
{
    questionlist = questionlist + question.QuestionID.ToString();
}

#line default
#line hidden
#line 132 "/Users/daviado/Downloads/Luiz/LuizApp/LuizApp/Views/Home/Master.cshtml"
 foreach (var question in Model.Skip(1))
{
    questionlist = questionlist + "," + question.QuestionID.ToString();
}

#line default
#line hidden
            BeginContext(2941, 8624, true);
            WriteLiteral(@" <!--https://jsfiddle.net/AntonTrollback/nqQc7/-->
<div style=""margin-top:20px"">
    <div id=""loginscreen"" style=""text-align:center"" class=""screen"">
        <div style=""background-color:#03b1fc;font-size:60px;font-weight:600;padding:10px;border-radius:10px;color:white;display:flex;justify-content:space-between"">
            <div>
                Game Key: <br /><span id=""gamecode"" style=""color:#03b1fc;background-color:white;padding:10px;border-radius:8px;font-size:90px"">[UNAVAIL]</span><span id=""gameerror"" style=""margin-left:10px"">&#9888;</span>
            </div>
            <div>
                Contestants: <br /><span id=""numplayers"" style=""color:#00ed7a;background-color:white;padding:10px;border-radius:8px;font-size:90px"">0</span>
            </div>
        </div>
        <span id=""questiontest""></span>
        <input type=""button"" id=""startgame"" value=""GO!"" />
    </div>

    <div id=""questionp"" style=""display:none"">
        <table style=""position: absolute; top: 0; bottom: 0; left: 0; r");
            WriteLiteral(@"ight: 0;width:100%"">
            <tr>
                <td style=""width:10%;overflow:hidden;background-color:white;border:4px solid lightgray;border-radius:6px 0px 0px 6px"">
                    <span style=""font-weight:900;font-size:50px;text-align:center;margin-left:40px;color:gray"">Q</span>
                </td>
                <td style=""width:90%;text-wrap:inherit;padding:30px;background-color:lightgray;border:4px solid lightgray;border-radius:0px 6px 6px 0px"">
                    <span style=""font-size:30px;vertical-align:text-bottom;font-family:Georgia, 'Times New Roman', Times, serif"" id=""qsquestion"">What is 1 + 1?</span>
                </td>
            </tr>
        </table>
        <table style=""width:100%;border-spacing:0 15px;border-collapse:separate;margin-top:15vh"">

            <tr>
                <td style=""width:10%;overflow:hidden;background-color:white;border:4px solid #42c5f5;border-radius:6px 0px 0px 6px"">
                    <span style=""font-weight:900;font-size:50px;text");
            WriteLiteral(@"-align:center;margin-left:40px;color:#42c5f5"">1</span>
                </td>
                <td style=""width:90%;text-wrap:inherit;padding:30px;background-color:#42c5f5;border:4px solid #42c5f5;border-radius:0px 6px 6px 0px"">
                    <span style=""font-size:30px;vertical-align:text-bottom;font-family:Georgia, 'Times New Roman', Times, serif"" id=""qsa1"">1</span>
                </td>
            </tr>
            <tr>
                <td style=""width:10%;overflow:hidden;background-color:white;border:4px solid #f54284;border-radius:6px 0px 0px 6px"">
                    <span style=""font-weight:900;font-size:50px;text-align:center;margin-left:40px;color:#f54284"">2</span>
                </td>
                <td style=""width:90%;text-wrap:inherit;padding:30px;background-color:#f54284;border:4px solid #f54284;border-radius:0px 6px 6px 0px"">
                    <span style=""font-size:30px;vertical-align:text-bottom;font-family:Georgia, 'Times New Roman', Times, serif"" id=""qsa2"">2</span>
    ");
            WriteLiteral(@"            </td>
            </tr>
            <tr>
                <td style=""width:10%;overflow:hidden;background-color:white;border:4px solid #3ce663;border-radius:6px 0px 0px 6px"">
                    <span style=""font-weight:900;font-size:50px;text-align:center;margin-left:40px;color:#3ce663"">3</span>
                </td>
                <td style=""width:90%;text-wrap:inherit;padding:30px;background-color:#3ce663;border:4px solid #3ce663;border-radius:0px 6px 6px 0px"">
                    <span style=""font-size:30px;vertical-align:text-bottom;font-family:Georgia, 'Times New Roman', Times, serif"" id=""qsa3"">5</span>
                </td>
            </tr>
            <tr>
                <td style=""width:10%;overflow:hidden;background-color:white;border:4px solid #e6c73c;border-radius:6px 0px 0px 6px"">
                    <span style=""font-weight:900;font-size:50px;text-align:center;margin-left:40px;color:#e6c73c"">4</span>
                </td>
                <td style=""width:90%;text-wrap");
            WriteLiteral(@":inherit;padding:30px;background-color:#e6c73c;border:4px solid #e6c73c;border-radius:0px 6px 6px 0px"">
                    <span style=""font-size:30px;vertical-align:text-bottom;font-family:Georgia, 'Times New Roman', Times, serif"" id=""qsa4"">The answer is triangle!</span>
                </td>
            </tr>
        </table>
        <input type=""button"" id=""checkanswer"" value=""Check Answer""/>
        <div style=""text-align:center"">
            <span id=""secondsleft"" style=""text-align:center;padding:10px;font-size:30px;background-color:#03b1fc;color:white""></span>
        </div>

    </div>
    <div id=""resultsp"" style=""display:none"">
        <div style=""text-align:center"">
            <div style=""background-color:green;color:white;padding:10px;border-radius:8px 8px 0px 0px"">
                <span style=""font-size:80px""><span id=""numcorrect"" class=""resultnumbers"" style=""font-weight:700"">0</span>%</span>
            </div>

        </div>
        <table style=""width:100%;font-size:70px;tex");
            WriteLiteral(@"t-align:center;font-weight:600"">
            <tr>
                <td style=""width:25%;margin-right:10px;background-color:#cccccc;color:white"" class=""num1c"">
                    #1 <span id=""num1"" style=""background-color:white;color:#cccccc;padding-left:5px;padding-right:5px;border-radius:6px"">0</span>
                </td>
                <td style=""width:25%;margin-right:10px;background-color:#cccccc;color:white"" class=""num2c"">
                    #2 <span id=""num2"" style=""background-color:white;color:#cccccc;padding-left:5px;padding-right:5px;border-radius:6px"">0</span>
                </td>
                <td style=""width:25%;margin-right:10px;background-color:green;color:white"" class=""num3c"">
                    #3 <span id=""num3"" style=""background-color:white;color:green;padding-left:5px;padding-right:5px;border-radius:6px"">0</span>
                </td>
                <td style=""width:25%;margin-right:10px;background-color:#cccccc;color:white"" class=""num4c"">
                    #4 <span i");
            WriteLiteral(@"d=""num4"" style=""background-color:white;color:#cccccc;padding-left:5px;padding-right:5px;border-radius:6px"">0</span>
                </td>
            </tr>
        </table>

        <input type=""button"" id=""leaderboard"" value=""Leaderboard"" />
    </div>
    <div id=""leaderboardp"" style=""display:none;text-align:center"">
        <div class=""container"">
          <div class=""rank23leaderboard"" id=""r1"">
            <div class=""name"" id=""r1user"">Player1</div><div class=""score"" id=""r1pts"">430</div>
          </div>

          <div class=""rank23leaderboard"" id=""r2"">
            <div class=""name"" id=""r2user"">Player2</div><div class=""score"" id=""r2pts"">580</div>
          </div>

          <div class=""rank23leaderboard"" id=""r3"">
            <div class=""name"" id=""r3user"">Player3</div><div class=""score"" id=""r3pts"">310</div>
          </div>

          <div class=""rank23leaderboard"" id=""r4"">
            <div class=""name"" id=""r4user"">Player4</div><div class=""score"" id=""r4pts"">640</div>
          </di");
            WriteLiteral(@"v>

          <div class=""rank23leaderboard"" id=""r5"">
            <div class=""name"" id=""r5user"">Player5</div><div class=""score"" id=""r5pts"">495</div>
          </div>

          <div class=""rank23leaderboard"" id=""r6"">
            <div class=""name"" id=""r6user"">Player6</div><div class=""score"" id=""r6pts"">495</div>
          </div>

          <div class=""rank23leaderboard"" id=""r7"">
            <div class=""name"" id=""r7user"">Player7</div><div class=""score"" id=""r7pts"">495</div>
          </div>
        </div>
        <input type=""button"" id=""next"" value=""Next Question"" />
    </div>
</div>
<div style=""background-color:#03b1fc;border:none"" class=""footer"">
    <div class=""container"" style=""text-align:center;margin-top:10px"">
        <div style=""color:white;padding:10px;border-radius:4px;width:20%;margin:auto;margin-bottom:5px"" class=""infobox"">
            <span id=""iconib"" style=""font-size:17px""><span class=""powerorb""></span></span>
            <span style=""font-size:25px;font-weight:600"" id=""messa");
            WriteLiteral(@"geib"">0</span>
        </div>
        <div style=""border:3px solid #03b1fc;border-radius:20px;margin-bottom:10px"">
            <div style=""width:100%;height:30px;border:5px solid white;border-radius:20px;background-color:white"">
                <div style=""width:50%;background-color:#03b1fc;height:20px;border-radius:20px"" class=""progressbar""></div>
            </div>
        </div>
        
        
    </div>
</div>
");
            EndContext();
            BeginContext(11565, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85493f6ccf824460b1a253fe4a97964a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11626, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(11628, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3e055b59b3e4ae1bb7cdbd71afbe930", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11679, 1555, true);
            WriteLiteral(@"
<script>$('#toggle_fullscreen').on('click', function () {
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
   ");
            WriteLiteral(@"         } else if (element.webkitRequestFullscreen) {
                element.webkitRequestFullscreen(Element.ALLOW_KEYBOARD_INPUT);
            } else if (element.msRequestFullscreen) {
                element.msRequestFullscreen();
            }

        }
    });</script>
<script>
    var GameKey = 0;
    var CurrentCorrect = 1;
    var Timer = 0;
    var InitialTimer = 0;
    var QuestionEnabled = true;
    var quiz = new signalR.HubConnectionBuilder().withUrl(""/quizHub"").build();
    var QuestionsList = [");
            EndContext();
            BeginContext(13235, 12, false);
#line 318 "/Users/daviado/Downloads/Luiz/LuizApp/LuizApp/Views/Home/Master.cshtml"
                    Write(questionlist);

#line default
#line hidden
            EndContext();
            BeginContext(13247, 8067, true);
            WriteLiteral(@"];
    var QuestionIndex = 0;
    var numQuestions = QuestionsList.length;
    var PercentCorrect = 0.0;
    quiz.on(""questionResults"", function (Correct, Wrong, Num1, Num2, Num3, Num4) {
        $(""#numcorrect"").html(Correct);
        $(""#numwrong"").html(Wrong);
        $(""#num1"").html(Num1);
        $(""#num2"").html(Num2);
        $(""#num3"").html(Num3);
        $(""#num4"").html(Num4);
        var totalanswers = Num1 + Num2 + Num3 + Num4
        if (totalanswers == 0) {
            totalanswers = 1
        }
        num1percent = ((Num1 / totalanswers)*90)
        num2percent = ((Num2 / totalanswers)*90)
        num3percent = ((Num3 / totalanswers)*90)
        num4percent = ((Num4 / totalanswers) * 90)
        $(""#num1c"").css(""width"", num1percent + ""%"")
        $(""#num2c"").css(""width"", num2percent + ""%"")
        $(""#num3c"").css(""width"", num3percent + ""%"")
        $(""#num4c"").css(""width"", num4percent + ""%"")
        $(""#num1w"").css(""width"", (90-num1percent) + ""%"")
        $(""#num2w"").css(");
            WriteLiteral(@"""width"", (90-num2percent) + ""%"")
        $(""#num3w"").css(""width"", (90-num3percent) + ""%"")
        $(""#num4w"").css(""width"", (90 - num4percent) + ""%"")
        $(""#num1c"").css(""background-color"", ""gray"")
        $(""#num2c"").css(""background-color"", ""gray"")
        $(""#num3c"").css(""background-color"", ""gray"")
        $(""#num4c"").css(""background-color"", ""gray"")
        $(""#num1l"").css(""color"", ""gray"")
        $(""#num2l"").css(""color"", ""gray"")
        $(""#num3l"").css(""color"", ""gray"")
        $(""#num4l"").css(""color"", ""gray"")
        $(""#num"" + CurrentCorrect + ""c"").css(""background-color"", ""green"")
        $(""#num"" + CurrentCorrect + ""l"").css(""color"", ""green"")
        $(""#iconib"").html(""<span class='correctmarker'>&#x2713;</span>"");
        if ((Correct + Wrong) == 0) {
            Wrong = 1
        }
        $(""#messageib"").html((Correct / (Correct + Wrong)) * 100 + ""%"");
        $("".progressbar"").css(""width"", (Correct / (Correct + Wrong)) * 100 + ""%"")
        $("".progressbar"").css(""background-color"",");
            WriteLiteral(@" ""green"")
        PercentCorrect = (Correct / (Correct + Wrong))

    });
    quiz.on(""sendLeaderboard"", function (TopTen, PowerPoints) {
        rankings = TopTen.length;
        $(""#messageib"").html(PowerPoints);
        if (rankings > 0) {
            $(""#r1"").css(""display"",""block"")
            $(""#r1user"").text(TopTen[0].userName);
            $(""#r1pts"").text(TopTen[0].points);
        } else {
            $(""#r1"").css(""display"",""none"")
        }
        if (rankings > 1) {
            $(""#r2"").css(""display"",""block"")
            $(""#r2user"").text(TopTen[1].userName);
            $(""#r2pts"").text(TopTen[1].points);
        } else {
            $(""#r2"").css(""display"",""none"")
        }
        if (rankings > 2) {
            $(""#r3"").css(""display"",""block"")
            $(""#r3user"").text(TopTen[2].userName);
            $(""#r3pts"").text(TopTen[2].points);
        } else {
            $(""#r3"").css(""display"",""none"")
        }
        if (rankings > 3) {
            $(""#r4"").css(""dis");
            WriteLiteral(@"play"",""block"")
            $(""#r4user"").text(TopTen[3].userName);
            $(""#r4pts"").text(TopTen[3].points);
        } else {
            $(""#r4"").css(""display"",""none"")
        }
        if (rankings > 4) {
            $(""#r5"").css(""display"",""block"")
            $(""#r5user"").text(TopTen[4].userName);
            $(""#r5pts"").text(TopTen[4].points);
        } else {
            $(""#r5"").css(""display"",""none"")
        }
        if (rankings > 5) {
            $(""#r6"").css(""display"",""block"")
            $(""#r6user"").text(TopTen[5].userName);
            $(""#r6pts"").text(TopTen[5].points);
        } else {
            $(""#r6"").css(""display"",""none"")
        }
        if (rankings > 6) {
            $(""#r7"").css(""display"",""block"")
            $(""#r7user"").text(TopTen[6].userName);
            $(""#r7pts"").text(TopTen[6].points);
        } else {
            $(""#r7"").css(""display"",""none"")
        }
        
    });

    quiz.start().then(function () {
        quiz.on(""questionLoaded""");
            WriteLiteral(@", function (QuestionLoaded) {
            $(""#questiontest"").html(QuestionLoaded.correctAnswer);
            var i = 0
            $(""#questionp"").css(""display"", ""inline"");
            $(""#resultsp"").css(""display"", ""none"");
            $(""#leaderboardp"").css(""display"", ""none"");
            quiz.invoke(""nextQuestion"");
            InitialTimer = 30;
            Timer = 30;
            quiz.invoke(""setTimer"", Timer);
            $(""#iconib"").html("""");
            $(""#messageib"").html(Timer + "" seconds"")
            $("".progressbar"").css(""background-color"", ""#03b1fc"")
            $("".progressbar"").css(""width"", ""100%"")
            $(""#secondsleft"").html(Timer)
            setTimeout(Countdown, 1000);
            QuestionEnabled = true;
        });
        $(document).ready(function () {
            GameKey = Math.floor((Math.random() * 1000000) + 1);
            quiz.invoke(""instanceCreate"", GameKey);
        });
        $(""#checkanswer"").click(function () {
            ShowResults(CurrentC");
            WriteLiteral(@"orrect);
            QuestionEnabled = false;
        });
        $(""#next"").click(function () {
            ShowQuestion();
        });
        $(""#leaderboard"").click(function () {
            ShowLeaderboard();
        });
        $(""#startgame"").click(function () {
            $(""#loginscreen"").css(""display"", ""none"")
            ShowQuestion();
        });
        quiz.on(""gameCreated"", function (Successful, GameKeySent) {
            if (!Successful) {
                GameKey = Math.floor((Math.random() * 1000000) + 1);
                quiz.invoke(""instanceCreate"", GameKey);
                $(""#gameerror"").css(""background-color"", ""red"")
            } else {
                $(""#gamecode"").html(GameKeySent)
                $(""#gameerror"").css(""display"",""none"")
            }
        });
        quiz.on(""questionLoaded"", function (QuestionLoaded) {
            $(""#qsquestion"").html(QuestionLoaded.questionName);
            $(""#qsa1"").html(QuestionLoaded.question1);
            $(""#q");
            WriteLiteral(@"sa2"").html(QuestionLoaded.question2);
            $(""#qsa3"").html(QuestionLoaded.question3);
            $(""#qsa4"").html(QuestionLoaded.question4);
            CurrentCorrect = QuestionLoaded.correctAnswer;
        });
        function ShowQuestion() {
            QuestionReveal()
        }
        function QuestionReveal() {
            quiz.invoke(""loadQuestion"", QuestionsList[QuestionIndex]);
            QuestionIndex += 1

        }
        function ShowResults(CorrectAnswer) {
            quiz.invoke(""nextQuestion"");
            quiz.invoke(""checkAnswers"", CorrectAnswer);
            quiz.invoke(""viewToggle"", true);
            CurrentCorrect = CorrectAnswer;
            QuestionEnabled = false;
            $(""#questionp"").css(""display"", ""none"");
            $(""#resultsp"").css(""display"", ""inline"");
            $(""#leaderboardp"").css(""display"", ""none"");



        }
        function ShowLeaderboard() {
            $(""#questionp"").css(""display"", ""none"");
            $(""#resultsp");
            WriteLiteral(@""").css(""display"", ""none"");
            $(""#leaderboardp"").css(""display"", ""inline"");
            quiz.invoke(""getLeaderboard"");
            $(""#iconib"").html(""<span class='powerorb'></span>"");
            $(""#messageib"").html(""0"");

        }
        function Countdown() {
            Timer = Timer - 1;
            if (Timer > 0 && QuestionEnabled == true) {
                $("".progressbar"").css(""width"", (Timer / InitialTimer) * 100 + ""%"")
                quiz.invoke(""setTimer"", Timer);
                setTimeout(Countdown, 1000);
                $(""#secondsleft"").html(Timer)
                $(""#iconib"").html("""");
                $(""#messageib"").html(Timer + "" seconds"")
            } else {
                if (QuestionEnabled == true) {
                    ShowResults(CurrentCorrect)
                }
                
            }

        }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591

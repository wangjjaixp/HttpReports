﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HttpReports.Dashboard.Views
{
    using System;
    
    #line 3 "..\..\Views\HttpReports\Trend.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class Trend : HttpReports.Dashboard.Views.RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");




            
            #line 4 "..\..\Views\HttpReports\Trend.cshtml"
  
    ViewData["Title"] = "Trend"; 

    var lang = ViewData["Language"] as HttpReports.Dashboard.Services.Localize;

    Layout = new HttpReports.Dashboard.Views.HttpReportsTemplate { Context = Context, ViewData = ViewData };



            
            #line default
            #line hidden
WriteLiteral(@"

<div class=""panel panel-default"">

    <div class=""panel-body"" style=""padding-left:30px;padding-right:30px;padding-top:30px;min-height:720px"">

        <div class=""row"" style=""padding-left:13px;padding-right:13px"">

            <div class=""panel panel-default"">
                <div class=""panel-body shadow-box"" style=""padding-bottom:20px"">

                    <div class=""form-inline form"">

                        <div class=""col-sm-12 form-inline form service-form"">

                            <div class=""col-sm-3"" style=""padding-left:0"">
                                <label class=""form-label""><i class=""fa fa-paper-plane"" style=""margin-right:8px;margin-left:2px""></i>");


            
            #line 28 "..\..\Views\HttpReports\Trend.cshtml"
                                                                                                                               Write(lang.ServiceTag);

            
            #line default
            #line hidden
WriteLiteral(@"</label>
                                <select class=""selectpicker service"" data-live-search=""true"" data-style=""btn-primary"" data-width=""220px"">
                                    <option>ALL</option>
                                </select>

                            </div>

                            <div class=""col-sm-3"">
                                <label class=""form-label""><i class=""fa fa-desktop"" style=""margin-right:8px;margin-left:2px""></i>");


            
            #line 36 "..\..\Views\HttpReports\Trend.cshtml"
                                                                                                                           Write(lang.InstanceTag);

            
            #line default
            #line hidden
WriteLiteral(@"</label>
                                <select class=""selectpicker instance"" data-live-search=""true"" data-style=""btn-primary"" data-width=""220px"">
                                    <option>ALL</option>
                                </select>
                            </div>

                        </div>

                    </div>

                    <div class=""col-sm-12"" style="""">

                        <div class=""col-sm-3"" style=""padding-left:0"">

                            <button style=""min-width:120px;"" onclick=""QueryClick(this)"" class=""btn btn-info  btn-search"">");


            
            #line 50 "..\..\Views\HttpReports\Trend.cshtml"
                                                                                                                    Write(lang.Query);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                        </div>\r\n                    </div>\r\n          " +
"      </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n\r" +
"\n            <div class=\"col-md-12\">\r\n\r\n                <div class=\"panel panel-" +
"default\">\r\n                    <div class=\"panel-body shadow-box\" style=\"padding" +
"-top:20px;padding-bottom:14px\">\r\n\r\n                        <div class=\"col-sm-12" +
"\">\r\n                            <div id=\"MinuteStateTimesBar\" style=\"height:300p" +
"x\"></div>\r\n                        </div>\r\n\r\n                        <div class=" +
"\"col-sm-12\" style=\"margin-top:12px\">\r\n                            <div id=\"Minut" +
"eStateAvgBar\" style=\"height:300px\"></div>\r\n                        </div>\r\n     " +
"               </div>\r\n                </div>\r\n            </div>\r\n        </div" +
">\r\n\r\n        <div class=\"row\">\r\n\r\n            <div class=\"col-md-12\">\r\n\r\n       " +
"         <div class=\"panel panel-default\">\r\n                    <div class=\"pane" +
"l-body shadow-box\" style=\"padding-top:20px;padding-bottom:14px\">\r\n\r\n            " +
"            <div class=\"col-sm-12\">\r\n                            <div id=\"DaySta" +
"teTimesBar\" style=\"height:300px\"></div>\r\n                        </div>\r\n\r\n     " +
"                   <div class=\"col-sm-12\" style=\"margin-top:12px\">\r\n            " +
"                <div id=\"DayStateAvgBar\" style=\"height:300px\"></div>\r\n          " +
"              </div>\r\n                    </div>\r\n                </div>\r\n      " +
"      </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n\r\n            <div cl" +
"ass=\"col-md-12\">\r\n\r\n                <div class=\"panel panel-default\">\r\n         " +
"           <div class=\"panel-body shadow-box\">\r\n\r\n                        <div c" +
"lass=\"col-sm-12\">\r\n\r\n                            <div id=\"LatelyDayChart\" style=" +
"\"height:360px\"></div>\r\n                        </div>\r\n                    </div" +
">\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</d" +
"iv>\r\n\r\n<script src=\"/HttpReportsStaticFiles/Content/page/trend.js?ver=1.0.6\"></s" +
"cript>\r\n");


        }
    }
}
#pragma warning restore 1591

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
    
    #line 3 "..\..\Views\HttpReports\Trace.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class Trace : HttpReports.Dashboard.Views.RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");




            
            #line 4 "..\..\Views\HttpReports\Trace.cshtml"
  
    ViewData["Title"] = "Trace";

    var lang = ViewData["Language"] as HttpReports.Dashboard.Services.Localize;

    Layout = new HttpReports.Dashboard.Views.HttpReportsTemplate { Context = Context, ViewData = ViewData };



            
            #line default
            #line hidden
WriteLiteral(@"
<script src=""/HttpReportsStaticFiles/Content/js/mSlider.min.js""></script>
<script src=""/HttpReportsStaticFiles/Content/js/jquery.nicescroll.js""></script>

<div class=""panel panel-default"">

    <div class=""panel-body request-trace"" style=""padding-left:30px;padding-right:30px;padding-top:30px;min-height:720px;padding-bottom:30px"">

        <div class=""request-tree""></div>

    </div>
</div>

<div class=""contextBox"" style=""display:none;"">

    <h3 class=""request_detail_notfound"" style=""display:none"">");


            
            #line 27 "..\..\Views\HttpReports\Trace.cshtml"
                                                        Write(lang.Request_NotFound);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n    <h3 class=\"request_detail_title\" style=\"padding-left:6px;margin-bott" +
"om:16px\"><i class=\"fa fa-star-half-o\" style=\"margin-right:10px\"></i>  ");


            
            #line 29 "..\..\Views\HttpReports\Trace.cshtml"
                                                                                                                                         Write(lang.Request_BasicInfo);

            
            #line default
            #line hidden
WriteLiteral(@"</h3>

    <table class=""table table-striped table-bordered"" style=""word-break:break-all"">
        <thead>
            <tr>
                <th width=""160"">Key</th>
                <th>Value</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>RequestId</td>
                <td class=""context_requestId"" style=""text-align:left;font-size:12px;padding-left:8px""></td>
            </tr>
            <tr>
                <td>");


            
            #line 44 "..\..\Views\HttpReports\Trace.cshtml"
               Write(lang.Index_ServiceNode);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_node\" style=\"text-align:left;font-size:" +
"12px;padding-left:8px\"></td>\r\n            </tr>\r\n            <tr>\r\n             " +
"   <td>");


            
            #line 48 "..\..\Views\HttpReports\Trace.cshtml"
               Write(lang.Request_Route);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_route\" style=\"text-align:left;font-size" +
":12px;padding-left:8px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n          " +
"      <td>");


            
            #line 53 "..\..\Views\HttpReports\Trace.cshtml"
               Write(lang.Request_Url);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_url\" style=\"text-align:left;font-size:1" +
"2px;padding-left:8px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n            " +
"    <td>");


            
            #line 58 "..\..\Views\HttpReports\Trace.cshtml"
               Write(lang.Request_Type);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_method\" style=\"text-align:left;font-siz" +
"e:12px;padding-left:8px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n         " +
"       <td>");


            
            #line 63 "..\..\Views\HttpReports\Trace.cshtml"
               Write(lang.Request_Connection);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_requestType\" style=\"text-align:left;fon" +
"t-size:12px;padding-left:8px\"></td>\r\n            </tr>\r\n\r\n\r\n            <tr>\r\n  " +
"              <td>");


            
            #line 69 "..\..\Views\HttpReports\Trace.cshtml"
               Write(lang.Request_Time);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_milliseconds\" style=\"text-align:left;fo" +
"nt-size:12px;padding-left:8px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n   " +
"             <td>");


            
            #line 74 "..\..\Views\HttpReports\Trace.cshtml"
               Write(lang.Request_StatusCode);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_statusCode\" style=\"text-align:left;font" +
"-size:12px;padding-left:6px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n     " +
"           <td>");


            
            #line 79 "..\..\Views\HttpReports\Trace.cshtml"
               Write(lang.Request_RemoteIP);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_ip\" style=\"text-align:left;font-size:12" +
"px;padding-left:6px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n             " +
"   <td>");


            
            #line 84 "..\..\Views\HttpReports\Trace.cshtml"
               Write(lang.Request_RemotePort);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_port\" style=\"text-align:left;font-size:" +
"12px;padding-left:6px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n           " +
"     <td>");


            
            #line 89 "..\..\Views\HttpReports\Trace.cshtml"
               Write(lang.Request_LocalIP);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_localIp\" style=\"text-align:left;font-si" +
"ze:12px;padding-left:6px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n        " +
"        <td>");


            
            #line 94 "..\..\Views\HttpReports\Trace.cshtml"
               Write(lang.Request_LocalPort);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td class=\"context_localPort\" style=\"text-align:left;font-" +
"size:12px;padding-left:6px\"></td>\r\n            </tr>\r\n\r\n            <tr>\r\n      " +
"          <td>");


            
            #line 99 "..\..\Views\HttpReports\Trace.cshtml"
               Write(lang.Request_CreateTime);

            
            #line default
            #line hidden
WriteLiteral(@"</td>
                <td class=""context_createTime"" style=""text-align:left;font-size:12px;padding-left:6px""></td>
            </tr>


        </tbody>
    </table>

    <h3 class=""request_detail_title"" style=""padding-left:6px; margin-top:20px;margin-bottom:16px""><i class=""fa fa-space-shuttle"" style=""margin-right:10px""></i>  ");


            
            #line 107 "..\..\Views\HttpReports\Trace.cshtml"
                                                                                                                                                            Write(lang.Request_DetailInfo);

            
            #line default
            #line hidden
WriteLiteral(@"</h3>

    <table class=""table table-striped table-bordered"" style=""word-break:break-all"">
        <thead>
            <tr>
                <th width=""160"">Key</th>
                <th>Value</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>QueryString</td>
                <td class=""context_queryString"" style=""text-align:left;font-size:12px""></td>
            </tr>

            <tr>
                <td>Header</td>
                <td class=""context_header"" style=""text-align:left;font-size:12px""></td>
            </tr>

            <tr>
                <td>Cookie</td>
                <td class=""context_cookie"" style=""text-align:left;font-size:12px""></td>
            </tr>

            <tr>
                <td>RequestBody</td>
                <td class=""context_requestBody"" style=""text-align:left;font-size:12px""></td>
            </tr>


            <tr>
                <td>ResponseBody</td>
                <td class=""context_responseBody"" style=""text-align:left;font-size:12px""></td>
            </tr>

            <tr>
                <td>Error</td>
                <td class=""context_error"" style=""text-align:left;font-size:12px""></td>
            </tr>

            <tr>
                <td>ErrorStack</td>
                <td class=""context_errorStack"" style=""text-align:left;font-size:12px""></td>
            </tr>


        </tbody>
    </table>

</div>


<input type=""hidden"" value=""");


            
            #line 160 "..\..\Views\HttpReports\Trace.cshtml"
                       Write(ViewData["TraceId"]);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"trace_id\" />\r\n\r\n<script src=\"/HttpReportsStaticFiles/Content/page/trace." +
"js?ver=1.0.6\"></script> ");


        }
    }
}
#pragma warning restore 1591

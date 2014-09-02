﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Root.Views.Shared.Partial
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\Partial\ContentsTree.cshtml"
    using BetterCms.Module.Root.Content.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Partial/ContentsTree.cshtml")]
    public partial class ContentsTree : System.Web.Mvc.WebViewPage<dynamic>
    {
        public ContentsTree()
        {
        }
        public override void Execute()
        {
WriteLiteral("<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-contents-tree-template\"");

WriteLiteral(@">
    <div class=""bcms-scroll-window"" id=""bcms-contents-tree"">
        <div class=""bcms-padded-content"">
            <div data-bind=""visible: visibleItems().length > 0, with: visibleItems()"">
                <h2 data-bind=""visible: $parent.invisibleItems().length > 0"">TODO: Visible regions</h2>
                <div data-bind='template: { name: ""bcms-contents-tree-list-template"" }'></div>
            </div>

            <div data-bind=""visible: invisibleItems().length > 0, with: invisibleItems()"">
                <h2>TODO: Invisible regions</h2>
                <div data-bind='template: { name: ""bcms-contents-tree-list-template"" }'></div>
            </div>
        </div>
    </div>
</script>
<style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n    body {\r\n        -webkit-font-smoothing: antialiased;\r\n        text-renderi" +
"ng: optimizeLegibility;\r\n    }\r\n\r\n    .bcms-contents-tree-region {\r\n        posi" +
"tion: relative;\r\n        min-height: 48px;\r\n        padding: 15px 15px 5px 30px;" +
"\r\n        margin-top: 40px;\r\n        background-color: #ffffff;\r\n        border:" +
" 1px dashed #0383df;\r\n        -moz-box-sizing: border-box;\r\n        box-sizing: " +
"border-box;\r\n    }\r\n\r\n    .bcms-contents-tree-region-icons {\r\n        display: n" +
"one;\r\n        float: right;\r\n    }\r\n\r\n    .bcms-contents-tree-region-header span" +
" {\r\n        line-height: 1em;\r\n        color: #0383df;\r\n        font-size: 16px;" +
"\r\n        font-weight: 600;\r\n        text-transform: uppercase;\r\n    }\r\n\r\n    .b" +
"cms-contents-tree-region-header > span:after {\r\n        content: \"\";\r\n        po" +
"sition: absolute;\r\n        top: 15px;\r\n        left: 9px;\r\n        width: 16px;\r" +
"\n        height: 16px;\r\n        background: url(\'data:image/png;base64,iVBORw0KG" +
"goAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAp0lEQVQ4y2NgaHzEgIa1gLgPiK8D8Q8ovgYV08JQj" +
"8RhA+IpQPwXiP/jwCC5GUDMiW4ASPNuPBrR8V6oHrgBU0nQDMNTYAZoA/EfJAmYofjY/6F6tEEC/WgmM" +
"5Dgin4GaGgTawC63HWQwE8SbEQ34Cc2A0jxwmdKvXAFWyCS4oUJIAEdCqJRh5KENJWqSZnizISMtcGB0" +
"/joBhD/AuIv4NCGiOmgqwcAeZoWhHl8VUoAAAAASUVORK5CYII=\') no-repeat center center;\r\n" +
"    }\r\n\r\n    .bcms-contents-tree-content {\r\n        position: relative;\r\n       " +
" min-height: 43px;\r\n        padding: 15px 15px 15px 30px;\r\n        background-co" +
"lor: #ffffff;\r\n        border: 1px solid black;\r\n        -moz-box-sizing: border" +
"-box;\r\n        box-sizing: border-box;\r\n    }\r\n\r\n        .bcms-contents-tree-con" +
"tent span {\r\n            font-size: 14px;\r\n            font-weight: 600;\r\n      " +
"  }\r\n\r\n        .bcms-contents-tree-content > div > span:after {\r\n            con" +
"tent: \"\";\r\n            position: absolute;\r\n            top: 15px;\r\n            " +
"left: 9px;\r\n            width: 16px;\r\n            height: 16px;\r\n            bac" +
"kground: url(\'data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9h" +
"AAAAoUlEQVQ4y63TMQ7CMAyF4UxI3OObaM8KHUDiLohbVJR7wAAIBEuCqkiB0jL8Qxy/J9txAkLGAkt0" +
"uEQOMbbI8/uHGdZ44FnggS3mucEMuw/CnH3UvA02P4gT62RQ4T7C4I4qYDVCnFiFOO38IhTI87qA64QK" +
"riWDMLCKU6mFobSlIX7rPdEE1BOesZ6ySJu/rvLkz9SnQoMjbjijjbE6z38BOfIicutUfNcAAAAASUVO" +
"RK5CYII=\') no-repeat center center;\r\n        }\r\n\r\n    .bcms-contents-tree-conten" +
"t-icons {\r\n        display: none;\r\n        float: right;\r\n    }\r\n\r\n    .bcms-dra" +
"gging {\r\n        background-color: #f5f5f5;\r\n        opacity: 0.8;\r\n    }\r\n\r\n   " +
"     .bcms-dragging:after {\r\n            content: \"\";\r\n            position: abs" +
"olute;\r\n            top: 14px;\r\n            right: 20px;\r\n            width: 18p" +
"x;\r\n            height: 18px;\r\n            background: url(\'data:image/png;base6" +
"4,iVBORw0KGgoAAAANSUhEUgAAABIAAAASCAYAAABWzo5XAAAAwElEQVQ4y82UMQoCMRBFAxbay9qId8" +
"ghbdQbWKynUEFFEcTCbezWRm+y6v8yA0GygYyNxWuG7IP8+RvnvXcJRuABbmCQOpuS9EAFXsIBdCyiRS" +
"BRZhbREjwDSQP2FpGiImfNyCRiiGNwyhCtQClL+Yj6YJP4oG2u+V1YEw6uke3kcndStl9FNUVDcDZcrZ" +
"E5K1HosAvmYJshYtOn2vb/7VGM49cvQtYW0SSyndIiYoi7QFJpiy0ZFewICyePXOvZNzOcGkIop91gAA" +
"AAAElFTkSuQmCC\') no-repeat center center;\r\n        }\r\n\r\n    .bcms-contents-tree-" +
"droppable {\r\n        height: 20px;\r\n    }\r\n\r\n    .bcms-contents-tree-droppable-a" +
"ctive {\r\n        color: black;\r\n        height: 30px;\r\n        margin: 10px 0;\r\n" +
"        border: 1px dashed black;\r\n    }\r\n\r\n    .bcms-contents-hover {\r\n        " +
"background-color: #f5f5f5;\r\n    }\r\n\r\n        .bcms-contents-hover .bcms-contents" +
"-tree-content-icons {\r\n            display: block;\r\n        }\r\n\r\n        .bcms-c" +
"ontents-hover .bcms-contents-tree-region-icons {\r\n            display: block;\r\n " +
"       }\r\n\r\n    .bcms-tree-controls a {\r\n        position: relative;\r\n        di" +
"splay: inline-block;\r\n        width: 18px;\r\n        height: 18px;\r\n        margi" +
"n-left: 15px;\r\n        background-position: center;\r\n        cursor: pointer;\r\n " +
"       vertical-align: middle;\r\n        text-indent: -9999px;\r\n    }\r\n\r\n    .bcm" +
"s-tree-controls-pointer {\r\n        background-image: url(\'\');\r\n    }\r\n\r\n        " +
".bcms-tree-controls-pointer:hover {\r\n            background-image: url(\'\');\r\n   " +
"     }\r\n\r\n    .bcms-tree-controls-history {\r\n        background-image: url(\'\');\r" +
"\n    }\r\n\r\n        .bcms-tree-controls-history:hover {\r\n            background-im" +
"age: url(\'\');\r\n        }\r\n\r\n    .bcms-tree-controls-edit {\r\n        background-i" +
"mage: url(\'\');\r\n    }\r\n\r\n        .bcms-tree-controls-edit:hover {\r\n            b" +
"ackground-image: url(\'\');\r\n        }\r\n\r\n    .bcms-tree-controls-delete {\r\n      " +
"  background-image: url(\'\');\r\n    }\r\n\r\n        .bcms-tree-controls-delete:hover " +
"{\r\n            background-image: url(\'\');\r\n        }\r\n\r\n    .bcms-tree-controls-" +
"add {\r\n        background-image: url(\'data:image/png;base64,iVBORw0KGgoAAAANSUhE" +
"UgAAABAAAAAQCAYAAAAf8/9hAAAAPklEQVQ4y2NgmPGOAQc+DMT/ofgwTnV4DPiPhkcNwGPAYSyKicWH" +
"GSjQDMHUMIASLxwZTQc0NuAwSmjjUAcAbxLzwsvYFoMAAAAASUVORK5CYII=\');\r\n    }\r\n\r\n      " +
"  .bcms-tree-controls-add:hover {\r\n            background-image: url(\'data:image" +
"/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAPklEQVQ4y2NgaHzEgAMf" +
"BuL/UHwYpzo8BvxHw6MG4DHgMBbFxOLDDBRohmBqGECJF46MpgMaG3AYJbRxqAMATWnQwmj3tBgAAAAA" +
"SUVORK5CYII=\');\r\n        }\r\n\r\n    /*TEST ONLY*/\r\n    .bcms-contents-tree-content" +
":hover .bcms-contents-tree-content-icons {\r\n        display: block;\r\n    }\r\n\r\n  " +
"  .bcms-contents-tree-region:hover .bcms-contents-tree-region-icons {\r\n        d" +
"isplay: block;\r\n    }\r\n</style>\r\n<script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"bcms-contents-tree-list-template\"");

WriteLiteral(">\r\n    <!-- ko if: $data.length > 0 -->\r\n    <!-- ko foreach: $data -->\r\n    <!--" +
" ko if: type == types.content && $index() == 0 -->\r\n    <div class=\"bcms-content" +
"s-tree-droppable\" data-bind=\"droppableContent: {type: \'top\', region: parentRegio" +
"n}, css: {\'bcms-contents-tree-droppable-active\': activeZone() == \'top\'}\">\r\n     " +
"   &nbsp;\r\n    </div>\r\n    <!-- /ko -->\r\n    <div data-bind=\"\r\n        css: {\r\n " +
"           \'bcms-contents-tree-region\': type == types.region,\r\n            \'bcms" +
"-contents-tree-content\': type == types.content,\r\n            \'bcms-dragging\': is" +
"BeingDragged()\r\n        },\r\n        draggableContent: type == types.content,\r\n  " +
"      style: { zIndex: !isBeingDragged() ? \'0\' : \'9999\'}\">\r\n        <div data-bi" +
"nd=\"css: {\'bcms-contents-tree-region-header\': type == types.region}\">\r\n         " +
"   <span data-bind=\"text: title()\"></span>\r\n            <div class=\"bcms-tree-co" +
"ntrols\" data-bind=\"css: {\'bcms-contents-tree-region-icons\': type==types.region, " +
"\'bcms-contents-tree-content-icons\': type==types.content}, visible: !isBeingDragg" +
"ed()\">\r\n                <!-- ko if: type == types.content -->\r\n                <" +
"!-- ko if: model.visibleButtons.configure -->\r\n                <a class=\"bcms-tr" +
"ee-controls-pointer\" data-bind=\"click: configure\">TODO: Configure</a>\r\n         " +
"       <!-- /ko -->\r\n                <!-- ko if: model.visibleButtons.history --" +
">\r\n                <a class=\"bcms-tree-controls-history\" data-bind=\"click: histo" +
"ry\"></a>\r\n                <!-- /ko -->\r\n                <!-- ko if: model.visibl" +
"eButtons.edit -->\r\n                <a class=\"bcms-tree-controls-edit\" data-bind=" +
"\"click: editItem\">");

            
            #line 213 "..\..\Views\Shared\Partial\ContentsTree.cshtml"
                                                                          Write(RootGlobalization.Button_Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                <!-- /ko -->\r\n                <!-- ko if: model.visibleButt" +
"ons.delete -->\r\n                <a class=\"bcms-tree-controls-delete\" data-bind=\"" +
"click: deleteItem\">");

            
            #line 216 "..\..\Views\Shared\Partial\ContentsTree.cshtml"
                                                                              Write(RootGlobalization.Button_Delete);

            
            #line default
            #line hidden
WriteLiteral(@"</a>
                <!-- /ko -->
                <!-- /ko -->
                <!-- ko if: type == types.region -->
                <a class=""bcms-tree-controls-add"" data-bind=""click: addContent""></a>
                <!-- /ko -->
            </div>
        </div>
        <div data-bind=""with: items()"">
            <div data-bind=""template: { name: 'bcms-contents-tree-list-template' }""></div>
        </div>

        <!-- ko if: type == types.region && items().length === 0 -->
        <div class=""bcms-contents-tree-droppable"" data-bind=""droppableContent: {type: 'emptyListZone', region: $data}, css: {'bcms-contents-tree-droppable-active': activeZone() == 'emptyListZone'}"">
            &nbsp;
        </div>
        <!-- /ko -->
    </div>

    <!-- ko if: type == types.content -->
    <div class=""bcms-contents-tree-droppable"" data-bind=""droppableContent: {type: 'middle', region: parentRegion}, css: {'bcms-contents-tree-droppable-active': activeZone() == 'middle'}"">
        &nbsp;
    </div>
    <!-- /ko -->
    <!-- /ko -->
    <!-- /ko -->
</script>");

        }
    }
}
#pragma warning restore 1591

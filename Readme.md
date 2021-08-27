<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128549768/15.2.15%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T328854)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/GridView/Controllers/HomeController.cs)
* **[_GridViewPartial.cshtml](./CS/GridView/Views/Home/_GridViewPartial.cshtml)**
* [Index.cshtml](./CS/GridView/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to automatically resize the grid to 100% inside a resizable PopupControl
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/100/)**
<!-- run online end -->


<p>This example illustrates how to set the grid's width and height to 100% when it is placed inside a resizable container. The <a href="https://www.devexpress.com/Support/Center/p/E3958">How to use the GridView extension in a Full Screen mode (100% browser Width and Height)</a> example describes how to accomplish this task when the grid is paced into the page directly. If the grid is placed inside some container, it is necessary to handle container resizing to set the grid height:</p>


```cs
settings.ClientSideEvents.AfterResizing = "function(s, e){ GridView.SetHeight(document.getElementById('containerDiv').clientHeight); }";

```


<p> GridView is placed inside the div element with height and width equal to 100% to get the client height of the container's content area:</p>


```cs
ViewContext.Writer.Write("<div id='containerDiv' style='height:100%; widht:100%'>");
Html.RenderAction("GridViewPartial");
ViewContext.Writer.Write("</div>");
```



<br/>



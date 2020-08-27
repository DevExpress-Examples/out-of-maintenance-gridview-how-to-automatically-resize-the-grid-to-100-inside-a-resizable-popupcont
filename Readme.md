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



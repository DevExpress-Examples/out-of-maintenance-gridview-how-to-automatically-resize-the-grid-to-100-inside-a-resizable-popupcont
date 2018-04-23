@Html.DevExpress().PopupControl(Sub(settings)
                                         settings.Name = "PopupControl"
                                         settings.AllowResize = True
                                         settings.ScrollBars = ScrollBars.Auto
                                         settings.ShowHeader = True
                                         settings.ShowOnPageLoad = False
                                         settings.AllowDragging = True
                                         settings.CloseAction = CloseAction.OuterMouseClick
                                         settings.CloseOnEscape = False
                                         settings.Modal = False
                                         settings.ShowMaximizeButton = True
                                         settings.PopupHorizontalAlign = PopupHorizontalAlign.WindowCenter
                                         settings.PopupVerticalAlign = PopupVerticalAlign.WindowCenter
                                         settings.Width = 600
                                         settings.SetContent(Sub()
                                                                 ViewContext.Writer.Write("<div id='containerDiv' style='height:100%; widht:100%'>")
                                                                 Html.RenderAction("GridViewPartialView")
                                                                 ViewContext.Writer.Write("</div>")
                                                             End Sub)
                                         settings.ClientSideEvents.AfterResizing = "function(s, e){ GridView.SetHeight(document.getElementById('containerDiv').clientHeight); }"
                                     End Sub).GetHtml()

@Html.DevExpress().Button(Sub(settings)
                                   settings.Name = "Button"
                                   settings.Text = "Show Popup"
                                   settings.UseSubmitBehavior = False
                                   settings.ClientSideEvents.Click = "function(s, e){ PopupControl.Show(); }"
                               End Sub).GetHtml()

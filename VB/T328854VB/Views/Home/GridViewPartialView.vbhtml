@* DXCOMMENT: Configure GridView *@
@Html.DevExpress().GridView(Sub(settings)
                                     settings.Name = "GridView"
                                     settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "GridViewPartialView"}

                                     settings.KeyFieldName = "CustomerID"

                                     ' DXCOMMENT: Configure grid's columns in accordance with data model fields
                                     settings.Columns.Add("ContactName")
                                     settings.Columns.Add("CompanyName")
                                     settings.Columns.Add("ContactTitle")
                                     settings.Columns.Add("Address")
                                     settings.Columns.Add("City")
                                     settings.Columns.Add("Region")
                                     settings.Columns.Add("PostalCode")
                                     settings.Columns.Add("Country")
                                     settings.Columns.Add("Phone")
                                     settings.Columns.Add("Fax")
                                     settings.Settings.VerticalScrollBarMode = ScrollBarMode.Visible
                                     settings.SettingsPager.Mode = GridViewPagerMode.ShowAllRecords
                                     settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
                                     settings.Settings.VerticalScrollableHeight = 300
                                 End Sub).Bind(Model).GetHtml()

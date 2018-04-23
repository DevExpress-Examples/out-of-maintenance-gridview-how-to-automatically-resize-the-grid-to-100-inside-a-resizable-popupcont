Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Public Function Index() As ActionResult
        Return View()
    End Function

    Public Function GridViewPartialView() As ActionResult
        Return PartialView("GridViewPartialView", NorthwindDataProvider.GetCustomers())
    End Function



End Class
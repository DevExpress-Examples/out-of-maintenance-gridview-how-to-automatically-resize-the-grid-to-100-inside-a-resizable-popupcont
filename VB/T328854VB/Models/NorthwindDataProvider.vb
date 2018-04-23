Public NotInheritable Class NorthwindDataProvider
    ' DXCOMMENT: Configure a data model (In this sample, we do this in file NorthwindDataProvider.vb. You would better create your custom file for a data model.)
    Private Const NorthwindDataContextKey As String = "DXNorthwindDataContext"

    Private Sub New()
    End Sub
    Public Shared ReadOnly Property DB() As NorthwindDataContext
        Get
            If HttpContext.Current.Items(NorthwindDataContextKey) Is Nothing Then
                HttpContext.Current.Items(NorthwindDataContextKey) = New NorthwindDataContext()
            End If
            Return CType(HttpContext.Current.Items(NorthwindDataContextKey), NorthwindDataContext)
        End Get
    End Property

    Public Shared Function GetCustomers() As IEnumerable
        Return From customer In DB.Customers _
               Select customer
    End Function
End Class
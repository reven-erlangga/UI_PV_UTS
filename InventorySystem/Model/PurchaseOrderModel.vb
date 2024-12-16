'Public Class PurchaseOrderModel
'    Public Shared Supplier As SupplierModel
'    Public Shared Items As New List(Of PurchaseOrderListModel)()
'End Class
Public Class PurchaseOrderModel

    Public Property ID As Integer
    Public Property PONumber As String
    Public Property SupplierName As String
    Public Property SupplierEmail As String
    Public Property SupplierFax As String
    Public Property SupplierHandphone As String
    Public Property SupplierAddress As String
    Public Property Reason As String
    Public Property PurchaseOrderLists As List(Of PurchaseOrderListModel)
    Public Property Status As String

End Class
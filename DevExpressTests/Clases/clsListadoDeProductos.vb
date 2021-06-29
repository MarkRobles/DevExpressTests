Imports System.Data.SqlClient

Public Class clsListadoDeProductos
    Private intCOMListadoDeProductosKey As Integer = 0
    Private unqCOMMastRequisicionLink As Guid = Nothing
    Private unqCOMMastOrdenDeCompraLink As Guid = Nothing
    Private mnyCostoTotal As Decimal = 0.0
    Private mnyPrecioUnitario As Decimal = 0.0
    Private decCantidad As Decimal = 0.0
    Private unqGENUnidadDeMedidaLink As Guid = Nothing
    Private strUnidadDeMedida As String = String.Empty
    Private vchDescripcion As String = String.Empty
    Private strUsuario As String
    Private strDetalleCotizacion As String
    Private strErrorMessage As String = String.Empty
    Private intErrorNumber As Integer = 0
    Private intAccion As Integer = 0
    Private intCOMListadoDeProductosKeyOut As Integer = 0
    Private blnCotizado As Boolean = Nothing
    Private strCodigoRequisicion As String = Nothing
    Private unqGENProveedorLink As Guid = Nothing
    Private unqCOMDetCatalogoPorProveedorLink As Guid
    Private decISR As Decimal = 0.00
    Private decISN As Decimal = 0.00
    Private decIVA As Decimal = 0.00
    Private unqCOMArticuloLink As Guid
    Private decRetencionIVA As Decimal = 0.00

    Public Property RetencionIVA() As Decimal
        Get
            Return decRetencionIVA
        End Get
        Set(ByVal value As Decimal)
            decRetencionIVA = value
        End Set
    End Property

    Public Property COMArticuloLink() As Guid
        Get
            Return unqCOMArticuloLink
        End Get
        Set(ByVal value As Guid)
            unqCOMArticuloLink = value
        End Set
    End Property

    Public Property IVA() As Decimal
        Get
            Return decIVA
        End Get
        Set(ByVal value As Decimal)
            decIVA = value
        End Set
    End Property
    Public Property ISN() As Decimal
        Get
            Return decISN
        End Get
        Set(ByVal value As Decimal)
            decISN = value
        End Set
    End Property
    Public Property ISR() As Decimal
        Get
            Return decISR
        End Get
        Set(ByVal value As Decimal)
            decISR = value
        End Set
    End Property


    Private decIVARetenido As Decimal
    Public Property IVARetenido() As Decimal
        Get
            Return decIVARetenido
        End Get
        Set(ByVal value As Decimal)
            decIVARetenido = value
        End Set
    End Property


    Public Property COMDetCatalogoPorProveedorKey() As Guid
        Get
            Return unqCOMDetCatalogoPorProveedorLink
        End Get
        Set(ByVal value As Guid)
            unqCOMDetCatalogoPorProveedorLink = value
        End Set
    End Property
    Public Property GENProveedorLink() As Guid
        Get
            Return unqGENProveedorLink
        End Get
        Set(ByVal value As Guid)
            unqGENProveedorLink = value
        End Set
    End Property

    Public Property CodigoRequisicion() As String
        Get
            Return strCodigoRequisicion
        End Get
        Set(ByVal value As String)
            strCodigoRequisicion = value
        End Set
    End Property


    Public Property Cotizado() As Boolean
        Get
            Return blnCotizado
        End Get
        Set(ByVal value As Boolean)
            blnCotizado = value
        End Set
    End Property



    Public Property Accion() As Integer
        Get
            Return intAccion
        End Get
        Set(ByVal value As Integer)
            intAccion = value
        End Set
    End Property


    Public Property COMListadoDeProductosKey() As Integer
        Get
            Return intCOMListadoDeProductosKey
        End Get
        Set(ByVal value As Integer)
            intCOMListadoDeProductosKey = value
        End Set
    End Property

    Public Property COMMastRequisicionLink() As Guid
        Get
            Return unqCOMMastRequisicionLink
        End Get
        Set(ByVal value As Guid)
            unqCOMMastRequisicionLink = value
        End Set
    End Property


    Public Property COMMastOrdenDeCompraLink() As Guid
        Get
            Return unqCOMMastOrdenDeCompraLink
        End Get
        Set(ByVal value As Guid)
            unqCOMMastOrdenDeCompraLink = value
        End Set
    End Property


    Public Property Descripcion() As String
        Get
            Return vchDescripcion
        End Get
        Set(ByVal value As String)
            vchDescripcion = value
        End Set
    End Property

    Public Property GENUnidadDeMedidaLink() As Guid
        Get
            Return unqGENUnidadDeMedidaLink
        End Get
        Set(ByVal value As Guid)
            unqGENUnidadDeMedidaLink = value
        End Set
    End Property

    Public Property UnidadDeMedida() As String
        Get
            Return strUnidadDeMedida
        End Get
        Set(ByVal value As String)
            strUnidadDeMedida = value
        End Set
    End Property

    Public Property Cantidad() As Decimal
        Get
            Return decCantidad
        End Get
        Set(ByVal value As Decimal)
            decCantidad = value
        End Set
    End Property

    Public Property PrecioUnitario() As Decimal
        Get
            Return mnyPrecioUnitario
        End Get
        Set(ByVal value As Decimal)
            mnyPrecioUnitario = value
        End Set
    End Property


    Public Property CostoTotal() As Decimal
        Get
            Return mnyCostoTotal
        End Get
        Set(ByVal value As Decimal)
            mnyCostoTotal = value
        End Set
    End Property


    Public Property Usuario() As String
        Get
            Return strUsuario
        End Get
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property

    Public Property DetalleCotizacion() As String
        Get
            Return strDetalleCotizacion
        End Get
        Set(ByVal value As String)
            strDetalleCotizacion = value
        End Set
    End Property

    Public Property COMListadoDeProductosKeyOut() As Integer
        Get
            Return intCOMListadoDeProductosKeyOut
        End Get
        Set(ByVal value As Integer)
            intCOMListadoDeProductosKeyOut = value
        End Set
    End Property

    Private strCodigoProducto As String
    Public Property CodigoProducto() As String
        Get
            Return strCodigoProducto
        End Get
        Set(ByVal value As String)
            strCodigoProducto = value
        End Set
    End Property


    Private strCodigoPresupuestal As String
    Public Property CodigoPresupuestal() As String
        Get
            Return strCodigoPresupuestal
        End Get
        Set(ByVal value As String)
            strCodigoPresupuestal = value
        End Set
    End Property



    Private decSubTotal As Decimal
    Public Property SubTotal() As Decimal
        Get
            Return decSubTotal
        End Get
        Set(ByVal value As Decimal)
            decSubTotal = value
        End Set
    End Property


    Private blnHabilitado As Boolean
    Public Property Habilitado() As Boolean

        Get
            Return blnHabilitado
        End Get
        Set(ByVal value As Boolean)
            blnHabilitado = value
        End Set
    End Property




    Private strProveedor As String
    Public Property Proveedor() As String
        Get
            Return strProveedor
        End Get
        Set(ByVal value As String)
            strProveedor = value
        End Set
    End Property


    Private strCodigoOC As String
    Public Property CodigoOC() As String
        Get
            Return strCodigoOC
        End Get
        Set(ByVal value As String)
            strCodigoOC = value
        End Set
    End Property

    Public Property ErrorMessage() As String
        Get
            Return strErrorMessage
        End Get
        Set(ByVal value As String)
            strErrorMessage = value
        End Set
    End Property

    ReadOnly Property ErrorNumber As Integer
        Get
            Return Me.intErrorNumber
        End Get
    End Property



    Function ObtenerLista() As List(Of clsListadoDeProductos)
        Dim tblTable As New DataTable
        Dim ListaDeProductos As New List(Of clsListadoDeProductos)
        Try
            tblTable = ObtenerDataTable()
            If Not tblTable Is Nothing Then
                If tblTable.Rows.Count > 0 Then
                    ListaDeProductos = (From dr In tblTable.Rows Select New clsListadoDeProductos() With {
           .COMListadoDeProductosKey = Convert.ToInt32(dr("intCOMListadoDeProductosKey")),
           .COMMastRequisicionLink = Guid.Parse(dr("unqCOMMastRequisicionLink").ToString()),
           .COMMastOrdenDeCompraLink = Guid.Parse(dr("unqCOMMastOrdenDeCompraLink").ToString()),
           .GENUnidadDeMedidaLink = Guid.Parse(dr("unqGENUnidadDeMedidaLink").ToString()),
            .GENProveedorLink = Guid.Parse(dr("unqGENProveedorLink").ToString()),
            .Proveedor = dr("vchProveedor").ToString(),
            .UnidadDeMedida = dr("vchUnidadDeMedida").ToString(),
            .DetalleCotizacion = dr("vchDetalleCotizacionArticulo"),
           .Descripcion = dr("vchDescripcion").ToString(),
            .CodigoOC = dr("vchCodigoOrdenDeCompra").ToString(),
            .Cantidad = Convert.ToDecimal(dr("decCantidad")),
            .PrecioUnitario = Convert.ToDecimal(dr("mnyPrecioUnitario")),
            .CostoTotal = Convert.ToDecimal(dr("mnyCostoTotal")),
            .COMDetCatalogoPorProveedorKey = Guid.Parse(dr("unqCOMDetCatalogoPorProveedorLink").ToString()),
            .COMArticuloLink = Guid.Parse(dr("unqCOMArticuloLink").ToString()),
             .CodigoPresupuestal = dr("vchCodigoPresupuestal").ToString(),
             .CodigoProducto = dr("vchCodigoProducto").ToString(),
            .IVA = Convert.ToDecimal(dr("mnyIVA")),
            .ISR = Convert.ToDecimal(dr("mnyISR")),
            .ISN = Convert.ToDecimal(dr("mnyISN")),
             .SubTotal = Convert.ToDecimal(dr("mnySubTotal")),
             .Habilitado = dr("bitStock")
       }).ToList()
                End If
            End If
        Catch ex As Exception
            Me.ErrorMessage = ex.Message
        End Try
        Return ListaDeProductos
    End Function

    Function ObtenerDataTable() As DataTable
        Dim cnnMain As New SqlConnection
        Dim cmdQuery As SqlCommand = Nothing
        Dim prmGeneric As SqlParameter = Nothing
        Dim daAdapter As SqlDataAdapter = Nothing
        Dim tblTable As DataTable = Nothing


        Try
            cnnMain.ConnectionString = System.Configuration.ConfigurationManager.AppSettings("YourConnectionString")
            cnnMain.Open()

            cmdQuery = New SqlCommand("COM.prObtenerListadoDeProductos", cnnMain)
            cmdQuery.CommandType = CommandType.StoredProcedure
            cmdQuery.Parameters.Clear()


            prmGeneric = New System.Data.SqlClient.SqlParameter("@intCOMListadoDeProductosKey", SqlDbType.Int)
            prmGeneric.Value = intCOMListadoDeProductosKey
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            prmGeneric = New System.Data.SqlClient.SqlParameter("@unqCOMMastRequisicionLink", SqlDbType.UniqueIdentifier)
            prmGeneric.Value = COMMastRequisicionLink
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)


            prmGeneric = New System.Data.SqlClient.SqlParameter("@unqCOMMastOrdenDeCompraLink", SqlDbType.UniqueIdentifier)
            prmGeneric.Value = unqCOMMastOrdenDeCompraLink
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)


            prmGeneric = New System.Data.SqlClient.SqlParameter("@vchCodigoRequisicion", SqlDbType.VarChar)
            prmGeneric.Value = strCodigoRequisicion
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)


            prmGeneric = New System.Data.SqlClient.SqlParameter("@bitCotizado", SqlDbType.Bit)
            prmGeneric.Value = blnCotizado
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)



            prmGeneric = New System.Data.SqlClient.SqlParameter("@unqGENProveedorLink", SqlDbType.UniqueIdentifier)
            prmGeneric.Value = unqGENProveedorLink
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            daAdapter = New SqlDataAdapter(cmdQuery)
            tblTable = New DataTable
            daAdapter.Fill(tblTable)

            If intErrorNumber = 0 Then
                ObtenerDataTable = tblTable
            Else
                ObtenerDataTable = Nothing
            End If

        Catch exError As SqlException
            ObtenerDataTable = Nothing
            Me.strErrorMessage = exError.Message
            Me.intErrorNumber = exError.Number
        Finally

            If Not tblTable Is Nothing Then
                tblTable.Dispose()
                tblTable = Nothing
            End If
            If Not daAdapter Is Nothing Then
                daAdapter.Dispose()
                daAdapter = Nothing
            End If
            If Not prmGeneric Is Nothing Then prmGeneric = Nothing
            If Not daAdapter Is Nothing Then
                daAdapter.Dispose()
                daAdapter = Nothing
            End If
            If Not cmdQuery Is Nothing Then
                cmdQuery.Dispose()
                cmdQuery = Nothing
            End If
            If cnnMain.State = ConnectionState.Open Then
                cnnMain.Close()
            End If

            If Not cnnMain Is Nothing Then
                cnnMain.Dispose()
                cnnMain = Nothing
            End If

        End Try
    End Function

    Function Mantenimiento(ByVal intMovimiento As Integer) As Boolean

        Dim cnnMain As New SqlConnection
        Dim cmdQuery As SqlCommand = Nothing
        Dim prmGeneric As SqlParameter = Nothing
        Dim daAdapter As SqlDataAdapter = Nothing
        Dim blnResult As Boolean = False
        Dim tblTable As DataTable = Nothing


        Try
            cnnMain.ConnectionString = System.Configuration.ConfigurationManager.AppSettings("YourConnectionString")
            cnnMain.Open()

            cmdQuery = New SqlCommand("COM.prMantenimientoListadoDeProductos", cnnMain)
            cmdQuery.CommandType = CommandType.StoredProcedure
            cmdQuery.Parameters.Clear()

            prmGeneric = New System.Data.SqlClient.SqlParameter("@intMovimiento", SqlDbType.Int)
            prmGeneric.Value = intMovimiento
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            prmGeneric = New System.Data.SqlClient.SqlParameter("@intCOMListadoDeProductosKey", SqlDbType.Int)
            prmGeneric.Value = intCOMListadoDeProductosKey
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            prmGeneric = New System.Data.SqlClient.SqlParameter("@unqCOMMastRequisicionLink", SqlDbType.UniqueIdentifier)
            prmGeneric.Value = COMMastRequisicionLink
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)


            prmGeneric = New System.Data.SqlClient.SqlParameter("@unqCOMMastOrdenDeCompraLink", SqlDbType.UniqueIdentifier)
            prmGeneric.Value = COMMastOrdenDeCompraLink
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)


            prmGeneric = New System.Data.SqlClient.SqlParameter("@vchDescripcion", SqlDbType.VarChar)
            prmGeneric.Value = Descripcion
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            prmGeneric = New System.Data.SqlClient.SqlParameter("@unqGENUnidadDeMedidaLink", SqlDbType.UniqueIdentifier)
            prmGeneric.Value = GENUnidadDeMedidaLink
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            prmGeneric = New System.Data.SqlClient.SqlParameter("@decCantidad", SqlDbType.Decimal)
            prmGeneric.Value = Cantidad
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            prmGeneric = New System.Data.SqlClient.SqlParameter("@mnyPrecioUnitario", SqlDbType.Money)
            prmGeneric.Value = PrecioUnitario
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            prmGeneric = New System.Data.SqlClient.SqlParameter("@mnyCostoTotal", SqlDbType.Money)
            prmGeneric.Value = CostoTotal
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            prmGeneric = New System.Data.SqlClient.SqlParameter("@vchUsuario", SqlDbType.VarChar)
            prmGeneric.Value = Usuario
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            prmGeneric = New System.Data.SqlClient.SqlParameter("@unqCOMDetCatalogoPorProveedorLink", SqlDbType.UniqueIdentifier)
            prmGeneric.Value = COMDetCatalogoPorProveedorKey
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            prmGeneric = New System.Data.SqlClient.SqlParameter("@mnyIVA", SqlDbType.Money)
            prmGeneric.Value = IVA
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            prmGeneric = New System.Data.SqlClient.SqlParameter("@mnyISR", SqlDbType.Money)
            prmGeneric.Value = ISR
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            prmGeneric = New System.Data.SqlClient.SqlParameter("@mnyISN", SqlDbType.Money)
            prmGeneric.Value = ISN
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            prmGeneric = New System.Data.SqlClient.SqlParameter("@unqCOMArticuloLink", SqlDbType.UniqueIdentifier)
            prmGeneric.Value = COMArticuloLink
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            prmGeneric = New System.Data.SqlClient.SqlParameter("@mnyRetencionIVA", SqlDbType.Money)
            prmGeneric.Value = RetencionIVA
            prmGeneric.Direction = ParameterDirection.Input
            cmdQuery.Parameters.Add(prmGeneric)

            'output parameters          
            prmGeneric = New System.Data.SqlClient.SqlParameter("@intRetVal", System.Data.SqlDbType.Int)
            prmGeneric.Value = 0
            prmGeneric.Direction = ParameterDirection.Output
            cmdQuery.Parameters.Add(prmGeneric)


            prmGeneric = New System.Data.SqlClient.SqlParameter("@vchErrorMessage", System.Data.SqlDbType.VarChar, 255)
            prmGeneric.Value = ""
            prmGeneric.Direction = ParameterDirection.Output
            cmdQuery.Parameters.Add(prmGeneric)


            prmGeneric = New System.Data.SqlClient.SqlParameter("@intCOMListadoDeProductosKeyOut", System.Data.SqlDbType.Int)
            prmGeneric.Value = 0
            prmGeneric.Direction = ParameterDirection.Output
            cmdQuery.Parameters.Add(prmGeneric)



            daAdapter = New SqlDataAdapter(cmdQuery)
            tblTable = New DataTable
            daAdapter.Fill(tblTable)

            Me.strErrorMessage = daAdapter.SelectCommand.Parameters("@vchErrorMessage").Value
            Me.intErrorNumber = daAdapter.SelectCommand.Parameters("@intRetVal").Value
            Me.intCOMListadoDeProductosKeyOut = daAdapter.SelectCommand.Parameters("@intCOMListadoDeProductosKeyOut").Value



            If intErrorNumber = 0 Then
                blnResult = True
            Else
                blnResult = False
            End If


        Catch exError As SqlException
            blnResult = False
            Me.strErrorMessage = exError.Message
            Me.intErrorNumber = exError.Number
        Finally
            If Not tblTable Is Nothing Then
                tblTable.Dispose()
                tblTable = Nothing
            End If

            If Not daAdapter Is Nothing Then
                daAdapter.Dispose()
                daAdapter = Nothing
            End If

            If Not prmGeneric Is Nothing Then
                prmGeneric = Nothing
            End If

            If Not daAdapter Is Nothing Then
                daAdapter.Dispose()
                daAdapter = Nothing
            End If

            If Not cmdQuery Is Nothing Then
                cmdQuery.Dispose()
                cmdQuery = Nothing
            End If

            If cnnMain.State = ConnectionState.Open Then
                cnnMain.Close()
            End If

            If Not cnnMain Is Nothing Then
                cnnMain.Dispose()
                cnnMain = Nothing
            End If

        End Try
        Mantenimiento = blnResult
    End Function

End Class

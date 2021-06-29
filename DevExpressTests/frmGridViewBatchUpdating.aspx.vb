Imports DevExpress.Web.Data

Public Class frmGridViewBatchUpdating
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Not Page.IsPostBack Then
            Session("listaproductos") = Nothing
        End If
        grdListaProductos.DataBind()

    End Sub


    Protected Sub grdListaProductos_DataBinding(ByVal sender As Object, ByVal e As EventArgs) Handles grdListaProductos.DataBinding
        Dim objProductos As New clsListadoDeProductos
        Dim strScript As String = String.Empty
        Dim listaProductos As New List(Of clsListadoDeProductos)
        Dim tblListaProductos As New DataTable
        Dim totalProductos As Decimal = 0
        Try
            If Not Session("listaproductos") Is Nothing Then
                listaProductos = Session("listaproductos")
                grdListaProductos.DataSource = listaProductos
            Else
                objProductos.COMMastRequisicionLink = Guid.Parse("87490426-D5BE-4CC7-8D60-9E8E88764172")
                listaProductos = objProductos.ObtenerLista()
                grdListaProductos.DataSource = listaProductos
                Session("listaproductos") = listaProductos
            End If

        Catch ex As Exception
            strScript = Environment.NewLine & "Error en: " & System.Reflection.MethodInfo.GetCurrentMethod().ToString() & Environment.NewLine & Environment.NewLine & "Motivo:" & ex.Message &
                Environment.NewLine & Environment.NewLine & "Stack trace: " & ex.StackTrace
        Finally
            objProductos = Nothing
        End Try

    End Sub

    Protected Sub grdListaProductos_BatchUpdate(sender As Object, e As DevExpress.Web.Data.ASPxDataBatchUpdateEventArgs)
        Dim strScript As String = String.Empty
        Try
            For Each elemento In e.InsertValues
                AgregarElemento(elemento.NewValues)
            Next elemento

            For Each elemento In e.UpdateValues
                ModificarElemento(elemento.Keys, elemento.NewValues)
            Next elemento

            For Each elemento In e.DeleteValues
                EliminarElemento(elemento.Keys, elemento.Values)
            Next elemento

            e.Handled = True
        Catch ex As Exception
            strScript = Environment.NewLine & "Error en: " & System.Reflection.MethodInfo.GetCurrentMethod().ToString() & Environment.NewLine & Environment.NewLine & "Motivo:" & ex.Message &
                       Environment.NewLine & Environment.NewLine & "Stack trace: " & ex.StackTrace
        End Try
    End Sub



    Function AgregarElemento(ByVal values As OrderedDictionary) As String
        Dim strScript As String = String.Empty
        Dim ListaDeProductos As New List(Of clsListadoDeProductos)
        Dim ultimoElemento As New clsListadoDeProductos

        Dim totalProductos As Decimal = 0
        Dim objListaRegistrosPorEliminar As New List(Of clsListadoDeProductos)
        Dim objListaRegistrosPorExcluir As New List(Of String)

        Try
            ListaDeProductos = Session("listaproductos")

            'idea:
            'Crear un CRUD tipo T en memoria
            'me pasan un objeto y quiero encontrar cual de sus propiedades o campos corresponde a las propiedades de mi clase destino

            'Esta seria creo la forma manual

            If Not ListaDeProductos Is Nothing Then
                If ListaDeProductos.Count > 0 Then
                    'Obtener id del ultimo elemento agregado :Solo aplica si el id de la clase es entero
                    ultimoElemento = ListaDeProductos.OrderByDescending(Function(x) x.COMListadoDeProductosKey).First
                End If
            End If




            Dim elemento As New clsListadoDeProductos With {
             .COMListadoDeProductosKey = IIf(ultimoElemento Is Nothing, -1, ultimoElemento.COMListadoDeProductosKey - 1),
            .CodigoPresupuestal = values("CodigoPresupuestal"),
            .CodigoProducto = values("CodigoProducto"),
            .Descripcion = values("Descripcion"),
            .Cantidad = values("Cantidad"),
            .PrecioUnitario = values("PrecioUnitario"),
            .SubTotal = values("SubTotal"),
            .IVA = values("IVA"),
            .IVARetenido = values("IVARetenido"),
            .ISN = values("ISN"),
            .ISR = values("ISR"),
            .CostoTotal = values("CostoTotal"),
            .Habilitado = values("Habilitado"),
            .Proveedor = values("Proveedor")
            }


            ListaDeProductos.Add(elemento)
            Session("listaproductos") = ListaDeProductos
            grdListaProductos.DataBind()

        Catch ex As Exception
            strScript = Environment.NewLine & "Error en: " & System.Reflection.MethodInfo.GetCurrentMethod().ToString() & Environment.NewLine & Environment.NewLine & "Motivo:" & ex.Message &
             Environment.NewLine & Environment.NewLine & "Stack trace: " & ex.StackTrace
        End Try

        Return strScript
    End Function



    Function ModificarElemento(ByVal keys As OrderedDictionary, ByVal values As OrderedDictionary) As String
        Dim strScript As String = String.Empty
        Dim ListaDeProductos As New List(Of clsListadoDeProductos)

        Dim totalProductos As Decimal = 0
        Dim objListaRegistrosPorEliminar As New List(Of clsListadoDeProductos)
        Dim objListaRegistrosPorExcluir As New List(Of String)

        Try
            ListaDeProductos = Session("listaproductos")

            'idea:
            'Crear un CRUD tipo T en memoria
            'me pasan un objeto y quiero encontrar cual de sus propiedades o campos corresponde a las propiedades de mi clase destino

            'Esta seria creo la forma manual
            Dim id = Convert.ToInt32(keys("COMListadoDeProductosKey"))
            Dim elemento = ListaDeProductos.First(Function(i) i.COMListadoDeProductosKey = id)



            elemento.CodigoPresupuestal = values("CodigoPresupuestal")
            elemento.CodigoProducto = values("CodigoProducto")
            elemento.Descripcion = values("Descripcion")
            elemento.Cantidad = values("Cantidad")
            elemento.PrecioUnitario = values("PrecioUnitario")
            elemento.SubTotal = values("SubTotal")
            elemento.IVA = values("IVA")
            elemento.IVARetenido = values("IVARetenido")
            elemento.ISN = values("ISN")
            elemento.ISR = values("ISR")
            elemento.CostoTotal = values("CostoTotal")
            elemento.Habilitado = values("Habilitado")
            elemento.Proveedor = values("Proveedor")



            Session("listaproductos") = ListaDeProductos
            grdListaProductos.DataBind()

        Catch ex As Exception
            strScript = Environment.NewLine & "Error en: " & System.Reflection.MethodInfo.GetCurrentMethod().ToString() & Environment.NewLine & Environment.NewLine & "Motivo:" & ex.Message &
             Environment.NewLine & Environment.NewLine & "Stack trace: " & ex.StackTrace
        End Try

        Return strScript
    End Function

    Function EliminarElemento(ByVal keys As OrderedDictionary, ByVal values As OrderedDictionary) As String
        Dim strScript As String = String.Empty
        Dim ListaDeProductos As New List(Of clsListadoDeProductos)
        Dim objProducto As New clsListadoDeProductos
        Dim totalProductos As Decimal = 0
        Dim objListaRegistrosPorEliminar As New List(Of clsListadoDeProductos)
        Dim objListaRegistrosPorExcluir As New List(Of String)

        Try
            ListaDeProductos = Session("listaproductos")

            'idea:
            'Crear un CRUD tipo T en memoria
            'me pasan un objeto y quiero encontrar cual de sus propiedades o campos corresponde a las propiedades de mi clase destino

            'Esta seria creo la forma manual
            Dim id = Convert.ToInt32(keys("COMListadoDeProductosKey"))
            Dim item = ListaDeProductos.First(Function(i) i.COMListadoDeProductosKey = id)
            ListaDeProductos.Remove(item)
            Session("listaproductos") = ListaDeProductos
            grdListaProductos.DataBind()

        Catch ex As Exception
            strScript = Environment.NewLine & "Error en: " & System.Reflection.MethodInfo.GetCurrentMethod().ToString() & Environment.NewLine & Environment.NewLine & "Motivo:" & ex.Message &
             Environment.NewLine & Environment.NewLine & "Stack trace: " & ex.StackTrace
        End Try

        Return strScript
    End Function


End Class
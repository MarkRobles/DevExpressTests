<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmGridViewBatchUpdating.aspx.vb" Inherits="DevExpressTests.frmGridViewBatchUpdating" %>

<%@ Register Assembly="DevExpress.Web.v20.1, Version=20.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-12">
            <h1>CRUD DE PRUEBA CON LISTA DE OBJETOS TIPO ESPECIFICO EN MEMORIA
            </h1>
        </div>

        <div class="col-12">




            <dx:ASPxGridView ID="grdListaProductos" runat="server" AutoGenerateColumns="False" ClientInstanceName="grdListaProductos" EnableTheming="True" KeyboardSupport="True" KeyFieldName="COMListadoDeProductosKey"
                TabIndex="22" Theme="SoftOrange" Width="100%" OnBatchUpdate="grdListaProductos_BatchUpdate">
                <SettingsBehavior AllowSelectByRowClick="true" AllowFocusedRow="true" />
                <SettingsPager AlwaysShowPager="True">
                    <Summary AllPagesText="Páginas: {0} - {1} ({2} registros)" Text="Página {0} de {1} ({2} registros)" />
                    <PageSizeItemSettings Caption="Registros por página:" ShowAllItem="True" Visible="True">
                    </PageSizeItemSettings>
                </SettingsPager>
                <Settings HorizontalScrollBarMode="Visible" ShowFilterRow="True" ShowFilterRowMenu="True" ShowFooter="True" VerticalScrollBarMode="Auto" />
                <SettingsText CommandCancel="Cancelar" CommandDelete="Eliminar" CommandEdit="Editar" CommandNew="Nuevo" CommandUpdate="Actualizar" EmptyDataRow="No hay registros" GroupPanel="Arrastre la columna que desea agrupar" />
                <SettingsEditing Mode="Batch" />
                <Columns>
                    <dx:GridViewCommandColumn ShowNewButtonInHeader="true" ShowDeleteButton="true" VisibleIndex="0" />
                    <%--     <dx:GridViewCommandColumn ShowSelectCheckbox="true" SelectAllCheckboxMode="Page" VisibleIndex="1" Width="35">
                    </dx:GridViewCommandColumn>--%>
                    <dx:GridViewDataTextColumn FieldName="COMDetCatalogoPorProveedorKey" ShowInCustomizationForm="True" Visible="true" VisibleIndex="0" Width="0px">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="COMArticuloLink" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="GENProveedorLink" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="GENUnidadDeMedidaLink" ShowInCustomizationForm="True" Visible="False" VisibleIndex="1">
                    </dx:GridViewDataTextColumn>

                    <dx:GridViewDataTextColumn FieldName="Proveedor" Caption="Proveedor" ShowInCustomizationForm="True" Visible="true" VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="CodigoPresupuestal" Caption="Codigo <br>Presupuestal" ShowInCustomizationForm="True" Visible="true" VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="CodigoProducto" Caption="Codigo <br>Producto" ShowInCustomizationForm="True" Visible="true" VisibleIndex="3">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Descripcion" Caption="Descripcion <br>Producto" ShowInCustomizationForm="True" VisibleIndex="4" Visible="true">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="UnidadDeMedida" Caption="Unidad <br>de Medida" ShowInCustomizationForm="True" VisibleIndex="5">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Cantidad" Caption="Cantidad" ShowInCustomizationForm="True" VisibleIndex="6">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="PrecioUnitario" Caption="Precio<br> Unitario" ShowInCustomizationForm="True" VisibleIndex="7">
                        <PropertiesTextEdit DisplayFormatString="c2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="SubTotal" Caption="Subtotal" ShowInCustomizationForm="True" VisibleIndex="7">
                        <PropertiesTextEdit DisplayFormatString="c2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="IVA" Caption="IVA" ShowInCustomizationForm="True" VisibleIndex="8">
                        <PropertiesTextEdit DisplayFormatString="c2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ISR" Caption="ISR" ShowInCustomizationForm="True" VisibleIndex="9">
                        <PropertiesTextEdit DisplayFormatString="c2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="ISN" Caption="ISN" ShowInCustomizationForm="True" VisibleIndex="10">
                        <PropertiesTextEdit DisplayFormatString="c2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="CostoTotal" Caption="Costo Total" ShowInCustomizationForm="True" VisibleIndex="11">
                        <PropertiesTextEdit DisplayFormatString="c2">
                        </PropertiesTextEdit>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataCheckColumn FieldName="Habilitado" Caption="Habilitado"></dx:GridViewDataCheckColumn>
                </Columns>
                <TotalSummary>
                    <dx:ASPxSummaryItem ShowInColumn="Cantidad" FieldName="Cantidad" SummaryType="Sum" DisplayFormat="N2" />
                    <dx:ASPxSummaryItem ShowInColumn="Precio Unitario" FieldName="PrecioUnitario" SummaryType="Sum" DisplayFormat="C2" />
                    <dx:ASPxSummaryItem ShowInColumn="SubTotal" FieldName="SubTotal" SummaryType="Sum" DisplayFormat="C2" />
                    <dx:ASPxSummaryItem ShowInColumn="IVA" SummaryType="Sum" FieldName="IVA" DisplayFormat="C2"></dx:ASPxSummaryItem>
                    <dx:ASPxSummaryItem ShowInColumn="ISR" SummaryType="Sum" FieldName="ISR" DisplayFormat="C2"></dx:ASPxSummaryItem>
                    <dx:ASPxSummaryItem ShowInColumn="ISN" SummaryType="Sum" FieldName="ISN" DisplayFormat="C2"></dx:ASPxSummaryItem>
                    <dx:ASPxSummaryItem ShowInColumn="Costo Total" SummaryType="Sum" FieldName="CostoTotal" DisplayFormat="C2"></dx:ASPxSummaryItem>
                </TotalSummary>
            </dx:ASPxGridView>
        </div>
    </div>

</asp:Content>

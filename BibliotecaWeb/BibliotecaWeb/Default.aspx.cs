using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaWeb
{
    public partial class Default : System.Web.UI.Page
    {
        private DataAccess dataAccess = new DataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTodosLosLibros();
            }
        }

        private void CargarTodosLosLibros()
        {
            try
            {
                DataTable dt = dataAccess.EjecutarProcedimiento("sp_ObtenerTodosLosLibros", null);
                gvTodosLosLibros.DataSource = dt;
                gvTodosLosLibros.DataBind();
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar todos los libros: " + ex.Message);
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string terminoBusqueda = txtBusqueda.Text.Trim();
                DataTable dt = dataAccess.EjecutarProcedimiento("sp_BuscarLibros", new SqlParameter[] { new SqlParameter("@Termino", terminoBusqueda) });
                gvResultadosBusqueda.DataSource = dt;
                gvResultadosBusqueda.DataBind();
                lblResultados.Text = $"Se encontraron {dt.Rows.Count} resultado(s).";
                pnlResultadosBusqueda.Visible = true;
            }
            catch (Exception ex)
            {
                MostrarError("Error al buscar libros: " + ex.Message);
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Titulo", txtTitulo.Text),
                    new SqlParameter("@Autor", txtAutor.Text),
                    new SqlParameter("@ISBN", txtISBN.Text),
                    new SqlParameter("@Disponible", chkDisponible.Checked)
                };

                if (string.IsNullOrEmpty(hfLibroID.Value))
                {
                    // Insertar nuevo libro
                    dataAccess.EjecutarProcedimientoNonQuery("sp_InsertarLibro", parametros);
                    MostrarMensaje("Libro insertado correctamente.");
                }
                else
                {
                    // Actualizar libro existente
                    parametros = parametros.Concat(new[] { new SqlParameter("@ID", Convert.ToInt32(hfLibroID.Value)) }).ToArray();
                    dataAccess.EjecutarProcedimientoNonQuery("sp_ActualizarLibro", parametros);
                    MostrarMensaje("Libro actualizado correctamente.");
                }

                LimpiarFormulario();
                CargarTodosLosLibros();
            }
            catch (Exception ex)
            {
                MostrarError("Error al guardar el libro: " + ex.Message);
            }
        }

        protected void gvTodosLosLibros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int libroID = Convert.ToInt32(gvTodosLosLibros.DataKeys[index].Value);

                if (e.CommandName == "Editar")
                {
                    CargarLibroParaEditar(libroID);
                }
                else if (e.CommandName == "Eliminar")
                {
                    EliminarLibro(libroID);
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al procesar la acción: " + ex.Message);
            }
        }
        protected void gvTodosLosLibros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTodosLosLibros.PageIndex = e.NewPageIndex;
            CargarTodosLosLibros();
        }
        private void CargarLibroParaEditar(int libroID)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("@ID", libroID) };
                DataTable dt = dataAccess.EjecutarProcedimiento("sp_ObtenerLibroPorID", parametros);

                if (dt != null && dt.Rows.Count > 0)
                {
                    hfLibroID.Value = libroID.ToString();
                    txtTitulo.Text = dt.Rows[0]["Titulo"].ToString();
                    txtAutor.Text = dt.Rows[0]["Autor"].ToString();
                    txtISBN.Text = dt.Rows[0]["ISBN"].ToString();
                    chkDisponible.Checked = Convert.ToBoolean(dt.Rows[0]["Disponible"]);
                    btnGuardar.Text = "Actualizar";
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar el libro para editar: " + ex.Message);
            }
        }

        private void EliminarLibro(int libroID)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[] { new SqlParameter("@ID", libroID) };
                dataAccess.EjecutarProcedimientoNonQuery("sp_EliminarLibro", parametros);

                CargarTodosLosLibros();
                MostrarMensaje("Libro eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MostrarError("Error al eliminar el libro: " + ex.Message);
            }
        }

        private void LimpiarFormulario()
        {
            hfLibroID.Value = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtISBN.Text = "";
            chkDisponible.Checked = true;
            btnGuardar.Text = "Guardar";
        }

        private void MostrarError(string mensaje)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.CssClass = "alert alert-danger";
            lblMensaje.Visible = true;
        }

        private void MostrarMensaje(string mensaje)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.CssClass = "alert alert-success";
            lblMensaje.Visible = true;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public class DataAccess
{
    private string connectionString = ConfigurationManager.ConnectionStrings["BibliotecaDBConnection"].ConnectionString;

    public DataTable EjecutarProcedimiento(string nombreProcedimiento, SqlParameter[] parametros)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand(nombreProcedimiento, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros);
                }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
        }
    }

    public int EjecutarProcedimientoNonQuery(string nombreProcedimiento, SqlParameter[] parametros)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand(nombreProcedimiento, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros);
                }

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Webservice2
{
    public class DatosMesa
    {
        public DataSet getMesas()
        {
            DataSet dataTable = new DataSet();

            //A TRAVEZ DE LA CADENA DE CONEXION DEL WEBCONFIG Y LA OBTENEMOS  
            //CON EL CONFIGURATIONMANAGER 
            using (SqlConnection con = new SqlConnection(
                ConfigurationManager.ConnectionStrings["connectionLocal"]
                .ConnectionString))
            {
                //SE ABRE LA CONEXION 
                con.Open();

                //SE UTILIZA PARA LLENAR UN DATASET CON LOS ELEMENTOS NECESARIOS  
                //COMO UNA CONEXION DE BASE DE DATOS 
                using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(
                    "SELECT * FROM Mesa", con))
                {
                    //SE LLENA EL DATASET CON LOS DATOS OBTENIDOS EN EL SQLADAPTER 
                    sqlAdapter.Fill(dataTable);
                }
            }
            //REGRESAMOS LOS DATOS COMO DATOS EN MEMORIA 
            return dataTable;
        }
    }
    
}
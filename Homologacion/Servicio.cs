using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Homologacion
{
    class Servicio
    {
        protected Int32 idServicio { get; set; }
        protected String lugar { get; set; }
        protected String tipo { get; set; }
        protected DateTime horaInicio { get; set; }
        protected DateTime horaFin { get; set; }
        protected String curso { get; set; }
        protected Int32 año { get; set; }
        protected Int32 idMateria { get; set; }


        public Servicio(short idServicio)
        {
            this.idServicio = idServicio;
        }
        public Servicio(short idServicio, string lugar, string tipo, DateTime horaInicio, DateTime horaFin, String curso, Int32 año)
        {
            this.idServicio = idServicio;
            this.lugar = lugar;
            this.tipo = tipo;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.curso = curso;
            this.año = año;
        }
        public Servicio()
        {
        }
      
        public int agregar(Servicio s)
        {
            int res = 0;

            try
            {
                //abrir la conexión

                SqlConnection con;
                con = Conexion.conectar();
                //command para ejecutar ek query (insert)
                SqlCommand cmd = new SqlCommand(String.Format("insert into servicio (idServicio, lugar, horaInicio, horaFin, curso, año) values ({0}, '{1}','{2}','{3}',{4},{5}) ", s.idServicio, s.lugar, s.tipo, s.horaInicio, s.horaFin, s.curso, s.año), con);
                res = cmd.ExecuteNonQuery(); //núm de registros afectos 
                                             //CERRAR CONEXIÓN
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el Servicio" + ex);
            }

            return res;
        }
        public int eliminar(int cu)
        {
            int res = 0;
            try
            {
                //abrir conexion
                SqlConnection con;
                con = Conexion.conectar();

                //command para ejecutar el query (insert)
                SqlCommand cmd = new SqlCommand(String.Format("delete from servicio where idServicio = {0}", cu), con);
                //ejecutar query
                res = cmd.ExecuteNonQuery();
                //cerrar conexion
                con.Close();
            }
            catch (Exception ex)
            {
                res = -1;
            }

            return res;

        }
        public int modificar(Servicio s)
        {
            int res = 0;
            try
            {
                //abrir la conexión
                SqlConnection con;
                con = Conexion.conectar();
                //command para ejecutar ek query (update)
                SqlCommand cmd = new SqlCommand(String.Format("update servicio set correo = '{0}'  where claveUnica = {1}",s.lugar,  s.idServicio), con);
                res = cmd.ExecuteNonQuery(); //núm de registros afectos 
                                             //CERRAR CONEXIÓN
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alumno  no creado" + ex);
            }

            return res;

        }
        public List<Servicio> buscar(string nombre)
        {
            List<Servicio> lis = new List<Servicio>();
            Servicio s;
            SqlDataReader rd;

            //abrir la conexion 
            SqlConnection con;
            con = Conexion.conectar();

            //command para ejecutar el query (insert)
            SqlCommand cmd = new SqlCommand(String.Format("select * from alumno where nombre like '%{0}%'", nombre), con);
            //ejecutar el query
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                s = new Servicio();
                s.idServicio = rd.GetInt16(0);
                s.lugar = rd.GetString(1);
                s.tipo = rd.GetString(2);
                s.horaInicio = rd.GetDateTime(3);
                s.horaFin = rd.GetDateTime(4);
                s.año = rd.GetInt16(5);
                lis.Add(s);

            }

            con.Close();
            return lis;
        }
        public string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("Id del Servicio " + idServicio).Append(" Lugar " + lugar).Append(" Tipo " + tipo).Append("horaInicio " + horaInicio).Append("  horaFin" + horaFin).Append("  curso" + curso).Append(" año" + año);

            this.idServicio = idServicio;
            this.lugar = lugar;
            this.tipo = tipo;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.curso = curso;
            this.año = año;
            return res.ToString();
        }
    }
}

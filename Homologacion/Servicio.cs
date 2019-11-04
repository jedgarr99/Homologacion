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
        //atributos de la clase servicio 
        public Int32 idServicio { get; set; }
        public String lugar { get; set; }
        public String tipo { get; set; }
        public String horaInicio { get; set; }
        public String horaFin { get; set; }
        public String curso { get; set; }
        public Int32 año { get; set; }
        public Int32 idMateria { get; set; }
        public Int32 idDocente { get; set; }
        public String dia { get; set; }

        //constructores 
        public Servicio(short idServicio)
        {
            this.idServicio = idServicio;
        }
        public Servicio(short idServicio, string lugar, string tipo, String horaInicio, String horaFin, String curso, Int32 año, Int32 idMateria, String dia)
        {
            this.idServicio = idServicio;
            this.lugar = lugar;
            this.tipo = tipo;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.curso = curso;
            this.año = año;
            this.idMateria = idMateria;
            this.idDocente = 0;//corregir
            this.dia = dia;
        }
        public Servicio()
        {
        }

        public Servicio(short idServicio, String hora)
        {
            this.idServicio = idServicio;
            this.horaInicio = hora;
            this.horaFin = hora;
        }


        // agrega un servicio a la base de datos y regresa un entero ( es 0 si no lo agrego) 
        public int agregar(Servicio s)
        {
            int res = 0;

            try
            {
                //abrir la conexión

                SqlConnection con;
                con = Conexion.conectar();
                //command para ejecutar ek query (insert)
                SqlCommand cmd = new SqlCommand(String.Format("insert into servicios (idServicio, lugar, tipo, horaInicio, horaFin, curso, año,idMateria,idDocente,dia) values ({0}, '{1}','{2}','{3}','{4}','{5}',{6},{7},{8},'{9}')", s.idServicio, s.lugar, s.tipo, s.horaInicio, s.horaFin, s.curso, s.año, s.idMateria, s.idDocente, s.dia), con);
                res = cmd.ExecuteNonQuery(); //núm de registros afectos 
                                             //CERRAR CONEXIÓN
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el Servicio " + ex.Message);
            }

            return res;
        }
        // elimina servicios de la base de datos por su id, regresa 0 si no lo elimino 
        public int eliminar(int cu)
        {
            int res = 0;
            try
            {
                //abrir conexion
                SqlConnection con;
                con = Conexion.conectar();

                //command para ejecutar el query (insert)
                SqlCommand cmd = new SqlCommand(String.Format("delete from servicios where idServicio = {0}", cu), con);
                //ejecutar query
                res = cmd.ExecuteNonQuery();
                //cerrar conexion
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el servicio \n" + ex.Message);
            }

            return res;

        }
        // modifica la hora de inicio de un servicio en particular, regresa 0 si no modifico ninguno 
        public int modificarIn(Servicio s)
        {
            SqlCommand cmd;
            SqlConnection con;
            int res = 0;
            try
            {
                con = Conexion.conectar();
                cmd = new SqlCommand(String.Format("update servicios set horaInicio ='{0}' where idServicio = {1}", s.horaInicio, s.idServicio), con);
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar al alumno\n " + ex.Message);
            }
            return res;
        }
        // modifica la hora de fin de un servicio en particular, regresa 0 si no modifico ninguno 
        public int modificarFin(Servicio s)
        {
            SqlCommand cmd;
            SqlConnection con;
            int res = 0;
            try
            {

                con = Conexion.conectar();
                cmd = new SqlCommand(String.Format("update servicios set horaFin ='{0}' where idServicio = {1}", s.horaFin, s.idServicio), con);
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar al alumno\n " + ex.Message);
            }
            return res;
        }
        // busca los servicios que pertenezcan a la materia proporcionada, devuelve una lista de servios que se usaran para llenar un Data Grid 
        public List<Servicio> buscar(int idMateria)
        {
            List<Servicio> lis = new List<Servicio>();
            Servicio s;
            SqlDataReader rd;

            //abrir la conexion 
            SqlConnection con;
            con = Conexion.conectar();

            //command para ejecutar el query (insert)
            SqlCommand cmd = new SqlCommand(String.Format("select * from servicios where idMateria = {0}", idMateria), con);
            //ejecutar el query
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                s = new Servicio();
                s.idServicio = rd.GetInt16(0);
                s.lugar = rd.GetString(1);
                s.tipo = rd.GetString(2);
                s.horaInicio = rd.GetString(3);
                s.horaFin = rd.GetString(4);
                s.curso = rd.GetString(5);
                s.año = rd.GetInt16(6);
                s.idMateria = rd.GetInt16(7);
                s.idDocente = rd.GetInt16(8);
                s.dia = rd.GetString(9);
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

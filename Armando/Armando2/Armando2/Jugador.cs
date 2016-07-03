﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace Armando2
{
   public class Jugador
    {
        public int idJugador { get; set; }
        public static string username{ get; set; }
        public string nombre { get; set; }
        public int nivel { get; set; }
        public int completado{ get; set; }
        public int compledos { get; set; }
        public int compleSila { get; set; }
        private OleDbConnection Conn;

        public void AbrirConexion()
        {

            Conn = new OleDbConnection(Configuracion.ConnectionString);
            Conn.Open();
        }
        public void AgregameJugador()
        {
            nivel = 1;
            completado = 0;
            compledos = 0;
            compleSila = 0;
            AbrirConexion();
            OleDbCommand Consulta = Conn.CreateCommand();
            Consulta.CommandType = CommandType.StoredProcedure;
            Consulta.CommandText = "CreameJugador";
            OleDbParameter pNombre = new OleDbParameter("pNombre", nombre);
            OleDbParameter pNivel = new OleDbParameter("pNivel", nivel);
            OleDbParameter pComple = new OleDbParameter("pComple", completado);
            OleDbParameter pComple2 = new OleDbParameter("pComple2", compledos);
            OleDbParameter pSila = new OleDbParameter("pSila", compleSila);
            Consulta.Parameters.Add(pNombre);
            Consulta.Parameters.Add(pNivel);
            Consulta.Parameters.Add(pComple);
            Consulta.Parameters.Add(pComple2);
            Consulta.Parameters.Add(pSila);
            Consulta.ExecuteNonQuery();
            Conn.Close();
        }
        public List<Jugador> Jugadores()
        {
            AbrirConexion();
            OleDbCommand Consulta = Conn.CreateCommand();
            Consulta.CommandType = CommandType.StoredProcedure;
            Consulta.CommandText = "ListameJugadores";
            OleDbDataReader traido = Consulta.ExecuteReader();
            List<Jugador> lista = new List<Jugador>();
            while (traido.Read())
            {
                Jugador juga = new Jugador();
                juga.idJugador = Convert.ToInt32(traido["IdJugador"]);
                juga.nombre = traido["Nombre"].ToString();
                juga.nivel = Convert.ToInt32(traido["Nivel"]);
                juga.completado = Convert.ToInt32(traido["Completado"]);
                juga.compledos = Convert.ToInt32(traido["CompleDos"]);
                juga.compleSila = Convert.ToInt32(traido["CompleSila"]);
                lista.Add(juga);
            }
            Conn.Close();
            return lista;
        }
        public void Modificar()
        {
            AbrirConexion();
            OleDbCommand Consulta = Conn.CreateCommand();
            Consulta.CommandType = CommandType.StoredProcedure;
            Consulta.CommandText = "ModificameJugador";
            OleDbParameter pNombre = new OleDbParameter("pNombre", nombre);
            OleDbParameter pNivel = new OleDbParameter("pNivel", nivel);
            OleDbParameter pComple = new OleDbParameter("pComple", completado);
            OleDbParameter pComple2 = new OleDbParameter("pComple2", compledos);
            OleDbParameter pSila = new OleDbParameter("pSila", compleSila);
            OleDbParameter pid = new OleDbParameter("pid", idJugador);
            Consulta.Parameters.Add(pNombre);
            Consulta.Parameters.Add(pNivel);
            Consulta.Parameters.Add(pComple);
            Consulta.Parameters.Add(pComple2);
            Consulta.Parameters.Add(pSila);
            Consulta.Parameters.Add(pid);
            
            Consulta.ExecuteNonQuery();

            Conn.Close();
        }
        public void Traemelo(string nomb)
        {
            AbrirConexion();
            OleDbCommand Consulta = Conn.CreateCommand();
            Consulta.CommandType = CommandType.StoredProcedure;
            Consulta.CommandText = "TraemeJugador";
            OleDbParameter pid = new OleDbParameter("pNombre", nomb);
            Consulta.Parameters.Add(pid);
            OleDbDataReader traido = Consulta.ExecuteReader();

            while (traido.Read())
            {

                idJugador = Convert.ToInt32(traido["IdJugador"]);
                nombre = nomb;
                nivel= Convert.ToInt32(traido["Nivel"]);
                completado= Convert.ToInt32(traido["Completado"]);
                compledos = Convert.ToInt32(traido["CompleDos"]);
                compleSila = Convert.ToInt32(traido["CompleSila"]);


            }
            Conn.Close();

        }
    }
}

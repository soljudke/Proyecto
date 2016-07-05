using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace Armando2
{
    class palabras
    {
        public int idPalabra { get; set; }
        public string palabra { get; set; }
        public int cantLetras { get; set; }
        public string foto { get; set; }
        public int nivel { get; set; }
        public int nivo { get; set; }
        public int cantSilabas { get; set; }
        public string silaba { get; set; }
        private int num1=1;
        private int num2 = 7;
        private int num3 = 7;
        private OleDbConnection Conn;
        Jugador jug = new Jugador();
        public void AbrirConexion()
        {

            Conn = new OleDbConnection(Configuracion.ConnectionString);
            Conn.Open();
        }
        public void Traelo()
        { jug.Traemelo(Jugador.username);

            if (nivo == 1)
            {
             
                idPalabra = jug.completado;
               /* if (num1 <= 6)
                    num1++;
                else
                    num1 = 1;*/
                nivel = 1;
                AbrirConexion();
                OleDbCommand Consulta = Conn.CreateCommand();
                Consulta.CommandType = CommandType.StoredProcedure;
                Consulta.CommandText = "Traer_Palabra";
                OleDbParameter pCod = new OleDbParameter("pPala", idPalabra);
                OleDbParameter pCod2 = new OleDbParameter("pNivel", nivel);
                Consulta.Parameters.Add(pCod);
                Consulta.Parameters.Add(pCod2);
                OleDbDataReader traido = Consulta.ExecuteReader();
                while (traido.Read())
                {

                    idPalabra = idPalabra;
                    palabra = traido["Palabra"].ToString();
                    foto = traido["Foto"].ToString();
                    cantLetras = Convert.ToInt32(traido["CantDeLetras"]);

                }
                Conn.Close();
            }
            else if (nivo == 2)
            {
                idPalabra = jug.compledos+6;
                
                nivel = 2;
                AbrirConexion();
                OleDbCommand Consulta = Conn.CreateCommand();
                Consulta.CommandType = CommandType.StoredProcedure;
                Consulta.CommandText = "Traer_Palabra";
                OleDbParameter pCod = new OleDbParameter("pPala", idPalabra);
                OleDbParameter pCod2 = new OleDbParameter("pNivel", nivel);
                Consulta.Parameters.Add(pCod);
                Consulta.Parameters.Add(pCod2);
                OleDbDataReader traido = Consulta.ExecuteReader();
                while (traido.Read())
                {

                    idPalabra = idPalabra;
                    palabra = traido["Palabra"].ToString();
                    foto = traido["Foto"].ToString();
                    cantLetras = Convert.ToInt32(traido["CantDeLetras"]);

                }
                Conn.Close();
            }
        }
        public void TraemeSilaba()
        {
            jug.Traemelo(Jugador.username);
            idPalabra = jug.compleSila+6;
            /*if (num3 <= 13)
                num3++;
            else
                num3 = 7;*/
            //Random random = new Random();
            //int randomNumberr = random.Next(7, 13);
            //idPalabra = randomNumberr;
            AbrirConexion();
            OleDbCommand Consulta = Conn.CreateCommand();
            Consulta.CommandType = CommandType.StoredProcedure;
            Consulta.CommandText = "Traer_Silaba";
            OleDbParameter pCod = new OleDbParameter("pPala", idPalabra);
            Consulta.Parameters.Add(pCod);
            OleDbDataReader traido = Consulta.ExecuteReader();
            while (traido.Read())
            {

                idPalabra = idPalabra;
                silaba = traido["Silabas"].ToString();
                foto = traido["Foto"].ToString();
                cantSilabas = Convert.ToInt32(traido["CantSilabas"]);

            }
            Conn.Close();
        }

    }
}


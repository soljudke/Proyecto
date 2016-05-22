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
        private OleDbConnection Conn;

        public void AbrirConexion()
        {
            Conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\c\Desktop\Proyecto\Database21.accdb"); 
            Conn.Open();
        }
        public void Traelo()
        {
            Random random = new Random();
            int randomNumberr = random.Next(1, 4);
            idPalabra = randomNumberr;
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
                
                idPalabra= idPalabra;
                palabra = traido["Palabra"].ToString();
                foto = traido["Foto"].ToString();
                cantLetras = Convert.ToInt32(traido["CantDeLetras"]);

            }
            Conn.Close();
        }
    }
}

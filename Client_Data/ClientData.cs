using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Client_Data
{
    public class ClientData
    {
        public int InsertClient(Client client)
        {
            SqlConnection cnx = new SqlConnection("Data Source=LFR024533'\'SQLEXPRESS;Initial Catalog=architecture;Integrated Security=True");
            cnx.Open();
            SqlCommand cmd = new SqlCommand("insertclient", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter prmnom = new SqlParameter("nom", System.Data.SqlDbType.VarChar, 20);
            prmnom.Value = client.nom;
            cmd.Parameters.Add(prmnom);
            SqlParameter prmprenom = new SqlParameter("prenom", SqlDbType.VarChar, 20);
            prmprenom.Value = client.prenom;
            cmd.Parameters.Add(prmprenom);
            SqlParameter prmtel = new SqlParameter("tel", SqlDbType.VarChar, 20);
            prmtel.Value = client.tel;
            SqlParameter prmadresse = new SqlParameter("adresse", SqlDbType.VarChar, 20);
            prmadresse.Value = client.adresse;
            int result = Convert.ToInt32(cmd.ExecuteNonQuery());
            return result;
        }

        public int UpdateClient (Client client)
        {
            SqlConnection cnx = new SqlConnection("Data Source=LFR024533'\'SQLEXPRESS;Initial Catalog=architecture;Integrated Security=True");
            cnx.Open();
            SqlCommand cmd = new SqlCommand("updateclient", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter prmid = new SqlParameter("id", SqlDbType.Int, 20);
            prmid.Value = client.nom;
            cmd.Parameters.Add(prmid);
            SqlParameter prmnom = new SqlParameter("nom", SqlDbType.VarChar, 20);
            prmnom.Value = client.nom;
            cmd.Parameters.Add(prmnom);
            SqlParameter prmprenom = new SqlParameter("prenom", SqlDbType.VarChar, 20);
            prmprenom.Value = client.prenom;
            cmd.Parameters.Add(prmprenom);
            SqlParameter prmtel = new SqlParameter("tel", SqlDbType.VarChar, 20);
            prmtel.Value = client.tel;
            cmd.Parameters.Add(prmtel);
            SqlParameter prmadresse = new SqlParameter("adresse", SqlDbType.VarChar, 20);
            prmadresse.Value = client.adresse;
            cmd.Parameters.Add(prmadresse);
            int result = Convert.ToInt32(cmd.ExecuteNonQuery());
            return result;
        }

        public void DeleteClient(int client)
        {
            SqlConnection cnx = new SqlConnection("Data Source=LFR024533'\'SQLEXPRESS;Initial Catalog=architecture;Integrated Security=True");
            cnx.Open();
            SqlCommand cmd = new SqlCommand("deleteclient", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter prmid = new SqlParameter("id", SqlDbType.Int, 20);
            prmid.Value = client;
            cmd.Parameters.Add(prmid);
            cmd.ExecuteNonQuery();
        }

        public DataTable SelectClient()
        {
            SqlConnection cnx = new SqlConnection("Data Source=LFR024533'\'SQLEXPRESS;Initial Catalog=architecture;Integrated Security=True");
            cnx.Open();
            SqlCommand cmd = new SqlCommand("selectclient", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable VerifClientBeforeInsert(string paramNumero)
        {
            SqlConnection cnx = new SqlConnection("Data Source=LFR024533'\'SQLEXPRESS;Initial Catalog=architecture;Integrated Security=True");
            cnx.Open();
            SqlCommand cmd = new SqlCommand("VerifNumeroBeforeInsert", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weselny_ERP
{
    class SqlOperations
    {
        private string bride { get; set; }
        private string brideAdress { get; set; }
        private string bridePhone { get; set; }
        private string groom { get; set; }
        private string groomAdress { get; set; }
        private string groomPhone { get; set; }
        private string wedDate { get; set; }
        private string wedPlace { get; set; }

        public int jurnal { get; set; }
        public int sesion { get; set; }
        public int engag { get; set; }
        public string engagPaid { get; set; }
        public int photobook { get; set; }
        public int extraPhotobook { get; set; }
        public int paint { get; set; }
        public int prints { get; set; }
        public int guestPaid { get; set; }
        public int guestToPay { get; set; }
        public int travel { get; set; }
        public int pase { get; set; }
        public string wedPaid { get; set; }

        public int year { get; set; }
        public string month { get; set; }
        public string source { get; set; }
        public string date { get; set; }
        public int qoute { get; set; }
        public string meeting { get; set; }
        public string contract { get; set; }
        public string name { get; set; }

        public string size { get; set; }
        public int estate { get; set; }
        public int reserv { get; set; }
        public int av { get; set; }
        public DataSet data = new DataSet();

        public void SqlModify(string command, string customerID)
        {
            ConnectionString connect = new ConnectionString(); 
            connect.Connect();
            connect.con.Open();
            MySqlCommand com = new MySqlCommand(command);

            com.Parameters.AddWithValue("@ID", customerID);
            com.Parameters.AddWithValue("@bride", bride);
            com.Parameters.AddWithValue("@brideAdress", brideAdress);
            com.Parameters.AddWithValue("@bridePhone", bridePhone);
            com.Parameters.AddWithValue("@groom", groom);
            com.Parameters.AddWithValue("@groomAdress", groomAdress);
            com.Parameters.AddWithValue("@groomPhone", groomPhone);
            com.Parameters.AddWithValue("@weddingDate", wedDate);
            com.Parameters.AddWithValue("@weddingPlace", wedPlace);

            com.Parameters.AddWithValue("@jurnal", jurnal);
            com.Parameters.AddWithValue("@sesion", sesion);
            com.Parameters.AddWithValue("@engagment", engag);
            com.Parameters.AddWithValue("@engPaid", engagPaid);
            com.Parameters.AddWithValue("@photobook", photobook);
            com.Parameters.AddWithValue("@extraPhoto", extraPhotobook);
            com.Parameters.AddWithValue("@paint", paint);
            com.Parameters.AddWithValue("@prints", prints);
            com.Parameters.AddWithValue("@guestPaid", guestPaid);
            com.Parameters.AddWithValue("@guestToPay", guestToPay);
            com.Parameters.AddWithValue("@travel", travel);
            com.Parameters.AddWithValue("@wedPaid", wedPaid);
            com.Parameters.AddWithValue("@pase", pase);

            com.Parameters.AddWithValue("@year", year);
            com.Parameters.AddWithValue("@month", month);
            com.Parameters.AddWithValue("@source", source);
            com.Parameters.AddWithValue("@date", date);
            com.Parameters.AddWithValue("@qoute", qoute);
            com.Parameters.AddWithValue("@meeting", meeting);
            com.Parameters.AddWithValue("@contract", contract);
            com.Parameters.AddWithValue("@name", name);

            com.Parameters.AddWithValue("@size", size);
            com.Parameters.AddWithValue("@estate", estate);
            com.Parameters.AddWithValue("@reserv", reserv);
            com.Parameters.AddWithValue("@av", estate - reserv);

            com.Connection = connect.con;
            com.ExecuteNonQuery();
            connect.con.Close();
        }
        public void SqlLoad(string table, string customerID)
        {
            ConnectionString connect = new ConnectionString();
            connect.Connect();
            connect.con.Open();
            MySqlCommand select = new MySqlCommand("SELECT * FROM " + table);
            MySqlDataAdapter adap = new MySqlDataAdapter(select);
            adap.Fill(data);
            connect.con.Close();            
        }
    }
}

using System.Data;
using System.Data.SqlClient; 
namespace SQL
{
    [Serializable()]
    public class Sql
    {
        SqlConnection Connection;
        SqlDataAdapter Adapter = new SqlDataAdapter();
        SqlCommand Command = new SqlCommand();
        public bool ConnectionState { get; set; }
        public Sql(string connectionstring)
        {
            Connection = new SqlConnection(connectionstring);
            object value = Command.Parameters.Add("@p1",SqlDbType.VarChar);
            ConnectionState = false;
        }
        public bool ConnectionOpen()
        {
            try
            {
                Connection.Open();
                ConnectionState = true;
                return true;
            }
            catch (Exception ex)
            {
                ConnectionState = false;
                return false;
            }
        }
        public bool ConnectionClose()
        {
            try
            {
                Connection.Close();
                ConnectionState = false;
                return true;
            }
            catch (Exception ex)
            {
                ConnectionState = true;
                return false;
            }
        }
        public DataTable GetTable(string tablename, string kolonnames, string kriter)
        {
            DataTable table = new DataTable();
            string commandtext = "SELECT " + kolonnames + " FROM " + tablename + " " + kriter;
            Command.Connection = Connection;
            Command.CommandText = commandtext;
            Adapter.SelectCommand = Command;
            Adapter.Fill(table);
            return table;
        }
        public long GetTableBigint(string tablename, string kolonnames, string kriter)
        {
            DataTable table = new DataTable();
            long deger = -1;
            string commandtext = "SELECT " + kolonnames + " FROM " + tablename + " " + kriter;
            Command.Connection = Connection;
            Command.CommandText = commandtext;
            Adapter.SelectCommand = Command;
            Adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                deger = (long)(table.Rows[0][0]);
            }
            return deger;
        }
        public string GetTableString(string tablename, string kolonnames, string kriter)
        {
            DataTable table = new DataTable();
            string deger = "";
            string commandtext = "SELECT " + kolonnames + " FROM " + tablename + " " + kriter;
            Command.Connection = Connection;
            Command.CommandText = commandtext;
            Adapter.SelectCommand = Command;
            Adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                deger = (string)(table.Rows[0][0]);
            }
            return deger;
        }
        public bool Delete(string tablename, string kriter)
        {
            string commandtext = "DELETE FROM " + tablename + " " + kriter;
            Command.Connection = Connection;
            Command.CommandText = commandtext;
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool Update(string tablename, string values, string kriter)
        {
            string commandtext = "UPDATE " + tablename + " SET " + values + " " + kriter;
            Command.Connection = Connection;
            Command.CommandText = commandtext;
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool Insert(string tablename, string kolonnames, string values, string kriter)
        {
            string commandtext = "INSERT INTO " + tablename + "(" + kolonnames + ") values(" + values + ") " + kriter;
            Command.Connection = Connection;
            Command.CommandText = commandtext;
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool InsertKayit(DateTime kayitzamani, string recetekodu, string receteadi,
                                          int batchno, int kayitidentity,
                                          float hedefbb1, float toleransbb1, float alinanbb1, float hatabb1,
                                          float hedefbb2, float toleransbb2, float alinanbb2, float hatabb2,
                                          float hedefkms1, float toleranskms1, float alinankms1, float hatakms1,
                                          float hedefkms2, float toleranskms2, float alinankms2, float hatakms2,
                                          float hedefkms3, float toleranskms3, float alinankms3, float hatakms3,
                                          float hedefkms4, float toleranskms4, float alinankms4, float hatakms4,
                                          float hedefkms5, float toleranskms5, float alinankms5, float hatakms5,
                                          float hedefkms6, float toleranskms6, float alinankms6, float hatakms6,
                                          float hedefbbd, float toleransbbd, float alinanbbd, float hatabbd)
        {
            string tarihx = kayitzamani.ToString("yyyy-MM-dd HH:mm:ss");
            string commandtext = "INSERT INTO Records(SaatTarih,ReceteKodu,ReceteAdi,BatchNo,KayitIdentity," +
                                                     "HedefBB1,ToleransBB1,AlinanBB1,HataBB1," +
                                                     "HedefBB2,ToleransBB2,AlinanBB2,HataBB2," +
                                                     "HedefKMS1,ToleransKMS1,AlinanKMS1,HataKMS1," +
                                                     "HedefKMS2,ToleransKMS2,AlinanKMS2,HataKMS2," +
                                                     "HedefKMS3,ToleransKMS3,AlinanKMS3,HataKMS3," +
                                                     "HedefKMS4,ToleransKMS4,AlinanKMS4,HataKMS4," +
                                                     "HedefKMS5,ToleransKMS5,AlinanKMS5,HataKMS5," +
                                                     "HedefKMS6,ToleransKMS6,AlinanKMS6,HataKMS6," +
                                                     "HedefBBD,ToleransBBD,AlinanBBD,HataBBD" +
                                                     ") values(" +
                                  "'" + tarihx + "'" + ",'" + recetekodu + "','" + receteadi + "'," + batchno + "," + kayitidentity + "," +
                                  hedefbb1 + "," + toleransbb1 + "," + alinanbb1 + "," + hatabb1 + "," +
                                  hedefbb2 + "," + toleransbb2 + "," + alinanbb2 + "," + hatabb2 + "," +
                                  hedefkms1 + "," + toleranskms1 + "," + alinankms1 + "," + hatakms1 + "," +
                                  hedefkms2 + "," + toleranskms2 + "," + alinankms2 + "," + hatakms2 + "," +
                                  hedefkms3 + "," + toleranskms3 + "," + alinankms3 + "," + hatakms3 + "," +
                                  hedefkms4 + "," + toleranskms4 + "," + alinankms4 + "," + hatakms4 + "," +
                                  hedefkms5 + "," + toleranskms5 + "," + alinankms5 + "," + hatakms5 + "," +
                                  hedefkms6 + "," + toleranskms6 + "," + alinankms6 + "," + hatakms6 + "," +
                                  hedefbbd + "," + toleransbbd + "," + alinanbbd + "," + hatabbd +
                                  ")";
            Command.Connection = Connection;
            Command.CommandText = commandtext;
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
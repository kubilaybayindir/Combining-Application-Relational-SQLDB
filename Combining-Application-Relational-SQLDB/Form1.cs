using System;
using System.Drawing;
using System.Windows.Forms; 


namespace Combining_Application_Relational_SQLDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SQLDB sqlDb = new SQLDB();
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlDb.Sql(Properties.Settings.Default.ConnectionString);
            ListAllActions();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ListAllActions()
        {
            sqlDb.ConnectionOpen();
            DgvDB.DataSource = sqlDb.GetTableFromProcedure("TestRelationalDB");
            sqlDb.ConnectionClose();
        }

        private void BtChangeBColor_Click(object sender, EventArgs e)
        {
            Color[] colors = new Color[] { Color.PeachPuff, Color.Khaki, Color.Tan, Color.Magenta, Color.Yellow, Color.AliceBlue, Color.Azure, Color.Bisque, Color.AntiqueWhite };
            Random random = new Random();
            this.BackColor = colors[random.Next(colors.Length)];
        }

        private void BtCustomers_Click(object sender, EventArgs e)
        {
            sqlDb.ConnectionOpen();
            DgvDB.DataSource = sqlDb.GetTable("Customers","*","");
            sqlDb.ConnectionClose();
        }

        private void BtProducts_Click(object sender, EventArgs e)
        {
            sqlDb.ConnectionOpen();
            DgvDB.DataSource = sqlDb.GetTable("Products", "*", "");
            sqlDb.ConnectionClose();
        }

        private void BtStaffs_Click(object sender, EventArgs e)
        {
            sqlDb.ConnectionOpen();
            DgvDB.DataSource = sqlDb.GetTable("Staffs", "*", "");
            sqlDb.ConnectionClose();
        }
    }
}

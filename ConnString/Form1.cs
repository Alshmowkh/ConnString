using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = "Server=(localdb)\v11.0;Integrated Security=true";
            //goooooood//conn.ConnectionString = @"server=(localdb)\v11.0;integrated security=true   ;attachdbfilename=f:\desgin\C#\connString\mdf\data2.mdf";
                          //goooooood//conn.ConnectionString = @"server=(localdb)\v11.0;attachdbfilename=f:\desgin\c#\connstring\mdf\data2.mdf";
            /*
            SqlConnectionStringBuilder connbuld = new SqlConnectionStringBuilder();
            connbuld.DataSource = "(localdb)\\v11.0";
            connbuld.AttachDBFilename = @"f:\desgin\c#\connstring\mdf\db project.mdf";
            conn.ConnectionString = connbuld.ConnectionString ;    */

            //conn.ConnectionString = "data source=(localdb)\\v11.0;initial catalog=data2;integrated security=true";
            //conn.ConnectionString = @"data source=localhost; AttachDBFilename =f:\desgin\c#\connstring\mdf\db project.mdf";
          
            
            
            
            
              conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da = new SqlDataAdapter("select * from talent", conn);
            da.Fill(ds, "tb");
           for(int i=0;i < ds.Tables["tb"].Rows.Count;i++)
            {
                comboBox1.Items.Add(ds.Tables["tb"].Rows[i].ItemArray[1]);
            }
           conn.Close();
           comboBox1.Text = comboBox1.Items[0].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KeyPreview = true;  
        }
    }
}

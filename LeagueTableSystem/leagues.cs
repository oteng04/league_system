using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueTableSystem
{
    public partial class leagues : Form
    {

        String insert,  picName;
        DataTable dataTable;
        public leagues()
        {
            InitializeComponent();
        }

        private void labelLeagueName_Click(object sender, EventArgs e)
        {
              }


        private void Create()
        {
            string Insert = "INSERT INTO Leagues (League_ID,League_Name, League_Logo) VALUES('" + idd.Text + "','" + namee.Text + "','" + picName + "')";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Leagues_Table(Insert);
        }

        private void delete()
        {
            string Insert = "Delete Leagues where League_ID = '" + idd.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Leagues_Table(Insert);
        }

        private void AddSavebtn_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void picc_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "select a jpeg image";
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = false;
            

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                try {
                    picc.Load(openFileDialog1.FileName);
                    picName = openFileDialog1.SafeFileName;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }


        }
    }
}

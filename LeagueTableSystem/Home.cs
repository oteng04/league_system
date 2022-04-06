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
    public partial class Home : Form
    {
        String picName = "serie-a.jpg";
        String Name = "Italian Serie A";
        public Home()
        {
            InitializeComponent();
        }

        private void SplitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    
        private void buttonEpl_Click(object sender, EventArgs e)
        {
            Epl epl = new Epl();
           

             
            epl.iconLeague.BackgroundImage = Properties.Resources.epl;
            epl.leagueTitle = "English Premier League";
            AddScores.leagueInt = 1;
            AddTeams.leagueInt = 1;
            Epl.leagueInt = 1;


            epl.Show();
            this.Hide();
           
        

        }

        private void buttonLaliga_Click(object sender, EventArgs e)
        {
            Epl epl = new Epl();
            
            epl.iconLeague.BackgroundImage = Properties.Resources.laliga;
            epl.leagueTitle = "Spanish Laliga";
            AddScores.leagueInt = 2;
            AddTeams.leagueInt = 2;
            Epl.leagueInt = 2;
            epl.Show();
            this.Hide();
        }
         
        private void Home_Load(object sender, EventArgs e)
        {
            buttonEpl.BackgroundImage = Properties.Resources.stadMain;
            buttonEpl.Focus();
             
        }
        public void selectAll()
        {
            String selectAllRecords = "SELECT * From Leagues";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Leagues_Table(selectAllRecords);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            
            if (!e.Cancel && e.CloseReason == CloseReason.UserClosing)
            {


                e.Cancel = true;
                
        
                    DialogResult result = MessageBox.Show("Do you want to Exit?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                   
                    Application.Exit();
                    }


            }
           
        }

        private void Create()
        {
            string Insert = "INSERT INTO Leagues (League_Name, League_Logo) VALUES('" + Name + "','" + picName + "')";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Leagues_Table(Insert);
        }

        private void buttonSerieA_Click(object sender, EventArgs e)
        {
            Epl epl = new Epl();
            epl.iconLeague.BackgroundImage = Properties.Resources.serie_a;
            epl.leagueTitle = "Italian Serie A";
            AddScores.leagueInt = 3;
            AddTeams.leagueInt = 3;
            Epl.leagueInt = 3;
            epl.Show();
            this.Hide();
        }

        private void buttonBundesliga_Click(object sender, EventArgs e)
        {
            Epl epl = new Epl();
            epl.iconLeague.BackgroundImage = Properties.Resources.bundesliga;
            epl.leagueTitle = "German Bundesliga";
            AddScores.leagueInt = 4;
            AddTeams.leagueInt = 4;
            Epl.leagueInt = 4;
            epl.Show();
            this.Hide();
        }

        private void buttonLigue1_Click(object sender, EventArgs e)
        {
            Epl epl = new Epl();
            epl.iconLeague.BackgroundImage = Properties.Resources.league1;
            epl.leagueTitle = "French Ligue 1";
            AddScores.leagueInt = 5;
            AddTeams.leagueInt = 5;
            Epl.leagueInt = 5;
            epl.Show();
            this.Hide();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bhandled = false;
            

            switch(keyData)
            {
                case Keys.Down:
                    if (buttonEpl.Focused)
                    {
                        buttonLaliga.Focus();
                        buttonEpl.BackgroundImage = null;
                        buttonLigue1.BackgroundImage = null;
                        buttonSerieA.BackgroundImage = null;
                        buttonBundesliga.BackgroundImage = null;
                        buttonLaliga.BackgroundImage = Properties.Resources.stadMain;
                        bhandled = true;

                    }

                    else if (buttonLaliga.Focused)
                    {
                        buttonSerieA.Focus();
                        buttonEpl.BackgroundImage = null;
                        buttonLigue1.BackgroundImage = null;
                        buttonSerieA.BackgroundImage = Properties.Resources.stadMain;
                        buttonBundesliga.BackgroundImage = null;
                        buttonLaliga.BackgroundImage = null;
                        bhandled = true;

                    }

                    else if (buttonSerieA.Focused)
                    {
                        buttonBundesliga.Focus();
                        buttonEpl.BackgroundImage = null;
                        buttonLigue1.BackgroundImage = null;
                        buttonSerieA.BackgroundImage = null;
                        buttonBundesliga.BackgroundImage = Properties.Resources.stadMain;
                        buttonLaliga.BackgroundImage = null;
                        bhandled = true;

                    }

                    else if (buttonBundesliga.Focused)
                    {
                        buttonLigue1.Focus();
                        buttonEpl.BackgroundImage = null;
                        buttonLigue1.BackgroundImage = Properties.Resources.stadMain;
                        buttonSerieA.BackgroundImage = null;
                        buttonBundesliga.BackgroundImage = null;
                        buttonLaliga.BackgroundImage = null;
                        bhandled = true;

                    }

                    else if (buttonLigue1.Focused)
                    {
                        buttonEpl.Focus();
                        buttonEpl.BackgroundImage = Properties.Resources.stadMain;
                        buttonLigue1.BackgroundImage = null;
                        buttonSerieA.BackgroundImage = null;
                        buttonBundesliga.BackgroundImage = null;
                        buttonLaliga.BackgroundImage = null;
                        bhandled = true;

                    }
                    break;

                case Keys.Up:
                    if (buttonEpl.Focused)
                    {
                        buttonLigue1.Focus();
                        buttonEpl.BackgroundImage = null;
                        buttonLigue1.BackgroundImage = Properties.Resources.stadMain;
                        buttonSerieA.BackgroundImage = null;
                        buttonBundesliga.BackgroundImage = null;
                        buttonLaliga.BackgroundImage = null;
                        bhandled = true;

                    }

                    else if (buttonLaliga.Focused)
                    {
                        buttonEpl.Focus();
                        buttonEpl.BackgroundImage = Properties.Resources.stadMain;
                        buttonLigue1.BackgroundImage = null;
                        buttonSerieA.BackgroundImage = null;
                        buttonBundesliga.BackgroundImage = null;
                        buttonLaliga.BackgroundImage = null;
                        bhandled = true;

                    }

                    else if (buttonSerieA.Focused)
                    {
                        buttonLaliga.Focus();
                        buttonEpl.BackgroundImage = null;
                        buttonLigue1.BackgroundImage = null;
                        buttonSerieA.BackgroundImage = null;
                        buttonBundesliga.BackgroundImage = null;
                        buttonLaliga.BackgroundImage = Properties.Resources.stadMain;
                        bhandled = true;

                    }

                    else if (buttonBundesliga.Focused)
                    {
                       buttonSerieA.Focus();
                        buttonEpl.BackgroundImage = null;
                        buttonLigue1.BackgroundImage = null;
                        buttonSerieA.BackgroundImage = Properties.Resources.stadMain;
                        buttonBundesliga.BackgroundImage = null;
                        buttonLaliga.BackgroundImage = null;
                        bhandled = true;

                    }

                    else if (buttonLigue1.Focused)
                    {
                        buttonBundesliga.Focus();
                        buttonEpl.BackgroundImage = null;
                        buttonLigue1.BackgroundImage = null;
                        buttonSerieA.BackgroundImage = null;
                        buttonBundesliga.BackgroundImage = Properties.Resources.stadMain;
                        buttonLaliga.BackgroundImage = null;
                        bhandled = true;

                    }
                    break;

                case Keys.Home:
                    DialogResult result = MessageBox.Show("Do you want to Exit?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        Application.Exit();

                    }

                    
                    break;

            }



            return bhandled;
        }

        

        
    }

    


}

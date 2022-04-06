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
    public partial class Epl : Form
    {
        public static int popInt = 0;
        public String leagueTitle;
        String leagueCode;

        public static int leagueInt;


         

        public Epl()
        {
            InitializeComponent();
        }

        private void SplitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        public void refreshData(String Tcode)
        {
            String selectAllRecords = "SELECT Teams.Team_Name AS 'TEAMS',Team_Records.Matches_Played AS 'MATCHES PLAYED', Team_Records.GF,Team_Records.GA,Team_Records.GD,Team_Records.Points AS 'POINTS'  From Teams,Team_Records  Where Teams.Team_ID = Team_Records.Team_ID And Teams.League_ID = '" + Tcode + "' Order By Team_Records.Points DESC ,  Team_Records.GD DESC, Team_Records.GF DESC";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Records_Table(selectAllRecords);
            //Epl.AllData.DataSource = sql.Records_Table(selectAllRecords);
            
        }

        private void Epl_Load(object sender, EventArgs e)
        {
            Nammme.Text = leagueTitle;
            MD.Text = "MATCHDAY " + matchNum.Text + " ";
            buttonAddScores.Select();
            buttonAddScores.Enabled = true;


            // selectFix();

            
            if (leagueInt == 1) {

                leagueCode = "EPL";
                selectAll(leagueCode);


                if (selectFixtures(leagueCode) == true)
                {

                    selectAwayTeam1(leagueCode);
                    selectAwayTeam2(leagueCode);
                    selectAwayTeam3(leagueCode);
                    selectAwayTeam4(leagueCode);
                    selectAwayTeam5(leagueCode);


                    selectAwayScore1(leagueCode);
                    selectAwayScore2(leagueCode);
                    selectAwayScore3(leagueCode);
                    selectAwayScore4(leagueCode);
                    selectAwayScore5(leagueCode);


                    selectHomeScore1(leagueCode);
                    selectHomeScore2(leagueCode);
                    selectHomeScore3(leagueCode);
                    selectHomeScore4(leagueCode);
                    selectHomeScore5(leagueCode);

                    selectHomeTeam1(leagueCode);
                    selectHomeTeam2(leagueCode);
                    selectHomeTeam3(leagueCode);
                    selectHomeTeam4(leagueCode);
                    selectHomeTeam5(leagueCode);


                    selectHomePic1(leagueCode);
                    selectHomePic2(leagueCode);
                    selectHomePic3(leagueCode);
                    selectHomePic4(leagueCode);
                    selectHomePic5(leagueCode);

                    selectAwayPic1(leagueCode);
                    selectAwayPic2(leagueCode);
                    selectAwayPic3(leagueCode);
                    selectAwayPic4(leagueCode);
                    selectAwayPic5(leagueCode);
                }
                else
                    groupBox8.Visible = false;
            }

            else if (leagueInt == 2)
            {

                  leagueCode = "ESP";
                selectAll(leagueCode);
                if (selectFixtures(leagueCode) == true)
                {

                    selectAwayTeam1(leagueCode);
                    selectAwayTeam2(leagueCode);
                    selectAwayTeam3(leagueCode);
                    selectAwayTeam4(leagueCode);
                    selectAwayTeam5(leagueCode);


                    selectAwayScore1(leagueCode);
                    selectAwayScore2(leagueCode);
                    selectAwayScore3(leagueCode);
                    selectAwayScore4(leagueCode);
                    selectAwayScore5(leagueCode);


                    selectHomeScore1(leagueCode);
                    selectHomeScore2(leagueCode);
                    selectHomeScore3(leagueCode);
                    selectHomeScore4(leagueCode);
                    selectHomeScore5(leagueCode);

                    selectHomeTeam1(leagueCode);
                    selectHomeTeam2(leagueCode);
                    selectHomeTeam3(leagueCode);
                    selectHomeTeam4(leagueCode);
                    selectHomeTeam5(leagueCode);


                    selectHomePic1(leagueCode);
                    selectHomePic2(leagueCode);
                    selectHomePic3(leagueCode);
                    selectHomePic4(leagueCode);
                    selectHomePic5(leagueCode);

                    selectAwayPic1(leagueCode);
                    selectAwayPic2(leagueCode);
                    selectAwayPic3(leagueCode);
                    selectAwayPic4(leagueCode);
                    selectAwayPic5(leagueCode);
                }
                else
                    groupBox8.Visible = false;

            }

            else if (leagueInt == 3)
            {

                  leagueCode = "ITA";
                selectAll(leagueCode);
                if (selectFixtures(leagueCode) == true)
                {

                    selectAwayTeam1(leagueCode);
                    selectAwayTeam2(leagueCode);
                    selectAwayTeam3(leagueCode);
                    selectAwayTeam4(leagueCode);
                    selectAwayTeam5(leagueCode);


                    selectAwayScore1(leagueCode);
                    selectAwayScore2(leagueCode);
                    selectAwayScore3(leagueCode);
                    selectAwayScore4(leagueCode);
                    selectAwayScore5(leagueCode);


                    selectHomeScore1(leagueCode);
                    selectHomeScore2(leagueCode);
                    selectHomeScore3(leagueCode);
                    selectHomeScore4(leagueCode);
                    selectHomeScore5(leagueCode);

                    selectHomeTeam1(leagueCode);
                    selectHomeTeam2(leagueCode);
                    selectHomeTeam3(leagueCode);
                    selectHomeTeam4(leagueCode);
                    selectHomeTeam5(leagueCode);


                    selectHomePic1(leagueCode);
                    selectHomePic2(leagueCode);
                    selectHomePic3(leagueCode);
                    selectHomePic4(leagueCode);
                    selectHomePic5(leagueCode);

                    selectAwayPic1(leagueCode);
                    selectAwayPic2(leagueCode);
                    selectAwayPic3(leagueCode);
                    selectAwayPic4(leagueCode);
                    selectAwayPic5(leagueCode);
                }
                else
                    groupBox8.Visible = false;
            }

            else if (leagueInt == 4)
            {

                 leagueCode = "GER";
                selectAll(leagueCode);
                if (selectFixtures(leagueCode) == true)
                {

                    selectAwayTeam1(leagueCode);
                    selectAwayTeam2(leagueCode);
                    selectAwayTeam3(leagueCode);
                    selectAwayTeam4(leagueCode);
                    selectAwayTeam5(leagueCode);


                    selectAwayScore1(leagueCode);
                    selectAwayScore2(leagueCode);
                    selectAwayScore3(leagueCode);
                    selectAwayScore4(leagueCode);
                    selectAwayScore5(leagueCode);


                    selectHomeScore1(leagueCode);
                    selectHomeScore2(leagueCode);
                    selectHomeScore3(leagueCode);
                    selectHomeScore4(leagueCode);
                    selectHomeScore5(leagueCode);

                    selectHomeTeam1(leagueCode);
                    selectHomeTeam2(leagueCode);
                    selectHomeTeam3(leagueCode);
                    selectHomeTeam4(leagueCode);
                    selectHomeTeam5(leagueCode);


                    selectHomePic1(leagueCode);
                    selectHomePic2(leagueCode);
                    selectHomePic3(leagueCode);
                    selectHomePic4(leagueCode);
                    selectHomePic5(leagueCode);

                    selectAwayPic1(leagueCode);
                    selectAwayPic2(leagueCode);
                    selectAwayPic3(leagueCode);
                    selectAwayPic4(leagueCode);
                    selectAwayPic5(leagueCode);
                }
                else
                    groupBox8.Visible = false;
            }

            else if (leagueInt == 5)
            {

                  leagueCode = "FRA";
                selectAll(leagueCode);
                if (selectFixtures(leagueCode) == true)
                {

                    selectAwayTeam1(leagueCode);
                    selectAwayTeam2(leagueCode);
                    selectAwayTeam3(leagueCode);
                    selectAwayTeam4(leagueCode);
                    selectAwayTeam5(leagueCode);


                    selectAwayScore1(leagueCode);
                    selectAwayScore2(leagueCode);
                    selectAwayScore3(leagueCode);
                    selectAwayScore4(leagueCode);
                    selectAwayScore5(leagueCode);


                    selectHomeScore1(leagueCode);
                    selectHomeScore2(leagueCode);
                    selectHomeScore3(leagueCode);
                    selectHomeScore4(leagueCode);
                    selectHomeScore5(leagueCode);

                    selectHomeTeam1(leagueCode);
                    selectHomeTeam2(leagueCode);
                    selectHomeTeam3(leagueCode);
                    selectHomeTeam4(leagueCode);
                    selectHomeTeam5(leagueCode);


                    selectHomePic1(leagueCode);
                    selectHomePic2(leagueCode);
                    selectHomePic3(leagueCode);
                    selectHomePic4(leagueCode);
                    selectHomePic5(leagueCode);

                    selectAwayPic1(leagueCode);
                    selectAwayPic2(leagueCode);
                    selectAwayPic3(leagueCode);
                    selectAwayPic4(leagueCode);
                    selectAwayPic5(leagueCode);
                }
                else
                    groupBox8.Visible = false;
            }

            fixResults1();

        }



        public void selecting()
        {
            if (leagueInt == 1)
            {

                String leagueCode = "EPL";
                selectAll(leagueCode);
            }

            else if (leagueInt == 2)
            {

                String leagueCode = "ESP";
                selectAll(leagueCode);
            }

            else if (leagueInt == 3)
            {

                String leagueCode = "ITA";
                selectAll(leagueCode);
            }

            else if (leagueInt == 4)
            {

                String leagueCode = "GER";
                selectAll(leagueCode);
            }

            else if (leagueInt == 5)
            {

                String leagueCode = "FRA";
                selectAll(leagueCode);
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bhandled = false;


            switch (keyData)
            {
                case Keys.Right:
                    if (buttonAddScores.Focused)
                    {
                        
                         
                        buttonAddTeams.Focus();
                         
                        bhandled = true;

                    }

                    else if (buttonAddTeams.Focused)
                    {
                        
                        buttonAddScores.Focus();
                         
                        bhandled = true;

                    }

                   
                    break;

                case Keys.Left:
                    if (buttonAddScores.Focused)
                    {

                        
                        buttonAddTeams.Focus();
                        
                        bhandled = true;

                    }

                    else if (buttonAddTeams.Focused)
                    {
                         
                        buttonAddScores.Focus();
                        
                        bhandled = true;

                    }
                    break;

                case Keys.Home:
                    
                   
                    this.Close();
                    DialogResult result = MessageBox.Show("Do you want to Exit?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        Application.Exit();

                    }

                    bhandled = true;
                    break;

                case Keys.Escape:
                     
                    this.Close();
                    bhandled = true;

                    break;
            }

            return bhandled;
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!e.Cancel && e.CloseReason == CloseReason.UserClosing)
            {
                 


                e.Cancel = true;
                Home home = new Home();
                home.Show();
                this.Hide();
              
             


            }

        }

        private void AllData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public bool selectFixtures(String leagueCode)

        {

            DataTable table;
            String select = "SELECT * From Fixtures  Where League_ID = '" + leagueCode + "' ";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Fixtures_Table(select);
            table = sql.Fixtures_Table(select);

            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
        public void selectAwayScore1(String leagueCode)

        {

            String fixCode = "1B";
            String select = "SELECT GF From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, LabelScore1B);
        }


        public void selectAwayScore2(String leagueCode)

        {

            String fixCode = "2B";
            String select = "SELECT GF From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, LabelScore2B);
        }

        public void selectAwayScore3(String leagueCode)

        {

            String fixCode = "3B";
            String select = "SELECT GF From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, LabelScore3B);
        }

        public void selectAwayScore4(String leagueCode)

        {

            String fixCode = "4B";
            String select = "SELECT GF From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, LabelScore4B);
        }

        public void selectAwayScore5(String leagueCode)

        {

            String fixCode = "5B";
            String select = "SELECT GF From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, LabelScore5B);
        }

        public void selectHomeScore1(String leagueCode)

        {

            String fixCode = "1A";
            String select = "SELECT GF From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, LabelScore1A);
        }


        public void selectHomeScore2(String leagueCode)

        {

            String fixCode = "2A";
            String select = "SELECT GF From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, LabelScore2A);
        }

        public void selectHomeScore3(String leagueCode)

        {

            String fixCode = "3A";
            String select = "SELECT GF From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, LabelScore3A);
        }

        public void selectHomeScore4(String leagueCode)

        {

            String fixCode = "4A";
            String select = "SELECT GF From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, LabelScore4A);
        }

        public void selectHomeScore5(String leagueCode)

        {

            String fixCode = "5A";
            String select = "SELECT GF From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, LabelScore5A);
        }
        public void selectAwayTeam1(String leagueCode)

        {
             
            String fixCode = "1B";
            String select = "SELECT Team_ID From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '"+ fixCode +"' And Matches_Played = '"+ matchNum.Text +"'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, B1);


            String selectTeamCode = "SELECT Team_Code From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + B1.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, LabelTeam1B);


        }

        public void selectAwayTeam2(String leagueCode)

        {

            String fixCode = "2B";
            String select = "SELECT Team_ID From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, B2);


            String selectTeamCode = "SELECT Team_Code From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + B2.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, LabelTeam2B);


        }


        public void selectAwayTeam3(String leagueCode)

        {

            String fixCode = "3B";
            String select = "SELECT Team_ID From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, B3);


            String selectTeamCode = "SELECT Team_Code From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + B3.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, LabelTeam3B);


        }


        public void selectAwayTeam4(String leagueCode)

        {

            String fixCode = "4B";
            String select = "SELECT Team_ID From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, B4);


            String selectTeamCode = "SELECT Team_Code From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + B4.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, LabelTeam4B);


        }

        public void selectAwayTeam5(String leagueCode)

        {

            String fixCode = "5B";
            String select = "SELECT Team_ID From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, B5);


            String selectTeamCode = "SELECT Team_Code From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + B5.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, LabelTeam5B);


        }
        public void selectHomeTeam1(String leagueCode)

        {

            String fixCode = "1A";
            String select = "SELECT Team_ID From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, A1);


            String selectTeamCode = "SELECT Team_Code From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + A1.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, LabelTeam1A);


        }

        public void selectHomeTeam2(String leagueCode)

        {

            String fixCode = "2A";
            String select = "SELECT Team_ID From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, A2);


            String selectTeamCode = "SELECT Team_Code From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + A2.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, LabelTeam2A);


        }


        public void selectHomeTeam3(String leagueCode)

        {

            String fixCode = "3A";
            String select = "SELECT Team_ID From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, A3);


            String selectTeamCode = "SELECT Team_Code From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + A3.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, LabelTeam3A);


        }


        public void selectHomeTeam4(String leagueCode)

        {

            String fixCode = "4A";
            String select = "SELECT Team_ID From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, A4);


            String selectTeamCode = "SELECT Team_Code From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + A4.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, LabelTeam4A);


        }

        public void selectHomeTeam5(String leagueCode)

        {

            String fixCode = "5A";
            String select = "SELECT Team_ID From Fixtures  Where League_ID = '" + leagueCode + "' And Fixture_Code = '" + fixCode + "' And Matches_Played = '" + matchNum.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, A5);


            String selectTeamCode = "SELECT Team_Code From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + A5.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, LabelTeam5A);


        }



        public void selectAll(String leagueCode)
        {
            String selectAllRecords = "SELECT Teams.Team_Name AS 'TEAMS',Team_Records.Matches_Played AS 'MATCHES PLAYED', Team_Records.GF AS 'GOALS SCORED',Team_Records.GA AS 'GOALS CONCEDED',Team_Records.GD AS 'GOAL DIFFERENCE',Team_Records.Points AS 'POINTS'  From Teams,Team_Records  Where Teams.Team_ID = Team_Records.Team_ID And Teams.League_ID = '" + leagueCode + "' Order By Team_Records.Points DESC ,  Team_Records.GD DESC, Team_Records.GF DESC";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Records_Table(selectAllRecords);

            Table.DataSource = sql.Records_Table(selectAllRecords);
        }

        public void selectFix()
        {
            String select = "SELECT * From Fixtures";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Fixtures_Table(select);

            Table.DataSource = sql.Fixtures_Table(select);



        }

        public void selectPic()
        {
            String select = "SELECT Team_Logo  From Teams  Where Team_Name = '"+ Nametxt.Text +"'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select,label3);

            
        }


        public void selectCoach()
        {
            String select = "SELECT Team_Coach  From Teams  Where Team_Name = '" + Nametxt.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, labelHeadCoach);


        }
        public void selectOwner()
        {
            String select = "SELECT Team_Owner  From Teams  Where Team_Name = '" + Nametxt.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(select, labelOwner);


        }
        private void leagueName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTeams add = new AddTeams(this);
            if (iconLeague.BackgroundImage == Properties.Resources.epl)
            {
                AddTeams.leagueInt = 1;
            }
            else if (iconLeague.BackgroundImage == Properties.Resources.laliga)
            {
                AddTeams.leagueInt = 2;
            }
            else if (iconLeague.BackgroundImage == Properties.Resources.serie_a)
            {
                AddTeams.leagueInt = 3;
            }
            else if (iconLeague.BackgroundImage == Properties.Resources.bundesliga)
            {
                AddTeams.leagueInt = 4;
            }
            else if (iconLeague.BackgroundImage == Properties.Resources.league1)
            {
                AddTeams.leagueInt = 5;
            }

            add.Show();
        }

        private void buttonEpl_Click(object sender, EventArgs e)
        {
            AddScores add = new AddScores(this);
            if (iconLeague.BackgroundImage == Properties.Resources.epl)
            {
                AddScores.leagueInt = 1;
            }else if (iconLeague.BackgroundImage == Properties.Resources.laliga)
            {
                AddScores.leagueInt = 2;
            }
            else if (iconLeague.BackgroundImage == Properties.Resources.serie_a)
            {
                AddScores.leagueInt = 3;
            }
            else if (iconLeague.BackgroundImage == Properties.Resources.bundesliga)
            {
                AddScores.leagueInt = 4;
            }
            else if (iconLeague.BackgroundImage == Properties.Resources.league1)
            {
                AddScores.leagueInt = 5;
            }

            add.Show();
             

        }

        private void AllData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           

        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Table.RowCount != 0)
            {
                if (Box.Visible == false)
                {
                    Box.Visible = true;
                }


                


                int i = Table.CurrentRow.Index;
                 Nametxt.Text = Table[0, i].Value.ToString();

                selectPic();

                PictureBox1.BackColor = Color.White;

                String picLocation = "E:\\Programming sample\\MyProject\\LeagueTableSystem\\LeagueTableSystem\\Resources\\" + label3.Text;
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                PictureBox1.ImageLocation = picLocation;

                selectOwner();
                selectCoach();

                labelMatches.Text = Table[1, i].Value.ToString();
                labelGF.Text = Table[2, i].Value.ToString();
                labelGA.Text = Table[3, i].Value.ToString();
                labelGD.Text = Table[4, i].Value.ToString();
                labelPoints.Text = Table[5, i].Value.ToString();
                int ii = i + 1;
                if (ii == 1)
                {
                    Box.Text = ii.ToString() + "st";

                }
                else if (ii == 2)
                {
                    Box.Text = ii.ToString() + "nd";
                }

                else if (ii == 3)
                {
                    Box.Text = ii.ToString() + "rd";
                }

                else
                {
                    Box.Text = ii.ToString() + "th";
                }
            }

        }

        private void Nametxt_Click(object sender, EventArgs e)
        {
            if (popInt == 0)
            {
                UpdateTeam.updateRefString = Nametxt.Text;
                UpdateTeam update = new UpdateTeam(this);

                update.Show();
                popInt = 1;
            }

            

        }

        private void labelOwner_Click(object sender, EventArgs e)
        {
            if (popInt == 0)
            {
                UpdateTeam.updateRefString = Nametxt.Text;
                UpdateTeam update = new UpdateTeam(this);

                update.Show();
                popInt = 1;
            }
        }

        private void labelHeadCoach_Click(object sender, EventArgs e)
        {
            if (popInt == 0)
            {
                UpdateTeam.updateRefString = Nametxt.Text;
                UpdateTeam update = new UpdateTeam(this);

                update.Show();
                popInt = 1;
            }
        }
        public void selectAwayPic1(String leagueCode)

        {

             


            String selectTeamCode = "SELECT Team_Logo From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + B1.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, pic1B);

             
            String picLocation = "E:\\Programming sample\\MyProject\\LeagueTableSystem\\LeagueTableSystem\\Resources\\" + pic1B.Text;
            picFix1B.SizeMode = PictureBoxSizeMode.StretchImage;
            picFix1B.ImageLocation = picLocation;


        }

        public void selectAwayPic2(String leagueCode)

        {




            String selectTeamCode = "SELECT Team_Logo From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + B2.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, pic2B);

             
            String picLocation = "E:\\Programming sample\\MyProject\\LeagueTableSystem\\LeagueTableSystem\\Resources\\" + pic2B.Text;
            picFix2B.SizeMode = PictureBoxSizeMode.StretchImage;
            picFix2B.ImageLocation = picLocation;


        }

        public void selectAwayPic3(String leagueCode)

        {




            String selectTeamCode = "SELECT Team_Logo From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + B3.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, pic3B);

             
            String picLocation = "E:\\Programming sample\\MyProject\\LeagueTableSystem\\LeagueTableSystem\\Resources\\" + pic3B.Text;
            picFix3B.SizeMode = PictureBoxSizeMode.StretchImage;
            picFix3B.ImageLocation = picLocation;


        }

        public void selectAwayPic4(String leagueCode)

        {




            String selectTeamCode = "SELECT Team_Logo From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + B4.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, pic4B);

             
            String picLocation = "E:\\Programming sample\\MyProject\\LeagueTableSystem\\LeagueTableSystem\\Resources\\" + pic4B.Text;
            picFix4B.SizeMode = PictureBoxSizeMode.StretchImage;
            picFix4B.ImageLocation = picLocation;


        }

        public void selectAwayPic5(String leagueCode)

        {




            String selectTeamCode = "SELECT Team_Logo From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + B5.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, pic5B);

            
            String picLocation = "E:\\Programming sample\\MyProject\\LeagueTableSystem\\LeagueTableSystem\\Resources\\" + pic5B.Text;
            picFix5B.SizeMode = PictureBoxSizeMode.StretchImage;
            picFix5B.ImageLocation = picLocation;


        }




        public void selectHomePic1(String leagueCode)

        {




            String selectTeamCode = "SELECT Team_Logo From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + A1.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, pic1A);


            String picLocation = "E:\\Programming sample\\MyProject\\LeagueTableSystem\\LeagueTableSystem\\Resources\\" + pic1A.Text;
            picFix1A.SizeMode = PictureBoxSizeMode.StretchImage;
            picFix1A.ImageLocation = picLocation;


        }

        public void selectHomePic2(String leagueCode)

        {




            String selectTeamCode = "SELECT Team_Logo From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + A2.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, pic2A);


            String picLocation = "E:\\Programming sample\\MyProject\\LeagueTableSystem\\LeagueTableSystem\\Resources\\" + pic2A.Text;
            picFix2A.SizeMode = PictureBoxSizeMode.StretchImage;
            picFix2A.ImageLocation = picLocation;


        }

        public void selectHomePic3(String leagueCode)

        {




            String selectTeamCode = "SELECT Team_Logo From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + A3.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, pic3A);


            String picLocation = "E:\\Programming sample\\MyProject\\LeagueTableSystem\\LeagueTableSystem\\Resources\\" + pic3A.Text;
            picFix3A.SizeMode = PictureBoxSizeMode.StretchImage;
            picFix3A.ImageLocation = picLocation;


        }

        public void selectHomePic4(String leagueCode)

        {




            String selectTeamCode = "SELECT Team_Logo From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + A4.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, pic4A);


            String picLocation = "E:\\Programming sample\\MyProject\\LeagueTableSystem\\LeagueTableSystem\\Resources\\" + pic4A.Text;
            picFix4A.SizeMode = PictureBoxSizeMode.StretchImage;
            picFix4A.ImageLocation = picLocation;


        }

        public void selectHomePic5(String leagueCode)

        {




            String selectTeamCode = "SELECT Team_Logo From Teams  Where League_ID = '" + leagueCode + "' And Team_ID = '" + A5.Text + "' ";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.getLabelText(selectTeamCode, pic5A);


            String picLocation = "E:\\Programming sample\\MyProject\\LeagueTableSystem\\LeagueTableSystem\\Resources\\" + pic5A.Text;
            picFix5A.SizeMode = PictureBoxSizeMode.StretchImage;
            picFix5A.ImageLocation = picLocation;


        }

        public void fixResults()
        {
            DataTable table;
            String all = "Select * From Fixtures";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Fixtures_Table(all);
            table = sql.Fixtures_Table(all);

            int i = table.Rows.Count;

            if (i == 0)
            {

            }
            else
            {

                int ii = i / 10;






                if (int.Parse(matchNum.Text) < ii)
                {

                    matchNum.Text = ii.ToString();
                    MD.Text = "MATCHDAY " + matchNum.Text + " ";

                    selectAll(leagueCode);



                    selectAwayTeam1(leagueCode);
                    selectAwayTeam2(leagueCode);
                    selectAwayTeam3(leagueCode);
                    selectAwayTeam4(leagueCode);
                    selectAwayTeam5(leagueCode);


                    selectAwayScore1(leagueCode);
                    selectAwayScore2(leagueCode);
                    selectAwayScore3(leagueCode);
                    selectAwayScore4(leagueCode);
                    selectAwayScore5(leagueCode);


                    selectHomeScore1(leagueCode);
                    selectHomeScore2(leagueCode);
                    selectHomeScore3(leagueCode);
                    selectHomeScore4(leagueCode);
                    selectHomeScore5(leagueCode);

                    selectHomeTeam1(leagueCode);
                    selectHomeTeam2(leagueCode);
                    selectHomeTeam3(leagueCode);
                    selectHomeTeam4(leagueCode);
                    selectHomeTeam5(leagueCode);


                    selectHomePic1(leagueCode);
                    selectHomePic2(leagueCode);
                    selectHomePic3(leagueCode);
                    selectHomePic4(leagueCode);
                    selectHomePic5(leagueCode);

                    selectAwayPic1(leagueCode);
                    selectAwayPic2(leagueCode);
                    selectAwayPic3(leagueCode);
                    selectAwayPic4(leagueCode);
                    selectAwayPic5(leagueCode);
                }
                else
                {
                    MessageBox.Show(" " + matchNum.Text + " Matche(s) have been played so far");
                }






            }
        }


        public void fixResults1()
        {
            DataTable table;
            String all = "Select * From Fixtures where League_ID = '"+ leagueCode +"'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Fixtures_Table(all);
            table = sql.Fixtures_Table(all);

            int i = table.Rows.Count;

            if (i < 10)
            {
                selectAll(leagueCode);

            }
            else
            {

                int ii = i / 10;






                

                    matchNum.Text = ii.ToString();
                    MD.Text = "MATCHDAY " + matchNum.Text + " ";

                    selectAll(leagueCode);



                    selectAwayTeam1(leagueCode);
                    selectAwayTeam2(leagueCode);
                    selectAwayTeam3(leagueCode);
                    selectAwayTeam4(leagueCode);
                    selectAwayTeam5(leagueCode);


                    selectAwayScore1(leagueCode);
                    selectAwayScore2(leagueCode);
                    selectAwayScore3(leagueCode);
                    selectAwayScore4(leagueCode);
                    selectAwayScore5(leagueCode);


                    selectHomeScore1(leagueCode);
                    selectHomeScore2(leagueCode);
                    selectHomeScore3(leagueCode);
                    selectHomeScore4(leagueCode);
                    selectHomeScore5(leagueCode);

                    selectHomeTeam1(leagueCode);
                    selectHomeTeam2(leagueCode);
                    selectHomeTeam3(leagueCode);
                    selectHomeTeam4(leagueCode);
                    selectHomeTeam5(leagueCode);


                    selectHomePic1(leagueCode);
                    selectHomePic2(leagueCode);
                    selectHomePic3(leagueCode);
                    selectHomePic4(leagueCode);
                    selectHomePic5(leagueCode);

                    selectAwayPic1(leagueCode);
                    selectAwayPic2(leagueCode);
                    selectAwayPic3(leagueCode);
                    selectAwayPic4(leagueCode);
                    selectAwayPic5(leagueCode);
                






            }
        }
        private void buttonForward_Click(object sender, EventArgs e)
        {
            fixResults();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void picFix1A_Click(object sender, EventArgs e)
        {

        }

        private void LabelTeam3B_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void LabelScore5B_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (int.Parse(matchNum.Text) > 1)
            {
                int ii = int.Parse(matchNum.Text) - 1;
                matchNum.Text = ii.ToString();
                MD.Text = "MATCHDAY " + matchNum.Text + " ";
                selectAll(leagueCode);



                selectAwayTeam1(leagueCode);
                selectAwayTeam2(leagueCode);
                selectAwayTeam3(leagueCode);
                selectAwayTeam4(leagueCode);
                selectAwayTeam5(leagueCode);


                selectAwayScore1(leagueCode);
                selectAwayScore2(leagueCode);
                selectAwayScore3(leagueCode);
                selectAwayScore4(leagueCode);
                selectAwayScore5(leagueCode);


                selectHomeScore1(leagueCode);
                selectHomeScore2(leagueCode);
                selectHomeScore3(leagueCode);
                selectHomeScore4(leagueCode);
                selectHomeScore5(leagueCode);

                selectHomeTeam1(leagueCode);
                selectHomeTeam2(leagueCode);
                selectHomeTeam3(leagueCode);
                selectHomeTeam4(leagueCode);
                selectHomeTeam5(leagueCode);


                selectHomePic1(leagueCode);
                selectHomePic2(leagueCode);
                selectHomePic3(leagueCode);
                selectHomePic4(leagueCode);
                selectHomePic5(leagueCode);

                selectAwayPic1(leagueCode);
                selectAwayPic2(leagueCode);
                selectAwayPic3(leagueCode);
                selectAwayPic4(leagueCode);
                selectAwayPic5(leagueCode);
            }
        }

        private void iconLeague_Click(object sender, EventArgs e)
        {
            //selectFix();
        }

        
    }


   
}

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
    public partial class AddScores : Form
    {
        public static int leagueInt;
        static char firstLetter ;
        static char secondLetter ;
        static char thirdLetter ;
        int Matches,Mp;
        String Tcode;
        private readonly Epl _epl;
        public AddScores(Epl epl)
        {
            InitializeComponent();
            _epl = epl;
        }

        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bhandled = false;


            switch (keyData)
            {
                
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



        private void TextBox0_KeyPress(object sender, KeyPressEventArgs e)
        {
          
         
 
            if (HomeTeam1.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                firstLetter = e.KeyChar;
            }
            

            if (HomeTeam1.Text.Length == 1)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                secondLetter = e.KeyChar;
            }
            

            if (HomeTeam1.Text.Length == 2)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                thirdLetter = e.KeyChar;
            }
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AwayTeam1.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                firstLetter = e.KeyChar;
            }


            if (AwayTeam1.Text.Length == 1)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                secondLetter = e.KeyChar;
            }


            if (AwayTeam1.Text.Length == 2)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                thirdLetter = e.KeyChar;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (HomeTeam2.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                firstLetter = e.KeyChar;
            }


            if (HomeTeam2.Text.Length == 1)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                secondLetter = e.KeyChar;
            }


            if (HomeTeam2.Text.Length == 2)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                thirdLetter = e.KeyChar;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (HomeTeam3.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                firstLetter = e.KeyChar;
            }


            if (HomeTeam3.Text.Length == 1)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                secondLetter = e.KeyChar;
            }


            if (HomeTeam3.Text.Length == 2)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                thirdLetter = e.KeyChar;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AwayTeam3.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                firstLetter = e.KeyChar;
            }


            if (AwayTeam3.Text.Length == 1)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                secondLetter = e.KeyChar;
            }


            if (AwayTeam3.Text.Length == 2)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                thirdLetter = e.KeyChar;
            }
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (HomeTeam55.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                firstLetter = e.KeyChar;
            }


            if (HomeTeam55.Text.Length == 1)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                secondLetter = e.KeyChar;
            }


            if (HomeTeam55.Text.Length == 2)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                thirdLetter = e.KeyChar;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AwayTeam5.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                firstLetter = e.KeyChar;
            }


            if (AwayTeam5.Text.Length == 1)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                secondLetter = e.KeyChar;
            }


            if (AwayTeam5.Text.Length == 2)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                thirdLetter = e.KeyChar;
            }
        }

        private void AddScores_Load(object sender, EventArgs e)
        {

            match();
            if (leagueInt == 1)
            {
                labelLeagueName.Text = "EPL";
                Tcode = "EPL";
                dummyLabel.Text = "EPL";
                leagueIcon.BackgroundImage = Properties.Resources.epl;
            }

            else if (leagueInt == 2)
            {
                labelLeagueName.Text = "Laliga";
                Tcode = "ESP";
                dummyLabel.Text = "ESP";
                leagueIcon.BackgroundImage = Properties.Resources.laliga;
            }

            else if (leagueInt == 3)
            {
                labelLeagueName.Text = "Serie A";
                Tcode = "ITA";
                dummyLabel.Text = "ITA";
                leagueIcon.BackgroundImage = Properties.Resources.serie_a;
            }

            else if (leagueInt == 4)
            {
                labelLeagueName.Text = "Bundesliga";
                Tcode = "GER";
                dummyLabel.Text = "GER";
                leagueIcon.BackgroundImage = Properties.Resources.bundesliga;
            }

           else if (leagueInt == 5)
            {
                labelLeagueName.Text = "Ligue 1";
                Tcode = "FRA";
                dummyLabel.Text = "FRA";
                leagueIcon.BackgroundImage = Properties.Resources.league1;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AwayTeam2.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                firstLetter = e.KeyChar;
            }


            if (AwayTeam2.Text.Length == 1)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                secondLetter = e.KeyChar;
            }


            if (AwayTeam2.Text.Length == 2)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                thirdLetter = e.KeyChar;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (HomeTeam4.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                firstLetter = e.KeyChar;
            }


            if (HomeTeam4.Text.Length == 1)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                secondLetter = e.KeyChar;
            }


            if (HomeTeam4.Text.Length == 2)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                thirdLetter = e.KeyChar;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AwayTeam4.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                firstLetter = e.KeyChar;
            }


            if (AwayTeam4.Text.Length == 1)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                secondLetter = e.KeyChar;
            }


            if (AwayTeam4.Text.Length == 2)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                thirdLetter = e.KeyChar;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AwayScore2.Select();

            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HomeTeam1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AwayTeam1.Select();

            }
                
            
        
        }

        private void HomeTeam2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AwayTeam2.Select();

            }
        }

        private void HomeTeam3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AwayTeam3.Select();

            }
        }

        private void HomeTeam4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AwayTeam4.Select();

            }
        }

        private void textBox19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AwayTeam5.Select();

            }
        }

        private void HomeScore1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AwayScore1.Select();

            }
        }

        private void HomeScore3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AwayScore3.Select();

            }
        }

        private void HomeScore4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AwayScore4.Select();

            }
        }

        private void HomeScore5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AwayScore5.Select();

            }
        }

        private void AwayTeam1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HomeScore1.Select();

            }
        }

        private void AwayTeam2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HomeScore2.Select();

            }
        }

        private void AwayTeam3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HomeScore3.Select();

            }
        }

        private void AwayTeam4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HomeScore4.Select();

            }
        }

        private void AwayTeam5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HomeScore5.Select();

            }
        }

        private void AwayScore1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HomeTeam2.Select();

            }
        }

        private void AwayScore2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HomeTeam3.Select();

            }
        }

        private void AwayScore3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HomeTeam4.Select();

            }
        }

        private void AwayScore4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HomeTeam55.Select();

            }
        }

        private void AwayScore5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddSavebtn.Select();

            }
        }

        private void AddSavebtn_Click(object sender, EventArgs e)
        {


            //specUpdate2("EPL");
           
             scores();
           
             




        }

        private void scores()
        {
            if (HomeTeam1.Text == "" || HomeTeam2.Text == "" || HomeTeam3.Text == "" || HomeTeam4.Text == "" || AwayTeam1.Text == "" || AwayTeam2.Text == "" || AwayTeam3.Text == "" || AwayTeam4.Text == "" || AwayTeam5.Text == "" || HomeTeam55.Text == "")
            {
                MessageBox.Show("Fill in all spaces provided");
            }
            else
            {

                if(selectSpecificTeam(HomeTeam1) == true && selectSpecificTeam(HomeTeam2) == true && selectSpecificTeam(HomeTeam3) == true && selectSpecificTeam(HomeTeam4) == true && selectSpecificTeam(HomeTeam55) == true && selectSpecificTeam(AwayTeam1) == true && selectSpecificTeam(AwayTeam2) == true && selectSpecificTeam(AwayTeam3) == true && selectSpecificTeam(AwayTeam4) == true && selectSpecificTeam(AwayTeam5) == true)
                {

                    if (HomeScore1.Text == "" || HomeScore2.Text == "" || HomeScore3.Text == "" || HomeScore4.Text == "" || AwayScore1.Text == "" || AwayScore2.Text == "" || AwayScore3.Text == "" || AwayScore4.Text == "" || AwayScore5.Text == "" || HomeScore5.Text == "")
                    {
                        MessageBox.Show("Fill in all spaces provided");
                    }
                    else
                    {
                        scorePoints1();
                        scorePoints2();
                        scorePoints3();
                        scorePoints4();
                        scorePoints5();
                        specUpdate1(CodeID(HomeTeam1).Text, CodeID(HomeTeam2).Text, CodeID(HomeTeam3).Text, CodeID(HomeTeam4).Text, CodeID(HomeTeam55).Text, CodeID(AwayTeam1).Text, CodeID(AwayTeam2).Text, CodeID(AwayTeam3).Text, CodeID(AwayTeam4).Text, CodeID(AwayTeam5).Text);
                         
                        //dbTable();

                        String selectAllRecords = "SELECT Teams.Team_Name AS 'TEAMS',Team_Records.Matches_Played AS 'MATCHES PLAYED', Team_Records.GF AS 'GOALS SCORED',Team_Records.GA AS 'GOALS CONCEDED',Team_Records.GD AS 'GOAL DIFFERENCE',Team_Records.Points AS 'POINTS'  From Teams,Team_Records  Where Teams.Team_ID = Team_Records.Team_ID And Teams.League_ID = '" + Tcode + "' Order By Team_Records.Points DESC ,  Team_Records.GD DESC, Team_Records.GF DESC";
                        SqlDatabaseModule sql1 = new SqlDatabaseModule();
                        sql1.Records_Table(selectAllRecords);

                        //Epl.AllData.DataSource = sql1.Records_Table(selectAllRecords);
                        HomeTeam1.Clear();
                        HomeTeam2.Clear();
                        HomeTeam3.Clear();
                        HomeTeam4.Clear();
                        HomeTeam55.Clear();
                        AwayTeam1.Clear();
                        AwayTeam2.Clear();
                        AwayTeam3.Clear();
                        AwayTeam4.Clear();
                        AwayTeam5.Clear();

                        AwayScore1.Clear();
                        AwayScore2.Clear();
                        AwayScore3.Clear();
                        AwayScore4.Clear();
                        AwayScore5.Clear();

                        HomeScore1.Clear();
                        HomeScore2.Clear();
                        HomeScore3.Clear();
                        HomeScore4.Clear();
                        HomeScore5.Clear();

                        AwayScore1.Clear();
                        AwayScore2.Clear();

                        AwayScore3.Clear();

                        AwayScore4.Clear();
                        AwayScore5.Clear();
                        selectAll(Tcode);
                        _epl.Box.Visible = false;
                        _epl.fixResults1();


                        DialogResult result = MessageBox.Show("Add another Score?", "Successfull!", MessageBoxButtons.YesNo);
                         if (result == DialogResult.No)
                        {

                            this.Close();
                        }

                        

                    }


                }else
                {
                    MessageBox.Show("Invalid Team Code found");

                }



            }

        
               

        }


        private void specc()
        {
            String updateLeagueTable = "UPDATE Team_Records SET Matches_Played = 0, GF = 0 ,GA = 0 ,GD = 0,Points =0 ";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Records_Table(updateLeagueTable);
        }

        private void specUpdate(String code)
        {
            SqlDatabaseModule sql = new SqlDatabaseModule();

            SqlDatabaseModule sql1 = new SqlDatabaseModule();

            DataTable table;
            String all = "Select * From Fixtures";
            SqlDatabaseModule sqll = new SqlDatabaseModule();
            sqll.Fixtures_Table(all);
            table = sqll.Fixtures_Table(all);

            int i = table.Rows.Count;

            if (i == 0)
            {
                
            }
            else
            {
                Mp = i ;
                String selectMP = "SELECT Matches_Played  From Fixtures  Where Rec_ID = '"+ Mp +"' And League_ID = '" + Tcode + "' ";
                sql1.getLabelText(selectMP, Fix1A);


                 

            }


            String selectGF = "SELECT sum(GF)  From Fixtures  Where Team_ID = '"+ code +"' And League_ID = '" + Tcode + "' ";
             String selectGA = "SELECT sum(GA)  From Fixtures  Where Team_ID = '" + code + "' And League_ID = '" + Tcode + "' ";
            String selectGD = "SELECT sum(GD)  From Fixtures  Where Team_ID = '" + code + "' And League_ID = '" + Tcode + "' ";
            String selectPoints = "SELECT sum(Points)  From Fixtures  Where Team_ID = '" + code + "' And League_ID = '" + Tcode + "' ";



            
            sql1.getLabelText(selectGF, Fix2A);
            sql1.getLabelText(selectGA, Fix3A);
            sql1.getLabelText(selectGD, Fix4A);
            sql1.getLabelText(selectPoints, Fix5A);
            String updateLeagueTable = "UPDATE Team_Records SET Matches_Played = '" + Fix1A.Text + "', GF = '" + Fix2A.Text + "' ,GA = '" + Fix3A.Text + "' ,GD = '" + Fix4A.Text + "',Points ='" + Fix5A.Text + "' Where  Team_ID = '" + code + "'";
            
             sql.Records_Table(updateLeagueTable);


            




           

            
             
             


        }


        private void specUpdate1(String code1, String code2, String code3, String code4, String code5, String code6, String code7, String code8, String code9, String code10)
        {
            SqlDatabaseModule sql = new SqlDatabaseModule();

            

            DataTable table;
            String all = "Select * From Fixtures";
            
            sql.Fixtures_Table(all);
            table = sql.Fixtures_Table(all);

            int i = table.Rows.Count;

            if (i == 0)
            {

            }
            else
            {
                int ii = i / 10;

                String updateLeagueTable1 = "UPDATE Team_Records SET Matches_Played = '" + ii + "' Where  Team_ID = '" + code1 + "'";
                String updateLeagueTable2 = "UPDATE Team_Records SET Matches_Played = '" + ii + "' Where  Team_ID = '" + code2 + "'";
                String updateLeagueTable3 = "UPDATE Team_Records SET Matches_Played = '" + ii + "' Where  Team_ID = '" + code3 + "'";
                String updateLeagueTable4 = "UPDATE Team_Records SET Matches_Played = '" + ii + "' Where  Team_ID = '" + code4 + "'";
                String updateLeagueTable5 = "UPDATE Team_Records SET Matches_Played = '" + ii + "' Where  Team_ID = '" + code5 + "'";
                String updateLeagueTable6 = "UPDATE Team_Records SET Matches_Played = '" + ii + "' Where  Team_ID = '" + code6 + "'";
                String updateLeagueTable7 = "UPDATE Team_Records SET Matches_Played = '" + ii + "' Where  Team_ID = '" + code7 + "'";
                String updateLeagueTable8 = "UPDATE Team_Records SET Matches_Played = '" + ii + "' Where  Team_ID = '" + code8 + "'";
                String updateLeagueTable9 = "UPDATE Team_Records SET Matches_Played = '" + ii + "' Where  Team_ID = '" + code9 + "'";
                String updateLeagueTable10 = "UPDATE Team_Records SET Matches_Played = '" + ii + "' Where  Team_ID = '" + code10 + "'";



                sql.Records_Table(updateLeagueTable1);
                sql.Records_Table(updateLeagueTable2);
                sql.Records_Table(updateLeagueTable3);
                sql.Records_Table(updateLeagueTable4);
                sql.Records_Table(updateLeagueTable5);
                sql.Records_Table(updateLeagueTable6);
                sql.Records_Table(updateLeagueTable7);
                sql.Records_Table(updateLeagueTable8);
                sql.Records_Table(updateLeagueTable9);
                sql.Records_Table(updateLeagueTable10);



            }

 

            
           











        }

        public void selectAll(String leagueCode)
        {
            String selectAllRecords = "SELECT Teams.Team_Name AS 'TEAMS',Team_Records.Matches_Played AS 'MATCHES PLAYED', Team_Records.GF AS 'GOALS SCORED',Team_Records.GA AS 'GOALS CONCEDED',Team_Records.GD AS 'GOAL DIFFERENCE',Team_Records.Points AS 'POINTS'  From Teams,Team_Records  Where Teams.Team_ID = Team_Records.Team_ID And Teams.League_ID = '" + leagueCode + "' Order By Team_Records.Points DESC ,  Team_Records.GD DESC, Team_Records.GF DESC";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Records_Table(selectAllRecords);

            _epl.Table.DataSource = sql.Records_Table(selectAllRecords);
        }
        private void specUpdate2(String leagueCode )
        {
            SqlDatabaseModule sql = new SqlDatabaseModule();




            int ii = 2;

                String updateLeagueTable = "UPDATE Team_Records SET Matches_Played = '" + ii + "'";

                sql.Records_Table(updateLeagueTable);

            




 
















        }

        private bool selectSpecificTeam(TextBox textBox)
        {
            DataTable dataTable;
            String select;
            select = "select * From Teams Where Team_Code = '" + textBox.Text +"'";
            SqlDatabaseModule sql = new SqlDatabaseModule();


            sql.Teams_Table(select);
            dataTable = sql.Teams_Table(select);

            if (dataTable.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void dbUpdate(String str)
        {
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Records_Table(str);


        }

        private void dbInsert(String str)
        {
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Fixtures_Table(str);


        }

        private void dbTable()
        {
            String selectAllRecords = "SELECT Teams.Team_Name AS 'TEAMS',Team_Records.Matches_Played AS 'MATCHES PLAYED', Team_Records.GF,Team_Records.GA,Team_Records.GD,Team_Records.Points AS 'POINTS'  From Teams,Team_Records  Where Teams.Team_ID = Team_Records.Team_ID And Teams.League_ID = '" + Tcode + "' Order By Team_Records.Points ";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Records_Table(selectAllRecords);
             
           // Epl.AllData.DataSource = sql.Records_Table(selectAllRecords);


        }


        private TextBox CodeID(TextBox textBox)
        {


            TextBox txt = new TextBox();
            String select;
            select = "select Team_ID From Teams Where Team_Code = '" + textBox.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            
            sql.getTextBoxText(select,txt);

            return txt;
        }


        private void match()
        {
            DataTable table;
            String all = "Select * From Fixtures";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Fixtures_Table(all);
            table = sql.Fixtures_Table(all);

            int i = table.Rows.Count;

            if (i == 0)
            {
                Matches = 1;
            }
            else
            {
                int ii = i / 10;

                 

                Matches = ii + 1;

            }

        }
        private void scorePoints1()
        {
            int GoalsFor, GoalsAgainst, GoalDifference;
            int GoalsFor1, GoalsAgainst1, GoalDifference1;
            String insertLeagueTable, insertLeagueTable1;
            String code, code1;
            code = "1A";
            code1 = "1B";


            if (int.Parse(HomeScore1.Text) > int.Parse(AwayScore1.Text))
            {
                GoalsFor = int.Parse(HomeScore1.Text);
                GoalsAgainst = int.Parse(AwayScore1.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

               
                

 
                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam1).Text + "', '"+ Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 3, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam1).Text);


                GoalsFor1 = int.Parse(AwayScore1.Text);
                GoalsAgainst1 = int.Parse(HomeScore1.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam1).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 0, '" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam1).Text);
            }
            else if (int.Parse(HomeScore1.Text) < int.Parse(AwayScore1.Text))
            {
                GoalsFor = int.Parse(HomeScore1.Text);
                GoalsAgainst = int.Parse(AwayScore1.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

                 
                


                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam1).Text + "', '" + Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 0, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam1).Text);



                GoalsFor1 = int.Parse(AwayScore1.Text);
                GoalsAgainst1 = int.Parse(HomeScore1.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam1).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 3, '" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam1).Text);
            }

            else if (int.Parse(HomeScore1.Text) == int.Parse(AwayScore1.Text))
            {
                GoalsFor = int.Parse(HomeScore1.Text);
                GoalsAgainst = int.Parse(AwayScore1.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

              


                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam1).Text + "', '" + Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 1, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam1).Text);



                GoalsFor1 = int.Parse(AwayScore1.Text);
                GoalsAgainst1 = int.Parse(HomeScore1.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam1).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 1, '" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam1).Text);
            }
        }


        private void scorePoints2()
        {
            int GoalsFor, GoalsAgainst, GoalDifference;
            int GoalsFor1, GoalsAgainst1, GoalDifference1;
            String insertLeagueTable, insertLeagueTable1;
            String code, code1;
            code = "2A";
            code1 = "2B";

            if (int.Parse(HomeScore2.Text) > int.Parse(AwayScore2.Text))
            {
                GoalsFor = int.Parse(HomeScore2.Text);
                GoalsAgainst = int.Parse(AwayScore2.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

                

                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam2).Text + "', '" + Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 3, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam2).Text);


                GoalsFor1 = int.Parse(AwayScore2.Text);
                GoalsAgainst1 = int.Parse(HomeScore2.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam2).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 0, '" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam2).Text);
            }
            else if (int.Parse(HomeScore2.Text) < int.Parse(AwayScore2.Text))
            {
                GoalsFor = int.Parse(HomeScore2.Text);
                GoalsAgainst = int.Parse(AwayScore2.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

                
                  

                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam2).Text + "', '" + Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 0, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam2).Text);




                GoalsFor1 = int.Parse(AwayScore2.Text);
                GoalsAgainst1 = int.Parse(HomeScore2.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam2).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 3, '" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam2).Text);
            }

            else if (int.Parse(HomeScore2.Text) == int.Parse(AwayScore2.Text))
            {
                GoalsFor = int.Parse(HomeScore2.Text);
                GoalsAgainst = int.Parse(AwayScore2.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

                
               

                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam2).Text + "', '" + Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 1, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam2).Text);



                GoalsFor1 = int.Parse(AwayScore2.Text);
                GoalsAgainst1 = int.Parse(HomeScore2.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam2).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 1, '" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam2).Text);
            }
        }

        private void scoreeeePoints2()
        {
            int GoalsFor, GoalsAgainst, GoalDifference;
            int GoalsFor1, GoalsAgainst1, GoalDifference1;
            String updateLeagueTable, updateLeagueTable1;


            if (int.Parse(HomeScore2.Text) > int.Parse(AwayScore2.Text))
            {
                GoalsFor = int.Parse(HomeScore2.Text);
                GoalsAgainst = int.Parse(AwayScore2.Text);
                GoalDifference = GoalsFor - GoalsAgainst;


                updateLeagueTable = "UPDATE Team_Records SET Matches_Played = Matches_Played + 1, GF =  GF + '" + GoalsFor + "',GA = GA + '" + GoalsAgainst + "' ,GD = GD + '" + GoalDifference + "',Points = Points  + 3 Where  Team_ID = '" + CodeID(HomeTeam2).Text + "'";
                dbUpdate(updateLeagueTable);
                specUpdate(CodeID(HomeTeam2).Text);




                GoalsFor1 = int.Parse(AwayScore2.Text);
                GoalsAgainst1 = int.Parse(HomeScore2.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                updateLeagueTable1 = "UPDATE Team_Records SET Matches_Played = Matches_Played + 1, GF =  GF + '" + GoalsFor1 + "',GA = GA + '" + GoalsAgainst1 + "' ,GD = GD + '" + GoalDifference1 + "',Points = Points  + 0 Where  Team_ID = '" + CodeID(AwayTeam2).Text + "'";
                dbUpdate(updateLeagueTable1);
                specUpdate(CodeID(AwayTeam2).Text);
            }
            else if (int.Parse(HomeScore2.Text) < int.Parse(AwayScore2.Text))
            {
                GoalsFor = int.Parse(HomeScore2.Text);
                GoalsAgainst = int.Parse(AwayScore2.Text);
                GoalDifference = GoalsFor - GoalsAgainst;


                updateLeagueTable = "UPDATE Team_Records SET Matches_Played = Matches_Played + 1, GF =  GF + '" + GoalsFor + "',GA = GA + '" + GoalsAgainst + "' ,GD = GD + '" + GoalDifference + "',Points = Points  + 0 Where  Team_ID = '" + CodeID(HomeTeam2).Text + "'";

                dbUpdate(updateLeagueTable);
                specUpdate(CodeID(HomeTeam2).Text);



                GoalsFor1 = int.Parse(AwayScore2.Text);
                GoalsAgainst1 = int.Parse(HomeScore2.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                updateLeagueTable1 = "UPDATE Team_Records SET Matches_Played = Matches_Played + 1, GF =  GF + '" + GoalsFor1 + "',GA = GA + '" + GoalsAgainst1 + "' ,GD = GD + '" + GoalDifference1 + "',Points = Points  + 3 Where  Team_ID = '" + CodeID(AwayTeam2).Text + "'";
                dbUpdate(updateLeagueTable1);
                specUpdate(CodeID(AwayTeam2).Text);
            }

            else if (int.Parse(HomeScore2.Text) == int.Parse(AwayScore2.Text))
            {
                GoalsFor = int.Parse(HomeScore2.Text);
                GoalsAgainst = int.Parse(AwayScore2.Text);
                GoalDifference = GoalsFor - GoalsAgainst;


                updateLeagueTable = "UPDATE Team_Records SET Matches_Played = Matches_Played + 1, GF =  GF + '" + GoalsFor + "',GA = GA + '" + GoalsAgainst + "' ,GD = GD + '" + GoalDifference + "',Points = Points  + 1 Where  Team_ID = '" + CodeID(HomeTeam2).Text + "'";
                dbUpdate(updateLeagueTable);
                specUpdate(CodeID(HomeTeam2).Text);




                GoalsFor1 = int.Parse(AwayScore2.Text);
                GoalsAgainst1 = int.Parse(HomeScore2.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                updateLeagueTable1 = "UPDATE Team_Records SET Matches_Played = Matches_Played + 1, GF =  GF + '" + GoalsFor1 + "',GA = GA + '" + GoalsAgainst1 + "' ,GD = GD + '" + GoalDifference1 + "',Points = Points  + 1 Where  Team_ID = '" + CodeID(AwayTeam2).Text + "'";
                dbUpdate(updateLeagueTable1);
                specUpdate(CodeID(AwayTeam2).Text);
            }
        }


        private void scorePoints3()
        {
            int GoalsFor, GoalsAgainst, GoalDifference;
            int GoalsFor1, GoalsAgainst1, GoalDifference1;
            String insertLeagueTable, insertLeagueTable1;
            String code, code1;
            code = "3A";
            code1 = "3B";


            if (int.Parse(HomeScore3.Text) > int.Parse(AwayScore3.Text))
            {
                GoalsFor = int.Parse(HomeScore3.Text);
                GoalsAgainst = int.Parse(AwayScore3.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

                
               


                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam3).Text + "', '" + Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 3, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam3).Text);


                GoalsFor1 = int.Parse(AwayScore3.Text);
                GoalsAgainst1 = int.Parse(HomeScore3.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam3).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 0, '" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam3).Text);
            }
            else if (int.Parse(HomeScore3.Text) < int.Parse(AwayScore3.Text))
            {
                GoalsFor = int.Parse(HomeScore3.Text);
                GoalsAgainst = int.Parse(AwayScore3.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

                
                


                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam3).Text + "', '" + Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 0, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam3).Text);




                GoalsFor1 = int.Parse(AwayScore3.Text);
                GoalsAgainst1 = int.Parse(HomeScore3.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam3).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 3, '" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam3).Text);
            }

            else if (int.Parse(HomeScore3.Text) == int.Parse(AwayScore3.Text))
            {
                GoalsFor = int.Parse(HomeScore3.Text);
                GoalsAgainst = int.Parse(AwayScore3.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

                
               


                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam3).Text + "', '" + Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 1, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam3).Text);




                GoalsFor1 = int.Parse(AwayScore3.Text);
                GoalsAgainst1 = int.Parse(HomeScore3.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam3).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 1, '" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam3).Text);
            }
        }

        private void scorePoints4()
        {
            int GoalsFor, GoalsAgainst, GoalDifference;
            int GoalsFor1, GoalsAgainst1, GoalDifference1;
            String insertLeagueTable, insertLeagueTable1;
            String code, code1;
            code = "4A";
            code1 = "4B";

            if (int.Parse(HomeScore4.Text) > int.Parse(AwayScore4.Text))
            {
                GoalsFor = int.Parse(HomeScore4.Text);
                GoalsAgainst = int.Parse(AwayScore4.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

                 
                


                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam4).Text + "', '" + Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 3, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam4).Text);


                GoalsFor1 = int.Parse(AwayScore4.Text);
                GoalsAgainst1 = int.Parse(HomeScore4.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam4).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 0,'" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam4).Text);
            }
            else if (int.Parse(HomeScore4.Text) < int.Parse(AwayScore4.Text))
            {
                GoalsFor = int.Parse(HomeScore4.Text);
                GoalsAgainst = int.Parse(AwayScore4.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

                
               


                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam4).Text + "', '" + Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 0, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam4).Text);




                GoalsFor1 = int.Parse(AwayScore4.Text);
                GoalsAgainst1 = int.Parse(HomeScore4.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam4).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 3, '" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam4).Text);
            }

            else if (int.Parse(HomeScore4.Text) == int.Parse(AwayScore4.Text))
            {
                GoalsFor = int.Parse(HomeScore4.Text);
                GoalsAgainst = int.Parse(AwayScore4.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

                
               


                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam4).Text + "', '" + Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 1, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam4).Text);




                GoalsFor1 = int.Parse(AwayScore4.Text);
                GoalsAgainst1 = int.Parse(HomeScore4.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam4).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 1, '" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam4).Text);
            }
        }

        private void scorePoints5()
        {
            int GoalsFor, GoalsAgainst, GoalDifference;
            int GoalsFor1, GoalsAgainst1, GoalDifference1;
            String insertLeagueTable, insertLeagueTable1;

            String code, code1;
            code = "5A";
            code1 = "5B";


            if (int.Parse(HomeScore5.Text) > int.Parse(AwayScore5.Text))
            {
                GoalsFor = int.Parse(HomeScore5.Text);
                GoalsAgainst = int.Parse(AwayScore5.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

                
               


                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam55).Text + "', '" + Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 3, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam55).Text);


                GoalsFor1 = int.Parse(AwayScore5.Text);
                GoalsAgainst1 = int.Parse(HomeScore5.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam5).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 0, '" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam5).Text);
            }
            else if (int.Parse(HomeScore5.Text) < int.Parse(AwayScore5.Text))
            {
                GoalsFor = int.Parse(HomeScore5.Text);
                GoalsAgainst = int.Parse(AwayScore5.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

                
                


                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam55).Text + "', '" + Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 0, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam55).Text);




                GoalsFor1 = int.Parse(AwayScore5.Text);
                GoalsAgainst1 = int.Parse(HomeScore5.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam5).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 3, '" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam5).Text);
            }

            else if (int.Parse(HomeScore5.Text) == int.Parse(AwayScore5.Text))
            {
                GoalsFor = int.Parse(HomeScore5.Text);
                GoalsAgainst = int.Parse(AwayScore5.Text);
                GoalDifference = GoalsFor - GoalsAgainst;

                 
                


                insertLeagueTable = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(HomeTeam55).Text + "', '" + Matches + "','" + GoalsFor + "','" + GoalsAgainst + "','" + GoalDifference + "', 1, '" + code + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable);
                specUpdate(CodeID(HomeTeam55).Text);




                GoalsFor1 = int.Parse(AwayScore5.Text);
                GoalsAgainst1 = int.Parse(HomeScore5.Text);
                GoalDifference1 = GoalsFor1 - GoalsAgainst1;


                insertLeagueTable1 = "INSERT INTO Fixtures (Team_ID, Matches_Played, GF,GA,GD,Points,Fixture_Code,League_ID) VALUES('" + CodeID(AwayTeam5).Text + "', '" + Matches + "','" + GoalsFor1 + "','" + GoalsAgainst1 + "','" + GoalDifference1 + "', 1, '" + code1 + "','" + dummyLabel.Text + "') ";
                dbInsert(insertLeagueTable1);
                specUpdate(CodeID(AwayTeam5).Text);
                 
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
             

        }
    }


}

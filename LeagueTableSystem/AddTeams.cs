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

    public partial class AddTeams : Form
    {

        static char firstLetter;
        static char secondLetter;
        static char thirdLetter;
        String picName;
        public static int leagueInt;
        private readonly Epl _epl;
        public AddTeams(Epl epl)
        {
            InitializeComponent();
            _epl = epl;
        }
        public void selectAll(String leagueCode)
        {
            String selectAllRecords = "SELECT Teams.Team_Name AS 'TEAMS',Team_Records.Matches_Played AS 'MATCHES PLAYED', Team_Records.GF AS 'GOALS SCORED',Team_Records.GA AS 'GOALS CONCEDED',Team_Records.GD AS 'GOAL DIFFERENCE',Team_Records.Points AS 'POINTS'  From Teams,Team_Records  Where Teams.Team_ID = Team_Records.Team_ID And Teams.League_ID = '" + leagueCode + "' Order By Team_Records.Points DESC ,  Team_Records.GD DESC, Team_Records.GF DESC";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Records_Table(selectAllRecords);

            _epl.Table.DataSource = sql.Records_Table(selectAllRecords);
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
        private void Create()
        {
            string Insert = "INSERT INTO Teams (League_ID, Team_Name, Team_Logo,Team_Coach,Team_Owner,Team_Code) VALUES('" + dummyLabel.Text + "','" + TeamName.Text + "','" + picName + "','" + TeamCoach.Text + "','" + TeamOwner.Text + "','" + TeamCode.Text + "')";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Teams_Table(Insert);

            int Mp = 0;
            int GF = 0;
            int GA = 0;
            int GD = 0;
            int Points = 0;


            string Insert1 = "INSERT INTO Team_Records (Team_ID, Matches_Played, GF,GA,GD,Points) VALUES('" + CodeID(TeamCode).Text + "','" + Mp + "','" + GF + "','" + GA + "','" + GD + "','" + Points + "')";
            sql.Teams_Table(Insert1);

            selectAll(dummyLabel.Text);
            _epl.Box.Visible = false;
            DialogResult result = MessageBox.Show("Do you want to Add another Team?", "Successfully Saved !", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {

                this.Close();

            }
            else if (result == DialogResult.Yes)
            {

                TeamCode.Clear();
                TeamName.Clear();
                TeamCoach.Clear();
                TeamOwner.Clear();
                pictureBoxTeamLogo.Image = null;
                TeamCode.Select();

            }
        }


        private TextBox CodeID(TextBox textBox)
        {


            TextBox txt = new TextBox();
            String select;
            select = "select Team_ID From Teams Where Team_Code = '" + textBox.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();

            sql.getTextBoxText(select, txt);

            return txt;
        }


        private void Create2()
        {
            string Insert = "INSERT INTO Team_Records (Team_ID, Matches_Played, GF,GA,GD,Points) VALUES('" + TeamName.Text + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "')";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Teams_Table(Insert);
            DialogResult result = MessageBox.Show("Do you want to Add another Team?", "Successfully Saved !", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {

                this.Close();

            }
            else if (result == DialogResult.Yes)
            {

                TeamCode.Clear();
                TeamName.Clear();
                TeamCoach.Clear();
                TeamOwner.Clear();
                pictureBoxTeamLogo.Image = null;
                TeamCode.Select();

            }
        }

        private void delete()
        {
            string Insert = "Delete Teams   where Team_ID =  '" + TeamCode.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Teams_Table(Insert);
            
        }

        private void AddTeams_Load(object sender, EventArgs e)
        {
            if (leagueInt == 1)
            {
                labelLeagueName.Text = "EPL";
                dummyLabel.Text = "EPL";
                leagueIcon.BackgroundImage = Properties.Resources.epl;
            }

            else if (leagueInt == 2)
            {
                labelLeagueName.Text = "Laliga";
                dummyLabel.Text = "ESP";
                leagueIcon.BackgroundImage = Properties.Resources.laliga;
            }

            else if (leagueInt == 3)
            {
                labelLeagueName.Text = "Serie A";
                dummyLabel.Text = "ITA";
                leagueIcon.BackgroundImage = Properties.Resources.serie_a;
            }

            else if (leagueInt == 4)
            {
                labelLeagueName.Text = "Bundesliga";
                dummyLabel.Text = "GER";
                leagueIcon.BackgroundImage = Properties.Resources.bundesliga;
            }

            else if (leagueInt == 5)
            {
                labelLeagueName.Text = "Ligue 1";
                dummyLabel.Text = "FRA";
                leagueIcon.BackgroundImage = Properties.Resources.league1;
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxPatientSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePickerPatientDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void TeamCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TeamCode.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                firstLetter = e.KeyChar;
            }


            if (TeamCode.Text.Length == 1)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                secondLetter = e.KeyChar;
            }


            if (TeamCode.Text.Length == 2)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
                thirdLetter = e.KeyChar;
            }
        }

        private void pictureBoxTeamLogo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "select image";
            openFileDialog1.Filter = "All files|*.PNG";
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();

            if(openFileDialog1.FileName == "")
            {

            }
            else
            {
                try
                {
                   pictureBoxTeamLogo.Load(openFileDialog1.FileName);
                     picName = openFileDialog1.SafeFileName;

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void AddSavebtn_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void update()
        {
            String Update = "UPDATE Teams SET Team_Name = '" + TeamName.Text + "'   WHERE Team_Code = '" + TeamCode.Text + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Teams_Table(Update);
        }

        private void TeamCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TeamName.Select();

            }
        }

        private void TeamName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TeamCoach.Select();

            }
        }

       
        private void TeamCoach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TeamOwner.Select();

            }
        }

        private void TeamOwner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBoxTeamLogo.Select();

            }
        }
    }
}

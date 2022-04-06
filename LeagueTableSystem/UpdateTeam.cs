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
    public partial class UpdateTeam : Form
    {
        private readonly Epl _epl;
        public UpdateTeam(Epl epl)
        {
            InitializeComponent();
            _epl = epl;
        }

        public static String updateRefString = "";

        private void deleting()
        {
            SqlDatabaseModule sql = new SqlDatabaseModule();
            String selectTeamID = "Select Team_ID From  Teams Where Team_Name = '" + updateRefString + "'";
            sql.getLabelText(selectTeamID,label1);


            String deleteRec = "Delete Team_Records Where Team_ID = '" + label1.Text + "' ";
            sql.Teams_Table(deleteRec);

            String deleteTeam = "Delete Teams Where Team_ID = '" + label1.Text + "' ";
            sql.Teams_Table(deleteTeam);
            this.Hide();
            Epl.popInt = 0;
            updateRefString = "";
            _epl.Box.Visible = false;
            _epl.fixResults1();
            MessageBox.Show("Successfully Deleted !");

        }

        private void updating()
        {
           String updateTeam = "UPDATE Teams SET Team_Code = '" + TeamCode.Text + "', Team_Name ='" + TeamName.Text + "', Team_Coach = '" + TeamCoach.Text + "' ,Team_Owner =  '" + TeamOwner.Text + "',Team_Logo = '"+ labell.Text +"' Where  Team_Name = '" + updateRefString + "'";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.Teams_Table(updateTeam);
            this.Hide();
            Epl.popInt = 0;
            updateRefString = "";
            _epl.Box.Visible = false;
            _epl.fixResults1();

            MessageBox.Show("Successfully Updated !");
            
        }
        private void UpdateTeam_Load(object sender, EventArgs e)
        {
            String selectCode = "SELECT Team_Code  From Teams  Where Team_Name = '" + updateRefString + "' ";
            String selectName = "SELECT Team_Name  From Teams  Where Team_Name = '" + updateRefString + "' ";
            String selectCoach = "SELECT Team_Coach  From Teams  Where Team_Name = '" + updateRefString + "' ";
            String selectOwner = "SELECT Team_Owner  From Teams  Where Team_Name = '" + updateRefString + "' ";
            String selectLogo = "SELECT Team_Logo  From Teams  Where Team_Name = '" + updateRefString + "' ";
            SqlDatabaseModule sql = new SqlDatabaseModule();
            sql.getLabelText(selectLogo, labell);
            TeamLogo.BackColor = Color.White;

            String picLocation = "E:\\Programming sample\\MyProject\\LeagueTableSystem\\LeagueTableSystem\\Resources\\" + labell.Text;
            TeamLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            TeamLogo.ImageLocation = picLocation;
            sql.getTextBoxText(selectCode, TeamCode);
            sql.getTextBoxText(selectName, TeamName);
            sql.getTextBoxText(selectCoach, TeamCoach);
            sql.getTextBoxText(selectOwner, TeamOwner);
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!e.Cancel && e.CloseReason == CloseReason.UserClosing)
            {


                e.Cancel = true;




                Epl.popInt = 0;
                 updateRefString = "";

                this.Hide();
                


            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void TeamLogo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "select image";
            openFileDialog1.Filter = "All files|*.PNG";
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName == "")
            {

            }
            else
            {
                try
                {
                    TeamLogo.Load(openFileDialog1.FileName);
                    labell.Text = openFileDialog1.SafeFileName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void update_DeleteBtn2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove '"+ updateRefString +"' from the League ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                deleting();
            }
        }

        private void update_Updatebtn2_Click(object sender, EventArgs e)
        {
            updating();
        }
    }
}

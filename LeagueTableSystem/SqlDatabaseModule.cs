using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueTableSystem
{

    public class SqlDatabaseModule

    {


        public SqlDataReader leagues_SqlDataReader;
        public SqlDataReader teams_SqlDataReader;
        public SqlDataReader records_SqlDataReader;
        public SqlDataReader fixtures_SqlDataReader;

        SqlCommand teams_Command;
        SqlCommand command;
        SqlCommand leagues_Command;
        SqlCommand records_Command;
        SqlCommand fixtures_Command;



        public System.Data.DataTable Leagues_Table(String leaguesSqlCommand)
        {
            System.Data.DataTable leaguesDataTable = new System.Data.DataTable();
            SqlConnection leaguesConnection = new SqlConnection(Properties.Settings.Default.Leagues);
            leagues_Command = new SqlCommand(leaguesSqlCommand, leaguesConnection);
            try {
                using (leaguesConnection)
                {

                    if (leaguesConnection.State == System.Data.ConnectionState.Closed)
                    {
                        leaguesConnection.Open();
                    }

                    using (leagues_Command)
                    {

                        leagues_SqlDataReader = leagues_Command.ExecuteReader();
                        leaguesDataTable.Load(leagues_SqlDataReader);
                    }

                    leaguesConnection.Close();
                }



            } catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }




            return leaguesDataTable;
        }


        public System.Data.DataTable Teams_Table(String teamsSqlCommand)
        {
            System.Data.DataTable teamsDataTable = new System.Data.DataTable();
            SqlConnection teamsConnection = new SqlConnection(Properties.Settings.Default.Teams);
            teams_Command = new SqlCommand(teamsSqlCommand, teamsConnection);
            try
            {
                using (teamsConnection)
                {

                    if (teamsConnection.State == System.Data.ConnectionState.Closed)
                    {
                        teamsConnection.Open();
                    }

                    using (teams_Command)
                    {

                        teams_SqlDataReader = teams_Command.ExecuteReader();
                        teamsDataTable.Load(teams_SqlDataReader);
                    }

                    teamsConnection.Close();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }




            return teamsDataTable;
        }


        public System.Data.DataTable Records_Table(String recordsSqlCommand)
        {
            System.Data.DataTable recordsDataTable = new System.Data.DataTable();
            SqlConnection recordsConnection = new SqlConnection(Properties.Settings.Default.Records);
            records_Command = new SqlCommand(recordsSqlCommand, recordsConnection);
            try
            {
                using (recordsConnection)
                {

                    if (recordsConnection.State == System.Data.ConnectionState.Closed)
                    {
                        recordsConnection.Open();
                    }

                    using (records_Command)
                    {

                        records_SqlDataReader = records_Command.ExecuteReader();
                        recordsDataTable.Load(records_SqlDataReader);
                    }

                    recordsConnection.Close();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }




            return recordsDataTable;
        }


        public System.Data.DataTable Fixtures_Table(String fixturesSqlCommand)
        {
            System.Data.DataTable fixturesDataTable = new System.Data.DataTable();
            SqlConnection fixturesConnection = new SqlConnection(Properties.Settings.Default.Fixtures);
            fixtures_Command = new SqlCommand(fixturesSqlCommand, fixturesConnection);
            try
            {
                using (fixturesConnection)
                {

                    if (fixturesConnection.State == System.Data.ConnectionState.Closed)
                    {
                        fixturesConnection.Open();
                    }

                    using (fixtures_Command)
                    {

                        fixtures_SqlDataReader = fixtures_Command.ExecuteReader();
                        fixturesDataTable.Load(fixtures_SqlDataReader);
                    }

                    fixturesConnection.Close();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }




            return fixturesDataTable;
        }




        public void getLabelText(String sqlCommand, Label EveryLabel)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Teams);
            command = new SqlCommand(sqlCommand, connection);
            String txt;
            try
            {

                using (connection)
                {

                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    using (command)
                    {



                        
                        

                            txt = command.ExecuteScalar().ToString();
                            EveryLabel.Text = txt;
                        



                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void getString(String sqlCommand, String EveryLabel)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Teams);
            command = new SqlCommand(sqlCommand, connection);
            String txt;
            try
            {

                using (connection)
                {

                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    using (command)
                    {






                        txt = command.ExecuteScalar().ToString();
                        EveryLabel = txt;




                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        public void getTextBoxText(String sqlCommand, TextBox EveryLabel)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Teams);
            command = new SqlCommand(sqlCommand, connection);
            String txt;
            try
            {

                using (connection)
                {

                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    using (command)
                    {






                        txt = command.ExecuteScalar().ToString();
                        EveryLabel.Text = txt;




                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





    }

}

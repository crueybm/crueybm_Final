/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 12/05/2017
 * Assignment: Final
 * Description: This program is designed to simulate an automotive navigation system.
 * It automatically suggests cities and towns based on the user's input, 
 * and actively enables and disables keys based on the previously entered letters.
 * The data in the application is provided by queries run against a linked database.
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crueybm_Final
{
    public partial class frmGPS : Form
    {
        String connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Location.accdb;
            Persist Security Info=False;";      //Provides the connection string for the database file
        String selectedState = null;            //Declares and sets String selectedState to null
        int StateID;                            //Declares int StateID
        String selectedCity = null;             //Declares and sets String selectedCity to null
        int CityID;                             //Declares int CityID
        String selectedStreet = null;           //Declares and sets String selectedStreet to null
        int StreetID;                           //Declares int StreetID
        String selectedAddress = null;          //Declares and sets String selectedAddress to null
        String search = null;                   //Declares and sets String search


        public frmGPS()
        {
            InitializeComponent();
            panState.Visible = true;            //Sets panel panState to visible
            panContainer.Visible = false;       //Sets panel panContainer to not visible
            panCity.Visible = true;             //Sets panel panCity to visible
            panStreet.Visible = false;          //Sets panel panStreet to not visible
            panAddress.Visible = false;         //Sets panel panAddress to not visible
            panNumpad.Visible = false;          //Sets panel panNumpad to not visible
            panMap.Visible = false;             //Sets panel panMap to not visible
        }

        private void frmGPS_Load(object sender, EventArgs e)            //Event handler for when frmGPS loads
        {
            OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
            try
            {
                conn.Open();                                            //Opens database connection
                OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null
                OleDbCommand cmd = new OleDbCommand("SELECT State FROM tState ORDER BY State", conn);
                reader = cmd.ExecuteReader();                           //Executes the reader using the query string
                while (reader.Read())                                   //While-loop that runs while the reader has items
                {
                    lbState.Items.Add(reader["State"].ToString());      //Adds all "State" items to lbState
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
            }
            finally
            {
                conn.Close();                                           //Closes database connection
            }
        }

        private void btnABC_Click(object sender, EventArgs e)           //Event handler for when btnABC is clicked
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
            try
            {
                conn.Open();                                            //Opens database connection
                OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'A' And 'C') ORDER BY State", conn);
                reader = cmd.ExecuteReader();                           //Executes the reader using the query string
                while (reader.Read())                                   //While-loop that runs while the reader has items
                {
                    lbState.Items.Add(reader["State"].ToString());      //Adds all "State" items starting with ABC to lbState
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
            }
            finally
            {
                conn.Close();                                           //Closes database connection
            }
        }

        private void btnDEF_Click(object sender, EventArgs e)           //Event handler for when btnDEF is clicked
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
            try
            {
                conn.Open();                                            //Opens database connection
                OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'D' And 'F') ORDER BY State", conn);
                reader = cmd.ExecuteReader();                           //Executes the reader using the query string    
                while (reader.Read())                                   //While-loop that runs while the reader has items
                {
                    lbState.Items.Add(reader["State"].ToString());      //Adds all "State" items starting with DEF to lbState
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
            }
            finally
            {
                conn.Close();                                           //Closes database connection
            }
        }

        private void btnGHI_Click(object sender, EventArgs e)           //Event handler for when btnGHI is clicked
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
            try
            {
                conn.Open();                                            //Opens database connection
                OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null    
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'G' And 'I') ORDER BY State", conn);
                reader = cmd.ExecuteReader();                           //Executes the reader using the query string
                while (reader.Read())                                   //While-loop that runs while the reader has items
                {
                    lbState.Items.Add(reader["State"].ToString());      //Adds all "State" items starting with GHI to lbState
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
            }
            finally
            {
                conn.Close();                                           //Closes database connection
            }
        }

        private void btnJKL_Click(object sender, EventArgs e)           //Event handler for when btnJKL is clicked
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
            try
            {
                conn.Open();                                            //Opens database connection
                OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null        
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'J' And 'L') ORDER BY State", conn);
                reader = cmd.ExecuteReader();                           //Executes the reader using the query string
                while (reader.Read())                                   //While-loop that runs while the reader has items
                {
                    lbState.Items.Add(reader["State"].ToString());      //Adds all "State" items starting with JKL to lbState
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
            }
            finally
            {
                conn.Close();                                           //Closes database connection
            }
        }

        private void btnMNO_Click(object sender, EventArgs e)           //Event handler for when btnMNO is clicked
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
            try
            {
                conn.Open();                                            //Opens database connection
                OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'M' And 'O') ORDER BY State", conn);
                reader = cmd.ExecuteReader();                           //Executes the reader using the query string
                while (reader.Read())                                   //While-loop that runs while the reader has items
                {
                    lbState.Items.Add(reader["State"].ToString());      //Adds all "State" items starting with MNO to lbState
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
            }
            finally
            {
                conn.Close();                                           //Closes database connection
            }
        }

        private void btnPQRS_Click(object sender, EventArgs e)          //Event handler for when btnPQRS is clicked
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
            try
            {
                conn.Open();                                            //Opens database connection
                OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'P' And 'S') ORDER BY State", conn);
                reader = cmd.ExecuteReader();                           //Executes the reader using the query string
                while (reader.Read())                                   //While-loop that runs while the reader has items    
                {
                    lbState.Items.Add(reader["State"].ToString());      //Adds all "State" items starting with PQRS to lbState
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
            }
            finally
            {
                conn.Close();                                           //Closes database connection
            }
        }

        private void btnTUV_Click(object sender, EventArgs e)           //Event handler for when btnTUV is clicked
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
            try
            {
                conn.Open();                                            //Opens database connection
                OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'T' And 'V') ORDER BY State", conn);
                reader = cmd.ExecuteReader();                           //Executes the reader using the query string
                while (reader.Read())                                   //While-loop that runs while the reader has items
                {
                    lbState.Items.Add(reader["State"].ToString());      //Adds all "State" items starting with TUV to lbState
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
            }
            finally
            {
                conn.Close();                                           //Closes database connection
            }
        }

        private void btnWXYZ_Click(object sender, EventArgs e)          //Event handler for when btnWXYZ is clicked
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
            try
            {
                conn.Open();                                            //Opens database connection
                OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'W' And 'Z') ORDER BY State", conn);
                reader = cmd.ExecuteReader();                           //Executes the reader using the query string
                while (reader.Read())                                   //While-loop that runs while the reader has items
                {
                    lbState.Items.Add(reader["State"].ToString());      //Adds all "State" items starting with WXYZ to lbState
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
            }
            finally
            {
                conn.Close();                                           //Closes database connection
            }
        }
        private void lbState_SelectedIndexChanged(object sender, EventArgs e)       //Event handler for when an item in lbState is selected
        {
            selectedState = lbState.SelectedItem.ToString();
            String q = "SELECT StateID FROM tState WHERE (tState.State = '" + selectedState + "') ORDER BY State";
            OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
            try
            {
                conn.Open();                                            //Opens database connection
                OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null
                OleDbCommand cmd = new OleDbCommand(q, conn);           //Declares OleDbCommand cmd and uses q and conn as arguments
                reader = cmd.ExecuteReader();                           //Executes the reader using the query string
                while (reader.Read())                                   //While-loop that runs while the reader has items
                {
                    StateID = Convert.ToInt32(reader["StateID"]);       //Sets int StateID to the selected state's corresponding StateID in the database
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
            }
            finally
            {
                conn.Close();                                           //Closes database connection
            }
            panState.Visible = false;                                   //Sets panState to not visible
            panContainer.Visible = true;                                //Sets panContainer to visible
            lblTitle.Text = "City Name";                                //Sets lblTitle to "City Name"
            CityAutoComplete();                                         //Calls on CityAutoComplete method
        }

        void CityAutoComplete()
        {
            int charCount = tbCitySearch.Text.Length;                   //Declares and sets int charCount
            List<String> lCity = new List<String>();                    //Declares List<String> lCity
            AutoCompleteStringCollection city = new AutoCompleteStringCollection();   //Declares AutoCompleteStringCollection city
            OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
            try
            {
                String q = "SELECT tCity.City FROM tCity " +
                    "INNER JOIN(tState INNER JOIN tStateCity ON tState.StateID = tStateCity.StateID) " +
                    "ON tCity.CityID = tStateCity.CityID WHERE(((tState.StateID) = " + StateID + "));";     //Query string for the database command
                conn.Open();                                            //Opens database connection
                OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null
                OleDbCommand cmd = new OleDbCommand(q, conn);           //Declares OleDbCommand cmd and uses q and conn as arguments
                reader = cmd.ExecuteReader();                           //Executes the reader using the query string
                while (reader.Read())                                   //While-loop that runs while the reader has items
                {
                    string cName = reader.GetString(0);                 //Declares cName and sets it to an item in the database
                    city.Add(cName);                                    //Adds cName to StringCollection city
                    lCity.Add(cName);                                   //Adds cName to List<String> lCity
                }
                tbCitySearch.AutoCompleteCustomSource = city;           //Sets tbCitySearch's AutoComplete Source to StringCollection city
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
            }
            finally
            {
                conn.Close();                                           //Closes database connection
            }
            foreach (Button item in panKeyboard.Controls)               //foreach loop for all buttons in panKeyboard
            {
                item.Enabled = false;                                   //Sets button to disabled
            }
            foreach (String c in lCity)                                 //foreach loop for Strings in lCity
            {
                try
                {
                    if (c.Substring(0, tbCitySearch.TextLength).ToUpper().Equals(tbCitySearch.Text) == false) { continue; }

                    string x = c.Substring(tbCitySearch.TextLength, 1);     //Declares string x and sets it to the letter after the user's previous entry

                    if (x == "a" || x == "A")       //If statement that enables buttons based on string x
                    {
                        btnA.Enabled = true;
                    }
                    else if (x == "b" || x == "B")
                    {
                        btnB.Enabled = true;
                    }
                    else if (x == "c" || x == "C")
                    {
                        btnC.Enabled = true;
                    }
                    else if (x == "d" || x == "D")
                    {
                        btnD.Enabled = true;
                    }
                    else if (x == "e" || x == "E")
                    {
                        btnE.Enabled = true;
                    }
                    else if (x == "f" || x == "F")
                    {
                        btnF.Enabled = true;
                    }
                    else if (x == "g" || x == "G")
                    {
                        btnG.Enabled = true;
                    }
                    else if (x == "h" || x == "H")
                    {
                        btnH.Enabled = true;
                    }
                    else if (x == "i" || x == "I")
                    {
                        btnI.Enabled = true;
                    }
                    else if (x == "j" || x == "J")
                    {
                        btnJ.Enabled = true;
                    }
                    else if (x == "k" || x == "K")
                    {
                        btnK.Enabled = true;
                    }
                    else if (x == "l" || x == "L")
                    {
                        btnL.Enabled = true;
                    }
                    else if (x == "m" || x == "M")
                    {
                        btnM.Enabled = true;
                    }
                    else if (x == "n" || x == "N")
                    {
                        btnN.Enabled = true;
                    }
                    else if (x == "o" || x == "O")
                    {
                        btnO.Enabled = true;
                    }
                    else if (x == "p" || x == "P")
                    {
                        btnP.Enabled = true;
                    }
                    else if (x == "q" || x == "Q")
                    {
                        btnQ.Enabled = true;
                    }
                    else if (x == "r" || x == "R")
                    {
                        btnR.Enabled = true;
                    }
                    else if (x == "s" || x == "S")
                    {
                        btnS.Enabled = true;
                    }
                    else if (x == "t" || x == "T")
                    {
                        btnT.Enabled = true;
                    }
                    else if (x == "u" || x == "U")
                    {
                        btnU.Enabled = true;
                    }
                    else if (x == "v" || x == "V")
                    {
                        btnV.Enabled = true;
                    }
                    else if (x == "w" || x == "W")
                    {
                        btnW.Enabled = true;
                    }
                    else if (x == "x" || x == "X")
                    {
                        btnX.Enabled = true;
                    }
                    else if (x == "y" || x == "Y")
                    {
                        btnY.Enabled = true;
                    }
                    else if (x == "z" || x == "Z")
                    {
                        btnZ.Enabled = true;
                    }
                } catch (Exception ex)      //Empty catch block to handle array out of bounds exception
                {

                }
            }
        }

        private void tbCitySearch_TextChanged(object sender, EventArgs e)   //Event handler for when text is changed in tbCitySearch
        {
            CityAutoComplete();          //Calls on CityAutoComplete
            btnBackspace.Enabled = true; //Keeps btnBackspace enabled   
            btnSpace.Enabled = true;     //Keeps btnSpace enabled
        }

        private void btnCitySubmit_Click(object sender, EventArgs e)        //Event handler for when btnCitySubmit is clicked
        {
            selectedCity = tbCitySearch.Text.ToString();
            String q = "SELECT CityID FROM tCity WHERE (tCity.City = '" + selectedCity + "') ORDER BY City";
            OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
            try
            {
                conn.Open();                                            //Opens database connection
                OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null
                OleDbCommand cmd = new OleDbCommand(q, conn);           //Declares OleDbCommand cmd and uses q and conn as arguments
                reader = cmd.ExecuteReader();                           //Executes the reader using the query string
                while (reader.Read())                                   //While-loop that runs while the reader has items
                {
                    CityID = Convert.ToInt32(reader["CityID"]);         //Sets CityID to value from database
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
            }
            finally
            {
                conn.Close();                                           //Closes database connection
            }
            panCity.Visible = false;                                    //Sets panCity to not visible
            panStreet.Visible = true;                                   //Sets panStreet to visible
            lblTitle.Text = "Street Name";                              //Sets lblTitle to say "Street Name"
            StreetAutoComplete();                                       //Calls on StreetAutoComplete method
        }
        void StreetAutoComplete()
        {
            try
            {
                List<String> lStreet = new List<String>();              //Declares List<String> lStreet
                AutoCompleteStringCollection street = new AutoCompleteStringCollection();   //Declares StringCollection street
                OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
                try
                {
                    String q = "SELECT tStreet.Street FROM tStreet " +
                        "INNER JOIN(tCity INNER JOIN tCityStreet ON tCity.CityID = tCityStreet.CityID) " +
                        "ON tStreet.StreetID = tCityStreet.StreetID WHERE(((tCityStreet.CityID) = " + CityID + "));";
                    conn.Open();                                            //Opens database connection
                    OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null
                    OleDbCommand cmd = new OleDbCommand(q, conn);           //Declares OleDbCommand cmd and uses q and conn as arguments
                    reader = cmd.ExecuteReader();                           //Executes the reader using the query string
                    while (reader.Read())                                   //While-loop that runs while the reader has items
                    {
                        string sName = reader.GetString(0);                 //Declares and sets string sName to reader result
                        street.Add(sName);                                  //Adds sName to StringCollection street
                        lStreet.Add(sName);                                 //Adds sName to lStreet
                    }
                    tbStreetSearch.AutoCompleteCustomSource = street;       //Sets tbStreetSearch's source to street
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
                }
                finally
                {
                    conn.Close();                                           //Closes database connection
                }
                foreach (Button item in panKeyboard.Controls)               //foreach loop for all buttons in panKeyboard
                {
                    item.Enabled = false;                                   //Sets button to disabled
                }
                foreach (String c in lStreet)                               //foreach loop for Strings in lStreet
                {
                    if (c.Substring(0, tbStreetSearch.TextLength).ToUpper().Equals(tbStreetSearch.Text.ToUpper()) == false) { continue; }

                    string x = c.Substring(tbStreetSearch.TextLength, 1);   //Declares string x and sets it to the letter after the user's previous entry

                    if (x == "a" || x == "A")       //If statement that enables buttons based on string x
                    {
                        btnA.Enabled = true;
                    }
                    else if (x == "b" || x == "B")
                    {
                        btnB.Enabled = true;
                    }
                    else if (x == "c" || x == "C")
                    {
                        btnC.Enabled = true;
                    }
                    else if (x == "d" || x == "D")
                    {
                        btnD.Enabled = true;
                    }
                    else if (x == "e" || x == "E")
                    {
                        btnE.Enabled = true;
                    }
                    else if (x == "f" || x == "F")
                    {
                        btnF.Enabled = true;
                    }
                    else if (x == "g" || x == "G")
                    {
                        btnG.Enabled = true;
                    }
                    else if (x == "h" || x == "H")
                    {
                        btnH.Enabled = true;
                    }
                    else if (x == "i" || x == "I")
                    {
                        btnI.Enabled = true;
                    }
                    else if (x == "j" || x == "J")
                    {
                        btnJ.Enabled = true;
                    }
                    else if (x == "k" || x == "K")
                    {
                        btnK.Enabled = true;
                    }
                    else if (x == "l" || x == "L")
                    {
                        btnL.Enabled = true;
                    }
                    else if (x == "m" || x == "M")
                    {
                        btnM.Enabled = true;
                    }
                    else if (x == "n" || x == "N")
                    {
                        btnN.Enabled = true;
                    }
                    else if (x == "o" || x == "O")
                    {
                        btnO.Enabled = true;
                    }
                    else if (x == "p" || x == "P")
                    {
                        btnP.Enabled = true;
                    }
                    else if (x == "q" || x == "Q")
                    {
                        btnQ.Enabled = true;
                    }
                    else if (x == "r" || x == "R")
                    {
                        btnR.Enabled = true;
                    }
                    else if (x == "s" || x == "S")
                    {
                        btnS.Enabled = true;
                    }
                    else if (x == "t" || x == "T")
                    {
                        btnT.Enabled = true;
                    }
                    else if (x == "u" || x == "U")
                    {
                        btnU.Enabled = true;
                    }
                    else if (x == "v" || x == "V")
                    {
                        btnV.Enabled = true;
                    }
                    else if (x == "w" || x == "W")
                    {
                        btnW.Enabled = true;
                    }
                    else if (x == "x" || x == "X")
                    {
                        btnX.Enabled = true;
                    }
                    else if (x == "y" || x == "Y")
                    {
                        btnY.Enabled = true;
                    }
                    else if (x == "z" || x == "Z")
                    {
                        btnZ.Enabled = true;
                    }
                }
            }
            catch (Exception ex)    //Empty catch block to handle array out of bounds exceptions
            {

            }
        }

        private void tbStreetSearch_TextChanged(object sender, EventArgs e)     //Event handler for when text is changed in tbStreetSearch
        {
            StreetAutoComplete();           //Calls on StreetAutoComplete method
            btnBackspace.Enabled = true;    //Keeps btnBackspace enabled  
            btnSpace.Enabled = true;        //Keeps btnSpace enabled
        }

        private void btnStreetSubmit_Click(object sender, EventArgs e)          //Event handler for when btnStreetSubmit is clicked
        {
            selectedStreet = tbStreetSearch.Text.ToString();
            String q = "SELECT StreetID FROM tStreet WHERE (tStreet.Street = '" + selectedStreet + "') ORDER BY Street";
            OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
            try
            {
                conn.Open();                                            //Opens database connection
                OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null
                OleDbCommand cmd = new OleDbCommand(q, conn);           //Declares OleDbCommand cmd and uses q and conn as arguments
                reader = cmd.ExecuteReader();                           //Executes the reader using the query string
                while (reader.Read())                                   //While-loop that runs while the reader has items
                {
                    StreetID = Convert.ToInt32(reader["StreetID"]);     //Sets StreetID to value from the database
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
            }
            finally
            {
                conn.Close();                                           //Closes database connection
            }
            panStreet.Visible = false;                                  //Sets panStreet to not visible
            panKeyboard.Visible = false;
            panAddress.Visible = true;                                  //Sets panAddress to visible
            panNumpad.Visible = true;
            lblTitle.Text = "House Number";                             //Sets lblTitle to "House Number"
            AddressAutoComplete();
        }
        void AddressAutoComplete()
        {
            List<String> lAddress = new List<String>();
            AutoCompleteStringCollection address = new AutoCompleteStringCollection();
            OleDbConnection conn = new OleDbConnection(connString);     //Uses connString to connect to the database
            try
            {
                String q = "SELECT tAddress.Address FROM tAddress " +
                    "INNER JOIN(tStreet INNER JOIN tStreetAddress ON tStreet.StreetID = tStreetAddress.StreetID) " +
                    "ON tAddress.AddressID = tStreetAddress.AddressID WHERE(((tStreet.StreetID) = " + StreetID + "));";
                conn.Open();                                            //Opens database connection
                OleDbDataReader reader = null;                          //Declares a DataReader and sets it to null
                OleDbCommand cmd = new OleDbCommand(q, conn);           //Declares OleDbCommand cmd and uses q and conn as arguments
                reader = cmd.ExecuteReader();                           //Executes the reader using the query string
                while (reader.Read())                                   //While-loop that runs while the reader has items
                {
                    string aName = (reader.GetString(0));               //Declares and sets string aName to the reader's result
                    address.Add(aName);                                 //Adds aName to StringCollection address
                    lAddress.Add(aName);                                //Adds aName to lAddress
                }
                tbStreetSearch.AutoCompleteCustomSource = address;      //Sets tbStreetSearch's source to address
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");       //Catches in case the database cannot be connected to, and creates a message box.
            }
            finally
            {
                conn.Close();                                           //Closes database connection
            }
            foreach (Button item in panNumpad.Controls)               //foreach loop for all buttons in panKeyboard
            {
                item.Enabled = false;                                   //Sets button to disabled
            }
            foreach (String c in lAddress)                                 //foreach loop for Strings in lStreet
            {
                try
                {
                    if (c.Substring(0, tbAddressSearch.TextLength).ToUpper().Equals(tbAddressSearch.Text.ToUpper()) == false) { continue; }

                    string nAddress = c.Substring(tbAddressSearch.TextLength, 1);   //Declares string nAddress and sets it to the letter after the user's previous entry

                    if (nAddress == "1")            //If statement that enables buttons based on string x
                    {
                        btnNum1.Enabled = true;
                    } else if (nAddress == "2")
                    {
                        btnNum2.Enabled = true;
                    } else if (nAddress == "3")
                    {
                        btnNum3.Enabled = true;
                    } else if (nAddress == "4")
                    {
                        btnNum4.Enabled = true;
                    } else if (nAddress == "5")
                    {
                        btnNum5.Enabled = true;
                    } else if (nAddress == "6")
                    {
                        btnNum6.Enabled = true;
                    } else if (nAddress == "7")
                    {
                        btnNum7.Enabled = true;
                    } else if (nAddress == "8")
                    {
                        btnNum8.Enabled = true;
                    } else if (nAddress == "9")
                    {
                        btnNum9.Enabled = true;
                    } else if (nAddress == "0")
                    {
                        btnNum0.Enabled = true;
                    }
                }
                catch (Exception ex)        //Empty catch block to handle array out of bounds exception
                {

                }
            }
        }

        private void tbAddressSearch_TextChanged(object sender, EventArgs e)    //Event handler for when text is changed in tbAddressSearch
        {
            AddressAutoComplete();              //Calls upon AddressAutoComplete
            btnNumBackspace.Enabled = true;     //Keeps btnNumBackspace enabled
        }

        private void btnA_Click(object sender, EventArgs e)         //Event handler for btnA
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("A");
            }
            else if (panStreet.Visible == true)   //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("A");
            }
        }

        private void btnB_Click(object sender, EventArgs e)         //Event handler for btnB
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("B");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("B");
            }
        }

        private void btnC_Click(object sender, EventArgs e)         //Event handler for btnC
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("C");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("C");
            }
        }

        private void btnD_Click(object sender, EventArgs e)         //Event handler for btnD
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("D");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("D");
            }
        }

        private void btnE_Click(object sender, EventArgs e)         //Event handler for btnE
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("E");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("E");
            }
        }

        private void btnF_Click(object sender, EventArgs e)         //Event handler for btnF
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("F");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("F");
            }
        }

        private void btnG_Click(object sender, EventArgs e)         //Event handler for btnG
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("G");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("G");
            }
        }

        private void btnH_Click(object sender, EventArgs e)         //Event handler for btnH
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("H");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("H");
            }
        }

        private void btnI_Click(object sender, EventArgs e)         //Event handler for btnI
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("I");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("I");
            }
        }

        private void btnJ_Click(object sender, EventArgs e)         //Event handler for btnJ
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("J");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("J");
            }
        }

        private void btnK_Click(object sender, EventArgs e)         //Event handler for btnK
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("K");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("K");
            }
        }

        private void btnL_Click(object sender, EventArgs e)         //Event handler for btnL
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("L");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("L");
            }
        }

        private void btnM_Click(object sender, EventArgs e)         //Event handler for btnM
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("M");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("M");
            }
        }

        private void btnN_Click(object sender, EventArgs e)         //Event handler for btnN
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("N");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("N");
            }
        }

        private void bntO_Click(object sender, EventArgs e)         //Event handler for btnO  
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("O");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("O");
            }
        }

        private void btnP_Click(object sender, EventArgs e)         //Event handler for btnP
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("P");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("P");
            }
        }

        private void btnQ_Click(object sender, EventArgs e)         //Event handler for btnQ
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("Q");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("Q");
            }
        }

        private void btnR_Click(object sender, EventArgs e)         //Event handler for btnR
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("R");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("R");
            }
        }

        private void btnS_Click(object sender, EventArgs e)         //Event handler for btnS
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("S");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("S");
            }
        }

        private void btnT_Click(object sender, EventArgs e)         //Event handler for btnT
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("T");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("T");
            }
        }

        private void btnU_Click(object sender, EventArgs e)         //Event handler for btnU
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("U");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("U");
            }
        }

        private void btnV_Click(object sender, EventArgs e)         //Event handler for btnV
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("V");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("V");
            }
        }

        private void btnW_Click(object sender, EventArgs e)         //Event handler for btnW
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("W");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("W");
            }
        }

        private void btnX_Click(object sender, EventArgs e)         //Event handler for btnX
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("X");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("X");
            }
        }

        private void btnY_Click(object sender, EventArgs e)         //Event handler for btnY
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("Y");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("Y");
            }
        }

        private void btnZ_Click(object sender, EventArgs e)         //Event handler for btnZ
        {
            if (panCity.Visible == true)            //If panCity is visible, enters letter to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send("Z");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, enters letter to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send("Z");
            }
        }
        private void btnBackspace_Click(object sender, EventArgs e)     //Event handler for btnBackspace
        {
            if (panCity.Visible == true)            //If panCity is visible, deletes letter from tbCitySearch
            {
                tbCitySearch.Focus();
                if (tbCitySearch.SelectionLength > 0)       //If no letters in tbCitySearch, does nothing
                {
                    tbCitySearch.SelectedText = "";
                }
                else if (tbCitySearch.SelectionStart > 0)   //If greater than zero characters in tbCitySearch, deletes end character
                {
                    tbCitySearch.Text = tbCitySearch.Text.Remove(--tbCitySearch.SelectionStart, 1);
                }
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, deletes letter from tbStreetSearch
            {
                tbStreetSearch.Focus();
                if (tbStreetSearch.SelectionLength > 0)     //If no letters in tbStreetSearch, does nothing
                {
                    tbStreetSearch.SelectedText = "";
                }
                else if (tbStreetSearch.SelectionStart > 0) //If greater than zero characters in tbStreetSearch, deletes end character
                {
                    tbStreetSearch.Text = tbStreetSearch.Text.Remove(--tbStreetSearch.SelectionStart, 1);
                }
            }
        }
        private void btnSpace_Click(object sender, EventArgs e)     //Event handler for btnSpace
        {
            if (panCity.Visible == true)            //If panCity is visible, adds a space to tbCitySearch
            {
                tbCitySearch.Focus();
                SendKeys.Send(" ");
            }
            else if (panStreet.Visible == true)     //If panStreet is visible, adds a space to tbStreetSearch
            {
                tbStreetSearch.Focus();
                SendKeys.Send(" ");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)      //Event handler for btnBack
        {
            if (panState.Visible == true)       //If panState is visible, button is disabled
            {
                btnBack.Enabled = false;
            } else if (panContainer.Visible == true && panCity.Visible == true)     //Else if panContainer and panCity are visible
            {
                tbCitySearch.Clear();               //Clears tbCitySearch
                panContainer.Visible = false;       //Sets panContainer to not visible
                panState.Visible = true;            //Sets panState to visible
                lblTitle.Text = "State/Province";   //Sets lblTitle to "State/Province"
            } else if (panContainer.Visible == true && panStreet.Visible == true)   //Else if panContainer and panStreet are visible
            {
                tbStreetSearch.Clear();             //Clears tbStreetSearch
                panStreet.Visible = false;          //Sets panStreet to not visible
                panCity.Visible = true;             //Sets panCity to visible
                lblTitle.Text = "City Name";        //Sets lblTitle to "City Name"
            } else if (panContainer.Visible == true && panAddress.Visible == true)  //Else if panContainer and panAddress are visible
            {
                tbAddressSearch.Clear();            //Clears tbAddressSearch
                panAddress.Visible = false;         //Sets panAddress to not visible
                panNumpad.Visible = false;          //Sets panNumpad to not visible
                panStreet.Visible = true;           //Sets panStreet to visible
                panKeyboard.Visible = true;         //Sets panKeyboard to visible
                lblTitle.Text = "Street Name";      //Sets lblTitle to "Street Name"
            } else if (panMap.Visible == true)      //Else if panMap is visible
            {
                panMap.Visible = false;             //Sets panMap to not visible
                panContainer.Visible = true;        //Sets panContainer to visible
                panAddress.Visible = true;          //Sets panAddress to visible
                lblTitle.Text = "House Number";     //Sets lblTitle to "House Number"
            }

        }
        private void btnAddressSubmit_Click(object sender, EventArgs e)     //Event handler for when btnAddressSubmit is clicked
        {
            selectedAddress = tbAddressSearch.Text.ToString();              //Sets selectedAddress to what was entered in tbAddressSearch
            search = selectedAddress + " " + selectedStreet + ", " + selectedCity + " " + selectedState;    //Sets String search to all selected items in the form
            panContainer.Visible = false;               //Sets panContainer to not visible
            panMap.Visible = true;                      //Sets panMap to visible
            wbMap.Navigate("https://www.google.com/maps/place/" + search);  //Navigates wbMap to a google maps search of the entered address
            lblTitle.Text = "Confirm Destination";      //Sets lblTitle to "Confirm Destination"
        }

        private void btnNum1_Click(object sender, EventArgs e)      //Event handler for btnNum1
        {
            if (panNumpad.Visible == true)      //If panNumpad is visible, adds number "1" to tbAddressSearch
            {
                tbAddressSearch.Focus();
                SendKeys.Send("1");
            }
        }

        private void btnNum2_Click(object sender, EventArgs e)      //Event handler for btnNum2
        {
            if (panNumpad.Visible == true)      //If panNumpad is visible, adds number "2" to tbAddressSearch
            {
                tbAddressSearch.Focus();
                SendKeys.Send("2");
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)      //Event handler for btnNum3
        {
            if (panNumpad.Visible == true)      //If panNumpad is visible, adds number "3" to tbAddressSearch
            {
                tbAddressSearch.Focus();
                SendKeys.Send("3");
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)      //Event handler for btnNum4
        {
            if (panNumpad.Visible == true)      //If panNumpad is visible, adds number "4" to tbAddressSearch
            {
                tbAddressSearch.Focus();
                SendKeys.Send("4");
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)      //Event handler for btnNum5
        {
            if (panNumpad.Visible == true)      //If panNumpad is visible, adds number "5" to tbAddressSearch
            {
                tbAddressSearch.Focus();
                SendKeys.Send("5");
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)      //Event handler for btnNum6
        {
            if (panNumpad.Visible == true)      //If panNumpad is visible, adds number "6" to tbAddressSearch
            {
                tbAddressSearch.Focus();
                SendKeys.Send("6");
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)      //Event handler for btnNum7
        {
            if (panNumpad.Visible == true)      //If panNumpad is visible, adds number "7" to tbAddressSearch
            {
                tbAddressSearch.Focus();
                SendKeys.Send("7");
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)      //Event handler for btnNum8
        {
            if (panNumpad.Visible == true)      //If panNumpad is visible, adds number "8" to tbAddressSearch
            {
                tbAddressSearch.Focus();
                SendKeys.Send("8");
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)      //Event handler for btnNum9
        {
            if (panNumpad.Visible == true)      //If panNumpad is visible, adds number "9" to tbAddressSearch
            {
                tbAddressSearch.Focus();
                SendKeys.Send("9");
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)      //Event handler for btnNum0
        {
            if (panNumpad.Visible == true)      //If panNumpad is visible, adds number "0" to tbAddressSearch
            {
                tbAddressSearch.Focus();
                SendKeys.Send("0");
            }
        }

        private void btnNumBackspace_Click(object sender, EventArgs e)      //Event handler for btnNumBackspace
        {
            tbAddressSearch.Focus();
            if (tbAddressSearch.SelectionLength > 0)        //If no text in box, does nothing
            {
                tbAddressSearch.SelectedText = "";
            }
            else if (tbAddressSearch.SelectionStart > 0)    //If text in box is greater than 0, deletes one character
            {
                tbAddressSearch.Text = tbAddressSearch.Text.Remove(--tbAddressSearch.SelectionStart, 1);
            }
        }
    }
}

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
            Persist Security Info=False;";
        String selectedState = null;
        int StateID;
        String selectedCity = null;
        int CityID;
        String selectedStreet = null;
        int StreetID;
        String selectedAddress = null;
        int AddressID;
        String search = null;


        public frmGPS()
        {
            InitializeComponent();
            panState.Visible = true;
            panContainer.Visible = false;
            panCity.Visible = true;
            panStreet.Visible = false;
            panAddress.Visible = false;
            panMap.Visible = false;
        }

        private void frmGPS_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand("SELECT State FROM tState ORDER BY State", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lbState.Items.Add(reader["State"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnABC_Click(object sender, EventArgs e)
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'A' And 'C') ORDER BY State", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lbState.Items.Add(reader["State"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDEF_Click(object sender, EventArgs e)
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'D' And 'F') ORDER BY State", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lbState.Items.Add(reader["State"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnGHI_Click(object sender, EventArgs e)
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'G' And 'I') ORDER BY State", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lbState.Items.Add(reader["State"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnJKL_Click(object sender, EventArgs e)
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'J' And 'L') ORDER BY State", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lbState.Items.Add(reader["State"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnMNO_Click(object sender, EventArgs e)
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'M' And 'O') ORDER BY State", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lbState.Items.Add(reader["State"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnPQRS_Click(object sender, EventArgs e)
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'P' And 'S') ORDER BY State", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lbState.Items.Add(reader["State"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnTUV_Click(object sender, EventArgs e)
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'T' And 'V') ORDER BY State", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lbState.Items.Add(reader["State"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnWXYZ_Click(object sender, EventArgs e)
        {
            lbState.Items.Clear();
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand("SELECT StateID, State FROM tState WHERE (Left([tState.State], 1) Between 'W' And 'Z') ORDER BY State", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lbState.Items.Add(reader["State"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
        }
        private void lbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = lbState.SelectedItem.ToString();
            String q = "SELECT StateID FROM tState WHERE (tState.State = '" + selectedState + "') ORDER BY State";
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand(q, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    StateID = Convert.ToInt32(reader["StateID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
            panState.Visible = false;
            panContainer.Visible = true;
            lblTitle.Text = "City Name";
        }

        void CityAutoComplete()
        {
            int charCount = tbCitySearch.Text.Length;
            List<String> lCity = new List<String>();
            AutoCompleteStringCollection city = new AutoCompleteStringCollection();
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                String q = "SELECT tCity.City FROM tCity " +
                    "INNER JOIN(tState INNER JOIN tStateCity ON tState.StateID = tStateCity.StateID) " +
                    "ON tCity.CityID = tStateCity.CityID WHERE(((tState.StateID) = " + StateID + "));";
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand(q, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string cName = reader.GetString(0);
                    city.Add(cName);
                    lCity.Add(cName);
                }
                tbCitySearch.AutoCompleteCustomSource = city;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
            foreach (Button item in panKeyboard.Controls)
            {
                item.Enabled = false;
                //item.BackColor = Color.Black;
                //item.ForeColor = Color.White;
            }
            foreach (String c in lCity)
            {
                List<char> charCity = new List<char>();
                for (int i = 0; i < c.Length; i++)
                {
                    charCity.Add(c[i]);
                }
                string x = charCity[charCount].ToString();
                //string xx = "";
                /*if (tbCitySearch.Text.Length > 0)
                {
                    xx = charCity[charCount -1].ToString();
                }
                foreach (char cc in charCity)
                {
                    if (tbCitySearch.Text.EndsWith(charCity[charCount - 1].ToString()) == xx)
                    {*/
                        if (x == "a" || x == "A")
                        {
                            btnA.Enabled = true;
                            //btnA.BackColor = Color.Silver;
                            //btnA.ForeColor = Color.Black;
                        }
                        else if (x == "b" || x == "B")
                        {
                            btnB.Enabled = true;
                            //btnB.BackColor = Color.Silver;
                            //btnB.ForeColor = Color.Black;
                        }
                        else if (x == "c" || x == "C")
                        {
                            btnC.Enabled = true;
                            //btnC.BackColor = Color.Silver;
                            //btnC.ForeColor = Color.Black;
                        }
                        else if (x == "d" || x == "D")
                        {
                            btnD.Enabled = true;
                            //btnD.BackColor = Color.Silver;
                            //btnD.ForeColor = Color.Black;
                        }
                        else if (x == "e" || x == "E")
                        {
                            btnE.Enabled = true;
                            //btnE.BackColor = Color.Silver;
                            //btnE.ForeColor = Color.Black;
                        }
                        else if (x == "f" || x == "F")
                        {
                            btnF.Enabled = true;
                            //btnF.BackColor = Color.Silver;
                            //btnF.ForeColor = Color.Black;
                        }
                        else if (x == "g" || x == "G")
                        {
                            btnG.Enabled = true;
                            //btnG.BackColor = Color.Silver;
                            //btnG.ForeColor = Color.Black;
                        }
                        else if (x == "h" || x == "H")
                        {
                            btnH.Enabled = true;
                            //btnH.BackColor = Color.Silver;
                            //btnH.ForeColor = Color.Black;
                        }
                        else if (x == "i" || x == "I")
                        {
                            btnI.Enabled = true;
                            //btnI.BackColor = Color.Silver;
                            //btnI.ForeColor = Color.Black;
                        }
                        else if (x == "j" || x == "J")
                        {
                            btnJ.Enabled = true;
                            //btnJ.BackColor = Color.Silver;
                            //btnJ.ForeColor = Color.Black;
                        }
                        else if (x == "k" || x == "K")
                        {
                            btnK.Enabled = true;
                            //btnK.BackColor = Color.Silver;
                            //btnK.ForeColor = Color.Black;
                        }
                        else if (x == "l" || x == "L")
                        {
                            btnL.Enabled = true;
                            //btnL.BackColor = Color.Silver;
                            //btnL.ForeColor = Color.Black;
                        }
                        else if (x == "m" || x == "M")
                        {
                            btnM.Enabled = true;
                            //btnM.BackColor = Color.Silver;
                            //btnM.ForeColor = Color.Black;
                        }
                        else if (x == "n" || x == "N")
                        {
                            btnN.Enabled = true;
                            //btnN.BackColor = Color.Silver;
                            //btnN.ForeColor = Color.Black;
                        }
                        else if (x == "o" || x == "O")
                        {
                            btnO.Enabled = true;
                            //btnO.BackColor = Color.Silver;
                            //btnO.ForeColor = Color.Black;
                        }
                else if (x == "p" || x == "P")
                {
                    btnP.Enabled = true;
                    //btnO.BackColor = Color.Silver;
                    //btnO.ForeColor = Color.Black;
                }
                else if (x == "q" || x == "Q")
                {
                    btnQ.Enabled = true;
                    //btnO.BackColor = Color.Silver;
                    //btnO.ForeColor = Color.Black;
                }
                else if (x == "r" || x == "R")
                {
                    btnR.Enabled = true;
                    //btnO.BackColor = Color.Silver;
                    //btnO.ForeColor = Color.Black;
                }
                else if (x == "s" || x == "S")
                {
                    btnS.Enabled = true;
                    //btnO.BackColor = Color.Silver;
                    //btnO.ForeColor = Color.Black;
                }
                else if (x == "t" || x == "T")
                {
                    btnT.Enabled = true;
                    //btnO.BackColor = Color.Silver;
                    //btnO.ForeColor = Color.Black;
                }
                else if (x == "u" || x == "U")
                {
                    btnU.Enabled = true;
                    //btnO.BackColor = Color.Silver;
                    //btnO.ForeColor = Color.Black;
                }
                else if (x == "v" || x == "V")
                {
                    btnV.Enabled = true;
                    //btnO.BackColor = Color.Silver;
                    //btnO.ForeColor = Color.Black;
                }
                else if (x == "w" || x == "W")
                {
                    btnW.Enabled = true;
                    //btnO.BackColor = Color.Silver;
                    //btnO.ForeColor = Color.Black;
                }
                else if (x == "x" || x == "X")
                {
                    btnX.Enabled = true;
                    //btnO.BackColor = Color.Silver;
                    //btnO.ForeColor = Color.Black;
                }
                else if (x == "y" || x == "Y")
                {
                    btnY.Enabled = true;
                    //btnO.BackColor = Color.Silver;
                    //btnO.ForeColor = Color.Black;
                }
                else if (x == "z" || x == "Z")
                {
                    btnZ.Enabled = true;
                    //btnO.BackColor = Color.Silver;
                    //btnO.ForeColor = Color.Black;
                }
                //break;
                //}
                //}
            }
        }

        private void tbCitySearch_TextChanged(object sender, EventArgs e)
        {
            CityAutoComplete();
        }

        private void btnCitySubmit_Click(object sender, EventArgs e)
        {
            selectedCity = tbCitySearch.Text.ToString();
            String q = "SELECT CityID FROM tCity WHERE (tCity.City = '" + selectedCity + "') ORDER BY City";
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand(q, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CityID = Convert.ToInt32(reader["CityID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
            panCity.Visible = false;
            panStreet.Visible = true;
            lblTitle.Text = "Street Name";
        }
        void StreetAutoComplete()
        {
            AutoCompleteStringCollection street = new AutoCompleteStringCollection();
            OleDbConnection conn = new OleDbConnection(connString);
            try
            { 
                String q = "SELECT tStreet.Street FROM tStreet " +
                    "INNER JOIN(tCity INNER JOIN tCityStreet ON tCity.CityID = tCityStreet.CityID) " +
                    "ON tStreet.StreetID = tCityStreet.StreetID WHERE(((tCityStreet.CityID) = " + CityID + "));";
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand(q, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString(0);
                    street.Add(sName);
                }
                tbStreetSearch.AutoCompleteCustomSource = street;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
        }

        private void tbStreetSearch_TextChanged(object sender, EventArgs e)
        {
            StreetAutoComplete();
        }

        private void btnStreetSubmit_Click(object sender, EventArgs e)
        {
            selectedStreet = tbStreetSearch.Text.ToString();
            String q = "SELECT StreetID FROM tStreet WHERE (tStreet.Street = '" + selectedStreet + "') ORDER BY Street";
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand(q, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    StreetID = Convert.ToInt32(reader["StreetID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
            panStreet.Visible = false;
            panAddress.Visible = true;
            lblTitle.Text = "House Number";
        }
        void AddressAutoComplete()
        {
            AutoCompleteStringCollection address = new AutoCompleteStringCollection();
            OleDbConnection conn = new OleDbConnection(connString);
            try
            {
                String q = "SELECT tAddress.Address FROM tAddress " +
                    "INNER JOIN(tStreet INNER JOIN tStreetAddress ON tStreet.StreetID = tStreetAddress.StreetID) " +
                    "ON tAddress.AddressID = tStreetAddress.AddressID WHERE(((tStreet.StreetID) = '" + StreetID + "'));";
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand(q, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string aName = (reader.GetInt32(0)).ToString();
                    address.Add(aName);
                }
                tbStreetSearch.AutoCompleteCustomSource = address;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connect to Database");
            }
            finally
            {
                conn.Close();
            }
        }

        private void tbAddressSearch_TextChanged(object sender, EventArgs e)
        {
            //AddressAutoComplete();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("A");
            } else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("A");
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("B");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("B");
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("C");
            }
            else
            {
                tbStreetSearch.Focus();
                SendKeys.Send("C");
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("D");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("D");
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("E");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("E");
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("F");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("F");
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("G");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("G");
            }
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("H");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("H");
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("I");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("I");
            }
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("J");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("J");
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("K");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("K");
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("L");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("L");
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("M");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("M");
            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("N");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("N");
            }
        }

        private void bntO_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("O");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("O");
            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("P");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("P");
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("Q");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("Q");
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("R");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("R");
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("S");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("S");
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("T");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("T");
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("U");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("U");
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("V");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("V");
            }
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("W");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("W");
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("X");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("X");
            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("Y");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("Y");
            }
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            if (panCity.Visible == true)
            {
                tbCitySearch.Focus();
                SendKeys.Send("Z");
            }
            else if (panStreet.Visible == true)
            {
                tbStreetSearch.Focus();
                SendKeys.Send("Z");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (panState.Visible == true)
            {
                btnBack.Enabled = false;
            } else if (panContainer.Visible == true && panCity.Visible == true)
            {
                tbCitySearch.Clear();
                panContainer.Visible = false;
                panState.Visible = true;
                lblTitle.Text = "State/Province";
            } else if (panContainer.Visible == true && panStreet.Visible == true)
            {
                tbStreetSearch.Clear();
                panStreet.Visible = false;
                panCity.Visible = true;
                lblTitle.Text = "City Name";
            } else if (panContainer.Visible == true && panAddress.Visible == true)
            {
                tbAddressSearch.Clear();
                panAddress.Visible = false;
                panStreet.Visible = true;
                lblTitle.Text = "Street Name";
            } else if (panMap.Visible == true)
            {
                panMap.Visible = false;
                panContainer.Visible = true;
                panAddress.Visible = true;
                lblTitle.Text = "House Number";
            }

        }
        private void btnAddressSubmit_Click(object sender, EventArgs e)
        {
            selectedAddress = tbAddressSearch.Text.ToString();
            search = selectedAddress + " " + selectedStreet + ", " + selectedCity + " " + selectedState;
            panContainer.Visible = false;
            panMap.Visible = true;
            wbMap.Navigate("https://www.google.com/maps/place/" + search);
            lblTitle.Text = "Confirm Destination";
        }

        
    }
}

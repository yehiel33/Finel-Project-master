using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //Access

namespace Finel_Project
{
    public partial class Seating : Form
    {
        public Seating()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //חזרה לחלון הראשי
            this.Hide();
            EventSeatingManager eventseatingmanager = new EventSeatingManager();
            eventseatingmanager.ShowDialog();
        }

        

        private void Seating_Load(object sender, EventArgs e)
        {
           

        }

        private void btnLoadGestList_Click(object sender, EventArgs e)
        {
            // הגדרת מחרוזת שמכילה את פקודת החיבור
            string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";
            // יצירת חיבור חדש לבסיס הנתונים
            OleDbConnection conn = new OleDbConnection(strDb);
            OleDbCommand cmd = new OleDbCommand("Select * From GUEST_LIST where [Event Owner]='" + EventSeatingManager.globalusername + "';", conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader(); // הגדרת אובייקט קריאה
                while (reader.Read())
                {
                    string fullguestname = reader["Guest First Name"].ToString() +" "+ reader["Guest Last Name"].ToString();
                    cmbGuestList.Items.Add(fullguestname);
                }
                reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //תוספת אפשרית למבנה טריי וקאצ' מגדירה מה יקרה בכל מקרה
            {
                conn.Close();
            }

            
        }
    }
}

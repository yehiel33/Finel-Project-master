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
            try
            {
                string strDb = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Public\Finel Project\Finel Project.accdb;" + "Persist Security Info=False";// הגדרת מחרוזת שמכילה את פקודת החיבור
                OleDbConnection conn = new OleDbConnection(strDb);// יצירת חיבור חדש לבסיס הנתונים
                conn.Open();//פתיחת החיבור
                OleDbDataReader dr;//משתנה שיכיל את המידע הנשלף
                OleDbCommand cmd = new OleDbCommand("Select [Guest First Name],[Guest Last Name] From GUEST_LIST where [Event Owner]=" + EventSeatingManager.globalusername);
                dr = cmd.ExecuteReader(); // pointer
                cmbGuestList.Items.Clear();
                string namelist;

                while (dr.Read())
                {
                    namelist = dr["namelist"].ToString();
                    cmbGuestList.Items.Add(namelist);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /* try
             {
                 string strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=college.accdb;" + "Persist Security Info=False";
                 OleDbConnection conn = new OleDbConnection(strDb);
                 conn.Open();
                 OleDbDataReader dr;
                 OleDbCommand cmd = new OleDbCommand("Select nameAcademic from Academics;", conn); //command sql
                 dr = cmd.ExecuteReader(); // pointer 
                 cmbAcademics.Items.Clear();
                 string nameAcademic;

                 // read rows 
                 while (dr.Read())
                 {
                     nameAcademic = dr["nameAcademic"].ToString();
                     cmbAcademics.Items.Add(nameAcademic);
                 }
                 dr.Close();
                 conn.Close();

             }
             catch (Exception err)
             {
                 MessageBox.Show(err.Message, "College", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             */
        }
    }
}

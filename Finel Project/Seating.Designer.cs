namespace Finel_Project
{
    partial class Seating
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSeating = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTable = new System.Windows.Forms.Label();
            this.cmbGuestList = new System.Windows.Forms.ComboBox();
            this.btnLoadGestList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeating
            // 
            this.lblSeating.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblSeating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSeating.ForeColor = System.Drawing.Color.White;
            this.lblSeating.Location = new System.Drawing.Point(12, 9);
            this.lblSeating.Name = "lblSeating";
            this.lblSeating.Size = new System.Drawing.Size(441, 57);
            this.lblSeating.TabIndex = 34;
            this.lblSeating.Text = "Seating";
            this.lblSeating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.Location = new System.Drawing.Point(352, 359);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 57);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTable
            // 
            this.lblTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTable.Location = new System.Drawing.Point(293, 106);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(160, 145);
            this.lblTable.TabIndex = 52;
            // 
            // cmbGuestList
            // 
            this.cmbGuestList.FormattingEnabled = true;
            this.cmbGuestList.Location = new System.Drawing.Point(57, 204);
            this.cmbGuestList.Name = "cmbGuestList";
            this.cmbGuestList.Size = new System.Drawing.Size(121, 24);
            this.cmbGuestList.TabIndex = 53;
            // 
            // btnLoadGestList
            // 
            this.btnLoadGestList.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLoadGestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLoadGestList.Location = new System.Drawing.Point(40, 262);
            this.btnLoadGestList.Name = "btnLoadGestList";
            this.btnLoadGestList.Size = new System.Drawing.Size(159, 57);
            this.btnLoadGestList.TabIndex = 54;
            this.btnLoadGestList.Text = "Load Gest List";
            this.btnLoadGestList.UseVisualStyleBackColor = false;
            this.btnLoadGestList.Click += new System.EventHandler(this.btnLoadGestList_Click);
            // 
            // Seating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 555);
            this.Controls.Add(this.btnLoadGestList);
            this.Controls.Add(this.cmbGuestList);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSeating);
            this.Name = "Seating";
            this.Text = "Seating";
            this.Load += new System.EventHandler(this.Seating_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSeating;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ComboBox cmbGuestList;
        private System.Windows.Forms.Button btnLoadGestList;
    }
}
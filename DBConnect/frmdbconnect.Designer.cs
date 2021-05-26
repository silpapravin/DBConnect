
namespace DBConnect
{
    partial class frmdbconnect
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonclick = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttongetcars = new System.Windows.Forms.Button();
            this.buttoninsert = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonclick
            // 
            this.buttonclick.Location = new System.Drawing.Point(248, 12);
            this.buttonclick.Name = "buttonclick";
            this.buttonclick.Size = new System.Drawing.Size(254, 54);
            this.buttonclick.TabIndex = 0;
            this.buttonclick.Text = "CONNECT";
            this.buttonclick.UseVisualStyleBackColor = true;
            this.buttonclick.Click += new System.EventHandler(this.buttonclick_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(250, 165);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(252, 53);
            this.buttonupdate.TabIndex = 1;
            this.buttonupdate.Text = "UPDATE";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttongetcars
            // 
            this.buttongetcars.Location = new System.Drawing.Point(250, 83);
            this.buttongetcars.Name = "buttongetcars";
            this.buttongetcars.Size = new System.Drawing.Size(251, 61);
            this.buttongetcars.TabIndex = 2;
            this.buttongetcars.Text = "GETCARS";
            this.buttongetcars.UseVisualStyleBackColor = true;
            this.buttongetcars.Click += new System.EventHandler(this.buttongetcars_Click);
            // 
            // buttoninsert
            // 
            this.buttoninsert.Location = new System.Drawing.Point(248, 236);
            this.buttoninsert.Name = "buttoninsert";
            this.buttoninsert.Size = new System.Drawing.Size(254, 53);
            this.buttoninsert.TabIndex = 3;
            this.buttoninsert.Text = "INSERT";
            this.buttoninsert.UseVisualStyleBackColor = true;
            this.buttoninsert.Click += new System.EventHandler(this.buttoninsert_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(246, 313);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(255, 53);
            this.buttondelete.TabIndex = 4;
            this.buttondelete.Text = "DELETE";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // frmdbconnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttoninsert);
            this.Controls.Add(this.buttongetcars);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttonclick);
            this.Name = "frmdbconnect";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmconnect_frmclosing);
            this.Load += new System.EventHandler(this.frmdbconnect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonclick;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttongetcars;
        private System.Windows.Forms.Button buttoninsert;
        private System.Windows.Forms.Button buttondelete;
    }
}


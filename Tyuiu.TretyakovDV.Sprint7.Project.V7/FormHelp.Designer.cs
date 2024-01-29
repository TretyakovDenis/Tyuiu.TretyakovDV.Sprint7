
namespace Tyuiu.TretyakovDV.Sprint7.Project.V7
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.textBoxInfo_TDV = new System.Windows.Forms.TextBox();
            this.textBoxInfo2_TDV = new System.Windows.Forms.TextBox();
            this.pictureBox_TDV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TDV)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInfo_TDV
            // 
            this.textBoxInfo_TDV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxInfo_TDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_TDV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo_TDV.Location = new System.Drawing.Point(12, 12);
            this.textBoxInfo_TDV.Multiline = true;
            this.textBoxInfo_TDV.Name = "textBoxInfo_TDV";
            this.textBoxInfo_TDV.ReadOnly = true;
            this.textBoxInfo_TDV.Size = new System.Drawing.Size(424, 354);
            this.textBoxInfo_TDV.TabIndex = 1;
            this.textBoxInfo_TDV.TabStop = false;
            this.textBoxInfo_TDV.Text = resources.GetString("textBoxInfo_TDV.Text");
            // 
            // textBoxInfo2_TDV
            // 
            this.textBoxInfo2_TDV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxInfo2_TDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo2_TDV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo2_TDV.Location = new System.Drawing.Point(108, 411);
            this.textBoxInfo2_TDV.Multiline = true;
            this.textBoxInfo2_TDV.Name = "textBoxInfo2_TDV";
            this.textBoxInfo2_TDV.ReadOnly = true;
            this.textBoxInfo2_TDV.Size = new System.Drawing.Size(328, 136);
            this.textBoxInfo2_TDV.TabIndex = 2;
            this.textBoxInfo2_TDV.TabStop = false;
            this.textBoxInfo2_TDV.Text = resources.GetString("textBoxInfo2_TDV.Text");
            // 
            // pictureBox_TDV
            // 
            this.pictureBox_TDV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_TDV.Image")));
            this.pictureBox_TDV.Location = new System.Drawing.Point(12, 411);
            this.pictureBox_TDV.Name = "pictureBox_TDV";
            this.pictureBox_TDV.Size = new System.Drawing.Size(90, 140);
            this.pictureBox_TDV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TDV.TabIndex = 3;
            this.pictureBox_TDV.TabStop = false;
            // 
            // FormHelp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(448, 563);
            this.Controls.Add(this.pictureBox_TDV);
            this.Controls.Add(this.textBoxInfo2_TDV);
            this.Controls.Add(this.textBoxInfo_TDV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHelp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfo_TDV;
        private System.Windows.Forms.TextBox textBoxInfo2_TDV;
        private System.Windows.Forms.PictureBox pictureBox_TDV;
    }
}
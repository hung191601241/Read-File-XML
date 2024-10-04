namespace ReadFileXML
{
    partial class ReDo
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Btn_ReadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(549, 502);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_ReadFile
            // 
            this.Btn_ReadFile.Location = new System.Drawing.Point(12, 520);
            this.Btn_ReadFile.Name = "Btn_ReadFile";
            this.Btn_ReadFile.Size = new System.Drawing.Size(75, 23);
            this.Btn_ReadFile.TabIndex = 1;
            this.Btn_ReadFile.Text = "Read File";
            this.Btn_ReadFile.UseVisualStyleBackColor = true;
            this.Btn_ReadFile.Click += new System.EventHandler(this.Btn_ReadFile_Click);
            // 
            // ReDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 555);
            this.Controls.Add(this.Btn_ReadFile);
            this.Controls.Add(this.listView1);
            this.Name = "ReDo";
            this.Text = "ReDo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Btn_ReadFile;
    }
}
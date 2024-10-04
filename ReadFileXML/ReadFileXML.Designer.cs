namespace ReadFileXML
{
    partial class ReadFileXML
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
            this.ListView_XML = new System.Windows.Forms.ListView();
            this.Btn_ReadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListView_XML
            // 
            this.ListView_XML.HideSelection = false;
            this.ListView_XML.Location = new System.Drawing.Point(12, 12);
            this.ListView_XML.Name = "ListView_XML";
            this.ListView_XML.Size = new System.Drawing.Size(810, 631);
            this.ListView_XML.TabIndex = 0;
            this.ListView_XML.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_ReadFile
            // 
            this.Btn_ReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ReadFile.Location = new System.Drawing.Point(12, 649);
            this.Btn_ReadFile.Name = "Btn_ReadFile";
            this.Btn_ReadFile.Size = new System.Drawing.Size(98, 27);
            this.Btn_ReadFile.TabIndex = 1;
            this.Btn_ReadFile.Text = "Read File";
            this.Btn_ReadFile.UseVisualStyleBackColor = true;
            this.Btn_ReadFile.Click += new System.EventHandler(this.Btn_ReadFile_Click);
            // 
            // ReadFileXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 686);
            this.Controls.Add(this.Btn_ReadFile);
            this.Controls.Add(this.ListView_XML);
            this.Name = "ReadFileXML";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListView_XML;
        private System.Windows.Forms.Button Btn_ReadFile;
    }
}


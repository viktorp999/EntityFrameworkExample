namespace EntityFrameworkExample
{
    partial class Main
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
            this.ReadL = new System.Windows.Forms.Label();
            this.SaveL = new System.Windows.Forms.Label();
            this.ReadB = new System.Windows.Forms.Button();
            this.SaveB = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.ListBox();
            this.ClearB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadL
            // 
            this.ReadL.AutoSize = true;
            this.ReadL.Location = new System.Drawing.Point(377, 12);
            this.ReadL.Name = "ReadL";
            this.ReadL.Size = new System.Drawing.Size(335, 13);
            this.ReadL.TabIndex = 1;
            this.ReadL.Text = "Read people older than 18 and younger than 50 years from database.";
            // 
            // SaveL
            // 
            this.SaveL.AutoSize = true;
            this.SaveL.Location = new System.Drawing.Point(377, 120);
            this.SaveL.Name = "SaveL";
            this.SaveL.Size = new System.Drawing.Size(135, 13);
            this.SaveL.TabIndex = 2;
            this.SaveL.Text = "Save this people to xml file.";
            // 
            // ReadB
            // 
            this.ReadB.Location = new System.Drawing.Point(380, 28);
            this.ReadB.Name = "ReadB";
            this.ReadB.Size = new System.Drawing.Size(75, 23);
            this.ReadB.TabIndex = 3;
            this.ReadB.Text = "Read";
            this.ReadB.UseVisualStyleBackColor = true;
            this.ReadB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReadPeople);
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(380, 136);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(75, 23);
            this.SaveB.TabIndex = 4;
            this.SaveB.Text = "Save";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SavePeople);
            // 
            // Output
            // 
            this.Output.FormattingEnabled = true;
            this.Output.Location = new System.Drawing.Point(12, 12);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(359, 420);
            this.Output.TabIndex = 5;
            // 
            // ClearB
            // 
            this.ClearB.Location = new System.Drawing.Point(380, 259);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(75, 23);
            this.ClearB.TabIndex = 6;
            this.ClearB.Text = "Clear List";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clear);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.ReadB);
            this.Controls.Add(this.SaveL);
            this.Controls.Add(this.ReadL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ReadL;
        private System.Windows.Forms.Label SaveL;
        private System.Windows.Forms.Button ReadB;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.ListBox Output;
        private System.Windows.Forms.Button ClearB;
    }
}


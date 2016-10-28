namespace SomeOldApplication
{
    partial class Form1
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
            this.buttonCreateCsv = new System.Windows.Forms.Button();
            this.buttonMailCsv = new System.Windows.Forms.Button();
            this.buttonScript = new System.Windows.Forms.Button();
            this.buttonScript2 = new System.Windows.Forms.Button();
            this.buttonScript3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateCsv
            // 
            this.buttonCreateCsv.Location = new System.Drawing.Point(78, 59);
            this.buttonCreateCsv.Name = "buttonCreateCsv";
            this.buttonCreateCsv.Size = new System.Drawing.Size(138, 55);
            this.buttonCreateCsv.TabIndex = 0;
            this.buttonCreateCsv.Text = "Create a CSV";
            this.buttonCreateCsv.UseVisualStyleBackColor = true;
            this.buttonCreateCsv.Click += new System.EventHandler(this.buttonCreateCsv_Click);
            // 
            // buttonMailCsv
            // 
            this.buttonMailCsv.Location = new System.Drawing.Point(251, 59);
            this.buttonMailCsv.Name = "buttonMailCsv";
            this.buttonMailCsv.Size = new System.Drawing.Size(138, 55);
            this.buttonMailCsv.TabIndex = 1;
            this.buttonMailCsv.Text = "Mail CSV link";
            this.buttonMailCsv.UseVisualStyleBackColor = true;
            this.buttonMailCsv.Click += new System.EventHandler(this.buttonMailCsv_Click);
            // 
            // buttonScript
            // 
            this.buttonScript.Location = new System.Drawing.Point(132, 176);
            this.buttonScript.Name = "buttonScript";
            this.buttonScript.Size = new System.Drawing.Size(138, 55);
            this.buttonScript.TabIndex = 2;
            this.buttonScript.Text = "The scripting treatment";
            this.buttonScript.UseVisualStyleBackColor = true;
            this.buttonScript.Click += new System.EventHandler(this.buttonScript_Click);
            // 
            // buttonScript2
            // 
            this.buttonScript2.Location = new System.Drawing.Point(303, 176);
            this.buttonScript2.Name = "buttonScript2";
            this.buttonScript2.Size = new System.Drawing.Size(138, 55);
            this.buttonScript2.TabIndex = 3;
            this.buttonScript2.Text = "The scripting treatment 2";
            this.buttonScript2.UseVisualStyleBackColor = true;
            this.buttonScript2.Click += new System.EventHandler(this.buttonScript2_Click);
            // 
            // buttonScript3
            // 
            this.buttonScript3.Location = new System.Drawing.Point(466, 176);
            this.buttonScript3.Name = "buttonScript3";
            this.buttonScript3.Size = new System.Drawing.Size(138, 55);
            this.buttonScript3.TabIndex = 4;
            this.buttonScript3.Text = "The scripting treatment 3";
            this.buttonScript3.UseVisualStyleBackColor = true;
            this.buttonScript3.Click += new System.EventHandler(this.buttonScript3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 346);
            this.Controls.Add(this.buttonScript3);
            this.Controls.Add(this.buttonScript2);
            this.Controls.Add(this.buttonScript);
            this.Controls.Add(this.buttonMailCsv);
            this.Controls.Add(this.buttonCreateCsv);
            this.Name = "Form1";
            this.Text = "It just works (tm)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateCsv;
        private System.Windows.Forms.Button buttonMailCsv;
        private System.Windows.Forms.Button buttonScript;
        private System.Windows.Forms.Button buttonScript2;
        private System.Windows.Forms.Button buttonScript3;
    }
}


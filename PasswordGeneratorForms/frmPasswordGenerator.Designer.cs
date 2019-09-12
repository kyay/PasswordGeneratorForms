namespace PasswordGeneratorForms
{
    partial class frmPasswordGenerator
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
            this.components = new System.ComponentModel.Container();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.tipMain = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(108, 85);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(266, 53);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate a new password for me please because I\'m a lazy slacker";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(103, 145);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(271, 68);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tipMain.SetToolTip(this.lblPassword, "Click the Password to copy it over to your clipboard");
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.Font = new System.Drawing.Font("Curlz MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.Green;
            this.lblGreeting.Location = new System.Drawing.Point(12, 9);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(445, 64);
            this.lblGreeting.TabIndex = 2;
            this.lblGreeting.Text = "Welcome to the Slacker-Help-inator 2000 for all your Password Generation needs";
            this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 87);
            this.label1.TabIndex = 3;
            this.label1.Text = "Protip: hover over the password for a cool surprise";
            // 
            // frmPasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnGenerate);
            this.Name = "frmPasswordGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.ToolTip tipMain;
        private System.Windows.Forms.Label label1;
    }
}


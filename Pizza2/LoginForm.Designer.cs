namespace Pizza2
{
    partial class LoginForm
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
            this.txtUtilisateur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoginOK = new System.Windows.Forms.Button();
            this.btnLoginAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Location = new System.Drawing.Point(121, 42);
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(100, 20);
            this.txtUtilisateur.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utilisateur";
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(121, 84);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.PasswordChar = '*';
            this.txtMDP.Size = new System.Drawing.Size(100, 20);
            this.txtMDP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // btnLoginOK
            // 
            this.btnLoginOK.Location = new System.Drawing.Point(47, 134);
            this.btnLoginOK.Name = "btnLoginOK";
            this.btnLoginOK.Size = new System.Drawing.Size(75, 23);
            this.btnLoginOK.TabIndex = 2;
            this.btnLoginOK.Text = "OK";
            this.btnLoginOK.UseVisualStyleBackColor = true;
            this.btnLoginOK.Click += new System.EventHandler(this.btnLoginOK_Click);
            // 
            // btnLoginAnnuler
            // 
            this.btnLoginAnnuler.Location = new System.Drawing.Point(146, 134);
            this.btnLoginAnnuler.Name = "btnLoginAnnuler";
            this.btnLoginAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnLoginAnnuler.TabIndex = 3;
            this.btnLoginAnnuler.Text = "Annuler";
            this.btnLoginAnnuler.UseVisualStyleBackColor = true;
            this.btnLoginAnnuler.Click += new System.EventHandler(this.btnLoginAnnuler_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 192);
            this.Controls.Add(this.btnLoginAnnuler);
            this.Controls.Add(this.btnLoginOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtUtilisateur);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoginOK;
        private System.Windows.Forms.Button btnLoginAnnuler;
    }
}
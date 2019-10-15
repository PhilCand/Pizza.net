namespace Pizza2
{
    partial class NewBoissonForm
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
            this.txtNomBoisson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrixBoisson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreerBoisson = new System.Windows.Forms.Button();
            this.listBoxListeBoissonsNew = new System.Windows.Forms.ListBox();
            this.btnSupprimerBoisson = new System.Windows.Forms.Button();
            this.btnRetourBoisson = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomBoisson
            // 
            this.txtNomBoisson.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtNomBoisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomBoisson.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtNomBoisson.Location = new System.Drawing.Point(92, 68);
            this.txtNomBoisson.Name = "txtNomBoisson";
            this.txtNomBoisson.Size = new System.Drawing.Size(100, 20);
            this.txtNomBoisson.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom boisson";
            // 
            // txtPrixBoisson
            // 
            this.txtPrixBoisson.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtPrixBoisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixBoisson.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtPrixBoisson.Location = new System.Drawing.Point(92, 94);
            this.txtPrixBoisson.Name = "txtPrixBoisson";
            this.txtPrixBoisson.Size = new System.Drawing.Size(100, 20);
            this.txtPrixBoisson.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(62, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix";
            // 
            // btnCreerBoisson
            // 
            this.btnCreerBoisson.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCreerBoisson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreerBoisson.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCreerBoisson.Location = new System.Drawing.Point(92, 120);
            this.btnCreerBoisson.Name = "btnCreerBoisson";
            this.btnCreerBoisson.Size = new System.Drawing.Size(100, 23);
            this.btnCreerBoisson.TabIndex = 2;
            this.btnCreerBoisson.Text = "Creer boisson";
            this.btnCreerBoisson.UseVisualStyleBackColor = false;
            this.btnCreerBoisson.Click += new System.EventHandler(this.btnCreerBoisson_Click);
            // 
            // listBoxListeBoissonsNew
            // 
            this.listBoxListeBoissonsNew.BackColor = System.Drawing.Color.PapayaWhip;
            this.listBoxListeBoissonsNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxListeBoissonsNew.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxListeBoissonsNew.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBoxListeBoissonsNew.FormattingEnabled = true;
            this.listBoxListeBoissonsNew.Location = new System.Drawing.Point(223, 47);
            this.listBoxListeBoissonsNew.Name = "listBoxListeBoissonsNew";
            this.listBoxListeBoissonsNew.Size = new System.Drawing.Size(120, 195);
            this.listBoxListeBoissonsNew.TabIndex = 3;
            this.listBoxListeBoissonsNew.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxListeBoissonsNew_DrawItem);
            // 
            // btnSupprimerBoisson
            // 
            this.btnSupprimerBoisson.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSupprimerBoisson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerBoisson.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSupprimerBoisson.Location = new System.Drawing.Point(223, 252);
            this.btnSupprimerBoisson.Name = "btnSupprimerBoisson";
            this.btnSupprimerBoisson.Size = new System.Drawing.Size(120, 23);
            this.btnSupprimerBoisson.TabIndex = 3;
            this.btnSupprimerBoisson.Text = "Supprimer";
            this.btnSupprimerBoisson.UseVisualStyleBackColor = false;
            this.btnSupprimerBoisson.Click += new System.EventHandler(this.btnSupprimerBoisson_Click);
            // 
            // btnRetourBoisson
            // 
            this.btnRetourBoisson.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRetourBoisson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetourBoisson.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRetourBoisson.Location = new System.Drawing.Point(268, 303);
            this.btnRetourBoisson.Name = "btnRetourBoisson";
            this.btnRetourBoisson.Size = new System.Drawing.Size(75, 23);
            this.btnRetourBoisson.TabIndex = 4;
            this.btnRetourBoisson.Text = "Retour";
            this.btnRetourBoisson.UseVisualStyleBackColor = false;
            this.btnRetourBoisson.Click += new System.EventHandler(this.btnRetourBoisson_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(18, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menu edition boissons";
            // 
            // label4
            // 
            this.label4.Image = global::Pizza2.Properties.Resources.boisson;
            this.label4.Location = new System.Drawing.Point(43, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 153);
            this.label4.TabIndex = 6;
            // 
            // NewBoissonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 358);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxListeBoissonsNew);
            this.Controls.Add(this.btnRetourBoisson);
            this.Controls.Add(this.btnSupprimerBoisson);
            this.Controls.Add(this.btnCreerBoisson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrixBoisson);
            this.Controls.Add(this.txtNomBoisson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewBoissonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion des boissons";
            this.Load += new System.EventHandler(this.NewBoissonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomBoisson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrixBoisson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreerBoisson;
        private System.Windows.Forms.ListBox listBoxListeBoissonsNew;
        private System.Windows.Forms.Button btnSupprimerBoisson;
        private System.Windows.Forms.Button btnRetourBoisson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
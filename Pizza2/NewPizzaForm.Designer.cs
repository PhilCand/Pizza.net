using System.Windows.Forms;

namespace Pizza2
{
    partial class NewPizzaForm
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
            this.btnCreerPizza = new System.Windows.Forms.Button();
            this.txtNomPizza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrixPizza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAjouterIngredient = new System.Windows.Forms.Button();
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.listBoxListePizza = new System.Windows.Forms.ListBox();
            this.btnSuppPizza = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreerPizza
            // 
            this.btnCreerPizza.BackColor = System.Drawing.Color.PeachPuff;
            this.btnCreerPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreerPizza.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCreerPizza.Location = new System.Drawing.Point(257, 233);
            this.btnCreerPizza.Name = "btnCreerPizza";
            this.btnCreerPizza.Size = new System.Drawing.Size(131, 23);
            this.btnCreerPizza.TabIndex = 4;
            this.btnCreerPizza.Text = "Creer pizza";
            this.btnCreerPizza.UseVisualStyleBackColor = false;
            this.btnCreerPizza.Click += new System.EventHandler(this.btnCreerPizza_Click);
            // 
            // txtNomPizza
            // 
            this.txtNomPizza.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtNomPizza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomPizza.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtNomPizza.Location = new System.Drawing.Point(69, 41);
            this.txtNomPizza.Name = "txtNomPizza";
            this.txtNomPizza.Size = new System.Drawing.Size(140, 20);
            this.txtNomPizza.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // txtPrixPizza
            // 
            this.txtPrixPizza.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtPrixPizza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrixPizza.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtPrixPizza.Location = new System.Drawing.Point(69, 67);
            this.txtPrixPizza.Name = "txtPrixPizza";
            this.txtPrixPizza.Size = new System.Drawing.Size(57, 20);
            this.txtPrixPizza.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(39, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prix";
            // 
            // txtIngredient
            // 
            this.txtIngredient.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtIngredient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngredient.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtIngredient.Location = new System.Drawing.Point(69, 121);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(140, 20);
            this.txtIngredient.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(9, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingredient";
            // 
            // btnAjouterIngredient
            // 
            this.btnAjouterIngredient.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAjouterIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterIngredient.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAjouterIngredient.Location = new System.Drawing.Point(109, 147);
            this.btnAjouterIngredient.Name = "btnAjouterIngredient";
            this.btnAjouterIngredient.Size = new System.Drawing.Size(100, 23);
            this.btnAjouterIngredient.TabIndex = 3;
            this.btnAjouterIngredient.Text = "Ajouter ingredient";
            this.btnAjouterIngredient.UseVisualStyleBackColor = false;
            this.btnAjouterIngredient.Click += new System.EventHandler(this.btnAjouterIngredient_Click);
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.BackColor = System.Drawing.Color.PapayaWhip;
            this.listBoxIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxIngredients.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxIngredients.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.Location = new System.Drawing.Point(257, 41);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(131, 182);
            this.listBoxIngredients.TabIndex = 8;
            this.listBoxIngredients.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlSaisiCde_DrawItem);
            // 
            // listBoxListePizza
            // 
            this.listBoxListePizza.BackColor = System.Drawing.Color.PapayaWhip;
            this.listBoxListePizza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxListePizza.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxListePizza.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBoxListePizza.FormattingEnabled = true;
            this.listBoxListePizza.Location = new System.Drawing.Point(505, 72);
            this.listBoxListePizza.Name = "listBoxListePizza";
            this.listBoxListePizza.Size = new System.Drawing.Size(131, 182);
            this.listBoxListePizza.TabIndex = 6;
            this.listBoxListePizza.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlSaisiCde_DrawItem);
            // 
            // btnSuppPizza
            // 
            this.btnSuppPizza.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSuppPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppPizza.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSuppPizza.Location = new System.Drawing.Point(504, 264);
            this.btnSuppPizza.Name = "btnSuppPizza";
            this.btnSuppPizza.Size = new System.Drawing.Size(131, 23);
            this.btnSuppPizza.TabIndex = 7;
            this.btnSuppPizza.Text = "Supprimer pizza";
            this.btnSuppPizza.UseVisualStyleBackColor = false;
            this.btnSuppPizza.Click += new System.EventHandler(this.btnSuppPizza_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(257, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Liste ingredients";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(505, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Liste pizzas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listBoxIngredients);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIngredient);
            this.groupBox1.Controls.Add(this.txtPrixPizza);
            this.groupBox1.Controls.Add(this.txtNomPizza);
            this.groupBox1.Controls.Add(this.btnAjouterIngredient);
            this.groupBox1.Controls.Add(this.btnCreerPizza);
            this.groupBox1.Location = new System.Drawing.Point(32, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 313);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Image = global::Pizza2.Properties.Resources.pizza;
            this.label7.Location = new System.Drawing.Point(34, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 128);
            this.label7.TabIndex = 9;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.PeachPuff;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRetour.Location = new System.Drawing.Point(560, 321);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(32, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Menu edition pizzas";
            // 
            // NewPizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 368);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxListePizza);
            this.Controls.Add(this.btnSuppPizza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewPizzaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Getion des pizzas";
            this.Load += new System.EventHandler(this.NewPizzaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreerPizza;
        private System.Windows.Forms.TextBox txtNomPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrixPizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAjouterIngredient;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private System.Windows.Forms.ListBox listBoxListePizza;
        private System.Windows.Forms.Button btnSuppPizza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRetour;
        private Label label4;
        private Label label7;
    }
}
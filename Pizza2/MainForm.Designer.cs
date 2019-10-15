namespace Pizza2
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlSaisiCde = new System.Windows.Forms.TabControl();
            this.tabPageSaisirCde = new System.Windows.Forms.TabPage();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnValiderCommande = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtPrenomClient = new System.Windows.Forms.TextBox();
            this.txtAdresse2 = new System.Windows.Forms.TextBox();
            this.txtAdresse1 = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalCdeEnCours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSupprEnCours = new System.Windows.Forms.Button();
            this.listBoxRecapCommande = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNouvelleBoisson = new System.Windows.Forms.Button();
            this.listBoxBoisson = new System.Windows.Forms.ListBox();
            this.btnAjouterBoisson = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAjouterPizza = new System.Windows.Forms.Button();
            this.checkBoxSupOeuf = new System.Windows.Forms.CheckBox();
            this.checkBoxSupAnchois = new System.Windows.Forms.CheckBox();
            this.checkBoxSupOlives = new System.Windows.Forms.CheckBox();
            this.checkBoxSupCapres = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNouvelleRecette = new System.Windows.Forms.Button();
            this.btnDetailPizza = new System.Windows.Forms.Button();
            this.listBoxPizza = new System.Windows.Forms.ListBox();
            this.tabPageHistoCommande = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.buttonSuppCde = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtHistoPrix = new System.Windows.Forms.TextBox();
            this.listBoxHistoContenuCde = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtHistoTel = new System.Windows.Forms.TextBox();
            this.txtHistoVille = new System.Windows.Forms.TextBox();
            this.txtHistoPrenom = new System.Windows.Forms.TextBox();
            this.txtHistoAdresse2 = new System.Windows.Forms.TextBox();
            this.txtHistoAdresse1 = new System.Windows.Forms.TextBox();
            this.txtHistoCP = new System.Windows.Forms.TextBox();
            this.txtHistoNom = new System.Windows.Forms.TextBox();
            this.listBoxHistoCdes = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlSaisiCde.SuspendLayout();
            this.tabPageSaisirCde.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageHistoCommande.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSaisiCde
            // 
            this.tabControlSaisiCde.Controls.Add(this.tabPageSaisirCde);
            this.tabControlSaisiCde.Controls.Add(this.tabPageHistoCommande);
            this.tabControlSaisiCde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSaisiCde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSaisiCde.Location = new System.Drawing.Point(0, 24);
            this.tabControlSaisiCde.Name = "tabControlSaisiCde";
            this.tabControlSaisiCde.SelectedIndex = 0;
            this.tabControlSaisiCde.Size = new System.Drawing.Size(1060, 712);
            this.tabControlSaisiCde.TabIndex = 20;
            this.tabControlSaisiCde.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlSaisiCde_DrawItem);
            // 
            // tabPageSaisirCde
            // 
            this.tabPageSaisirCde.BackColor = System.Drawing.Color.White;
            this.tabPageSaisirCde.Controls.Add(this.btnQuitter);
            this.tabPageSaisirCde.Controls.Add(this.btnValiderCommande);
            this.tabPageSaisirCde.Controls.Add(this.groupBox4);
            this.tabPageSaisirCde.Controls.Add(this.groupBox3);
            this.tabPageSaisirCde.Controls.Add(this.groupBox2);
            this.tabPageSaisirCde.Controls.Add(this.groupBox1);
            this.tabPageSaisirCde.Location = new System.Drawing.Point(4, 24);
            this.tabPageSaisirCde.Name = "tabPageSaisirCde";
            this.tabPageSaisirCde.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSaisirCde.Size = new System.Drawing.Size(1052, 684);
            this.tabPageSaisirCde.TabIndex = 0;
            this.tabPageSaisirCde.Text = "Saisir commande";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.PeachPuff;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(866, 505);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(162, 43);
            this.btnQuitter.TabIndex = 28;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnValiderCommande
            // 
            this.btnValiderCommande.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValiderCommande.BackColor = System.Drawing.Color.PeachPuff;
            this.btnValiderCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderCommande.Location = new System.Drawing.Point(866, 559);
            this.btnValiderCommande.Name = "btnValiderCommande";
            this.btnValiderCommande.Size = new System.Drawing.Size(163, 103);
            this.btnValiderCommande.TabIndex = 27;
            this.btnValiderCommande.Text = "  Valider    commande";
            this.btnValiderCommande.UseVisualStyleBackColor = false;
            this.btnValiderCommande.Click += new System.EventHandler(this.btnValiderCommande_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtTel);
            this.groupBox4.Controls.Add(this.txtVille);
            this.groupBox4.Controls.Add(this.txtPrenomClient);
            this.groupBox4.Controls.Add(this.txtAdresse2);
            this.groupBox4.Controls.Add(this.txtAdresse1);
            this.groupBox4.Controls.Add(this.txtCP);
            this.groupBox4.Controls.Add(this.txtNomClient);
            this.groupBox4.Location = new System.Drawing.Point(451, 416);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 247);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(19, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Infos client";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Telephone";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Ville";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Prenom";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Adresse 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Adresse 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "CP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nom";
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtTel.Location = new System.Drawing.Point(87, 215);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 26;
            // 
            // txtVille
            // 
            this.txtVille.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtVille.Location = new System.Drawing.Point(87, 186);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 25;
            // 
            // txtPrenomClient
            // 
            this.txtPrenomClient.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtPrenomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomClient.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtPrenomClient.Location = new System.Drawing.Point(88, 69);
            this.txtPrenomClient.Name = "txtPrenomClient";
            this.txtPrenomClient.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomClient.TabIndex = 21;
            // 
            // txtAdresse2
            // 
            this.txtAdresse2.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtAdresse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtAdresse2.Location = new System.Drawing.Point(88, 129);
            this.txtAdresse2.Name = "txtAdresse2";
            this.txtAdresse2.Size = new System.Drawing.Size(275, 20);
            this.txtAdresse2.TabIndex = 23;
            // 
            // txtAdresse1
            // 
            this.txtAdresse1.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtAdresse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtAdresse1.Location = new System.Drawing.Point(88, 99);
            this.txtAdresse1.Name = "txtAdresse1";
            this.txtAdresse1.Size = new System.Drawing.Size(275, 20);
            this.txtAdresse1.TabIndex = 22;
            // 
            // txtCP
            // 
            this.txtCP.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtCP.Location = new System.Drawing.Point(87, 158);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 20);
            this.txtCP.TabIndex = 24;
            // 
            // txtNomClient
            // 
            this.txtNomClient.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomClient.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtNomClient.Location = new System.Drawing.Point(88, 40);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(100, 20);
            this.txtNomClient.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtTotalCdeEnCours);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.buttonSupprEnCours);
            this.groupBox3.Controls.Add(this.listBoxRecapCommande);
            this.groupBox3.Location = new System.Drawing.Point(451, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 366);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(17, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Liste produits commande en cours";
            // 
            // txtTotalCdeEnCours
            // 
            this.txtTotalCdeEnCours.BackColor = System.Drawing.Color.SeaShell;
            this.txtTotalCdeEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCdeEnCours.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtTotalCdeEnCours.Location = new System.Drawing.Point(460, 329);
            this.txtTotalCdeEnCours.Name = "txtTotalCdeEnCours";
            this.txtTotalCdeEnCours.ReadOnly = true;
            this.txtTotalCdeEnCours.Size = new System.Drawing.Size(74, 20);
            this.txtTotalCdeEnCours.TabIndex = 5;
            this.txtTotalCdeEnCours.Text = "0";
            this.txtTotalCdeEnCours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total TTC";
            // 
            // buttonSupprEnCours
            // 
            this.buttonSupprEnCours.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonSupprEnCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprEnCours.Location = new System.Drawing.Point(23, 325);
            this.buttonSupprEnCours.Name = "buttonSupprEnCours";
            this.buttonSupprEnCours.Size = new System.Drawing.Size(105, 24);
            this.buttonSupprEnCours.TabIndex = 18;
            this.buttonSupprEnCours.Text = "Supprimer produit";
            this.buttonSupprEnCours.UseVisualStyleBackColor = false;
            this.buttonSupprEnCours.Click += new System.EventHandler(this.buttonSupprEnCours_Click);
            // 
            // listBoxRecapCommande
            // 
            this.listBoxRecapCommande.BackColor = System.Drawing.Color.PapayaWhip;
            this.listBoxRecapCommande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxRecapCommande.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxRecapCommande.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBoxRecapCommande.FormattingEnabled = true;
            this.listBoxRecapCommande.Location = new System.Drawing.Point(23, 29);
            this.listBoxRecapCommande.Name = "listBoxRecapCommande";
            this.listBoxRecapCommande.Size = new System.Drawing.Size(512, 286);
            this.listBoxRecapCommande.TabIndex = 17;
            this.listBoxRecapCommande.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlSaisiCde_DrawItem);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnNouvelleBoisson);
            this.groupBox2.Controls.Add(this.listBoxBoisson);
            this.groupBox2.Controls.Add(this.btnAjouterBoisson);
            this.groupBox2.Location = new System.Drawing.Point(12, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 248);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label26
            // 
            this.label26.Image = global::Pizza2.Properties.Resources.boisson;
            this.label26.Location = new System.Drawing.Point(302, 52);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 107);
            this.label26.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(19, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Choix boisson";
            // 
            // btnNouvelleBoisson
            // 
            this.btnNouvelleBoisson.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNouvelleBoisson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvelleBoisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelleBoisson.Location = new System.Drawing.Point(22, 206);
            this.btnNouvelleBoisson.Name = "btnNouvelleBoisson";
            this.btnNouvelleBoisson.Size = new System.Drawing.Size(129, 23);
            this.btnNouvelleBoisson.TabIndex = 15;
            this.btnNouvelleBoisson.Text = "Menu edition boissons";
            this.btnNouvelleBoisson.UseVisualStyleBackColor = false;
            this.btnNouvelleBoisson.Visible = false;
            this.btnNouvelleBoisson.Click += new System.EventHandler(this.btnNouvelleBoisson_Click);
            // 
            // listBoxBoisson
            // 
            this.listBoxBoisson.BackColor = System.Drawing.Color.PapayaWhip;
            this.listBoxBoisson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxBoisson.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxBoisson.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBoxBoisson.FormattingEnabled = true;
            this.listBoxBoisson.Location = new System.Drawing.Point(23, 31);
            this.listBoxBoisson.Name = "listBoxBoisson";
            this.listBoxBoisson.Size = new System.Drawing.Size(218, 169);
            this.listBoxBoisson.TabIndex = 13;
            this.listBoxBoisson.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlSaisiCde_DrawItem);
            // 
            // btnAjouterBoisson
            // 
            this.btnAjouterBoisson.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAjouterBoisson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterBoisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterBoisson.Location = new System.Drawing.Point(282, 183);
            this.btnAjouterBoisson.Name = "btnAjouterBoisson";
            this.btnAjouterBoisson.Size = new System.Drawing.Size(118, 46);
            this.btnAjouterBoisson.TabIndex = 14;
            this.btnAjouterBoisson.Text = "Ajouter boisson";
            this.btnAjouterBoisson.UseVisualStyleBackColor = false;
            this.btnAjouterBoisson.Click += new System.EventHandler(this.btnAjouterBoisson_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAjouterPizza);
            this.groupBox1.Controls.Add(this.checkBoxSupOeuf);
            this.groupBox1.Controls.Add(this.checkBoxSupAnchois);
            this.groupBox1.Controls.Add(this.checkBoxSupOlives);
            this.groupBox1.Controls.Add(this.checkBoxSupCapres);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButtonLarge);
            this.groupBox1.Controls.Add(this.radioButtonMedium);
            this.groupBox1.Controls.Add(this.radioButtonSmall);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNouvelleRecette);
            this.groupBox1.Controls.Add(this.btnDetailPizza);
            this.groupBox1.Controls.Add(this.listBoxPizza);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 366);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(18, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Choix pizza";
            // 
            // btnAjouterPizza
            // 
            this.btnAjouterPizza.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAjouterPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPizza.Location = new System.Drawing.Point(282, 302);
            this.btnAjouterPizza.Name = "btnAjouterPizza";
            this.btnAjouterPizza.Size = new System.Drawing.Size(118, 46);
            this.btnAjouterPizza.TabIndex = 9;
            this.btnAjouterPizza.Text = "Ajouter pizza";
            this.btnAjouterPizza.UseVisualStyleBackColor = false;
            this.btnAjouterPizza.Click += new System.EventHandler(this.btnAjouterPizza_Click);
            // 
            // checkBoxSupOeuf
            // 
            this.checkBoxSupOeuf.AutoSize = true;
            this.checkBoxSupOeuf.Location = new System.Drawing.Point(285, 249);
            this.checkBoxSupOeuf.Name = "checkBoxSupOeuf";
            this.checkBoxSupOeuf.Size = new System.Drawing.Size(52, 19);
            this.checkBoxSupOeuf.TabIndex = 8;
            this.checkBoxSupOeuf.Text = "Oeuf";
            this.checkBoxSupOeuf.UseVisualStyleBackColor = true;
            // 
            // checkBoxSupAnchois
            // 
            this.checkBoxSupAnchois.AutoSize = true;
            this.checkBoxSupAnchois.Location = new System.Drawing.Point(285, 226);
            this.checkBoxSupAnchois.Name = "checkBoxSupAnchois";
            this.checkBoxSupAnchois.Size = new System.Drawing.Size(69, 19);
            this.checkBoxSupAnchois.TabIndex = 7;
            this.checkBoxSupAnchois.Text = "Anchois";
            this.checkBoxSupAnchois.UseVisualStyleBackColor = true;
            // 
            // checkBoxSupOlives
            // 
            this.checkBoxSupOlives.AutoSize = true;
            this.checkBoxSupOlives.Location = new System.Drawing.Point(285, 203);
            this.checkBoxSupOlives.Name = "checkBoxSupOlives";
            this.checkBoxSupOlives.Size = new System.Drawing.Size(59, 19);
            this.checkBoxSupOlives.TabIndex = 6;
            this.checkBoxSupOlives.Text = "Olives";
            this.checkBoxSupOlives.UseVisualStyleBackColor = true;
            // 
            // checkBoxSupCapres
            // 
            this.checkBoxSupCapres.AutoSize = true;
            this.checkBoxSupCapres.Location = new System.Drawing.Point(285, 180);
            this.checkBoxSupCapres.Name = "checkBoxSupCapres";
            this.checkBoxSupCapres.Size = new System.Drawing.Size(65, 19);
            this.checkBoxSupCapres.TabIndex = 5;
            this.checkBoxSupCapres.Text = "Capres";
            this.checkBoxSupCapres.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supplements :";
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(282, 111);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(57, 19);
            this.radioButtonLarge.TabIndex = 4;
            this.radioButtonLarge.Text = "Large";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Checked = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(282, 88);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(71, 19);
            this.radioButtonMedium.TabIndex = 3;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(282, 65);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(57, 19);
            this.radioButtonSmall.TabIndex = 2;
            this.radioButtonSmall.Text = "Small";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Taille :";
            // 
            // btnNouvelleRecette
            // 
            this.btnNouvelleRecette.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNouvelleRecette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvelleRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelleRecette.Location = new System.Drawing.Point(22, 325);
            this.btnNouvelleRecette.Name = "btnNouvelleRecette";
            this.btnNouvelleRecette.Size = new System.Drawing.Size(129, 23);
            this.btnNouvelleRecette.TabIndex = 11;
            this.btnNouvelleRecette.Text = "Menu edition pizzas";
            this.btnNouvelleRecette.UseVisualStyleBackColor = false;
            this.btnNouvelleRecette.Visible = false;
            this.btnNouvelleRecette.Click += new System.EventHandler(this.btnNouvelleRecette_Click);
            // 
            // btnDetailPizza
            // 
            this.btnDetailPizza.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDetailPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailPizza.Location = new System.Drawing.Point(165, 325);
            this.btnDetailPizza.Name = "btnDetailPizza";
            this.btnDetailPizza.Size = new System.Drawing.Size(75, 23);
            this.btnDetailPizza.TabIndex = 10;
            this.btnDetailPizza.Text = "Détail";
            this.btnDetailPizza.UseVisualStyleBackColor = false;
            this.btnDetailPizza.Click += new System.EventHandler(this.btnDetailPizza_Click);
            // 
            // listBoxPizza
            // 
            this.listBoxPizza.BackColor = System.Drawing.Color.PapayaWhip;
            this.listBoxPizza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPizza.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxPizza.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listBoxPizza.FormattingEnabled = true;
            this.listBoxPizza.Location = new System.Drawing.Point(22, 29);
            this.listBoxPizza.Name = "listBoxPizza";
            this.listBoxPizza.Size = new System.Drawing.Size(218, 286);
            this.listBoxPizza.TabIndex = 0;
            this.listBoxPizza.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlSaisiCde_DrawItem);
            // 
            // tabPageHistoCommande
            // 
            this.tabPageHistoCommande.Controls.Add(this.groupBox5);
            this.tabPageHistoCommande.Controls.Add(this.listBoxHistoCdes);
            this.tabPageHistoCommande.Location = new System.Drawing.Point(4, 24);
            this.tabPageHistoCommande.Name = "tabPageHistoCommande";
            this.tabPageHistoCommande.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistoCommande.Size = new System.Drawing.Size(1052, 684);
            this.tabPageHistoCommande.TabIndex = 1;
            this.tabPageHistoCommande.Text = "Historique commandes";
            this.tabPageHistoCommande.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.buttonSuppCde);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.txtHistoPrix);
            this.groupBox5.Controls.Add(this.listBoxHistoContenuCde);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 315);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1046, 366);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label24.Location = new System.Drawing.Point(479, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(118, 19);
            this.label24.TabIndex = 26;
            this.label24.Text = "Détail contenu";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label23.Location = new System.Drawing.Point(8, 15);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 19);
            this.label23.TabIndex = 25;
            this.label23.Text = "Détail client";
            // 
            // buttonSuppCde
            // 
            this.buttonSuppCde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSuppCde.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSuppCde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuppCde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuppCde.Location = new System.Drawing.Point(880, 13);
            this.buttonSuppCde.Name = "buttonSuppCde";
            this.buttonSuppCde.Size = new System.Drawing.Size(133, 23);
            this.buttonSuppCde.TabIndex = 2;
            this.buttonSuppCde.Text = "Supprimer commande";
            this.buttonSuppCde.UseVisualStyleBackColor = false;
            this.buttonSuppCde.Visible = false;
            this.buttonSuppCde.Click += new System.EventHandler(this.buttonSuppCde_Click);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(877, 300);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 15);
            this.label22.TabIndex = 24;
            this.label22.Text = "Total TTC";
            // 
            // txtHistoPrix
            // 
            this.txtHistoPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHistoPrix.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtHistoPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoPrix.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtHistoPrix.Location = new System.Drawing.Point(938, 299);
            this.txtHistoPrix.Name = "txtHistoPrix";
            this.txtHistoPrix.ReadOnly = true;
            this.txtHistoPrix.Size = new System.Drawing.Size(75, 20);
            this.txtHistoPrix.TabIndex = 23;
            // 
            // listBoxHistoContenuCde
            // 
            this.listBoxHistoContenuCde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxHistoContenuCde.BackColor = System.Drawing.Color.PapayaWhip;
            this.listBoxHistoContenuCde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxHistoContenuCde.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxHistoContenuCde.FormattingEnabled = true;
            this.listBoxHistoContenuCde.Location = new System.Drawing.Point(483, 42);
            this.listBoxHistoContenuCde.Name = "listBoxHistoContenuCde";
            this.listBoxHistoContenuCde.Size = new System.Drawing.Size(530, 247);
            this.listBoxHistoContenuCde.TabIndex = 22;
            this.listBoxHistoContenuCde.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlSaisiCde_DrawItem);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.txtHistoTel);
            this.groupBox6.Controls.Add(this.txtHistoVille);
            this.groupBox6.Controls.Add(this.txtHistoPrenom);
            this.groupBox6.Controls.Add(this.txtHistoAdresse2);
            this.groupBox6.Controls.Add(this.txtHistoAdresse1);
            this.groupBox6.Controls.Add(this.txtHistoCP);
            this.groupBox6.Controls.Add(this.txtHistoNom);
            this.groupBox6.Location = new System.Drawing.Point(6, 42);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(378, 251);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Telephone";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "Ville";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Prenom";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 15);
            this.label18.TabIndex = 1;
            this.label18.Text = "Adresse 2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 15);
            this.label19.TabIndex = 1;
            this.label19.Text = "Adresse 1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(40, 158);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 15);
            this.label20.TabIndex = 1;
            this.label20.Text = "CP";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(32, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 15);
            this.label21.TabIndex = 1;
            this.label21.Text = "Nom";
            // 
            // txtHistoTel
            // 
            this.txtHistoTel.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtHistoTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHistoTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoTel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtHistoTel.Location = new System.Drawing.Point(72, 224);
            this.txtHistoTel.Name = "txtHistoTel";
            this.txtHistoTel.ReadOnly = true;
            this.txtHistoTel.Size = new System.Drawing.Size(100, 20);
            this.txtHistoTel.TabIndex = 0;
            // 
            // txtHistoVille
            // 
            this.txtHistoVille.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtHistoVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHistoVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoVille.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtHistoVille.Location = new System.Drawing.Point(72, 191);
            this.txtHistoVille.Name = "txtHistoVille";
            this.txtHistoVille.ReadOnly = true;
            this.txtHistoVille.Size = new System.Drawing.Size(100, 20);
            this.txtHistoVille.TabIndex = 0;
            // 
            // txtHistoPrenom
            // 
            this.txtHistoPrenom.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtHistoPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHistoPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoPrenom.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtHistoPrenom.Location = new System.Drawing.Point(72, 59);
            this.txtHistoPrenom.Name = "txtHistoPrenom";
            this.txtHistoPrenom.ReadOnly = true;
            this.txtHistoPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtHistoPrenom.TabIndex = 0;
            // 
            // txtHistoAdresse2
            // 
            this.txtHistoAdresse2.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtHistoAdresse2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHistoAdresse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoAdresse2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtHistoAdresse2.Location = new System.Drawing.Point(72, 125);
            this.txtHistoAdresse2.Name = "txtHistoAdresse2";
            this.txtHistoAdresse2.ReadOnly = true;
            this.txtHistoAdresse2.Size = new System.Drawing.Size(275, 20);
            this.txtHistoAdresse2.TabIndex = 0;
            // 
            // txtHistoAdresse1
            // 
            this.txtHistoAdresse1.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtHistoAdresse1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHistoAdresse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoAdresse1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtHistoAdresse1.Location = new System.Drawing.Point(72, 92);
            this.txtHistoAdresse1.Name = "txtHistoAdresse1";
            this.txtHistoAdresse1.ReadOnly = true;
            this.txtHistoAdresse1.Size = new System.Drawing.Size(275, 20);
            this.txtHistoAdresse1.TabIndex = 0;
            // 
            // txtHistoCP
            // 
            this.txtHistoCP.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtHistoCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHistoCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoCP.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtHistoCP.Location = new System.Drawing.Point(72, 158);
            this.txtHistoCP.Name = "txtHistoCP";
            this.txtHistoCP.ReadOnly = true;
            this.txtHistoCP.Size = new System.Drawing.Size(100, 20);
            this.txtHistoCP.TabIndex = 0;
            // 
            // txtHistoNom
            // 
            this.txtHistoNom.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtHistoNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHistoNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistoNom.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtHistoNom.Location = new System.Drawing.Point(72, 26);
            this.txtHistoNom.Name = "txtHistoNom";
            this.txtHistoNom.ReadOnly = true;
            this.txtHistoNom.Size = new System.Drawing.Size(100, 20);
            this.txtHistoNom.TabIndex = 0;
            // 
            // listBoxHistoCdes
            // 
            this.listBoxHistoCdes.BackColor = System.Drawing.Color.PapayaWhip;
            this.listBoxHistoCdes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxHistoCdes.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxHistoCdes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxHistoCdes.FormattingEnabled = true;
            this.listBoxHistoCdes.Location = new System.Drawing.Point(3, 3);
            this.listBoxHistoCdes.Name = "listBoxHistoCdes";
            this.listBoxHistoCdes.Size = new System.Drawing.Size(1046, 312);
            this.listBoxHistoCdes.TabIndex = 0;
            this.listBoxHistoCdes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlSaisiCde_DrawItem);
            this.listBoxHistoCdes.SelectedIndexChanged += new System.EventHandler(this.listBoxHistoCdes_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerUtilisateurToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // changerUtilisateurToolStripMenuItem
            // 
            this.changerUtilisateurToolStripMenuItem.Name = "changerUtilisateurToolStripMenuItem";
            this.changerUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.changerUtilisateurToolStripMenuItem.Text = "Changer Utilisateur";
            this.changerUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.changerUtilisateurToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 736);
            this.Controls.Add(this.tabControlSaisiCde);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza.net";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlSaisiCde.ResumeLayout(false);
            this.tabPageSaisirCde.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageHistoCommande.ResumeLayout(false);
            this.tabPageHistoCommande.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSaisiCde;
        private System.Windows.Forms.TabPage tabPageSaisirCde;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSupprEnCours;
        private System.Windows.Forms.ListBox listBoxRecapCommande;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAjouterBoisson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAjouterPizza;
        private System.Windows.Forms.CheckBox checkBoxSupOeuf;
        private System.Windows.Forms.CheckBox checkBoxSupAnchois;
        private System.Windows.Forms.CheckBox checkBoxSupOlives;
        private System.Windows.Forms.CheckBox checkBoxSupCapres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNouvelleRecette;
        private System.Windows.Forms.Button btnDetailPizza;
        private System.Windows.Forms.ListBox listBoxPizza;
        private System.Windows.Forms.TabPage tabPageHistoCommande;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerUtilisateurToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnValiderCommande;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtPrenomClient;
        private System.Windows.Forms.TextBox txtAdresse2;
        private System.Windows.Forms.TextBox txtAdresse1;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBoxHistoContenuCde;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtHistoTel;
        private System.Windows.Forms.TextBox txtHistoVille;
        private System.Windows.Forms.TextBox txtHistoPrenom;
        private System.Windows.Forms.TextBox txtHistoAdresse2;
        private System.Windows.Forms.TextBox txtHistoAdresse1;
        private System.Windows.Forms.TextBox txtHistoCP;
        private System.Windows.Forms.TextBox txtHistoNom;
        private System.Windows.Forms.ListBox listBoxHistoCdes;
        private System.Windows.Forms.Button buttonSuppCde;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtHistoPrix;
        private System.Windows.Forms.Button btnNouvelleBoisson;
        private System.Windows.Forms.ListBox listBoxBoisson;
        private System.Windows.Forms.TextBox txtTotalCdeEnCours;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label26;
    }
}


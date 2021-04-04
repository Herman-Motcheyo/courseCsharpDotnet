
namespace TransportApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_poids = new System.Windows.Forms.TextBox();
            this.txt_volume = new System.Windows.Forms.TextBox();
            this.listCargaison = new System.Windows.Forms.ListView();
            this.btn_add_cargaison = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.data_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_poids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cout = new System.Windows.Forms.Label();
            this.txt_cout = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_dist
            // 
            this.txt_dist.Location = new System.Drawing.Point(133, 37);
            this.txt_dist.Name = "txt_dist";
            this.txt_dist.Size = new System.Drawing.Size(128, 20);
            this.txt_dist.TabIndex = 1;
            this.txt_dist.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(133, 69);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(128, 21);
            this.cb_type.TabIndex = 3;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(154, 96);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 4;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Poids :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Volume :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(278, 122);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(62, 20);
            this.txt_num.TabIndex = 8;
            // 
            // txt_poids
            // 
            this.txt_poids.Location = new System.Drawing.Point(404, 122);
            this.txt_poids.Name = "txt_poids";
            this.txt_poids.Size = new System.Drawing.Size(62, 20);
            this.txt_poids.TabIndex = 9;
            // 
            // txt_volume
            // 
            this.txt_volume.Location = new System.Drawing.Point(536, 122);
            this.txt_volume.Name = "txt_volume";
            this.txt_volume.Size = new System.Drawing.Size(62, 20);
            this.txt_volume.TabIndex = 10;
            this.txt_volume.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // listCargaison
            // 
            this.listCargaison.HideSelection = false;
            this.listCargaison.Location = new System.Drawing.Point(24, 193);
            this.listCargaison.Name = "listCargaison";
            this.listCargaison.Size = new System.Drawing.Size(205, 183);
            this.listCargaison.TabIndex = 11;
            this.listCargaison.UseCompatibleStateImageBehavior = false;
            this.listCargaison.SelectedIndexChanged += new System.EventHandler(this.listCargaison_SelectedIndexChanged);
            // 
            // btn_add_cargaison
            // 
            this.btn_add_cargaison.Location = new System.Drawing.Point(364, 159);
            this.btn_add_cargaison.Name = "btn_add_cargaison";
            this.btn_add_cargaison.Size = new System.Drawing.Size(112, 23);
            this.btn_add_cargaison.TabIndex = 12;
            this.btn_add_cargaison.Text = "Ajouter Cargaison";
            this.btn_add_cargaison.UseVisualStyleBackColor = true;
            this.btn_add_cargaison.Click += new System.EventHandler(this.btn_add_cargaison_Click);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_num,
            this.data_poids,
            this.data_volume});
            this.datagrid.Location = new System.Drawing.Point(278, 193);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(320, 183);
            this.datagrid.TabIndex = 13;
            // 
            // data_num
            // 
            this.data_num.HeaderText = "NUMERO";
            this.data_num.Name = "data_num";
            // 
            // data_poids
            // 
            this.data_poids.HeaderText = "Poids";
            this.data_poids.Name = "data_poids";
            // 
            // data_volume
            // 
            this.data_volume.HeaderText = "Volume";
            this.data_volume.Name = "data_volume";
            // 
            // lbl_cout
            // 
            this.lbl_cout.AutoSize = true;
            this.lbl_cout.Location = new System.Drawing.Point(116, 384);
            this.lbl_cout.Name = "lbl_cout";
            this.lbl_cout.Size = new System.Drawing.Size(104, 13);
            this.lbl_cout.TabIndex = 14;
            this.lbl_cout.Text = "Cout de la cargaison";
            // 
            // txt_cout
            // 
            this.txt_cout.Location = new System.Drawing.Point(240, 382);
            this.txt_cout.Name = "txt_cout";
            this.txt_cout.Size = new System.Drawing.Size(119, 20);
            this.txt_cout.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(619, 409);
            this.Controls.Add(this.txt_cout);
            this.Controls.Add(this.lbl_cout);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.btn_add_cargaison);
            this.Controls.Add(this.listCargaison);
            this.Controls.Add(this.txt_volume);
            this.Controls.Add(this.txt_poids);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dist);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_poids;
        private System.Windows.Forms.TextBox txt_volume;
        private System.Windows.Forms.ListView listCargaison;
        private System.Windows.Forms.Button btn_add_cargaison;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label lbl_cout;
        private System.Windows.Forms.TextBox txt_cout;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_poids;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_volume;
    }
}


namespace verifica_alessio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PopolaTabella = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codicecroduttore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produttore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.codicecroduttore,
            this.quantita,
            this.prezzo,
            this.produttore,
            this.descrizione});
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(746, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // PopolaTabella
            // 
            this.PopolaTabella.Location = new System.Drawing.Point(151, 39);
            this.PopolaTabella.Name = "PopolaTabella";
            this.PopolaTabella.Size = new System.Drawing.Size(75, 23);
            this.PopolaTabella.TabIndex = 2;
            this.PopolaTabella.Text = "PopolaTabella";
            this.PopolaTabella.UseVisualStyleBackColor = true;
            this.PopolaTabella.Click += new System.EventHandler(this.PopolaTabella_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // codicecroduttore
            // 
            this.codicecroduttore.HeaderText = "codicecroduttore";
            this.codicecroduttore.Name = "codicecroduttore";
            // 
            // quantita
            // 
            this.quantita.HeaderText = "quantita";
            this.quantita.Name = "quantita";
            // 
            // prezzo
            // 
            this.prezzo.HeaderText = "prezzo";
            this.prezzo.Name = "prezzo";
            // 
            // produttore
            // 
            this.produttore.HeaderText = "produttore";
            this.produttore.Name = "produttore";
            // 
            // descrizione
            // 
            this.descrizione.HeaderText = "descrizione";
            this.descrizione.Name = "descrizione";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PopolaTabella);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button PopolaTabella;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn codicecroduttore;
        private DataGridViewTextBoxColumn quantita;
        private DataGridViewTextBoxColumn prezzo;
        private DataGridViewTextBoxColumn produttore;
        private DataGridViewTextBoxColumn descrizione;
    }
}
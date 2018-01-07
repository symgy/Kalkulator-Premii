namespace Premia
{
    partial class Form1
    {
        // ******************************************  deklaracja zmiennych
        int id_rekordu = 0;
        int miesiac = 1;
        // ******************************************  koniec deklaracji zmiennych

            


        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnModyfikuj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dpData = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKwotaFV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumerFV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbProcent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPremiaNetto = new System.Windows.Forms.Label();
            this.lblPremiaBrutto = new System.Windows.Forms.Label();
            this.lblSumaNetto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgPremia = new System.Windows.Forms.DataGridView();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.tbSzukaj = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMiesiac = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPremia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUsun);
            this.groupBox1.Controls.Add(this.btnModyfikuj);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.dpData);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbOpis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbKwotaFV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNumerFV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane ";
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(236, 198);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 11;
            this.btnUsun.Text = "usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnModyfikuj
            // 
            this.btnModyfikuj.Location = new System.Drawing.Point(127, 198);
            this.btnModyfikuj.Name = "btnModyfikuj";
            this.btnModyfikuj.Size = new System.Drawing.Size(75, 23);
            this.btnModyfikuj.TabIndex = 10;
            this.btnModyfikuj.Text = "modyfikuj";
            this.btnModyfikuj.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(23, 198);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dpData
            // 
            this.dpData.Location = new System.Drawing.Point(91, 18);
            this.dpData.Name = "dpData";
            this.dpData.Size = new System.Drawing.Size(226, 20);
            this.dpData.TabIndex = 8;
            this.dpData.Value = new System.DateTime(2018, 1, 6, 15, 20, 52, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Opis:";
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(91, 100);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(226, 79);
            this.tbOpis.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kwota netto:";
            // 
            // tbKwotaFV
            // 
            this.tbKwotaFV.Location = new System.Drawing.Point(91, 74);
            this.tbKwotaFV.Name = "tbKwotaFV";
            this.tbKwotaFV.Size = new System.Drawing.Size(226, 20);
            this.tbKwotaFV.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numer FV:";
            // 
            // tbNumerFV
            // 
            this.tbNumerFV.Location = new System.Drawing.Point(91, 48);
            this.tbNumerFV.Name = "tbNumerFV";
            this.tbNumerFV.Size = new System.Drawing.Size(226, 20);
            this.tbNumerFV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data FV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbProcent);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblPremiaNetto);
            this.groupBox2.Controls.Add(this.lblPremiaBrutto);
            this.groupBox2.Controls.Add(this.lblSumaNetto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(10, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podsumowanie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Premia.Properties.Resources.pdf;
            this.pictureBox1.Location = new System.Drawing.Point(231, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "przelicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(192, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "%";
            // 
            // tbProcent
            // 
            this.tbProcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbProcent.Location = new System.Drawing.Point(158, 32);
            this.tbProcent.Name = "tbProcent";
            this.tbProcent.Size = new System.Drawing.Size(30, 22);
            this.tbProcent.TabIndex = 7;
            this.tbProcent.Text = "5";
            this.tbProcent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(8, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Wartość premii:";
            // 
            // lblPremiaNetto
            // 
            this.lblPremiaNetto.AutoSize = true;
            this.lblPremiaNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPremiaNetto.ForeColor = System.Drawing.Color.Red;
            this.lblPremiaNetto.Location = new System.Drawing.Point(165, 129);
            this.lblPremiaNetto.Name = "lblPremiaNetto";
            this.lblPremiaNetto.Size = new System.Drawing.Size(20, 24);
            this.lblPremiaNetto.TabIndex = 5;
            this.lblPremiaNetto.Text = "0";
            // 
            // lblPremiaBrutto
            // 
            this.lblPremiaBrutto.AutoSize = true;
            this.lblPremiaBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPremiaBrutto.Location = new System.Drawing.Point(165, 105);
            this.lblPremiaBrutto.Name = "lblPremiaBrutto";
            this.lblPremiaBrutto.Size = new System.Drawing.Size(20, 24);
            this.lblPremiaBrutto.TabIndex = 4;
            this.lblPremiaBrutto.Text = "0";
            // 
            // lblSumaNetto
            // 
            this.lblSumaNetto.AutoSize = true;
            this.lblSumaNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSumaNetto.Location = new System.Drawing.Point(165, 81);
            this.lblSumaNetto.Name = "lblSumaNetto";
            this.lblSumaNetto.Size = new System.Drawing.Size(20, 24);
            this.lblSumaNetto.TabIndex = 3;
            this.lblSumaNetto.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(9, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Premia netto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(9, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Premia brutto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Suma netto:";
            // 
            // dgPremia
            // 
            this.dgPremia.AllowUserToAddRows = false;
            this.dgPremia.AllowUserToOrderColumns = true;
            this.dgPremia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPremia.Location = new System.Drawing.Point(355, 12);
            this.dgPremia.Name = "dgPremia";
            this.dgPremia.Size = new System.Drawing.Size(800, 557);
            this.dgPremia.TabIndex = 2;
            this.dgPremia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPremia_CellClick);
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Location = new System.Drawing.Point(147, 97);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(75, 23);
            this.btnSzukaj.TabIndex = 12;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // tbSzukaj
            // 
            this.tbSzukaj.Location = new System.Drawing.Point(11, 63);
            this.tbSzukaj.Name = "tbSzukaj";
            this.tbSzukaj.Size = new System.Drawing.Size(337, 20);
            this.tbSzukaj.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Wybierz miesiąc:";
            // 
            // cbMiesiac
            // 
            this.cbMiesiac.FormattingEnabled = true;
            this.cbMiesiac.Items.AddRange(new object[] {
            "styczeń",
            "luty",
            "marzec",
            "kwiecień",
            "maj",
            "czerwiec",
            "lipiec",
            "sierpień",
            "wrzesień",
            "październik",
            "listopad",
            "grudzień"});
            this.cbMiesiac.Location = new System.Drawing.Point(159, 25);
            this.cbMiesiac.Name = "cbMiesiac";
            this.cbMiesiac.Size = new System.Drawing.Size(121, 21);
            this.cbMiesiac.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 582);
            this.Controls.Add(this.cbMiesiac);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.tbSzukaj);
            this.Controls.Add(this.dgPremia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator premii";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPremia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dpData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKwotaFV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumerFV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnModyfikuj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbProcent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPremiaNetto;
        private System.Windows.Forms.Label lblPremiaBrutto;
        private System.Windows.Forms.Label lblSumaNetto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgPremia;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.TextBox tbSzukaj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMiesiac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


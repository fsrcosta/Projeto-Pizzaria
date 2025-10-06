namespace ProjetoPizzaria
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btbSair = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbTamahoPizza = new System.Windows.Forms.ComboBox();
            this.chkBorda = new System.Windows.Forms.CheckBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.chkCatupiry = new System.Windows.Forms.CheckBox();
            this.chkTempero = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpicionais = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtValorPizza = new System.Windows.Forms.TextBox();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.gpboxOpicionais = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpboxOpicionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(71, 365);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(89, 34);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(196, 365);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 34);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(340, 365);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(89, 34);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btbSair
            // 
            this.btbSair.Location = new System.Drawing.Point(479, 365);
            this.btbSair.Name = "btbSair";
            this.btbSair.Size = new System.Drawing.Size(89, 34);
            this.btbSair.TabIndex = 3;
            this.btbSair.Text = "SAIR";
            this.btbSair.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 119);
            this.dataGridView1.TabIndex = 4;
            // 
            // cmbTamahoPizza
            // 
            this.cmbTamahoPizza.FormattingEnabled = true;
            this.cmbTamahoPizza.Location = new System.Drawing.Point(39, 42);
            this.cmbTamahoPizza.Name = "cmbTamahoPizza";
            this.cmbTamahoPizza.Size = new System.Drawing.Size(121, 21);
            this.cmbTamahoPizza.TabIndex = 5;
            this.cmbTamahoPizza.Text = "TAMANHO DA PIZZA";
            // 
            // chkBorda
            // 
            this.chkBorda.AutoSize = true;
            this.chkBorda.Location = new System.Drawing.Point(6, 25);
            this.chkBorda.Name = "chkBorda";
            this.chkBorda.Size = new System.Drawing.Size(126, 17);
            this.chkBorda.TabIndex = 6;
            this.chkBorda.Text = "BORDA RECHEADA";
            this.chkBorda.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(6, 57);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(136, 17);
            this.chkCebola.TabIndex = 7;
            this.chkCebola.Text = "CEBOLA SEM CHORO";
            this.chkCebola.UseVisualStyleBackColor = true;
            // 
            // chkCatupiry
            // 
            this.chkCatupiry.AutoSize = true;
            this.chkCatupiry.Location = new System.Drawing.Point(6, 80);
            this.chkCatupiry.Name = "chkCatupiry";
            this.chkCatupiry.Size = new System.Drawing.Size(134, 17);
            this.chkCatupiry.TabIndex = 8;
            this.chkCatupiry.Text = "CATUPIRY ORIGINAL";
            this.chkCatupiry.UseVisualStyleBackColor = true;
            // 
            // chkTempero
            // 
            this.chkTempero.AutoSize = true;
            this.chkTempero.Location = new System.Drawing.Point(6, 103);
            this.chkTempero.Name = "chkTempero";
            this.chkTempero.Size = new System.Drawing.Size(117, 17);
            this.chkTempero.TabIndex = 9;
            this.chkTempero.Text = "TEMPERO CHEFE";
            this.chkTempero.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "VALOR DA PIZZA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOpicionais
            // 
            this.lblOpicionais.AutoSize = true;
            this.lblOpicionais.Location = new System.Drawing.Point(394, 87);
            this.lblOpicionais.Name = "lblOpicionais";
            this.lblOpicionais.Size = new System.Drawing.Size(133, 13);
            this.lblOpicionais.TabIndex = 11;
            this.lblOpicionais.Text = "VALOR DOS OPICIONAIS";
            this.lblOpicionais.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(533, 87);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(93, 13);
            this.lblValorPagar.TabIndex = 12;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(372, 197);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(69, 13);
            this.lblPesquisar.TabIndex = 13;
            this.lblPesquisar.Text = "PESQUISAR";
            // 
            // txtValorPizza
            // 
            this.txtValorPizza.Location = new System.Drawing.Point(274, 109);
            this.txtValorPizza.Name = "txtValorPizza";
            this.txtValorPizza.Size = new System.Drawing.Size(95, 20);
            this.txtValorPizza.TabIndex = 14;
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(397, 109);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(95, 20);
            this.txtValorOpcionais.TabIndex = 15;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(533, 109);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(95, 20);
            this.txtValorPagar.TabIndex = 16;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(447, 195);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(95, 20);
            this.txtPesquisar.TabIndex = 17;
            // 
            // gpboxOpicionais
            // 
            this.gpboxOpicionais.Controls.Add(this.chkBorda);
            this.gpboxOpicionais.Controls.Add(this.chkCebola);
            this.gpboxOpicionais.Controls.Add(this.chkCatupiry);
            this.gpboxOpicionais.Controls.Add(this.chkTempero);
            this.gpboxOpicionais.Location = new System.Drawing.Point(12, 87);
            this.gpboxOpicionais.Name = "gpboxOpicionais";
            this.gpboxOpicionais.Size = new System.Drawing.Size(220, 135);
            this.gpboxOpicionais.TabIndex = 19;
            this.gpboxOpicionais.TabStop = false;
            this.gpboxOpicionais.Text = "ESCOLHAS OPICIONAIS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpboxOpicionais);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.txtValorPizza);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblOpicionais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTamahoPizza);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btbSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpboxOpicionais.ResumeLayout(false);
            this.gpboxOpicionais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btbSair;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbTamahoPizza;
        private System.Windows.Forms.CheckBox chkBorda;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.CheckBox chkCatupiry;
        private System.Windows.Forms.CheckBox chkTempero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOpicionais;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtValorPizza;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.GroupBox gpboxOpicionais;
    }
}


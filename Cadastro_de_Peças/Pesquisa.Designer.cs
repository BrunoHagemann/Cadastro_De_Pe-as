namespace Trabalho_Igor_P5
{
    partial class Pesquisa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texCodigoPeca = new System.Windows.Forms.TextBox();
            this.texNomePeca = new System.Windows.Forms.TextBox();
            this.texfabri = new System.Windows.Forms.TextBox();
            this.texpreco = new System.Windows.Forms.TextBox();
            this.texTipo = new System.Windows.Forms.TextBox();
            this.btnCadastrarP = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.tbnExcluirP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(599, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(828, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo.P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fabricante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome Peça";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Preço";
            // 
            // texCodigoPeca
            // 
            this.texCodigoPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texCodigoPeca.Location = new System.Drawing.Point(196, 48);
            this.texCodigoPeca.Name = "texCodigoPeca";
            this.texCodigoPeca.Size = new System.Drawing.Size(330, 34);
            this.texCodigoPeca.TabIndex = 2;
            // 
            // texNomePeca
            // 
            this.texNomePeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texNomePeca.Location = new System.Drawing.Point(195, 112);
            this.texNomePeca.Name = "texNomePeca";
            this.texNomePeca.Size = new System.Drawing.Size(330, 34);
            this.texNomePeca.TabIndex = 2;
            // 
            // texfabri
            // 
            this.texfabri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texfabri.Location = new System.Drawing.Point(195, 178);
            this.texfabri.Name = "texfabri";
            this.texfabri.Size = new System.Drawing.Size(330, 34);
            this.texfabri.TabIndex = 2;
            // 
            // texpreco
            // 
            this.texpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texpreco.Location = new System.Drawing.Point(195, 299);
            this.texpreco.Name = "texpreco";
            this.texpreco.Size = new System.Drawing.Size(330, 34);
            this.texpreco.TabIndex = 2;
            // 
            // texTipo
            // 
            this.texTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texTipo.Location = new System.Drawing.Point(195, 243);
            this.texTipo.Name = "texTipo";
            this.texTipo.Size = new System.Drawing.Size(330, 34);
            this.texTipo.TabIndex = 2;
            // 
            // btnCadastrarP
            // 
            this.btnCadastrarP.BackColor = System.Drawing.Color.LightGreen;
            this.btnCadastrarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarP.Location = new System.Drawing.Point(105, 395);
            this.btnCadastrarP.Name = "btnCadastrarP";
            this.btnCadastrarP.Size = new System.Drawing.Size(128, 59);
            this.btnCadastrarP.TabIndex = 3;
            this.btnCadastrarP.Text = "Cadastrar";
            this.btnCadastrarP.UseVisualStyleBackColor = false;
            this.btnCadastrarP.Click += new System.EventHandler(this.btnCadastrarP_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(398, 395);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(128, 59);
            this.btnProcurar.TabIndex = 3;
            this.btnProcurar.Text = "Buscar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // tbnExcluirP
            // 
            this.tbnExcluirP.BackColor = System.Drawing.Color.Red;
            this.tbnExcluirP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnExcluirP.Location = new System.Drawing.Point(702, 395);
            this.tbnExcluirP.Name = "tbnExcluirP";
            this.tbnExcluirP.Size = new System.Drawing.Size(128, 59);
            this.tbnExcluirP.TabIndex = 3;
            this.tbnExcluirP.Text = "Excluir";
            this.tbnExcluirP.UseVisualStyleBackColor = false;
            this.tbnExcluirP.Click += new System.EventHandler(this.tbnExcluirP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Trabalho_Igor_P5.Properties.Resources.png_transparent_euro_sign_currency_symbol_cent_euro_symbol_angle_text_currency_symbol_thumbnail_removebg_preview;
            this.pictureBox1.Image = global::Trabalho_Igor_P5.Properties.Resources.png_transparent_euro_sign_currency_symbol_cent_euro_symbol_angle_text_currency_symbol_thumbnail_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(433, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 425);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 548);
            this.Controls.Add(this.tbnExcluirP);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnCadastrarP);
            this.Controls.Add(this.texTipo);
            this.Controls.Add(this.texpreco);
            this.Controls.Add(this.texfabri);
            this.Controls.Add(this.texNomePeca);
            this.Controls.Add(this.texCodigoPeca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pesquisa";
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.Pesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texCodigoPeca;
        private System.Windows.Forms.TextBox texNomePeca;
        private System.Windows.Forms.TextBox texfabri;
        private System.Windows.Forms.TextBox texpreco;
        private System.Windows.Forms.TextBox texTipo;
        private System.Windows.Forms.Button btnCadastrarP;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button tbnExcluirP;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
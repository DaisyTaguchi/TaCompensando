
namespace TaCompencando
{
    partial class Form1
    {
        private const string V1 = "Calcular";
        private const string V = V1;

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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.LabelPrLitro = new System.Windows.Forms.Label();
            this.LabelPrLitroEtanol = new System.Windows.Forms.Label();
            this.LabelPrLitroGasolina = new System.Windows.Forms.Label();
            this.LabelConsMedio = new System.Windows.Forms.Label();
            this.LabelKmLEtanol = new System.Windows.Forms.Label();
            this.LabelKmLGasolina = new System.Windows.Forms.Label();
            this.kkkkk = new System.Windows.Forms.TextBox();
            this.TextBoxGas = new System.Windows.Forms.TextBox();
            this.TextBoxKmLEtanol = new System.Windows.Forms.TextBox();
            this.TextBoxKmLGas = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LabelValorInf = new System.Windows.Forms.Label();
            this.LabelResEtanol = new System.Windows.Forms.Label();
            this.LabelResLGas = new System.Windows.Forms.Label();
            this.LabelResKmLEtanol = new System.Windows.Forms.Label();
            this.LabelResKmLGas = new System.Windows.Forms.Label();
            this.TextBoxResEtanol = new System.Windows.Forms.TextBox();
            this.TexboxResGas = new System.Windows.Forms.TextBox();
            this.TextBoxResKmEtanol = new System.Windows.Forms.TextBox();
            this.TextBoxResKmGas = new System.Windows.Forms.TextBox();
            this.LabelResultado = new System.Windows.Forms.Label();
            this.LabelRelEtanolGas = new System.Windows.Forms.Label();
            this.TextBoxRelEtanolGas = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 31);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // LabelPrLitro
            // 
            this.LabelPrLitro.AutoSize = true;
            this.LabelPrLitro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPrLitro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelPrLitro.Location = new System.Drawing.Point(2, 20);
            this.LabelPrLitro.Name = "LabelPrLitro";
            this.LabelPrLitro.Size = new System.Drawing.Size(147, 21);
            this.LabelPrLitro.TabIndex = 1;
            this.LabelPrLitro.Text = "Preço do Litro  R$:";
            // 
            // LabelPrLitroEtanol
            // 
            this.LabelPrLitroEtanol.AutoSize = true;
            this.LabelPrLitroEtanol.Location = new System.Drawing.Point(2, 51);
            this.LabelPrLitroEtanol.Name = "LabelPrLitroEtanol";
            this.LabelPrLitroEtanol.Size = new System.Drawing.Size(43, 15);
            this.LabelPrLitroEtanol.TabIndex = 2;
            this.LabelPrLitroEtanol.Text = "Etanol:";
            // 
            // LabelPrLitroGasolina
            // 
            this.LabelPrLitroGasolina.AutoSize = true;
            this.LabelPrLitroGasolina.Location = new System.Drawing.Point(2, 80);
            this.LabelPrLitroGasolina.Name = "LabelPrLitroGasolina";
            this.LabelPrLitroGasolina.Size = new System.Drawing.Size(52, 15);
            this.LabelPrLitroGasolina.TabIndex = 3;
            this.LabelPrLitroGasolina.Text = "Gasolina";
            this.LabelPrLitroGasolina.Click += new System.EventHandler(this.LabelPrLitroGasolina_Click);
            // 
            // LabelConsMedio
            // 
            this.LabelConsMedio.AutoSize = true;
            this.LabelConsMedio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelConsMedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelConsMedio.Location = new System.Drawing.Point(2, 114);
            this.LabelConsMedio.Name = "LabelConsMedio";
            this.LabelConsMedio.Size = new System.Drawing.Size(210, 21);
            this.LabelConsMedio.TabIndex = 4;
            this.LabelConsMedio.Text = "Consumo Médio Km/Litro:";
            // 
            // LabelKmLEtanol
            // 
            this.LabelKmLEtanol.AutoSize = true;
            this.LabelKmLEtanol.Location = new System.Drawing.Point(2, 153);
            this.LabelKmLEtanol.Name = "LabelKmLEtanol";
            this.LabelKmLEtanol.Size = new System.Drawing.Size(87, 15);
            this.LabelKmLEtanol.TabIndex = 5;
            this.LabelKmLEtanol.Text = "Km/litro Etanol";
            // 
            // LabelKmLGasolina
            // 
            this.LabelKmLGasolina.AutoSize = true;
            this.LabelKmLGasolina.Location = new System.Drawing.Point(2, 187);
            this.LabelKmLGasolina.Name = "LabelKmLGasolina";
            this.LabelKmLGasolina.Size = new System.Drawing.Size(99, 15);
            this.LabelKmLGasolina.TabIndex = 6;
            this.LabelKmLGasolina.Text = "Km/litro Gasolina";
            // 
            // kkkkk
            // 
            this.kkkkk.Location = new System.Drawing.Point(112, 42);
            this.kkkkk.Name = "kkkkk";
            this.kkkkk.Size = new System.Drawing.Size(100, 23);
            this.kkkkk.TabIndex = 7;
            this.kkkkk.TextChanged += new System.EventHandler(this.textBoxEtanol_TextChanged);
            // 
            // TextBoxGas
            // 
            this.TextBoxGas.Location = new System.Drawing.Point(112, 72);
            this.TextBoxGas.Name = "TextBoxGas";
            this.TextBoxGas.Size = new System.Drawing.Size(100, 23);
            this.TextBoxGas.TabIndex = 8;
            // 
            // TextBoxKmLEtanol
            // 
            this.TextBoxKmLEtanol.Location = new System.Drawing.Point(114, 154);
            this.TextBoxKmLEtanol.Name = "TextBoxKmLEtanol";
            this.TextBoxKmLEtanol.Size = new System.Drawing.Size(100, 23);
            this.TextBoxKmLEtanol.TabIndex = 9;
            // 
            // TextBoxKmLGas
            // 
            this.TextBoxKmLGas.Location = new System.Drawing.Point(114, 185);
            this.TextBoxKmLGas.Name = "TextBoxKmLGas";
            this.TextBoxKmLGas.Size = new System.Drawing.Size(98, 23);
            this.TextBoxKmLGas.TabIndex = 10;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCalcular.ForeColor = System.Drawing.Color.Maroon;
            this.BtnCalcular.Location = new System.Drawing.Point(53, 232);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(159, 33);
            this.BtnCalcular.TabIndex = 11;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // LabelValorInf
            // 
            this.LabelValorInf.AutoSize = true;
            this.LabelValorInf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelValorInf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelValorInf.Location = new System.Drawing.Point(366, 20);
            this.LabelValorInf.Name = "LabelValorInf";
            this.LabelValorInf.Size = new System.Drawing.Size(146, 21);
            this.LabelValorInf.TabIndex = 12;
            this.LabelValorInf.Text = "Valores Informados";
            // 
            // LabelResEtanol
            // 
            this.LabelResEtanol.AutoSize = true;
            this.LabelResEtanol.Location = new System.Drawing.Point(333, 51);
            this.LabelResEtanol.Name = "LabelResEtanol";
            this.LabelResEtanol.Size = new System.Drawing.Size(82, 15);
            this.LabelResEtanol.TabIndex = 13;
            this.LabelResEtanol.Text = "R$/LitroEtanol";
            // 
            // LabelResLGas
            // 
            this.LabelResLGas.AutoSize = true;
            this.LabelResLGas.Location = new System.Drawing.Point(333, 84);
            this.LabelResLGas.Name = "LabelResLGas";
            this.LabelResLGas.Size = new System.Drawing.Size(94, 15);
            this.LabelResLGas.TabIndex = 14;
            this.LabelResLGas.Text = "R$/LitroGasolina";
            // 
            // LabelResKmLEtanol
            // 
            this.LabelResKmLEtanol.AutoSize = true;
            this.LabelResKmLEtanol.Location = new System.Drawing.Point(333, 113);
            this.LabelResKmLEtanol.Name = "LabelResKmLEtanol";
            this.LabelResKmLEtanol.Size = new System.Drawing.Size(87, 15);
            this.LabelResKmLEtanol.TabIndex = 15;
            this.LabelResKmLEtanol.Text = "Km/LitroEtanol";
            // 
            // LabelResKmLGas
            // 
            this.LabelResKmLGas.AutoSize = true;
            this.LabelResKmLGas.Location = new System.Drawing.Point(333, 142);
            this.LabelResKmLGas.Name = "LabelResKmLGas";
            this.LabelResKmLGas.Size = new System.Drawing.Size(99, 15);
            this.LabelResKmLGas.TabIndex = 16;
            this.LabelResKmLGas.Text = "Km/LitroGasolina";
            // 
            // TextBoxResEtanol
            // 
            this.TextBoxResEtanol.Location = new System.Drawing.Point(445, 51);
            this.TextBoxResEtanol.Name = "TextBoxResEtanol";
            this.TextBoxResEtanol.Size = new System.Drawing.Size(100, 23);
            this.TextBoxResEtanol.TabIndex = 17;
            this.TextBoxResEtanol.TextChanged += new System.EventHandler(this.TextBoxResEtanol_TextChanged);
            // 
            // TexboxResGas
            // 
            this.TexboxResGas.Location = new System.Drawing.Point(445, 77);
            this.TexboxResGas.Name = "TexboxResGas";
            this.TexboxResGas.Size = new System.Drawing.Size(100, 23);
            this.TexboxResGas.TabIndex = 18;
            // 
            // TextBoxResKmEtanol
            // 
            this.TextBoxResKmEtanol.Location = new System.Drawing.Point(445, 105);
            this.TextBoxResKmEtanol.Name = "TextBoxResKmEtanol";
            this.TextBoxResKmEtanol.Size = new System.Drawing.Size(100, 23);
            this.TextBoxResKmEtanol.TabIndex = 19;
            // 
            // TextBoxResKmGas
            // 
            this.TextBoxResKmGas.Location = new System.Drawing.Point(445, 134);
            this.TextBoxResKmGas.Name = "TextBoxResKmGas";
            this.TextBoxResKmGas.Size = new System.Drawing.Size(100, 23);
            this.TextBoxResKmGas.TabIndex = 20;
            // 
            // LabelResultado
            // 
            this.LabelResultado.AutoSize = true;
            this.LabelResultado.BackColor = System.Drawing.Color.Yellow;
            this.LabelResultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelResultado.Location = new System.Drawing.Point(376, 198);
            this.LabelResultado.Name = "LabelResultado";
            this.LabelResultado.Size = new System.Drawing.Size(99, 25);
            this.LabelResultado.TabIndex = 21;
            this.LabelResultado.Text = "Resultado";
            // 
            // LabelRelEtanolGas
            // 
            this.LabelRelEtanolGas.AutoSize = true;
            this.LabelRelEtanolGas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelRelEtanolGas.Location = new System.Drawing.Point(355, 232);
            this.LabelRelEtanolGas.Name = "LabelRelEtanolGas";
            this.LabelRelEtanolGas.Size = new System.Drawing.Size(143, 21);
            this.LabelRelEtanolGas.TabIndex = 22;
            this.LabelRelEtanolGas.Text = "Relação Etanol/Gas";
            // 
            // TextBoxRelEtanolGas
            // 
            this.TextBoxRelEtanolGas.BackColor = System.Drawing.Color.White;
            this.TextBoxRelEtanolGas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBoxRelEtanolGas.Location = new System.Drawing.Point(355, 270);
            this.TextBoxRelEtanolGas.Name = "TextBoxRelEtanolGas";
            this.TextBoxRelEtanolGas.Size = new System.Drawing.Size(143, 23);
            this.TextBoxRelEtanolGas.TabIndex = 25;
            this.TextBoxRelEtanolGas.TextChanged += new System.EventHandler(this.textBoxRelEtanolGas_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.TextBoxRelEtanolGas);
            this.Controls.Add(this.LabelRelEtanolGas);
            this.Controls.Add(this.LabelResultado);
            this.Controls.Add(this.TextBoxResKmGas);
            this.Controls.Add(this.TextBoxResKmEtanol);
            this.Controls.Add(this.TexboxResGas);
            this.Controls.Add(this.TextBoxResEtanol);
            this.Controls.Add(this.LabelResKmLGas);
            this.Controls.Add(this.LabelResKmLEtanol);
            this.Controls.Add(this.LabelResLGas);
            this.Controls.Add(this.LabelResEtanol);
            this.Controls.Add(this.LabelValorInf);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TextBoxKmLGas);
            this.Controls.Add(this.TextBoxKmLEtanol);
            this.Controls.Add(this.TextBoxGas);
            this.Controls.Add(this.kkkkk);
            this.Controls.Add(this.LabelKmLGasolina);
            this.Controls.Add(this.LabelKmLEtanol);
            this.Controls.Add(this.LabelConsMedio);
            this.Controls.Add(this.LabelPrLitroGasolina);
            this.Controls.Add(this.LabelPrLitroEtanol);
            this.Controls.Add(this.LabelPrLitro);
            this.Name = "Form1";
            this.Text = "TaCompensando";
            this.TransparencyKey = System.Drawing.Color.Gold;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Label LabelPrLitro;
        private System.Windows.Forms.Label LabelPrLitroEtanol;
        private System.Windows.Forms.Label LabelPrLitroGasolina;
        private System.Windows.Forms.Label LabelConsMedio;
        private System.Windows.Forms.Label LabelKmLEtanol;
        private System.Windows.Forms.Label LabelKmLGasolina;
        private System.Windows.Forms.TextBox kkkkk;
        private System.Windows.Forms.TextBox TextBoxGas;
        private System.Windows.Forms.TextBox TextBoxKmLEtanol;
        private System.Windows.Forms.TextBox TextBoxKmLGas;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LabelValorInf;
        private System.Windows.Forms.Label LabelResEtanol;
        private System.Windows.Forms.Label LabelResLGas;
        private System.Windows.Forms.Label LabelResKmLEtanol;
        private System.Windows.Forms.Label LabelResKmLGas;
        private System.Windows.Forms.TextBox TextBoxResEtanol;
        private System.Windows.Forms.TextBox TexboxResGas;
        private System.Windows.Forms.TextBox TextBoxResKmEtanol;
        private System.Windows.Forms.TextBox TextBoxResKmGas;
        private System.Windows.Forms.Label LabelResultado;
        private System.Windows.Forms.Label LabelRelEtanolGas;
        private System.Windows.Forms.TextBox TextBoxRelEtanolGas;
    }
}


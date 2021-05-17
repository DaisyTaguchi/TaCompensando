
namespace TaCompencando
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.LabelPrLitro = new System.Windows.Forms.Label();
            this.LabelPrLitroEtanol = new System.Windows.Forms.Label();
            this.LabelPrLitroGasolina = new System.Windows.Forms.Label();
            this.LabelConsMedio = new System.Windows.Forms.Label();
            this.LabelKmLEtanol = new System.Windows.Forms.Label();
            this.LabelKmLGasolina = new System.Windows.Forms.Label();
            this.textBoxEtanol = new System.Windows.Forms.TextBox();
            this.textBoxGas = new System.Windows.Forms.TextBox();
            this.textBoxKmLEtanol = new System.Windows.Forms.TextBox();
            this.textBoxKmLGas = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.labelValorInf = new System.Windows.Forms.Label();
            this.labelResEtanol = new System.Windows.Forms.Label();
            this.labelResLGas = new System.Windows.Forms.Label();
            this.labelResKmLEtanol = new System.Windows.Forms.Label();
            this.labelResKmLGas = new System.Windows.Forms.Label();
            this.textBoxResEtanol = new System.Windows.Forms.TextBox();
            this.texboxResGas = new System.Windows.Forms.TextBox();
            this.textBoxResKmEtanol = new System.Windows.Forms.TextBox();
            this.textBoxResKmGas = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelRelEtanolGas = new System.Windows.Forms.Label();
            this.textBoxRelEtanolGas = new System.Windows.Forms.TextBox();
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
            // textBoxEtanol
            // 
            this.textBoxEtanol.Location = new System.Drawing.Point(112, 42);
            this.textBoxEtanol.Name = "textBoxEtanol";
            this.textBoxEtanol.Size = new System.Drawing.Size(100, 23);
            this.textBoxEtanol.TabIndex = 7;
            // 
            // textBoxGas
            // 
            this.textBoxGas.Location = new System.Drawing.Point(112, 72);
            this.textBoxGas.Name = "textBoxGas";
            this.textBoxGas.Size = new System.Drawing.Size(100, 23);
            this.textBoxGas.TabIndex = 8;
            // 
            // textBoxKmLEtanol
            // 
            this.textBoxKmLEtanol.Location = new System.Drawing.Point(114, 154);
            this.textBoxKmLEtanol.Name = "textBoxKmLEtanol";
            this.textBoxKmLEtanol.Size = new System.Drawing.Size(100, 23);
            this.textBoxKmLEtanol.TabIndex = 9;
            // 
            // textBoxKmLGas
            // 
            this.textBoxKmLGas.Location = new System.Drawing.Point(114, 185);
            this.textBoxKmLGas.Name = "textBoxKmLGas";
            this.textBoxKmLGas.Size = new System.Drawing.Size(98, 23);
            this.textBoxKmLGas.TabIndex = 10;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.ForeColor = System.Drawing.Color.Maroon;
            this.btnCalcular.Location = new System.Drawing.Point(53, 232);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(159, 33);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // labelValorInf
            // 
            this.labelValorInf.AutoSize = true;
            this.labelValorInf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelValorInf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelValorInf.Location = new System.Drawing.Point(366, 20);
            this.labelValorInf.Name = "labelValorInf";
            this.labelValorInf.Size = new System.Drawing.Size(146, 21);
            this.labelValorInf.TabIndex = 12;
            this.labelValorInf.Text = "Valores Informados";
            // 
            // labelResEtanol
            // 
            this.labelResEtanol.AutoSize = true;
            this.labelResEtanol.Location = new System.Drawing.Point(333, 51);
            this.labelResEtanol.Name = "labelResEtanol";
            this.labelResEtanol.Size = new System.Drawing.Size(82, 15);
            this.labelResEtanol.TabIndex = 13;
            this.labelResEtanol.Text = "R$/LitroEtanol";
            // 
            // labelResLGas
            // 
            this.labelResLGas.AutoSize = true;
            this.labelResLGas.Location = new System.Drawing.Point(333, 84);
            this.labelResLGas.Name = "labelResLGas";
            this.labelResLGas.Size = new System.Drawing.Size(94, 15);
            this.labelResLGas.TabIndex = 14;
            this.labelResLGas.Text = "R$/LitroGasolina";
            // 
            // labelResKmLEtanol
            // 
            this.labelResKmLEtanol.AutoSize = true;
            this.labelResKmLEtanol.Location = new System.Drawing.Point(333, 113);
            this.labelResKmLEtanol.Name = "labelResKmLEtanol";
            this.labelResKmLEtanol.Size = new System.Drawing.Size(87, 15);
            this.labelResKmLEtanol.TabIndex = 15;
            this.labelResKmLEtanol.Text = "Km/LitroEtanol";
            // 
            // labelResKmLGas
            // 
            this.labelResKmLGas.AutoSize = true;
            this.labelResKmLGas.Location = new System.Drawing.Point(333, 142);
            this.labelResKmLGas.Name = "labelResKmLGas";
            this.labelResKmLGas.Size = new System.Drawing.Size(99, 15);
            this.labelResKmLGas.TabIndex = 16;
            this.labelResKmLGas.Text = "Km/LitroGasolina";
            // 
            // textBoxResEtanol
            // 
            this.textBoxResEtanol.Location = new System.Drawing.Point(445, 51);
            this.textBoxResEtanol.Name = "textBoxResEtanol";
            this.textBoxResEtanol.Size = new System.Drawing.Size(100, 23);
            this.textBoxResEtanol.TabIndex = 17;
            // 
            // texboxResGas
            // 
            this.texboxResGas.Location = new System.Drawing.Point(445, 77);
            this.texboxResGas.Name = "texboxResGas";
            this.texboxResGas.Size = new System.Drawing.Size(100, 23);
            this.texboxResGas.TabIndex = 18;
            // 
            // textBoxResKmEtanol
            // 
            this.textBoxResKmEtanol.Location = new System.Drawing.Point(445, 105);
            this.textBoxResKmEtanol.Name = "textBoxResKmEtanol";
            this.textBoxResKmEtanol.Size = new System.Drawing.Size(100, 23);
            this.textBoxResKmEtanol.TabIndex = 19;
            // 
            // textBoxResKmGas
            // 
            this.textBoxResKmGas.Location = new System.Drawing.Point(445, 134);
            this.textBoxResKmGas.Name = "textBoxResKmGas";
            this.textBoxResKmGas.Size = new System.Drawing.Size(100, 23);
            this.textBoxResKmGas.TabIndex = 20;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.BackColor = System.Drawing.Color.Yellow;
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelResultado.Location = new System.Drawing.Point(376, 198);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(99, 25);
            this.labelResultado.TabIndex = 21;
            this.labelResultado.Text = "Resultado";
            // 
            // labelRelEtanolGas
            // 
            this.labelRelEtanolGas.AutoSize = true;
            this.labelRelEtanolGas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRelEtanolGas.Location = new System.Drawing.Point(355, 232);
            this.labelRelEtanolGas.Name = "labelRelEtanolGas";
            this.labelRelEtanolGas.Size = new System.Drawing.Size(143, 21);
            this.labelRelEtanolGas.TabIndex = 22;
            this.labelRelEtanolGas.Text = "Relação Etanol/Gas";
            // 
            // textBoxRelEtanolGas
            // 
            this.textBoxRelEtanolGas.BackColor = System.Drawing.Color.White;
            this.textBoxRelEtanolGas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxRelEtanolGas.Location = new System.Drawing.Point(355, 270);
            this.textBoxRelEtanolGas.Name = "textBoxRelEtanolGas";
            this.textBoxRelEtanolGas.Size = new System.Drawing.Size(143, 23);
            this.textBoxRelEtanolGas.TabIndex = 25;
            this.textBoxRelEtanolGas.TextChanged += new System.EventHandler(this.textBoxRelEtanolGas_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.textBoxRelEtanolGas);
            this.Controls.Add(this.labelRelEtanolGas);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxResKmGas);
            this.Controls.Add(this.textBoxResKmEtanol);
            this.Controls.Add(this.texboxResGas);
            this.Controls.Add(this.textBoxResEtanol);
            this.Controls.Add(this.labelResKmLGas);
            this.Controls.Add(this.labelResKmLEtanol);
            this.Controls.Add(this.labelResLGas);
            this.Controls.Add(this.labelResEtanol);
            this.Controls.Add(this.labelValorInf);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textBoxKmLGas);
            this.Controls.Add(this.textBoxKmLEtanol);
            this.Controls.Add(this.textBoxGas);
            this.Controls.Add(this.textBoxEtanol);
            this.Controls.Add(this.LabelKmLGasolina);
            this.Controls.Add(this.LabelKmLEtanol);
            this.Controls.Add(this.LabelConsMedio);
            this.Controls.Add(this.LabelPrLitroGasolina);
            this.Controls.Add(this.LabelPrLitroEtanol);
            this.Controls.Add(this.LabelPrLitro);
            this.Name = "Form1";
            this.Text = "TaCompensando";
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
        private System.Windows.Forms.TextBox textBoxEtanol;
        private System.Windows.Forms.TextBox textBoxGas;
        private System.Windows.Forms.TextBox textBoxKmLEtanol;
        private System.Windows.Forms.TextBox textBoxKmLGas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label labelValorInf;
        private System.Windows.Forms.Label labelResEtanol;
        private System.Windows.Forms.Label labelResLGas;
        private System.Windows.Forms.Label labelResKmLEtanol;
        private System.Windows.Forms.Label labelResKmLGas;
        private System.Windows.Forms.TextBox textBoxResEtanol;
        private System.Windows.Forms.TextBox texboxResGas;
        private System.Windows.Forms.TextBox textBoxResKmEtanol;
        private System.Windows.Forms.TextBox textBoxResKmGas;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelRelEtanolGas;
        private System.Windows.Forms.TextBox textBoxRelEtanolGas;
    }
}


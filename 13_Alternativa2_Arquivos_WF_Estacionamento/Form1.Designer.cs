namespace _13_Alternativa2_Arquivos_WF_Estacionamento
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
            components = new System.ComponentModel.Container();
            buttonAdicionar = new Button();
            textBoxEntrada = new TextBox();
            textBoxSaida = new TextBox();
            label1 = new Label();
            textBoxPlaca = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            LabelDataAtual = new Label();
            labelHoraAtual = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Location = new Point(240, 88);
            buttonAdicionar.Margin = new Padding(3, 2, 3, 2);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(149, 29);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "Estacionar Veículo";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += button1_Click;
            // 
            // textBoxEntrada
            // 
            textBoxEntrada.BackColor = SystemColors.Window;
            textBoxEntrada.Location = new Point(12, 43);
            textBoxEntrada.Multiline = true;
            textBoxEntrada.Name = "textBoxEntrada";
            textBoxEntrada.ReadOnly = true;
            textBoxEntrada.ScrollBars = ScrollBars.Vertical;
            textBoxEntrada.Size = new Size(222, 358);
            textBoxEntrada.TabIndex = 1;
            // 
            // textBoxSaida
            // 
            textBoxSaida.BackColor = Color.White;
            textBoxSaida.Location = new Point(550, 43);
            textBoxSaida.Multiline = true;
            textBoxSaida.Name = "textBoxSaida";
            textBoxSaida.ReadOnly = true;
            textBoxSaida.ScrollBars = ScrollBars.Vertical;
            textBoxSaida.Size = new Size(222, 358);
            textBoxSaida.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(240, 9);
            label1.Name = "label1";
            label1.Size = new Size(304, 23);
            label1.TabIndex = 3;
            label1.Text = "Estacionamento C# WF";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(240, 60);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(304, 23);
            textBoxPlaca.TabIndex = 4;
            textBoxPlaca.TextChanged += textBoxPlaca_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Cursor = Cursors.No;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(240, 43);
            label2.Name = "label2";
            label2.Size = new Size(304, 14);
            label2.TabIndex = 5;
            label2.Text = "Placa";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Cursor = Cursors.No;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(222, 22);
            label3.TabIndex = 6;
            label3.Text = "Entrada de Veículos";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Cursor = Cursors.No;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(550, 18);
            label4.Name = "label4";
            label4.Size = new Size(222, 22);
            label4.TabIndex = 7;
            label4.Text = "Saída de Veículos";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(395, 88);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(149, 29);
            button1.TabIndex = 8;
            button1.Text = "Remover Veículo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // LabelDataAtual
            // 
            LabelDataAtual.AutoSize = true;
            LabelDataAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDataAtual.Location = new Point(240, 380);
            LabelDataAtual.Name = "LabelDataAtual";
            LabelDataAtual.Size = new Size(40, 21);
            LabelDataAtual.TabIndex = 11;
            LabelDataAtual.Text = "data";
            LabelDataAtual.Click += label5_Click;
            // 
            // labelHoraAtual
            // 
            labelHoraAtual.AutoSize = true;
            labelHoraAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHoraAtual.Location = new Point(477, 380);
            labelHoraAtual.Name = "labelHoraAtual";
            labelHoraAtual.Size = new Size(42, 21);
            labelHoraAtual.TabIndex = 12;
            labelHoraAtual.Text = "hora";
            labelHoraAtual.Click += labelHoraAtual_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 413);
            Controls.Add(labelHoraAtual);
            Controls.Add(LabelDataAtual);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPlaca);
            Controls.Add(label1);
            Controls.Add(textBoxSaida);
            Controls.Add(textBoxEntrada);
            Controls.Add(buttonAdicionar);
            Name = "Form1";
            Text = "Estacionalmento C# WF";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdicionar;
        private TextBox textBoxEntrada;
        private TextBox textBoxSaida;
        private Label label1;
        private TextBox textBoxPlaca;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label LabelDataAtual;
        private Label labelHoraAtual;
        private System.Windows.Forms.Timer timer1;
    }
}
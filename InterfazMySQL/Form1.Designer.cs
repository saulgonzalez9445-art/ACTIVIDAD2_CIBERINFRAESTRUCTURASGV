namespace InterfazMySQL
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            btnConectar = new Button();
            tbUsuario = new TextBox();
            tbContraseña = new TextBox();
            tbHost = new TextBox();
            tbBasedatos = new TextBox();
            tbPuerto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Beige;
            label1.Location = new Point(46, 33);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Beige;
            label2.Location = new Point(22, 64);
            label2.Name = "label2";
            label2.Size = new Size(88, 19);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Beige;
            label3.Location = new Point(66, 90);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 2;
            label3.Text = "Host:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Beige;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(344, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(507, 189);
            dataGridView1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.Beige;
            label4.Location = new Point(3, 123);
            label4.Name = "label4";
            label4.Size = new Size(107, 19);
            label4.TabIndex = 4;
            label4.Text = "Base de Datos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.Beige;
            label5.Location = new Point(52, 155);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 5;
            label5.Text = "Puerto:";
            // 
            // btnConectar
            // 
            btnConectar.BackColor = Color.DarkOrange;
            btnConectar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConectar.ForeColor = Color.FloralWhite;
            btnConectar.Location = new Point(203, 183);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(124, 38);
            btnConectar.TabIndex = 6;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = false;
            btnConectar.Click += button1_Click;
            // 
            // tbUsuario
            // 
            tbUsuario.BackColor = Color.Beige;
            tbUsuario.Location = new Point(116, 32);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(211, 23);
            tbUsuario.TabIndex = 7;
            // 
            // tbContraseña
            // 
            tbContraseña.BackColor = Color.Beige;
            tbContraseña.Location = new Point(116, 60);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.Size = new Size(211, 23);
            tbContraseña.TabIndex = 8;
            // 
            // tbHost
            // 
            tbHost.BackColor = Color.Beige;
            tbHost.Location = new Point(116, 89);
            tbHost.Name = "tbHost";
            tbHost.Size = new Size(211, 23);
            tbHost.TabIndex = 9;
            // 
            // tbBasedatos
            // 
            tbBasedatos.BackColor = Color.Beige;
            tbBasedatos.Location = new Point(116, 119);
            tbBasedatos.Name = "tbBasedatos";
            tbBasedatos.Size = new Size(211, 23);
            tbBasedatos.TabIndex = 10;
            // 
            // tbPuerto
            // 
            tbPuerto.BackColor = Color.Beige;
            tbPuerto.Location = new Point(116, 154);
            tbPuerto.Name = "tbPuerto";
            tbPuerto.Size = new Size(211, 23);
            tbPuerto.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(877, 248);
            Controls.Add(tbPuerto);
            Controls.Add(tbBasedatos);
            Controls.Add(tbHost);
            Controls.Add(tbContraseña);
            Controls.Add(tbUsuario);
            Controls.Add(btnConectar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label5;
        private Button btnConectar;
        private TextBox tbUsuario;
        private TextBox tbContraseña;
        private TextBox tbHost;
        private TextBox tbBasedatos;
        private TextBox tbPuerto;
    }
}

namespace calcularIdade
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
            bt_calcular = new Button();
            lb_resultado = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // bt_calcular
            // 
            bt_calcular.Location = new Point(106, 103);
            bt_calcular.Name = "bt_calcular";
            bt_calcular.Size = new Size(81, 38);
            bt_calcular.TabIndex = 1;
            bt_calcular.Text = "button1";
            bt_calcular.UseVisualStyleBackColor = true;
            bt_calcular.Click += bt_calcular_Click;
            // 
            // lb_resultado
            // 
            lb_resultado.AutoSize = true;
            lb_resultado.Location = new Point(99, 156);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(38, 15);
            lb_resultado.TabIndex = 2;
            lb_resultado.Text = "label1";
            lb_resultado.Click += lb_resultado_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(55, 55);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 318);
            Controls.Add(dateTimePicker1);
            Controls.Add(lb_resultado);
            Controls.Add(bt_calcular);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt_calcular;
        private Label lb_resultado;
        private DateTimePicker dateTimePicker1;
    }
}
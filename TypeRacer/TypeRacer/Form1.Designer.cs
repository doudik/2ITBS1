namespace TypeRacer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.button_vygenerujVetu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_celkoveUhozy = new System.Windows.Forms.Label();
            this.label_celkoveUhozy_num = new System.Windows.Forms.Label();
            this.label_spravnychUhozu_num = new System.Windows.Forms.Label();
            this.label_spravneUhozy = new System.Windows.Forms.Label();
            this.label_spatneUhozy_num = new System.Windows.Forms.Label();
            this.label_spatneUhozy = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_text = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            this.button_vygenerujVetu.Location = new System.Drawing.Point(787, 615);
            this.button_vygenerujVetu.Name = "button_vygenerujVetu";
            this.button_vygenerujVetu.Size = new System.Drawing.Size(391, 184);
            this.button_vygenerujVetu.TabIndex = 0;
            this.button_vygenerujVetu.Text = "Startujc";
            this.button_vygenerujVetu.UseVisualStyleBackColor = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label_spatneUhozy_num);
            this.panel1.Controls.Add(this.label_spatneUhozy);
            this.panel1.Controls.Add(this.label_spravnychUhozu_num);
            this.panel1.Controls.Add(this.label_spravneUhozy);
            this.panel1.Controls.Add(this.label_celkoveUhozy_num);
            this.panel1.Controls.Add(this.label_celkoveUhozy);
            this.panel1.Location = new System.Drawing.Point(787, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 590);
            this.panel1.TabIndex = 1;
            this.label_celkoveUhozy.AutoSize = true;
            this.label_celkoveUhozy.Location = new System.Drawing.Point(47, 88);
            this.label_celkoveUhozy.Name = "label_celkoveUhozy";
            this.label_celkoveUhozy.Size = new System.Drawing.Size(152, 30);
            this.label_celkoveUhozy.TabIndex = 0;
            this.label_celkoveUhozy.Text = "          Celkové úhozy:";
            this.label_celkoveUhozy_num.AutoSize = true;
            this.label_celkoveUhozy_num.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_celkoveUhozy_num.Location = new System.Drawing.Point(249, 88);
            this.label_celkoveUhozy_num.Name = "label_celkoveUhozy_num";
            this.label_celkoveUhozy_num.Size = new System.Drawing.Size(24, 30);
            this.label_celkoveUhozy_num.TabIndex = 1;
            this.label_celkoveUhozy_num.Text = "0";            this.label_spravnychUhozu_num.AutoSize = true;
            this.label_spravnychUhozu_num.Location = new System.Drawing.Point(249, 142);
            this.label_spravnychUhozu_num.Name = "label_spravnychUhozu_num";
            this.label_spravnychUhozu_num.Size = new System.Drawing.Size(24, 30);
            this.label_spravnychUhozu_num.TabIndex = 3;
            this.label_spravnychUhozu_num.Text = "0";
            this.label_spravneUhozy.AutoSize = true;
            this.label_spravneUhozy.Location = new System.Drawing.Point(47, 142);
            this.label_spravneUhozy.Name = "label_spravneUhozy";
            this.label_spravneUhozy.Size = new System.Drawing.Size(183, 30);
            this.label_spravneUhozy.TabIndex = 2;
            this.label_spravneUhozy.Text = "Správných úhozů: ";
            this.label_spatneUhozy_num.AutoSize = true;
            this.label_spatneUhozy_num.Location = new System.Drawing.Point(249, 196);
            this.label_spatneUhozy_num.Name = "label_spatneUhozy_num";
            this.label_spatneUhozy_num.Size = new System.Drawing.Size(24, 30);
            this.label_spatneUhozy_num.TabIndex = 5;
            this.label_spatneUhozy_num.Text = "0";            this.label_spatneUhozy.AutoSize = true;
            this.label_spatneUhozy.Location = new System.Drawing.Point(47, 196);
            this.label_spatneUhozy.Name = "label_spatneUhozy";
            this.label_spatneUhozy.Size = new System.Drawing.Size(173, 30);
            this.label_spatneUhozy.TabIndex = 4;
            this.label_spatneUhozy.Text = "Špatných úhozů: ";
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label_text);
            this.panel2.Location = new System.Drawing.Point(24, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 467);
            this.panel2.TabIndex = 3;
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(91, 195);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(173, 30);
            this.label_text.TabIndex = 0;
            this.label_text.Text = "TADY BUDE TEXT";
            this.label_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 811);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_vygenerujVetu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_vygenerujVetu;
        private Panel panel1;
        private Label label_spatneUhozy_num;
        private Label label_spatneUhozy;
        private Label label_spravnychUhozu_num;
        private Label label_spravneUhozy;
        private Label label_celkoveUhozy_num;
        private Label label_celkoveUhozy;
        private Panel panel2;
        public Label label_text;
    }
}
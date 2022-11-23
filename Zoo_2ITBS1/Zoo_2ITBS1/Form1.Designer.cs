namespace Zoo_2ITBS1
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
            this.panel_zoo = new System.Windows.Forms.Panel();
            this.comboBox_osetrovatel = new System.Windows.Forms.ComboBox();
            this.label_Osetrovatel = new System.Windows.Forms.Label();
            this.label_vybeh = new System.Windows.Forms.Label();
            this.comboBox_vybeh = new System.Windows.Forms.ComboBox();
            this.label_zviratko = new System.Windows.Forms.Label();
            this.comboBox_zviratko = new System.Windows.Forms.ComboBox();
            this.button_zkontrolujZviratko = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_maHlad = new System.Windows.Forms.Label();
            this.button_nakrmZviratko = new System.Windows.Forms.Button();
            this.label_potravina = new System.Windows.Forms.Label();
            this.comboBox_seznamPotravin = new System.Windows.Forms.ComboBox();
            this.label_checkPotravina_text = new System.Windows.Forms.Label();
            this.panel_checkPotravina = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_checkPotravina.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_zoo
            // 
            this.panel_zoo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_zoo.Location = new System.Drawing.Point(1, 1);
            this.panel_zoo.Name = "panel_zoo";
            this.panel_zoo.Size = new System.Drawing.Size(688, 639);
            this.panel_zoo.TabIndex = 0;
            this.panel_zoo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox_osetrovatel
            // 
            this.comboBox_osetrovatel.FormattingEnabled = true;
            this.comboBox_osetrovatel.Location = new System.Drawing.Point(837, 46);
            this.comboBox_osetrovatel.Name = "comboBox_osetrovatel";
            this.comboBox_osetrovatel.Size = new System.Drawing.Size(212, 38);
            this.comboBox_osetrovatel.TabIndex = 1;
            // 
            // label_Osetrovatel
            // 
            this.label_Osetrovatel.AutoSize = true;
            this.label_Osetrovatel.Location = new System.Drawing.Point(705, 48);
            this.label_Osetrovatel.Name = "label_Osetrovatel";
            this.label_Osetrovatel.Size = new System.Drawing.Size(119, 30);
            this.label_Osetrovatel.TabIndex = 2;
            this.label_Osetrovatel.Text = "Ošetřovatel";
            // 
            // label_vybeh
            // 
            this.label_vybeh.AutoSize = true;
            this.label_vybeh.Location = new System.Drawing.Point(743, 91);
            this.label_vybeh.Name = "label_vybeh";
            this.label_vybeh.Size = new System.Drawing.Size(81, 30);
            this.label_vybeh.TabIndex = 4;
            this.label_vybeh.Text = "Výběhy";
            // 
            // comboBox_vybeh
            // 
            this.comboBox_vybeh.FormattingEnabled = true;
            this.comboBox_vybeh.Location = new System.Drawing.Point(837, 91);
            this.comboBox_vybeh.Name = "comboBox_vybeh";
            this.comboBox_vybeh.Size = new System.Drawing.Size(212, 38);
            this.comboBox_vybeh.TabIndex = 3;
            // 
            // label_zviratko
            // 
            this.label_zviratko.AutoSize = true;
            this.label_zviratko.Location = new System.Drawing.Point(743, 139);
            this.label_zviratko.Name = "label_zviratko";
            this.label_zviratko.Size = new System.Drawing.Size(87, 30);
            this.label_zviratko.TabIndex = 6;
            this.label_zviratko.Text = "Zvířátko";
            // 
            // comboBox_zviratko
            // 
            this.comboBox_zviratko.FormattingEnabled = true;
            this.comboBox_zviratko.Location = new System.Drawing.Point(837, 139);
            this.comboBox_zviratko.Name = "comboBox_zviratko";
            this.comboBox_zviratko.Size = new System.Drawing.Size(212, 38);
            this.comboBox_zviratko.TabIndex = 99;
            // 
            // button_zkontrolujZviratko
            // 
            this.button_zkontrolujZviratko.Location = new System.Drawing.Point(709, 202);
            this.button_zkontrolujZviratko.Name = "button_zkontrolujZviratko";
            this.button_zkontrolujZviratko.Size = new System.Drawing.Size(351, 40);
            this.button_zkontrolujZviratko.TabIndex = 7;
            this.button_zkontrolujZviratko.Text = "Má zvířátko hlad?";
            this.button_zkontrolujZviratko.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_maHlad);
            this.panel1.Location = new System.Drawing.Point(709, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 51);
            this.panel1.TabIndex = 8;
            // 
            // label_maHlad
            // 
            this.label_maHlad.AutoSize = true;
            this.label_maHlad.Location = new System.Drawing.Point(128, 9);
            this.label_maHlad.Name = "label_maHlad";
            this.label_maHlad.Size = new System.Drawing.Size(48, 30);
            this.label_maHlad.TabIndex = 0;
            this.label_maHlad.Text = "text";
            this.label_maHlad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_nakrmZviratko
            // 
            this.button_nakrmZviratko.Location = new System.Drawing.Point(709, 455);
            this.button_nakrmZviratko.Name = "button_nakrmZviratko";
            this.button_nakrmZviratko.Size = new System.Drawing.Size(351, 40);
            this.button_nakrmZviratko.TabIndex = 1;
            this.button_nakrmZviratko.Text = "NAKRM ZVIRATKO";
            this.button_nakrmZviratko.UseVisualStyleBackColor = true;
            this.button_nakrmZviratko.Click += new System.EventHandler(this.button_nakrmZviratko_Click);
            // 
            // label_potravina
            // 
            this.label_potravina.AutoSize = true;
            this.label_potravina.Location = new System.Drawing.Point(743, 354);
            this.label_potravina.Name = "label_potravina";
            this.label_potravina.Size = new System.Drawing.Size(99, 30);
            this.label_potravina.TabIndex = 10;
            this.label_potravina.Text = "Potravina";
            // 
            // comboBox_seznamPotravin
            // 
            this.comboBox_seznamPotravin.FormattingEnabled = true;
            this.comboBox_seznamPotravin.Location = new System.Drawing.Point(848, 354);
            this.comboBox_seznamPotravin.Name = "comboBox_seznamPotravin";
            this.comboBox_seznamPotravin.Size = new System.Drawing.Size(212, 38);
            this.comboBox_seznamPotravin.TabIndex = 9;
            // 
            // label_checkPotravina_text
            // 
            this.label_checkPotravina_text.AutoSize = true;
            this.label_checkPotravina_text.Location = new System.Drawing.Point(128, 9);
            this.label_checkPotravina_text.Name = "label_checkPotravina_text";
            this.label_checkPotravina_text.Size = new System.Drawing.Size(48, 30);
            this.label_checkPotravina_text.TabIndex = 0;
            this.label_checkPotravina_text.Text = "text";
            this.label_checkPotravina_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_checkPotravina
            // 
            this.panel_checkPotravina.Controls.Add(this.label_checkPotravina_text);
            this.panel_checkPotravina.Location = new System.Drawing.Point(709, 398);
            this.panel_checkPotravina.Name = "panel_checkPotravina";
            this.panel_checkPotravina.Size = new System.Drawing.Size(351, 51);
            this.panel_checkPotravina.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 881);
            this.Controls.Add(this.panel_checkPotravina);
            this.Controls.Add(this.label_potravina);
            this.Controls.Add(this.comboBox_seznamPotravin);
            this.Controls.Add(this.button_nakrmZviratko);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_zkontrolujZviratko);
            this.Controls.Add(this.label_zviratko);
            this.Controls.Add(this.comboBox_zviratko);
            this.Controls.Add(this.label_vybeh);
            this.Controls.Add(this.comboBox_vybeh);
            this.Controls.Add(this.label_Osetrovatel);
            this.Controls.Add(this.comboBox_osetrovatel);
            this.Controls.Add(this.panel_zoo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_checkPotravina.ResumeLayout(false);
            this.panel_checkPotravina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_zoo;
        private ComboBox comboBox_osetrovatel;
        private Label label_Osetrovatel;
        private Label label_vybeh;
        private ComboBox comboBox_vybeh;
        private Label label_zviratko;
        private ComboBox comboBox_zviratko;
        private Button button_zkontrolujZviratko;
        private Panel panel1;
        private Label label_maHlad;
        private Button button_nakrmZviratko;
        private Label label_potravina;
        private ComboBox comboBox_seznamPotravin;
        private Label label_checkPotravina_text;
        private Panel panel_checkPotravina;
    }
}
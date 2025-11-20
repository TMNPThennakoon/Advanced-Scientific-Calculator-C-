namespace CalculatorApp
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.convert = new System.Windows.Forms.Button();
            this.convertedTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature Converter";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(305, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 25);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "To Fahrenheit";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(305, 229);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(129, 25);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "To Celsius";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperature:";
            // 
            // inputTemp
            // 
            this.inputTemp.Location = new System.Drawing.Point(85, 204);
            this.inputTemp.Name = "inputTemp";
            this.inputTemp.Size = new System.Drawing.Size(100, 22);
            this.inputTemp.TabIndex = 4;
            this.inputTemp.TextChanged += new System.EventHandler(this.inputTemp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 6;
            // 
            // convert
            // 
            this.convert.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.convert.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.convert.Location = new System.Drawing.Point(194, 313);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(129, 38);
            this.convert.TabIndex = 7;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = false;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // convertedTemp
            // 
            this.convertedTemp.AutoSize = true;
            this.convertedTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedTemp.Location = new System.Drawing.Point(87, 284);
            this.convertedTemp.Name = "convertedTemp";
            this.convertedTemp.Size = new System.Drawing.Size(0, 22);
            this.convertedTemp.TabIndex = 8;
            this.convertedTemp.Click += new System.EventHandler(this.convertedTemp_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 379);
            this.Controls.Add(this.convertedTemp);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label convertedTemp;
    }
}
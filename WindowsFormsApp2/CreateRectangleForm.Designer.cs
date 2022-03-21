namespace WindowsFormsApp2
{
    partial class CreateRectangleForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxRectX = new System.Windows.Forms.TextBox();
            this.textBoxRectY = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxW);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxH);
            this.groupBox3.Controls.Add(this.textBoxRectX);
            this.groupBox3.Controls.Add(this.textBoxRectY);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 181);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Создание фигуры";
            // 
            // textBoxW
            // 
            this.textBoxW.Location = new System.Drawing.Point(10, 61);
            this.textBoxW.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(137, 20);
            this.textBoxW.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Введите ширину:";
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(92, 19);
            this.textBoxH.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(51, 20);
            this.textBoxH.TabIndex = 2;
            // 
            // textBoxRectX
            // 
            this.textBoxRectX.Location = new System.Drawing.Point(73, 85);
            this.textBoxRectX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRectX.Name = "textBoxRectX";
            this.textBoxRectX.Size = new System.Drawing.Size(74, 20);
            this.textBoxRectX.TabIndex = 3;
            // 
            // textBoxRectY
            // 
            this.textBoxRectY.Location = new System.Drawing.Point(73, 108);
            this.textBoxRectY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRectY.Name = "textBoxRectY";
            this.textBoxRectY.Size = new System.Drawing.Size(75, 20);
            this.textBoxRectY.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 137);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Создать фигуру";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите длину:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Введите X:";
            // 
            // CreateRectangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 200);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CreateRectangleForm";
            this.Text = "Прямоугольник";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxRectX;
        private System.Windows.Forms.TextBox textBoxRectY;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
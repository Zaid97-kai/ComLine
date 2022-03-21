namespace WindowsFormsApp2
{
    partial class CreatePolygon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDrawPolygon = new System.Windows.Forms.Button();
            this.textBoxNumPoints = new System.Windows.Forms.TextBox();
            this.buttonCreatePoint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCoordY = new System.Windows.Forms.TextBox();
            this.textBoxCoordX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDrawPolygon);
            this.groupBox1.Controls.Add(this.textBoxNumPoints);
            this.groupBox1.Controls.Add(this.buttonCreatePoint);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCoordY);
            this.groupBox1.Controls.Add(this.textBoxCoordX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание многоугольника";
            // 
            // buttonDrawPolygon
            // 
            this.buttonDrawPolygon.Location = new System.Drawing.Point(9, 118);
            this.buttonDrawPolygon.Name = "buttonDrawPolygon";
            this.buttonDrawPolygon.Size = new System.Drawing.Size(281, 23);
            this.buttonDrawPolygon.TabIndex = 4;
            this.buttonDrawPolygon.Text = "Нарисовать полигон";
            this.buttonDrawPolygon.UseVisualStyleBackColor = true;
            this.buttonDrawPolygon.Click += new System.EventHandler(this.buttonDrawPolygon_Click);
            // 
            // textBoxNumPoints
            // 
            this.textBoxNumPoints.Location = new System.Drawing.Point(190, 13);
            this.textBoxNumPoints.Name = "textBoxNumPoints";
            this.textBoxNumPoints.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumPoints.TabIndex = 3;
            // 
            // buttonCreatePoint
            // 
            this.buttonCreatePoint.Location = new System.Drawing.Point(9, 89);
            this.buttonCreatePoint.Name = "buttonCreatePoint";
            this.buttonCreatePoint.Size = new System.Drawing.Size(281, 23);
            this.buttonCreatePoint.TabIndex = 3;
            this.buttonCreatePoint.Text = "Добавить точку";
            this.buttonCreatePoint.UseVisualStyleBackColor = true;
            this.buttonCreatePoint.Click += new System.EventHandler(this.buttonCreatePoint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите координату по Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите координату по X ";
            // 
            // textBoxCoordY
            // 
            this.textBoxCoordY.Location = new System.Drawing.Point(190, 62);
            this.textBoxCoordY.Name = "textBoxCoordY";
            this.textBoxCoordY.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoordY.TabIndex = 2;
            // 
            // textBoxCoordX
            // 
            this.textBoxCoordX.Location = new System.Drawing.Point(190, 36);
            this.textBoxCoordX.Name = "textBoxCoordX";
            this.textBoxCoordX.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoordX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // CreatePolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 179);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreatePolygon";
            this.Text = "Многоугольник";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDrawPolygon;
        private System.Windows.Forms.TextBox textBoxNumPoints;
        private System.Windows.Forms.Button buttonCreatePoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCoordY;
        private System.Windows.Forms.TextBox textBoxCoordX;
        private System.Windows.Forms.Label label1;
    }
}
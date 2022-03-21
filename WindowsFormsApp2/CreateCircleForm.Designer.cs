namespace WindowsFormsApp2
{
    partial class CreateCircleForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelCoordY = new System.Windows.Forms.Label();
            this.labelRadius = new System.Windows.Forms.Label();
            this.labelCoordX = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxR);
            this.groupBox2.Controls.Add(this.textBoxX);
            this.groupBox2.Controls.Add(this.textBoxY);
            this.groupBox2.Controls.Add(this.buttonCreate);
            this.groupBox2.Controls.Add(this.labelCoordY);
            this.groupBox2.Controls.Add(this.labelRadius);
            this.groupBox2.Controls.Add(this.labelCoordX);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 181);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создание фигуры";
            // 
            // textBoxR
            // 
            this.textBoxR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxR.Location = new System.Drawing.Point(5, 38);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(137, 20);
            this.textBoxR.TabIndex = 2;
            // 
            // textBoxX
            // 
            this.textBoxX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxX.Location = new System.Drawing.Point(5, 76);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(137, 20);
            this.textBoxX.TabIndex = 3;
            // 
            // textBoxY
            // 
            this.textBoxY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxY.Location = new System.Drawing.Point(5, 113);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(137, 20);
            this.textBoxY.TabIndex = 9;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreate.Location = new System.Drawing.Point(5, 137);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(137, 38);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Создать фигуру";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelCoordY
            // 
            this.labelCoordY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCoordY.AutoSize = true;
            this.labelCoordY.Location = new System.Drawing.Point(7, 98);
            this.labelCoordY.Name = "labelCoordY";
            this.labelCoordY.Size = new System.Drawing.Size(62, 13);
            this.labelCoordY.TabIndex = 8;
            this.labelCoordY.Text = "Введите Y:";
            // 
            // labelRadius
            // 
            this.labelRadius.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(7, 19);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(90, 13);
            this.labelRadius.TabIndex = 6;
            this.labelRadius.Text = "Введите радиус:";
            // 
            // labelCoordX
            // 
            this.labelCoordX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCoordX.AutoSize = true;
            this.labelCoordX.Location = new System.Drawing.Point(7, 61);
            this.labelCoordX.Name = "labelCoordX";
            this.labelCoordX.Size = new System.Drawing.Size(62, 13);
            this.labelCoordX.TabIndex = 7;
            this.labelCoordX.Text = "Введите X:";
            // 
            // CreateCircleForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(172, 203);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Name = "CreateCircleForm";
            this.Text = "Окружность";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelCoordY;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.Label labelCoordX;
    }
}
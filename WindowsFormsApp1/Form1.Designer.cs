namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Элементы интерфейса
        private System.Windows.Forms.Panel drawingPanel; // Панель для рисования
        private System.Windows.Forms.Button btnLine; // Кнопка для рисования линий
        private System.Windows.Forms.Button btnRectangle; // Кнопка для рисования прямоугольников
        private System.Windows.Forms.Button btnCircle; // Кнопка для рисования кругов
        private System.Windows.Forms.Button btnColor; // Кнопка для выбора цвета
        private System.Windows.Forms.Panel toolPanel; // Панель с инструментами

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.Color.White;
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPanel.Location = new System.Drawing.Point(16, 15);
            this.drawingPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(1034, 524);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseMove);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseUp);
            // 
            // toolPanel
            // 
            this.toolPanel.Controls.Add(this.btnLine);
            this.toolPanel.Controls.Add(this.btnRectangle);
            this.toolPanel.Controls.Add(this.btnCircle);
            this.toolPanel.Controls.Add(this.btnColor);
            this.toolPanel.Location = new System.Drawing.Point(1059, 15);
            this.toolPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(160, 524);
            this.toolPanel.TabIndex = 1;
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(17, 25);
            this.btnLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(125, 28);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Линия";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(17, 76);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(125, 28);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "Прямоугольник";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(17, 123);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(125, 28);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "Круг";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(17, 172);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(125, 28);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Цвет";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 554);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.drawingPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Приложение для рисования";
            this.toolPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}

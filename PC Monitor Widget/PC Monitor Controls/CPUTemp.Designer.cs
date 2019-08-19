namespace PC_Monitor_Widget
{
    partial class CPUTemp
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cpb_CPUTemp = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(29, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPU Temperature";
            // 
            // cpb_CPUTemp
            // 
            this.cpb_CPUTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cpb_CPUTemp.BackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.cpb_CPUTemp.DynamicProgress = false;
            this.cpb_CPUTemp.FieldColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(62)))), ((int)(((byte)(0)))));
            this.cpb_CPUTemp.Location = new System.Drawing.Point(25, 3);
            this.cpb_CPUTemp.MaximumValue = 100D;
            this.cpb_CPUTemp.MinimumValue = 0D;
            this.cpb_CPUTemp.Name = "cpb_CPUTemp";
            this.cpb_CPUTemp.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            this.cpb_CPUTemp.Size = new System.Drawing.Size(150, 150);
            this.cpb_CPUTemp.TabIndex = 2;
            this.cpb_CPUTemp.TextColor = System.Drawing.Color.Black;
            this.cpb_CPUTemp.TextFont = new System.Drawing.Font("Arial", 9F);
            this.cpb_CPUTemp.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CPUTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpb_CPUTemp);
            this.Name = "CPUTemp";
            this.Size = new System.Drawing.Size(204, 175);
            this.Load += new System.EventHandler(this.CPUTemp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar cpb_CPUTemp;
        private System.Windows.Forms.Timer timer1;
    }
}

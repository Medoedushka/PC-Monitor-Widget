namespace PC_Monitor_Widget
{
    partial class RAMControl
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
            this.cpb_RAM = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RAM = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(78, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "RAM";
            // 
            // cpb_RAM
            // 
            this.cpb_RAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cpb_RAM.BackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.cpb_RAM.DynamicProgress = false;
            this.cpb_RAM.FieldColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.cpb_RAM.Location = new System.Drawing.Point(25, 3);
            this.cpb_RAM.MaximumValue = 100D;
            this.cpb_RAM.MinimumValue = 0D;
            this.cpb_RAM.Name = "cpb_RAM";
            this.cpb_RAM.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.cpb_RAM.Size = new System.Drawing.Size(150, 150);
            this.cpb_RAM.TabIndex = 2;
            this.cpb_RAM.TextColor = System.Drawing.Color.Black;
            this.cpb_RAM.TextFont = new System.Drawing.Font("Arial", 9F);
            this.cpb_RAM.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "% Committed Bytes In Use";
            // 
            // RAMControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpb_RAM);
            this.Name = "RAMControl";
            this.Size = new System.Drawing.Size(204, 175);
            this.Load += new System.EventHandler(this.RAMControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar cpb_RAM;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter RAM;
    }
}

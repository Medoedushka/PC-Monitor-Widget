namespace PC_Monitor_Widget
{
    partial class CPUControl
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
            this.cpb_CPU = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPU = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            this.SuspendLayout();
            // 
            // cpb_CPU
            // 
            this.cpb_CPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cpb_CPU.BackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.cpb_CPU.DynamicProgress = false;
            this.cpb_CPU.FieldColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(158)))), ((int)(((byte)(49)))));
            this.cpb_CPU.Location = new System.Drawing.Point(25, 3);
            this.cpb_CPU.MaximumValue = 100D;
            this.cpb_CPU.MinimumValue = 0D;
            this.cpb_CPU.Name = "cpb_CPU";
            this.cpb_CPU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(247)))), ((int)(((byte)(77)))));
            this.cpb_CPU.Size = new System.Drawing.Size(150, 150);
            this.cpb_CPU.TabIndex = 0;
            this.cpb_CPU.TextColor = System.Drawing.Color.Black;
            this.cpb_CPU.TextFont = new System.Drawing.Font("Arial", 9F);
            this.cpb_CPU.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(247)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(81, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processor";
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // CPUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpb_CPU);
            this.Name = "CPUControl";
            this.Size = new System.Drawing.Size(204, 175);
            this.Load += new System.EventHandler(this.CPUControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar cpb_CPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter CPU;
    }
}

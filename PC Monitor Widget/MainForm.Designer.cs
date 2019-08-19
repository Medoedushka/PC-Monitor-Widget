namespace PC_Monitor_Widget
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Controls = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.cpb_CPU = new CircularProgressBar.CircularProgressBar();
            this.cpb_RAM = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cpb_Hard = new CircularProgressBar.CircularProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.pnl_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 27);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pnl_Controls
            // 
            this.pnl_Controls.Controls.Add(this.label3);
            this.pnl_Controls.Controls.Add(this.label2);
            this.pnl_Controls.Controls.Add(this.label1);
            this.pnl_Controls.Controls.Add(this.cpb_Hard);
            this.pnl_Controls.Controls.Add(this.cpb_RAM);
            this.pnl_Controls.Controls.Add(this.cpb_CPU);
            this.pnl_Controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Controls.Location = new System.Drawing.Point(0, 27);
            this.pnl_Controls.Name = "pnl_Controls";
            this.pnl_Controls.Size = new System.Drawing.Size(329, 136);
            this.pnl_Controls.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(247)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(43, 104);
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
            // cpb_CPU
            // 
            this.cpb_CPU.BackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.cpb_CPU.DynamicProgress = false;
            this.cpb_CPU.FieldColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(158)))), ((int)(((byte)(49)))));
            this.cpb_CPU.Location = new System.Drawing.Point(14, 6);
            this.cpb_CPU.MaximumValue = 100D;
            this.cpb_CPU.MinimumValue = 0D;
            this.cpb_CPU.Name = "cpb_CPU";
            this.cpb_CPU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(247)))), ((int)(((byte)(77)))));
            this.cpb_CPU.Size = new System.Drawing.Size(98, 95);
            this.cpb_CPU.TabIndex = 0;
            this.cpb_CPU.TextColor = System.Drawing.Color.Black;
            this.cpb_CPU.TextFont = new System.Drawing.Font("Arial", 9F);
            this.cpb_CPU.Value = 0;
            // 
            // cpb_RAM
            // 
            this.cpb_RAM.BackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.cpb_RAM.DynamicProgress = false;
            this.cpb_RAM.FieldColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.cpb_RAM.Location = new System.Drawing.Point(118, 6);
            this.cpb_RAM.MaximumValue = 100D;
            this.cpb_RAM.MinimumValue = 0D;
            this.cpb_RAM.Name = "cpb_RAM";
            this.cpb_RAM.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.cpb_RAM.Size = new System.Drawing.Size(98, 95);
            this.cpb_RAM.TabIndex = 0;
            this.cpb_RAM.TextColor = System.Drawing.Color.Black;
            this.cpb_RAM.TextFont = new System.Drawing.Font("Arial", 9F);
            this.cpb_RAM.Value = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(146, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAM";
            // 
            // cpb_Hard
            // 
            this.cpb_Hard.BackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.cpb_Hard.DynamicProgress = false;
            this.cpb_Hard.FieldColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(14)))), ((int)(((byte)(140)))));
            this.cpb_Hard.Location = new System.Drawing.Point(222, 6);
            this.cpb_Hard.MaximumValue = 100D;
            this.cpb_Hard.MinimumValue = 0D;
            this.cpb_Hard.Name = "cpb_Hard";
            this.cpb_Hard.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(23)))), ((int)(((byte)(230)))));
            this.cpb_Hard.Size = new System.Drawing.Size(98, 95);
            this.cpb_Hard.TabIndex = 0;
            this.cpb_Hard.TextColor = System.Drawing.Color.Black;
            this.cpb_Hard.TextFont = new System.Drawing.Font("Arial", 9F);
            this.cpb_Hard.Value = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(23)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(228, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hard Drive";
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "% Committed Bytes In Use";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(329, 163);
            this.Controls.Add(this.pnl_Controls);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Controls.ResumeLayout(false);
            this.pnl_Controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Controls;
        private CircularProgressBar.CircularProgressBar cpb_CPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar cpb_RAM;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar.CircularProgressBar cpb_Hard;
        private System.Diagnostics.PerformanceCounter RAM;
    }
}


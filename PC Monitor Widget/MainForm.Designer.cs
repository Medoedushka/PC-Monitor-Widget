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
            this.pcb_Close = new System.Windows.Forms.PictureBox();
            this.pnl_Controls = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPUTemperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Close)).BeginInit();
            this.pnl_Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pcb_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 27);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pcb_Close
            // 
            this.pcb_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcb_Close.Image = global::PC_Monitor_Widget.Properties.Resources.uncheckedCancel27px;
            this.pcb_Close.Location = new System.Drawing.Point(276, 0);
            this.pcb_Close.Name = "pcb_Close";
            this.pcb_Close.Size = new System.Drawing.Size(27, 27);
            this.pcb_Close.TabIndex = 0;
            this.pcb_Close.TabStop = false;
            // 
            // pnl_Controls
            // 
            this.pnl_Controls.Controls.Add(this.panel2);
            this.pnl_Controls.Controls.Add(this.menuStrip1);
            this.pnl_Controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Controls.Location = new System.Drawing.Point(0, 27);
            this.pnl_Controls.Name = "pnl_Controls";
            this.pnl_Controls.Size = new System.Drawing.Size(303, 282);
            this.pnl_Controls.TabIndex = 1;
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
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "% Committed Bytes In Use";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(303, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentToolStripMenuItem
            // 
            this.componentToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.componentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPUToolStripMenuItem,
            this.rAMToolStripMenuItem,
            this.hardDriveToolStripMenuItem,
            this.cPUTemperatureToolStripMenuItem});
            this.componentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.componentToolStripMenuItem.Name = "componentToolStripMenuItem";
            this.componentToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.componentToolStripMenuItem.Text = "Component";
            // 
            // cPUToolStripMenuItem
            // 
            this.cPUToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cPUToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cPUToolStripMenuItem.Name = "cPUToolStripMenuItem";
            this.cPUToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cPUToolStripMenuItem.Text = "CPU";
            // 
            // rAMToolStripMenuItem
            // 
            this.rAMToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rAMToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rAMToolStripMenuItem.Name = "rAMToolStripMenuItem";
            this.rAMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rAMToolStripMenuItem.Text = "RAM";
            // 
            // hardDriveToolStripMenuItem
            // 
            this.hardDriveToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hardDriveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hardDriveToolStripMenuItem.Name = "hardDriveToolStripMenuItem";
            this.hardDriveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hardDriveToolStripMenuItem.Text = "Hard Drive";
            // 
            // cPUTemperatureToolStripMenuItem
            // 
            this.cPUTemperatureToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cPUTemperatureToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cPUTemperatureToolStripMenuItem.Name = "cPUTemperatureToolStripMenuItem";
            this.cPUTemperatureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cPUTemperatureToolStripMenuItem.Text = "CPU Temperature";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 5);
            this.panel2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(303, 309);
            this.Controls.Add(this.pnl_Controls);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Close)).EndInit();
            this.pnl_Controls.ResumeLayout(false);
            this.pnl_Controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Controls;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Diagnostics.PerformanceCounter RAM;
        private System.Windows.Forms.PictureBox pcb_Close;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPUTemperatureToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
    }
}


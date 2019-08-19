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
            this.pnl_Hat = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.pnl_Controls = new System.Windows.Forms.Panel();
            this.pnl_Border = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_CPU = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_RAM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_HardDrive = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_CPUTemp = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.pcb_Close = new System.Windows.Forms.PictureBox();
            this.pnl_Hat.SuspendLayout();
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Hat
            // 
            this.pnl_Hat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            this.pnl_Hat.Controls.Add(this.pcb_Close);
            this.pnl_Hat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Hat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_Hat.Location = new System.Drawing.Point(0, 0);
            this.pnl_Hat.Name = "pnl_Hat";
            this.pnl_Hat.Size = new System.Drawing.Size(204, 21);
            this.pnl_Hat.TabIndex = 0;
            this.pnl_Hat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pnl_Controls);
            this.panel.Controls.Add(this.pnl_Border);
            this.panel.Controls.Add(this.menuStrip1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 21);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(204, 210);
            this.panel.TabIndex = 1;
            // 
            // pnl_Controls
            // 
            this.pnl_Controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Controls.Location = new System.Drawing.Point(0, 29);
            this.pnl_Controls.Name = "pnl_Controls";
            this.pnl_Controls.Size = new System.Drawing.Size(204, 181);
            this.pnl_Controls.TabIndex = 2;
            // 
            // pnl_Border
            // 
            this.pnl_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(0)))));
            this.pnl_Border.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Border.Location = new System.Drawing.Point(0, 24);
            this.pnl_Border.Name = "pnl_Border";
            this.pnl_Border.Size = new System.Drawing.Size(204, 5);
            this.pnl_Border.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(204, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentToolStripMenuItem
            // 
            this.componentToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.componentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_CPU,
            this.tsm_RAM,
            this.tsm_HardDrive,
            this.tsm_CPUTemp});
            this.componentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.componentToolStripMenuItem.Name = "componentToolStripMenuItem";
            this.componentToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.componentToolStripMenuItem.Text = "Component";
            // 
            // tsm_CPU
            // 
            this.tsm_CPU.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsm_CPU.ForeColor = System.Drawing.Color.White;
            this.tsm_CPU.Name = "tsm_CPU";
            this.tsm_CPU.Size = new System.Drawing.Size(167, 22);
            this.tsm_CPU.Text = "CPU";
            this.tsm_CPU.Click += new System.EventHandler(this.tsm_CPU_Click);
            // 
            // tsm_RAM
            // 
            this.tsm_RAM.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsm_RAM.ForeColor = System.Drawing.Color.White;
            this.tsm_RAM.Name = "tsm_RAM";
            this.tsm_RAM.Size = new System.Drawing.Size(167, 22);
            this.tsm_RAM.Text = "RAM";
            this.tsm_RAM.Click += new System.EventHandler(this.tsm_RAM_Click);
            // 
            // tsm_HardDrive
            // 
            this.tsm_HardDrive.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsm_HardDrive.ForeColor = System.Drawing.Color.White;
            this.tsm_HardDrive.Name = "tsm_HardDrive";
            this.tsm_HardDrive.Size = new System.Drawing.Size(167, 22);
            this.tsm_HardDrive.Text = "Hard Drive";
            this.tsm_HardDrive.Click += new System.EventHandler(this.tsm_HardDrive_Click);
            // 
            // tsm_CPUTemp
            // 
            this.tsm_CPUTemp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsm_CPUTemp.ForeColor = System.Drawing.Color.White;
            this.tsm_CPUTemp.Name = "tsm_CPUTemp";
            this.tsm_CPUTemp.Size = new System.Drawing.Size(167, 22);
            this.tsm_CPUTemp.Text = "CPU Temperature";
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
            // pcb_Close
            // 
            this.pcb_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcb_Close.Image = global::PC_Monitor_Widget.Properties.Resources.unchecked15px;
            this.pcb_Close.Location = new System.Drawing.Point(186, 3);
            this.pcb_Close.Name = "pcb_Close";
            this.pcb_Close.Size = new System.Drawing.Size(15, 15);
            this.pcb_Close.TabIndex = 0;
            this.pcb_Close.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(204, 231);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pnl_Hat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Hat.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Hat;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Diagnostics.PerformanceCounter RAM;
        private System.Windows.Forms.PictureBox pcb_Close;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_CPU;
        private System.Windows.Forms.ToolStripMenuItem tsm_RAM;
        private System.Windows.Forms.ToolStripMenuItem tsm_HardDrive;
        private System.Windows.Forms.ToolStripMenuItem tsm_CPUTemp;
        private System.Windows.Forms.Panel pnl_Border;
        private System.Windows.Forms.Panel pnl_Controls;
    }
}


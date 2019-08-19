namespace PC_Monitor_Widget
{
    partial class HardDriveControl
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
            this.cpb_HardDrive = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(23)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(55, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hard Drive";
            // 
            // cpb_HardDrive
            // 
            this.cpb_HardDrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cpb_HardDrive.BackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.cpb_HardDrive.DynamicProgress = false;
            this.cpb_HardDrive.FieldColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(14)))), ((int)(((byte)(140)))));
            this.cpb_HardDrive.Location = new System.Drawing.Point(25, 3);
            this.cpb_HardDrive.MaximumValue = 100D;
            this.cpb_HardDrive.MinimumValue = 0D;
            this.cpb_HardDrive.Name = "cpb_HardDrive";
            this.cpb_HardDrive.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(23)))), ((int)(((byte)(230)))));
            this.cpb_HardDrive.Size = new System.Drawing.Size(150, 150);
            this.cpb_HardDrive.TabIndex = 4;
            this.cpb_HardDrive.TextColor = System.Drawing.Color.Black;
            this.cpb_HardDrive.TextFont = new System.Drawing.Font("Arial", 9F);
            this.cpb_HardDrive.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HardDriveControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpb_HardDrive);
            this.Name = "HardDriveControl";
            this.Size = new System.Drawing.Size(204, 175);
            this.Load += new System.EventHandler(this.HardDriveControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar cpb_HardDrive;
        private System.Windows.Forms.Timer timer1;
    }
}

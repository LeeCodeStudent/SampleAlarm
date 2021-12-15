namespace SampleAlarm
{
    partial class ModifyAlarmLimit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyAlarmLimit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lab_HiHiAlarm = new System.Windows.Forms.Label();
            this.lab_HighAlarm = new System.Windows.Forms.Label();
            this.lab_LowAlarm = new System.Windows.Forms.Label();
            this.lab_LoLoAlarm = new System.Windows.Forms.Label();
            this.txt_HiHiAlarm = new System.Windows.Forms.TextBox();
            this.txt_HighAlarm = new System.Windows.Forms.TextBox();
            this.txt_LowAlarm = new System.Windows.Forms.TextBox();
            this.txt_LoLoAlarm = new System.Windows.Forms.TextBox();
            this.lab_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_OK, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lab_HiHiAlarm, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lab_HighAlarm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lab_LowAlarm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lab_LoLoAlarm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_HiHiAlarm, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_HighAlarm, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_LowAlarm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_LoLoAlarm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lab_ID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_ID, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(561, 498);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_OK.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.btn_OK, 2);
            this.btn_OK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(61, 428);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(438, 52);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Text = "确定修改";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lab_HiHiAlarm
            // 
            this.lab_HiHiAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_HiHiAlarm.AutoSize = true;
            this.lab_HiHiAlarm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_HiHiAlarm.Location = new System.Drawing.Point(87, 357);
            this.lab_HiHiAlarm.Name = "lab_HiHiAlarm";
            this.lab_HiHiAlarm.Size = new System.Drawing.Size(106, 24);
            this.lab_HiHiAlarm.TabIndex = 6;
            this.lab_HiHiAlarm.Text = "高高报警";
            // 
            // lab_HighAlarm
            // 
            this.lab_HighAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_HighAlarm.AutoSize = true;
            this.lab_HighAlarm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_HighAlarm.Location = new System.Drawing.Point(99, 275);
            this.lab_HighAlarm.Name = "lab_HighAlarm";
            this.lab_HighAlarm.Size = new System.Drawing.Size(82, 24);
            this.lab_HighAlarm.TabIndex = 2;
            this.lab_HighAlarm.Text = "高报警";
            // 
            // lab_LowAlarm
            // 
            this.lab_LowAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_LowAlarm.AutoSize = true;
            this.lab_LowAlarm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_LowAlarm.Location = new System.Drawing.Point(99, 193);
            this.lab_LowAlarm.Name = "lab_LowAlarm";
            this.lab_LowAlarm.Size = new System.Drawing.Size(82, 24);
            this.lab_LowAlarm.TabIndex = 4;
            this.lab_LowAlarm.Text = "低报警";
            // 
            // lab_LoLoAlarm
            // 
            this.lab_LoLoAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_LoLoAlarm.AutoSize = true;
            this.lab_LoLoAlarm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_LoLoAlarm.Location = new System.Drawing.Point(87, 111);
            this.lab_LoLoAlarm.Name = "lab_LoLoAlarm";
            this.lab_LoLoAlarm.Size = new System.Drawing.Size(106, 24);
            this.lab_LoLoAlarm.TabIndex = 0;
            this.lab_LoLoAlarm.Text = "低低报警";
            // 
            // txt_HiHiAlarm
            // 
            this.txt_HiHiAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HiHiAlarm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_HiHiAlarm.Location = new System.Drawing.Point(343, 351);
            this.txt_HiHiAlarm.Name = "txt_HiHiAlarm";
            this.txt_HiHiAlarm.Size = new System.Drawing.Size(154, 35);
            this.txt_HiHiAlarm.TabIndex = 4;
            // 
            // txt_HighAlarm
            // 
            this.txt_HighAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HighAlarm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_HighAlarm.Location = new System.Drawing.Point(343, 269);
            this.txt_HighAlarm.Name = "txt_HighAlarm";
            this.txt_HighAlarm.Size = new System.Drawing.Size(154, 35);
            this.txt_HighAlarm.TabIndex = 3;
            // 
            // txt_LowAlarm
            // 
            this.txt_LowAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_LowAlarm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_LowAlarm.Location = new System.Drawing.Point(343, 187);
            this.txt_LowAlarm.Name = "txt_LowAlarm";
            this.txt_LowAlarm.Size = new System.Drawing.Size(154, 35);
            this.txt_LowAlarm.TabIndex = 2;
            // 
            // txt_LoLoAlarm
            // 
            this.txt_LoLoAlarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_LoLoAlarm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_LoLoAlarm.Location = new System.Drawing.Point(343, 105);
            this.txt_LoLoAlarm.Name = "txt_LoLoAlarm";
            this.txt_LoLoAlarm.Size = new System.Drawing.Size(154, 35);
            this.txt_LoLoAlarm.TabIndex = 1;
            // 
            // lab_ID
            // 
            this.lab_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_ID.AutoSize = true;
            this.lab_ID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_ID.Location = new System.Drawing.Point(123, 29);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(34, 24);
            this.lab_ID.TabIndex = 0;
            this.lab_ID.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ID.Location = new System.Drawing.Point(343, 23);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(154, 35);
            this.txt_ID.TabIndex = 0;
            // 
            // ModifyAlarmLimit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyAlarmLimit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "报警限值修改";
            this.Load += new System.EventHandler(this.ModifyAlarmLimit_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lab_LoLoAlarm;
        private System.Windows.Forms.TextBox txt_LoLoAlarm;
        private System.Windows.Forms.Label lab_LowAlarm;
        private System.Windows.Forms.Label lab_HighAlarm;
        private System.Windows.Forms.TextBox txt_LowAlarm;
        private System.Windows.Forms.TextBox txt_HighAlarm;
        private System.Windows.Forms.Label lab_HiHiAlarm;
        private System.Windows.Forms.TextBox txt_HiHiAlarm;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lab_ID;
        private System.Windows.Forms.TextBox txt_ID;
    }
}
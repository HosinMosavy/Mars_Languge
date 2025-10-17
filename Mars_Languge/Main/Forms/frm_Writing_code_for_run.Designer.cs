namespace Mars_Languge.Main.Forms
{
    partial class frm_Writing_code_for_run
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Writing_code_for_run));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lexser = new System.Windows.Forms.RichTextBox();
            this.txtError = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_conntrol_box = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.radSplitButton1 = new Telerik.WinControls.UI.RadSplitButton();
            this.btn_open = new Telerik.WinControls.UI.RadMenuItem();
            this.btn_save = new Telerik.WinControls.UI.RadMenuItem();
            this.btn_save_as = new Telerik.WinControls.UI.RadMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.lstSuggest = new System.Windows.Forms.ListBox();
            this.pnl_conntrol_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "input code";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Black;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.Location = new System.Drawing.Point(806, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(47, 45);
            this.btnRun.TabIndex = 2;
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOutput.ForeColor = System.Drawing.Color.White;
            this.txtOutput.Location = new System.Drawing.Point(10, 29);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(440, 220);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // txt_lexser
            // 
            this.txt_lexser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_lexser.ForeColor = System.Drawing.Color.White;
            this.txt_lexser.Location = new System.Drawing.Point(657, 464);
            this.txt_lexser.Name = "txt_lexser";
            this.txt_lexser.Size = new System.Drawing.Size(190, 103);
            this.txt_lexser.TabIndex = 5;
            this.txt_lexser.Text = "";
            this.txt_lexser.Visible = false;
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtError.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.LightCoral;
            this.txtError.Location = new System.Drawing.Point(477, 144);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(370, 269);
            this.txtError.TabIndex = 6;
            this.txtError.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(733, 607);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lexer :";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(477, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Error List";
            // 
            // pnl_conntrol_box
            // 
            this.pnl_conntrol_box.BackColor = System.Drawing.Color.Gray;
            this.pnl_conntrol_box.Controls.Add(this.label6);
            this.pnl_conntrol_box.Controls.Add(this.lbl_time);
            this.pnl_conntrol_box.Controls.Add(this.pictureBox1);
            this.pnl_conntrol_box.Controls.Add(this.label5);
            this.pnl_conntrol_box.Controls.Add(this.btn_Minimize);
            this.pnl_conntrol_box.Controls.Add(this.btn_close);
            this.pnl_conntrol_box.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_conntrol_box.Location = new System.Drawing.Point(0, 0);
            this.pnl_conntrol_box.Name = "pnl_conntrol_box";
            this.pnl_conntrol_box.Size = new System.Drawing.Size(866, 42);
            this.pnl_conntrol_box.TabIndex = 9;
            this.pnl_conntrol_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Timer :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(434, 10);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(60, 22);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "00:00";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mars_Languge.Properties.Resources.Mars;
            this.pictureBox1.Location = new System.Drawing.Point(150, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mars Language";
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackgroundImage = global::Mars_Languge.Properties.Resources.icons8_minimize_50;
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.ForeColor = System.Drawing.Color.Gray;
            this.btn_Minimize.Location = new System.Drawing.Point(765, 4);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(43, 35);
            this.btn_Minimize.TabIndex = 1;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::Mars_Languge.Properties.Resources.icons8_close_window_50;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Gray;
            this.btn_close.Location = new System.Drawing.Point(814, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(43, 35);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radSplitButton1);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 55);
            this.panel1.TabIndex = 10;
            // 
            // radSplitButton1
            // 
            this.radSplitButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radSplitButton1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btn_open,
            this.btn_save,
            this.btn_save_as});
            this.radSplitButton1.Location = new System.Drawing.Point(10, 13);
            this.radSplitButton1.Name = "radSplitButton1";
            this.radSplitButton1.Size = new System.Drawing.Size(68, 24);
            this.radSplitButton1.TabIndex = 3;
            this.radSplitButton1.Text = "File";
            this.radSplitButton1.ThemeName = "Fluent";
            // 
            // btn_open
            // 
            this.btn_open.Name = "btn_open";
            this.btn_open.Text = "Open";
            // 
            // btn_save
            // 
            this.btn_save.Name = "btn_save";
            this.btn_save.Text = "Save";
            // 
            // btn_save_as
            // 
            this.btn_save_as.Name = "btn_save_as";
            this.btn_save_as.Text = "Save As";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtOutput);
            this.panel2.Location = new System.Drawing.Point(11, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 259);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCode);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(7, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 295);
            this.panel3.TabIndex = 12;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.Color.White;
            this.txtCode.Location = new System.Drawing.Point(14, 22);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(440, 269);
            this.txtCode.TabIndex = 2;
            this.txtCode.Text = "";
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            this.txtCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyUp);
            // 
            // lstSuggest
            // 
            this.lstSuggest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstSuggest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSuggest.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lstSuggest.FormattingEnabled = true;
            this.lstSuggest.ItemHeight = 16;
            this.lstSuggest.Items.AddRange(new object[] {
            "print",
            "int",
            "string",
            "float",
            "bool",
            "if",
            "for",
            "while"});
            this.lstSuggest.Location = new System.Drawing.Point(492, 432);
            this.lstSuggest.Name = "lstSuggest";
            this.lstSuggest.Size = new System.Drawing.Size(112, 228);
            this.lstSuggest.TabIndex = 13;
            this.lstSuggest.Click += new System.EventHandler(this.lstSuggest_Click);
            this.lstSuggest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSuggest_KeyDown);
            // 
            // frm_Writing_code_for_run
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(866, 700);
            this.ControlBox = false;
            this.Controls.Add(this.lstSuggest);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_conntrol_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.txt_lexser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_Writing_code_for_run";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Writing_code_for_run_Load);
            this.pnl_conntrol_box.ResumeLayout(false);
            this.pnl_conntrol_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_lexser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RichTextBox txtError;
        private System.Windows.Forms.Panel pnl_conntrol_box;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadSplitButton radSplitButton1;
        private Telerik.WinControls.UI.RadMenuItem btn_open;
        private Telerik.WinControls.UI.RadMenuItem btn_save;
        private Telerik.WinControls.UI.RadMenuItem btn_save_as;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.ListBox lstSuggest;
    }
}
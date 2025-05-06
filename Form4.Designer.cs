namespace LoginForm
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbocategory = new ComboBox();
            cboname = new ComboBox();
            cbotype = new ComboBox();
            dtp = new DateTimePicker();
            label5 = new Label();
            txtage = new TextBox();
            Dgv = new DataGridView();
            btnsubmit = new Button();
            btnselect = new Button();
            lbltitle = new Label();
            btndelete = new Button();
            btnclear = new Button();
            btnupdate = new Button();
            lblcheckname = new Label();
            lblcheckage1 = new Label();
            panel1 = new Panel();
            lblx = new Label();
            ((System.ComponentModel.ISupportInitialize)Dgv).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 180);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 1;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 100);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 2;
            label2.Text = "Course Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(456, 97);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 3;
            label3.Text = "Course Type\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(74, 247);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 4;
            label4.Text = "Date of Birth";
            // 
            // cbocategory
            // 
            cbocategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbocategory.FlatStyle = FlatStyle.Popup;
            cbocategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbocategory.FormattingEnabled = true;
            cbocategory.Items.AddRange(new object[] { "Technical", "Non-Technical" });
            cbocategory.Location = new Point(228, 92);
            cbocategory.Name = "cbocategory";
            cbocategory.Size = new Size(164, 31);
            cbocategory.TabIndex = 5;
            cbocategory.SelectedIndexChanged += cbocategory_SelectedIndexChanged;
            cbocategory.ValueMemberChanged += cbocategory_ValueMemberChanged;
            // 
            // cboname
            // 
            cboname.DropDownStyle = ComboBoxStyle.DropDownList;
            cboname.FlatStyle = FlatStyle.Popup;
            cboname.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboname.FormattingEnabled = true;
            cboname.Location = new Point(228, 172);
            cboname.Name = "cboname";
            cboname.Size = new Size(164, 31);
            cboname.TabIndex = 6;
            cboname.SelectedIndexChanged += cboname_SelectedIndexChanged;
            // 
            // cbotype
            // 
            cbotype.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotype.FlatStyle = FlatStyle.Popup;
            cbotype.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbotype.FormattingEnabled = true;
            cbotype.Items.AddRange(new object[] { "Short Course", "Long Course" });
            cbotype.Location = new Point(593, 92);
            cbotype.Name = "cbotype";
            cbotype.Size = new Size(164, 31);
            cbotype.TabIndex = 7;
            cbotype.SelectedIndexChanged += cbotype_SelectedIndexChanged;
            // 
            // dtp
            // 
            dtp.Cursor = Cursors.Hand;
            dtp.CustomFormat = "dd-MM-yy";
            dtp.DropDownAlign = LeftRightAlignment.Right;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.Location = new Point(228, 247);
            dtp.MaxDate = new DateTime(2031, 1, 3, 0, 0, 0, 0);
            dtp.MinDate = new DateTime(1947, 1, 1, 0, 0, 0, 0);
            dtp.Name = "dtp";
            dtp.Size = new Size(164, 27);
            dtp.TabIndex = 8;
            dtp.Value = new DateTime(2025, 4, 29, 0, 0, 0, 0);
            dtp.ValueChanged += dtp_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(459, 187);
            label5.Name = "label5";
            label5.Size = new Size(101, 23);
            label5.TabIndex = 9;
            label5.Text = "Current age";
            // 
            // txtage
            // 
            txtage.BackColor = SystemColors.ControlLight;
            txtage.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtage.Location = new Point(593, 180);
            txtage.Name = "txtage";
            txtage.ReadOnly = true;
            txtage.Size = new Size(164, 30);
            txtage.TabIndex = 10;
            txtage.TextChanged += txtage_TextChanged;
            // 
            // Dgv
            // 
            Dgv.AllowUserToOrderColumns = true;
            Dgv.BackgroundColor = Color.AntiqueWhite;
            Dgv.BorderStyle = BorderStyle.Fixed3D;
            Dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            Dgv.Location = new Point(0, 382);
            Dgv.MultiSelect = false;
            Dgv.Name = "Dgv";
            Dgv.ReadOnly = true;
            Dgv.RowHeadersWidth = 51;
            Dgv.Size = new Size(838, 176);
            Dgv.TabIndex = 11;
            Dgv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnsubmit
            // 
            btnsubmit.Location = new Point(730, 304);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(94, 29);
            btnsubmit.TabIndex = 12;
            btnsubmit.Text = "Submit";
            btnsubmit.UseVisualStyleBackColor = true;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // btnselect
            // 
            btnselect.Location = new Point(613, 304);
            btnselect.Name = "btnselect";
            btnselect.Size = new Size(94, 29);
            btnselect.TabIndex = 13;
            btnselect.Text = "Refresh";
            btnselect.UseVisualStyleBackColor = true;
            btnselect.Click += btnselect_Click;
            // 
            // lbltitle
            // 
            lbltitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(298, -4);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(216, 37);
            lbltitle.TabIndex = 14;
            lbltitle.Text = "Course  Details";
            lbltitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(280, 316);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 29);
            btndelete.TabIndex = 15;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(12, 316);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(120, 29);
            btnclear.TabIndex = 16;
            btnclear.Text = "Clear Entries";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += button2_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(152, 316);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 29);
            btnupdate.TabIndex = 18;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // lblcheckname
            // 
            lblcheckname.AutoSize = true;
            lblcheckname.ForeColor = Color.Red;
            lblcheckname.Location = new Point(231, 205);
            lblcheckname.Name = "lblcheckname";
            lblcheckname.Size = new Size(0, 20);
            lblcheckname.TabIndex = 19;
            // 
            // lblcheckage1
            // 
            lblcheckage1.AutoSize = true;
            lblcheckage1.CausesValidation = false;
            lblcheckage1.ForeColor = Color.Red;
            lblcheckage1.Location = new Point(228, 281);
            lblcheckage1.Name = "lblcheckage1";
            lblcheckage1.Size = new Size(0, 20);
            lblcheckage1.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(lblx);
            panel1.Controls.Add(lbltitle);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 33);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // lblx
            // 
            lblx.AutoSize = true;
            lblx.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblx.ForeColor = Color.Red;
            lblx.Location = new Point(812, 5);
            lblx.Name = "lblx";
            lblx.Size = new Size(26, 28);
            lblx.TabIndex = 22;
            lblx.Text = "X";
            lblx.Click += lblx_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(838, 569);
            Controls.Add(panel1);
            Controls.Add(lblcheckage1);
            Controls.Add(lblcheckname);
            Controls.Add(btnupdate);
            Controls.Add(btnclear);
            Controls.Add(btndelete);
            Controls.Add(btnselect);
            Controls.Add(btnsubmit);
            Controls.Add(Dgv);
            Controls.Add(txtage);
            Controls.Add(label5);
            Controls.Add(dtp);
            Controls.Add(cbotype);
            Controls.Add(cboname);
            Controls.Add(cbocategory);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            Text = "Course Information";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)Dgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblcheckage_Click(object sender, EventArgs e)
        {
            
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbocategory;
        private ComboBox cboname;
        private ComboBox cbotype;
        private DateTimePicker dtp;
        private Label label5;
        private TextBox txtage;
        private DataGridView Dgv;
        private Button btnsubmit;
        private Button btnselect;
        private Label lbltitle;
        private Button btndelete;
        private Button btnclear;
        private Label lblcheckage;
        private Button btnupdate;
        private Label lblcheckname;
        private Label lblcheckage1;
        private Panel panel1;
        private Label lblx;
    }
}
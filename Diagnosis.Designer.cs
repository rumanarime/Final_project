namespace final
{
    partial class Diagnosis
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
            this.cmbwardtype = new System.Windows.Forms.ComboBox();
            this.cmbward = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtmedicine = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtdiagnosis = new System.Windows.Forms.TextBox();
            this.txtsymptoms = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbwardtype
            // 
            this.cmbwardtype.FormattingEnabled = true;
            this.cmbwardtype.Items.AddRange(new object[] {
            "General",
            "Duo",
            "Single",
            "None"});
            this.cmbwardtype.Location = new System.Drawing.Point(511, 341);
            this.cmbwardtype.Name = "cmbwardtype";
            this.cmbwardtype.Size = new System.Drawing.Size(99, 24);
            this.cmbwardtype.TabIndex = 46;
            // 
            // cmbward
            // 
            this.cmbward.FormattingEnabled = true;
            this.cmbward.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbward.Location = new System.Drawing.Point(511, 285);
            this.cmbward.Name = "cmbward";
            this.cmbward.Size = new System.Drawing.Size(99, 24);
            this.cmbward.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(582, 103);
            this.dataGridView1.TabIndex = 44;
            // 
            // txtmedicine
            // 
            this.txtmedicine.Location = new System.Drawing.Point(197, 385);
            this.txtmedicine.Name = "txtmedicine";
            this.txtmedicine.Size = new System.Drawing.Size(96, 22);
            this.txtmedicine.TabIndex = 43;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(306, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 22);
            this.textBox3.TabIndex = 42;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtdiagnosis
            // 
            this.txtdiagnosis.Location = new System.Drawing.Point(197, 336);
            this.txtdiagnosis.Name = "txtdiagnosis";
            this.txtdiagnosis.Size = new System.Drawing.Size(96, 22);
            this.txtdiagnosis.TabIndex = 41;
            // 
            // txtsymptoms
            // 
            this.txtsymptoms.Location = new System.Drawing.Point(197, 280);
            this.txtsymptoms.Name = "txtsymptoms";
            this.txtsymptoms.Size = new System.Drawing.Size(96, 22);
            this.txtsymptoms.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "type of ward";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "ward required";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "Medicine";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(62, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "Diagnosis";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(62, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "Symptoms";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(177, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Pid";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(161, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(366, 24);
            this.label17.TabIndex = 32;
            this.label17.Text = "Adding more information about patient";
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 521);
            this.Controls.Add(this.cmbwardtype);
            this.Controls.Add(this.cmbward);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtmedicine);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtdiagnosis);
            this.Controls.Add(this.txtsymptoms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Name = "Diagnosis";
            this.Text = "Diagnosis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbwardtype;
        private System.Windows.Forms.ComboBox cmbward;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmedicine;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtdiagnosis;
        private System.Windows.Forms.TextBox txtsymptoms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}
namespace QueryTicks
{
    partial class Form1
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
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.queryFrom = new System.Windows.Forms.TextBox();
            this.querySpan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.copyFrom = new System.Windows.Forms.Button();
            this.copySpan = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.addHourSpan = new System.Windows.Forms.NumericUpDown();
            this.hourSpan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addHourSpan)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(96, 15);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(96, 92);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 1;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // queryFrom
            // 
            this.queryFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.queryFrom.Location = new System.Drawing.Point(303, 15);
            this.queryFrom.Name = "queryFrom";
            this.queryFrom.ReadOnly = true;
            this.queryFrom.Size = new System.Drawing.Size(562, 20);
            this.queryFrom.TabIndex = 2;
            // 
            // querySpan
            // 
            this.querySpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.querySpan.Location = new System.Drawing.Point(303, 92);
            this.querySpan.Name = "querySpan";
            this.querySpan.ReadOnly = true;
            this.querySpan.Size = new System.Drawing.Size(562, 20);
            this.querySpan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "UTC DateFrom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "UTC DateTo";
            // 
            // copyFrom
            // 
            this.copyFrom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.copyFrom.Location = new System.Drawing.Point(871, 14);
            this.copyFrom.Name = "copyFrom";
            this.copyFrom.Size = new System.Drawing.Size(75, 23);
            this.copyFrom.TabIndex = 6;
            this.copyFrom.Text = "copy";
            this.copyFrom.UseVisualStyleBackColor = true;
            this.copyFrom.Click += new System.EventHandler(this.copyFrom_Click);
            // 
            // copySpan
            // 
            this.copySpan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.copySpan.Location = new System.Drawing.Point(871, 91);
            this.copySpan.Name = "copySpan";
            this.copySpan.Size = new System.Drawing.Size(75, 23);
            this.copySpan.TabIndex = 7;
            this.copySpan.Text = "copy";
            this.copySpan.UseVisualStyleBackColor = true;
            this.copySpan.Click += new System.EventHandler(this.copySpan_Click);
            // 
            // addHourSpan
            // 
            this.addHourSpan.Location = new System.Drawing.Point(176, 54);
            this.addHourSpan.Name = "addHourSpan";
            this.addHourSpan.Size = new System.Drawing.Size(120, 20);
            this.addHourSpan.TabIndex = 8;
            this.addHourSpan.ValueChanged += new System.EventHandler(this.addHourSpan_ValueChanged);
            // 
            // hourSpan
            // 
            this.hourSpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hourSpan.Location = new System.Drawing.Point(303, 54);
            this.hourSpan.Name = "hourSpan";
            this.hourSpan.ReadOnly = true;
            this.hourSpan.Size = new System.Drawing.Size(562, 20);
            this.hourSpan.TabIndex = 9;
            this.hourSpan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(871, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 128);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hourSpan);
            this.Controls.Add(this.addHourSpan);
            this.Controls.Add(this.copySpan);
            this.Controls.Add(this.copyFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.querySpan);
            this.Controls.Add(this.queryFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.addHourSpan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.TextBox queryFrom;
        private System.Windows.Forms.TextBox querySpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copyFrom;
        private System.Windows.Forms.Button copySpan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown addHourSpan;
        private System.Windows.Forms.TextBox hourSpan;
        private System.Windows.Forms.Button button1;
    }
}


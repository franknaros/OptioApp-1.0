namespace OptioApp
{
    partial class OptioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptioForm));
            this.adminlabel = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.productLabeltimer = new System.Windows.Forms.Timer(this.components);
            this.productLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminlabel
            // 
            this.adminlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adminlabel.AutoSize = true;
            this.adminlabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.adminlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adminlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.15584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminlabel.Location = new System.Drawing.Point(1701, 937);
            this.adminlabel.Margin = new System.Windows.Forms.Padding(3);
            this.adminlabel.Name = "adminlabel";
            this.adminlabel.Size = new System.Drawing.Size(98, 32);
            this.adminlabel.TabIndex = 0;
            this.adminlabel.Text = "ADMIN";
            this.adminlabel.Click += new System.EventHandler(this.adminlabel_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 84.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.White;
            this.mainLabel.Location = new System.Drawing.Point(275, 370);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainLabel.Size = new System.Drawing.Size(1251, 206);
            this.mainLabel.TabIndex = 3;
            this.mainLabel.Text = "Just say hello!";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainLabel.Click += new System.EventHandler(this.mainLabel_Click);
            // 
            // productLabeltimer
            // 
            this.productLabeltimer.Enabled = true;
            this.productLabeltimer.Interval = 25000;
            this.productLabeltimer.Tick += new System.EventHandler(this.productLabeltimer_Tick);
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productLabel.AutoSize = true;
            this.productLabel.BackColor = System.Drawing.Color.Transparent;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(901, 668);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(0, 117);
            this.productLabel.TabIndex = 4;
            this.productLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.productLabel.Click += new System.EventHandler(this.productLabel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.productLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.adminlabel, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1802, 972);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // OptioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1802, 972);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "OptioForm";
            this.Text = "OptioApp";
            this.Load += new System.EventHandler(this.OptioForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OptioForm_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OptioForm_MouseClick);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label adminlabel;
        public System.Windows.Forms.Label mainLabel;
        public System.Windows.Forms.Timer productLabeltimer;
        public System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
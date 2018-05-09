namespace OptioApp
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.labelprName = new System.Windows.Forms.Label();
            this.prNametextBox = new System.Windows.Forms.TextBox();
            this.prInfolabel = new System.Windows.Forms.Label();
            this.prInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.prLocationlabel = new System.Windows.Forms.Label();
            this.prLocationtextBox = new System.Windows.Forms.TextBox();
            this.prPricelabel = new System.Windows.Forms.Label();
            this.prPricetextBox = new System.Windows.Forms.TextBox();
            this.headerlabel = new System.Windows.Forms.Label();
            this.prSavebutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelprName
            // 
            this.labelprName.AutoSize = true;
            this.labelprName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprName.Location = new System.Drawing.Point(64, 159);
            this.labelprName.Name = "labelprName";
            this.labelprName.Size = new System.Drawing.Size(205, 30);
            this.labelprName.TabIndex = 0;
            this.labelprName.Text = "Product Name: ";
            // 
            // prNametextBox
            // 
            this.prNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.22078F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prNametextBox.Location = new System.Drawing.Point(358, 155);
            this.prNametextBox.Name = "prNametextBox";
            this.prNametextBox.Size = new System.Drawing.Size(745, 35);
            this.prNametextBox.TabIndex = 1;
            this.prNametextBox.TextChanged += new System.EventHandler(this.prNametextBox_TextChanged);
            // 
            // prInfolabel
            // 
            this.prInfolabel.AutoSize = true;
            this.prInfolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prInfolabel.Location = new System.Drawing.Point(64, 228);
            this.prInfolabel.Name = "prInfolabel";
            this.prInfolabel.Size = new System.Drawing.Size(262, 30);
            this.prInfolabel.TabIndex = 2;
            this.prInfolabel.Text = "Product Information:";
            // 
            // prInfoTextBox
            // 
            this.prInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.22078F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prInfoTextBox.Location = new System.Drawing.Point(358, 228);
            this.prInfoTextBox.Name = "prInfoTextBox";
            this.prInfoTextBox.Size = new System.Drawing.Size(745, 160);
            this.prInfoTextBox.TabIndex = 3;
            this.prInfoTextBox.Text = "";
            // 
            // prLocationlabel
            // 
            this.prLocationlabel.AutoSize = true;
            this.prLocationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prLocationlabel.Location = new System.Drawing.Point(64, 415);
            this.prLocationlabel.Name = "prLocationlabel";
            this.prLocationlabel.Size = new System.Drawing.Size(228, 30);
            this.prLocationlabel.TabIndex = 4;
            this.prLocationlabel.Text = "Product Location:";
            // 
            // prLocationtextBox
            // 
            this.prLocationtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.22078F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prLocationtextBox.Location = new System.Drawing.Point(358, 415);
            this.prLocationtextBox.Name = "prLocationtextBox";
            this.prLocationtextBox.Size = new System.Drawing.Size(745, 35);
            this.prLocationtextBox.TabIndex = 5;
            this.prLocationtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prLocationtextBox_KeyPress);
            // 
            // prPricelabel
            // 
            this.prPricelabel.AutoSize = true;
            this.prPricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.15584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prPricelabel.Location = new System.Drawing.Point(64, 499);
            this.prPricelabel.Name = "prPricelabel";
            this.prPricelabel.Size = new System.Drawing.Size(188, 30);
            this.prPricelabel.TabIndex = 6;
            this.prPricelabel.Text = "Product Price:";
            // 
            // prPricetextBox
            // 
            this.prPricetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.22078F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prPricetextBox.Location = new System.Drawing.Point(358, 499);
            this.prPricetextBox.Name = "prPricetextBox";
            this.prPricetextBox.Size = new System.Drawing.Size(745, 35);
            this.prPricetextBox.TabIndex = 7;
            // 
            // headerlabel
            // 
            this.headerlabel.AutoSize = true;
            this.headerlabel.Font = new System.Drawing.Font("Constantia", 20.1039F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerlabel.Location = new System.Drawing.Point(466, 32);
            this.headerlabel.Name = "headerlabel";
            this.headerlabel.Size = new System.Drawing.Size(332, 54);
            this.headerlabel.TabIndex = 8;
            this.headerlabel.Text = "OPTIO ADMIN";
            // 
            // prSavebutton
            // 
            this.prSavebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.02597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prSavebutton.Location = new System.Drawing.Point(829, 631);
            this.prSavebutton.Name = "prSavebutton";
            this.prSavebutton.Size = new System.Drawing.Size(274, 97);
            this.prSavebutton.TabIndex = 9;
            this.prSavebutton.Text = "Save Product";
            this.prSavebutton.UseVisualStyleBackColor = true;
            this.prSavebutton.Click += new System.EventHandler(this.prSavebutton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.02597F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(358, 631);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(274, 97);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1238, 869);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.prSavebutton);
            this.Controls.Add(this.headerlabel);
            this.Controls.Add(this.prPricetextBox);
            this.Controls.Add(this.prPricelabel);
            this.Controls.Add(this.prLocationtextBox);
            this.Controls.Add(this.prLocationlabel);
            this.Controls.Add(this.prInfoTextBox);
            this.Controls.Add(this.prInfolabel);
            this.Controls.Add(this.prNametextBox);
            this.Controls.Add(this.labelprName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelprName;
        private System.Windows.Forms.TextBox prNametextBox;
        private System.Windows.Forms.Label prInfolabel;
        private System.Windows.Forms.RichTextBox prInfoTextBox;
        private System.Windows.Forms.Label prLocationlabel;
        private System.Windows.Forms.TextBox prLocationtextBox;
        private System.Windows.Forms.Label prPricelabel;
        private System.Windows.Forms.TextBox prPricetextBox;
        private System.Windows.Forms.Label headerlabel;
        private System.Windows.Forms.Button prSavebutton;
        private System.Windows.Forms.Button exitButton;
    }
}
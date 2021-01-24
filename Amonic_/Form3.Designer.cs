namespace Amonic_
{
    partial class Form3
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
            this.add_user_AdminPage = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.changeRoleButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_user_AdminPage
            // 
            this.add_user_AdminPage.Font = new System.Drawing.Font("TeX Gyre Adventor", 10.8F, System.Drawing.FontStyle.Italic);
            this.add_user_AdminPage.Location = new System.Drawing.Point(13, 13);
            this.add_user_AdminPage.Name = "add_user_AdminPage";
            this.add_user_AdminPage.Size = new System.Drawing.Size(75, 34);
            this.add_user_AdminPage.TabIndex = 0;
            this.add_user_AdminPage.Text = "Add user";
            this.add_user_AdminPage.UseVisualStyleBackColor = true;
            this.add_user_AdminPage.Click += new System.EventHandler(this.add_user_AdminPage_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("TeX Gyre Adventor", 10.8F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(104, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TeX Gyre Adventor", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Office:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("TeX Gyre Adventor", 10.8F, System.Drawing.FontStyle.Italic);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 34);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(977, 351);
            this.dataGridView1.TabIndex = 4;
            // 
            // changeRoleButton
            // 
            this.changeRoleButton.Font = new System.Drawing.Font("TeX Gyre Adventor", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeRoleButton.Location = new System.Drawing.Point(17, 482);
            this.changeRoleButton.Name = "changeRoleButton";
            this.changeRoleButton.Size = new System.Drawing.Size(162, 34);
            this.changeRoleButton.TabIndex = 5;
            this.changeRoleButton.Text = "Change Role";
            this.changeRoleButton.UseVisualStyleBackColor = true;
            this.changeRoleButton.Click += new System.EventHandler(this.changeRoleButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("TeX Gyre Adventor", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(198, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "Enable/Disable Login";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 545);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.changeRoleButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_user_AdminPage);
            this.Name = "Form3";
            this.Text = "AMONIC Airlines Automation System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_user_AdminPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button changeRoleButton;
        private System.Windows.Forms.Button button3;
    }
}
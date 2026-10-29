namespace WindowsFormsApp_shahdkhaled
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
            this.customernamelabel = new System.Windows.Forms.Label();
            this.choosefoodlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.restaurantlabel = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.smallradioButton = new System.Windows.Forms.RadioButton();
            this.largeradioButton = new System.Windows.Forms.RadioButton();
            this.cheesecheckBox = new System.Windows.Forms.CheckBox();
            this.saucecheckBox = new System.Windows.Forms.CheckBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // customernamelabel
            // 
            this.customernamelabel.AutoSize = true;
            this.customernamelabel.Location = new System.Drawing.Point(111, 97);
            this.customernamelabel.Name = "customernamelabel";
            this.customernamelabel.Size = new System.Drawing.Size(99, 16);
            this.customernamelabel.TabIndex = 0;
            this.customernamelabel.Text = "customer name";
            // 
            // choosefoodlabel
            // 
            this.choosefoodlabel.AutoSize = true;
            this.choosefoodlabel.Location = new System.Drawing.Point(111, 143);
            this.choosefoodlabel.Name = "choosefoodlabel";
            this.choosefoodlabel.Size = new System.Drawing.Size(82, 16);
            this.choosefoodlabel.TabIndex = 1;
            this.choosefoodlabel.Text = "choose food";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "extras";
            // 
            // totallabel
            // 
            this.totallabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totallabel.Location = new System.Drawing.Point(392, 333);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(269, 78);
            this.totallabel.TabIndex = 4;
            this.totallabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restaurantlabel
            // 
            this.restaurantlabel.AutoSize = true;
            this.restaurantlabel.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantlabel.Location = new System.Drawing.Point(330, 30);
            this.restaurantlabel.Name = "restaurantlabel";
            this.restaurantlabel.Size = new System.Drawing.Size(163, 37);
            this.restaurantlabel.TabIndex = 5;
            this.restaurantlabel.Text = "restaurant";
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(607, 158);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 6;
            this.addbutton.Text = "add order";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "burger"});
            this.listBox1.Location = new System.Drawing.Point(252, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 7;
            // 
            // smallradioButton
            // 
            this.smallradioButton.AutoSize = true;
            this.smallradioButton.Location = new System.Drawing.Point(159, 272);
            this.smallradioButton.Name = "smallradioButton";
            this.smallradioButton.Size = new System.Drawing.Size(60, 20);
            this.smallradioButton.TabIndex = 8;
            this.smallradioButton.TabStop = true;
            this.smallradioButton.Text = "small";
            this.smallradioButton.UseVisualStyleBackColor = true;
            // 
            // largeradioButton
            // 
            this.largeradioButton.AutoSize = true;
            this.largeradioButton.Location = new System.Drawing.Point(328, 276);
            this.largeradioButton.Name = "largeradioButton";
            this.largeradioButton.Size = new System.Drawing.Size(59, 20);
            this.largeradioButton.TabIndex = 9;
            this.largeradioButton.TabStop = true;
            this.largeradioButton.Text = "large";
            this.largeradioButton.UseVisualStyleBackColor = true;
            // 
            // cheesecheckBox
            // 
            this.cheesecheckBox.AutoSize = true;
            this.cheesecheckBox.Location = new System.Drawing.Point(114, 354);
            this.cheesecheckBox.Name = "cheesecheckBox";
            this.cheesecheckBox.Size = new System.Drawing.Size(74, 20);
            this.cheesecheckBox.TabIndex = 10;
            this.cheesecheckBox.Text = "cheese";
            this.cheesecheckBox.UseVisualStyleBackColor = true;
            // 
            // saucecheckBox
            // 
            this.saucecheckBox.AutoSize = true;
            this.saucecheckBox.Location = new System.Drawing.Point(277, 354);
            this.saucecheckBox.Name = "saucecheckBox";
            this.saucecheckBox.Size = new System.Drawing.Size(66, 20);
            this.saucecheckBox.TabIndex = 11;
            this.saucecheckBox.Text = "sauce";
            this.saucecheckBox.UseVisualStyleBackColor = true;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(277, 97);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 22);
            this.nametextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.saucecheckBox);
            this.Controls.Add(this.cheesecheckBox);
            this.Controls.Add(this.largeradioButton);
            this.Controls.Add(this.smallradioButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.restaurantlabel);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.choosefoodlabel);
            this.Controls.Add(this.customernamelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customernamelabel;
        private System.Windows.Forms.Label choosefoodlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label restaurantlabel;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton smallradioButton;
        private System.Windows.Forms.RadioButton largeradioButton;
        private System.Windows.Forms.CheckBox cheesecheckBox;
        private System.Windows.Forms.CheckBox saucecheckBox;
        private System.Windows.Forms.TextBox nametextBox;
    }
}


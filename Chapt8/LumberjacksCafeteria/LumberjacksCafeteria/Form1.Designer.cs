namespace LumberjacksCafeteria
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
            this.label1 = new System.Windows.Forms.Label();
            this.addFlapjacks = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.addLumberjack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.banana = new System.Windows.Forms.RadioButton();
            this.nextInLine = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lumberjack name";
            // 
            // addFlapjacks
            // 
            this.addFlapjacks.Location = new System.Drawing.Point(7, 160);
            this.addFlapjacks.Name = "addFlapjacks";
            this.addFlapjacks.Size = new System.Drawing.Size(187, 29);
            this.addFlapjacks.TabIndex = 1;
            this.addFlapjacks.Text = "Add flapjacks";
            this.addFlapjacks.UseVisualStyleBackColor = true;
            this.addFlapjacks.Click += new System.EventHandler(this.addFlapjacks_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(139, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(183, 22);
            this.name.TabIndex = 2;
            // 
            // addLumberjack
            // 
            this.addLumberjack.Location = new System.Drawing.Point(16, 47);
            this.addLumberjack.Name = "addLumberjack";
            this.addLumberjack.Size = new System.Drawing.Size(306, 31);
            this.addLumberjack.TabIndex = 3;
            this.addLumberjack.Text = "Add lumberjack";
            this.addLumberjack.UseVisualStyleBackColor = true;
            this.addLumberjack.Click += new System.EventHandler(this.addLumberjack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Breakfast line";
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.ItemHeight = 16;
            this.line.Location = new System.Drawing.Point(19, 142);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(156, 292);
            this.line.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.nextInLine);
            this.groupBox1.Controls.Add(this.banana);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Controls.Add(this.addFlapjacks);
            this.groupBox1.Location = new System.Drawing.Point(181, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 342);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a Lumberjack";
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(6, 23);
            this.howMany.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.howMany.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(120, 22);
            this.howMany.TabIndex = 2;
            this.howMany.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(7, 52);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(68, 21);
            this.crispy.TabIndex = 3;
            this.crispy.TabStop = true;
            this.crispy.Text = "Crispy";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(7, 79);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(69, 21);
            this.soggy.TabIndex = 4;
            this.soggy.TabStop = true;
            this.soggy.Text = "Soggy";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(7, 106);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(84, 21);
            this.browned.TabIndex = 5;
            this.browned.TabStop = true;
            this.browned.Text = "Browned";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Location = new System.Drawing.Point(7, 133);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(78, 21);
            this.banana.TabIndex = 6;
            this.banana.TabStop = true;
            this.banana.Text = "Banana";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // nextInLine
            // 
            this.nextInLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nextInLine.Location = new System.Drawing.Point(7, 196);
            this.nextInLine.Name = "nextInLine";
            this.nextInLine.Size = new System.Drawing.Size(187, 72);
            this.nextInLine.TabIndex = 7;
            this.nextInLine.Text = "Lumberjack status";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "Next Lumberjack";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addLumberjack);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Breakfast for Lumberjacks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addFlapjacks;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button addLumberjack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label nextInLine;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.NumericUpDown howMany;
    }
}


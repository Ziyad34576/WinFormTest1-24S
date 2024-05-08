namespace Ziyad_Aljuaid_703
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            t1 = new TextBox();
            t4 = new TextBox();
            t2 = new TextBox();
            t3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 14.25F);
            button1.Location = new Point(110, 93);
            button1.Name = "button1";
            button1.Size = new Size(261, 39);
            button1.TabIndex = 0;
            button1.Text = "دور في اتجاه عقارب الساعة";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 14.25F);
            button2.Location = new Point(110, 151);
            button2.Name = "button2";
            button2.Size = new Size(261, 39);
            button2.TabIndex = 1;
            button2.Text = "دور عكس اتجاه عقارب الساعة";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // t1
            // 
            t1.Font = new Font("Segoe UI", 14.25F);
            t1.Location = new Point(46, 21);
            t1.Name = "t1";
            t1.Size = new Size(100, 33);
            t1.TabIndex = 2;
            // 
            // t4
            // 
            t4.Font = new Font("Segoe UI", 14.25F);
            t4.Location = new Point(46, 223);
            t4.Name = "t4";
            t4.Size = new Size(100, 33);
            t4.TabIndex = 3;
            // 
            // t2
            // 
            t2.Font = new Font("Segoe UI", 14.25F);
            t2.Location = new Point(328, 21);
            t2.Name = "t2";
            t2.Size = new Size(100, 33);
            t2.TabIndex = 4;
            // 
            // t3
            // 
            t3.Font = new Font("Segoe UI", 14.25F);
            t3.Location = new Point(328, 223);
            t3.Name = "t3";
            t3.Size = new Size(100, 33);
            t3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 289);
            Controls.Add(t3);
            Controls.Add(t2);
            Controls.Add(t4);
            Controls.Add(t1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox t1;
        private TextBox t4;
        private TextBox t2;
        private TextBox t3;
    }
}

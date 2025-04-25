namespace registerPage
{
    partial class signup
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
            this.signupButton = new System.Windows.Forms.Button();
            this.passTextbox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.registerlabel = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maleradio = new System.Windows.Forms.RadioButton();
            this.femaleradio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // signupButton
            // 
            this.signupButton.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.Location = new System.Drawing.Point(142, 266);
            this.signupButton.Margin = new System.Windows.Forms.Padding(2);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(149, 32);
            this.signupButton.TabIndex = 13;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // passTextbox
            // 
            this.passTextbox.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextbox.Location = new System.Drawing.Point(124, 106);
            this.passTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.passTextbox.Name = "passTextbox";
            this.passTextbox.Size = new System.Drawing.Size(238, 27);
            this.passTextbox.TabIndex = 11;
            this.passTextbox.UseSystemPasswordChar = true;
            this.passTextbox.TextChanged += new System.EventHandler(this.passTextbox_TextChanged);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(15, 113);
            this.passLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(72, 19);
            this.passLabel.TabIndex = 10;
            this.passLabel.Text = "Password";
            this.passLabel.Click += new System.EventHandler(this.passLabel_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(15, 75);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 19);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // registerlabel
            // 
            this.registerlabel.AutoSize = true;
            this.registerlabel.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerlabel.Location = new System.Drawing.Point(185, 20);
            this.registerlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerlabel.Name = "registerlabel";
            this.registerlabel.Size = new System.Drawing.Size(93, 29);
            this.registerlabel.TabIndex = 8;
            this.registerlabel.Text = "Sign Up";
            this.registerlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.Location = new System.Drawing.Point(124, 68);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(238, 27);
            this.emailTextbox.TabIndex = 7;
            this.emailTextbox.TextChanged += new System.EventHandler(this.emailTextbox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(124, 144);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 27);
            this.textBox1.TabIndex = 15;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Confirm Password";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // maleradio
            // 
            this.maleradio.AutoSize = true;
            this.maleradio.Location = new System.Drawing.Point(142, 209);
            this.maleradio.Name = "maleradio";
            this.maleradio.Size = new System.Drawing.Size(48, 17);
            this.maleradio.TabIndex = 16;
            this.maleradio.TabStop = true;
            this.maleradio.Text = "Male";
            this.maleradio.UseVisualStyleBackColor = true;
            // 
            // femaleradio
            // 
            this.femaleradio.AutoSize = true;
            this.femaleradio.Location = new System.Drawing.Point(232, 209);
            this.femaleradio.Name = "femaleradio";
            this.femaleradio.Size = new System.Drawing.Size(59, 17);
            this.femaleradio.TabIndex = 17;
            this.femaleradio.TabStop = true;
            this.femaleradio.Text = "Female";
            this.femaleradio.UseVisualStyleBackColor = true;
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 416);
            this.Controls.Add(this.femaleradio);
            this.Controls.Add(this.maleradio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.passTextbox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.registerlabel);
            this.Controls.Add(this.emailTextbox);
            this.Name = "signup";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.TextBox passTextbox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label registerlabel;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton maleradio;
        private System.Windows.Forms.RadioButton femaleradio;
    }
}


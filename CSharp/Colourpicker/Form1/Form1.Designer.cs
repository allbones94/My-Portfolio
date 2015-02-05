namespace Form1
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
            this.btn_HelloWorld = new System.Windows.Forms.Button();
            this.tb_green = new System.Windows.Forms.TrackBar();
            this.tb_blue = new System.Windows.Forms.TrackBar();
            this.tb_red = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_red)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_HelloWorld
            // 
            this.btn_HelloWorld.Location = new System.Drawing.Point(331, 223);
            this.btn_HelloWorld.Name = "btn_HelloWorld";
            this.btn_HelloWorld.Size = new System.Drawing.Size(145, 42);
            this.btn_HelloWorld.TabIndex = 1;
            this.btn_HelloWorld.Text = "Click me";
            this.btn_HelloWorld.UseVisualStyleBackColor = true;
            this.btn_HelloWorld.Click += new System.EventHandler(this.btn_HelloWorld_Click);
            // 
            // tb_green
            // 
            this.tb_green.Location = new System.Drawing.Point(127, 105);
            this.tb_green.Maximum = 255;
            this.tb_green.Name = "tb_green";
            this.tb_green.Size = new System.Drawing.Size(255, 45);
            this.tb_green.TabIndex = 2;
            this.tb_green.Scroll += new System.EventHandler(this.tb_green_Scroll);
            // 
            // tb_blue
            // 
            this.tb_blue.Location = new System.Drawing.Point(127, 149);
            this.tb_blue.Maximum = 255;
            this.tb_blue.Name = "tb_blue";
            this.tb_blue.Size = new System.Drawing.Size(255, 45);
            this.tb_blue.TabIndex = 3;
            this.tb_blue.Scroll += new System.EventHandler(this.tb_blue_Scroll);
            // 
            // tb_red
            // 
            this.tb_red.Location = new System.Drawing.Point(127, 63);
            this.tb_red.Maximum = 255;
            this.tb_red.Name = "tb_red";
            this.tb_red.Size = new System.Drawing.Size(255, 45);
            this.tb_red.TabIndex = 4;
            this.tb_red.Scroll += new System.EventHandler(this.tb_red_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(509, 286);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_red);
            this.Controls.Add(this.tb_blue);
            this.Controls.Add(this.tb_green);
            this.Controls.Add(this.btn_HelloWorld);
            this.Name = "Form1";
            this.Text = "Hello World!!!!!!!!!";
            ((System.ComponentModel.ISupportInitialize)(this.tb_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HelloWorld;
        private System.Windows.Forms.TrackBar tb_green;
        private System.Windows.Forms.TrackBar tb_blue;
        private System.Windows.Forms.TrackBar tb_red;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


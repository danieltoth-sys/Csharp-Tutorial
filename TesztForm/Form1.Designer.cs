namespace TesztForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ifgreat = new System.Windows.Forms.Button();
            this.ifless = new System.Windows.Forms.Button();
            this.newgame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pontszámod: 0";
            // 
            // ifgreat
            // 
            this.ifgreat.Location = new System.Drawing.Point(122, 402);
            this.ifgreat.Name = "ifgreat";
            this.ifgreat.Size = new System.Drawing.Size(179, 68);
            this.ifgreat.TabIndex = 2;
            this.ifgreat.Text = "nagyobb";
            this.ifgreat.UseVisualStyleBackColor = true;
            this.ifgreat.Click += new System.EventHandler(this.ifgreat_Click);
            // 
            // ifless
            // 
            this.ifless.Location = new System.Drawing.Point(495, 402);
            this.ifless.Name = "ifless";
            this.ifless.Size = new System.Drawing.Size(179, 68);
            this.ifless.TabIndex = 3;
            this.ifless.Text = "kisebb";
            this.ifless.UseVisualStyleBackColor = true;
            this.ifless.Click += new System.EventHandler(this.ifless_Click);
            // 
            // newgame
            // 
            this.newgame.Location = new System.Drawing.Point(299, 579);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(179, 68);
            this.newgame.TabIndex = 4;
            this.newgame.Text = "Új játék";
            this.newgame.UseVisualStyleBackColor = true;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(356, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Szám";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.ifless);
            this.Controls.Add(this.ifgreat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button ifgreat;
        private Button ifless;
        private Button newgame;
        private Label label2;
    }
}
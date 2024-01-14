
namespace WindowsFormsApp1
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
            this.lbFormSize = new System.Windows.Forms.Label();
            this.bbnEvo = new System.Windows.Forms.Button();
            this.เกมทอยลูกเต๋า = new System.Windows.Forms.Label();
            this.เต๋า1 = new System.Windows.Forms.PictureBox();
            this.เต๋า2 = new System.Windows.Forms.PictureBox();
            this.หมุน = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.เต๋า1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.เต๋า2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFormSize
            // 
            this.lbFormSize.AutoSize = true;
            this.lbFormSize.BackColor = System.Drawing.Color.Bisque;
            this.lbFormSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormSize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbFormSize.Location = new System.Drawing.Point(12, 627);
            this.lbFormSize.Name = "lbFormSize";
            this.lbFormSize.Size = new System.Drawing.Size(120, 25);
            this.lbFormSize.TabIndex = 0;
            this.lbFormSize.Text = "lbFormSize";
            this.lbFormSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbFormSize.Click += new System.EventHandler(this.label1_Click);
            // 
            // bbnEvo
            // 
            this.bbnEvo.Location = new System.Drawing.Point(203, 626);
            this.bbnEvo.Name = "bbnEvo";
            this.bbnEvo.Size = new System.Drawing.Size(75, 23);
            this.bbnEvo.TabIndex = 2;
            this.bbnEvo.Text = "แปลงร่าง";
            this.bbnEvo.UseVisualStyleBackColor = true;
            this.bbnEvo.Click += new System.EventHandler(this.button2_Click);
            // 
            // เกมทอยลูกเต๋า
            // 
            this.เกมทอยลูกเต๋า.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.เกมทอยลูกเต๋า.AutoSize = true;
            this.เกมทอยลูกเต๋า.BackColor = System.Drawing.SystemColors.Control;
            this.เกมทอยลูกเต๋า.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.เกมทอยลูกเต๋า.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.เกมทอยลูกเต๋า.Location = new System.Drawing.Point(402, 9);
            this.เกมทอยลูกเต๋า.Name = "เกมทอยลูกเต๋า";
            this.เกมทอยลูกเต๋า.Size = new System.Drawing.Size(161, 33);
            this.เกมทอยลูกเต๋า.TabIndex = 3;
            this.เกมทอยลูกเต๋า.Text = "เกมทอยลูกเต๋า";
            this.เกมทอยลูกเต๋า.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.เกมทอยลูกเต๋า.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // เต๋า1
            // 
            this.เต๋า1.Image = global::WindowsFormsApp1.Properties.Resources.dice1;
            this.เต๋า1.Location = new System.Drawing.Point(108, 175);
            this.เต๋า1.Name = "เต๋า1";
            this.เต๋า1.Size = new System.Drawing.Size(200, 200);
            this.เต๋า1.TabIndex = 5;
            this.เต๋า1.TabStop = false;
            this.เต๋า1.Click += new System.EventHandler(this.เต๋า1_Click);
            // 
            // เต๋า2
            // 
            this.เต๋า2.Image = global::WindowsFormsApp1.Properties.Resources.dice1;
            this.เต๋า2.Location = new System.Drawing.Point(664, 175);
            this.เต๋า2.Name = "เต๋า2";
            this.เต๋า2.Size = new System.Drawing.Size(200, 200);
            this.เต๋า2.TabIndex = 6;
            this.เต๋า2.TabStop = false;
            this.เต๋า2.Click += new System.EventHandler(this.เต๋า2_Click);
            // 
            // หมุน
            // 
            this.หมุน.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.หมุน.Location = new System.Drawing.Point(402, 488);
            this.หมุน.Name = "หมุน";
            this.หมุน.Size = new System.Drawing.Size(150, 75);
            this.หมุน.TabIndex = 7;
            this.หมุน.Text = "หมุน";
            this.หมุน.UseVisualStyleBackColor = true;
            this.หมุน.Click += new System.EventHandler(this.button1_Click);
            this.หมุน.MouseDown += new System.Windows.Forms.MouseEventHandler(this.หมุน_MouseDown);
            this.หมุน.MouseLeave += new System.EventHandler(this.หมุน_MouseLeave);
            this.หมุน.MouseHover += new System.EventHandler(this.หมุน_MouseHover);
            this.หมุน.MouseUp += new System.Windows.Forms.MouseEventHandler(this.หมุน_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.หมุน);
            this.Controls.Add(this.เต๋า2);
            this.Controls.Add(this.เต๋า1);
            this.Controls.Add(this.เกมทอยลูกเต๋า);
            this.Controls.Add(this.bbnEvo);
            this.Controls.Add(this.lbFormSize);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ลูกเต๋า";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.เต๋า1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.เต๋า2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFormSize;
        private System.Windows.Forms.Button bbnEvo;
        private System.Windows.Forms.Label เกมทอยลูกเต๋า;
        private System.Windows.Forms.PictureBox เต๋า1;
        private System.Windows.Forms.PictureBox เต๋า2;
        private System.Windows.Forms.Button หมุน;
        private System.Windows.Forms.Label label1;
    }
}


namespace _024_scrollBar
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.red = new System.Windows.Forms.Label();
            this.scrG = new System.Windows.Forms.HScrollBar();
            this.scrR = new System.Windows.Forms.HScrollBar();
            this.blue = new System.Windows.Forms.Label();
            this.scrB = new System.Windows.Forms.HScrollBar();
            this.green = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(71, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 145);
            this.panel1.TabIndex = 0;
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(83, 241);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(39, 18);
            this.red.TabIndex = 1;
            this.red.Text = "Red";
            // 
            // scrG
            // 
            this.scrG.Location = new System.Drawing.Point(170, 284);
            this.scrG.Name = "scrG";
            this.scrG.Size = new System.Drawing.Size(418, 26);
            this.scrG.TabIndex = 2;
            this.scrG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // scrR
            // 
            this.scrR.Location = new System.Drawing.Point(170, 230);
            this.scrR.Name = "scrR";
            this.scrR.Size = new System.Drawing.Size(418, 29);
            this.scrR.TabIndex = 4;
            this.scrR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(83, 339);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(42, 18);
            this.blue.TabIndex = 3;
            this.blue.Text = "Blue";
            // 
            // scrB
            // 
            this.scrB.Location = new System.Drawing.Point(169, 339);
            this.scrB.Name = "scrB";
            this.scrB.Size = new System.Drawing.Size(419, 26);
            this.scrB.TabIndex = 6;
            this.scrB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.Location = new System.Drawing.Point(83, 292);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(56, 18);
            this.green.TabIndex = 5;
            this.green.Text = "Green";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(634, 231);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 28);
            this.txtR.TabIndex = 7;
            this.txtR.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(634, 349);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 28);
            this.txtB.TabIndex = 8;
            this.txtB.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(635, 294);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 28);
            this.txtG.TabIndex = 9;
            this.txtG.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.scrB);
            this.Controls.Add(this.green);
            this.Controls.Add(this.scrR);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.scrG);
            this.Controls.Add(this.red);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label red;
        private System.Windows.Forms.HScrollBar scrG;
        private System.Windows.Forms.HScrollBar scrR;
        private System.Windows.Forms.Label blue;
        private System.Windows.Forms.HScrollBar scrB;
        private System.Windows.Forms.Label green;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtG;
    }
}


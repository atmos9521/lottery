
namespace lottery
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lottery_btn = new System.Windows.Forms.Button();
            this.roulettePictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roulettePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lottery_btn
            // 
            this.lottery_btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lottery_btn.Location = new System.Drawing.Point(79, 272);
            this.lottery_btn.Name = "lottery_btn";
            this.lottery_btn.Size = new System.Drawing.Size(196, 56);
            this.lottery_btn.TabIndex = 0;
            this.lottery_btn.Text = "抽籤";
            this.lottery_btn.UseVisualStyleBackColor = true;
            this.lottery_btn.Click += new System.EventHandler(this.lottery_btn_Click);
            // 
            // roulettePictureBox
            // 
            this.roulettePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("roulettePictureBox.Image")));
            this.roulettePictureBox.Location = new System.Drawing.Point(79, 24);
            this.roulettePictureBox.Name = "roulettePictureBox";
            this.roulettePictureBox.Size = new System.Drawing.Size(284, 222);
            this.roulettePictureBox.TabIndex = 1;
            this.roulettePictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 374);
            this.Controls.Add(this.roulettePictureBox);
            this.Controls.Add(this.lottery_btn);
            this.Name = "Form1";
            this.Text = "lottery";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roulettePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lottery_btn;
        private System.Windows.Forms.PictureBox roulettePictureBox;
        private System.Windows.Forms.Timer timer1;
    }
}


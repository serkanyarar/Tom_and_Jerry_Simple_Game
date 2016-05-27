namespace tom_and_jerry
{
    partial class frmGame
    {
        /// <summary>
        ///Gerekli designer değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        ///Designer desteği için gerekli metottur; bu metodun
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.timerSure = new System.Windows.Forms.Timer(this.components);
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.timerTom = new System.Windows.Forms.Timer(this.components);
            this.btnTom = new System.Windows.Forms.Button();
            this.btnOyuncu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerSure
            // 
            this.timerSure.Interval = 1000;
            this.timerSure.Tick += new System.EventHandler(this.timerSure_Tick);
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPuan.Location = new System.Drawing.Point(368, 7);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(82, 26);
            this.lblPuan.TabIndex = 1;
            this.lblPuan.Text = "Puan : 0";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.Color.Red;
            this.lblSure.Location = new System.Drawing.Point(12, 7);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(49, 23);
            this.lblSure.TabIndex = 2;
            this.lblSure.Text = "0 SN";
            // 
            // timerTom
            // 
            this.timerTom.Interval = 3000;
            this.timerTom.Tick += new System.EventHandler(this.timerTom_Tick);
            // 
            // btnTom
            // 
            this.btnTom.BackColor = System.Drawing.Color.Transparent;
            this.btnTom.FlatAppearance.BorderSize = 0;
            this.btnTom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTom.Image = ((System.Drawing.Image)(resources.GetObject("btnTom.Image")));
            this.btnTom.Location = new System.Drawing.Point(16, 51);
            this.btnTom.Name = "btnTom";
            this.btnTom.Size = new System.Drawing.Size(100, 133);
            this.btnTom.TabIndex = 3;
            this.btnTom.UseVisualStyleBackColor = false;
            // 
            // btnOyuncu
            // 
            this.btnOyuncu.FlatAppearance.BorderSize = 0;
            this.btnOyuncu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOyuncu.Image = ((System.Drawing.Image)(resources.GetObject("btnOyuncu.Image")));
            this.btnOyuncu.Location = new System.Drawing.Point(204, 399);
            this.btnOyuncu.Name = "btnOyuncu";
            this.btnOyuncu.Size = new System.Drawing.Size(64, 50);
            this.btnOyuncu.TabIndex = 0;
            this.btnOyuncu.UseVisualStyleBackColor = true;
            this.btnOyuncu.LocationChanged += new System.EventHandler(this.btnOyuncu_LocationChanged);
            this.btnOyuncu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnOyuncu_KeyPress);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 484);
            this.ControlBox = false;
            this.Controls.Add(this.btnTom);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.btnOyuncu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOyuncu;
        private System.Windows.Forms.Timer timerSure;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer timerTom;
        private System.Windows.Forms.Button btnTom;
    }
}


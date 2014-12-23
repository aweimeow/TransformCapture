namespace TransformCapture
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Capture = new System.Windows.Forms.Button();
            this.Btn_End = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Capture
            // 
            this.Btn_Capture.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Capture.Location = new System.Drawing.Point(12, 12);
            this.Btn_Capture.Name = "Btn_Capture";
            this.Btn_Capture.Size = new System.Drawing.Size(153, 177);
            this.Btn_Capture.TabIndex = 0;
            this.Btn_Capture.Text = "Capture";
            this.Btn_Capture.UseVisualStyleBackColor = true;
            this.Btn_Capture.Click += new System.EventHandler(this.Btn_Capture_Click);
            // 
            // Btn_End
            // 
            this.Btn_End.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_End.Location = new System.Drawing.Point(236, 12);
            this.Btn_End.Name = "Btn_End";
            this.Btn_End.Size = new System.Drawing.Size(147, 177);
            this.Btn_End.TabIndex = 1;
            this.Btn_End.Text = "End";
            this.Btn_End.UseVisualStyleBackColor = true;
            this.Btn_End.Click += new System.EventHandler(this.Btn_End_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 201);
            this.Controls.Add(this.Btn_End);
            this.Controls.Add(this.Btn_Capture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Capture;
        private System.Windows.Forms.Button Btn_End;
    }
}


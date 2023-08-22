namespace opencv_OCR
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
            this.comboBox_camera_list = new System.Windows.Forms.ComboBox();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.button_ocr = new System.Windows.Forms.Button();
            this.label_output_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_camera_list
            // 
            this.comboBox_camera_list.FormattingEnabled = true;
            this.comboBox_camera_list.Items.AddRange(new object[] {
            "USB Webcam",
            "Select Image"});
            this.comboBox_camera_list.Location = new System.Drawing.Point(24, 24);
            this.comboBox_camera_list.Name = "comboBox_camera_list";
            this.comboBox_camera_list.Size = new System.Drawing.Size(237, 20);
            this.comboBox_camera_list.TabIndex = 0;
            this.comboBox_camera_list.SelectedIndexChanged += new System.EventHandler(this.comboBox_camera_list_SelectedIndexChanged);
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Location = new System.Drawing.Point(24, 62);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(237, 182);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_image.TabIndex = 1;
            this.pictureBox_image.TabStop = false;
            // 
            // button_ocr
            // 
            this.button_ocr.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ocr.Location = new System.Drawing.Point(24, 277);
            this.button_ocr.Name = "button_ocr";
            this.button_ocr.Size = new System.Drawing.Size(237, 36);
            this.button_ocr.TabIndex = 2;
            this.button_ocr.Text = "OCR";
            this.button_ocr.UseVisualStyleBackColor = true;
            this.button_ocr.Click += new System.EventHandler(this.button_ocr_Click);
            // 
            // label_output_text
            // 
            this.label_output_text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_output_text.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_output_text.Location = new System.Drawing.Point(296, 24);
            this.label_output_text.Name = "label_output_text";
            this.label_output_text.Size = new System.Drawing.Size(331, 289);
            this.label_output_text.TabIndex = 3;
            this.label_output_text.Text = "OCR Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 359);
            this.Controls.Add(this.label_output_text);
            this.Controls.Add(this.button_ocr);
            this.Controls.Add(this.pictureBox_image);
            this.Controls.Add(this.comboBox_camera_list);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_camera_list;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.Button button_ocr;
        private System.Windows.Forms.Label label_output_text;
    }
}


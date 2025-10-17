namespace WindowsFormFiles
{
    partial class MainForm
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
            BtnSelectFile = new Button();
            txtSelectFile = new TextBox();
            label1 = new Label();
            pbImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // BtnSelectFile
            // 
            BtnSelectFile.Location = new Point(2, 12);
            BtnSelectFile.Name = "BtnSelectFile";
            BtnSelectFile.Size = new Size(140, 52);
            BtnSelectFile.TabIndex = 0;
            BtnSelectFile.Text = "Select Photo";
            BtnSelectFile.UseVisualStyleBackColor = true;
            BtnSelectFile.Click += BtnSelectFile_Click;
            // 
            // txtSelectFile
            // 
            txtSelectFile.Location = new Point(2, 70);
            txtSelectFile.Name = "txtSelectFile";
            txtSelectFile.Size = new Size(786, 23);
            txtSelectFile.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(718, 96);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "Ваше Фото";
            // 
            // pbImage
            // 
            pbImage.Location = new Point(2, 99);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(505, 362);
            pbImage.TabIndex = 3;
            pbImage.TabStop = false;
            pbImage.Click += pictureBox1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 473);
            Controls.Add(pbImage);
            Controls.Add(label1);
            Controls.Add(txtSelectFile);
            Controls.Add(BtnSelectFile);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSelectFile;
        private TextBox txtSelectFile;
        private Label label1;
        private PictureBox pbImage;
    }
}

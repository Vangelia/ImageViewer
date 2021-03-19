
namespace ImageViewerTrue
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.brightness = new System.Windows.Forms.TrackBar();
            this.trransparency = new System.Windows.Forms.TrackBar();
            this.shadesOfGrey = new System.Windows.Forms.TrackBar();
            this.pathList = new System.Windows.Forms.ListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trransparency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadesOfGrey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChangeImageButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChangeImageButtonClick);
            // 
            // brightness
            // 
            this.brightness.Location = new System.Drawing.Point(588, 138);
            this.brightness.Name = "brightness";
            this.brightness.Size = new System.Drawing.Size(104, 56);
            this.brightness.TabIndex = 2;
            this.brightness.Scroll += new System.EventHandler(this.ChangeBrightness);
            // 
            // trransparency
            // 
            this.trransparency.Location = new System.Drawing.Point(588, 200);
            this.trransparency.Name = "trransparency";
            this.trransparency.Size = new System.Drawing.Size(104, 56);
            this.trransparency.TabIndex = 3;
            this.trransparency.Scroll += new System.EventHandler(this.ChangeTransparency);
            // 
            // shadesOfGrey
            // 
            this.shadesOfGrey.Location = new System.Drawing.Point(588, 262);
            this.shadesOfGrey.Name = "shadesOfGrey";
            this.shadesOfGrey.Size = new System.Drawing.Size(104, 56);
            this.shadesOfGrey.TabIndex = 4;
   
            // 
            // pathList
            // 
            this.pathList.FormattingEnabled = true;
            this.pathList.ItemHeight = 16;
            this.pathList.Location = new System.Drawing.Point(26, 81);
            this.pathList.Name = "pathList";
            this.pathList.Size = new System.Drawing.Size(256, 292);
            this.pathList.TabIndex = 5;
            this.pathList.SelectedIndexChanged += new System.EventHandler(this.pathList_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(306, 86);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(232, 287);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "folderButton";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.pathList);
            this.Controls.Add(this.shadesOfGrey);
            this.Controls.Add(this.trransparency);
            this.Controls.Add(this.brightness);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trransparency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shadesOfGrey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar brightness;
        private System.Windows.Forms.TrackBar trransparency;
        private System.Windows.Forms.TrackBar shadesOfGrey;
        private System.Windows.Forms.ListBox pathList;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button3;
    }
}


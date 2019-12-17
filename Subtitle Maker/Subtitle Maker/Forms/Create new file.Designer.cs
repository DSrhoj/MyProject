namespace Subtitle_Maker.Forms
{
    partial class CreateNewFile
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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelError1 = new System.Windows.Forms.Label();
            this.labelError2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 46);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(297, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(315, 44);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 1;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(12, 23);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(257, 20);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Select the path for your new .srt file";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(217, 154);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancle
            // 
            this.buttonCancle.Location = new System.Drawing.Point(315, 154);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(75, 23);
            this.buttonCancle.TabIndex = 4;
            this.buttonCancle.Text = "Cancle";
            this.buttonCancle.UseVisualStyleBackColor = true;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo2.Location = new System.Drawing.Point(12, 97);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(234, 20);
            this.labelInfo2.TabIndex = 5;
            this.labelInfo2.Text = "Insert name for your new .srt file";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 120);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(297, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // labelError1
            // 
            this.labelError1.AutoSize = true;
            this.labelError1.ForeColor = System.Drawing.Color.Red;
            this.labelError1.Location = new System.Drawing.Point(9, 69);
            this.labelError1.Name = "labelError1";
            this.labelError1.Size = new System.Drawing.Size(99, 13);
            this.labelError1.TabIndex = 7;
            this.labelError1.Text = "*Must enter a value";
            this.labelError1.Visible = false;
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.ForeColor = System.Drawing.Color.Red;
            this.labelError2.Location = new System.Drawing.Point(9, 143);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(99, 13);
            this.labelError2.TabIndex = 8;
            this.labelError2.Text = "*Must enter a value";
            this.labelError2.Visible = false;
            // 
            // CreateNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 189);
            this.Controls.Add(this.labelError2);
            this.Controls.Add(this.labelError1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelInfo2);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.textBoxPath);
            this.Name = "CreateNewFile";
            this.Text = "Create new file";
            this.Load += new System.EventHandler(this.CreateNewFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelError1;
        private System.Windows.Forms.Label labelError2;
    }
}
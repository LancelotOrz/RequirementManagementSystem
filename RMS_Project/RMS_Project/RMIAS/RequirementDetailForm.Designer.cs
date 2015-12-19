﻿namespace RMS_Project
{
    partial class RequirementDetailForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._nameLabel = new System.Windows.Forms.Label();
            this._descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this._memoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._nameLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this._descriptionRichTextBox, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this._memoRichTextBox, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(819, 521);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::RMS_Project.Properties.Resources.requirement_icon;
            this.pictureBox1.Location = new System.Drawing.Point(83, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel2.SetRowSpan(this.pictureBox1, 5);
            this.pictureBox1.Size = new System.Drawing.Size(274, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nameLabel.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(153)))));
            this._nameLabel.Location = new System.Drawing.Point(363, 40);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(371, 40);
            this._nameLabel.TabIndex = 1;
            this._nameLabel.Text = "label1";
            this._nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _descriptionRichTextBox
            // 
            this._descriptionRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this._descriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._descriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._descriptionRichTextBox.Font = new System.Drawing.Font("新細明體", 14F);
            this._descriptionRichTextBox.ForeColor = System.Drawing.Color.White;
            this._descriptionRichTextBox.Location = new System.Drawing.Point(363, 83);
            this._descriptionRichTextBox.Name = "_descriptionRichTextBox";
            this._descriptionRichTextBox.ReadOnly = true;
            this._descriptionRichTextBox.Size = new System.Drawing.Size(371, 194);
            this._descriptionRichTextBox.TabIndex = 2;
            this._descriptionRichTextBox.Text = "";
            // 
            // _memoRichTextBox
            // 
            this._memoRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this._memoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._memoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._memoRichTextBox.Font = new System.Drawing.Font("新細明體", 14F);
            this._memoRichTextBox.ForeColor = System.Drawing.Color.White;
            this._memoRichTextBox.Location = new System.Drawing.Point(363, 283);
            this._memoRichTextBox.Name = "_memoRichTextBox";
            this._memoRichTextBox.ReadOnly = true;
            this._memoRichTextBox.Size = new System.Drawing.Size(371, 194);
            this._memoRichTextBox.TabIndex = 3;
            this._memoRichTextBox.Text = "";
            // 
            // RequirementDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 521);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "RequirementDetailForm";
            this.Text = "RequirementDetailForm";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.RichTextBox _descriptionRichTextBox;
        private System.Windows.Forms.RichTextBox _memoRichTextBox;


    }
}
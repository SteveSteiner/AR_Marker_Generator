﻿namespace AR_Marker_Generator
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
            this.btn_CreateCodeMarker = new System.Windows.Forms.Button();
            this.btn_SaveCodeToFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chx_IconEnabled = new System.Windows.Forms.CheckBox();
            this.txt_CodeContent = new System.Windows.Forms.TextBox();
            this.txt_Icon = new System.Windows.Forms.TextBox();
            this.cbx_Colors = new System.Windows.Forms.ComboBox();
            this.pbx_CodeDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CodeDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CreateCodeMarker
            // 
            this.btn_CreateCodeMarker.Location = new System.Drawing.Point(12, 93);
            this.btn_CreateCodeMarker.Name = "btn_CreateCodeMarker";
            this.btn_CreateCodeMarker.Size = new System.Drawing.Size(428, 23);
            this.btn_CreateCodeMarker.TabIndex = 4;
            this.btn_CreateCodeMarker.Text = "Create Code Marker";
            this.btn_CreateCodeMarker.UseVisualStyleBackColor = true;
            this.btn_CreateCodeMarker.Click += new System.EventHandler(this.btn_CreateCodeMarker_Click);
            // 
            // btn_SaveCodeToFile
            // 
            this.btn_SaveCodeToFile.Location = new System.Drawing.Point(15, 554);
            this.btn_SaveCodeToFile.Name = "btn_SaveCodeToFile";
            this.btn_SaveCodeToFile.Size = new System.Drawing.Size(425, 23);
            this.btn_SaveCodeToFile.TabIndex = 5;
            this.btn_SaveCodeToFile.Text = "Save Code to File...";
            this.btn_SaveCodeToFile.UseVisualStyleBackColor = true;
            this.btn_SaveCodeToFile.Click += new System.EventHandler(this.btn_SaveCodeToFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code Content";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Code Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enable and Choose Icon Text";
            // 
            // chx_IconEnabled
            // 
            this.chx_IconEnabled.AutoSize = true;
            this.chx_IconEnabled.Location = new System.Drawing.Point(231, 69);
            this.chx_IconEnabled.Name = "chx_IconEnabled";
            this.chx_IconEnabled.Size = new System.Drawing.Size(15, 14);
            this.chx_IconEnabled.TabIndex = 2;
            this.chx_IconEnabled.UseVisualStyleBackColor = true;
            this.chx_IconEnabled.CheckedChanged += new System.EventHandler(this.chx_IconEnabled_CheckedChanged);
            // 
            // txt_CodeContent
            // 
            this.txt_CodeContent.Location = new System.Drawing.Point(12, 27);
            this.txt_CodeContent.Name = "txt_CodeContent";
            this.txt_CodeContent.Size = new System.Drawing.Size(428, 20);
            this.txt_CodeContent.TabIndex = 0;
            // 
            // txt_Icon
            // 
            this.txt_Icon.Location = new System.Drawing.Point(252, 66);
            this.txt_Icon.Name = "txt_Icon";
            this.txt_Icon.Size = new System.Drawing.Size(188, 20);
            this.txt_Icon.TabIndex = 3;
            // 
            // cbx_Colors
            // 
            this.cbx_Colors.FormattingEnabled = true;
            this.cbx_Colors.Location = new System.Drawing.Point(12, 66);
            this.cbx_Colors.Name = "cbx_Colors";
            this.cbx_Colors.Size = new System.Drawing.Size(199, 21);
            this.cbx_Colors.TabIndex = 1;
            // 
            // pbx_CodeDisplay
            // 
            this.pbx_CodeDisplay.Location = new System.Drawing.Point(15, 123);
            this.pbx_CodeDisplay.Name = "pbx_CodeDisplay";
            this.pbx_CodeDisplay.Size = new System.Drawing.Size(425, 425);
            this.pbx_CodeDisplay.TabIndex = 9;
            this.pbx_CodeDisplay.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 584);
            this.Controls.Add(this.pbx_CodeDisplay);
            this.Controls.Add(this.cbx_Colors);
            this.Controls.Add(this.txt_Icon);
            this.Controls.Add(this.txt_CodeContent);
            this.Controls.Add(this.chx_IconEnabled);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SaveCodeToFile);
            this.Controls.Add(this.btn_CreateCodeMarker);
            this.Name = "Form1";
            this.Text = "AR_Marker_Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CodeDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateCodeMarker;
        private System.Windows.Forms.Button btn_SaveCodeToFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chx_IconEnabled;
        private System.Windows.Forms.TextBox txt_CodeContent;
        private System.Windows.Forms.TextBox txt_Icon;
        private System.Windows.Forms.ComboBox cbx_Colors;
        private System.Windows.Forms.PictureBox pbx_CodeDisplay;
    }
}


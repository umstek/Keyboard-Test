namespace Keyboard_Test
{
    partial class Form
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
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelCtrl = new System.Windows.Forms.Label();
            this.labelAlt = new System.Windows.Forms.Label();
            this.labelShift = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelDesc
            // 
            this.labelDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDesc.Location = new System.Drawing.Point(176, 11);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(230, 25);
            this.labelDesc.TabIndex = 0;
            this.labelDesc.Text = "Press keys to test";
            this.labelDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKey
            // 
            this.labelKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey.Font = new System.Drawing.Font("Segoe UI Semilight", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKey.Location = new System.Drawing.Point(13, 36);
            this.labelKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(311, 385);
            this.labelKey.TabIndex = 1;
            this.labelKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.labelKey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // labelCtrl
            // 
            this.labelCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCtrl.Location = new System.Drawing.Point(12, 421);
            this.labelCtrl.Name = "labelCtrl";
            this.labelCtrl.Size = new System.Drawing.Size(100, 23);
            this.labelCtrl.TabIndex = 2;
            this.labelCtrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAlt
            // 
            this.labelAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAlt.Location = new System.Drawing.Point(118, 421);
            this.labelAlt.Name = "labelAlt";
            this.labelAlt.Size = new System.Drawing.Size(100, 23);
            this.labelAlt.TabIndex = 3;
            this.labelAlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelShift
            // 
            this.labelShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelShift.Location = new System.Drawing.Point(224, 421);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(100, 23);
            this.labelShift.TabIndex = 4;
            this.labelShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.BackColor = System.Drawing.SystemColors.Control;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(331, 36);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(239, 400);
            this.listBox.TabIndex = 5;
            this.listBox.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.labelShift);
            this.Controls.Add(this.labelAlt);
            this.Controls.Add(this.labelCtrl);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.labelDesc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keyboard Test";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelCtrl;
        private System.Windows.Forms.Label labelAlt;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.ListBox listBox;
    }
}


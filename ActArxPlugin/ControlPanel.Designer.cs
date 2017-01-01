namespace ActArxPlugin
{
    partial class ControlPanel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.indexHtmlLbl = new System.Windows.Forms.Label();
            this.indexHtmlTextBox = new System.Windows.Forms.TextBox();
            this.selectIndexHtmlBtn = new System.Windows.Forms.Button();
            this.appJsLbl = new System.Windows.Forms.Label();
            this.appJsTextBox = new System.Windows.Forms.TextBox();
            this.appJsBtn = new System.Windows.Forms.Button();
            this.debugTextLog = new System.Windows.Forms.TextBox();
            this.debugLbl = new System.Windows.Forms.Label();
            this.debugCLearBtn = new System.Windows.Forms.Button();
            this.indexHtmlFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.appJsFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // indexHtmlLbl
            // 
            this.indexHtmlLbl.AutoSize = true;
            this.indexHtmlLbl.Location = new System.Drawing.Point(4, 17);
            this.indexHtmlLbl.Name = "indexHtmlLbl";
            this.indexHtmlLbl.Size = new System.Drawing.Size(66, 13);
            this.indexHtmlLbl.TabIndex = 0;
            this.indexHtmlLbl.Text = "Index HTML";
            // 
            // indexHtmlTextBox
            // 
            this.indexHtmlTextBox.Location = new System.Drawing.Point(76, 14);
            this.indexHtmlTextBox.Name = "indexHtmlTextBox";
            this.indexHtmlTextBox.Size = new System.Drawing.Size(238, 20);
            this.indexHtmlTextBox.TabIndex = 1;
            // 
            // selectIndexHtmlBtn
            // 
            this.selectIndexHtmlBtn.AutoSize = true;
            this.selectIndexHtmlBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectIndexHtmlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectIndexHtmlBtn.Location = new System.Drawing.Point(331, 10);
            this.selectIndexHtmlBtn.Name = "selectIndexHtmlBtn";
            this.selectIndexHtmlBtn.Size = new System.Drawing.Size(30, 26);
            this.selectIndexHtmlBtn.TabIndex = 2;
            this.selectIndexHtmlBtn.Text = "...";
            this.selectIndexHtmlBtn.UseVisualStyleBackColor = true;
            this.selectIndexHtmlBtn.Click += new System.EventHandler(this.selectIndexHtmlBtn_Click);
            // 
            // appJsLbl
            // 
            this.appJsLbl.AutoSize = true;
            this.appJsLbl.Location = new System.Drawing.Point(7, 53);
            this.appJsLbl.Name = "appJsLbl";
            this.appJsLbl.Size = new System.Drawing.Size(36, 13);
            this.appJsLbl.TabIndex = 3;
            this.appJsLbl.Text = "App.js";
            // 
            // appJsTextBox
            // 
            this.appJsTextBox.Location = new System.Drawing.Point(76, 50);
            this.appJsTextBox.Name = "appJsTextBox";
            this.appJsTextBox.Size = new System.Drawing.Size(238, 20);
            this.appJsTextBox.TabIndex = 4;
            // 
            // appJsBtn
            // 
            this.appJsBtn.AutoSize = true;
            this.appJsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.appJsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appJsBtn.Location = new System.Drawing.Point(331, 46);
            this.appJsBtn.Name = "appJsBtn";
            this.appJsBtn.Size = new System.Drawing.Size(30, 26);
            this.appJsBtn.TabIndex = 5;
            this.appJsBtn.Text = "...";
            this.appJsBtn.UseVisualStyleBackColor = true;
            // 
            // debugTextLog
            // 
            this.debugTextLog.AcceptsReturn = true;
            this.debugTextLog.BackColor = System.Drawing.SystemColors.Window;
            this.debugTextLog.Location = new System.Drawing.Point(10, 128);
            this.debugTextLog.Multiline = true;
            this.debugTextLog.Name = "debugTextLog";
            this.debugTextLog.ReadOnly = true;
            this.debugTextLog.ShortcutsEnabled = false;
            this.debugTextLog.Size = new System.Drawing.Size(371, 85);
            this.debugTextLog.TabIndex = 6;
            // 
            // debugLbl
            // 
            this.debugLbl.AutoSize = true;
            this.debugLbl.Location = new System.Drawing.Point(10, 109);
            this.debugLbl.Name = "debugLbl";
            this.debugLbl.Size = new System.Drawing.Size(60, 13);
            this.debugLbl.TabIndex = 7;
            this.debugLbl.Text = "Debug Log";
            // 
            // debugCLearBtn
            // 
            this.debugCLearBtn.AutoSize = true;
            this.debugCLearBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.debugCLearBtn.Location = new System.Drawing.Point(10, 220);
            this.debugCLearBtn.Name = "debugCLearBtn";
            this.debugCLearBtn.Size = new System.Drawing.Size(41, 23);
            this.debugCLearBtn.TabIndex = 8;
            this.debugCLearBtn.Text = "Clear";
            this.debugCLearBtn.UseVisualStyleBackColor = true;
            // 
            // indexHtmlFileDialog
            // 
            this.indexHtmlFileDialog.FileName = "indexHtmlFileDialog";
            // 
            // appJsFileDialog
            // 
            this.appJsFileDialog.FileName = "appJsFileDialog";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.debugCLearBtn);
            this.Controls.Add(this.debugLbl);
            this.Controls.Add(this.debugTextLog);
            this.Controls.Add(this.appJsBtn);
            this.Controls.Add(this.appJsTextBox);
            this.Controls.Add(this.appJsLbl);
            this.Controls.Add(this.selectIndexHtmlBtn);
            this.Controls.Add(this.indexHtmlTextBox);
            this.Controls.Add(this.indexHtmlLbl);
            this.Name = "ControlPanel";
            this.Size = new System.Drawing.Size(403, 257);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label indexHtmlLbl;
        private System.Windows.Forms.TextBox indexHtmlTextBox;
        private System.Windows.Forms.Button selectIndexHtmlBtn;
        private System.Windows.Forms.Label appJsLbl;
        private System.Windows.Forms.TextBox appJsTextBox;
        private System.Windows.Forms.Button appJsBtn;
        private System.Windows.Forms.TextBox debugTextLog;
        private System.Windows.Forms.Label debugLbl;
        private System.Windows.Forms.Button debugCLearBtn;
        private System.Windows.Forms.OpenFileDialog indexHtmlFileDialog;
        private System.Windows.Forms.OpenFileDialog appJsFileDialog;
    }
}

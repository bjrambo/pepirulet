namespace pepirulet
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.UserId = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goToPepi = new System.Windows.Forms.Button();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserId
            // 
            this.UserId.Location = new System.Drawing.Point(12, 12);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(185, 23);
            this.UserId.TabIndex = 0;
            this.UserId.Text = "아이디";
            // 
            // Password
            // 
            this.Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Password.Location = new System.Drawing.Point(12, 55);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(185, 23);
            this.Password.TabIndex = 1;
            this.Password.Text = "비밀번호";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.textToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(95, 48);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.textToolStripMenuItem.Text = "text";
            // 
            // textToolStripMenuItem1
            // 
            this.textToolStripMenuItem1.Name = "textToolStripMenuItem1";
            this.textToolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.textToolStripMenuItem1.Text = "text";
            // 
            // goToPepi
            // 
            this.goToPepi.Location = new System.Drawing.Point(203, 12);
            this.goToPepi.Name = "goToPepi";
            this.goToPepi.Size = new System.Drawing.Size(90, 66);
            this.goToPepi.TabIndex = 4;
            this.goToPepi.Text = "페피 로그인!";
            this.goToPepi.UseVisualStyleBackColor = true;
            this.goToPepi.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 90);
            this.Controls.Add(this.goToPepi);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UserId;
        private TextBox Password;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem textToolStripMenuItem;
        private ToolStripMenuItem textToolStripMenuItem1;
        private Button goToPepi;
        private ContextMenuStrip contextMenuStrip3;
    }
}
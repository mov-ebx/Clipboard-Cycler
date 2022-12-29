
namespace Clipboard_Cycler
{
    partial class UI
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
            this.Fill = new System.Windows.Forms.Panel();
            this.ListHolder = new System.Windows.Forms.Panel();
            ClipboardList = new System.Windows.Forms.ListBox();
            this.Bottom = new System.Windows.Forms.Panel();
            ToggleStatus = new System.Windows.Forms.CheckBox();
            this.ListControls = new System.Windows.Forms.SplitContainer();
            this.Clear = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Top = new System.Windows.Forms.Panel();
            this.ListSet = new System.Windows.Forms.SplitContainer();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Fill.SuspendLayout();
            this.ListHolder.SuspendLayout();
            this.Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListControls)).BeginInit();
            this.ListControls.Panel1.SuspendLayout();
            this.ListControls.Panel2.SuspendLayout();
            this.ListControls.SuspendLayout();
            this.Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListSet)).BeginInit();
            this.ListSet.Panel1.SuspendLayout();
            this.ListSet.Panel2.SuspendLayout();
            this.ListSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fill
            // 
            this.Fill.BackColor = System.Drawing.Color.Transparent;
            this.Fill.Controls.Add(this.ListHolder);
            this.Fill.Controls.Add(this.Bottom);
            this.Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fill.Location = new System.Drawing.Point(0, 32);
            this.Fill.Name = "Fill";
            this.Fill.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Fill.Size = new System.Drawing.Size(234, 229);
            this.Fill.TabIndex = 3;
            // 
            // ListHolder
            // 
            this.ListHolder.Controls.Add(ClipboardList);
            this.ListHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListHolder.Location = new System.Drawing.Point(0, 2);
            this.ListHolder.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.ListHolder.Name = "ListHolder";
            this.ListHolder.Padding = new System.Windows.Forms.Padding(5, 0, 5, 3);
            this.ListHolder.Size = new System.Drawing.Size(234, 172);
            this.ListHolder.TabIndex = 7;
            // 
            // ClipboardList
            // 
            ClipboardList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            ClipboardList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ClipboardList.Dock = System.Windows.Forms.DockStyle.Fill;
            ClipboardList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            ClipboardList.ForeColor = System.Drawing.Color.White;
            ClipboardList.FormattingEnabled = true;
            ClipboardList.ItemHeight = 15;
            ClipboardList.Location = new System.Drawing.Point(5, 0);
            ClipboardList.Name = "ClipboardList";
            ClipboardList.Size = new System.Drawing.Size(224, 169);
            ClipboardList.TabIndex = 0;
            // 
            // Bottom
            // 
            this.Bottom.BackColor = System.Drawing.Color.Transparent;
            this.Bottom.Controls.Add(ToggleStatus);
            this.Bottom.Controls.Add(this.ListControls);
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom.Location = new System.Drawing.Point(0, 174);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(234, 55);
            this.Bottom.TabIndex = 5;
            // 
            // ToggleStatus
            // 
            ToggleStatus.AutoSize = true;
            ToggleStatus.ForeColor = System.Drawing.Color.White;
            ToggleStatus.Location = new System.Drawing.Point(3, 35);
            ToggleStatus.Name = "ToggleStatus";
            ToggleStatus.Size = new System.Drawing.Size(65, 17);
            ToggleStatus.TabIndex = 8;
            ToggleStatus.Text = "Enabled";
            ToggleStatus.UseVisualStyleBackColor = true;
            // 
            // ListControls
            // 
            this.ListControls.BackColor = System.Drawing.Color.Transparent;
            this.ListControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListControls.IsSplitterFixed = true;
            this.ListControls.Location = new System.Drawing.Point(0, 0);
            this.ListControls.Name = "ListControls";
            // 
            // ListControls.Panel1
            // 
            this.ListControls.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.ListControls.Panel1.Controls.Add(this.Clear);
            this.ListControls.Panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            // 
            // ListControls.Panel2
            // 
            this.ListControls.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.ListControls.Panel2.Controls.Add(this.Remove);
            this.ListControls.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.ListControls.Size = new System.Drawing.Size(234, 34);
            this.ListControls.SplitterDistance = 117;
            this.ListControls.TabIndex = 7;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(5, 0);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(112, 29);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "Clear all";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Remove.FlatAppearance.BorderSize = 0;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Remove.ForeColor = System.Drawing.Color.White;
            this.Remove.Location = new System.Drawing.Point(0, 0);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(108, 29);
            this.Remove.TabIndex = 0;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.Transparent;
            this.Top.Controls.Add(this.ListSet);
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(234, 32);
            this.Top.TabIndex = 0;
            // 
            // ListSet
            // 
            this.ListSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListSet.IsSplitterFixed = true;
            this.ListSet.Location = new System.Drawing.Point(0, 0);
            this.ListSet.Name = "ListSet";
            // 
            // ListSet.Panel1
            // 
            this.ListSet.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.ListSet.Panel1.Controls.Add(this.TextBox);
            this.ListSet.Panel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            // 
            // ListSet.Panel2
            // 
            this.ListSet.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.ListSet.Panel2.Controls.Add(this.Add);
            this.ListSet.Panel2.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.ListSet.Size = new System.Drawing.Size(234, 32);
            this.ListSet.SplitterDistance = 165;
            this.ListSet.SplitterWidth = 1;
            this.ListSet.TabIndex = 0;
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBox.ForeColor = System.Drawing.Color.White;
            this.TextBox.Location = new System.Drawing.Point(5, 5);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(160, 22);
            this.TextBox.TabIndex = 0;
            this.TextBox.WordWrap = false;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(0, 5);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(63, 22);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.Top);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Name = "UI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClipboardCycler";
            this.Load += new System.EventHandler(this.UI_Load);
            this.Fill.ResumeLayout(false);
            this.ListHolder.ResumeLayout(false);
            this.Bottom.ResumeLayout(false);
            this.Bottom.PerformLayout();
            this.ListControls.Panel1.ResumeLayout(false);
            this.ListControls.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListControls)).EndInit();
            this.ListControls.ResumeLayout(false);
            this.Top.ResumeLayout(false);
            this.ListSet.Panel1.ResumeLayout(false);
            this.ListSet.Panel1.PerformLayout();
            this.ListSet.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListSet)).EndInit();
            this.ListSet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Fill;
        private System.Windows.Forms.Panel Bottom;
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.SplitContainer ListSet;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Panel ListHolder;
        private static System.Windows.Forms.CheckBox ToggleStatus;
        private System.Windows.Forms.SplitContainer ListControls;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Remove;
        private static System.Windows.Forms.ListBox ClipboardList;
    }
}


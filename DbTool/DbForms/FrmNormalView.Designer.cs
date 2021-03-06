﻿namespace DbTool.DbForms
{
    partial class FrmNormalView
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageNormal = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbSql = new AvalonEdit.Winform.AvalonTextBox();
            this.dgvNormal = new DbTool.MyControls.DataGridViewEx();
            this.tabControl.SuspendLayout();
            this.tabPageNormal.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageNormal);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(591, 388);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageNormal
            // 
            this.tabPageNormal.Controls.Add(this.dgvNormal);
            this.tabPageNormal.Location = new System.Drawing.Point(4, 22);
            this.tabPageNormal.Name = "tabPageNormal";
            this.tabPageNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNormal.Size = new System.Drawing.Size(583, 362);
            this.tabPageNormal.TabIndex = 2;
            this.tabPageNormal.Text = "一般";
            this.tabPageNormal.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbSql);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SQL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbSql
            // 
            this.tbSql.AutoScroll = true;
            this.tbSql.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.tbSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSql.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSql.Location = new System.Drawing.Point(3, 3);
            this.tbSql.Margin = new System.Windows.Forms.Padding(4);
            this.tbSql.Name = "tbSql";
            this.tbSql.Size = new System.Drawing.Size(577, 356);
            this.tbSql.SyntaxHighlighting = "SQL";
            this.tbSql.TabIndex = 0;
            // 
            // dgvNormal
            // 
            this.dgvNormal.AllowUserToAddRows = false;
            this.dgvNormal.AllowUserToDeleteRows = false;
            this.dgvNormal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNormal.Location = new System.Drawing.Point(3, 3);
            this.dgvNormal.Name = "dgvNormal";
            this.dgvNormal.ReadOnly = true;
            this.dgvNormal.RowTemplate.Height = 23;
            this.dgvNormal.Size = new System.Drawing.Size(577, 356);
            this.dgvNormal.TabIndex = 1;
            // 
            // FrmNormalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 388);
            this.Controls.Add(this.tabControl);
            this.Name = "FrmNormalView";
            this.Text = "一般查看";
            this.Load += new System.EventHandler(this.FrmNormalView_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageNormal.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.DataGridViewEx dgvNormal;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageNormal;
        private System.Windows.Forms.TabPage tabPage2;
        private AvalonEdit.Winform.AvalonTextBox tbSql;
    }
}
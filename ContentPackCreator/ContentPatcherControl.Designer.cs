﻿namespace ContentPackCreator
{
    partial class ContentPatcherControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cpFormat = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.configRemove = new System.Windows.Forms.Button();
            this.configAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.configDefault = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.configAllowValues = new System.Windows.Forms.TextBox();
            this.labelFieldName = new System.Windows.Forms.Label();
            this.configFieldName = new System.Windows.Forms.TextBox();
            this.configListBox = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.changesRemoveButton = new System.Windows.Forms.Button();
            this.changesActionPanel = new System.Windows.Forms.Panel();
            this.changesAddButton = new System.Windows.Forms.Button();
            this.actionComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cpJsonTab = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.cpJsonTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1197, 494);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cpFormat);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1189, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 30);
            this.label10.TabIndex = 36;
            this.label10.Text = "Format";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpFormat
            // 
            this.cpFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpFormat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpFormat.Location = new System.Drawing.Point(137, 9);
            this.cpFormat.MinimumSize = new System.Drawing.Size(612, 30);
            this.cpFormat.Name = "cpFormat";
            this.cpFormat.Size = new System.Drawing.Size(827, 29);
            this.cpFormat.TabIndex = 37;
            this.cpFormat.Text = "1.2.5";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.configRemove);
            this.tabPage3.Controls.Add(this.configAdd);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.configDefault);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.configAllowValues);
            this.tabPage3.Controls.Add(this.labelFieldName);
            this.tabPage3.Controls.Add(this.configFieldName);
            this.tabPage3.Controls.Add(this.configListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1189, 466);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Config";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // configRemove
            // 
            this.configRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.configRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.configRemove.Location = new System.Drawing.Point(899, 111);
            this.configRemove.Name = "configRemove";
            this.configRemove.Size = new System.Drawing.Size(139, 34);
            this.configRemove.TabIndex = 46;
            this.configRemove.Text = "Remove";
            this.configRemove.UseVisualStyleBackColor = true;
            this.configRemove.Click += new System.EventHandler(this.configRemove_Click);
            // 
            // configAdd
            // 
            this.configAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.configAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.configAdd.Location = new System.Drawing.Point(1044, 112);
            this.configAdd.Name = "configAdd";
            this.configAdd.Size = new System.Drawing.Size(139, 34);
            this.configAdd.TabIndex = 45;
            this.configAdd.Text = "Add";
            this.configAdd.UseVisualStyleBackColor = true;
            this.configAdd.Click += new System.EventHandler(this.configAdd_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(245, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 43;
            this.label2.Text = "Default";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // configDefault
            // 
            this.configDefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configDefault.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.configDefault.Location = new System.Drawing.Point(373, 76);
            this.configDefault.MinimumSize = new System.Drawing.Size(612, 30);
            this.configDefault.Name = "configDefault";
            this.configDefault.Size = new System.Drawing.Size(810, 29);
            this.configDefault.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(245, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 41;
            this.label1.Text = "AllowValues";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // configAllowValues
            // 
            this.configAllowValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configAllowValues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.configAllowValues.Location = new System.Drawing.Point(373, 40);
            this.configAllowValues.MinimumSize = new System.Drawing.Size(612, 30);
            this.configAllowValues.Name = "configAllowValues";
            this.configAllowValues.Size = new System.Drawing.Size(810, 29);
            this.configAllowValues.TabIndex = 42;
            // 
            // labelFieldName
            // 
            this.labelFieldName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFieldName.Location = new System.Drawing.Point(245, 3);
            this.labelFieldName.Name = "labelFieldName";
            this.labelFieldName.Size = new System.Drawing.Size(122, 30);
            this.labelFieldName.TabIndex = 38;
            this.labelFieldName.Text = "Field Name";
            this.labelFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // configFieldName
            // 
            this.configFieldName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configFieldName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.configFieldName.Location = new System.Drawing.Point(373, 4);
            this.configFieldName.MinimumSize = new System.Drawing.Size(612, 30);
            this.configFieldName.Name = "configFieldName";
            this.configFieldName.Size = new System.Drawing.Size(810, 29);
            this.configFieldName.TabIndex = 39;
            // 
            // configListBox
            // 
            this.configListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.configListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.configListBox.FormattingEnabled = true;
            this.configListBox.ItemHeight = 21;
            this.configListBox.Location = new System.Drawing.Point(6, 6);
            this.configListBox.Name = "configListBox";
            this.configListBox.Size = new System.Drawing.Size(233, 445);
            this.configListBox.TabIndex = 0;
            this.configListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.changesRemoveButton);
            this.tabPage5.Controls.Add(this.changesActionPanel);
            this.tabPage5.Controls.Add(this.changesAddButton);
            this.tabPage5.Controls.Add(this.actionComboBox);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.listBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1189, 466);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Changes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(376, 12);
            this.textBox1.MinimumSize = new System.Drawing.Size(612, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(810, 29);
            this.textBox1.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(245, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 64;
            this.label3.Text = "LogName";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changesRemoveButton
            // 
            this.changesRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changesRemoveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changesRemoveButton.Location = new System.Drawing.Point(899, 428);
            this.changesRemoveButton.Name = "changesRemoveButton";
            this.changesRemoveButton.Size = new System.Drawing.Size(139, 34);
            this.changesRemoveButton.TabIndex = 63;
            this.changesRemoveButton.Text = "Remove";
            this.changesRemoveButton.UseVisualStyleBackColor = true;
            // 
            // changesActionPanel
            // 
            this.changesActionPanel.Location = new System.Drawing.Point(245, 83);
            this.changesActionPanel.Name = "changesActionPanel";
            this.changesActionPanel.Size = new System.Drawing.Size(938, 339);
            this.changesActionPanel.TabIndex = 57;
            // 
            // changesAddButton
            // 
            this.changesAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changesAddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changesAddButton.Location = new System.Drawing.Point(1044, 429);
            this.changesAddButton.Name = "changesAddButton";
            this.changesAddButton.Size = new System.Drawing.Size(139, 34);
            this.changesAddButton.TabIndex = 62;
            this.changesAddButton.Text = "Add";
            this.changesAddButton.UseVisualStyleBackColor = true;
            // 
            // actionComboBox
            // 
            this.actionComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actionComboBox.FormattingEnabled = true;
            this.actionComboBox.Items.AddRange(new object[] {
            "Load",
            "EditData",
            "EditImage",
            "EditMap",
            "Include"});
            this.actionComboBox.Location = new System.Drawing.Point(376, 48);
            this.actionComboBox.Name = "actionComboBox";
            this.actionComboBox.Size = new System.Drawing.Size(810, 29);
            this.actionComboBox.TabIndex = 56;
            this.actionComboBox.SelectedIndexChanged += new System.EventHandler(this.actionComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(248, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 30);
            this.label5.TabIndex = 48;
            this.label5.Text = "Action";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(6, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 445);
            this.listBox1.TabIndex = 47;
            // 
            // cpJsonTab
            // 
            this.cpJsonTab.Location = new System.Drawing.Point(4, 24);
            this.cpJsonTab.Name = "cpJsonTab";
            this.cpJsonTab.Padding = new System.Windows.Forms.Padding(3);
            this.cpJsonTab.Size = new System.Drawing.Size(1189, 466);
            this.cpJsonTab.TabIndex = 3;
            this.cpJsonTab.Text = "JSON";
            this.cpJsonTab.UseVisualStyleBackColor = true;
            // 
            // ContentPatcherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ContentPatcherControl";
            this.Size = new System.Drawing.Size(1200, 500);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cpFormat;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage cpJsonTab;
        private System.Windows.Forms.ListBox configListBox;
        private System.Windows.Forms.Label labelFieldName;
        private System.Windows.Forms.TextBox configFieldName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox configDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox configAllowValues;
        private System.Windows.Forms.Button configAdd;
        private System.Windows.Forms.Button configRemove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox actionComboBox;
        private System.Windows.Forms.Panel changesActionPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button changesRemoveButton;
        private System.Windows.Forms.Button changesAddButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

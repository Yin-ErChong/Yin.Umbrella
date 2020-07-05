namespace Yin.Umbrella.CodeGenerator
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
            this.EntityCheck = new System.Windows.Forms.CheckBox();
            this.DTOCheck = new System.Windows.Forms.CheckBox();
            this.Template = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EntityCheck
            // 
            this.EntityCheck.AutoSize = true;
            this.EntityCheck.Location = new System.Drawing.Point(90, 51);
            this.EntityCheck.Name = "EntityCheck";
            this.EntityCheck.Size = new System.Drawing.Size(69, 24);
            this.EntityCheck.TabIndex = 0;
            this.EntityCheck.Text = "Entity";
            this.EntityCheck.UseVisualStyleBackColor = true;
            this.EntityCheck.CheckedChanged += new System.EventHandler(this.EntityCheck_CheckedChanged);
            // 
            // DTOCheck
            // 
            this.DTOCheck.AutoSize = true;
            this.DTOCheck.Location = new System.Drawing.Point(189, 51);
            this.DTOCheck.Name = "DTOCheck";
            this.DTOCheck.Size = new System.Drawing.Size(60, 24);
            this.DTOCheck.TabIndex = 1;
            this.DTOCheck.Text = "DTO";
            this.DTOCheck.UseVisualStyleBackColor = true;
            this.DTOCheck.CheckedChanged += new System.EventHandler(this.DTOCheck_CheckedChanged);
            // 
            // Template
            // 
            this.Template.Location = new System.Drawing.Point(90, 183);
            this.Template.Multiline = true;
            this.Template.Name = "Template";
            this.Template.Size = new System.Drawing.Size(199, 472);
            this.Template.TabIndex = 2;
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(482, 183);
            this.Code.Multiline = true;
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(308, 472);
            this.Code.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "模板";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "生成的代码";
            // 
            // tableName
            // 
            this.tableName.Location = new System.Drawing.Point(482, 50);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(120, 25);
            this.tableName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "表名";
            // 
            // Generate
            // 
            this.Generate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Generate.Location = new System.Drawing.Point(735, 86);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(90, 28);
            this.Generate.TabIndex = 6;
            this.Generate.Text = "生成";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 748);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.Template);
            this.Controls.Add(this.DTOCheck);
            this.Controls.Add(this.EntityCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox EntityCheck;
        private System.Windows.Forms.CheckBox DTOCheck;
        private System.Windows.Forms.TextBox Template;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tableName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Generate;
    }
}


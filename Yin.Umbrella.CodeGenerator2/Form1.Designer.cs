namespace Yin.Umbrella.CodeGenerator2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.EntityCheck = new System.Windows.Forms.CheckBox();
            this.DTOCheck = new System.Windows.Forms.CheckBox();
            this.Template = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.TableName = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EntityCheck
            // 
            this.EntityCheck.AutoSize = true;
            this.EntityCheck.Location = new System.Drawing.Point(167, 53);
            this.EntityCheck.Name = "EntityCheck";
            this.EntityCheck.Size = new System.Drawing.Size(60, 16);
            this.EntityCheck.TabIndex = 0;
            this.EntityCheck.Text = "Entity";
            this.EntityCheck.UseVisualStyleBackColor = true;
            this.EntityCheck.CheckedChanged += new System.EventHandler(this.EntityCheck_CheckedChanged);
            // 
            // DTOCheck
            // 
            this.DTOCheck.AutoSize = true;
            this.DTOCheck.Location = new System.Drawing.Point(273, 53);
            this.DTOCheck.Name = "DTOCheck";
            this.DTOCheck.Size = new System.Drawing.Size(42, 16);
            this.DTOCheck.TabIndex = 1;
            this.DTOCheck.Text = "DTO";
            this.DTOCheck.UseVisualStyleBackColor = true;
            this.DTOCheck.CheckedChanged += new System.EventHandler(this.DTOCheck_CheckedChanged);
            // 
            // Template
            // 
            this.Template.Location = new System.Drawing.Point(107, 115);
            this.Template.Multiline = true;
            this.Template.Name = "Template";
            this.Template.Size = new System.Drawing.Size(135, 297);
            this.Template.TabIndex = 2;
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(430, 115);
            this.Code.Multiline = true;
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(288, 297);
            this.Code.TabIndex = 3;
            // 
            // TableName
            // 
            this.TableName.Location = new System.Drawing.Point(463, 53);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(100, 21);
            this.TableName.TabIndex = 4;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(642, 74);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 5;
            this.Generate.Text = "生成";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.TableName);
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
        private System.Windows.Forms.TextBox TableName;
        private System.Windows.Forms.Button Generate;
    }
}


namespace WindowsFormsApp1
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
            this.create = new System.Windows.Forms.Button();
            this.pathNameTxt = new System.Windows.Forms.TextBox();
            this.entityNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addAppCoreFolder = new System.Windows.Forms.CheckBox();
            this.addInfrafolder = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderNameText = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(46, 230);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(107, 23);
            this.create.TabIndex = 0;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // pathNameTxt
            // 
            this.pathNameTxt.Location = new System.Drawing.Point(339, 41);
            this.pathNameTxt.Name = "pathNameTxt";
            this.pathNameTxt.Size = new System.Drawing.Size(247, 20);
            this.pathNameTxt.TabIndex = 1;
            // 
            // entityNameTxt
            // 
            this.entityNameTxt.Location = new System.Drawing.Point(339, 99);
            this.entityNameTxt.Name = "entityNameTxt";
            this.entityNameTxt.Size = new System.Drawing.Size(247, 20);
            this.entityNameTxt.TabIndex = 2;
            this.entityNameTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "path name (Exemplo  C:\\...\\PortalGestaoObras\\src)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "entity name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addAppCoreFolder
            // 
            this.addAppCoreFolder.AutoSize = true;
            this.addAppCoreFolder.Location = new System.Drawing.Point(46, 183);
            this.addAppCoreFolder.Name = "addAppCoreFolder";
            this.addAppCoreFolder.Size = new System.Drawing.Size(118, 17);
            this.addAppCoreFolder.TabIndex = 6;
            this.addAppCoreFolder.Text = "Add AppCore folder";
            this.addAppCoreFolder.UseVisualStyleBackColor = true;
            this.addAppCoreFolder.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // addInfrafolder
            // 
            this.addInfrafolder.AutoSize = true;
            this.addInfrafolder.Location = new System.Drawing.Point(214, 183);
            this.addInfrafolder.Name = "addInfrafolder";
            this.addInfrafolder.Size = new System.Drawing.Size(98, 17);
            this.addInfrafolder.TabIndex = 7;
            this.addInfrafolder.Text = "Add Infra folder";
            this.addInfrafolder.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "folder name (optional)";
            // 
            // folderNameText
            // 
            this.folderNameText.Location = new System.Drawing.Point(234, 139);
            this.folderNameText.Name = "folderNameText";
            this.folderNameText.Size = new System.Drawing.Size(201, 20);
            this.folderNameText.TabIndex = 9;
            // 
            // labelResult
            // 
            this.labelResult.BackColor = this.BackColor;
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelResult.Location = new System.Drawing.Point(46, 259);
            this.labelResult.Multiline = true;
            this.labelResult.Name = "labelResult";
            this.labelResult.ReadOnly = true;
            this.labelResult.Size = new System.Drawing.Size(540, 60);
            this.labelResult.TabIndex = 10;
            this.labelResult.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 331);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.folderNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addInfrafolder);
            this.Controls.Add(this.addAppCoreFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entityNameTxt);
            this.Controls.Add(this.pathNameTxt);
            this.Controls.Add(this.create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox pathNameTxt;
        private System.Windows.Forms.TextBox entityNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox addAppCoreFolder;
        private System.Windows.Forms.CheckBox addInfrafolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox folderNameText;
        private System.Windows.Forms.TextBox labelResult;
    }
}


namespace To_Do_List
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
            this.clsToDo = new System.Windows.Forms.CheckedListBox();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.txtNewToDo = new System.Windows.Forms.TextBox();
            this.btnAddToDo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clsToDo
            // 
            this.clsToDo.FormattingEnabled = true;
            this.clsToDo.Location = new System.Drawing.Point(55, 186);
            this.clsToDo.Name = "clsToDo";
            this.clsToDo.Size = new System.Drawing.Size(1179, 340);
            this.clsToDo.TabIndex = 0;
            // 
            // lstDone
            // 
            this.lstDone.FormattingEnabled = true;
            this.lstDone.ItemHeight = 25;
            this.lstDone.Location = new System.Drawing.Point(55, 781);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(1174, 154);
            this.lstDone.TabIndex = 1;
            // 
            // txtNewToDo
            // 
            this.txtNewToDo.Location = new System.Drawing.Point(50, 46);
            this.txtNewToDo.Name = "txtNewToDo";
            this.txtNewToDo.Size = new System.Drawing.Size(737, 31);
            this.txtNewToDo.TabIndex = 2;
            // 
            // btnAddToDo
            // 
            this.btnAddToDo.Location = new System.Drawing.Point(1074, 46);
            this.btnAddToDo.Name = "btnAddToDo";
            this.btnAddToDo.Size = new System.Drawing.Size(160, 31);
            this.btnAddToDo.TabIndex = 3;
            this.btnAddToDo.Text = "Add";
            this.btnAddToDo.UseVisualStyleBackColor = true;
            this.btnAddToDo.Click += new System.EventHandler(this.btnAddToDo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(55, 544);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(387, 54);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Remove checked items";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "What do you need to do?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Things to do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 740);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Deleted Items";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddToDo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 962);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddToDo);
            this.Controls.Add(this.txtNewToDo);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.clsToDo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clsToDo;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.TextBox txtNewToDo;
        private System.Windows.Forms.Button btnAddToDo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


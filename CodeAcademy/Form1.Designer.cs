namespace CodeAcademy
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
            this.Btn_AddSubject = new System.Windows.Forms.Button();
            this.Btn_AddTeacher = new System.Windows.Forms.Button();
            this.Btn_AddStudent = new System.Windows.Forms.Button();
            this.Btn_AddGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_AddSubject
            // 
            this.Btn_AddSubject.Location = new System.Drawing.Point(207, 24);
            this.Btn_AddSubject.Name = "Btn_AddSubject";
            this.Btn_AddSubject.Size = new System.Drawing.Size(109, 23);
            this.Btn_AddSubject.TabIndex = 0;
            this.Btn_AddSubject.Text = "Add Subject";
            this.Btn_AddSubject.UseVisualStyleBackColor = true;
            this.Btn_AddSubject.Click += new System.EventHandler(this.Btn_AddSubject_Click);
            // 
            // Btn_AddTeacher
            // 
            this.Btn_AddTeacher.Location = new System.Drawing.Point(207, 53);
            this.Btn_AddTeacher.Name = "Btn_AddTeacher";
            this.Btn_AddTeacher.Size = new System.Drawing.Size(109, 23);
            this.Btn_AddTeacher.TabIndex = 0;
            this.Btn_AddTeacher.Text = "Add Teacher";
            this.Btn_AddTeacher.UseVisualStyleBackColor = true;
            this.Btn_AddTeacher.Click += new System.EventHandler(this.Btn_AddTeacher_Click);
            // 
            // Btn_AddStudent
            // 
            this.Btn_AddStudent.Location = new System.Drawing.Point(208, 111);
            this.Btn_AddStudent.Name = "Btn_AddStudent";
            this.Btn_AddStudent.Size = new System.Drawing.Size(109, 23);
            this.Btn_AddStudent.TabIndex = 0;
            this.Btn_AddStudent.Text = "Add Student";
            this.Btn_AddStudent.UseVisualStyleBackColor = true;
            // 
            // Btn_AddGroup
            // 
            this.Btn_AddGroup.Location = new System.Drawing.Point(207, 82);
            this.Btn_AddGroup.Name = "Btn_AddGroup";
            this.Btn_AddGroup.Size = new System.Drawing.Size(109, 23);
            this.Btn_AddGroup.TabIndex = 0;
            this.Btn_AddGroup.Text = "Add Group";
            this.Btn_AddGroup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 314);
            this.Controls.Add(this.Btn_AddGroup);
            this.Controls.Add(this.Btn_AddStudent);
            this.Controls.Add(this.Btn_AddTeacher);
            this.Controls.Add(this.Btn_AddSubject);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_AddSubject;
        private System.Windows.Forms.Button Btn_AddTeacher;
        private System.Windows.Forms.Button Btn_AddStudent;
        private System.Windows.Forms.Button Btn_AddGroup;
    }
}


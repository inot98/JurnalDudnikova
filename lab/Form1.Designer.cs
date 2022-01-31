
namespace lab
{
    partial class main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentFormBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectBut = new System.Windows.Forms.Button();
            this.AcadPerfBut = new System.Windows.Forms.Button();
            this.LessonBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentFormBut
            // 
            this.StudentFormBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentFormBut.Location = new System.Drawing.Point(139, 61);
            this.StudentFormBut.Name = "StudentFormBut";
            this.StudentFormBut.Size = new System.Drawing.Size(223, 29);
            this.StudentFormBut.TabIndex = 0;
            this.StudentFormBut.Text = "Список студентов";
            this.StudentFormBut.UseVisualStyleBackColor = true;
            this.StudentFormBut.Click += new System.EventHandler(this.StudentFormBut_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Электронный журнал";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubjectBut
            // 
            this.SubjectBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectBut.Location = new System.Drawing.Point(139, 96);
            this.SubjectBut.Name = "SubjectBut";
            this.SubjectBut.Size = new System.Drawing.Size(223, 29);
            this.SubjectBut.TabIndex = 0;
            this.SubjectBut.Text = "Список предметов";
            this.SubjectBut.UseVisualStyleBackColor = true;
            this.SubjectBut.Click += new System.EventHandler(this.SubjectBut_Click);
            // 
            // AcadPerfBut
            // 
            this.AcadPerfBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcadPerfBut.Location = new System.Drawing.Point(139, 131);
            this.AcadPerfBut.Name = "AcadPerfBut";
            this.AcadPerfBut.Size = new System.Drawing.Size(223, 29);
            this.AcadPerfBut.TabIndex = 0;
            this.AcadPerfBut.Text = "Успеваемость";
            this.AcadPerfBut.UseVisualStyleBackColor = true;
            this.AcadPerfBut.Click += new System.EventHandler(this.AcadPerfBut_Click);
            // 
            // LessonBut
            // 
            this.LessonBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LessonBut.Location = new System.Drawing.Point(139, 166);
            this.LessonBut.Name = "LessonBut";
            this.LessonBut.Size = new System.Drawing.Size(223, 29);
            this.LessonBut.TabIndex = 0;
            this.LessonBut.Text = "Занятия";
            this.LessonBut.UseVisualStyleBackColor = true;
            this.LessonBut.Click += new System.EventHandler(this.button3_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LessonBut);
            this.Controls.Add(this.AcadPerfBut);
            this.Controls.Add(this.SubjectBut);
            this.Controls.Add(this.StudentFormBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentFormBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubjectBut;
        private System.Windows.Forms.Button AcadPerfBut;
        private System.Windows.Forms.Button LessonBut;
    }
}


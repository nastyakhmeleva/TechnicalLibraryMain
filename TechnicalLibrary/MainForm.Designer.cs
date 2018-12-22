namespace TechnicalLibrary
{
    partial class MainForm
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
            this.AddNewDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewDoc
            // 
            this.AddNewDoc.Location = new System.Drawing.Point(12, 12);
            this.AddNewDoc.Name = "AddNewDoc";
            this.AddNewDoc.Size = new System.Drawing.Size(134, 68);
            this.AddNewDoc.TabIndex = 0;
            this.AddNewDoc.Text = "Добавить новый документ";
            this.AddNewDoc.UseVisualStyleBackColor = true;
            this.AddNewDoc.Click += new System.EventHandler(this.AddNewDoc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(472, 228);
            this.Controls.Add(this.AddNewDoc);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Техническая библиотека";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewDoc;
    }
}


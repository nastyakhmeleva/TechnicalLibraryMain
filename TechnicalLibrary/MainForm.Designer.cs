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
            this.dataGridViewDoc = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoc)).BeginInit();
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
            // dataGridViewDoc
            // 
            this.dataGridViewDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Year,
            this.Author});
            this.dataGridViewDoc.Location = new System.Drawing.Point(152, 12);
            this.dataGridViewDoc.MultiSelect = false;
            this.dataGridViewDoc.Name = "dataGridViewDoc";
            this.dataGridViewDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoc.Size = new System.Drawing.Size(668, 438);
            this.dataGridViewDoc.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Name
            // 
            this.Name.HeaderText = "Название";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 250;
            // 
            // Year
            // 
            this.Year.HeaderText = "Год";
            this.Year.Name = "Year";
            this.Year.Width = 70;
            // 
            // Author
            // 
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.Width = 250;
            // 
            // DeleteDoc
            // 
            this.DeleteDoc.Location = new System.Drawing.Point(12, 86);
            this.DeleteDoc.Name = "DeleteDoc";
            this.DeleteDoc.Size = new System.Drawing.Size(134, 68);
            this.DeleteDoc.TabIndex = 2;
            this.DeleteDoc.Text = "Удалить документ";
            this.DeleteDoc.UseVisualStyleBackColor = true;
            this.DeleteDoc.Click += new System.EventHandler(this.DeleteDoc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(832, 462);
            this.Controls.Add(this.DeleteDoc);
            this.Controls.Add(this.dataGridViewDoc);
            this.Controls.Add(this.AddNewDoc);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Техническая библиотека";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewDoc;
        private System.Windows.Forms.DataGridView dataGridViewDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.Button DeleteDoc;
    }
}


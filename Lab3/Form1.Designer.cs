namespace Lab3
{
    partial class Form1
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
            this.newElement_groupBox = new System.Windows.Forms.GroupBox();
            this.libraryList_dataGrid = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.lastname_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.nameBook_label = new System.Windows.Forms.Label();
            this.autor_groupBox = new System.Windows.Forms.GroupBox();
            this.pages_label = new System.Windows.Forms.Label();
            this.publ_label = new System.Windows.Forms.Label();
            this.genre_label = new System.Windows.Forms.Label();
            this.lastname_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.nameBook_box = new System.Windows.Forms.TextBox();
            this.pages_box = new System.Windows.Forms.TextBox();
            this.publ_box = new System.Windows.Forms.TextBox();
            this.genre_box = new System.Windows.Forms.TextBox();
            this.type_box = new System.Windows.Forms.CheckedListBox();
            this.newElement_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryList_dataGrid)).BeginInit();
            this.autor_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newElement_groupBox
            // 
            this.newElement_groupBox.Controls.Add(this.type_box);
            this.newElement_groupBox.Controls.Add(this.genre_box);
            this.newElement_groupBox.Controls.Add(this.publ_box);
            this.newElement_groupBox.Controls.Add(this.pages_box);
            this.newElement_groupBox.Controls.Add(this.nameBook_box);
            this.newElement_groupBox.Controls.Add(this.genre_label);
            this.newElement_groupBox.Controls.Add(this.publ_label);
            this.newElement_groupBox.Controls.Add(this.pages_label);
            this.newElement_groupBox.Controls.Add(this.autor_groupBox);
            this.newElement_groupBox.Controls.Add(this.nameBook_label);
            this.newElement_groupBox.Controls.Add(this.add_button);
            this.newElement_groupBox.Location = new System.Drawing.Point(22, 25);
            this.newElement_groupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newElement_groupBox.Name = "newElement_groupBox";
            this.newElement_groupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newElement_groupBox.Size = new System.Drawing.Size(1166, 191);
            this.newElement_groupBox.TabIndex = 0;
            this.newElement_groupBox.TabStop = false;
            this.newElement_groupBox.Text = "Добавить новый элемент";
            // 
            // libraryList_dataGrid
            // 
            this.libraryList_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.libraryList_dataGrid.Location = new System.Drawing.Point(22, 225);
            this.libraryList_dataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.libraryList_dataGrid.Name = "libraryList_dataGrid";
            this.libraryList_dataGrid.Size = new System.Drawing.Size(1166, 415);
            this.libraryList_dataGrid.TabIndex = 1;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(924, 18);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(233, 164);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // lastname_label
            // 
            this.lastname_label.AutoSize = true;
            this.lastname_label.Location = new System.Drawing.Point(9, 23);
            this.lastname_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastname_label.Name = "lastname_label";
            this.lastname_label.Size = new System.Drawing.Size(72, 19);
            this.lastname_label.TabIndex = 1;
            this.lastname_label.Text = "Фамилия";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(9, 63);
            this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(37, 19);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Имя";
            // 
            // nameBook_label
            // 
            this.nameBook_label.AutoSize = true;
            this.nameBook_label.Location = new System.Drawing.Point(567, 41);
            this.nameBook_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameBook_label.Name = "nameBook_label";
            this.nameBook_label.Size = new System.Drawing.Size(73, 19);
            this.nameBook_label.TabIndex = 3;
            this.nameBook_label.Text = "Название";
            // 
            // autor_groupBox
            // 
            this.autor_groupBox.Controls.Add(this.name_box);
            this.autor_groupBox.Controls.Add(this.lastname_box);
            this.autor_groupBox.Controls.Add(this.lastname_label);
            this.autor_groupBox.Controls.Add(this.name_label);
            this.autor_groupBox.Location = new System.Drawing.Point(245, 27);
            this.autor_groupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autor_groupBox.Name = "autor_groupBox";
            this.autor_groupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autor_groupBox.Size = new System.Drawing.Size(300, 106);
            this.autor_groupBox.TabIndex = 4;
            this.autor_groupBox.TabStop = false;
            this.autor_groupBox.Text = "Автор";
            // 
            // pages_label
            // 
            this.pages_label.AutoSize = true;
            this.pages_label.Location = new System.Drawing.Point(567, 73);
            this.pages_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pages_label.Name = "pages_label";
            this.pages_label.Size = new System.Drawing.Size(117, 19);
            this.pages_label.TabIndex = 5;
            this.pages_label.Text = "Кол-во страниц";
            // 
            // publ_label
            // 
            this.publ_label.AutoSize = true;
            this.publ_label.Location = new System.Drawing.Point(567, 105);
            this.publ_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publ_label.Name = "publ_label";
            this.publ_label.Size = new System.Drawing.Size(100, 19);
            this.publ_label.TabIndex = 6;
            this.publ_label.Text = "Издательство";
            // 
            // genre_label
            // 
            this.genre_label.AutoSize = true;
            this.genre_label.Location = new System.Drawing.Point(567, 137);
            this.genre_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(47, 19);
            this.genre_label.TabIndex = 7;
            this.genre_label.Text = "Жанр";
            // 
            // lastname_box
            // 
            this.lastname_box.Location = new System.Drawing.Point(88, 20);
            this.lastname_box.Name = "lastname_box";
            this.lastname_box.Size = new System.Drawing.Size(205, 26);
            this.lastname_box.TabIndex = 3;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(88, 56);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(205, 26);
            this.name_box.TabIndex = 4;
            // 
            // nameBook_box
            // 
            this.nameBook_box.Location = new System.Drawing.Point(695, 38);
            this.nameBook_box.Name = "nameBook_box";
            this.nameBook_box.Size = new System.Drawing.Size(205, 26);
            this.nameBook_box.TabIndex = 8;
            // 
            // pages_box
            // 
            this.pages_box.Location = new System.Drawing.Point(695, 70);
            this.pages_box.Name = "pages_box";
            this.pages_box.Size = new System.Drawing.Size(205, 26);
            this.pages_box.TabIndex = 9;
            // 
            // publ_box
            // 
            this.publ_box.Location = new System.Drawing.Point(695, 102);
            this.publ_box.Name = "publ_box";
            this.publ_box.Size = new System.Drawing.Size(205, 26);
            this.publ_box.TabIndex = 10;
            // 
            // genre_box
            // 
            this.genre_box.Location = new System.Drawing.Point(695, 134);
            this.genre_box.Name = "genre_box";
            this.genre_box.Size = new System.Drawing.Size(205, 26);
            this.genre_box.TabIndex = 11;
            // 
            // type_box
            // 
            this.type_box.FormattingEnabled = true;
            this.type_box.Items.AddRange(new object[] {
            "Книги",
            "Журналы"});
            this.type_box.Location = new System.Drawing.Point(16, 36);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(208, 130);
            this.type_box.TabIndex = 12;
            this.type_box.SelectedIndexChanged += new System.EventHandler(this.type_box_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.libraryList_dataGrid);
            this.Controls.Add(this.newElement_groupBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.newElement_groupBox.ResumeLayout(false);
            this.newElement_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryList_dataGrid)).EndInit();
            this.autor_groupBox.ResumeLayout(false);
            this.autor_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox newElement_groupBox;
        private System.Windows.Forms.CheckedListBox type_box;
        private System.Windows.Forms.TextBox genre_box;
        private System.Windows.Forms.TextBox publ_box;
        private System.Windows.Forms.TextBox pages_box;
        private System.Windows.Forms.TextBox nameBook_box;
        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.Label publ_label;
        private System.Windows.Forms.Label pages_label;
        private System.Windows.Forms.GroupBox autor_groupBox;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox lastname_box;
        private System.Windows.Forms.Label lastname_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label nameBook_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView libraryList_dataGrid;
    }
}


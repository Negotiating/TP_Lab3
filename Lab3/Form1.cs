using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        List<Library> libraries;

        public Form1()
        {
            InitializeComponent();
            libraries = new List<Library>() {
                new Book(new Author("Леру","Гастон"), "Призрак оперы", 120, "ИЗДАТЕЛЬСТВО","Роман"),
                new Book(new Author("Остин","Джейн"), "Гордость и предубеждение", 210, "ИЗДАТЕЛЬСТВО","Тоже роман"),
                new Magazine(new Author("Пелс", "Джессика"), "Cosmopolitan", 23, "Cosmopolitan", "журналы для женщин")
            };
            libraryList_dataGrid.DataSource = libraries;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            switch (type_box.SelectedIndex)
            {
                case 0:
                    libraries.Add(new Book(new Author(lastname_box.Text, name_box.Text), nameBook_box.Text, Convert.ToInt32(pages_box.Text), publ_box.Text, genre_box.Text));
                    break;
                case 1:
                    libraries.Add(new Magazine(new Author(lastname_box.Text, name_box.Text), nameBook_box.Text, Convert.ToInt32(pages_box.Text), publ_box.Text, genre_box.Text));
                    break;
            }
            libraryList_dataGrid.DataSource = null;
            libraryList_dataGrid.DataSource = libraries;
            libraryList_dataGrid.Update();
            libraryList_dataGrid.Refresh();
        }

        private void type_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (type_box.SelectedIndex)
            {
                case 0:
                    genre_label.Text = "Жанр";
                    break;
                case 1:
                    genre_label.Text = "Категория";
                    break ;
            }
        }
    }
}

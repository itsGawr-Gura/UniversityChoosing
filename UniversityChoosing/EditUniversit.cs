using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityChoosing
{
    public partial class EditUniversit : Form
    {
        public EditUniversit(string currentUniversityName, string currentCityName)
        {
            InitializeComponent();
            university.Text = currentUniversityName;
            city.Text = currentCityName;
        }
        public string GetEditedUniversityName()
        {
            return university.Text;
        }

        public string GetEditedUniversityCity()
        {
            return city.Text;
        }
        private void edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(university.Text) || string.IsNullOrEmpty(city.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityChoosing
{
    public partial class UniversityInfo : Form
    {
        private string universityName;
        private string cityName;
        public UniversityInfo(string universityName, string cityName)
        {
            InitializeComponent();
            this.universityName = universityName;
            this.cityName = cityName; 
            univer.Text = universityName;
            city.Text = cityName;
            LoadImage();
        }

        private void backBT_Click(object sender, EventArgs e)
        {
            this.Close();
            UniversityChoosing choose = new UniversityChoosing();
            choose.Show();
        }
        private void LoadImage()
        {
            string imagePath = Path.Combine("Images", universityName + ".jpg");
            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Изображение университета не найдено.");
            }
        }
    }
}

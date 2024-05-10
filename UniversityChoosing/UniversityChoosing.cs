using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace UniversityChoosing
{

    public partial class UniversityChoosing : Form
    {
        private string citiesFilePath = "City.txt";
        private string universitiesFilePath = "Universities.txt";
        private Dictionary<int, University> universities = new Dictionary<int, University>();
        public UniversityChoosing()
        {
            InitializeComponent();


            infoGW.Columns.Add("CityColumn", "Город");
            infoGW.Columns.Add("UniversityColumn", "Университет");
            LoadCities();
            LoadUniversities();
        }
        private void LoadCities()
        {
            if (File.Exists(citiesFilePath))
            {
                var cities = File.ReadAllLines(citiesFilePath);
                cityComboBox.Items.AddRange(cities);
            }
            else
            {
                MessageBox.Show("Файл городов не найден.");
            }
        }
        private void LoadUniversities()
        {
            if (File.Exists(universitiesFilePath))
            {
                var lines = File.ReadAllLines(universitiesFilePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    if (data.Length == 3 && int.TryParse(data[1], out int cityId) && int.TryParse(data[2], out int imageId))
                    {
                        var university = new University
                        {
                            Name = data[0],
                            CityId = cityId,
                            ImageId = imageId
                        };
                        universities.Add(universities.Count + 1, university);

                        infoGW.Rows.Add(cityComboBox.Items[university.CityId - 1], university.Name);
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл университетов не найден.");
            }

        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = cityComboBox.SelectedItem.ToString();
            infoGW.Rows.Clear();
            foreach (var university in universities.Values)
            {
                if (university.CityId == cityComboBox.SelectedIndex + 1)
                {

                    infoGW.Rows.Add(selectedCity, university.Name);
                }
            }
        }

        private void infoGW_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string universityName = infoGW.Rows[e.RowIndex].Cells["UniversityColumn"].Value.ToString();
            string cityName = infoGW.Rows[e.RowIndex].Cells["CityColumn"].Value.ToString();
            UniversityInfo info = new UniversityInfo(universityName, cityName);
            this.Hide();
            info.Show();
        }
    }
    public class University
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        public int ImageId { get; set; }
    }

}

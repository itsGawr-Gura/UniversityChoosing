using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        private void AddUniversity()
        {
            AddUniversity addForm = new AddUniversity();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                string newName = addForm.GetUniversityName();
                string newCity = addForm.GetUniversityCity();
                int newId = universities.Count + 6;
                University newUniversity = new University { Name = newName, CityId = cityComboBox.SelectedIndex + 1 };
                universities.Add(newId, newUniversity);
                infoGW.Rows.Add(newCity, newName);
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUniversity();
        }
        private void DeleteUniversity()
        {
            if (infoGW.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранный университет?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int selectedIndex = infoGW.SelectedRows[0].Index;
                    infoGW.Rows.RemoveAt(selectedIndex);
                    string deletedUniversityName = infoGW.Rows[selectedIndex].Cells["UniversityColumn"].Value.ToString();
                    foreach (var university in universities.Values)
                    {
                        if (university.Name == deletedUniversityName)
                        {
                            universities.Remove(universities.First(x => x.Value.Name == deletedUniversityName).Key);
                            break;
                        }
                    }
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUniversity();
        }
        private void EditUniversity()
        {
            if (infoGW.SelectedRows.Count > 0)
            {
                int selectedIndex = infoGW.SelectedRows[0].Index;
                string currentUniversityName = infoGW.Rows[selectedIndex].Cells["UniversityColumn"].Value.ToString();
                string currentCityName = infoGW.Rows[selectedIndex].Cells["CityColumn"].Value.ToString();
                EditUniversit editForm = new EditUniversit(currentUniversityName, currentCityName);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    string editedName = editForm.GetEditedUniversityName();
                    string editedCity = editForm.GetEditedUniversityCity();
                    infoGW.Rows[selectedIndex].Cells["UniversityColumn"].Value = editedName;
                    infoGW.Rows[selectedIndex].Cells["CityColumn"].Value = editedCity;
                    foreach (var university in universities.Values)
                    {
                        if (university.Name == currentUniversityName)
                        {
                            university.Name = editedName;
                            break;
                        }
                    }
                }
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUniversity();
        }
    }
    public class University
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        public int ImageId { get; set; }
    }

}

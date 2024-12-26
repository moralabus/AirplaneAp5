using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AirplaneAp5
{
    public partial class Form1 : Form
    {
        private List<Airplane> airplanes = new List<Airplane>();

        public Form1()
        {
            InitializeComponent();
            comboBoxModel.Items.AddRange(new string[] { "CargoAirplane", "PassengerAirplane", "BusinessClassAirplane" });
            comboBoxModel.SelectedIndex = 0; // Устанавливаем начальное значение комбобокса
        }

        private void buttonAddAirplaneWithFoto_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxAirplaneName.Text;
                string model = comboBoxModel.SelectedItem.ToString();
                int range = (int)numericUpDownRange.Value;
                decimal fuelConsumption = (decimal)numericUpDownFuelConsumption.Value;
                DateTime manufactureDate = dateTimePickerManufactureDate.Value;

                Airplane newAirplane = CreateAirplane(model, name, range, fuelConsumption, manufactureDate);

                if (newAirplane != null)
                {
                    airplanes.Add(newAirplane);
                    listBoxAirplanes.Items.Add(newAirplane.Name); // Добавляем только имя в ListBox

                    // Очистка элементов управления после добавления
                    ClearInputs();
                    MessageBox.Show("Самолет добавлен.");
                }
                else
                {
                    MessageBox.Show("Неверный тип самолета.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении самолета: {ex.Message}");
            }
        }

        private Airplane CreateAirplane(string model, string name, int range, decimal fuelConsumption, DateTime manufactureDate)
        {
            switch (model)
            {
                case "CargoAirplane":
                    int cargoCapacity = (int)numericUpDownCargoCapacity.Value;
                    string cargoType = textBoxCargoType.Text;
                    return new CargoAirplane(name, model, range, fuelConsumption, manufactureDate, null, cargoCapacity, cargoType);

                case "PassengerAirplane":
                    int passengerCapacity = (int)numericUpDownPassengerCapacity.Value;
                    bool hasBusinessClass = checkBoxHasBusinessClass.Checked;
                    return new PassengerAirplane(name, model, range, fuelConsumption, manufactureDate, null, passengerCapacity, hasBusinessClass);

                case "BusinessClassAirplane":
                    int businessClassCapacity = (int)numericUpDownBusinessClassCapacity.Value;
                    bool hasPrivateLounge = checkBoxHasPrivateLounge.Checked;
                    string[] amenities = listBoxAmenities.Items.Cast<string>().ToArray();
                    passengerCapacity = (int)numericUpDownPassengerCapacity.Value; // Здесь не нужно повторное определение
                    hasBusinessClass = checkBoxHasBusinessClass.Checked; // Здесь не нужно повторное определение
                    return new BusinessClassAirplane(name, model, range, fuelConsumption, manufactureDate, null, passengerCapacity, hasBusinessClass, businessClassCapacity, hasPrivateLounge, amenities);

                default:
                    return null; // Неверный тип самолета
            }
        }

        private void ClearInputs()
        {
            textBoxAirplaneName.Clear();
            numericUpDownCargoCapacity.Value = 0;
            textBoxCargoType.Clear();
            numericUpDownPassengerCapacity.Value = 0;
            checkBoxHasBusinessClass.Checked = false;
            numericUpDownBusinessClassCapacity.Value = 0;
            checkBoxHasPrivateLounge.Checked = false;
            listBoxAmenities.Items.Clear();
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Airplane.WriteToFile(airplanes, saveFileDialog.FileName);
                MessageBox.Show("Данные сохранены в файл.");
            }
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                airplanes = Airplane.ReadFromFile(openFileDialog.FileName);
                listBoxAirplanes.Items.Clear();
                foreach (Airplane airplane in airplanes)
                {
                    listBoxAirplanes.Items.Add(airplane.Name); // Добавляем только имя в ListBox
                }
                MessageBox.Show("Данные загружены из файла.");
            }
        }

        private void buttonShowAirplaneInfo_Click(object sender, EventArgs e)
        {
            if (listBoxAirplanes.SelectedItem != null)
            {
                string selectedAirplaneName = listBoxAirplanes.SelectedItem.ToString();
                Airplane selectedAirplane = airplanes.FirstOrDefault(a => a.Name == selectedAirplaneName);
                if (selectedAirplane != null)
                {
                    textBoxOutput.Text = selectedAirplane.GetInfo();
                }
                else
                {
                    MessageBox.Show("Самолет не найден.");
                }
            }
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModel = comboBoxModel.SelectedItem.ToString();
            ToggleVisibility(selectedModel);
        }

        private void ToggleVisibility(string selectedModel)
        {
            bool isCargo = selectedModel == "CargoAirplane";
            numericUpDownCargoCapacity.Visible = isCargo;
            textBoxCargoType.Visible = isCargo;
            textBoxCargoCapacityLabel.Visible = isCargo;
            textBoxCargoTypeLabel.Visible = isCargo;

            bool isPassengerOrBusiness = selectedModel == "PassengerAirplane" || selectedModel == "BusinessClassAirplane";
            numericUpDownPassengerCapacity.Visible = isPassengerOrBusiness;
            checkBoxHasBusinessClass.Visible = isPassengerOrBusiness;
            textBoxPassengerCapacityLabel.Visible = isPassengerOrBusiness;

            bool isBusiness = selectedModel == "BusinessClassAirplane";
            numericUpDownBusinessClassCapacity.Visible = isBusiness;
            checkBoxHasPrivateLounge.Visible = isBusiness;
            listBoxAmenities.Visible = isBusiness;
            textBoxBusinessClassCapacityLabel.Visible = isBusiness;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

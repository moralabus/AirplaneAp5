namespace AirplaneAp5
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
            this.textBoxAirplaneName = new System.Windows.Forms.TextBox();
            this.labelAirplaneName = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.numericUpDownRange = new System.Windows.Forms.NumericUpDown();
            this.labelRange = new System.Windows.Forms.Label();
            this.numericUpDownFuelConsumption = new System.Windows.Forms.NumericUpDown();
            this.labelFuelConsumption = new System.Windows.Forms.Label();
            this.dateTimePickerManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.labelManufactureDate = new System.Windows.Forms.Label();
            this.numericUpDownCargoCapacity = new System.Windows.Forms.NumericUpDown();
            this.textBoxCargoType = new System.Windows.Forms.TextBox();
            this.textBoxCargoCapacityLabel = new System.Windows.Forms.Label();
            this.textBoxCargoTypeLabel = new System.Windows.Forms.Label();
            this.numericUpDownPassengerCapacity = new System.Windows.Forms.NumericUpDown();
            this.checkBoxHasBusinessClass = new System.Windows.Forms.CheckBox();
            this.textBoxPassengerCapacityLabel = new System.Windows.Forms.Label();
            this.numericUpDownBusinessClassCapacity = new System.Windows.Forms.NumericUpDown();
            this.checkBoxHasPrivateLounge = new System.Windows.Forms.CheckBox();
            this.listBoxAmenities = new System.Windows.Forms.ListBox();
            this.textBoxBusinessClassCapacityLabel = new System.Windows.Forms.Label();
            this.buttonAddAirplaneWithFoto = new System.Windows.Forms.Button();
            this.listBoxAirplanes = new System.Windows.Forms.ListBox();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargoCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassengerCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBusinessClassCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAirplaneName
            // 
            this.textBoxAirplaneName.Location = new System.Drawing.Point(12, 45);
            this.textBoxAirplaneName.Name = "textBoxAirplaneName";
            this.textBoxAirplaneName.Size = new System.Drawing.Size(200, 31);
            this.textBoxAirplaneName.TabIndex = 0;
            // 
            // labelAirplaneName
            // 
            this.labelAirplaneName.AutoSize = true;
            this.labelAirplaneName.Location = new System.Drawing.Point(12, 15);
            this.labelAirplaneName.Name = "labelAirplaneName";
            this.labelAirplaneName.Size = new System.Drawing.Size(211, 25);
            this.labelAirplaneName.TabIndex = 1;
            this.labelAirplaneName.Text = "Название самолета";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(12, 107);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(200, 33);
            this.comboBoxModel.TabIndex = 2;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(12, 77);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(152, 25);
            this.labelModel.TabIndex = 3;
            this.labelModel.Text = "Вид самолета";
            // 
            // numericUpDownRange
            // 
            this.numericUpDownRange.Location = new System.Drawing.Point(12, 171);
            this.numericUpDownRange.Name = "numericUpDownRange";
            this.numericUpDownRange.Size = new System.Drawing.Size(200, 31);
            this.numericUpDownRange.TabIndex = 4;
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(12, 141);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(195, 25);
            this.labelRange.TabIndex = 5;
            this.labelRange.Text = "Дальность полета";
            // 
            // numericUpDownFuelConsumption
            // 
            this.numericUpDownFuelConsumption.Location = new System.Drawing.Point(12, 235);
            this.numericUpDownFuelConsumption.Name = "numericUpDownFuelConsumption";
            this.numericUpDownFuelConsumption.Size = new System.Drawing.Size(200, 31);
            this.numericUpDownFuelConsumption.TabIndex = 6;
            // 
            // labelFuelConsumption
            // 
            this.labelFuelConsumption.AutoSize = true;
            this.labelFuelConsumption.Location = new System.Drawing.Point(12, 205);
            this.labelFuelConsumption.Name = "labelFuelConsumption";
            this.labelFuelConsumption.Size = new System.Drawing.Size(342, 25);
            this.labelFuelConsumption.TabIndex = 7;
            this.labelFuelConsumption.Text = "Потребление горючего (л/100км)";
            // 
            // dateTimePickerManufactureDate
            // 
            this.dateTimePickerManufactureDate.Location = new System.Drawing.Point(12, 299);
            this.dateTimePickerManufactureDate.Name = "dateTimePickerManufactureDate";
            this.dateTimePickerManufactureDate.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerManufactureDate.TabIndex = 8;
            // 
            // labelManufactureDate
            // 
            this.labelManufactureDate.AutoSize = true;
            this.labelManufactureDate.Location = new System.Drawing.Point(12, 269);
            this.labelManufactureDate.Name = "labelManufactureDate";
            this.labelManufactureDate.Size = new System.Drawing.Size(206, 25);
            this.labelManufactureDate.TabIndex = 9;
            this.labelManufactureDate.Text = "Дата производства";
            // 
            // numericUpDownCargoCapacity
            // 
            this.numericUpDownCargoCapacity.Location = new System.Drawing.Point(246, 107);
            this.numericUpDownCargoCapacity.Name = "numericUpDownCargoCapacity";
            this.numericUpDownCargoCapacity.Size = new System.Drawing.Size(200, 31);
            this.numericUpDownCargoCapacity.TabIndex = 10;
            this.numericUpDownCargoCapacity.Visible = false;
            // 
            // textBoxCargoType
            // 
            this.textBoxCargoType.Location = new System.Drawing.Point(246, 171);
            this.textBoxCargoType.Name = "textBoxCargoType";
            this.textBoxCargoType.Size = new System.Drawing.Size(200, 31);
            this.textBoxCargoType.TabIndex = 11;
            this.textBoxCargoType.Visible = false;
            // 
            // textBoxCargoCapacityLabel
            // 
            this.textBoxCargoCapacityLabel.AutoSize = true;
            this.textBoxCargoCapacityLabel.Location = new System.Drawing.Point(246, 77);
            this.textBoxCargoCapacityLabel.Name = "textBoxCargoCapacityLabel";
            this.textBoxCargoCapacityLabel.Size = new System.Drawing.Size(202, 25);
            this.textBoxCargoCapacityLabel.TabIndex = 12;
            this.textBoxCargoCapacityLabel.Text = "Грузоподъемность";
            this.textBoxCargoCapacityLabel.Visible = false;
            // 
            // textBoxCargoTypeLabel
            // 
            this.textBoxCargoTypeLabel.AutoSize = true;
            this.textBoxCargoTypeLabel.Location = new System.Drawing.Point(246, 141);
            this.textBoxCargoTypeLabel.Name = "textBoxCargoTypeLabel";
            this.textBoxCargoTypeLabel.Size = new System.Drawing.Size(109, 25);
            this.textBoxCargoTypeLabel.TabIndex = 13;
            this.textBoxCargoTypeLabel.Text = "Тип груза";
            this.textBoxCargoTypeLabel.Visible = false;
            // 
            // numericUpDownPassengerCapacity
            // 
            this.numericUpDownPassengerCapacity.Location = new System.Drawing.Point(246, 235);
            this.numericUpDownPassengerCapacity.Name = "numericUpDownPassengerCapacity";
            this.numericUpDownPassengerCapacity.Size = new System.Drawing.Size(200, 31);
            this.numericUpDownPassengerCapacity.TabIndex = 14;
            this.numericUpDownPassengerCapacity.Visible = false;
            // 
            // checkBoxHasBusinessClass
            // 
            this.checkBoxHasBusinessClass.AutoSize = true;
            this.checkBoxHasBusinessClass.Location = new System.Drawing.Point(246, 299);
            this.checkBoxHasBusinessClass.Name = "checkBoxHasBusinessClass";
            this.checkBoxHasBusinessClass.Size = new System.Drawing.Size(180, 29);
            this.checkBoxHasBusinessClass.TabIndex = 15;
            this.checkBoxHasBusinessClass.Text = "Бизнес-класс";
            this.checkBoxHasBusinessClass.UseVisualStyleBackColor = true;
            this.checkBoxHasBusinessClass.Visible = false;
            // 
            // textBoxPassengerCapacityLabel
            // 
            this.textBoxPassengerCapacityLabel.AutoSize = true;
            this.textBoxPassengerCapacityLabel.Location = new System.Drawing.Point(246, 205);
            this.textBoxPassengerCapacityLabel.Name = "textBoxPassengerCapacityLabel";
            this.textBoxPassengerCapacityLabel.Size = new System.Drawing.Size(145, 25);
            this.textBoxPassengerCapacityLabel.TabIndex = 16;
            this.textBoxPassengerCapacityLabel.Text = "Вместимость";
            this.textBoxPassengerCapacityLabel.Visible = false;
            // 
            // numericUpDownBusinessClassCapacity
            // 
            this.numericUpDownBusinessClassCapacity.Location = new System.Drawing.Point(480, 107);
            this.numericUpDownBusinessClassCapacity.Name = "numericUpDownBusinessClassCapacity";
            this.numericUpDownBusinessClassCapacity.Size = new System.Drawing.Size(200, 31);
            this.numericUpDownBusinessClassCapacity.TabIndex = 17;
            this.numericUpDownBusinessClassCapacity.Visible = false;
            // 
            // checkBoxHasPrivateLounge
            // 
            this.checkBoxHasPrivateLounge.AutoSize = true;
            this.checkBoxHasPrivateLounge.Location = new System.Drawing.Point(480, 171);
            this.checkBoxHasPrivateLounge.Name = "checkBoxHasPrivateLounge";
            this.checkBoxHasPrivateLounge.Size = new System.Drawing.Size(224, 29);
            this.checkBoxHasPrivateLounge.TabIndex = 18;
            this.checkBoxHasPrivateLounge.Text = "Отдельный лаунж";
            this.checkBoxHasPrivateLounge.UseVisualStyleBackColor = true;
            this.checkBoxHasPrivateLounge.Visible = false;
            // 
            // listBoxAmenities
            // 
            this.listBoxAmenities.FormattingEnabled = true;
            this.listBoxAmenities.ItemHeight = 25;
            this.listBoxAmenities.Location = new System.Drawing.Point(480, 235);
            this.listBoxAmenities.Name = "listBoxAmenities";
            this.listBoxAmenities.Size = new System.Drawing.Size(200, 104);
            this.listBoxAmenities.TabIndex = 19;
            this.listBoxAmenities.Visible = false;
            // 
            // textBoxBusinessClassCapacityLabel
            // 
            this.textBoxBusinessClassCapacityLabel.AutoSize = true;
            this.textBoxBusinessClassCapacityLabel.Location = new System.Drawing.Point(480, 77);
            this.textBoxBusinessClassCapacityLabel.Name = "textBoxBusinessClassCapacityLabel";
            this.textBoxBusinessClassCapacityLabel.Size = new System.Drawing.Size(297, 25);
            this.textBoxBusinessClassCapacityLabel.TabIndex = 20;
            this.textBoxBusinessClassCapacityLabel.Text = "Вместимость бизнес-класса";
            this.textBoxBusinessClassCapacityLabel.Visible = false;
            // 
            // buttonAddAirplaneWithFoto
            // 
            this.buttonAddAirplaneWithFoto.Location = new System.Drawing.Point(12, 358);
            this.buttonAddAirplaneWithFoto.Name = "buttonAddAirplaneWithFoto";
            this.buttonAddAirplaneWithFoto.Size = new System.Drawing.Size(250, 44);
            this.buttonAddAirplaneWithFoto.TabIndex = 21;
            this.buttonAddAirplaneWithFoto.Text = "Добавить самолет";
            this.buttonAddAirplaneWithFoto.UseVisualStyleBackColor = true;
            this.buttonAddAirplaneWithFoto.Click += new System.EventHandler(this.buttonAddAirplaneWithFoto_Click);
            // 
            // listBoxAirplanes
            // 
            this.listBoxAirplanes.FormattingEnabled = true;
            this.listBoxAirplanes.ItemHeight = 25;
            this.listBoxAirplanes.Location = new System.Drawing.Point(720, 45);
            this.listBoxAirplanes.Name = "listBoxAirplanes";
            this.listBoxAirplanes.Size = new System.Drawing.Size(200, 279);
            this.listBoxAirplanes.TabIndex = 22;
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(12, 418);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(250, 44);
            this.buttonSaveToFile.TabIndex = 25;
            this.buttonSaveToFile.Text = "Сохранить в файл";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(12, 478);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(250, 44);
            this.buttonLoadFromFile.TabIndex = 26;
            this.buttonLoadFromFile.Text = "Загрузить из файла";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(720, 358);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(380, 173);
            this.textBoxOutput.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 564);
            this.Controls.Add(this.buttonLoadFromFile);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.listBoxAirplanes);
            this.Controls.Add(this.buttonAddAirplaneWithFoto);
            this.Controls.Add(this.textBoxBusinessClassCapacityLabel);
            this.Controls.Add(this.listBoxAmenities);
            this.Controls.Add(this.checkBoxHasPrivateLounge);
            this.Controls.Add(this.numericUpDownBusinessClassCapacity);
            this.Controls.Add(this.textBoxPassengerCapacityLabel);
            this.Controls.Add(this.checkBoxHasBusinessClass);
            this.Controls.Add(this.numericUpDownPassengerCapacity);
            this.Controls.Add(this.textBoxCargoTypeLabel);
            this.Controls.Add(this.textBoxCargoCapacityLabel);
            this.Controls.Add(this.textBoxCargoType);
            this.Controls.Add(this.numericUpDownCargoCapacity);
            this.Controls.Add(this.labelManufactureDate);
            this.Controls.Add(this.dateTimePickerManufactureDate);
            this.Controls.Add(this.labelFuelConsumption);
            this.Controls.Add(this.numericUpDownFuelConsumption);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.numericUpDownRange);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.labelAirplaneName);
            this.Controls.Add(this.textBoxAirplaneName);
            this.Name = "Form1";
            this.Text = "Самолеты";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCargoCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassengerCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBusinessClassCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAirplaneName;
        private System.Windows.Forms.Label labelAirplaneName;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.NumericUpDown numericUpDownRange;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.NumericUpDown numericUpDownFuelConsumption;
        private System.Windows.Forms.Label labelFuelConsumption;
        private System.Windows.Forms.DateTimePicker dateTimePickerManufactureDate;
        private System.Windows.Forms.Label labelManufactureDate;
        private System.Windows.Forms.NumericUpDown numericUpDownCargoCapacity;
        private System.Windows.Forms.TextBox textBoxCargoType;
        private System.Windows.Forms.Label textBoxCargoCapacityLabel;
        private System.Windows.Forms.Label textBoxCargoTypeLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownPassengerCapacity;
        private System.Windows.Forms.CheckBox checkBoxHasBusinessClass;
        private System.Windows.Forms.Label textBoxPassengerCapacityLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownBusinessClassCapacity;
        private System.Windows.Forms.CheckBox checkBoxHasPrivateLounge;
        private System.Windows.Forms.ListBox listBoxAmenities;
        private System.Windows.Forms.Label textBoxBusinessClassCapacityLabel;
        private System.Windows.Forms.Button buttonAddAirplaneWithFoto;
        private System.Windows.Forms.ListBox listBoxAirplanes;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}
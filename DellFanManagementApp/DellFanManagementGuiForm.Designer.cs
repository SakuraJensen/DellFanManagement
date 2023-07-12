
namespace DellFanManagement.App
{
    partial class DellFanManagementGuiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DellFanManagementGuiForm));
            fansGroupBox = new System.Windows.Forms.GroupBox();
            fan2RpmLabel = new System.Windows.Forms.Label();
            fan1RpmLabel = new System.Windows.Forms.Label();
            thermalSettingGroupBox = new System.Windows.Forms.GroupBox();
            thermalSettingRadioButtonPerformance = new System.Windows.Forms.RadioButton();
            thermalSettingRadioButtonQuiet = new System.Windows.Forms.RadioButton();
            thermalSettingRadioButtonCool = new System.Windows.Forms.RadioButton();
            thermalSettingRadioButtonOptimized = new System.Windows.Forms.RadioButton();
            temperatureGroupBox = new System.Windows.Forms.GroupBox();
            temperatureLabel18 = new System.Windows.Forms.Label();
            temperatureLabel17 = new System.Windows.Forms.Label();
            temperatureLabel16 = new System.Windows.Forms.Label();
            temperatureLabel15 = new System.Windows.Forms.Label();
            temperatureLabel14 = new System.Windows.Forms.Label();
            temperatureLabel13 = new System.Windows.Forms.Label();
            temperatureLabel12 = new System.Windows.Forms.Label();
            temperatureLabel11 = new System.Windows.Forms.Label();
            temperatureLabel10 = new System.Windows.Forms.Label();
            temperatureLabel9 = new System.Windows.Forms.Label();
            temperatureLabel8 = new System.Windows.Forms.Label();
            temperatureLabel7 = new System.Windows.Forms.Label();
            temperatureLabel6 = new System.Windows.Forms.Label();
            temperatureLabel5 = new System.Windows.Forms.Label();
            temperatureLabel4 = new System.Windows.Forms.Label();
            temperatureLabel3 = new System.Windows.Forms.Label();
            temperatureLabel2 = new System.Windows.Forms.Label();
            temperatureLabel1 = new System.Windows.Forms.Label();
            operationModeGroupBox = new System.Windows.Forms.GroupBox();
            operationModeRadioButtonConsistency = new System.Windows.Forms.RadioButton();
            operationModeRadioButtonManual = new System.Windows.Forms.RadioButton();
            operationModeRadioButtonAutomatic = new System.Windows.Forms.RadioButton();
            manualGroupBox = new System.Windows.Forms.GroupBox();
            manualFan2GroupBox = new System.Windows.Forms.GroupBox();
            manualFan2RadioButtonHigh = new System.Windows.Forms.RadioButton();
            manualFan2RadioButtonMedium = new System.Windows.Forms.RadioButton();
            manualFan2RadioButtonOff = new System.Windows.Forms.RadioButton();
            manualFan1GroupBox = new System.Windows.Forms.GroupBox();
            manualFan1RadioButtonHigh = new System.Windows.Forms.RadioButton();
            manualFan1RadioButtonMedium = new System.Windows.Forms.RadioButton();
            manualFan1RadioButtonOff = new System.Windows.Forms.RadioButton();
            consistencyModeGroupBox = new System.Windows.Forms.GroupBox();
            alertsCheckBox = new System.Windows.Forms.CheckBox();
            consistencyModeApplyChangesButton = new System.Windows.Forms.Button();
            consistencyModeRpmThresholdTextBox = new System.Windows.Forms.TextBox();
            consistencyModeRpmThresholdLabel = new System.Windows.Forms.Label();
            consistencyModeUpperTemperatureThresholdTextBox = new System.Windows.Forms.TextBox();
            consistencyModeUpperTemperatureThresholdLabel = new System.Windows.Forms.Label();
            consistencyModeLowerTemperatureThresholdTextBox = new System.Windows.Forms.TextBox();
            consistencyModeLowerTemperatureThresholdLabel = new System.Windows.Forms.Label();
            ecFanControlRadioButtonOn = new System.Windows.Forms.RadioButton();
            ecFanControlRadioButtonOff = new System.Windows.Forms.RadioButton();
            ecFanControlGroupBox = new System.Windows.Forms.GroupBox();
            restartBackgroundThreadButton = new System.Windows.Forms.Button();
            aboutGroupBox = new System.Windows.Forms.GroupBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            aboutProductLabel = new System.Windows.Forms.Label();
            audioKeepAliveGroupBox = new System.Windows.Forms.GroupBox();
            audioKeepAliveComboBox = new System.Windows.Forms.ComboBox();
            audioKeepAliveCheckbox = new System.Windows.Forms.CheckBox();
            statusStrip = new System.Windows.Forms.StatusStrip();
            consistencyModeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            trayIcon = new System.Windows.Forms.NotifyIcon(components);
            trayIconCheckBox = new System.Windows.Forms.CheckBox();
            animatedCheckBox = new System.Windows.Forms.CheckBox();
            fansGroupBox.SuspendLayout();
            thermalSettingGroupBox.SuspendLayout();
            temperatureGroupBox.SuspendLayout();
            operationModeGroupBox.SuspendLayout();
            manualGroupBox.SuspendLayout();
            manualFan2GroupBox.SuspendLayout();
            manualFan1GroupBox.SuspendLayout();
            consistencyModeGroupBox.SuspendLayout();
            ecFanControlGroupBox.SuspendLayout();
            aboutGroupBox.SuspendLayout();
            audioKeepAliveGroupBox.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // fansGroupBox
            // 
            fansGroupBox.Controls.Add(fan2RpmLabel);
            fansGroupBox.Controls.Add(fan1RpmLabel);
            fansGroupBox.Location = new System.Drawing.Point(12, 12);
            fansGroupBox.Name = "fansGroupBox";
            fansGroupBox.Size = new System.Drawing.Size(223, 65);
            fansGroupBox.TabIndex = 1;
            fansGroupBox.TabStop = false;
            fansGroupBox.Text = "Fans:";
            // 
            // fan2RpmLabel
            // 
            fan2RpmLabel.AutoSize = true;
            fan2RpmLabel.Location = new System.Drawing.Point(6, 38);
            fan2RpmLabel.Name = "fan2RpmLabel";
            fan2RpmLabel.Size = new System.Drawing.Size(152, 15);
            fan2RpmLabel.TabIndex = 2;
            fan2RpmLabel.Text = "Fan 2 RPM: (Not measured)";
            // 
            // fan1RpmLabel
            // 
            fan1RpmLabel.AutoSize = true;
            fan1RpmLabel.Location = new System.Drawing.Point(6, 19);
            fan1RpmLabel.Name = "fan1RpmLabel";
            fan1RpmLabel.Size = new System.Drawing.Size(152, 15);
            fan1RpmLabel.TabIndex = 1;
            fan1RpmLabel.Text = "Fan 1 RPM: (Not measured)";
            // 
            // thermalSettingGroupBox
            // 
            thermalSettingGroupBox.Controls.Add(thermalSettingRadioButtonPerformance);
            thermalSettingGroupBox.Controls.Add(thermalSettingRadioButtonQuiet);
            thermalSettingGroupBox.Controls.Add(thermalSettingRadioButtonCool);
            thermalSettingGroupBox.Controls.Add(thermalSettingRadioButtonOptimized);
            thermalSettingGroupBox.Location = new System.Drawing.Point(350, 117);
            thermalSettingGroupBox.Name = "thermalSettingGroupBox";
            thermalSettingGroupBox.Size = new System.Drawing.Size(111, 124);
            thermalSettingGroupBox.TabIndex = 6;
            thermalSettingGroupBox.TabStop = false;
            thermalSettingGroupBox.Text = "Thermal setting:";
            // 
            // thermalSettingRadioButtonPerformance
            // 
            thermalSettingRadioButtonPerformance.AutoSize = true;
            thermalSettingRadioButtonPerformance.Location = new System.Drawing.Point(6, 97);
            thermalSettingRadioButtonPerformance.Name = "thermalSettingRadioButtonPerformance";
            thermalSettingRadioButtonPerformance.Size = new System.Drawing.Size(93, 19);
            thermalSettingRadioButtonPerformance.TabIndex = 3;
            thermalSettingRadioButtonPerformance.TabStop = true;
            thermalSettingRadioButtonPerformance.Text = "&Performance";
            thermalSettingRadioButtonPerformance.UseVisualStyleBackColor = true;
            // 
            // thermalSettingRadioButtonQuiet
            // 
            thermalSettingRadioButtonQuiet.AutoSize = true;
            thermalSettingRadioButtonQuiet.Location = new System.Drawing.Point(6, 72);
            thermalSettingRadioButtonQuiet.Name = "thermalSettingRadioButtonQuiet";
            thermalSettingRadioButtonQuiet.Size = new System.Drawing.Size(54, 19);
            thermalSettingRadioButtonQuiet.TabIndex = 2;
            thermalSettingRadioButtonQuiet.TabStop = true;
            thermalSettingRadioButtonQuiet.Text = "&Quiet";
            thermalSettingRadioButtonQuiet.UseVisualStyleBackColor = true;
            // 
            // thermalSettingRadioButtonCool
            // 
            thermalSettingRadioButtonCool.AutoSize = true;
            thermalSettingRadioButtonCool.Location = new System.Drawing.Point(6, 47);
            thermalSettingRadioButtonCool.Name = "thermalSettingRadioButtonCool";
            thermalSettingRadioButtonCool.Size = new System.Drawing.Size(50, 19);
            thermalSettingRadioButtonCool.TabIndex = 1;
            thermalSettingRadioButtonCool.TabStop = true;
            thermalSettingRadioButtonCool.Text = "&Cool";
            thermalSettingRadioButtonCool.UseVisualStyleBackColor = true;
            // 
            // thermalSettingRadioButtonOptimized
            // 
            thermalSettingRadioButtonOptimized.AutoSize = true;
            thermalSettingRadioButtonOptimized.Location = new System.Drawing.Point(6, 22);
            thermalSettingRadioButtonOptimized.Name = "thermalSettingRadioButtonOptimized";
            thermalSettingRadioButtonOptimized.Size = new System.Drawing.Size(80, 19);
            thermalSettingRadioButtonOptimized.TabIndex = 0;
            thermalSettingRadioButtonOptimized.TabStop = true;
            thermalSettingRadioButtonOptimized.Text = "&Optimized";
            thermalSettingRadioButtonOptimized.UseVisualStyleBackColor = true;
            // 
            // temperatureGroupBox
            // 
            temperatureGroupBox.Controls.Add(temperatureLabel18);
            temperatureGroupBox.Controls.Add(temperatureLabel17);
            temperatureGroupBox.Controls.Add(temperatureLabel16);
            temperatureGroupBox.Controls.Add(temperatureLabel15);
            temperatureGroupBox.Controls.Add(temperatureLabel14);
            temperatureGroupBox.Controls.Add(temperatureLabel13);
            temperatureGroupBox.Controls.Add(temperatureLabel12);
            temperatureGroupBox.Controls.Add(temperatureLabel11);
            temperatureGroupBox.Controls.Add(temperatureLabel10);
            temperatureGroupBox.Controls.Add(temperatureLabel9);
            temperatureGroupBox.Controls.Add(temperatureLabel8);
            temperatureGroupBox.Controls.Add(temperatureLabel7);
            temperatureGroupBox.Controls.Add(temperatureLabel6);
            temperatureGroupBox.Controls.Add(temperatureLabel5);
            temperatureGroupBox.Controls.Add(temperatureLabel4);
            temperatureGroupBox.Controls.Add(temperatureLabel3);
            temperatureGroupBox.Controls.Add(temperatureLabel2);
            temperatureGroupBox.Controls.Add(temperatureLabel1);
            temperatureGroupBox.Location = new System.Drawing.Point(12, 83);
            temperatureGroupBox.Name = "temperatureGroupBox";
            temperatureGroupBox.Size = new System.Drawing.Size(332, 199);
            temperatureGroupBox.TabIndex = 4;
            temperatureGroupBox.TabStop = false;
            temperatureGroupBox.Text = "Temperatures:";
            // 
            // temperatureLabel18
            // 
            temperatureLabel18.AutoSize = true;
            temperatureLabel18.Location = new System.Drawing.Point(167, 175);
            temperatureLabel18.Name = "temperatureLabel18";
            temperatureLabel18.Size = new System.Drawing.Size(160, 15);
            temperatureLabel18.TabIndex = 3;
            temperatureLabel18.Text = "Quadro RTX 5000: 50 (50-100)";
            // 
            // temperatureLabel17
            // 
            temperatureLabel17.AutoSize = true;
            temperatureLabel17.Location = new System.Drawing.Point(167, 156);
            temperatureLabel17.Name = "temperatureLabel17";
            temperatureLabel17.Size = new System.Drawing.Size(141, 15);
            temperatureLabel17.TabIndex = 3;
            temperatureLabel17.Text = "CPU Package: 50 (50-100)";
            // 
            // temperatureLabel16
            // 
            temperatureLabel16.AutoSize = true;
            temperatureLabel16.Location = new System.Drawing.Point(167, 137);
            temperatureLabel16.Name = "temperatureLabel16";
            temperatureLabel16.Size = new System.Drawing.Size(144, 15);
            temperatureLabel16.TabIndex = 15;
            temperatureLabel16.Text = "CPU Core #16: 50 (50-100)";
            // 
            // temperatureLabel15
            // 
            temperatureLabel15.AutoSize = true;
            temperatureLabel15.Location = new System.Drawing.Point(167, 118);
            temperatureLabel15.Name = "temperatureLabel15";
            temperatureLabel15.Size = new System.Drawing.Size(144, 15);
            temperatureLabel15.TabIndex = 14;
            temperatureLabel15.Text = "CPU Core #15: 50 (50-100)";
            // 
            // temperatureLabel14
            // 
            temperatureLabel14.AutoSize = true;
            temperatureLabel14.Location = new System.Drawing.Point(167, 99);
            temperatureLabel14.Name = "temperatureLabel14";
            temperatureLabel14.Size = new System.Drawing.Size(144, 15);
            temperatureLabel14.TabIndex = 13;
            temperatureLabel14.Text = "CPU Core #14: 50 (50-100)";
            // 
            // temperatureLabel13
            // 
            temperatureLabel13.AutoSize = true;
            temperatureLabel13.Location = new System.Drawing.Point(167, 80);
            temperatureLabel13.Name = "temperatureLabel13";
            temperatureLabel13.Size = new System.Drawing.Size(144, 15);
            temperatureLabel13.TabIndex = 12;
            temperatureLabel13.Text = "CPU Core #13: 50 (50-100)";
            // 
            // temperatureLabel12
            // 
            temperatureLabel12.AutoSize = true;
            temperatureLabel12.Location = new System.Drawing.Point(167, 61);
            temperatureLabel12.Name = "temperatureLabel12";
            temperatureLabel12.Size = new System.Drawing.Size(144, 15);
            temperatureLabel12.TabIndex = 11;
            temperatureLabel12.Text = "CPU Core #12: 50 (50-100)";
            // 
            // temperatureLabel11
            // 
            temperatureLabel11.AutoSize = true;
            temperatureLabel11.Location = new System.Drawing.Point(167, 42);
            temperatureLabel11.Name = "temperatureLabel11";
            temperatureLabel11.Size = new System.Drawing.Size(144, 15);
            temperatureLabel11.TabIndex = 10;
            temperatureLabel11.Text = "CPU Core #11: 50 (50-100)";
            // 
            // temperatureLabel10
            // 
            temperatureLabel10.AutoSize = true;
            temperatureLabel10.Location = new System.Drawing.Point(167, 23);
            temperatureLabel10.Name = "temperatureLabel10";
            temperatureLabel10.Size = new System.Drawing.Size(144, 15);
            temperatureLabel10.TabIndex = 9;
            temperatureLabel10.Text = "CPU Core #10: 50 (50-100)";
            // 
            // temperatureLabel9
            // 
            temperatureLabel9.AutoSize = true;
            temperatureLabel9.Location = new System.Drawing.Point(6, 175);
            temperatureLabel9.Name = "temperatureLabel9";
            temperatureLabel9.Size = new System.Drawing.Size(138, 15);
            temperatureLabel9.TabIndex = 8;
            temperatureLabel9.Text = "CPU Core #9: 50 (50-100)";
            // 
            // temperatureLabel8
            // 
            temperatureLabel8.AutoSize = true;
            temperatureLabel8.Location = new System.Drawing.Point(6, 156);
            temperatureLabel8.Name = "temperatureLabel8";
            temperatureLabel8.Size = new System.Drawing.Size(138, 15);
            temperatureLabel8.TabIndex = 7;
            temperatureLabel8.Text = "CPU Core #8: 50 (50-100)";
            // 
            // temperatureLabel7
            // 
            temperatureLabel7.AutoSize = true;
            temperatureLabel7.Location = new System.Drawing.Point(6, 137);
            temperatureLabel7.Name = "temperatureLabel7";
            temperatureLabel7.Size = new System.Drawing.Size(138, 15);
            temperatureLabel7.TabIndex = 6;
            temperatureLabel7.Text = "CPU Core #7: 50 (50-100)";
            // 
            // temperatureLabel6
            // 
            temperatureLabel6.AutoSize = true;
            temperatureLabel6.Location = new System.Drawing.Point(6, 118);
            temperatureLabel6.Name = "temperatureLabel6";
            temperatureLabel6.Size = new System.Drawing.Size(138, 15);
            temperatureLabel6.TabIndex = 5;
            temperatureLabel6.Text = "CPU Core #6: 50 (50-100)";
            // 
            // temperatureLabel5
            // 
            temperatureLabel5.AutoSize = true;
            temperatureLabel5.Location = new System.Drawing.Point(6, 99);
            temperatureLabel5.Name = "temperatureLabel5";
            temperatureLabel5.Size = new System.Drawing.Size(138, 15);
            temperatureLabel5.TabIndex = 4;
            temperatureLabel5.Text = "CPU Core #5: 50 (50-100)";
            // 
            // temperatureLabel4
            // 
            temperatureLabel4.AutoSize = true;
            temperatureLabel4.Location = new System.Drawing.Point(6, 80);
            temperatureLabel4.Name = "temperatureLabel4";
            temperatureLabel4.Size = new System.Drawing.Size(138, 15);
            temperatureLabel4.TabIndex = 3;
            temperatureLabel4.Text = "CPU Core #4: 50 (50-100)";
            // 
            // temperatureLabel3
            // 
            temperatureLabel3.AutoSize = true;
            temperatureLabel3.Location = new System.Drawing.Point(6, 61);
            temperatureLabel3.Name = "temperatureLabel3";
            temperatureLabel3.Size = new System.Drawing.Size(138, 15);
            temperatureLabel3.TabIndex = 2;
            temperatureLabel3.Text = "CPU Core #3: 50 (50-100)";
            // 
            // temperatureLabel2
            // 
            temperatureLabel2.AutoSize = true;
            temperatureLabel2.Location = new System.Drawing.Point(6, 42);
            temperatureLabel2.Name = "temperatureLabel2";
            temperatureLabel2.Size = new System.Drawing.Size(138, 15);
            temperatureLabel2.TabIndex = 1;
            temperatureLabel2.Text = "CPU Core #2: 50 (50-100)";
            // 
            // temperatureLabel1
            // 
            temperatureLabel1.AutoSize = true;
            temperatureLabel1.Location = new System.Drawing.Point(6, 23);
            temperatureLabel1.Name = "temperatureLabel1";
            temperatureLabel1.Size = new System.Drawing.Size(138, 15);
            temperatureLabel1.TabIndex = 0;
            temperatureLabel1.Text = "CPU Core #1: 50 (50-100)";
            // 
            // operationModeGroupBox
            // 
            operationModeGroupBox.Controls.Add(operationModeRadioButtonConsistency);
            operationModeGroupBox.Controls.Add(operationModeRadioButtonManual);
            operationModeGroupBox.Controls.Add(operationModeRadioButtonAutomatic);
            operationModeGroupBox.Location = new System.Drawing.Point(350, 12);
            operationModeGroupBox.Name = "operationModeGroupBox";
            operationModeGroupBox.Size = new System.Drawing.Size(111, 99);
            operationModeGroupBox.TabIndex = 5;
            operationModeGroupBox.TabStop = false;
            operationModeGroupBox.Text = "Operation mode:";
            // 
            // operationModeRadioButtonConsistency
            // 
            operationModeRadioButtonConsistency.AutoSize = true;
            operationModeRadioButtonConsistency.Location = new System.Drawing.Point(6, 72);
            operationModeRadioButtonConsistency.Name = "operationModeRadioButtonConsistency";
            operationModeRadioButtonConsistency.Size = new System.Drawing.Size(89, 19);
            operationModeRadioButtonConsistency.TabIndex = 2;
            operationModeRadioButtonConsistency.TabStop = true;
            operationModeRadioButtonConsistency.Text = "Con&sistency";
            operationModeRadioButtonConsistency.UseVisualStyleBackColor = true;
            // 
            // operationModeRadioButtonManual
            // 
            operationModeRadioButtonManual.AutoSize = true;
            operationModeRadioButtonManual.Location = new System.Drawing.Point(6, 47);
            operationModeRadioButtonManual.Name = "operationModeRadioButtonManual";
            operationModeRadioButtonManual.Size = new System.Drawing.Size(65, 19);
            operationModeRadioButtonManual.TabIndex = 1;
            operationModeRadioButtonManual.TabStop = true;
            operationModeRadioButtonManual.Text = "&Manual";
            operationModeRadioButtonManual.UseVisualStyleBackColor = true;
            operationModeRadioButtonManual.CheckedChanged += operationModeRadioButtonManual_CheckedChanged;
            // 
            // operationModeRadioButtonAutomatic
            // 
            operationModeRadioButtonAutomatic.AutoSize = true;
            operationModeRadioButtonAutomatic.Location = new System.Drawing.Point(6, 22);
            operationModeRadioButtonAutomatic.Name = "operationModeRadioButtonAutomatic";
            operationModeRadioButtonAutomatic.Size = new System.Drawing.Size(81, 19);
            operationModeRadioButtonAutomatic.TabIndex = 0;
            operationModeRadioButtonAutomatic.TabStop = true;
            operationModeRadioButtonAutomatic.Text = "&Automatic";
            operationModeRadioButtonAutomatic.UseVisualStyleBackColor = true;
            // 
            // manualGroupBox
            // 
            manualGroupBox.Controls.Add(manualFan2GroupBox);
            manualGroupBox.Controls.Add(manualFan1GroupBox);
            manualGroupBox.Location = new System.Drawing.Point(467, 12);
            manualGroupBox.Name = "manualGroupBox";
            manualGroupBox.Size = new System.Drawing.Size(194, 126);
            manualGroupBox.TabIndex = 9;
            manualGroupBox.TabStop = false;
            manualGroupBox.Text = "Manual control:";
            // 
            // manualFan2GroupBox
            // 
            manualFan2GroupBox.Controls.Add(manualFan2RadioButtonHigh);
            manualFan2GroupBox.Controls.Add(manualFan2RadioButtonMedium);
            manualFan2GroupBox.Controls.Add(manualFan2RadioButtonOff);
            manualFan2GroupBox.Location = new System.Drawing.Point(100, 21);
            manualFan2GroupBox.Name = "manualFan2GroupBox";
            manualFan2GroupBox.Size = new System.Drawing.Size(88, 99);
            manualFan2GroupBox.TabIndex = 1;
            manualFan2GroupBox.TabStop = false;
            manualFan2GroupBox.Text = "Fan 2:";
            // 
            // manualFan2RadioButtonHigh
            // 
            manualFan2RadioButtonHigh.AutoSize = true;
            manualFan2RadioButtonHigh.Location = new System.Drawing.Point(6, 72);
            manualFan2RadioButtonHigh.Name = "manualFan2RadioButtonHigh";
            manualFan2RadioButtonHigh.Size = new System.Drawing.Size(51, 19);
            manualFan2RadioButtonHigh.TabIndex = 5;
            manualFan2RadioButtonHigh.TabStop = true;
            manualFan2RadioButtonHigh.Text = "High";
            manualFan2RadioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // manualFan2RadioButtonMedium
            // 
            manualFan2RadioButtonMedium.AutoSize = true;
            manualFan2RadioButtonMedium.Location = new System.Drawing.Point(6, 47);
            manualFan2RadioButtonMedium.Name = "manualFan2RadioButtonMedium";
            manualFan2RadioButtonMedium.Size = new System.Drawing.Size(70, 19);
            manualFan2RadioButtonMedium.TabIndex = 5;
            manualFan2RadioButtonMedium.TabStop = true;
            manualFan2RadioButtonMedium.Text = "Medium";
            manualFan2RadioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // manualFan2RadioButtonOff
            // 
            manualFan2RadioButtonOff.AutoSize = true;
            manualFan2RadioButtonOff.Location = new System.Drawing.Point(6, 22);
            manualFan2RadioButtonOff.Name = "manualFan2RadioButtonOff";
            manualFan2RadioButtonOff.Size = new System.Drawing.Size(42, 19);
            manualFan2RadioButtonOff.TabIndex = 5;
            manualFan2RadioButtonOff.TabStop = true;
            manualFan2RadioButtonOff.Text = "Off";
            manualFan2RadioButtonOff.UseVisualStyleBackColor = true;
            // 
            // manualFan1GroupBox
            // 
            manualFan1GroupBox.Controls.Add(manualFan1RadioButtonHigh);
            manualFan1GroupBox.Controls.Add(manualFan1RadioButtonMedium);
            manualFan1GroupBox.Controls.Add(manualFan1RadioButtonOff);
            manualFan1GroupBox.Location = new System.Drawing.Point(6, 21);
            manualFan1GroupBox.Name = "manualFan1GroupBox";
            manualFan1GroupBox.Size = new System.Drawing.Size(88, 99);
            manualFan1GroupBox.TabIndex = 0;
            manualFan1GroupBox.TabStop = false;
            manualFan1GroupBox.Text = "Fan 1:";
            // 
            // manualFan1RadioButtonHigh
            // 
            manualFan1RadioButtonHigh.AutoSize = true;
            manualFan1RadioButtonHigh.Location = new System.Drawing.Point(6, 72);
            manualFan1RadioButtonHigh.Name = "manualFan1RadioButtonHigh";
            manualFan1RadioButtonHigh.Size = new System.Drawing.Size(51, 19);
            manualFan1RadioButtonHigh.TabIndex = 2;
            manualFan1RadioButtonHigh.TabStop = true;
            manualFan1RadioButtonHigh.Text = "High";
            manualFan1RadioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // manualFan1RadioButtonMedium
            // 
            manualFan1RadioButtonMedium.AutoSize = true;
            manualFan1RadioButtonMedium.Location = new System.Drawing.Point(6, 47);
            manualFan1RadioButtonMedium.Name = "manualFan1RadioButtonMedium";
            manualFan1RadioButtonMedium.Size = new System.Drawing.Size(70, 19);
            manualFan1RadioButtonMedium.TabIndex = 1;
            manualFan1RadioButtonMedium.TabStop = true;
            manualFan1RadioButtonMedium.Text = "Medium";
            manualFan1RadioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // manualFan1RadioButtonOff
            // 
            manualFan1RadioButtonOff.AutoSize = true;
            manualFan1RadioButtonOff.Location = new System.Drawing.Point(6, 22);
            manualFan1RadioButtonOff.Name = "manualFan1RadioButtonOff";
            manualFan1RadioButtonOff.Size = new System.Drawing.Size(42, 19);
            manualFan1RadioButtonOff.TabIndex = 0;
            manualFan1RadioButtonOff.TabStop = true;
            manualFan1RadioButtonOff.Text = "Off";
            manualFan1RadioButtonOff.UseVisualStyleBackColor = true;
            // 
            // consistencyModeGroupBox
            // 
            consistencyModeGroupBox.Controls.Add(alertsCheckBox);
            consistencyModeGroupBox.Controls.Add(consistencyModeApplyChangesButton);
            consistencyModeGroupBox.Controls.Add(consistencyModeRpmThresholdTextBox);
            consistencyModeGroupBox.Controls.Add(consistencyModeRpmThresholdLabel);
            consistencyModeGroupBox.Controls.Add(consistencyModeUpperTemperatureThresholdTextBox);
            consistencyModeGroupBox.Controls.Add(consistencyModeUpperTemperatureThresholdLabel);
            consistencyModeGroupBox.Controls.Add(consistencyModeLowerTemperatureThresholdTextBox);
            consistencyModeGroupBox.Controls.Add(consistencyModeLowerTemperatureThresholdLabel);
            consistencyModeGroupBox.Location = new System.Drawing.Point(467, 144);
            consistencyModeGroupBox.Name = "consistencyModeGroupBox";
            consistencyModeGroupBox.Size = new System.Drawing.Size(194, 138);
            consistencyModeGroupBox.TabIndex = 10;
            consistencyModeGroupBox.TabStop = false;
            consistencyModeGroupBox.Text = "Consistency mode options:";
            // 
            // alertsCheckBox
            // 
            alertsCheckBox.AutoSize = true;
            alertsCheckBox.Enabled = false;
            alertsCheckBox.Location = new System.Drawing.Point(137, 80);
            alertsCheckBox.Name = "alertsCheckBox";
            alertsCheckBox.Size = new System.Drawing.Size(56, 19);
            alertsCheckBox.TabIndex = 13;
            alertsCheckBox.Text = "A&lerts";
            alertsCheckBox.UseVisualStyleBackColor = true;
            // 
            // consistencyModeApplyChangesButton
            // 
            consistencyModeApplyChangesButton.Location = new System.Drawing.Point(5, 107);
            consistencyModeApplyChangesButton.Name = "consistencyModeApplyChangesButton";
            consistencyModeApplyChangesButton.Size = new System.Drawing.Size(184, 25);
            consistencyModeApplyChangesButton.TabIndex = 14;
            consistencyModeApplyChangesButton.Text = "Appl&y changes";
            consistencyModeApplyChangesButton.UseVisualStyleBackColor = true;
            // 
            // consistencyModeRpmThresholdTextBox
            // 
            consistencyModeRpmThresholdTextBox.Location = new System.Drawing.Point(96, 78);
            consistencyModeRpmThresholdTextBox.MaxLength = 4;
            consistencyModeRpmThresholdTextBox.Name = "consistencyModeRpmThresholdTextBox";
            consistencyModeRpmThresholdTextBox.Size = new System.Drawing.Size(30, 23);
            consistencyModeRpmThresholdTextBox.TabIndex = 5;
            consistencyModeRpmThresholdTextBox.Text = "2400";
            // 
            // consistencyModeRpmThresholdLabel
            // 
            consistencyModeRpmThresholdLabel.AutoSize = true;
            consistencyModeRpmThresholdLabel.Location = new System.Drawing.Point(7, 81);
            consistencyModeRpmThresholdLabel.Name = "consistencyModeRpmThresholdLabel";
            consistencyModeRpmThresholdLabel.Size = new System.Drawing.Size(88, 15);
            consistencyModeRpmThresholdLabel.TabIndex = 4;
            consistencyModeRpmThresholdLabel.Text = "RPM threshold:";
            // 
            // consistencyModeUpperTemperatureThresholdTextBox
            // 
            consistencyModeUpperTemperatureThresholdTextBox.Location = new System.Drawing.Point(170, 49);
            consistencyModeUpperTemperatureThresholdTextBox.MaxLength = 2;
            consistencyModeUpperTemperatureThresholdTextBox.Name = "consistencyModeUpperTemperatureThresholdTextBox";
            consistencyModeUpperTemperatureThresholdTextBox.Size = new System.Drawing.Size(18, 23);
            consistencyModeUpperTemperatureThresholdTextBox.TabIndex = 3;
            consistencyModeUpperTemperatureThresholdTextBox.Text = "85";
            // 
            // consistencyModeUpperTemperatureThresholdLabel
            // 
            consistencyModeUpperTemperatureThresholdLabel.AutoSize = true;
            consistencyModeUpperTemperatureThresholdLabel.Location = new System.Drawing.Point(6, 52);
            consistencyModeUpperTemperatureThresholdLabel.Name = "consistencyModeUpperTemperatureThresholdLabel";
            consistencyModeUpperTemperatureThresholdLabel.Size = new System.Drawing.Size(163, 15);
            consistencyModeUpperTemperatureThresholdLabel.TabIndex = 2;
            consistencyModeUpperTemperatureThresholdLabel.Text = "Upper temperature threshold:";
            // 
            // consistencyModeLowerTemperatureThresholdTextBox
            // 
            consistencyModeLowerTemperatureThresholdTextBox.Location = new System.Drawing.Point(170, 20);
            consistencyModeLowerTemperatureThresholdTextBox.MaxLength = 2;
            consistencyModeLowerTemperatureThresholdTextBox.Name = "consistencyModeLowerTemperatureThresholdTextBox";
            consistencyModeLowerTemperatureThresholdTextBox.Size = new System.Drawing.Size(18, 23);
            consistencyModeLowerTemperatureThresholdTextBox.TabIndex = 1;
            consistencyModeLowerTemperatureThresholdTextBox.Text = "65";
            // 
            // consistencyModeLowerTemperatureThresholdLabel
            // 
            consistencyModeLowerTemperatureThresholdLabel.AutoSize = true;
            consistencyModeLowerTemperatureThresholdLabel.Location = new System.Drawing.Point(6, 23);
            consistencyModeLowerTemperatureThresholdLabel.Name = "consistencyModeLowerTemperatureThresholdLabel";
            consistencyModeLowerTemperatureThresholdLabel.Size = new System.Drawing.Size(163, 15);
            consistencyModeLowerTemperatureThresholdLabel.TabIndex = 0;
            consistencyModeLowerTemperatureThresholdLabel.Text = "Lower temperature threshold:";
            // 
            // ecFanControlRadioButtonOn
            // 
            ecFanControlRadioButtonOn.AutoSize = true;
            ecFanControlRadioButtonOn.Location = new System.Drawing.Point(6, 22);
            ecFanControlRadioButtonOn.Name = "ecFanControlRadioButtonOn";
            ecFanControlRadioButtonOn.Size = new System.Drawing.Size(41, 19);
            ecFanControlRadioButtonOn.TabIndex = 2;
            ecFanControlRadioButtonOn.TabStop = true;
            ecFanControlRadioButtonOn.Text = "O&n";
            ecFanControlRadioButtonOn.UseVisualStyleBackColor = true;
            // 
            // ecFanControlRadioButtonOff
            // 
            ecFanControlRadioButtonOff.AutoSize = true;
            ecFanControlRadioButtonOff.Location = new System.Drawing.Point(53, 22);
            ecFanControlRadioButtonOff.Name = "ecFanControlRadioButtonOff";
            ecFanControlRadioButtonOff.Size = new System.Drawing.Size(42, 19);
            ecFanControlRadioButtonOff.TabIndex = 3;
            ecFanControlRadioButtonOff.TabStop = true;
            ecFanControlRadioButtonOff.Text = "O&ff";
            ecFanControlRadioButtonOff.UseVisualStyleBackColor = true;
            // 
            // ecFanControlGroupBox
            // 
            ecFanControlGroupBox.Controls.Add(ecFanControlRadioButtonOn);
            ecFanControlGroupBox.Controls.Add(ecFanControlRadioButtonOff);
            ecFanControlGroupBox.Location = new System.Drawing.Point(241, 12);
            ecFanControlGroupBox.Name = "ecFanControlGroupBox";
            ecFanControlGroupBox.Size = new System.Drawing.Size(103, 48);
            ecFanControlGroupBox.TabIndex = 2;
            ecFanControlGroupBox.TabStop = false;
            ecFanControlGroupBox.Text = "EC fan control:";
            // 
            // restartBackgroundThreadButton
            // 
            restartBackgroundThreadButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            restartBackgroundThreadButton.Location = new System.Drawing.Point(240, 66);
            restartBackgroundThreadButton.Name = "restartBackgroundThreadButton";
            restartBackgroundThreadButton.Size = new System.Drawing.Size(105, 21);
            restartBackgroundThreadButton.TabIndex = 3;
            restartBackgroundThreadButton.Text = "&Restart BG thread";
            restartBackgroundThreadButton.UseVisualStyleBackColor = true;
            // 
            // aboutGroupBox
            // 
            aboutGroupBox.Controls.Add(richTextBox1);
            aboutGroupBox.Controls.Add(aboutProductLabel);
            aboutGroupBox.Location = new System.Drawing.Point(667, 12);
            aboutGroupBox.Name = "aboutGroupBox";
            aboutGroupBox.Size = new System.Drawing.Size(334, 185);
            aboutGroupBox.TabIndex = 11;
            aboutGroupBox.TabStop = false;
            aboutGroupBox.Text = "About:";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.Color.RosyBrown;
            richTextBox1.ForeColor = System.Drawing.Color.White;
            richTextBox1.Location = new System.Drawing.Point(6, 37);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(322, 141);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // aboutProductLabel
            // 
            aboutProductLabel.AutoSize = true;
            aboutProductLabel.Location = new System.Drawing.Point(6, 19);
            aboutProductLabel.Name = "aboutProductLabel";
            aboutProductLabel.Size = new System.Drawing.Size(191, 15);
            aboutProductLabel.TabIndex = 0;
            aboutProductLabel.Text = "Dell Fan Management, version DEV";
            // 
            // audioKeepAliveGroupBox
            // 
            audioKeepAliveGroupBox.Controls.Add(audioKeepAliveComboBox);
            audioKeepAliveGroupBox.Controls.Add(audioKeepAliveCheckbox);
            audioKeepAliveGroupBox.Location = new System.Drawing.Point(667, 203);
            audioKeepAliveGroupBox.Name = "audioKeepAliveGroupBox";
            audioKeepAliveGroupBox.Size = new System.Drawing.Size(334, 79);
            audioKeepAliveGroupBox.TabIndex = 12;
            audioKeepAliveGroupBox.TabStop = false;
            audioKeepAliveGroupBox.Text = "Audio keep alive:";
            // 
            // audioKeepAliveComboBox
            // 
            audioKeepAliveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            audioKeepAliveComboBox.FormattingEnabled = true;
            audioKeepAliveComboBox.Location = new System.Drawing.Point(6, 49);
            audioKeepAliveComboBox.Name = "audioKeepAliveComboBox";
            audioKeepAliveComboBox.Size = new System.Drawing.Size(322, 23);
            audioKeepAliveComboBox.TabIndex = 1;
            // 
            // audioKeepAliveCheckbox
            // 
            audioKeepAliveCheckbox.AutoSize = true;
            audioKeepAliveCheckbox.Location = new System.Drawing.Point(6, 23);
            audioKeepAliveCheckbox.Name = "audioKeepAliveCheckbox";
            audioKeepAliveCheckbox.Size = new System.Drawing.Size(322, 19);
            audioKeepAliveCheckbox.TabIndex = 0;
            audioKeepAliveCheckbox.Text = "&Keep this audio device active to prevent pops and clicks:";
            audioKeepAliveCheckbox.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { consistencyModeStatusLabel });
            statusStrip.Location = new System.Drawing.Point(0, 293);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new System.Drawing.Size(1013, 22);
            statusStrip.SizingGrip = false;
            statusStrip.TabIndex = 13;
            // 
            // consistencyModeStatusLabel
            // 
            consistencyModeStatusLabel.Name = "consistencyModeStatusLabel";
            consistencyModeStatusLabel.Size = new System.Drawing.Size(109, 17);
            consistencyModeStatusLabel.Text = "Fan speed is locked";
            // 
            // trayIcon
            // 
            trayIcon.Text = "Dell Fan Management";
            // 
            // trayIconCheckBox
            // 
            trayIconCheckBox.AutoSize = true;
            trayIconCheckBox.Checked = true;
            trayIconCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            trayIconCheckBox.Location = new System.Drawing.Point(356, 246);
            trayIconCheckBox.Name = "trayIconCheckBox";
            trayIconCheckBox.Size = new System.Drawing.Size(73, 19);
            trayIconCheckBox.TabIndex = 7;
            trayIconCheckBox.Text = "&Tray icon";
            trayIconCheckBox.UseVisualStyleBackColor = true;
            // 
            // animatedCheckBox
            // 
            animatedCheckBox.AutoSize = true;
            animatedCheckBox.Checked = true;
            animatedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            animatedCheckBox.Location = new System.Drawing.Point(356, 266);
            animatedCheckBox.Name = "animatedCheckBox";
            animatedCheckBox.Size = new System.Drawing.Size(78, 19);
            animatedCheckBox.TabIndex = 8;
            animatedCheckBox.Text = "An&imated";
            animatedCheckBox.UseVisualStyleBackColor = true;
            // 
            // DellFanManagementGuiForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.Gray;
            ClientSize = new System.Drawing.Size(1013, 315);
            Controls.Add(animatedCheckBox);
            Controls.Add(trayIconCheckBox);
            Controls.Add(statusStrip);
            Controls.Add(audioKeepAliveGroupBox);
            Controls.Add(aboutGroupBox);
            Controls.Add(restartBackgroundThreadButton);
            Controls.Add(ecFanControlGroupBox);
            Controls.Add(consistencyModeGroupBox);
            Controls.Add(manualGroupBox);
            Controls.Add(operationModeGroupBox);
            Controls.Add(temperatureGroupBox);
            Controls.Add(thermalSettingGroupBox);
            Controls.Add(fansGroupBox);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DellFanManagementGuiForm";
            Opacity = 0.8D;
            Text = "Dell Fan Management (Sakura Edition)";
            Load += DellFanManagementGuiForm_Load;
            fansGroupBox.ResumeLayout(false);
            fansGroupBox.PerformLayout();
            thermalSettingGroupBox.ResumeLayout(false);
            thermalSettingGroupBox.PerformLayout();
            temperatureGroupBox.ResumeLayout(false);
            temperatureGroupBox.PerformLayout();
            operationModeGroupBox.ResumeLayout(false);
            operationModeGroupBox.PerformLayout();
            manualGroupBox.ResumeLayout(false);
            manualFan2GroupBox.ResumeLayout(false);
            manualFan2GroupBox.PerformLayout();
            manualFan1GroupBox.ResumeLayout(false);
            manualFan1GroupBox.PerformLayout();
            consistencyModeGroupBox.ResumeLayout(false);
            consistencyModeGroupBox.PerformLayout();
            ecFanControlGroupBox.ResumeLayout(false);
            ecFanControlGroupBox.PerformLayout();
            aboutGroupBox.ResumeLayout(false);
            aboutGroupBox.PerformLayout();
            audioKeepAliveGroupBox.ResumeLayout(false);
            audioKeepAliveGroupBox.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox fansGroupBox;
        private System.Windows.Forms.Label fan1RpmLabel;
        private System.Windows.Forms.Label fan2RpmLabel;
        private System.Windows.Forms.GroupBox thermalSettingGroupBox;
        private System.Windows.Forms.RadioButton thermalSettingRadioButtonPerformance;
        private System.Windows.Forms.RadioButton thermalSettingRadioButtonQuiet;
        private System.Windows.Forms.RadioButton thermalSettingRadioButtonCool;
        private System.Windows.Forms.RadioButton thermalSettingRadioButtonOptimized;
        private System.Windows.Forms.GroupBox temperatureGroupBox;
        private System.Windows.Forms.Label temperatureLabel18;
        private System.Windows.Forms.Label temperatureLabel17;
        private System.Windows.Forms.Label temperatureLabel16;
        private System.Windows.Forms.Label temperatureLabel15;
        private System.Windows.Forms.Label temperatureLabel14;
        private System.Windows.Forms.Label temperatureLabel13;
        private System.Windows.Forms.Label temperatureLabel12;
        private System.Windows.Forms.Label temperatureLabel11;
        private System.Windows.Forms.Label temperatureLabel10;
        private System.Windows.Forms.Label temperatureLabel9;
        private System.Windows.Forms.Label temperatureLabel8;
        private System.Windows.Forms.Label temperatureLabel7;
        private System.Windows.Forms.Label temperatureLabel6;
        private System.Windows.Forms.Label temperatureLabel5;
        private System.Windows.Forms.Label temperatureLabel4;
        private System.Windows.Forms.Label temperatureLabel3;
        private System.Windows.Forms.Label temperatureLabel2;
        private System.Windows.Forms.Label temperatureLabel1;
        private System.Windows.Forms.GroupBox operationModeGroupBox;
        private System.Windows.Forms.RadioButton operationModeRadioButtonConsistency;
        private System.Windows.Forms.RadioButton operationModeRadioButtonManual;
        private System.Windows.Forms.RadioButton operationModeRadioButtonAutomatic;
        private System.Windows.Forms.GroupBox manualGroupBox;
        private System.Windows.Forms.GroupBox manualFan2GroupBox;
        private System.Windows.Forms.RadioButton manualFan2RadioButtonHigh;
        private System.Windows.Forms.RadioButton manualFan2RadioButtonMedium;
        private System.Windows.Forms.RadioButton manualFan2RadioButtonOff;
        private System.Windows.Forms.GroupBox manualFan1GroupBox;
        private System.Windows.Forms.RadioButton manualFan1RadioButtonHigh;
        private System.Windows.Forms.RadioButton manualFan1RadioButtonMedium;
        private System.Windows.Forms.RadioButton manualFan1RadioButtonOff;
        private System.Windows.Forms.GroupBox consistencyModeGroupBox;
        private System.Windows.Forms.Button consistencyModeApplyChangesButton;
        private System.Windows.Forms.TextBox consistencyModeRpmThresholdTextBox;
        private System.Windows.Forms.Label consistencyModeRpmThresholdLabel;
        private System.Windows.Forms.TextBox consistencyModeUpperTemperatureThresholdTextBox;
        private System.Windows.Forms.Label consistencyModeUpperTemperatureThresholdLabel;
        private System.Windows.Forms.TextBox consistencyModeLowerTemperatureThresholdTextBox;
        private System.Windows.Forms.Label consistencyModeLowerTemperatureThresholdLabel;
        private System.Windows.Forms.RadioButton ecFanControlRadioButtonOn;
        private System.Windows.Forms.RadioButton ecFanControlRadioButtonOff;
        private System.Windows.Forms.GroupBox ecFanControlGroupBox;
        private System.Windows.Forms.Button restartBackgroundThreadButton;
        private System.Windows.Forms.GroupBox aboutGroupBox;
        private System.Windows.Forms.Label aboutProductLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox audioKeepAliveGroupBox;
        private System.Windows.Forms.ComboBox audioKeepAliveComboBox;
        private System.Windows.Forms.CheckBox audioKeepAliveCheckbox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel consistencyModeStatusLabel;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.CheckBox trayIconCheckBox;
        private System.Windows.Forms.CheckBox alertsCheckBox;
        private System.Windows.Forms.CheckBox animatedCheckBox;
    }
}


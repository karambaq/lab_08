namespace Clipping
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Cube = new System.Windows.Forms.RadioButton();
            this.NoShape = new System.Windows.Forms.RadioButton();
            this.tetrahedron = new System.Windows.Forms.RadioButton();
            this.displacement_button = new System.Windows.Forms.Button();
            this.z_shift = new System.Windows.Forms.NumericUpDown();
            this.y_shift = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.x_shift = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rotationAxisbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.x_rotate = new System.Windows.Forms.NumericUpDown();
            this.z_scale = new System.Windows.Forms.NumericUpDown();
            this.scale_button = new System.Windows.Forms.Button();
            this.y_scale = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.x_scale = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.countRotation = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.y_rotate = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.z_rotate = new System.Windows.Forms.NumericUpDown();
            this.SetPoints = new System.Windows.Forms.CheckBox();
            this.ZBufferBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_shift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_shift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_shift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_rotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_rotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_rotate)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(16, 15);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1253, 784);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMouseClick);
            // 
            // Cube
            // 
            this.Cube.AutoSize = true;
            this.Cube.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cube.Location = new System.Drawing.Point(1277, 69);
            this.Cube.Margin = new System.Windows.Forms.Padding(4);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(53, 21);
            this.Cube.TabIndex = 2;
            this.Cube.TabStop = true;
            this.Cube.Text = "Куб";
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.CheckedChanged += new System.EventHandler(this.shape_CheckedChanged);
            // 
            // NoShape
            // 
            this.NoShape.AutoSize = true;
            this.NoShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoShape.Location = new System.Drawing.Point(1277, 15);
            this.NoShape.Margin = new System.Windows.Forms.Padding(4);
            this.NoShape.Name = "NoShape";
            this.NoShape.Size = new System.Drawing.Size(98, 21);
            this.NoShape.TabIndex = 1;
            this.NoShape.TabStop = true;
            this.NoShape.Text = "Не задано";
            this.NoShape.UseVisualStyleBackColor = true;
            this.NoShape.CheckedChanged += new System.EventHandler(this.shape_CheckedChanged);
            // 
            // tetrahedron
            // 
            this.tetrahedron.AutoSize = true;
            this.tetrahedron.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tetrahedron.Location = new System.Drawing.Point(1277, 41);
            this.tetrahedron.Margin = new System.Windows.Forms.Padding(4);
            this.tetrahedron.Name = "tetrahedron";
            this.tetrahedron.Size = new System.Drawing.Size(92, 21);
            this.tetrahedron.TabIndex = 0;
            this.tetrahedron.TabStop = true;
            this.tetrahedron.Text = "Тетраэдр";
            this.tetrahedron.UseVisualStyleBackColor = true;
            this.tetrahedron.CheckedChanged += new System.EventHandler(this.shape_CheckedChanged);
            // 
            // displacement_button
            // 
            this.displacement_button.Location = new System.Drawing.Point(1408, 137);
            this.displacement_button.Margin = new System.Windows.Forms.Padding(4);
            this.displacement_button.Name = "displacement_button";
            this.displacement_button.Size = new System.Drawing.Size(172, 31);
            this.displacement_button.TabIndex = 6;
            this.displacement_button.Text = "Перенос";
            this.displacement_button.UseVisualStyleBackColor = true;
            this.displacement_button.Click += new System.EventHandler(this.DisplacementButtonClick);
            // 
            // z_shift
            // 
            this.z_shift.Location = new System.Drawing.Point(1457, 105);
            this.z_shift.Margin = new System.Windows.Forms.Padding(4);
            this.z_shift.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.z_shift.Name = "z_shift";
            this.z_shift.Size = new System.Drawing.Size(85, 22);
            this.z_shift.TabIndex = 5;
            // 
            // y_shift
            // 
            this.y_shift.Location = new System.Drawing.Point(1457, 73);
            this.y_shift.Margin = new System.Windows.Forms.Padding(4);
            this.y_shift.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.y_shift.Name = "y_shift";
            this.y_shift.Size = new System.Drawing.Size(85, 22);
            this.y_shift.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1428, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // x_shift
            // 
            this.x_shift.Location = new System.Drawing.Point(1457, 43);
            this.x_shift.Margin = new System.Windows.Forms.Padding(4);
            this.x_shift.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x_shift.Name = "x_shift";
            this.x_shift.Size = new System.Drawing.Size(85, 22);
            this.x_shift.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1427, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1427, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z:";
            // 
            // rotationAxisbutton
            // 
            this.rotationAxisbutton.Location = new System.Drawing.Point(1408, 324);
            this.rotationAxisbutton.Margin = new System.Windows.Forms.Padding(4);
            this.rotationAxisbutton.Name = "rotationAxisbutton";
            this.rotationAxisbutton.Size = new System.Drawing.Size(172, 33);
            this.rotationAxisbutton.TabIndex = 10;
            this.rotationAxisbutton.Text = "Поворот";
            this.rotationAxisbutton.UseVisualStyleBackColor = true;
            this.rotationAxisbutton.Click += new System.EventHandler(this.RotateButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(1427, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "X";
            // 
            // x_rotate
            // 
            this.x_rotate.Location = new System.Drawing.Point(1465, 228);
            this.x_rotate.Margin = new System.Windows.Forms.Padding(4);
            this.x_rotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.x_rotate.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.x_rotate.Name = "x_rotate";
            this.x_rotate.Size = new System.Drawing.Size(85, 22);
            this.x_rotate.TabIndex = 4;
            // 
            // z_scale
            // 
            this.z_scale.DecimalPlaces = 1;
            this.z_scale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.z_scale.Location = new System.Drawing.Point(1305, 292);
            this.z_scale.Margin = new System.Windows.Forms.Padding(4);
            this.z_scale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.z_scale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.z_scale.Name = "z_scale";
            this.z_scale.Size = new System.Drawing.Size(85, 22);
            this.z_scale.TabIndex = 6;
            this.z_scale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // scale_button
            // 
            this.scale_button.Location = new System.Drawing.Point(1281, 324);
            this.scale_button.Margin = new System.Windows.Forms.Padding(4);
            this.scale_button.Name = "scale_button";
            this.scale_button.Size = new System.Drawing.Size(109, 33);
            this.scale_button.TabIndex = 6;
            this.scale_button.Text = "Масштаб";
            this.scale_button.UseVisualStyleBackColor = true;
            this.scale_button.Click += new System.EventHandler(this.ScaleButtonClick);
            // 
            // y_scale
            // 
            this.y_scale.DecimalPlaces = 1;
            this.y_scale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.y_scale.Location = new System.Drawing.Point(1305, 260);
            this.y_scale.Margin = new System.Windows.Forms.Padding(4);
            this.y_scale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.y_scale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.y_scale.Name = "y_scale";
            this.y_scale.Size = new System.Drawing.Size(85, 22);
            this.y_scale.TabIndex = 5;
            this.y_scale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1277, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Y:";
            // 
            // x_scale
            // 
            this.x_scale.DecimalPlaces = 1;
            this.x_scale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.x_scale.Location = new System.Drawing.Point(1305, 228);
            this.x_scale.Margin = new System.Windows.Forms.Padding(4);
            this.x_scale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.x_scale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.x_scale.Name = "x_scale";
            this.x_scale.Size = new System.Drawing.Size(85, 22);
            this.x_scale.TabIndex = 3;
            this.x_scale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1277, 230);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "X:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1277, 294);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Z:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1427, 198);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Поворот:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1277, 202);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Масштабирование:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1427, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "Перенос:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1277, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1277, 145);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1277, 546);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 31);
            this.button4.TabIndex = 19;
            this.button4.Text = "Вращение";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CreateRotationFigure);
            // 
            // countRotation
            // 
            this.countRotation.Location = new System.Drawing.Point(1360, 509);
            this.countRotation.Margin = new System.Windows.Forms.Padding(4);
            this.countRotation.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.countRotation.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.countRotation.Name = "countRotation";
            this.countRotation.Size = new System.Drawing.Size(85, 22);
            this.countRotation.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1277, 450);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Фигура вращения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(1277, 511);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "вращений";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(1427, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Y";
            // 
            // y_rotate
            // 
            this.y_rotate.Location = new System.Drawing.Point(1465, 262);
            this.y_rotate.Margin = new System.Windows.Forms.Padding(4);
            this.y_rotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.y_rotate.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.y_rotate.Name = "y_rotate";
            this.y_rotate.Size = new System.Drawing.Size(85, 22);
            this.y_rotate.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(1427, 294);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "Z";
            // 
            // z_rotate
            // 
            this.z_rotate.Location = new System.Drawing.Point(1465, 292);
            this.z_rotate.Margin = new System.Windows.Forms.Padding(4);
            this.z_rotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.z_rotate.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.z_rotate.Name = "z_rotate";
            this.z_rotate.Size = new System.Drawing.Size(85, 22);
            this.z_rotate.TabIndex = 33;
            // 
            // SetPoints
            // 
            this.SetPoints.AutoSize = true;
            this.SetPoints.Location = new System.Drawing.Point(1281, 469);
            this.SetPoints.Margin = new System.Windows.Forms.Padding(4);
            this.SetPoints.Name = "SetPoints";
            this.SetPoints.Size = new System.Drawing.Size(173, 21);
            this.SetPoints.TabIndex = 35;
            this.SetPoints.Text = "Указать Образующие";
            this.SetPoints.UseVisualStyleBackColor = true;
            // 
            // ZBufferBox
            // 
            this.ZBufferBox.AutoSize = true;
            this.ZBufferBox.Location = new System.Drawing.Point(1281, 399);
            this.ZBufferBox.Name = "ZBufferBox";
            this.ZBufferBox.Size = new System.Drawing.Size(77, 21);
            this.ZBufferBox.TabIndex = 36;
            this.ZBufferBox.Text = "ZBuffer";
            this.ZBufferBox.UseVisualStyleBackColor = true;
            this.ZBufferBox.CheckedChanged += new System.EventHandler(this.ZBufferBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.ZBufferBox);
            this.Controls.Add(this.SetPoints);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.z_rotate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.y_rotate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.countRotation);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.displacement_button);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.z_shift);
            this.Controls.Add(this.z_scale);
            this.Controls.Add(this.y_shift);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scale_button);
            this.Controls.Add(this.x_shift);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rotationAxisbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.y_scale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.x_scale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.x_rotate);
            this.Controls.Add(this.NoShape);
            this.Controls.Add(this.tetrahedron);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "3D векторная графика";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_shift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_shift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_shift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_rotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_rotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_rotate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton tetrahedron;
        private System.Windows.Forms.RadioButton NoShape;
        private System.Windows.Forms.RadioButton Cube;
        private System.Windows.Forms.Button displacement_button;
        private System.Windows.Forms.NumericUpDown z_shift;
        private System.Windows.Forms.NumericUpDown y_shift;
        private System.Windows.Forms.NumericUpDown x_shift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rotationAxisbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown x_rotate;
        private System.Windows.Forms.Button scale_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown x_scale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown z_scale;
        private System.Windows.Forms.NumericUpDown y_scale;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown countRotation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown y_rotate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown z_rotate;
        private System.Windows.Forms.CheckBox SetPoints;
        private System.Windows.Forms.CheckBox ZBufferBox;
    }
}


namespace HeroMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_energy = new System.Windows.Forms.CheckBox();
            this.chk_luck = new System.Windows.Forms.CheckBox();
            this.chk_fart = new System.Windows.Forms.CheckBox();
            this.chk_water_breath = new System.Windows.Forms.CheckBox();
            this.chk_timecontrol = new System.Windows.Forms.CheckBox();
            this.chk_invisible = new System.Windows.Forms.CheckBox();
            this.chk_xray = new System.Windows.Forms.CheckBox();
            this.chk_fly = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_cities = new System.Windows.Forms.ListBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_batmobile = new System.Windows.Forms.RadioButton();
            this.rdo_teleport = new System.Windows.Forms.RadioButton();
            this.rdo_landspeeder = new System.Windows.Forms.RadioButton();
            this.rdo_jetpack = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_strength = new System.Windows.Forms.Label();
            this.lbl_stamina = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scroll_strength = new System.Windows.Forms.HScrollBar();
            this.scroll_stamina = new System.Windows.Forms.HScrollBar();
            this.scroll_speed = new System.Windows.Forms.HScrollBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.date_birthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date_power_discovery = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.date_fate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hero\'s Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(86, 6);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(226, 20);
            this.txt_name.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_energy);
            this.groupBox1.Controls.Add(this.chk_luck);
            this.groupBox1.Controls.Add(this.chk_fart);
            this.groupBox1.Controls.Add(this.chk_water_breath);
            this.groupBox1.Controls.Add(this.chk_timecontrol);
            this.groupBox1.Controls.Add(this.chk_invisible);
            this.groupBox1.Controls.Add(this.chk_xray);
            this.groupBox1.Controls.Add(this.chk_fly);
            this.groupBox1.Location = new System.Drawing.Point(15, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special Abilities";
            // 
            // chk_energy
            // 
            this.chk_energy.AutoSize = true;
            this.chk_energy.Location = new System.Drawing.Point(6, 97);
            this.chk_energy.Name = "chk_energy";
            this.chk_energy.Size = new System.Drawing.Size(95, 17);
            this.chk_energy.TabIndex = 4;
            this.chk_energy.Text = "Absorb Energy";
            this.chk_energy.UseVisualStyleBackColor = true;
            // 
            // chk_luck
            // 
            this.chk_luck.AutoSize = true;
            this.chk_luck.Location = new System.Drawing.Point(126, 28);
            this.chk_luck.Name = "chk_luck";
            this.chk_luck.Size = new System.Drawing.Size(91, 17);
            this.chk_luck.TabIndex = 7;
            this.chk_luck.Text = "Extreme Luck";
            this.chk_luck.UseVisualStyleBackColor = true;
            // 
            // chk_fart
            // 
            this.chk_fart.AutoSize = true;
            this.chk_fart.Location = new System.Drawing.Point(126, 51);
            this.chk_fart.Name = "chk_fart";
            this.chk_fart.Size = new System.Drawing.Size(97, 17);
            this.chk_fart.TabIndex = 6;
            this.chk_fart.Text = "Explosive Farts";
            this.chk_fart.UseVisualStyleBackColor = true;
            // 
            // chk_water_breath
            // 
            this.chk_water_breath.AutoSize = true;
            this.chk_water_breath.Location = new System.Drawing.Point(126, 74);
            this.chk_water_breath.Name = "chk_water_breath";
            this.chk_water_breath.Size = new System.Drawing.Size(103, 17);
            this.chk_water_breath.TabIndex = 5;
            this.chk_water_breath.Text = "Water Breathing";
            this.chk_water_breath.UseVisualStyleBackColor = true;
            // 
            // chk_timecontrol
            // 
            this.chk_timecontrol.AutoSize = true;
            this.chk_timecontrol.Location = new System.Drawing.Point(126, 97);
            this.chk_timecontrol.Name = "chk_timecontrol";
            this.chk_timecontrol.Size = new System.Drawing.Size(85, 17);
            this.chk_timecontrol.TabIndex = 4;
            this.chk_timecontrol.Text = "Time Control";
            this.chk_timecontrol.UseVisualStyleBackColor = true;
            // 
            // chk_invisible
            // 
            this.chk_invisible.AutoSize = true;
            this.chk_invisible.Location = new System.Drawing.Point(6, 74);
            this.chk_invisible.Name = "chk_invisible";
            this.chk_invisible.Size = new System.Drawing.Size(70, 17);
            this.chk_invisible.TabIndex = 2;
            this.chk_invisible.Text = "Invisibility";
            this.chk_invisible.UseVisualStyleBackColor = true;
            // 
            // chk_xray
            // 
            this.chk_xray.AutoSize = true;
            this.chk_xray.Location = new System.Drawing.Point(6, 51);
            this.chk_xray.Name = "chk_xray";
            this.chk_xray.Size = new System.Drawing.Size(81, 17);
            this.chk_xray.TabIndex = 1;
            this.chk_xray.Text = "xRay Vision";
            this.chk_xray.UseVisualStyleBackColor = true;
            // 
            // chk_fly
            // 
            this.chk_fly.AutoSize = true;
            this.chk_fly.Location = new System.Drawing.Point(6, 28);
            this.chk_fly.Name = "chk_fly";
            this.chk_fly.Size = new System.Drawing.Size(39, 17);
            this.chk_fly.TabIndex = 0;
            this.chk_fly.Text = "Fly";
            this.chk_fly.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Office Locations";
            // 
            // lst_cities
            // 
            this.lst_cities.FormattingEnabled = true;
            this.lst_cities.Items.AddRange(new object[] {
            "Moscow",
            "New York",
            "London",
            "Paris",
            "Tokyo",
            "Hong Kong",
            "Rome",
            "Sydney"});
            this.lst_cities.Location = new System.Drawing.Point(14, 177);
            this.lst_cities.Name = "lst_cities";
            this.lst_cities.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_cities.Size = new System.Drawing.Size(120, 95);
            this.lst_cities.TabIndex = 4;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(690, 405);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Create Hero";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_batmobile);
            this.groupBox2.Controls.Add(this.rdo_teleport);
            this.groupBox2.Controls.Add(this.rdo_landspeeder);
            this.groupBox2.Controls.Add(this.rdo_jetpack);
            this.groupBox2.Location = new System.Drawing.Point(141, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 108);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preferred Transport";
            // 
            // rdo_batmobile
            // 
            this.rdo_batmobile.AutoSize = true;
            this.rdo_batmobile.Location = new System.Drawing.Point(6, 88);
            this.rdo_batmobile.Name = "rdo_batmobile";
            this.rdo_batmobile.Size = new System.Drawing.Size(71, 17);
            this.rdo_batmobile.TabIndex = 3;
            this.rdo_batmobile.TabStop = true;
            this.rdo_batmobile.Text = "Batmobile";
            this.rdo_batmobile.UseVisualStyleBackColor = true;
            // 
            // rdo_teleport
            // 
            this.rdo_teleport.AutoSize = true;
            this.rdo_teleport.Location = new System.Drawing.Point(6, 65);
            this.rdo_teleport.Name = "rdo_teleport";
            this.rdo_teleport.Size = new System.Drawing.Size(64, 17);
            this.rdo_teleport.TabIndex = 2;
            this.rdo_teleport.TabStop = true;
            this.rdo_teleport.Text = "Teleport";
            this.rdo_teleport.UseVisualStyleBackColor = true;
            // 
            // rdo_landspeeder
            // 
            this.rdo_landspeeder.AutoSize = true;
            this.rdo_landspeeder.Location = new System.Drawing.Point(6, 42);
            this.rdo_landspeeder.Name = "rdo_landspeeder";
            this.rdo_landspeeder.Size = new System.Drawing.Size(87, 17);
            this.rdo_landspeeder.TabIndex = 1;
            this.rdo_landspeeder.TabStop = true;
            this.rdo_landspeeder.Text = "Landspeeder";
            this.rdo_landspeeder.UseVisualStyleBackColor = true;
            // 
            // rdo_jetpack
            // 
            this.rdo_jetpack.AutoSize = true;
            this.rdo_jetpack.Checked = true;
            this.rdo_jetpack.Location = new System.Drawing.Point(6, 19);
            this.rdo_jetpack.Name = "rdo_jetpack";
            this.rdo_jetpack.Size = new System.Drawing.Size(64, 17);
            this.rdo_jetpack.TabIndex = 0;
            this.rdo_jetpack.TabStop = true;
            this.rdo_jetpack.Text = "JetPack";
            this.rdo_jetpack.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_strength);
            this.groupBox3.Controls.Add(this.lbl_stamina);
            this.groupBox3.Controls.Add(this.lbl_speed);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.scroll_strength);
            this.groupBox3.Controls.Add(this.scroll_stamina);
            this.groupBox3.Controls.Add(this.scroll_speed);
            this.groupBox3.Location = new System.Drawing.Point(15, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 150);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Speed-Stamina-Strength";
            // 
            // lbl_strength
            // 
            this.lbl_strength.AutoSize = true;
            this.lbl_strength.Location = new System.Drawing.Point(61, 104);
            this.lbl_strength.Name = "lbl_strength";
            this.lbl_strength.Size = new System.Drawing.Size(19, 13);
            this.lbl_strength.TabIndex = 8;
            this.lbl_strength.Text = "33";
            // 
            // lbl_stamina
            // 
            this.lbl_stamina.AutoSize = true;
            this.lbl_stamina.Location = new System.Drawing.Point(61, 66);
            this.lbl_stamina.Name = "lbl_stamina";
            this.lbl_stamina.Size = new System.Drawing.Size(19, 13);
            this.lbl_stamina.TabIndex = 7;
            this.lbl_stamina.Text = "33";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(61, 30);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(19, 13);
            this.lbl_speed.TabIndex = 6;
            this.lbl_speed.Text = "33";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Strength:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stamina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Speed:";
            // 
            // scroll_strength
            // 
            this.scroll_strength.Location = new System.Drawing.Point(7, 117);
            this.scroll_strength.Name = "scroll_strength";
            this.scroll_strength.Size = new System.Drawing.Size(300, 15);
            this.scroll_strength.TabIndex = 2;
            this.scroll_strength.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_strength_Scroll);
            // 
            // scroll_stamina
            // 
            this.scroll_stamina.Location = new System.Drawing.Point(7, 79);
            this.scroll_stamina.Name = "scroll_stamina";
            this.scroll_stamina.Size = new System.Drawing.Size(300, 15);
            this.scroll_stamina.TabIndex = 1;
            this.scroll_stamina.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_stamina_Scroll);
            // 
            // scroll_speed
            // 
            this.scroll_speed.Location = new System.Drawing.Point(7, 43);
            this.scroll_speed.Name = "scroll_speed";
            this.scroll_speed.Size = new System.Drawing.Size(300, 15);
            this.scroll_speed.TabIndex = 0;
            this.scroll_speed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_speed_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(491, 252);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.date_fate);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.date_power_discovery);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.date_birthday);
            this.groupBox4.Location = new System.Drawing.Point(359, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 165);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // date_birthday
            // 
            this.date_birthday.Location = new System.Drawing.Point(18, 39);
            this.date_birthday.Name = "date_birthday";
            this.date_birthday.Size = new System.Drawing.Size(200, 20);
            this.date_birthday.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Super Power Discovery";
            // 
            // date_power_discovery
            // 
            this.date_power_discovery.Location = new System.Drawing.Point(18, 78);
            this.date_power_discovery.Name = "date_power_discovery";
            this.date_power_discovery.Size = new System.Drawing.Size(200, 20);
            this.date_power_discovery.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fateful Day";
            // 
            // date_fate
            // 
            this.date_fate.Location = new System.Drawing.Point(18, 115);
            this.date_fate.Name = "date_fate";
            this.date_fate.Size = new System.Drawing.Size(200, 20);
            this.date_fate.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lst_cities);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_xray;
        private System.Windows.Forms.CheckBox chk_fly;
        private System.Windows.Forms.CheckBox chk_invisible;
        private System.Windows.Forms.CheckBox chk_luck;
        private System.Windows.Forms.CheckBox chk_fart;
        private System.Windows.Forms.CheckBox chk_water_breath;
        private System.Windows.Forms.CheckBox chk_timecontrol;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.CheckBox chk_energy;
        private System.Windows.Forms.ListBox lst_cities;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_batmobile;
        private System.Windows.Forms.RadioButton rdo_teleport;
        private System.Windows.Forms.RadioButton rdo_landspeeder;
        private System.Windows.Forms.RadioButton rdo_jetpack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.HScrollBar scroll_speed;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.HScrollBar scroll_strength;
        private System.Windows.Forms.HScrollBar scroll_stamina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_strength;
        private System.Windows.Forms.Label lbl_stamina;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker date_birthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_fate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date_power_discovery;
    }
}


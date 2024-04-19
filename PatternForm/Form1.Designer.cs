namespace PatternForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            Zavod = new TabPage();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            hardRadioBut = new RadioButton();
            mediumRadioBut = new RadioButton();
            easyRadioBut = new RadioButton();
            currencyExchanger = new TabPage();
            exchangeBut = new Button();
            label2 = new Label();
            decorator = new TabPage();
            isSahar = new PictureBox();
            isMilk = new PictureBox();
            saharBut = new Button();
            milkBut = new Button();
            doubleEspessoBut = new Button();
            lungoBut = new Button();
            cappucinoBut = new Button();
            espressoBut = new Button();
            label1 = new Label();
            strategy = new TabPage();
            button3 = new Button();
            button2 = new Button();
            label5 = new Label();
            lungoToolTip = new ToolTip(components);
            cappucinoToolTip = new ToolTip(components);
            esprssoToolTip = new ToolTip(components);
            doubleEspressoToolTip = new ToolTip(components);
            exchangeToolTip = new ToolTip(components);
            tabControl1.SuspendLayout();
            Zavod.SuspendLayout();
            currencyExchanger.SuspendLayout();
            decorator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)isSahar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)isMilk).BeginInit();
            strategy.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Zavod);
            tabControl1.Controls.Add(currencyExchanger);
            tabControl1.Controls.Add(decorator);
            tabControl1.Controls.Add(strategy);
            tabControl1.Location = new Point(-2, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(943, 581);
            tabControl1.TabIndex = 1;
            // 
            // Zavod
            // 
            Zavod.BackColor = Color.White;
            Zavod.BackgroundImage = (Image)resources.GetObject("Zavod.BackgroundImage");
            Zavod.BackgroundImageLayout = ImageLayout.Stretch;
            Zavod.Controls.Add(label4);
            Zavod.Controls.Add(button1);
            Zavod.Controls.Add(label3);
            Zavod.Controls.Add(hardRadioBut);
            Zavod.Controls.Add(mediumRadioBut);
            Zavod.Controls.Add(easyRadioBut);
            Zavod.Cursor = Cursors.Hand;
            Zavod.Location = new Point(4, 24);
            Zavod.Name = "Zavod";
            Zavod.Padding = new Padding(3);
            Zavod.Size = new Size(935, 553);
            Zavod.TabIndex = 0;
            Zavod.Text = "Игра (Factory method)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(308, 0);
            label4.Name = "label4";
            label4.Size = new Size(347, 30);
            label4.TabIndex = 5;
            label4.Text = "Нажми на костер для начала игры";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(385, 377);
            button1.Name = "button1";
            button1.Size = new Size(181, 96);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ink Free", 26.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(443, 510);
            label3.Name = "label3";
            label3.Size = new Size(492, 43);
            label3.TabIndex = 3;
            label3.Text = "\"Олени наносят ответный удар\"";
            // 
            // hardRadioBut
            // 
            hardRadioBut.AutoSize = true;
            hardRadioBut.Location = new Point(154, 6);
            hardRadioBut.Name = "hardRadioBut";
            hardRadioBut.Size = new Size(75, 19);
            hardRadioBut.TabIndex = 2;
            hardRadioBut.TabStop = true;
            hardRadioBut.Text = "Сложная";
            hardRadioBut.UseVisualStyleBackColor = true;
            // 
            // mediumRadioBut
            // 
            mediumRadioBut.AutoSize = true;
            mediumRadioBut.Location = new Point(77, 6);
            mediumRadioBut.Name = "mediumRadioBut";
            mediumRadioBut.Size = new Size(71, 19);
            mediumRadioBut.TabIndex = 1;
            mediumRadioBut.TabStop = true;
            mediumRadioBut.Text = "Средняя";
            mediumRadioBut.UseVisualStyleBackColor = true;
            // 
            // easyRadioBut
            // 
            easyRadioBut.AutoSize = true;
            easyRadioBut.Location = new Point(9, 6);
            easyRadioBut.Name = "easyRadioBut";
            easyRadioBut.Size = new Size(62, 19);
            easyRadioBut.TabIndex = 0;
            easyRadioBut.TabStop = true;
            easyRadioBut.Text = "Легкая";
            easyRadioBut.UseVisualStyleBackColor = true;
            easyRadioBut.CheckedChanged += easyRadioBut_CheckedChanged;
            // 
            // currencyExchanger
            // 
            currencyExchanger.BackgroundImage = (Image)resources.GetObject("currencyExchanger.BackgroundImage");
            currencyExchanger.BackgroundImageLayout = ImageLayout.Stretch;
            currencyExchanger.BorderStyle = BorderStyle.FixedSingle;
            currencyExchanger.Controls.Add(exchangeBut);
            currencyExchanger.Controls.Add(label2);
            currencyExchanger.Location = new Point(4, 24);
            currencyExchanger.Name = "currencyExchanger";
            currencyExchanger.Padding = new Padding(3);
            currencyExchanger.Size = new Size(935, 553);
            currencyExchanger.TabIndex = 1;
            currencyExchanger.Text = "Обменник (Adapter)";
            currencyExchanger.UseVisualStyleBackColor = true;
            // 
            // exchangeBut
            // 
            exchangeBut.Cursor = Cursors.Help;
            exchangeBut.FlatAppearance.BorderSize = 0;
            exchangeBut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            exchangeBut.FlatAppearance.MouseOverBackColor = Color.Transparent;
            exchangeBut.FlatStyle = FlatStyle.Flat;
            exchangeBut.Location = new Point(278, 128);
            exchangeBut.Name = "exchangeBut";
            exchangeBut.Size = new Size(132, 413);
            exchangeBut.TabIndex = 1;
            exchangeBut.UseVisualStyleBackColor = true;
            exchangeBut.Click += exchangeBut_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(640, 508);
            label2.Name = "label2";
            label2.Size = new Size(294, 44);
            label2.TabIndex = 0;
            label2.Text = "Банк \"Павлин\"";
            // 
            // decorator
            // 
            decorator.BackgroundImage = (Image)resources.GetObject("decorator.BackgroundImage");
            decorator.BackgroundImageLayout = ImageLayout.Stretch;
            decorator.BorderStyle = BorderStyle.FixedSingle;
            decorator.Controls.Add(isSahar);
            decorator.Controls.Add(isMilk);
            decorator.Controls.Add(saharBut);
            decorator.Controls.Add(milkBut);
            decorator.Controls.Add(doubleEspessoBut);
            decorator.Controls.Add(lungoBut);
            decorator.Controls.Add(cappucinoBut);
            decorator.Controls.Add(espressoBut);
            decorator.Controls.Add(label1);
            decorator.Location = new Point(4, 24);
            decorator.Name = "decorator";
            decorator.Size = new Size(935, 553);
            decorator.TabIndex = 2;
            decorator.Text = "Кофейня (Decorator)";
            decorator.UseVisualStyleBackColor = true;
            // 
            // isSahar
            // 
            isSahar.BackgroundImage = (Image)resources.GetObject("isSahar.BackgroundImage");
            isSahar.BackgroundImageLayout = ImageLayout.Stretch;
            isSahar.Location = new Point(594, 404);
            isSahar.Name = "isSahar";
            isSahar.Size = new Size(26, 23);
            isSahar.TabIndex = 8;
            isSahar.TabStop = false;
            // 
            // isMilk
            // 
            isMilk.BackgroundImage = (Image)resources.GetObject("isMilk.BackgroundImage");
            isMilk.BackgroundImageLayout = ImageLayout.Stretch;
            isMilk.Location = new Point(778, 286);
            isMilk.Name = "isMilk";
            isMilk.Size = new Size(26, 23);
            isMilk.TabIndex = 7;
            isMilk.TabStop = false;
            // 
            // saharBut
            // 
            saharBut.BackgroundImage = (Image)resources.GetObject("saharBut.BackgroundImage");
            saharBut.BackgroundImageLayout = ImageLayout.Stretch;
            saharBut.FlatAppearance.BorderSize = 0;
            saharBut.FlatAppearance.CheckedBackColor = Color.Transparent;
            saharBut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            saharBut.FlatAppearance.MouseOverBackColor = Color.Transparent;
            saharBut.FlatStyle = FlatStyle.Flat;
            saharBut.Location = new Point(549, 433);
            saharBut.Name = "saharBut";
            saharBut.Size = new Size(108, 49);
            saharBut.TabIndex = 6;
            saharBut.UseVisualStyleBackColor = true;
            saharBut.Click += saharBut_Click;
            // 
            // milkBut
            // 
            milkBut.BackgroundImage = (Image)resources.GetObject("milkBut.BackgroundImage");
            milkBut.BackgroundImageLayout = ImageLayout.Zoom;
            milkBut.FlatAppearance.BorderSize = 0;
            milkBut.FlatAppearance.CheckedBackColor = Color.Transparent;
            milkBut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            milkBut.FlatAppearance.MouseOverBackColor = Color.Transparent;
            milkBut.FlatStyle = FlatStyle.Flat;
            milkBut.Location = new Point(694, 304);
            milkBut.Name = "milkBut";
            milkBut.Size = new Size(190, 178);
            milkBut.TabIndex = 5;
            milkBut.UseVisualStyleBackColor = true;
            milkBut.Click += milkBut_Click;
            // 
            // doubleEspessoBut
            // 
            doubleEspessoBut.BackColor = Color.Transparent;
            doubleEspessoBut.Cursor = Cursors.Hand;
            doubleEspessoBut.FlatAppearance.BorderSize = 0;
            doubleEspessoBut.FlatAppearance.CheckedBackColor = Color.Transparent;
            doubleEspessoBut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            doubleEspessoBut.FlatAppearance.MouseOverBackColor = Color.Transparent;
            doubleEspessoBut.FlatStyle = FlatStyle.Flat;
            doubleEspessoBut.Location = new Point(644, 417);
            doubleEspessoBut.Name = "doubleEspessoBut";
            doubleEspessoBut.Size = new Size(61, 23);
            doubleEspessoBut.TabIndex = 4;
            doubleEspessoBut.UseVisualStyleBackColor = false;
            doubleEspessoBut.Click += doubleEspessoBut_Click;
            // 
            // lungoBut
            // 
            lungoBut.BackColor = Color.Transparent;
            lungoBut.Cursor = Cursors.Hand;
            lungoBut.FlatAppearance.BorderSize = 0;
            lungoBut.FlatAppearance.CheckedBackColor = Color.Transparent;
            lungoBut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            lungoBut.FlatAppearance.MouseOverBackColor = Color.Transparent;
            lungoBut.FlatStyle = FlatStyle.Flat;
            lungoBut.Location = new Point(180, 304);
            lungoBut.Name = "lungoBut";
            lungoBut.Size = new Size(55, 23);
            lungoBut.TabIndex = 3;
            lungoBut.UseVisualStyleBackColor = false;
            lungoBut.Click += lungoBut_Click;
            // 
            // cappucinoBut
            // 
            cappucinoBut.BackColor = Color.Transparent;
            cappucinoBut.Cursor = Cursors.Hand;
            cappucinoBut.FlatAppearance.BorderSize = 0;
            cappucinoBut.FlatAppearance.CheckedBackColor = Color.Transparent;
            cappucinoBut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cappucinoBut.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cappucinoBut.FlatStyle = FlatStyle.Flat;
            cappucinoBut.Location = new Point(267, 393);
            cappucinoBut.Name = "cappucinoBut";
            cappucinoBut.Size = new Size(61, 23);
            cappucinoBut.TabIndex = 2;
            cappucinoBut.UseVisualStyleBackColor = false;
            cappucinoBut.Click += cappucinoBut_Click;
            // 
            // espressoBut
            // 
            espressoBut.BackColor = Color.Transparent;
            espressoBut.Cursor = Cursors.Hand;
            espressoBut.FlatAppearance.BorderSize = 0;
            espressoBut.FlatAppearance.CheckedBackColor = Color.Transparent;
            espressoBut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            espressoBut.FlatAppearance.MouseOverBackColor = Color.Transparent;
            espressoBut.FlatStyle = FlatStyle.Flat;
            espressoBut.Location = new Point(571, 346);
            espressoBut.Name = "espressoBut";
            espressoBut.Size = new Size(49, 23);
            espressoBut.TabIndex = 1;
            espressoBut.UseVisualStyleBackColor = false;
            espressoBut.Click += espressoBut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(393, 495);
            label1.Name = "label1";
            label1.Size = new Size(545, 56);
            label1.TabIndex = 0;
            label1.Text = "Кофейня \"У Глебыча\"";
            // 
            // strategy
            // 
            strategy.BackgroundImage = (Image)resources.GetObject("strategy.BackgroundImage");
            strategy.BackgroundImageLayout = ImageLayout.Stretch;
            strategy.BorderStyle = BorderStyle.FixedSingle;
            strategy.Controls.Add(button3);
            strategy.Controls.Add(button2);
            strategy.Controls.Add(label5);
            strategy.Cursor = Cursors.Hand;
            strategy.Location = new Point(4, 24);
            strategy.Name = "strategy";
            strategy.Size = new Size(935, 553);
            strategy.TabIndex = 3;
            strategy.Text = "База данных (Strategy)";
            strategy.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 14.25F);
            button3.Location = new Point(530, 482);
            button3.Name = "button3";
            button3.Size = new Size(126, 70);
            button3.TabIndex = 2;
            button3.Text = "Наказать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14.25F);
            button2.Location = new Point(281, 482);
            button2.Name = "button2";
            button2.Size = new Size(126, 70);
            button2.TabIndex = 1;
            button2.Text = "Помиловать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseHover;
            button2.MouseHover += button2_MouseHover;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(220, -1);
            label5.Name = "label5";
            label5.Size = new Size(493, 47);
            label5.TabIndex = 0;
            label5.Text = "Мы сломали базу данных =(";
            // 
            // lungoToolTip
            // 
            lungoToolTip.IsBalloon = true;
            lungoToolTip.ToolTipIcon = ToolTipIcon.Info;
            lungoToolTip.ToolTipTitle = "Лунго";
            // 
            // cappucinoToolTip
            // 
            cappucinoToolTip.IsBalloon = true;
            cappucinoToolTip.ToolTipIcon = ToolTipIcon.Info;
            cappucinoToolTip.ToolTipTitle = "Капучино";
            // 
            // esprssoToolTip
            // 
            esprssoToolTip.IsBalloon = true;
            esprssoToolTip.ToolTipIcon = ToolTipIcon.Info;
            esprssoToolTip.ToolTipTitle = "Эспрессо";
            // 
            // doubleEspressoToolTip
            // 
            doubleEspressoToolTip.IsBalloon = true;
            doubleEspressoToolTip.ToolTipIcon = ToolTipIcon.Info;
            doubleEspressoToolTip.ToolTipTitle = "Двойной эсперссо";
            // 
            // exchangeToolTip
            // 
            exchangeToolTip.IsBalloon = true;
            exchangeToolTip.OwnerDraw = true;
            exchangeToolTip.ToolTipTitle = "Игорь Алексеев";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(938, 577);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "❤Паттерный проектрирования❤";
            tabControl1.ResumeLayout(false);
            Zavod.ResumeLayout(false);
            Zavod.PerformLayout();
            currencyExchanger.ResumeLayout(false);
            currencyExchanger.PerformLayout();
            decorator.ResumeLayout(false);
            decorator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)isSahar).EndInit();
            ((System.ComponentModel.ISupportInitialize)isMilk).EndInit();
            strategy.ResumeLayout(false);
            strategy.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Zavod;
        private TabPage currencyExchanger;
        private TabPage decorator;
        private TabPage strategy;
        private RadioButton hardRadioBut;
        private RadioButton mediumRadioBut;
        private RadioButton easyRadioBut;
        private Label label1;
        private Button lungoBut;
        private Button cappucinoBut;
        private Button espressoBut;
        private Button doubleEspessoBut;
        private ToolTip lungoToolTip;
        private ToolTip cappucinoToolTip;
        private ToolTip esprssoToolTip;
        private ToolTip doubleEspressoToolTip;
        private Button saharBut;
        private Button milkBut;
        private PictureBox isMilk;
        private PictureBox isSahar;
        private Label label2;
        private Button exchangeBut;
        private ToolTip exchangeToolTip;
        private Label label4;
        private Button button1;
        private Label label3;
        private Button button3;
        private Button button2;
        private Label label5;
    }
}

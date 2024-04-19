using SimpleDesignPatterns;
using System.Diagnostics;
using System.Media;

namespace PatternForm
{
    public partial class Form1 : Form
    {
        private bool _withMilk = false;
        private bool _withSugar = false;
        private IBeverage<Espresso> beverage = new Espresso();
        private IBeverage<Сappuccino> beverage1 = new Сappuccino();
        private IBeverage<Lungo> beverage2 = new Lungo();
        private SoundPlayer soundPlayer;

        public Form1()
        {
            InitializeComponent();
            SetToolTip();
            string musicPath = "../../../../sound.wav";
            soundPlayer = new SoundPlayer(musicPath);
            soundPlayer.PlayLooping();
        }

        private void SetToolTip()
        {
            isSahar.Visible = false;
            isMilk.Visible = false;
            doubleEspressoToolTip.SetToolTip(doubleEspessoBut, "Кофейный напиток, готовящийся\n как двойная порция эспрессо с\n помощью кофейного фильтра или эспрессо-машины.");
            esprssoToolTip.SetToolTip(espressoBut, "Метод приготовления кофе путём прохождения\n горячей воды под давлением \nчерез фильтр с молотым кофе.");
            cappucinoToolTip.SetToolTip(cappucinoBut, "Кофейный напиток итальянской кухни\n на основе эспрессо с добавлением в\n него подогретого вспененного молока.");
            lungoToolTip.SetToolTip(lungoBut, "Напиток из кофе, приготовленный с помощью\n кофемашины по аналогии с эспрессо, \nно с большим количеством воды.");
            exchangeToolTip.SetToolTip(exchangeBut, "Привет бродяга! \nВижу ты деньги меняешь. \nДавай я тебе поменяю по более выгодному курсу!");
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            form.Text = title;
            label.Text = promptText;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 700, 20);
            buttonOk.SetBounds(228, 160, 160, 60);
            buttonCancel.SetBounds(400, 160, 160, 60);
            label.AutoSize = true;
            form.ClientSize = new Size(796, 307);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void exchangeBut_Click(object sender, EventArgs e)
        {
            ExternalCurrencyService externalService = new ExternalCurrencyService();
            ICurrencyExchange currencyExchange = new CurrencyExchangeAdapter(externalService);
            string value = "";
            InputBox("Интерфейс менялы", "Введите сумму и коды валют (пример, 100 RUB USD)", ref value);
            string[] inputParts = value.Split(' ');
            if (inputParts.Length != 3)
            {
                MessageBox.Show("Неверный формат ввода.");
                return;
            }

            if (!decimal.TryParse(inputParts[0], out decimal amount))
            {
                MessageBox.Show("Неверный формат суммы.");
                return;
            }

            try
            {
                decimal convertedAmount = currencyExchange.ConvertCurrency(amount, inputParts[1], inputParts[2]);
                MessageBox.Show($"Результат конвертации: {Math.Round(amount, 4)} {inputParts[1]} = {convertedAmount} {inputParts[2]}.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void milkBut_Click(object sender, EventArgs e)
        {
            _withMilk = !_withMilk;
            isMilk.Visible = _withMilk;
        }

        private void saharBut_Click(object sender, EventArgs e)
        {
            _withSugar = !_withSugar;
            isSahar.Visible = _withSugar;
        }

        private void ShowMessage(string text, double cost)
        {
            MessageBox.Show(
            $"Вы выпили: {text} \nОплатите: {cost}",
            "Господин, ваш кофе подан!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
        }

        private void cappucinoBut_Click(object sender, EventArgs e)
        {
            beverage1 = new Сappuccino();
            var beverageWithMilk = new MilkDecorator<Сappuccino>(beverage1);
            var beverageWithSugar = new SugarDecorator<Сappuccino>(beverage1);
            double cost;
            string description;

            if (_withMilk && _withSugar)
            {
                cost = beverageWithMilk.GetCost() + beverageWithSugar.GetCost() - beverage1.GetCost();
                description = "Капучино c молоком и сахаром";
            }
            else if (_withMilk && !_withSugar)
            {
                cost = beverageWithMilk.GetCost();
                description = "Капучино c молоком";
            }
            else if (!_withMilk && _withSugar)
            {
                cost = beverageWithSugar.GetCost();
                description = "Капучино c сахаром";
            }
            else
            {
                cost = beverage1.GetCost();
                description = "Капучино";
            }
            ShowMessage(description, cost);

        }

        private void doubleEspessoBut_Click(object sender, EventArgs e)
        {
            beverage = new Espresso();
            var beverageWithMilk = new MilkDecorator<Espresso>(beverage);
            var beverageWithSugar = new SugarDecorator<Espresso>(beverage);
            double cost;
            string description;

            if (_withMilk && _withSugar)
            {
                cost = beverageWithMilk.GetCost() + beverageWithSugar.GetCost();
                description = "Двойной эспрессо c молоком и сахаром";
            }
            else if (_withMilk && !_withSugar)
            {
                cost = 2 * beverageWithMilk.GetCost();
                description = "Двойной эспрессо c молоком";
            }
            else if (!_withMilk && _withSugar)
            {
                cost = 2 * beverageWithSugar.GetCost();
                description = "Двойной эспрессо c сахаром";
            }
            else
            {
                cost = 2 * beverage1.GetCost();
                description = "Двойной эспрессо";
            }
            ShowMessage(description, cost);
        }

        private void espressoBut_Click(object sender, EventArgs e)
        {
            beverage = new Espresso();
            var beverageWithMilk = new MilkDecorator<Espresso>(beverage);
            var beverageWithSugar = new SugarDecorator<Espresso>(beverage);
            double cost;
            string description;

            if (_withMilk && _withSugar)
            {
                cost = beverageWithMilk.GetCost() + beverageWithSugar.GetCost() - beverage.GetCost();
                description = "Эспрессо c молоком и сахаром";
            }
            else if (_withMilk && !_withSugar)
            {
                cost = beverageWithMilk.GetCost();
                description = "Эспрессо c молоком";
            }
            else if (!_withMilk && _withSugar)
            {
                cost = beverageWithSugar.GetCost();
                description = "Эспрессо c сахаром";
            }
            else
            {
                cost = beverage1.GetCost();
                description = "Эспрессо";
            }
            ShowMessage(description, cost);
        }

        private void lungoBut_Click(object sender, EventArgs e)
        {
            beverage2 = new Lungo();
            var beverageWithMilk = new MilkDecorator<Lungo>(beverage2);
            var beverageWithSugar = new SugarDecorator<Lungo>(beverage2);
            double cost;
            string description;

            if (_withMilk && _withSugar)
            {
                cost = beverageWithMilk.GetCost() + beverageWithSugar.GetCost() - beverage2.GetCost();
                description = "Лунго c молоком и сахаром";
            }
            else if (_withMilk && !_withSugar)
            {
                cost = beverageWithMilk.GetCost();
                description = "Лунго c молоком";
            }
            else if (!_withMilk && _withSugar)
            {
                cost = beverageWithSugar.GetCost();
                description = "Лунго c сахаром";
            }
            else
            {
                cost = beverage2.GetCost();
                description = "Лунго";
            }
            ShowMessage(description, cost);
        }

        private void easyRadioBut_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            Image image = Image.FromFile("../../../../angryHam.jpg");
            strategy.BackgroundImage = image;
            label5.Text = "";
            string musicPath = "../../../../End.wav";
            soundPlayer = new SoundPlayer(musicPath);
            soundPlayer.Play();

            Thread.Sleep(7000);

            string processName = "Skype";
            Process[] processes = Process.GetProcessesByName(processName);

            if (processes.Length > 0)
            {
                foreach (Process process in processes)
                {
                    try
                    {
                        process.Kill(true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error closing Skype: {ex.Message}");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция недоступна. Нажмите кнопку НАКАЗАТЬ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дорогой друг,\n наша игра находится на ранней стадии разработки. \nК сожалению, сейчас мы проходим сложные этапы тестирования и \nграфический интерфейс не работает.");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            int newX = random.Next(ClientSize.Width - button2.Width);
            int newY = random.Next(ClientSize.Height - button2.Height);
            button2.Location = new Point(newX, newY);
        }
    }
}

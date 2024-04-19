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
        private IBeverage<�appuccino> beverage1 = new �appuccino();
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
            doubleEspressoToolTip.SetToolTip(doubleEspessoBut, "�������� �������, �����������\n ��� ������� ������ �������� �\n ������� ��������� ������� ��� ��������-������.");
            esprssoToolTip.SetToolTip(espressoBut, "����� ������������� ���� ���� �����������\n ������� ���� ��� ��������� \n����� ������ � ������� ����.");
            cappucinoToolTip.SetToolTip(cappucinoBut, "�������� ������� ����������� �����\n �� ������ �������� � ����������� �\n ���� ����������� ����������� ������.");
            lungoToolTip.SetToolTip(lungoBut, "������� �� ����, �������������� � �������\n ���������� �� �������� � ��������, \n�� � ������� ����������� ����.");
            exchangeToolTip.SetToolTip(exchangeBut, "������ �������! \n���� �� ������ �������. \n����� � ���� ������� �� ����� ��������� �����!");
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
            InputBox("��������� ������", "������� ����� � ���� ����� (������, 100 RUB USD)", ref value);
            string[] inputParts = value.Split(' ');
            if (inputParts.Length != 3)
            {
                MessageBox.Show("�������� ������ �����.");
                return;
            }

            if (!decimal.TryParse(inputParts[0], out decimal amount))
            {
                MessageBox.Show("�������� ������ �����.");
                return;
            }

            try
            {
                decimal convertedAmount = currencyExchange.ConvertCurrency(amount, inputParts[1], inputParts[2]);
                MessageBox.Show($"��������� �����������: {Math.Round(amount, 4)} {inputParts[1]} = {convertedAmount} {inputParts[2]}.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"������: {ex.Message}");
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
            $"�� ������: {text} \n��������: {cost}",
            "��������, ��� ���� �����!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
        }

        private void cappucinoBut_Click(object sender, EventArgs e)
        {
            beverage1 = new �appuccino();
            var beverageWithMilk = new MilkDecorator<�appuccino>(beverage1);
            var beverageWithSugar = new SugarDecorator<�appuccino>(beverage1);
            double cost;
            string description;

            if (_withMilk && _withSugar)
            {
                cost = beverageWithMilk.GetCost() + beverageWithSugar.GetCost() - beverage1.GetCost();
                description = "�������� c ������� � �������";
            }
            else if (_withMilk && !_withSugar)
            {
                cost = beverageWithMilk.GetCost();
                description = "�������� c �������";
            }
            else if (!_withMilk && _withSugar)
            {
                cost = beverageWithSugar.GetCost();
                description = "�������� c �������";
            }
            else
            {
                cost = beverage1.GetCost();
                description = "��������";
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
                description = "������� �������� c ������� � �������";
            }
            else if (_withMilk && !_withSugar)
            {
                cost = 2 * beverageWithMilk.GetCost();
                description = "������� �������� c �������";
            }
            else if (!_withMilk && _withSugar)
            {
                cost = 2 * beverageWithSugar.GetCost();
                description = "������� �������� c �������";
            }
            else
            {
                cost = 2 * beverage1.GetCost();
                description = "������� ��������";
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
                description = "�������� c ������� � �������";
            }
            else if (_withMilk && !_withSugar)
            {
                cost = beverageWithMilk.GetCost();
                description = "�������� c �������";
            }
            else if (!_withMilk && _withSugar)
            {
                cost = beverageWithSugar.GetCost();
                description = "�������� c �������";
            }
            else
            {
                cost = beverage1.GetCost();
                description = "��������";
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
                description = "����� c ������� � �������";
            }
            else if (_withMilk && !_withSugar)
            {
                cost = beverageWithMilk.GetCost();
                description = "����� c �������";
            }
            else if (!_withMilk && _withSugar)
            {
                cost = beverageWithSugar.GetCost();
                description = "����� c �������";
            }
            else
            {
                cost = beverage2.GetCost();
                description = "�����";
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
            MessageBox.Show("������� ����������. ������� ������ ��������");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������� ����,\n ���� ���� ��������� �� ������ ������ ����������. \n� ���������, ������ �� �������� ������� ����� ������������ � \n����������� ��������� �� ��������.");
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

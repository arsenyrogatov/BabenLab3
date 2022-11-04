namespace BabenLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void atransform_button_Click(object sender, EventArgs e)
        {
            aresult_textBox.Text = "Результат: " + arMethod(ainput_textBox.Text.ToLower());
        }

        private string MTF(string input) //MTF преобразование
        {
            int inputLen = input.Length;
            List<char> alphabet = new List<char>(); //получаем уникальные буквы
            for (int i = 0; i < inputLen; i++)
            {
                if (!alphabet.Contains(input[i]))
                {
                    alphabet.Add(input[i]);
                }
            }
            alphabet.Sort();

            string result = "";
            for (int i = 0; i < inputLen; i++)
            {
                int index = alphabet.IndexOf(input[i]); //получаем индекс буквы
                result += index.ToString(); //записываем в результат этот индекс
                alphabet.RemoveAt(index); 
                alphabet.Insert(0, input[i]); //ставим индекс на первое место
            }
            return result;
        }

        private string BWT(string input) //BWT преобразование
        {
            int inputLen = input.Length;
            List<string> rotations = new List<string>(); //переставляем все буквы по очереди из конца в начало
            rotations.Add(input);
            for (int i = 0; i < inputLen - 1; i++)
            {
                int cutIndex = inputLen - i - 1;
                rotations.Add(input.Substring(cutIndex) + input.Substring(0, cutIndex));
            }
            rotations.Sort(); //сортируем полученные перестановки по алфавиту

            string result = "";
            for (int i = 0; i < inputLen; i++)
            {
                result += rotations[i][inputLen - 1]; //результат = последние буквы
            }
            return result;
        }

        struct ArSegment
        {
            public double left;
            public double right;
        }

        private string arMethod(string input)
        {
            acapacity_textBox.Text = "";
            int inputLen = input.Length;
            Dictionary<char, int> charFreq = new Dictionary<char, int>(); //считаем повторения букв и знаков

            for (int i = 0; i < inputLen; i++)
            {
                int tmpVal;
                if (charFreq.TryGetValue(input[i], out tmpVal))
                {
                    charFreq[input[i]] = tmpVal + 1;
                }
                else
                {
                    charFreq.Add(input[i], 1);
                }
            }

            Dictionary<char, ArSegment> segments = new Dictionary<char, ArSegment>();

            double l = 0;

            foreach (var keyValuePair in charFreq) //считаем сегменты для каждого значения частоты повторения буквы
            {
                acapacity_textBox.Text += "'"+keyValuePair.Key + "'\t|\t" + keyValuePair.Value + Environment.NewLine;
                ArSegment arSegment = new ArSegment();
                arSegment.left = l;
                arSegment.right = l + (keyValuePair.Value / (double)inputLen);
                l = arSegment.right;
                segments.Add(keyValuePair.Key, arSegment);
            }


            double left = 0;
            double right = 1;
            for (int i = 0; i < inputLen; i++) //это в википедии прочитай короче
            {
                var newRight = left + (right - left) * segments[input[i]].right;
                var newLeft = left + (right - left) * segments[input[i]].left;

                right = newRight;
                left = newLeft;
            }

            var result = (left + right) / 2;

            return result.ToString();
        }

        private void bwtmtf_button_Click(object sender, EventArgs e)
        {
            bwt_textBox.Text = BWT(input_textBox.Text.ToUpper());
            mtf_textBox.Text = MTF(bwt_textBox.Text);
        }
    }
}
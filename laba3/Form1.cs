using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Text.Encodings;
using System.Text;

namespace laba3
{
    public partial class Form1 : Form
    {
        string[] strings;
        string path = @"C:\Users\maksb\source\repos\laba3\laba3\Words.txt";
        string wrongWord;
        string word;
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            labelColor.BackColor = Color.Yellow;
            label.Text = "";
            word = strings[r.Next(strings.Length)];
            wrongWord = String.Concat(word.OrderBy(ch => ch));
            textBox.Text = "";
            for (int i = 0; i <= word.Length; i++)
            {
                label.Text = wrongWord;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strings = File.ReadAllLines(path);
        }

        private void aceptButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text == word)
            {
                labelColor.BackColor = Color.Green;
            }
            else
            {
                labelColor.BackColor = Color.Red;
            }
        }
    }
}
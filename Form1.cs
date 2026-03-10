namespace cs_gui_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(this.textN.Text);
            string[] parts = textBoxInput.Text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < n * 3){
                MessageBox.Show("Недостаточно чисел для треугольников.");
                return;
            }
            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(parts[i * 3]);
                b[i] = int.Parse(parts[i * 3 + 1]);
                c[i] = int.Parse(parts[i * 3 + 2]);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class TriangleCalculator
    {
        public int Count(int[] a, int[] b, int[] c, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] + b[i] > c[i] && a[i] + c[i] > b[i] && b[i] + c[i] > a[i])
                {
                    count++;
                }
            }
            return count;
        }
    }

}

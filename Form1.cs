namespace cs_gui_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textN.Text = Properties.Settings.Default.n_save.ToString();
            textBoxInput.Text = Properties.Settings.Default.Input_save;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            int[] a, b, c;
            string[] parts;
            try { 
                n = int.Parse(this.textN.Text);
                parts = textBoxInput.Text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length < n * 3){
                    MessageBox.Show("Недостаточно чисел для треугольников.");
                    return;
                }
                a = new int[n];
                b = new int[n];
                c = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(parts[i * 3]);
                    b[i] = int.Parse(parts[i * 3 + 1]);
                    c[i] = int.Parse(parts[i * 3 + 2]);
                }
            }
            catch (FormatException){ 
                MessageBox.Show("введите корректные числа");
                return;
            }
            Properties.Settings.Default.n_save = n;
            Properties.Settings.Default.Input_save = textBoxInput.Text;
            Properties.Settings.Default.Save();

            int validTriangles = new TriangleCalculator().Count(a, b, c, n);
            MessageBox.Show($"Количество треугольников: {validTriangles}");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class TriangleCalculator
    {
        public static int Count(List<Triangle> triangles)
        {
            int count = 0;
            foreach (var t in triangles)
            {
                if (t.IsValid())
                {
                    count++;
                }
            }
            return count;
        }
    }

}

public class Triangle
{
    public int a;
    public int b;
    public int c;

    public Triangle(int sideA, int sideB, int sideC)
    {
        a = sideA;
        b = sideB;
        c = sideC;
    }

    public bool IsValid()
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }
}
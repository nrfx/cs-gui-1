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
            var intN = int.Parse(this.textN.Text);
            var intA = int.Parse(this.textBoxInput.Text);
            var intB = int.Parse(this.textB.Text);
            var intC = int.Parse(this.textC.Text);

            MessageBox.Show(TriangleCalculator.Count(new int[] { intA }, new int[] { intB }, new int[] { intC }, 1).ToString());
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

namespace WinFormsSourceControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLength.Text, out int length) || !int.TryParse(txtWidth.Text, out int width))
            {
                MessageBox.Show("Please enter valid whole numbers for length and width.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtArea.Clear();
                txtPerimeter.Clear();
                return;
            }

            int area = length * width;
            int perimeter = 2 * (length + width);

            txtArea.Text = "Area is: " + area;
            txtPerimeter.Text = "Perimeter is: " + perimeter;
        }
    }
}

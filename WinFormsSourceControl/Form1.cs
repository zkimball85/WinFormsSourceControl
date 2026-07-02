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
            int length = Convert.ToInt32(txtLength.Text);
            int width = Convert.ToInt32(txtWidth.Text);

            int area = length * width;
            int perimeter = length * 2 + width * 2;

            txtArea.Text = "Area is: " + area;
            txtPerimeter.Text = "Perimeter is: " + perimeter;
        }
    }
}

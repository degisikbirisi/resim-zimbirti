namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowImageFullScreen(string imagePath)
        {
            Form fullScreenForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                BackgroundImage = Image.FromFile(imagePath),
                BackgroundImageLayout = ImageLayout.Stretch
            };

            fullScreenForm.Click += (s, e) => fullScreenForm.Close(); // Tam ekran formuna tıklanınca kapansın içeriden gelecek bağlantıya göre de yaptırılabilir
            fullScreenForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imagePath = "resim zımbırrtısının uzantısı";
            ShowImageFullScreen(imagePath);
        }
    }
}

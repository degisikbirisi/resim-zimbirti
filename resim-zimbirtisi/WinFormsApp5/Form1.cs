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

            fullScreenForm.Click += (s, e) => fullScreenForm.Close(); // Tam ekran formuna t�klan�nca kapans�n i�eriden gelecek ba�lant�ya g�re de yapt�r�labilir
            fullScreenForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imagePath = "resim z�mb�rrt�s�n�n uzant�s�";
            ShowImageFullScreen(imagePath);
        }
    }
}

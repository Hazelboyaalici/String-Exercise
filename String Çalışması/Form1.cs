namespace String_Çalışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string ad,soyad,yaş,meslek;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            yaş = maskedTextBox1.Text;
            meslek = textBox3.Text;

            listBox1.Items.Add(ad + " - "+ soyad + " - " + yaş + " - "+ meslek);
           

        }
    }
}
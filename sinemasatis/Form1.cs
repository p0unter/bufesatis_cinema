namespace sinemasatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        int kasa2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, kahve, kola, gazoz, toplam, kasa;
            misir = Convert.ToInt16(textMisir4.Text);
            kahve = Convert.ToInt16(textKahve2.Text);
            kola = Convert.ToInt16(textKola1.Text);
            gazoz = Convert.ToInt16(textGaz1.Text);
            toplam = (misir * 4 + kahve * 2 + kola * 1 + gazoz * 1);
            toplam1.Text = Convert.ToString(toplam);
            kasa2 = Convert.ToInt16(kasa2 + toplam);
            kasa1.Text = Convert.ToString(kasa2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textMisir4.Text = " ";
            textKahve2.Text = " ";
            textGaz1.Text = " ";
            textKola1.Text = " ";
        }
    }
}
namespace _3_yazılıyı_toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not1, not2, not3;
            double sonuc;

             not1 = Convert.ToInt32(txtNot1.Text);
             not2 = Convert.ToInt32(txtNot2.Text);
             not3 = Convert.ToInt32(txtNot3.Text);

             sonuc = (not1 + not2 + not3) / 3.0;

             lblOrtalama.Text = sonuc.ToString();
        }
    }
}
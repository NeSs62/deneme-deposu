namespace Vücut_İndeksi_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo, boy, vki;
            kilo = Convert.ToDouble(textBox1.Text);
            boy = Convert.ToDouble(textBox2.Text);
            vki = kilo / (boy * boy);
            textBox3.Text = Convert.ToString(vki);
            if (vki < 18)
            {
                label5.Text =  "zayıf";
            }
            else if (vki >= 18 && vki < 25)
            {
                label5.Text =  "Normal";
            }
            else if (vki >= 25 && vki < 30)
            {
                label5.Text =  "Kilolu";
            }
            else if (vki >= 30 && vki < 35)
            {
                label5.Text =  "Obez";
            }
        }
    }
}
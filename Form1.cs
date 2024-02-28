namespace combobox
{
    public partial class Form1 : Form
    {
        List<string> bilgiler = new()
        {
            "�stanbul","Ankara","�zmir","Manisa","�anakkaler"
        };
        public Form1()
        {
            InitializeComponent();
            // combobox�n i�erisine yeni bir itemm eklemek i�in .Items.add metodu kullan�r�r
            foreach (var item in bilgiler)
            {
                cmbSehirler.Items.Add(item);
            }
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            // text, combobox i�erisindeki text propertysi ile se�ilen metni okuyabiliriz.
            // selected index
            // combobox �n i�inde se�ilen elemean�n index numaras�n� d�nd�r�r.
            // de�er -1 d�n�yor ise herhangi bir ��e se��ilmemi� demektir

            int secilen = cmbSehirler.SelectedIndex;
            if (secilen == -1)
            {
                lblbilgi.Text = "Bir �ehir se�iniz";
                lblbilgi.ForeColor = Color.Red;
            }
            else
            {
                lblbilgi.Text = string.Format("{0} �ehri se�ildi ", cmbSehirler.Text);
                lblbilgi.ForeColor = Color.Azure;
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // combobox i�inde ki ��elerden silme i�lemini .items.removeat() metoduyla index no ya g�re sileriz

            int secim = cmbSehirler.SelectedIndex;

            if (secim == -1)
            {
                lblbilgi.Text = "�ehir se�iniz";
                lblbilgi.ForeColor = Color.Red;
            }
            else
            {
                string secilen = cmbSehirler.Text;
                cmbSehirler.Items.RemoveAt(secim);
                lblbilgi.Text = string.Format("{0} �ehri ba�ar�yla silindi", secilen);
                lblbilgi.ForeColor = Color.Green;
            }
        }

        private void btnHepsinisil_Click(object sender, EventArgs e)
        {
            // Combobox i�erisindeki t�m ��eleri silmek i�in .items.clear() metodu kullan�l�r

            DialogResult cevap = MessageBox.Show("T�m ��eleri silmek istedi�inize emin misiniz?", "Uyar�", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                cmbSehirler.Items.Clear();
            }
        }

        private void btndegistir_Click(object sender, EventArgs e)
        {
          int seciliindex=cmbSehirler.SelectedIndex;
            if(seciliindex == -1)
            {
                lblbilgi.Text = "Bir se�im Yap�n�z";
                lblbilgi.ForeColor= Color.Red;
            }
            else
            {
                string yenisehir=txtsehir.Text;
                if (yenisehir.Length<3)
                {
                    lblbilgi.Text = "en az 3 karakter girilmelidir.";
                    lblbilgi.ForeColor = Color.Red;
                }
                else
                {
                    bool varmi = false;
                    foreach (var item in cmbSehirler.Items)
                    {
                        if (item.ToString().ToLower()==yenisehir.ToLower())
                        {
                            lblbilgi.Text = "�ehir Bilgisi zaten mevcut";
                            lblbilgi.ForeColor=Color.Red;
                            varmi = true;
                            break;
                        }
                    }
                    if (!varmi)
                    {
                        string eskiksehir = cmbSehirler.Text;
                        cmbSehirler.Items[seciliindex] = yenisehir;
                        txtsehir.Clear();
                        lblbilgi.Text = string.Format("{0} �ehri {1} ile de�i�tirildi", yenisehir, eskiksehir);
                        lblbilgi.ForeColor = Color.Green;
                        cmbSehirler.SelectedIndex = -1;
                    }
                }
            }
        }
    }
}

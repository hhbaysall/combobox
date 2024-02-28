namespace combobox
{
    public partial class Form1 : Form
    {
        List<string> bilgiler = new()
        {
            "Ýstanbul","Ankara","Ýzmir","Manisa","Çanakkaler"
        };
        public Form1()
        {
            InitializeComponent();
            // comboboxýn içerisine yeni bir itemm eklemek için .Items.add metodu kullanýrýr
            foreach (var item in bilgiler)
            {
                cmbSehirler.Items.Add(item);
            }
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            // text, combobox içerisindeki text propertysi ile seçilen metni okuyabiliriz.
            // selected index
            // combobox ýn içinde seçilen elemeanýn index numarasýný döndürür.
            // deðer -1 dönüyor ise herhangi bir öðe seççilmemiþ demektir

            int secilen = cmbSehirler.SelectedIndex;
            if (secilen == -1)
            {
                lblbilgi.Text = "Bir þehir seçiniz";
                lblbilgi.ForeColor = Color.Red;
            }
            else
            {
                lblbilgi.Text = string.Format("{0} þehri seçildi ", cmbSehirler.Text);
                lblbilgi.ForeColor = Color.Azure;
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // combobox içinde ki öðelerden silme iþlemini .items.removeat() metoduyla index no ya göre sileriz

            int secim = cmbSehirler.SelectedIndex;

            if (secim == -1)
            {
                lblbilgi.Text = "Þehir seçiniz";
                lblbilgi.ForeColor = Color.Red;
            }
            else
            {
                string secilen = cmbSehirler.Text;
                cmbSehirler.Items.RemoveAt(secim);
                lblbilgi.Text = string.Format("{0} þehri baþarýyla silindi", secilen);
                lblbilgi.ForeColor = Color.Green;
            }
        }

        private void btnHepsinisil_Click(object sender, EventArgs e)
        {
            // Combobox içerisindeki tüm öðeleri silmek için .items.clear() metodu kullanýlýr

            DialogResult cevap = MessageBox.Show("Tüm öðeleri silmek istediðinize emin misiniz?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                lblbilgi.Text = "Bir seçim Yapýnýz";
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
                            lblbilgi.Text = "Þehir Bilgisi zaten mevcut";
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
                        lblbilgi.Text = string.Format("{0} þehri {1} ile deðiþtirildi", yenisehir, eskiksehir);
                        lblbilgi.ForeColor = Color.Green;
                        cmbSehirler.SelectedIndex = -1;
                    }
                }
            }
        }
    }
}

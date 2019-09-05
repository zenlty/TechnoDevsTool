using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32; //Eklemeyi unutmayalım !!
using System.Windows.Forms;

namespace TechnoDevs_Tool
{
    public partial class demo : Form
    {
        public demo()
        {
            InitializeComponent();
        }
        RegistryKey anahtar = Registry.CurrentUser;
        private void demo_Load(object sender, EventArgs e)
        {
            /*finish*/
            anahtar = anahtar.CreateSubKey("Software\\Google\\Source"); //REGİSTERED

            if ((anahtar.GetValue("Aktif") != null))
            {
                label1.Text = "SATIN ALDIĞINIZ İÇİN TEŞEKKÜR EDERİZ";
                label1.BackColor = Color.Red;
                txtserial.Enabled = false;
                button4.Enabled = false;
                button4.Text = "ETKİNLEŞTİRİLDİ";
                txtserial.Text = "LISANS SATIN ALDIGINIZ ICIN TESEKKURLER";

            }
            else
            {
                if (anahtar.GetValue("Sonkullanma") == null)
                {
                    label2.Text = "SURENIN BITMESINE 3 GUN KALDI";
                    label2.BackColor = Color.Cyan;
                    anahtar.SetValue("Sonkullanma", DateTime.Now.AddDays(3), RegistryValueKind.String);
                    anahtar.Flush();
                }

                else
                {

                    DateTime dt1 = Convert.ToDateTime(anahtar.GetValue("Sonkullanma"));
                    DateTime dt2 = Convert.ToDateTime(DateTime.Now.AddDays(0));

                    TimeSpan fark = dt1 - dt2;

                    int sonuc = Convert.ToInt32(fark.Days);


                    if (sonuc <= 0)
                    {
                        progressBar1.Value = 100;
                        MessageBox.Show("KULLANIM SURENIZ BITTI. PREMIUM SATIN ALINIZ");
                        button1.Visible = false;
                        System.Diagnostics.Process.Start("https://gsmturkey.net/threads/technodevs-tool-v2-premium.1669/");
                        Application.Exit();

                    }
                    else
                    {

                        label2.Text = "Aktivasyon için " + Convert.ToString(sonuc) + " gün kaldı";
                        label2.BackColor = Color.Cyan;


                        switch (sonuc)
                        {
                            case 1:
                                progressBar1.Value = 30;
                                break;

                            case 2:
                                progressBar1.Value = 60;
                                break;

                            case 3:
                                progressBar1.Value = 100;
                                break;
                        }
                    }
                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtserial.Text == "hakanislerpremium") //hakanisler
            {
                MessageBox.Show("HAKAN İŞLER HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            }
            if (txtserial.Text == "technodevsgelistiriciekibi") //TDT
            {
                MessageBox.Show("TECHNODEVS GELİŞTİRİCİ EKİBİ HOŞGELDİNİZ.", "KING EKİP :P ");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            }
            if (txtserial.Text == "premiumozelseri//0044GSM//") //özel
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            }
            if (txtserial.Text == "gsmturkeypremium") //premium1
            {
                MessageBox.Show("HOŞGELDİNİZ GSMTURKEY AİLESİ. LÜTFEN LİSANS KODU AİLEYE ÖZEL KALSIN", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            }
            if (txtserial.Text == "rtghenrlgıvhfvıjsfl423bhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            }
            if (txtserial.Text == "rtghenrlgıvhfvıjsfl5523bhefsgvşlm") //premium3
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rt%%ghenrlgıvhfvıjsflbhefsgvşlm") //premium4
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsflbhgdfvgvefsgvşlm") //premium5
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıj874sflbhefsgvşlm") //premium6
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlggregge4777474fsgvşlm") //premium7
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıv5645645654645fsgvşlm") //premium8
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenr8888şlm") //premium8
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhf&+^+%lm") //premium9
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenr+%/'+&5flbhefsgvşlm") //premium10
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "53534535flbhefsgvşlm") //premium11
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıv3453sgvşlm") //premium12
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenvbb22222hfvıjsflbhefsgvşlm") //premium13
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenr++++++şlm") //premium14
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlg4842224848") //premium15
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsflbhefsgvşlm") //premium16
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghen54-98/*65m") //premium17
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghe244/*---423") //premium18
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "r5186a309u235rfjvşlm") //premium19
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "r53678905fvbhefsgvşlm") //premium20
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfv//(^+%^'!Edm") //premium21
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenr2434sgvşlm") //premium22
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrl8758efsgvşlm") //premium23
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgı9398325252fsgvşlm") //premium24
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenr585858585lbhefsgvşlm") //premium25
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "9*9080pıvhfvıjsflbhefsgvşlm") //premium26
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rt113rFClbhefsgvşlm") //premium27
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvh3663263g2vşlm") //premium28
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsflbhe?=)(vşlm") //premium29
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghen[$½$½₺vıjfvgvşlm") //premium30
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenfe846853+'^+'Rm") //premium30
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "857u554864vfvfrgvv") //premium31
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rt6486wgvrc6r4gvrvgvşlm") //premium32
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "222rtghe2414hefsgvşlm") //premium33
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghe645645tggv55") //premium34
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenr54tggfvşlm") //premium35
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "25&&rtghenrlgıvhfvıjsflbhefsgvşlm") //premium36
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsflbhefsg456564vşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "356346rtghenrlgıvhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenr3767lgıvhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvh24645645654fvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsflbhe724574257fsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhf256456vıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıj24562456456sflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfv724682467ıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhf25724642567vıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtergevghenrlgıvhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgloılçömnbhtgıvhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvtregbdt<enbhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıj546498765423qsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsflb234567890987654hefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsf3456789987654edfcvbnlbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsf45678okmnfrgthlbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsfl576890897ı67juhbbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıj3456y7u6ı7o6kmjntdsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsflbhef435yuı5k6olökmngsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsflbhefsçıpşol8675432fevbgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsflbheftw4yh5eu6jık7ol8ş9çölkujy645rgwevfdsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsflbt4wyh5jmrnjs<jet4hefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsf<<<<<lbhefsgvfghj6teeşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvrerghfv4353ıjsfl<her<rebhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjs345365tgws<<flbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenr33lgıvhfvı>>>fweg4w4rhjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "2335ty5hnsr<e35UH") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghen34YTG4WWHhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtQ346T34GW4RHRW3lm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtg34T35GHBNEENDTJHNEDTJNEDTJND")
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenr*08978654YGlgıvhfvıjsf43G3T4YYlbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjs2JNJRY>>>flbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rI7YR6TUE5HJNlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtgh56I75KO8L9LÖUTKMYRJTEU5HYWRNvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "u5uyethrtghenrlgıvhfvıjsflbheY5EH6J4A6Qfsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rhetettghenr6453tsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghe346y57u86ı7okjybhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rt34657u68ıo6kjhgrfvgehtjyr7ık58rlgıvhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "456ıluöıkymutjyhtgdfvgbhnj") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "435647u8ı9okıjuhygtfrdfghj") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "r58tgue80tb058etgune0v9p") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rt3t5y6u7ı86okmjthşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rt56y7u5ıolökumjhtw45rg") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtgh4365y46u7ıkmrjtlbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "r365y7u8ı95o06pğ9şıl8yuktjrhgfm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtefrghnjmöçiüğ*p0o9876543w2sdefg") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rt34trgrssm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgı6nytbrfhyvfvhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıj6tjehedrgshsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtgh3545y6uı7kmjnhenrlgıvhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrl34567689ıkjtrthegbfrgıvhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvh345ty6hgthejnjtngdgthdethfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjsfl34556734t53rfghbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlg235u45u788ıjuhıvhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvh2356yu64j7yhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhf2356yu6ı7k86löjetghvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfv2356yuı77ıo9kjhbıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "r23456789809o8ıuygttghenrlgıvhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "235465768ı7juherbrtghenrl4gwbrhngıvhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "6789ıjuhgrtghenrlgıvhfvıjsflbhqerfqefefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlg2456y6ujhnbgfdıvhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvıjs132t4yh5ntbflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rgevtghenrlgıvhfvı123456u7ı8jhgjswdcfvflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıreergvhfvıjsflbegvefcvbheffrbgversgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtghenrlgıvhfvefwvgrbfıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtgergergghenrlgıvhfvıergergerjsflbhefsefwgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "rtergerggheregnrlgıvhfvrgetnıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            } if (txtserial.Text == "ergregrtergghenrlgergergıvhfvıjsflbhefsgvşlm") //premium2
            {
                MessageBox.Show("HOŞGELDİNİZ.", "PREMIUM");
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();

            }
            if (txtserial.Text == "baris.mizrakli/developer/Kilavya59") //BARIŞ MIZRAKLI
            {

                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                MessageBox.Show("BARIŞ MIZRAKLI HOŞGELDİNİZ.", "TECHNODEVS TOOL GELİSTİRİCİ");
                anahtar.Flush();
                Application.Restart();

            }

            else
            {
                MessageBox.Show("GİRDİĞİNİZ LİSANS KODU YANLIŞTIR.");
                MessageBox.Show("Satın Alma Sayfasına Yönlendirileceksiniz");
                System.Diagnostics.Process.Start("https://gsmturkey.net/threads/technodevs-tool-v2-premium.1669/");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gsmturkey.net/threads/technodevs-tool-v2-premium.1669/");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gsmturkey.net/threads/technodevs-tool-v2-premium.1669/");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (developersTextBox.Text == "bizsevdikteelleraldı")
            {
                MessageBox.Show("Hoşgeldin. 23:57 16 AĞUSTOS 2018 PERŞEMBE");
            }
            if (developersTextBox.Text == "tamiret")
            {
                MessageBox.Show("Hoşgeldin. 23:57 16 AĞUSTOS 2018 PERŞEMBE");
                progressBar1.Visible = true;
                button4.Visible = true;
                txtserial.Visible = true;
                label3.Visible = true;
                radioButton1.Visible = true;
                button1.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                MessageBox.Show("YETKİSİZ MÜDAHALEDE BULUNDUNUZ. GELİŞTİRİCİYE RAPOR BİLDİRİLİYOR");
                progressBar1.Visible = false;
                button4.Visible = false;
                txtserial.Visible = false;
                label3.Visible = false;
                radioButton1.Visible = false;
                button1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }

        }/*demoload*/
        /*finish*/
    }
}

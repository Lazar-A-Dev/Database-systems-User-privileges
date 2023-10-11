using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;//dodao
using NHibernate.Linq;//dodao
using PrivilegijeKorisnika.Entiteti;

namespace PrivilegijeKorisnika
{
    public partial class Ucitaj_NeuspelePokusaje : Form
    {
        public Ucitaj_NeuspelePokusaje()
        {
            InitializeComponent();
        }

        private void cmdPrikaziInfoKor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>("NemanjaJ991");

                MessageBox.Show("Ime: " + k.Ime + "\n" + "ImeRod: " + k.ImeRod + "\n" + "Prezime: " +  k.Prezime
                    + "\n" + "JedMatBr: " + k.JedMatBr + "\n" + "DatRodj: " + k.DatRodj + "\n" + "ImeRadnogMesta: " 
                   + k.ImeRadnogMesta + "\n" + "FunKojuObavlja: " + k.FunKojuObavlja + "\n" + "BrKancelarije: " 
                    + k.BrKancelarije + "\n" + "SifraKor: " + k.SifraKor + "\n" + "VremePoc: " + k.VremePoc + "\n" + 
                    "VremeZav: " + k.VremeZav);

                s.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUbaciKor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = new KorisnikIS();

                k.Id = "MartaF996";
                k.DatRodj = new DateTime(1996, 5, 3);
                k.JedMatBr = 03059966743295;
                k.VremePoc = "09:00";
                k.VremeZav = "15:00";
                k.ImeRadnogMesta = "Apeture";
                k.FunKojuObavlja = "Web developer";
                k.BrKancelarije = 23;
                k.SifraKor = "Maki32210";
                k.Ime = "Marta";
                k.ImeRod = "Darko";
                k.Prezime = "Filipinovic";

                s.Save(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdInfoGrupe_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GrupaKorisnika g = s.Load<GrupaKorisnika>("Phoenix");

                MessageBox.Show("JedIme: " + g.Id + "\n" + "KratakOpis: " + g.KratakOpis + "\n" + "DatumKreiranja: "
                    + g.DatumKreiranja + "\n" + "VremePocPer: " + g.VremePocPer + "\n" + "VremeKrajPer: " + g.VremeZavPer);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUbaciGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GrupaKorisnika g = new GrupaKorisnika();

                g.Id = "EnrityLab";
                g.KratakOpis = "Grupa sto specijalizuje u prepravkama koda na sql-ovom jeziku";
                g.DatumKreiranja = new DateTime(2016, 5, 17);
                g.VremePocPer = "09:00";
                g.VremeZavPer = "15:00";


                s.Save(g);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdKorObuhGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorisnikIS k1 = s.Load<KorisnikIS>("NemanjaJ991");
                foreach (GrupaKorisnika g1 in k1.Grupe)
                {
                    MessageBox.Show("Korisnik: " + k1.Id + "\n" + "Obuhvata grupu: " + g1.Id);
                }

                GrupaKorisnika g2 = s.Load<GrupaKorisnika>("DataDusk");
                foreach (KorisnikIS k2 in g2.Korisnici)
                {
                    MessageBox.Show("Grupi: " + g2.Id + "\n" + "Pripada korisnik: " + k2.Ime + " " + k2.Prezime);
                }

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdIzbrisiKor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorisnikIS k = s.Load<KorisnikIS>("MartaF996");
                s.Delete(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdIzbrisiGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GrupaKorisnika g = s.Load<GrupaKorisnika>("EnrityLab");
                s.Delete(g);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajProfl_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Profil p = s.Load<Profil>(14562);

                MessageBox.Show("RedniBr: " + p.Id + "\n" + "BojaPozadine: " + p.BojaPozadine + "\n" + "SpisakElGrafInt: "
                    + p.SpisakElGrafInt);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUbaciProfil_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Profil p = new Profil();

                p.BojaPozadine = "Braon";
                p.SpisakElGrafInt = "Tool tips, MessegeBox, Progress bar, Notifications";


                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdObrisiProfil_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Profil p = s.Load<Profil>(17265);
                s.Delete(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdKorPosProf_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorisnikIS k1 = s.Load<KorisnikIS>("NemanjaJ991");
                foreach (Profil p1 in k1.Profili)
                {
                    MessageBox.Show("Korisnik: " + k1.Id + "\n" + "Poseduje profil sa: " 
                        + "\n" + "Broj profila: " + p1.Id + "\n" + " Boja pozadine: " + p1.BojaPozadine);
                }

                Profil p2 = s.Load<Profil>(14967);
                foreach (KorisnikIS k2 in p2.KorisniciP)
                {
                    MessageBox.Show("Profil: " + p2.Id + "\n" + "Koristi korisnik: " + k2.Ime + " " + k2.Prezime);
                }

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajTelefon_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                BrTelefona b = s.Load<BrTelefona>(15782);
                string idKor = b.BrPripadaKor.Id;

                MessageBox.Show("Id korisnika: " + idKor + "\n" + "Kod: " + b.Id + "\n" + "BrojTelefona: " + b.Telefon);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajIP_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakIpAdresa i = s.Load<SpisakIpAdresa>(15819);
                string idKor = i.IpPripadaKor.Id;

                MessageBox.Show("Id korisnika: " + idKor + "\n" + "Kod: " + i.Id + "\n" + "IP_Adrese: " + i.IpAdrese);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUbaciIP_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = new KorisnikIS()
                {
                    Id = "NovakF996",
                    DatRodj =new DateTime(1996, 4, 9),
                    JedMatBr = 09049966743295,
                    VremePoc = "09:00",
                    VremeZav = "15:00",
                    ImeRadnogMesta = "Firefly",
                    FunKojuObavlja = "Front End developer",
                    BrKancelarije = 37,
                    SifraKor = "Noki19910",
                    Ime = "Novak",
                    ImeRod = "Milutin",
                    Prezime = "Rajkovic",

                };

                SpisakIpAdresa ip1 = new SpisakIpAdresa()
                {
                    //Id = 123231,
                    IpAdrese = "143.432.55.12.2"
                };

                SpisakIpAdresa ip2 = new SpisakIpAdresa()
                {
                    //Id = 123231,
                    IpAdrese = "103.12.105.14.5"
                };

                ip1.IpPripadaKor = k;

                k.IpAdrese.Add(ip1);

                s.Save(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)//Dodaje novog korisnik i nov broj telefona
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = new KorisnikIS(){
                    Id = "MartaF996",
                    DatRodj =new DateTime(1996, 5, 3),
                    JedMatBr = 03059966743295,
                    VremePoc = "09:00",
                    VremeZav = "15:00",
                    ImeRadnogMesta = "Apeture",
                    FunKojuObavlja = "Web developer",
                    BrKancelarije = 23,
                    SifraKor = "Maki32210",
                    Ime = "Marta",
                    ImeRod = "Darko",
                    Prezime = "Filipinovic",

                };

                BrTelefona br1 = new BrTelefona()
                {
                    Telefon = "0694234234"
                };

                BrTelefona br2 = new BrTelefona()
                {
                    Telefon = "0674234234"
                };

                br1.BrPripadaKor = k;
                //br2.BrPripadaKor = k;

                k.Telefoni.Add(br1);
                //k.Telefoni.Add(br2);

                s.Save(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdGrupaObuhvataGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                 GrupaObuhvataGrupu gog = s.Load<GrupaObuhvataGrupu>(105);

                MessageBox.Show("Kod: " + gog.Id + "\n" + "ImeNadGrupe: " + gog.PripadaNadGrupi.Id + 
                    "\n" + "ImePodGrupe: " +  gog.PripadaPodGrupi.Id);


                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajEmail_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                EmailAdresa ea = s.Load<EmailAdresa>(15985);
                string idKor = ea.EmailPripadaKor.Id;

                MessageBox.Show("Id korisnika: " + idKor + "\n" + "Kod: " + ea.Id + "\n" + "Email_Adresa: " + ea.Email);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUbaciEmail_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = new KorisnikIS()
                {
                    Id = "NevenaP995",
                    DatRodj =new DateTime(1995, 11, 13),
                    JedMatBr = 13119956711234,
                    VremePoc = "09:00",
                    VremeZav = "15:00",
                    ImeRadnogMesta = "CodeWish",
                    FunKojuObavlja = "PHP",
                    BrKancelarije = 24,
                    SifraKor = "NekiBFG76",
                    Ime = "Nevena",
                    ImeRod = "Ivica",
                    Prezime = "Pavlovic",

                };

                EmailAdresa e1 = new EmailAdresa()
                {
                    //Id = 123231,
                    Email = "Nevena.Pavlovic538@gmail.com"
                };

                EmailAdresa e2 = new EmailAdresa()
                {
                    //Id = 123231,
                    Email = "Nevena.Pavlovic995@gmail.com"
                };

                e1.EmailPripadaKor = k;
                //e2.EmailPripadaKor = k;

                k.EAdrese.Add(e1);
                //k.EAdrese.Add(e2);

                s.Save(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdGetKorisnikId_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Get<KorisnikIS>("AnaP990");
                if (k != null)
                    MessageBox.Show("ID Korisnika: " + k.Id);
                else
                    MessageBox.Show("Ne postoji korisnik sa ovim ID-jem");

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdReKorIS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Get<KorisnikIS>("AnaP990");

                s.Refresh(k);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdQueryKor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from KorisnikIS");
                IList<KorisnikIS> korisnici = q.List<KorisnikIS>();

                foreach (KorisnikIS k in korisnici) {
                    MessageBox.Show("ID Korisnika: " + k.Id);
                }
                
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajSistemProvere_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SistemProvere sp = s.Load<SistemProvere>(15458);

                MessageBox.Show("Kod: " + sp.Id + "\n" + "Sifra zadnji put promenjena: " + sp.SifraZadPutProm);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajSistemu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = new KorisnikIS()
                {
                    Id = "NebojsaP995",
                    DatRodj = new DateTime(1995, 9, 2),
                    JedMatBr = 02099956715685,
                    VremePoc = "09:00",
                    VremeZav = "15:00",
                    ImeRadnogMesta = "Apeture",
                    FunKojuObavlja = "Web developer",
                    BrKancelarije = 15,
                    SifraKor = "Neboj1099",
                    Ime = "Nebojsa",
                    ImeRod = "Stanko",
                    Prezime = "Petrovic",
                };

                SistemProvere sp = new SistemProvere()
                {
                    SifraZadPutProm = new DateTime(2022, 8, 28)
                };
               
                sp.SistemProvKor = k;

                 k.Provera.Add(sp);

                 s.Save(k);
                 s.Flush();
                 s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>("TanjaM993");
                foreach (BrTelefona br in k.Telefoni) {
                    MessageBox.Show("Id: " + br.Id + "\n" +  "Telefon: " + br.Telefon);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdBrisiBrTel_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BrTelefona br = s.Load<BrTelefona>(16129);
                s.Delete(br);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdIzbrisiIpAdr_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpisakIpAdresa ip = s.Load<SpisakIpAdresa>(16230);
                s.Delete(ip);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdIzbrisiEmail_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                EmailAdresa e1 = s.Load<EmailAdresa>(16092);
                s.Delete(e1);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajEmailPostojecemKor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>("AnaP990");

                EmailAdresa e1 = new EmailAdresa()
                {
                    //Id = 123231,
                    Email = "Ana.Peric101@gmail.com"
                };

                EmailAdresa e2 = new EmailAdresa()
                {
                    //Id = 123231,
                    Email = "Ana.Peric010@gmail.com"
                };

                e1.EmailPripadaKor = k;
                //e2.EmailPripadaKor = k;

                k.EAdrese.Add(e1);
                //k.EAdrese.Add(e2);

                s.Save(k);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajTelPostojecemKor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>("NemanjaJ991");

                BrTelefona br1 = new BrTelefona()
                {
                    //Id = 123231,
                    Telefon = "0658279027"
                };

                BrTelefona br2 = new BrTelefona()
                {
                    //Id = 123231,
                    Telefon = "0674369571"
                };

                br1.BrPripadaKor = k;
                //br2.BrPripadaKor = k;

                k.Telefoni.Add(br1);
                //k.Telefoni.Add(br2);

                s.Save(k);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajIpPostojecemKor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>("TanjaM993");

                SpisakIpAdresa ip1 = new SpisakIpAdresa()
                {
                    //Id = 123231,
                    IpAdrese = "145.22.155.0"
                };

                SpisakIpAdresa ip2 = new SpisakIpAdresa()
                {
                    //Id = 123231,
                    IpAdrese = "112.34.553.10"
                };

                ip1.IpPripadaKor = k;
                //ip2.IpPripadaKor = k;

                k.IpAdrese.Add(ip1);
                //k.IpAdrese.Add(ip2);

                s.Save(k);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajIpAdrGrupe_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakIpAdresaGrupe i = s.Load<SpisakIpAdresaGrupe>(14588);
                string idGrupe = i.IpPripadaGrupi.Id;

                MessageBox.Show("Id korisnika: " + idGrupe + "\n" + "Kod: " + i.Id + "\n" + "IP_Adrese: " + i.IpAdrese);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajIpGrupe_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GrupaKorisnika g = new GrupaKorisnika()
                {
                    Id = "HardCom",
                    KratakOpis = "Grupa sto specijalizuje u popravku hardware uredjaima",
                    DatumKreiranja = new DateTime(2017, 12, 18),
                    VremePocPer = "09:00",
                    VremeZavPer = "15:00"

                };

                SpisakIpAdresaGrupe ipg1 = new SpisakIpAdresaGrupe()
                {
                    //Id = 143231,
                    IpAdrese = "102.132.14.52.6"
                };

                SpisakIpAdresaGrupe ipg2 = new SpisakIpAdresaGrupe()
                {
                    //Id = 143231,
                    IpAdrese = "113.22.505.64.3"
                };

                ipg1.IpPripadaGrupi = g;

                g.IpAdreseGrupe.Add(ipg1);

                s.Save(g);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdNadjiIdGrupe_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GrupaKorisnika g = s.Get<GrupaKorisnika>("HardCom");
                if (g != null)
                    MessageBox.Show("ID Grupe: " + g.Id);
                else
                    MessageBox.Show("Ne postoji grupa sa ovim ID-jem");

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajIpPostojecojGrupi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GrupaKorisnika g = s.Load<GrupaKorisnika>("HardCom");

                SpisakIpAdresaGrupe ipg1 = new SpisakIpAdresaGrupe()
                {
                    //Id = 123231,
                    IpAdrese = "136.72.185.2"
                };

                SpisakIpAdresa ip2 = new SpisakIpAdresa()
                {
                    //Id = 123231,
                    IpAdrese = "112.34.553.10"
                };

                ipg1.IpPripadaGrupi = g;
                //ipg2.IpPripadaGrupi = g;

                g.IpAdreseGrupe.Add(ipg1);
                //g.IpAdreseGrupe.Add(ipg2);

                s.Save(g);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdIzbrisiIpGrupe_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpisakIpAdresaGrupe ipg = s.Load<SpisakIpAdresaGrupe>(14600);
                s.Delete(ipg);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajSPPostojecemKor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>("MilutinS998");

                SistemProvere sp1 = new SistemProvere()
                {
                    SifraZadPutProm = new DateTime(2022, 8, 30)
                };

                sp1.SistemProvKor = k;

                k.Provera.Add(sp1);

                s.Save(k);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdIzbrisiIzSP_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SistemProvere sp = s.Load<SistemProvere>(16748);
                s.Delete(sp);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajPredSifre_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SistemProvere sp = s.Load<SistemProvere>(14333);
                foreach (PredSifreKor psk in sp.PredSifre) {
                    MessageBox.Show("Predhodna sifra: " + psk.PredhodnaSifra);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajPSK_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SistemProvere sp = s.Load<SistemProvere>(16145);


                PredSifreKor psk = new PredSifreKor()
                {
                    PredhodnaSifra = "DulePP32"
                };

                psk.PredSifrePripadajuSistemu = sp;
                sp.PredSifre.Add(psk);

                s.Save(sp);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdBrojPromenaSifre_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SistemProvere sp = s.Load<SistemProvere>(16145);
                int broj = 0;
                foreach (PredSifreKor psk in sp.PredSifre)
                {
                    broj++;
                }

                MessageBox.Show("Broj promena sifre: " + broj);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdTajmerPromeneSifre_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SistemProvere sp = s.Load<SistemProvere>(14333);

                DateTime DtServer = sp.SifraZadPutProm;
                DateTime DtNow = DateTime.Now;
                var Difference = DtNow - DtServer;
                if (Difference.Days > 30)
                MessageBox.Show("Korisnik nije promenio sifru u roku od 30 dana");
                else
                MessageBox.Show("Sifra je zadnji put promenjena pre: " + "Dana: " + Difference.Days + " : " + "Sati: " + Difference.Hours + " : " + "Minuta: " + Difference.Minutes);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdUcitajNeuspesnePokusaje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NeuspeliPokusajPrijave npp = s.Load<NeuspeliPokusajPrijave>(14508);

                MessageBox.Show("Kod: " + npp.Id + "\n" + "Pogresna Sifra: " + npp.PogresnaSifra + "\n" + "Datum i vreme: " 
                    + npp.Datum + "/" + npp.Vreme + "\n" + "Ip adresa: " + npp.IpAdresa + "\n" 
                    + "Prava sifra korisnika: " + npp.SifraKor);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajNeuspelomPokusaju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = new KorisnikIS()
                {
                    Id = "BiljanaM998",
                    DatRodj =new DateTime(1998,12,5),
                    JedMatBr = 051299814552245,
                    VremePoc = "09:00",
                    VremeZav = "15:00",
                    ImeRadnogMesta = "DataDusk",
                    FunKojuObavlja = "Network Programming",
                    BrKancelarije = 3,
                    SifraKor = "BiljaFPDA",
                    Ime = "Biljana",
                    ImeRod = "Filip",
                    Prezime = "Mitrovic",
                };

                NeuspeliPokusajPrijave npp = new NeuspeliPokusajPrijave()
                {
                    Id = 14497,
                    PogresnaSifra = "Bilja3FFD",
                    Datum = "11-SEP-2020",
                    Vreme = "09:30",
                    IpAdresa = "103.44.21.455",
                    SifraKor = "BiljaFPDA"
                };

                npp.NeuspeliPokPamtiKor = k;

                k.PokusajPrijave.Add(npp);

                s.Save(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajNPPPosKor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>("DaniloJ992");

                NeuspeliPokusajPrijave npp = new NeuspeliPokusajPrijave()
                {
                    PogresnaSifra = "DanMen33",
                    Datum = "07-OCT-2020",
                    Vreme = "09:21",
                    IpAdresa = "103.44.21.455",
                    SifraKor = k.SifraKor
                };

                npp.NeuspeliPokPamtiKor = k;

                k.PokusajPrijave.Add(npp);

                s.Save(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NeuspeliPokusajPrijave npp = s.Load<NeuspeliPokusajPrijave>(14497);
                s.Delete(npp);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdBrojNeuspesnihPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorisnikIS k = s.Load<KorisnikIS>("VeljkoD997");
                int broj = 0;
                foreach (NeuspeliPokusajPrijave npp in k.PokusajPrijave)
                {
                    broj++;
                }

                MessageBox.Show("Broj neuspesnih prijava: " + broj);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdPrikaziPodGrupe_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GrupaObuhvataGrupu gog = s.Load<GrupaObuhvataGrupu>(105);

                GrupaKorisnika ngk = s.Load<GrupaKorisnika>(gog.PripadaNadGrupi.Id);

                GrupaKorisnika pgk = s.Load<GrupaKorisnika>(gog.PripadaPodGrupi.Id);


                MessageBox.Show("Ngk: " + ngk.Id + " " + "Pgk: " + pgk.Id);
                


                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpdateBrTelefona_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                BrTelefona b = s.Load<BrTelefona>(15782);

                s.Close();
                b.Telefon = "0674638214";
                ISession s1 = DataLayer.GetSession();

                s1.Update(b);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpit1KorisnikIS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from KorisnikIS as k where k.ImeRadnogMesta = 'Croware' ");

                IList<KorisnikIS> korisnici = q.List<KorisnikIS>();

                foreach (KorisnikIS k in korisnici)
                {
                    MessageBox.Show("Id korisnika: " + k.Id);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void QuarySaParKorisnikIS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Paramterizovani upit
                IQuery q = s.CreateQuery("from KorisnikIS as k where k.FunKojuObavlja = ? and k.BrKancelarije >= ?");
                q.SetParameter(0, "Program tester");//Radi kao 1. uslov 
                q.SetInt32(1, 2);//Broj kacelarije kao 2. uslov

                IList<KorisnikIS> korisnici = q.List<KorisnikIS>();

                foreach (KorisnikIS k in korisnici)
                {
                    MessageBox.Show(k.Id + " " + k.ImeRadnogMesta);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdQuarySaPar2KorIS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Paramterizovani upit
                IQuery q = s.CreateQuery("select n.NeuspeliPokPamtiKor from NeuspeliPokusajPrijave as n "
                    + " where n.Id >= :Kod and n.Vreme <= :time and n.Datum <= :date");
                q.SetInt32("Kod", 14409); 
                q.SetString("time", "09:15");
                q.SetString("date", "15-SEP-2018");

                IList<KorisnikIS> korisnik = q.List<KorisnikIS>();

                foreach (KorisnikIS k in korisnik)
                {
                    MessageBox.Show("JedImeKor: " + k.Id);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdEnumerableKor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from KorisnikIS");

                IEnumerable<KorisnikIS> korisnik = q.Enumerable<KorisnikIS>();

                foreach (KorisnikIS k in korisnik)
                {
                    if (k.ImeRadnogMesta == "Firefly")
                        break;

                }
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdSkalarniRezKor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select sum(k.BrKancelarije) from KorisnikIS k ");

                //za slucaj da upit vraca samo jednu vrednost
                Int64 kase = q.UniqueResult<Int64>();

                MessageBox.Show("Broj sabranih kancelarija: " + kase.ToString());

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUniqueRezKorIS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select k from KorisnikIS k where k.Id = 'VeljkoD997' ");

                //za slucaj da upit vraca samo jednu vrednost
                KorisnikIS k = q.UniqueResult<KorisnikIS>();

                MessageBox.Show("Ime radnog mesta: " + k.ImeRadnogMesta);

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdVisestrukiRezKorIS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("select k.ImeRadnogMesta, sum(k.BrKancelarije), count(k) from KorisnikIS k "
                                        + " group by k.ImeRadnogMesta ");

                //za slucaj da upit vraca visestruku vrednost
                IList<object[]> result = q.List<object[]>();

                foreach (object[] r in result)
                {
                    string tip = (string)r[0];//Ime radon mesta
                    Int64 kase = (Int64)r[1];//broj kancelarija
                    long broj = (Int64)r[2];//Broj radnih mesta

                    MessageBox.Show(tip + " " + broj.ToString() + " " + kase.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdStranicenjeKorIS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from KorisnikIS");
                q.SetFirstResult(3);//Koliko preskace od prvog clana
                q.SetMaxResults(2);//Koliko da stampa

                IList<KorisnikIS> korisnik = q.List<KorisnikIS>();

                foreach (KorisnikIS k in korisnik)
                {
                    MessageBox.Show("JedKorIme: " + k.Id);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCriteriaKorIS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<KorisnikIS>();

                c.Add(Expression.Ge("BrKancelarije", 20));//1. uslov koji mora da ispunjava
                c.Add(Expression.Eq("ImeRadnogMesta", "SoftWolf"));//2. uslov koji mora da ispunjava

                IList<KorisnikIS> korisnik = c.List<KorisnikIS>();

                foreach (KorisnikIS k in korisnik)
                {
                    MessageBox.Show("JedKorIme: " + k.Id);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdQuaryOver_KorIS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<KorisnikIS> korisnik = s.QueryOver<KorisnikIS>()//alternativa za kriteriju
                                                .Where(x => x.BrKancelarije >= 8)
                                                .Where(x => x.ImeRadnogMesta == "Apeture")
                                                .List<KorisnikIS>();

                foreach (KorisnikIS k in korisnik)
                {
                    MessageBox.Show("JedKorIme: " + k.Id);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdNativeSQLKorIS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ISQLQuery q = s.CreateSQLQuery("SELECT K.* FROM KORISNIK_IS K");
                q.AddEntity(typeof(KorisnikIS));


                IList<KorisnikIS> korisnik = q.List<KorisnikIS>();

                foreach (KorisnikIS k in korisnik)
                {
                    MessageBox.Show("JedKorIme: " + k.Id);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdTransakcijaKorIS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                 KorisnikIS k = s.Load<KorisnikIS>("BiljanaM998");

                ITransaction t = s.BeginTransaction();

                s.Delete(k);

                //t.Commit();
                t.Rollback();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdLINQKorIS_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<KorisnikIS> korisnik = (from k in s.Query<KorisnikIS>()
                                              where (k.BrKancelarije >= 5 && k.ImeRadnogMesta == "Croware")
                                              select k).ToList<KorisnikIS>();

                foreach (KorisnikIS k in korisnik)
                {
                    MessageBox.Show("JedKorIme: " + k.Id);
                }


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUpdateIpAdresu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakIpAdresa ip = s.Load<SpisakIpAdresa>(15993);

                s.Close();
                ip.IpAdrese = "147.77.188.12";
                ISession s1 = DataLayer.GetSession();

                s1.Update(ip);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpdateEmailAdresu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                EmailAdresa ea = s.Load<EmailAdresa>(15886);

                s.Close();
                ea.Email = "Ana.PericAPD@gmail.com";
                ISession s1 = DataLayer.GetSession();

                s1.Update(ea);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdRefreshGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GrupaKorisnika g = s.Get<GrupaKorisnika>("CrackWire");

                s.Refresh(g);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpdateIpAdresuGrupe_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakIpAdresaGrupe ipg = s.Load<SpisakIpAdresaGrupe>(14598);

                s.Close();
                ipg.IpAdrese = "147.77.188.12";
                ISession s1 = DataLayer.GetSession();

                s1.Update(ipg);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdGetProfil_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Profil p = s.Get<Profil>(15783);
                if (p != null)
                    MessageBox.Show("ID Profila: " + p.Id);
                else
                    MessageBox.Show("Ne postoji profil sa ovim ID-jem");

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdRefreshProfil_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Profil p = s.Get<Profil>(14562);

                s.Refresh(p);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpdateSistemProvere_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SistemProvere sp = s.Load<SistemProvere>(15458);

                s.Close();
                sp.SifraZadPutProm = new DateTime(2022, 9, 17);
                ISession s1 = DataLayer.GetSession();

                s1.Update(sp);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetSistemProvere_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SistemProvere sp = s.Get<SistemProvere>(14333);
                if (sp != null)
                    MessageBox.Show("ID Sistema Provere: " + sp.Id);
                else
                    MessageBox.Show("Ne postoji Sistem Provere sa ovim ID-jem");

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdRefreshSistemProvere_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SistemProvere sp = s.Get<SistemProvere>(16145);

                s.Refresh(sp);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpdatePredSifre_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PredSifreKor psk = s.Load<PredSifreKor>(14282);

                s.Close();
                psk.PredhodnaSifra = "DaniloooAA98";
                ISession s1 = DataLayer.GetSession();

                s1.Update(psk);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpdateNeuspelePokusaje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NeuspeliPokusajPrijave npp = s.Load<NeuspeliPokusajPrijave>(14469);

                s.Close();
                npp.PogresnaSifra = "Velljkoas22";
                npp.Datum = "19-NOV-2019";
                npp.Vreme = "09:10";
                ISession s1 = DataLayer.GetSession();

                s1.Update(npp);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajPriv_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije p = s.Load<Privilegije>(1);

                MessageBox.Show("Tip privilegije: " + p.Tip);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajPriv_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije p = new Privilegije();

                p.Tip = "Administrativne privilegije";

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdIzbrisiPriv_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Privilegije p = s.Load<Privilegije>(11);
                s.Delete(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpdatePriv_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije p = s.Load<Privilegije>(4);

                s.Close();
                p.Tip = "DROP ANY TYPE";
                ISession s1 = DataLayer.GetSession();

                s1.Update(p);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajKorDodjeljPrivGrupi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorDodeljujePrivGrupi kdpg = s.Load<KorDodeljujePrivGrupi>(1);

                MessageBox.Show("JedKorIme: " + kdpg.PripadaKorStoDodeljGrupi.Id + "\n" + "JedImeGrupe: " 
                    + kdpg.PripadaGrupiKojojDodeljKor.Id + "\n" + "JedBrPriv: " + kdpg.PripadaPrivKojiKorDodeljGrupi.Id 
                    + "\n" + "Tip prilegije: " + kdpg.PripadaPrivKojiKorDodeljGrupi.Tip + "\n" + "DatumDodele: " + kdpg.DatumDodele);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajPrivGrupi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorisnikIS k = s.Load<KorisnikIS>("MarkoN992");
                GrupaKorisnika gk = s.Load<GrupaKorisnika>("ComLink");
                Privilegije p = s.Load<Privilegije>(3);

                KorDodeljujePrivGrupi kdpg = new KorDodeljujePrivGrupi()
                {
                    DatumDodele = new DateTime(2021, 9, 11)
                };

                kdpg.PripadaKorStoDodeljGrupi = k;
                kdpg.PripadaGrupiKojojDodeljKor = gk;
                kdpg.PripadaPrivKojiKorDodeljGrupi = p;

                k.KorDodeljGrupi.Add(kdpg);
                gk.GrupiDodjKor.Add(kdpg);
                p.PrivKorDodeljujeGrupi.Add(kdpg);

                s.Save(k);
                s.Save(gk);
                s.Save(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateKorDodeljPrivGrupi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorDodeljujePrivGrupi kdpg = s.Load<KorDodeljujePrivGrupi>(3);
                kdpg.PripadaKorStoDodeljGrupi = s.Load<KorisnikIS>("TijanaP001");//Strani kljuc se ucita pre zatvaranja sesije

                s.Close();
                kdpg.DatumDodele = new DateTime(2020, 12, 19);


                ISession s1 = DataLayer.GetSession();

                s1.Update(kdpg);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteKorDodjeljPrivGrupi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorDodeljujePrivGrupi kdpg = s.Load<KorDodeljujePrivGrupi>(4);
                s.Delete(kdpg);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajKorDodeljPrivKor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorDodeljujePrivKor kdpk = s.Load<KorDodeljujePrivKor>(1);

                MessageBox.Show("JedKorImeNad: " + kdpk.PripadaKorNadStoDodeljKorPod.Id + "\n" + "JedKorImePod: "
                    + kdpk.PripadaKorPodKomeDodeljKorNad.Id + "\n" + "BrPrivKor: " + kdpk.PripadaPrivKojiKorNadDodeljKorPod.Id
                    + "\n" + "Tip prilegije: " + kdpk.PripadaPrivKojiKorNadDodeljKorPod.Tip + "\n" + "DatumDodele: " 
                    + kdpk.DatumDodele);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajKorDodeljPrivKor_Click(object sender, EventArgs e)
        {
            try 
            { 
                ISession s = DataLayer.GetSession();

                KorisnikIS kn = s.Load<KorisnikIS>("NemanjaJ991");
                KorisnikIS kp = s.Load<KorisnikIS>("VeljkoD997");
                Privilegije p = s.Load<Privilegije>(3);

                KorDodeljujePrivKor kdpk = new KorDodeljujePrivKor()
                {
                    DatumDodele = new DateTime(2022, 4, 12)
                };

                kdpk.PripadaKorNadStoDodeljKorPod = kn;
                kdpk.PripadaKorPodKomeDodeljKorNad = kp;
                kdpk.PripadaPrivKojiKorNadDodeljKorPod = p;

                kn.KorNadDodeljKorPod.Add(kdpk);
                kp.KorPodKomeDodeljKorNad.Add(kdpk);
                p.PrivKorDodeljujeKor.Add(kdpk);

                s.Save(kn);
                s.Save(kp);
                s.Save(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpdateKorDodeljPrivKor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorDodeljujePrivKor kdpk = s.Load<KorDodeljujePrivKor>(3);
                kdpk.PripadaKorPodKomeDodeljKorNad = s.Load<KorisnikIS>("DaniloJ992");//Strani kljuc se ucita pre zatvaranja sesije

                s.Close();
                kdpk.DatumDodele = new DateTime(2022, 5, 4);


                ISession s1 = DataLayer.GetSession();

                s1.Update(kdpk);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdIzbrisiKorDodeljPrivKor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorDodeljujePrivKor kdpk = s.Load<KorDodeljujePrivKor>(4);
                s.Delete(kdpk);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdKorHasManyIpAdr_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>("AnaP990");
                foreach (SpisakIpAdresa ip in k.IpAdrese)
                {
                    MessageBox.Show("Korisnik: " + k.Id + "\n" + "Ip Adresa: " + ip.IpAdrese);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdKorHasManyEmailAdr_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>("DusanS994");
                foreach (EmailAdresa ea in k.EAdrese)
                {
                    MessageBox.Show("Korisnik: " + k.Id + "\n" + "Email-Adresa: " + ea.Email);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdGrupaHasHamyIpAdr_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GrupaKorisnika gk = s.Load<GrupaKorisnika>("Phoenix");
                foreach (SpisakIpAdresaGrupe ipg in gk.IpAdreseGrupe)
                {
                    MessageBox.Show("Grupa: " + gk.Id + "\n" + "Ip Adresa: " + ipg.IpAdrese);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpdateProfil_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Profil p = s.Load<Profil>(17243);

                s.Close();
                p.BojaPozadine = "Tirkizna";
                ISession s1 = DataLayer.GetSession();

                s1.Update(p);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpdateGrupuStoObuhvataGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GrupaObuhvataGrupu gog = s.Load<GrupaObuhvataGrupu>(156);
                gog.PripadaPodGrupi = s.Load<GrupaKorisnika>("HardCom");

                s.Close();

                ISession s1 = DataLayer.GetSession();

                s1.Update(gog);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajGrupiStoObuhvataGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GrupaKorisnika gkn = s.Load<GrupaKorisnika>("EntityLab");//Nad
                GrupaKorisnika gkp = s.Load<GrupaKorisnika>("DataDusk");//Pod

                GrupaObuhvataGrupu gog = new GrupaObuhvataGrupu()
                {

                };

                gog.PripadaNadGrupi = gkn;
                gog.PripadaPodGrupi = gkp;

                gkn.NadGrupa.Add(gog);
                gkp.PodGrupa.Add(gog);

                s.Save(gkn);
                s.Save(gkp);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdIzbrisiGrupuStoObuhvataGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GrupaObuhvataGrupu gog = s.Load<GrupaObuhvataGrupu>(150);
                s.Delete(gog);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajPrivZaElInt_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrivZaElementeInterfejsa pzei = s.Load<PrivZaElementeInterfejsa>(1);

                MessageBox.Show("Opis: " + pzei.Opis + "\n" + "Akcija: " + pzei.Akcija + "\n" 
                    + "Samo vidi taj element: " + pzei.SamoVidiTajEl);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajPrivZaElInt_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije p = s.Load<Privilegije>(6);

                PrivZaElementeInterfejsa pzai = new PrivZaElementeInterfejsa()
                {
                    Opis = "Read License info",
                    Akcija= "da",
                    SamoVidiTajEl = "ne"
                };

                pzai.ElIntPripadaPriv = p;
                p.ElementInt.Add(pzai);

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdatePrivZaElInt_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrivZaElementeInterfejsa pzei = s.Load<PrivZaElementeInterfejsa>(12);
               
                s.Close();
                pzei.Akcija = "ne";
                pzei.SamoVidiTajEl = "da";

                ISession s1 = DataLayer.GetSession();

                s1.Update(pzei);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IzbrisiPrivZaElInt_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PrivZaElementeInterfejsa pzei = s.Load<PrivZaElementeInterfejsa>(12);
                s.Delete(pzei);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UcitajPrivZaFunModApk_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrivZaFunModApk pzei = s.Load<PrivZaFunModApk>(1);

                MessageBox.Show("Opis: " + pzei.Opis);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)//Dodaj u privilegije priv za el. int.
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije p = new Privilegije();

                PrivZaElementeInterfejsa pzei = s.Load<PrivZaElementeInterfejsa>(2);

                p.Tip = pzei.Opis;

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajPrivZaFunModApk_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije p = s.Load<Privilegije>(7);

                PrivZaFunModApk pzfma = new PrivZaFunModApk()
                {
                    Opis = "Manage Data Encryption",
                };

                pzfma.FunModApkPripadaPriv = p;
                p.FunModApk.Add(pzfma);

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdatePrivZaFunModApk_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrivZaFunModApk pzfma = s.Load<PrivZaFunModApk>(3);

                s.Close();
                pzfma.Opis = "Manage User Synchronization Filters";

                ISession s1 = DataLayer.GetSession();

                s1.Update(pzfma);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdIzbrisiPrivZaFunModApk_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PrivZaFunModApk pzfma = s.Load<PrivZaFunModApk>(3);
                s.Delete(pzfma);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdPrivZaFunModApkDodajPriv_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije p = new Privilegije();

                PrivZaFunModApk pzfma = s.Load<PrivZaFunModApk>(2);

                p.Tip = pzfma.Opis;

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajAdminPriv_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                AdministrativnePriv ap = s.Load<AdministrativnePriv>(1);

                MessageBox.Show("Opis: " + ap.Opis);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)//Dodaj admin prvililegije
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije p = s.Load<Privilegije>(10);

                AdministrativnePriv ad = new AdministrativnePriv()
                {
                    Opis = "Manege User WIP Limits"
                };

                ad.AdminPripadaPriv = p;
                p.AdminPriv.Add(ad);

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateAdminPriv_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                AdministrativnePriv ad = s.Load<AdministrativnePriv>(4);

                s.Close();
                ad.Opis = "Manege User WIP Limits";

                ISession s1 = DataLayer.GetSession();

                s1.Update(ad);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdIzbrisiAdminPriv_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AdministrativnePriv ad = s.Load<AdministrativnePriv>(4);
                s.Delete(ad);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdAdminPrivDodajPriv_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Privilegije p = new Privilegije();

                AdministrativnePriv ad = s.Load<AdministrativnePriv>(3);

                p.Tip = ad.Opis;

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajRodjSavMenija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RodStavkaMenija rsm = s.Load<RodStavkaMenija>(3);

                MessageBox.Show("Privilegija za Element interfejsa nad: " + rsm.PripadaElIntNad.Opis 
                    + "\n" + "Privilegija za Element interfejsa pod: " + rsm.PripadaElIntPod.Opis);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajRodStavMenija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PrivZaElementeInterfejsa privNad = s.Load<PrivZaElementeInterfejsa>(2);
                PrivZaElementeInterfejsa privPod = s.Load<PrivZaElementeInterfejsa>(3);

                RodStavkaMenija rod = new RodStavkaMenija()
                {

                };

                rod.PripadaElIntNad = privNad;
                rod.PripadaElIntPod = privPod;

                privNad.NadPrivZaElInt.Add(rod);
                privPod.PodPrivZaElInt.Add(rod);

                s.Save(privNad);
                s.Save(privPod);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpdateRodStavMenija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RodStavkaMenija rod = s.Load<RodStavkaMenija>(2);
                rod.PripadaElIntPod = s.Load<PrivZaElementeInterfejsa>(3);

                s.Close();

                ISession s1 = DataLayer.GetSession();

                s1.Update(rod);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdIzbrisiRodStavMenija_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RodStavkaMenija rod = s.Load<RodStavkaMenija>(5);
                s.Delete(rod);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Ucitaj_NeuspelePokusaje_Load(object sender, EventArgs e)//Ne brisi ovo
        {

        }

        private void cmdDodajKorObuhvataGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorisnikIS k = s.Load<KorisnikIS>("NemanjaJ991");
                GrupaKorisnika gk = s.Load<GrupaKorisnika>("DataLink");

                k.Grupe.Add(gk);
                gk.Korisnici.Add(k);

                s.Save(k);
                s.Save(gk);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateKorObuhvataGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorisnikIS k = s.Load<KorisnikIS>("NemanjaJ991");
                GrupaKorisnika gk = s.Load<GrupaKorisnika>("DataLink");
                GrupaKorisnika gk2 = s.Load<GrupaKorisnika>("CrackWire");

                k.Grupe.Remove(gk);
                k.Grupe.Add(gk2);

                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IzbrisiKorObuhvataGrupu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorisnikIS k = s.Load<KorisnikIS>("NemanjaJ991");
                GrupaKorisnika gk = s.Load<GrupaKorisnika>("CrackWire");

                k.Grupe.Remove(gk);
                gk.Korisnici.Remove(k);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dodaj_KorPosedujeProfil_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorisnikIS k = s.Load<KorisnikIS>("MarkoN992");
                Profil p = s.Load<Profil>(17264);

                k.Profili.Add(p);
                p.KorisniciP.Add(k);

                s.Save(k);
                s.Save(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateKorPosedujeProfil_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>("MarkoN992");
                Profil p = s.Load<Profil>(17264);
                Profil p2 = s.Load<Profil>(16578);

                k.Profili.Remove(p);
                k.Profili.Add(p2);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Izbrisi_KorPosedujeProfil_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                KorisnikIS k = s.Load<KorisnikIS>("MilutinS998");
                Profil p = s.Load<Profil>(16732);

                k.Profili.Remove(p);
                p.KorisniciP.Remove(k);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUpdateKorIs_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                KorisnikIS k = s.Load<KorisnikIS>("AnaP990");

                s.Close();
                k.BrKancelarije = 11;
                ISession s1 = DataLayer.GetSession();

                s1.Update(k);
                s1.Flush();
                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _2._1vtys
{
    public partial class AnaEkran : Form 
    {
        
        SqlBaglanti bgl = new SqlBaglanti();
        int[] krediler = new int[20];
        string[] dersKodlari = new string[20];
        string[] seciliDersKodlari = new string[20];
       

        public AnaEkran()
        {
            InitializeComponent();

            

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dersler.Items.Clear();
            DersEkle();
            OgrenciBilgiYazdir();
            if (bgl.BasariliOgrenci(OgrenciNo.ogrenciNo) == 1)
            {
                checkBox1.Checked = true;
            }


        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
      
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void aktarbtn_Click(object sender, EventArgs e)
        {
            secilendersler.Items.Clear();
            for (int i = 0; i < dersler.CheckedItems.Count; i++)
            {
                secilendersler.Items.Add(dersler.CheckedItems[i]);
            }
            OgrenciKrediHesap();

            
            





            
        }

        private void dersler_ItemCheck(object sender, ItemCheckEventArgs e)
        {
        
        }

        private void onaybtn_Click(object sender, EventArgs e)
        {
            KayitEkle();
        }

        void DersEkle()
        {
            SqlCommand cmd = new SqlCommand("SELECT *FROM Ders WHERE bolumNo = '" + OgrenciNo.bolumNo + "'",bgl.Baglanti());
            SqlDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                

                dersler.Items.Add(rdr["dersKodu"].ToString() + rdr["dersIsmi"] + " Kredi: " + rdr["dersKredisi"]);

                    dersKodlari[i] = rdr["dersKodu"].ToString();
                    krediler[i] = Convert.ToInt32(rdr["dersKredisi"]);
                i++;
                



            }



        }

        void OgrenciBilgiYazdir()
        {
            SqlCommand cmd = new SqlCommand("SELECT *FROM Ogrenci where ogrenciNo ='"+OgrenciNo.ogrenciNo+"'", bgl.Baglanti());
         
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {

                lblIsim.Text = bgl.AdSoyadKısaltma(OgrenciNo.ogrenciNo);
                lblNo.Text = rdr["ogrenciNo"].ToString();
                lblToplamKredi.Text = rdr["kredi"].ToString();
                lblOgrenciSayi.Text = bgl.OgrenciSayi(OgrenciNo.bolumNo).ToString();
    

                
                
            }
        }

        void OgrenciKrediHesap()
        {
            int toplamDers;
            toplamDers = secilendersler.Items.Count;

            for (int i = 0; i < toplamDers; i++)
            {
                string ders;
                
               ders = secilendersler.Items[i].ToString();

               string[] words = ders.Split(' ');

                for (int s = 0; s < 1; s++)
                {
                    seciliDersKodlari[i] = words[s];
                }

                for (int j = 0; j < words.Count(); j++)
                {
                    
                    for (int z = 0; z < krediler.Length; z++)
                    {

                    
                    if (words[j] == krediler[z].ToString())
                    {// KREDİLER
                            string txt = lblToplamKredi.Text;
                            int topKredi; 
                            topKredi = Convert.ToInt32(txt);
                        topKredi -= Convert.ToInt32(words[j]);
                        lblToplamKredi.Text = topKredi.ToString();

                           
                    }

                        

                    }

               
                }
                 
            }
            
        }

        void KayitEkle()
        {
            for (int i = 0; i < seciliDersKodlari.Count(); i++)
            {
                if (seciliDersKodlari[i] != null)
                {
                    SqlCommand cmd = new SqlCommand("Insert INTO Kayit (ogrenciNo,dersKodu,kayitTarihi) VALUES('" + OgrenciNo.ogrenciNo + "','" + seciliDersKodlari[i] + "','" + DateTime.Now.ToString("d/M/yyyy") + "')", bgl.Baglanti());
                    cmd.ExecuteNonQuery();
                }
                
            }
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            label2.Text = bgl.AdSoyadKısaltma(OgrenciNo.ogrenciNo);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

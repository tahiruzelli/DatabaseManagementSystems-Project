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
   
    
    public partial class Form1 : Form

    {
        
        
        SqlBaglanti bgl = new SqlBaglanti();

        AnaEkran AE = new AnaEkran();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                Giris();
            

        }

         void Giris()
        {
            
            SqlCommand komut = new SqlCommand("SELECT * FROM Ogrenci WHERE ogrenciNo = '"+ Notxtbox.Text+"'", bgl.Baglanti());
            SqlCommand komut2 = new SqlCommand("SELECT bolumNo from Ogrenci Where ogrenciNo = '" + Notxtbox.Text + "'", bgl.Baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            SqlDataReader rdr = komut2.ExecuteReader();
            OgrenciNo.ogrenciNo = Notxtbox.Text;
            while (rdr.Read())
            { 
                OgrenciNo.bolumNo = rdr["bolumNo"].ToString();
            }

            if (reader.Read())
            {
                AE.Show();
            }
        }
    }
}
 
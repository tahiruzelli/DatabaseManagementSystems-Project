using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _2._1vtys
{
    public class SqlBaglanti
    {

        
           
      public SqlConnection Baglanti()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FN34SBF\ERENSERVER;Initial Catalog=Proje;Integrated Security=True");
            con.Open();
            return con;
        }

        
        
        
        public string AdSoyadKısaltma(string _ogrenciNo)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FN34SBF\ERENSERVER;Initial Catalog=Proje;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT isim FROM Ogrenci WHERE ogrenciNo = '" + _ogrenciNo + "'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
           
            string adSoyadKisaltma;
            SqlCommand kisaltma = new SqlCommand("SELECT dbo.DEGISTIR(@AD,@SOYAD)", con);
            SqlParameter parameter1 = new SqlParameter("@AD", System.Data.SqlDbType.VarChar);
            SqlParameter parameter2 = new SqlParameter("@SOYAD", System.Data.SqlDbType.VarChar);


            while (rdr.Read())
            {
              
                    parameter1.Value = rdr["isim"];
                

            }

            rdr.Close();

            cmd = new SqlCommand("SELECT soyisim FROM Ogrenci WHERE ogrenciNo = '" + _ogrenciNo + "'", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                parameter2.Value = rdr["soyisim"];
            }

            rdr.Close();

            kisaltma.Parameters.AddWithValue("@AD", parameter1.Value);
            kisaltma.Parameters.AddWithValue("@SOYAD", parameter2.Value);

            
            adSoyadKisaltma = kisaltma.ExecuteScalar().ToString();
                
                return adSoyadKisaltma;
                con.Close();
        }

        /*public int BolumOgrenciSayi(string _ogrenciNo)
        {
            
            SqlCommand cmd = new SqlCommand("SELECT bolumNo FROM Ogrenci WHERE ogrenciNo = '" + _ogrenciNo + "'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
        }*/

        public int BasariliOgrenci(string _ogrenciNo)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FN34SBF\ERENSERVER;Initial Catalog=Proje;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT notOrtalamasi FROM Ogrenci WHERE ogrenciNo = '" + _ogrenciNo + "'", con);
            SqlCommand BasariliMi = new SqlCommand("SELECT dbo.BASARILIMI(@NOTORTALAMASI)", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            int basari;
            SqlParameter parameter = new SqlParameter("@NOTORTALAMASI", System.Data.SqlDbType.Float);

            while (rdr.Read())
            {
                parameter.Value = rdr["notOrtalamasi"];
            }
            rdr.Close();
            BasariliMi.Parameters.AddWithValue("@NOTORTALAMASI", parameter.Value);

            basari = Convert.ToInt32(BasariliMi.ExecuteScalar());

            return basari;

        }

        public int OgrenciSayi(string _ogrenciNo)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FN34SBF\ERENSERVER;Initial Catalog=Proje;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT bolumNo FROM Ogrenci WHERE ogrenciNo = '" + _ogrenciNo + "'", con);
            SqlCommand OgrenciSayii = new SqlCommand("SELECT dbo.OGRENCISAYI(@GELENDEGER)", con); 
            int ogrenciSayi;
            SqlParameter parameter = new SqlParameter("@GELENDEGER", System.Data.SqlDbType.VarChar);
            
            parameter.Value = _ogrenciNo;

        
            OgrenciSayii.Parameters.AddWithValue("@GELENDEGER", parameter.Value);

            ogrenciSayi = Convert.ToInt32(OgrenciSayii.ExecuteScalar());

            return ogrenciSayi;

        }
    }

   
}

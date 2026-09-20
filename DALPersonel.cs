using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("Select * from TBLBILGI", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open) // eğer komut1 bağlantım açık değilse aç
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Sehir = dr["SEHRI"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);

            }
            dr.Close();
            return degerler; // ilk başta oluşturduğum nesneye bu değerleri döndür
        }

        public static int PersonelEkle(EntityPersonel p) // p ile PersonelEkle içindeki property lere ulaşabiliyorum
        {
          
         SqlCommand komut2 = new SqlCommand("insert into TBLBILGI (AD,SOYAD,GOREV,SEHRI,MAAS) VALUES(@P1,@P2,@P3,@P4,@P5)",Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open) 
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1",p.Ad);
            komut2.Parameters.AddWithValue("@P2",p.Soyad);
            komut2.Parameters.AddWithValue("@P3", p.Gorev);
            komut2.Parameters.AddWithValue("@P4",p.Sehir);
            komut2.Parameters.AddWithValue("@P5", p.Maas);
            return komut2.ExecuteNonQuery();

        }
        public static bool PersonelSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete from TBLBILGI where ID= @P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1",p); // textbox dan girilen id değeri
            return komut3.ExecuteNonQuery() > 0; // bool değer

        }
        public static bool PersonelGuncelle(EntityPersonel ent) // birden fazla parametre göndereceğim için ent nesnesi ürettim
        {
            SqlCommand komut4 = new SqlCommand("Update TBLBILGI SET AD=@P1, SOYAD=@P2,MAAS=@P3, SEHRI=@P4, GOREV=@P5 WHERE ID=@P6 ", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.Ad);
            komut4.Parameters.AddWithValue("@P2", ent.Soyad);
            komut4.Parameters.AddWithValue("@P3", ent.Maas);
            komut4.Parameters.AddWithValue("@P4", ent.Sehir);
            komut4.Parameters.AddWithValue("@P5", ent.Gorev);
            komut4.Parameters.AddWithValue("@P6", ent.Id);
            return komut4.ExecuteNonQuery() > 0;
        }

    }
}

namespace OOP2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Furkan Yazar
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.TcNo = "12345678910";
            musteri1.Adi = "Furkan";
            musteri1.Soyadi = "Yazar";

            //furkanyazar.com
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "furkanyazar.com";
            musteri2.VergiNo = "0987654321";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
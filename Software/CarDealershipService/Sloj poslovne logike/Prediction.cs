using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike
{
    public class Prediction
    {
        private static int MINIMALNA_KOLICINA = 1;
        private static int MINIMALNA_DONJA_GRANICA_U_DANIMA = 2;
        public static string PredvidiVrijemeNarudzbe(Sloj_pristupa_podacima.Artikli_na_skladistu ans)
        {
            Sloj_pristupa_podacima.Artikl artikl = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiArtikl(ans.artikl);
            MINIMALNA_KOLICINA = artikl.minimalna_kolicina;
            MINIMALNA_DONJA_GRANICA_U_DANIMA = artikl.vrijeme_dostave;
            if (MINIMALNA_KOLICINA >= ans.kolicina)
            {
                return DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");                
            }
            else
            {
                int prosjecnoVrijemeNarudzbe = ProsjecnoVrijemePoNarudzbi(ans);
                int prosjecnaKolicinaNarudzbe = AverageKolicineNarudzbe(ans);
                DateTime vrijemeNarudzbe = PredvidiDanNarudzbe(ans, prosjecnoVrijemeNarudzbe, prosjecnaKolicinaNarudzbe);
                if (vrijemeNarudzbe.AddDays(-MINIMALNA_DONJA_GRANICA_U_DANIMA) <= DateTime.Now)
                {
                    return DateTime.Now.ToString();
                }
                else
                    return vrijemeNarudzbe.AddDays(-MINIMALNA_DONJA_GRANICA_U_DANIMA).ToString("dd.MM.yyyy HH:mm:ss");
            }
        }
        private static int AverageKolicineNarudzbe(Sloj_pristupa_podacima.Artikli_na_skladistu ans)
        {
            Sloj_pristupa_podacima.Artikl artikl = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiArtikl(ans.artikl);
            int kolicina = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.BrojProdanihArtikala(artikl);
            int brojRacuna = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.BrojRacunaProdanogArtikala(artikl);
            if (kolicina>0&&brojRacuna>0)
            {
                return (int)kolicina / (int)brojRacuna;
            }
            return 1;
        }
        private static int ProsjecnoVrijemePoNarudzbi(Sloj_pristupa_podacima.Artikli_na_skladistu ans)
        {
            Sloj_pristupa_podacima.Artikl artikl = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiArtikl(ans.artikl);

            int ukupnoDanaProdaje = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.BrojRacunaProdanogArtikala(artikl);
            int sumaIntervalaNarudzbe = 0;
            if (ukupnoDanaProdaje>0)
            {
                List<Sloj_pristupa_podacima.Stavke_dokumenta> stavke = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiStavkeDokumentaOdabranogArtikla(artikl);
                for (int i = stavke.Count - 1; i > 0; i--)
                {
                    Sloj_pristupa_podacima.Dokument d1 = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiDokument(stavke[i].dokument);
                    Sloj_pristupa_podacima.Dokument d2 = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiDokument(stavke[i - 1].dokument);
                    int brojDana = d1.datum_izdavanja.Subtract(d2.datum_izdavanja).Days;
                    sumaIntervalaNarudzbe += brojDana;
                }
                int kolicnik= sumaIntervalaNarudzbe /= ukupnoDanaProdaje;
                if (kolicnik>0)
                {
                    return kolicnik;
                }
                else
                {
                    return 1;
                }
                
            }
            return 10;
            
        }
        private static DateTime PredvidiDanNarudzbe(Sloj_pristupa_podacima.Artikli_na_skladistu ans, int sljedecaNarudzba, int kolicinaNarudzbe)
        {
            Sloj_pristupa_podacima.Artikl artikl = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiArtikl(ans.artikl);
            List<Sloj_pristupa_podacima.Stavke_dokumenta> stavke = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiStavkeDokumentaOdabranogArtikla(artikl);
            if (stavke.Count > 0)
            {
                Sloj_pristupa_podacima.Dokument d3 = Sloj_pristupa_podacima.UpravljanjeSkladistem.UpravljanjeSkladistemDAL.DohvatiDokument(stavke.Last().dokument);
                DateTime vrijemeZadnjeNarudzbe = d3.datum_izdavanja;
                int trenutnaKolicina = ans.kolicina;
                while (true)
                {
                    if (trenutnaKolicina - kolicinaNarudzbe >= MINIMALNA_KOLICINA)
                    {
                        trenutnaKolicina -= kolicinaNarudzbe;
                        vrijemeZadnjeNarudzbe = vrijemeZadnjeNarudzbe.AddDays(sljedecaNarudzba);
                    }
                    else
                    {
                        break;
                    }
                }
                return vrijemeZadnjeNarudzbe;
            }
            else
                return DateTime.Now.AddDays(30);

            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_poslovne_logike.UpravljanjeDnevnikom
{
    public enum RadnjaDnevnika
    {
        PRIJAVA_U_SUSTAV = 1,
        ODJAVA_IZ_SUSTAVA = 2,
        KREIRANA_POSLOVNICA = 3,
        KREIRAN_KORISNIK = 4,
        KREIRANA_REZERVACIJA = 5,
        KREIRANO_SKLADISTE = 1002,
        KREIRANA_NARUDZBA = 1003,
        KREIRANJE_VOZILA = 1004,
        KREIRANJE_REZERVNOG_DIJELA = 1005,
        BRISANJE_ARTIKLA = 1006,
        BRISANJE_REZERVACIJE = 1007,
        BRISANJE_NARUDZBE = 1008,
        BRISANJE_KORISNIKA = 1009,
        BRISANJE_POSLOVNICE = 1010,
        PRODAN_ARTIKL = 1011,
        AZURIRAJ_KORISNIKA = 1012,
        AZURIRAJ_NARUDZBU = 1013,
        AZURIRAJ_POSLOVNICU = 1014,
        AZURIRAJ_REZERVACIJU = 1015,
        AZURIRAJ_ARTIKL = 1016
    }
}

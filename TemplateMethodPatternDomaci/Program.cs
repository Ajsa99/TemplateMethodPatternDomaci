using System;

namespace TemplateMethodPatternDomaci
{
    abstract class ZahtjevZaLicnuKartu
    {
        public void PosaljiZahtjev()
        {
            KorisnikSaljeZahtev();
            ProveraInformacija();
            OdobrenjeOdStraneSluzbenika();
        }

        protected abstract void KorisnikSaljeZahtev();
        protected abstract void ProveraInformacija();
        protected abstract void OdobrenjeOdStraneSluzbenika();

    }

    class ZakazivanjeTermina : ZahtjevZaLicnuKartu
    {
        protected override void KorisnikSaljeZahtev()
        {
            Console.WriteLine("Korisnik salje zahtev za termin za licnu kartu.");
        }
        protected override void ProveraInformacija()
        {
            Console.WriteLine("Proveravaju se informacije o Korisniku.");
        }
        protected override void OdobrenjeOdStraneSluzbenika()
        {
            Console.WriteLine("Sluzbenik odobrava zahtev i zakazuje termin.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ZahtjevZaLicnuKartu zahtjev = new ZakazivanjeTermina();
            zahtjev.PosaljiZahtjev();
        }
    }
}

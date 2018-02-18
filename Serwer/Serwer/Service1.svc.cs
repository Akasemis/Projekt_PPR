using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
namespace Serwer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        Model1 Baza = new Model1();
        Zwierzaki Zwierze = new Zwierzaki();

        public int ile_wierszy()
        {
            int ile = Baza.Zwierzaki.Count();
            return ile;
        }
        public int wczytaj_id(int var)
        {
            Zwierze = Baza.Zwierzaki.Find(var);
            return Zwierze.id;
        }
        public string zwroc_imie(int var)
        {
            Zwierze = Baza.Zwierzaki.Find(var);
            return Zwierze.imie;
        }

        public string zwroc_rase(int var)
        {
            Zwierze = Baza.Zwierzaki.Find(var);
            return Zwierze.rasa;
        }
        public int? zwroc_wiek(int var)
        {
            Zwierze = Baza.Zwierzaki.Find(var);
            return Zwierze.wiek;
        }

        public string zwroc_kontakt(int var)
        {
            Zwierze = Baza.Zwierzaki.Find(var);
            return Zwierze.kontakt;
        }
        public string zwroc_zdj(int var)
        {
            Zwierze = Baza.Zwierzaki.Find(var);
            return Zwierze.zdj;
        }
        public int dodaj_zwierzaka(int id, string imie, string rasa, int? wiek, string kontakt, string zdj)
        {
            Zwierze.nowy_zwierzak(id, imie, rasa, wiek, kontakt, zdj);
            Baza.Zwierzaki.Add(Zwierze);
            Baza.SaveChanges();
            return 0;
        }



        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}

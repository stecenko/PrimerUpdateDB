using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerUpdate.Model
{
    public class PrimerRepository: INotifyPropertyChanged
    {
        PrimerEntities primerEntities = new PrimerEntities();

        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable<ViewTovar> GetViewTovars()
        {
            return primerEntities.ViewTovars.ToList();
        }


        public IEnumerable<ViewTovarType> GetViewTovarTypes()
        {
            return primerEntities.ViewTovarTypes.ToList();
        }

        public IEnumerable<Tovar> GetTovars()
        {
            return primerEntities.Tovars.ToList();
        }



        public void InsertTovar(string nameTovar)
        {
            // вставляем товар
            var tovar = primerEntities.Tovars.Add(new Tovar() { NameTorar = nameTovar, TypeTovar = 2 }); //для удобства TypeTovar - будет "продукты"
            primerEntities.SaveChanges();

            //int id = tovar.IdTovar; // получаем ID только после сохранения данных SaveChanges
            //var price = primerEntities.Prices.Add(new Price() { idTovar = id, PriceTovar = 100 });
            primerEntities.SaveChanges();
        }

        public void UpdateTovar(int idTovar, string nameTovar)
        {
            var tovar = primerEntities.Tovars.Where(a => a.IdTovar == idTovar).FirstOrDefault();
            tovar.NameTorar = nameTovar;

            primerEntities.Entry(tovar).State = System.Data.Entity.EntityState.Modified;
            primerEntities.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Generic interface'i ile her entity için ayrı bir interface tanımlamak ve bunların içini doldurmak yerine 
    //diğer her interface generic sınıfından miras alacak ve böylece kod tekrarının önüne geçilmiş olacak
    //T bir entity, T class a ait özellikleri üzerine alabilmeli ve bir class olmalı
    public interface IGenericDal<T> where T : class
    {
        //Ekleme İşlemi
        void Insert(T t);
        //Silme İşlemi
        void Delete(T t);
        //Güncelleme İşlemi
        void Update(T t);
        //Verilerin tümünün getirilmesi
        List<T> GetList();
        //ID ye göre değer getirmesi için
        T GetByID(int id);
    }
}

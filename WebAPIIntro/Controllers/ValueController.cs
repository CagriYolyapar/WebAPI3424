using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIIntro.Controllers
{

    //API Metot Yöntemleri

    /*
       --Get: Size bir sayfayı ilk kez getiren yöntemdir.
       --Post:Size gelmiş olan bir sayfayı tekrar server'a yollayarak yaptıgınız bir istektir. API'da sadece ekleme işlemleri icin kullanılması tavsiye edilir. Siz teknik olarak Post ile bir update işlemi yapabiliyor olsanız da  (arka tarafta güncelleme kodunu yazarsanız calısır) API dinamingine göre arka taraftaki trafikte karmasıklık yaratma ihtimali yüksek oldugundan ek olarak maintenance uygulamanız gerekir.
       --Put: API'da güncelleme işlemleri icin ayrılmıs bir yöntemdir.
       --Delete:API'da silme işlemleri icin kullanılır.

        Eger siz API'da bir custom route(kendinize özel bir rota) yaratmazsanız varsayılan sablon su sekildedir. => localhost:1234/ api/<controller ismi>/id(opsiyonel)

        MVC kısmında bir metodun üstüne bir yöntem icin attribute yazmazsanız varsayılan sablon sizi Get yönteminde ilgili action'a gönderir. Ancak API'da bir metodun yöntemini belirlemek zorundasınız...

        API'da bir Action'ın yöntemini belirlemek iki şekilde de olabilir : 
        1) Action isminin basına yontemin ismini yazarsınız(GetCategories())
        2)İlgili Action'un üzerine attribute olarak HTTPGet,HTTPPost gibi tipleri koymalısınız...

        Conventional Based HTTP isteklerinde API metodun yöntemine bakar...
        Conventional Based istek demek API'in size sundugu default rota template'i üzerinden gitmek demektir.



     */
    public class ValueController : ApiController
    {
       static List<string> cities = new List<string>
       {
           "Istanbul","İzmir","Ankara","Antalya"
       };

        public List<string> GetCities()
        {
            return cities;
        }

        //public List<string> GetDeneme()
        //{
        //    return new List<string>
        //    {
        //        "Deneme1","Deneme2"
        //    };
        //}

        public string GetCity(int id)
        {
            return cities[id];
        }

        public List<string> PostCity(string item)
        {
            cities.Add(item);
            return cities;
        }

    }
}

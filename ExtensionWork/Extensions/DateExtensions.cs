using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionWork.Extensions
{

    //Extension classı static olmalı. 
    public static class DateExtensions
    {
        

        public static string Ago(this DateTime dateTime)
        {

            //burda sistemin güncel saatini aldık ve now değerinin içine attık.
            var now = DateTime.Now;

            //burda gönderilen zaman ile güncel zaman arasındaki farkı aldım 

            TimeSpan timeSpan = now - dateTime;

            // 2 gün 3 saat 4 dakika önce formatında yazmalı 

            var str = timeSpan.Days+ " gün " + timeSpan.Hours + " saat " + timeSpan.Minutes+ " dakika önce" ;
            return str;
        }


    }
}

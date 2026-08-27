using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TopicosEspeciais2.Extensions
{
    static class DateTimeExtensions
    {

        //Classi para estender o metodo do DateTime, o que possibilita a chamada do metodo/função no propio objeto declarado na main
        public static string ElapsedTime(this DateTime thisObj) 
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Hours";
            }
            else 
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
            }
        }

    }
}

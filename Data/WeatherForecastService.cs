using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_SQlite_Authentication.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        SQliteContext _sqLiteContext;
        public WeatherForecastService(SQliteContext sqLiteContext)
        {
            _sqLiteContext = sqLiteContext;
            //MyStr ms = new MyStr();
            //List<MyStr> ms_list = new List<MyStr>();
            //ms_list.Add(new MyStr { name = "A1" });
            //ms_list.Add(new MyStr { name = "A2" });
            //ms_list.Add(new MyStr { name = "A3" });

            //try
            //{
            //    _sqLiteContext.strs.AddRange(ms_list);
            //    _sqLiteContext.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}
        }

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            //MyStr str = _sqLiteContext.strs.First<MyStr>();
            //try
            //{
            //    List<MyStr> str2 = _sqLiteContext.strs.ToList<MyStr>();
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}

            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}

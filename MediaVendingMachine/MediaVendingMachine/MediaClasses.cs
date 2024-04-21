using System;
using System.Collections.Generic;

namespace MediaVendingMachine
{
    public class Media
    {
        public double Rating { get; set; } // Рейтинг

        public virtual string GetInfo()
        {
            return $"Рейтинг: {Rating}";
        }
    }

    public class Movie : Media
    {
        public int Duration { get; set; } // Хронометраж в минутах
        public int AwardsCount { get; set; } // Количество наград

        public override string GetInfo()
        {
            return $"Фильм,{base.GetInfo()}, Хронометраж: {Duration} мин., Наград: {AwardsCount}";
        }
    }

    public class Series : Media
    {
        public int TotalEpisodes { get; set; } // Общее количество серий
        public int SeasonsCount { get; set; } // Количество сезонов

        public override string GetInfo()
        {
            return $"Сериал,{base.GetInfo()}, Серий: {TotalEpisodes}, Сезонов: {SeasonsCount}";
        }
    }

    public class TVShow : Media
    {
        public int Duration { get; set; } // Продолжительность в минутах
        public string AirTime { get; set; } // Время эфира

        public override string GetInfo()
        {
            return $"Телепередача, {base.GetInfo()}, Продолжительность: {Duration} мин., В эфире в: {AirTime}";
        }
    }
}

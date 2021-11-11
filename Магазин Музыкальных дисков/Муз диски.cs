using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public interface IStoraltem
    {
        public double Price { get; set; }
        public double DiscountPrice(int CENT)
        {
            return Price * CENT;
        }
    }

    public class Disk : IStoraltem
    {
        protected string name, genre;
        protected int burnCount;
        public Disk(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
        }
        public virtual int DiskSize { get; set; }
        public double DiscountPrice { get; }
        public double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual void Burn(params string[] values)
        {
            
        }

    }
    public class Audio : Disk
    {
        protected string artist, recordingStudio;
        protected int SongsNumber;
        public Audio(string artist, string recordingStudio, int SongsNumber, string name, string genre) : base(name, genre)
        {
            this.artist = artist;
            this.recordingStudio = recordingStudio;
            this.SongsNumber = SongsNumber;
            this.name = name;
            this.genre = genre;
        }
        public override int DiskSize { get => SongsNumber * 8; }
        public override void Burn(params string[] values)
        {
            artist = values[0];
            recordingStudio = values[1];
            SongsNumber = int.Parse(values[2]);
            name = values[3];
            genre = values[4];
            burnCount++;
        }
        public override string ToString()
        {
            return $"Название: {name}, Жанр: {genre}, Исполнитель: {artist}, Студия звукозаписи :{recordingStudio}, Количество песен: {songsNumber}, Количество прожигоа: {burnCount}";
        }
    }
    public class DVD : Disk
    {
        protected string producer, filmCompany;
        protected int minutesCount;
        public DVD (string producer, string filmCompany, int minutesCount, string name, string genre) : base(name, genre)
        {
            this.producer = producer;
            this.filmCompany = filmCompany;
            this.name = name;
            this.genre = genre;
            this.minutesCount = minutesCount;
        }
        public override int DiskSize { get => ((minutesCount) / 64 * 2); }
        public override void Burn(params string[] values)
        {
            producer = values[0];
            filmCompany = values[1];
            minutesCount = int.Parse(values[2]);
            name = values[3];
            genre = values[4];
            burnCount++;
        }
        public override string ToString()
        {
            return $"Название: {name}, Жанр: {genre}, Режисёр: {producer}, Кинокомпания: {filmCompany}, Количество минут: {minutesCount}, Количество прожигов: {burnCount}";
        }
    }
    public class Store
    {
        protected string StoreName;
        protected string Addres;
        protected List<Audio> audios;
        protected List<DVD> dvds;
        public Store(string StoreName, string Addres)
        {
            this.StoreName = StoreName;
            this.Addres = Addres;
        }
        public static Store operator +(Store all, DVD plusic)
        {
            all.dvds.Add(plusic);
            return all;
        }
        public static Store operator -(Store all, DVD minusic)
        {
            all.dvds.Remove(minusic);
            return all;
        }

        public static Store operator +(Store all, Audio plusic)
        {
            all.audios.Add(plusic);
            return all;
        }
        public static Store operator -(Store all, Audio minusic)
        {
            all.audios.Remove(minusic);
            return all;
        }
        public override string ToString()
        {
            string audio = "АУДИСПИСКИ: ";
            string dvdis = "ФИЛЬМЫ: ";
            for(int i = 0; i < audios.Count; i++)
            {
                audio += $"{audios[i]}";
            }
            for(int i = 0; i < dvds.Count; i++)
            {
                dvdis += $"{dvds[i]}";
            }
            return audio + dvdis;
        }
    }

    class Program
    {
       public static void Main(string[] args)
        {
            Store store = new("Название", "Адрес");
            List<Audio> audios = new();
            Audio one = new("Cumry", "NEXT", 15, "MASTER", "GachiREMIX");
            Audio two = new("DeadBlonde", "Boychic", 7, "Na 9", "Fagg");
            Audio three = new("NLC", "aboba", 9, "Slave", "help");
            store += first;
            store += second;
            store += third;
            DVD four = new("grey", "yellow", 5, "black", "frame");
            DVD five = new("Boy", "Full", 10, "red", "car");
            DVD six = new("ABIBA", "MC", 13, "scaven", "Slave");
            store.ToString();
            third.Burn("print", "yet", "8", "please", "group");
        }
    }
}

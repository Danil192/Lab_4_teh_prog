using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaVendingMachine
{
    public partial class Form1 : Form
    {
        private List<Media> mediaQueue = new List<Media>();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            UpdateQueueDisplay();
        }
        private void UpdateMediaCounts() //метод для посчета медиа
        {
            int movieCount = 0;
            int seriesCount = 0;
            int tvShowCount = 0;

            foreach (Media media in mediaQueue)
            {
                if (media is Movie)
                    movieCount++;
                else if (media is Series)
                    seriesCount++;
                else if (media is TVShow)
                    tvShowCount++;
            }

            lbFilm.Text = movieCount.ToString();
            lbSerial.Text = seriesCount.ToString();
            lbTV.Text = tvShowCount.ToString();
        }

        private void LoadRandomMedia(int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (random.Next(3)) // Генерируем один из трёх типов медиа
                {
                    case 0:
                        mediaQueue.Add(new Movie
                        {
                            Rating = random.NextDouble() * 10,
                            Duration = random.Next(90, 180),
                            AwardsCount = random.Next(0, 10)
                        });
                        break;
                    case 1:
                        mediaQueue.Add(new Series
                        {
                            Rating = random.NextDouble() * 10,
                            TotalEpisodes = random.Next(10, 100),
                            SeasonsCount = random.Next(1, 10)
                        });
                        break;
                    case 2:
                        mediaQueue.Add(new TVShow
                        {
                            Rating = random.NextDouble() * 10,
                            Duration = random.Next(30, 90),
                            AirTime = $"{random.Next(1, 12)}:{random.Next(0, 59):D2} {(random.Next(2) == 0 ? "AM" : "PM")}"
                        });
                        break;
                }
            }
        }

        private void UpdateQueueDisplay()
        {
            txtQueue.Clear();
            foreach (Media media in mediaQueue)
            {
                txtQueue.AppendText(media.GetInfo() + "\n\n");
            }
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            LoadRandomMedia(10); // Загрузить 10 случайных медиа
            UpdateQueueDisplay();
            UpdateMediaCounts(); //добавил
        }

        private void btnGetMedia_Click_1(object sender, EventArgs e)
        {
            if (mediaQueue.Count > 0)
            {
                Media media = mediaQueue[0];
                mediaQueue.RemoveAt(0);
                txtInfo.Text = media.GetInfo();
                UpdateQueueDisplay();
                UpdateMediaCounts(); //добавил
            }
            else
            {
                txtInfo.Text = "Автомат пуст";
            }
        }
    }
}

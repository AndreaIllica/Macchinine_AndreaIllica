using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macchinine_AndreaIllica
{
    public sealed class CarManager
    {
        //I love Java :)
        public static CarManager Manager { get; } = new CarManager();

        private HashSet<Car> _cars;

        public int Giri { get; private set; }
        public bool RaceStarted { get; private set; }

        private CarManager()
        {
            _cars = new HashSet<Car>();
            Giri = 0;
        }

        public void AddCar(string name, BackgroundWorker backgroundWorker, PictureBox carPicture, Image carImage, Label giriLabel, int speed, bool visible)
        {
            Car car = new Car(name, backgroundWorker, carPicture, carImage, giriLabel, speed);
            car.SetVisible(visible);
            _cars.Add(car); 
        }

        public void StartRace(int giri)
        {
            if (RaceStarted) return;
            if (giri <= 0) return;
            Giri = giri;

            foreach (var car in _cars)
            {
                car.Reset();
                RaceStarted = true;
                car.Start();
            }
        }

        public void StopRace()
        {
            foreach (var car in _cars)
                car.Stop();
            RaceStarted = false;
        }

        public void ResetRace()
        {
            foreach (var car in _cars)
                car.Reset();
            RaceStarted = false;
        }

        public void SetVisible(string carName, bool visible)
        {
            foreach (var car in _cars)
                if (car.Name == carName)
                    car.SetVisible(visible);
        }
    }
}

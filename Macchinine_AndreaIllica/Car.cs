using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Macchinine_AndreaIllica.Properties;
using System.Drawing;
using System.ComponentModel;

namespace Macchinine_AndreaIllica
{
    public sealed class Car
    {
        private static PictureBox _strada = null;
        public static PictureBox Strada
        {
            get { return _strada; }
            set
            {
                if (_strada == null)
                    _strada = value;
            }
        }

        private BackgroundWorker _backgroundWorker;
        private PictureBox _carPicture;
        private Label _giriLabel;
        private Point _startPositions;
        private int _endPosition;

        public int Speed { get; }
        public string Name { get; }

        public Car(string name, BackgroundWorker backgroundWorker, PictureBox carPicture, Image carImage, Label giriLabel, int speed)
        {
            Name = name;
            _backgroundWorker = backgroundWorker;
            _carPicture = carPicture;

            _carPicture.Visible = false;
            _carPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            _carPicture.Image = carImage;

            Point carStartPosition = carPicture.Location;
            _startPositions = new Point(carStartPosition.X,carStartPosition.Y);

            _giriLabel = giriLabel;
            Speed = speed;

            //Mi è morto il cuore a far sta roba
            if (Strada == null) throw new ArgumentNullException("La strada e' nulla!");
            _endPosition = Strada.Width;
        }

        private bool AddGiro()
        {
            int giri = int.Parse(_giriLabel.Text.Split(' ')[1]);
            _giriLabel.Text = "Giri: " + (++giri);
            return giri >= CarManager.Manager.Giri;
        }

        private bool SetGiri(int giri)
        {
            _giriLabel.Text = "Giri: " + giri;
            return giri >= CarManager.Manager.Giri;
        }

        public void SetVisible(bool visible)
        {
            _carPicture.Visible = visible;
        }

        public void Start()
        {
            if (_backgroundWorker.IsBusy) return;

            SetGiri(0);
            _backgroundWorker.RunWorkerAsync(this);
        }

        public void Stop()
        {
            if (!_backgroundWorker.IsBusy) return;
            _backgroundWorker.CancelAsync();
        }

        public void Reset()
        {
            _carPicture.Location = _startPositions;
            SetGiri(0);
        }

        /*
         *  Returns false if the car is in the street size.
         *  Returns true if the car is out of the street size.
         */
        public bool Move(int quantity)
        {
            if (!_carPicture.Visible) return false;

            Point currentCarPosition = _carPicture.Location;
            int deltaX = currentCarPosition.X + quantity;
            currentCarPosition.X = deltaX;
            _carPicture.Location = currentCarPosition;

            if (deltaX < 0 || deltaX >= _endPosition)
            {
                _carPicture.Location = _startPositions;
                return AddGiro();
            }

            return false;
        }
    }
}

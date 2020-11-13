using Macchinine_AndreaIllica.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macchinine_AndreaIllica
{
    public partial class Form1 : Form
    {
        private static Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            picStrada.Controls.Add(picMacchina1);
            picStrada.Controls.Add(picMacchina2);
            picStrada.Controls.Add(picTrenino);

            picStrada.Controls.Add(lblGiri1);
            picStrada.Controls.Add(lblGiri2);
            picStrada.Controls.Add(lblGiri3);

            Car.Strada = picStrada;
            InitCars();
        }

        private void InitCars()
        {
            CarManager.Manager.AddCar("Macchina rossa",carMoveWorker1, picMacchina1, Resources.MacchinaRossa, lblGiri1, 40, true);
            CarManager.Manager.AddCar("Macchina blu", carMoveWorker2, picMacchina2, Resources.MacchinaBlu, lblGiri2, 40, true);
            CarManager.Manager.AddCar("Trenino Thomas", carMoveWorker3, picTrenino, Resources.trenino, lblGiri3, 200, false);
        }

        private void carMoveDefault_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!(sender is BackgroundWorker)) return;
            var backgroundWorker = sender as BackgroundWorker;

            if (!(e.Argument is Car)) return;
            Car car = e.Argument as Car;

            while (!backgroundWorker.CancellationPending)
            {
                int deltaX = random.Next(car.Speed);
                backgroundWorker.ReportProgress(deltaX, car);

                Thread.Sleep(50);
            }
        }

        private void carMoveDefault_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!(sender is BackgroundWorker)) return;
            var backgroundWorker = sender as BackgroundWorker;

            if (!(e.UserState is Car)) return;
            Car car = e.UserState as Car;

            if (car.Move(e.ProgressPercentage))
            {
                CarManager.Manager.StopRace();
                MessageBox.Show(car.Name + " ha vinto!");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int giri;

            bool ok = int.TryParse(txtGiri.Text, out giri) && giri > 0;
            if (!ok) MessageBox.Show("I giri devono essere un numero intero positivo!");

            CarManager.Manager.StartRace(giri);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            CarManager.Manager.StopRace();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CarManager.Manager.StopRace();
            CarManager.Manager.ResetRace();
        }

        private void cbTrenino_CheckedChanged(object sender, EventArgs e)
        {
            bool check = cbTrenino.Checked;
            if (CarManager.Manager.RaceStarted) cbTrenino.Checked = !check;
            CarManager.Manager.SetVisible("Trenino Thomas", check);
        }
    }
}

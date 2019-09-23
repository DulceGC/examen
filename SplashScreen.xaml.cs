using System;
using System.Windows;
using System.Windows.Threading;
using MahApps.Metro.Controls;

namespace PrimerParcial
{
    /// <summary>
    /// Lógica de interacción para SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : MetroWindow
    {
        DispatcherTimer dt = new DispatcherTimer();

        public SplashScreen()
        {
            InitializeComponent();
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 2);
            dt.Start();
        }

        private void dt_Tick(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();

            dt.Stop();
            this.Close();
        }
    }
}

using System;

using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TwoFileSurroundPlayer
{
    static class CMain
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
            var client = GetWaveClient();
            //client.Initialize();
            
        } 

        public static NAudio.CoreAudioApi.AudioClient GetWaveClient()
        {
            Wave wave = new Wave();
            return wave.Client;
        }
    }
    

}

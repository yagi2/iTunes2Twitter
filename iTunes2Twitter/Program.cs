using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using iTunesLib;
using iTunes2Twitter;

namespace iTunes2TwitterProgram
{
    public class Program
    {
        iTunesAppClass iTunesApp;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            // 起動時に今流れてる音楽を取得しておく
            // iTunes2Twitter.MainForm_Load()で同じことを記述していたので一応コメントアウト
            /*
            string MusicText = "";
            MusicText = GetCurrentMusic();
            */
        }

        // 現在流れている音楽情報の取得
        public static string GetCurrentMusic()
        {
            string MusicText = "";

            iTunesApp iTA = new iTunesLib.iTunesApp();
            IITTrack track = iTA.CurrentTrack;

            if (track != null && track.Enabled)
            {
                MusicText = string.Format("[きいてるなう！] - {0} - {1} by {2} #nowplaying", track.Name, track.Album, track.Artist);
            }

            Marshal.ReleaseComObject(iTA);

            //SetArtWork(track);

            return MusicText;
        }

        /*
        // アートワークの取得
        public void SetArtWork(IITTrack track)
        {
            var awc = from IITArtwork aw in track.Artwork
                      select aw;

            foreach (var aw in awc)
            {
                var tmpFileName = @"c:\iTunesPhoto\tmp.jpg";
                aw.SaveArtworkToFile(tmpFileName);
                using (var fs = new FileStream(tmpFileName, FileMode.Open, FileAccess.Read))
                {
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pictureBox1.Image = Image.FromStream(fs);
                    fs.Close();
                }
                break;
            }
        }
        */
    }
}

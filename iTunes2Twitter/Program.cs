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
    }
}

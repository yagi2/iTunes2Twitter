using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTunesLib;
using System.Runtime.InteropServices;

using iTunes2TwitterProgram;

namespace iTunes2Twitter
{
    public partial class MainForm : Form
    {
        iTunesAppClass iTunesApp; 

        public MainForm()
        {
            InitializeComponent();
        }

        // 起動してメインフォームが表示された時に実行
        private void MainForm_Load(object sender, EventArgs e)
        {
            iTunesApp iTA = new iTunesApp();
            IITTrack track = iTA.CurrentTrack;

            iTunesApp = new iTunesAppClass();
            iTunesApp.OnPlayerPlayEvent += new _IiTunesEvents_OnPlayerPlayEventEventHandler(iTunesApp_OnPlayerPlayEvent);

            string str = GetCurrentMusic();

            changeText(TweetTextBox, new changeTextBoxDlegate(changeTextBox), str);
        }


        // ツイートテキストのテキストボックスの中身変更
        private delegate void changeTextBoxDlegate(string str);
        private void changeText(TextBox tb, changeTextBoxDlegate ctb, string str)
        {
            tb.Invoke(ctb, str);
        }
        private void changeTextBox(string str)
        {
            int SlectionStart = TweetTextBox.SelectionStart;
            TweetTextBox.Text = str;
            TweetTextBox.Select(SlectionStart, 0);
        }

        // ラベルの書き換え
        private delegate void changeLabelDelegate(string str);
        private void changelabelText(Label lb, changeLabelDelegate clb, string str)
        {
            lb.Invoke(clb, str);
        }

        private void iTunesApp_OnPlayerPlayEvent(object iTrack)
        {
            string str = "";

            str = GetCurrentMusic();

            changeText(TweetTextBox, new changeTextBoxDlegate(changeTextBox), str);
        }

        // 楽曲情報の取得
        public string GetCurrentMusic()
        {
            string MusicText = "";

            iTunesApp iTA = new iTunesLib.iTunesApp();
            IITTrack track = iTA.CurrentTrack;

            if (track != null && track.Enabled)
            {
                MusicText = string.Format("[きいてるなう！] - {0} - {1} by {2} #nowplaying", track.Name, track.Album, track.Artist);
            }

            Marshal.ReleaseComObject(iTA);

            SetArtWork(track);

            return MusicText;
        }

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
                    this.ArtWorkPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.ArtWorkPictureBox.Image = Image.FromStream(fs);
                    fs.Close();
                }
                break;
            }
        }

        // 再生/停止ボタンクリックイベント
        private void StartStopButton_Click(object sender, EventArgs e)
        {
            iTunesApp itunes = new iTunesLib.iTunesApp();
            IITTrack track = itunes.CurrentTrack;

            itunes.PlayPause();

            string str = "";
            str = GetCurrentMusic();

            changeText(TweetTextBox, new changeTextBoxDlegate(changeTextBox), str);

            Marshal.ReleaseComObject(itunes);
        }

        // 次の曲へボタンクリックイベント
        private void NextSongButton_Click(object sender, EventArgs e)
        {
            iTunesApp itunes = new iTunesLib.iTunesApp();
            IITTrack track = itunes.CurrentTrack;

            itunes.NextTrack();

            string str = "";
            str = GetCurrentMusic();

            changeText(TweetTextBox, new changeTextBoxDlegate(changeTextBox), str);

            Marshal.ReleaseComObject(itunes);
        }

        // 前の曲へボタンクリックイベント
        private void PreviousSongButton_Click(object sender, EventArgs e)
        {
            iTunesApp itunes = new iTunesLib.iTunesApp();
            IITTrack track = itunes.CurrentTrack;

            itunes.BackTrack();

            string str = "";
            str = GetCurrentMusic();

            changeText(TweetTextBox, new changeTextBoxDlegate(changeTextBox), str);

            Marshal.ReleaseComObject(itunes);
        }

        // ツイートするボタンクリックイベント
        private void TweetButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ついーときのうはまだ未実装なの！");
        }

    }
}

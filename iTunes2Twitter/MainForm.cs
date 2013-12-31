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

            string str = Program.GetCurrentMusic();

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

            str = Program.GetCurrentMusic();

            changeText(TweetTextBox, new changeTextBoxDlegate(changeTextBox), str);
        }
    }
}

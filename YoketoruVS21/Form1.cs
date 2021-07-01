using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoketoruVS21
{
    public partial class Form1 : Form
    {
        enum State
        {
            None=-1,    //無効
            Title,      //タイトル
            Game,       //ゲーム画面
            Gameover,   //ゲームオーバー
            Clear,      //クリア
        }
        public Form1()
        {
            InitializeComponent();
        }

    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using Pong.Lib.Drawable;
using Pong.Lib;

namespace Pong
{
    public partial class Form1 : Form
    {
        private Bitmap background = assets.logo;
        private Graphics g;
        private Platform leftPlatform;
        private Platform rightPlatform;

        public Form1()
        {
            InitializeComponent();
            leftPlatform = new Platform(10, 10, 20, 40, background);
            rightPlatform = new Platform(Width - 50, 10, 20, 40, background);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            g.DrawImage(leftPlatform.PlatformImg, leftPlatform.Outline);
            g.DrawImage(rightPlatform.PlatformImg, rightPlatform.Outline);
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var pressedKey = e.KeyChar.ToString().ToLower();
            if (pressedKey == "s")
            {
                leftPlatform.Move(Direction.Down, 5);
            }
            else if (pressedKey == "w")
            {
                leftPlatform.Move(Direction.Up, 5);
            }
            if (pressedKey == "8")
            {
                rightPlatform.Move(Direction.Up, 5);
            }
            else if (pressedKey == "2")
            {
                rightPlatform.Move(Direction.Down, 5);
            }
        }
    }
}

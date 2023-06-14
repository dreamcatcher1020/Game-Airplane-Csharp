
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

using System.Windows.Forms;
using System.Drawing;
using Microsoft.DirectX.DirectSound;
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;






namespace GameAirPlaneCSharip
{



    partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        bool _end = true;
        int _count = 3;
        bool yunilix = true;
        bool vertikalYunilix = true;
        Point p1 = new Point();
        //okning orni
        Point p2 = new Point();
        Point p3 = new Point();

        bool _flagBullet = true;

        int _airVerticalSpace = 1;


        int x1_Bullet2;
        int x2_Bullet2;
        int y1_Bullet2;

        int y2_Bullet2;
        int x1_Tank1;
        int x2_Tank1;
        int y1_Tank1;

        int y2_Tank1;


        int x1_Bullet1;
        int x2_Bullet1;
        int y1_Bullet1;

        int y2_Bullet1;
        int x1_Tank2;
        int x2_Tank2;
        int y1_Tank2;

        int y2_Tank2;

        int _stepSpace = 10;


        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (yunilix == true)
            {
                if (Tank2.Location.X > Panel_Main.Width - Tank2.Width)
                {
                    yunilix = false;
                    Tank2.Image = Properties.Resources.airplaneLeft;

                }

                p1 = new Point(Tank2.Location.X + 5, Tank2.Location.Y + _airVerticalSpace);
                Tank2.Location = p1;

            }
            else
            {
                if (Tank2.Location.X < 0)
                {
                    yunilix = true;
                    Tank2.Image = Properties.Resources.airplaneRight;

                }
                p1 = new Point(Tank2.Location.X - 5, Tank2.Location.Y + _airVerticalSpace);
                Tank2.Location = p1;
            }


            if (vertikalYunilix == true)
            {
                if (Tank2.Location.Y > (Panel_Main.Height / 6) * 5)
                {
                    _airVerticalSpace = -1;
                    vertikalYunilix = false;
                }


            }
            else
            {
                if (Tank2.Location.Y < 0)
                {
                    _airVerticalSpace = 1;
                    vertikalYunilix = true;
                }
            }









            x1_Bullet2 = Bullet2.Location.X;
            x2_Bullet2 = Bullet2.Location.X + Bullet2.Width;
            y1_Bullet2 = Bullet2.Location.Y;
            y2_Bullet2 = Bullet2.Location.Y + Bullet2.Height;

            x1_Bullet1 = Bullet1.Location.X;
            x2_Bullet1 = Bullet1.Location.X + Bullet1.Width;
            y1_Bullet1 = Bullet1.Location.Y;
            y2_Bullet1 = Bullet1.Location.Y + Bullet1.Height;


            /////////////////
            x1_Tank1 = Tank1.Location.X;
            x2_Tank1 = Tank1.Location.X + Tank1.Width;
            y1_Tank1 = Tank1.Location.Y;
            y2_Tank1 = Tank1.Location.Y + Tank1.Height;

            x1_Tank2 = Tank2.Location.X;
            x2_Tank2 = Tank2.Location.X + Tank2.Width;
            y1_Tank2 = Tank2.Location.Y;
            y2_Tank2 = Tank2.Location.Y + Tank2.Height;




            if (((x1_Bullet2 >= x1_Tank1 & x1_Bullet2 <= x2_Tank1) | (x2_Bullet2 >= x1_Tank1 & x2_Bullet2 <= x2_Tank1)) & ((y1_Bullet2 >= y1_Tank1 & y1_Bullet2 <= y2_Tank1) | (y2_Bullet2 >= y1_Tank1 & y2_Bullet2 <= y2_Tank1)))
            {
                //Tank2.Image = GaPanel_Main.My.Resources.boom
                //Tank2.Visible = False
                Timer1.Enabled = false;
                _end = true;
                Button2.Visible = false;
                PlaySound("boom.wav", BufferPlayFlags.Default);
                Tank1.Image = Properties.Resources.boom;
                MessageBox.Show("Game Over!");

                return;
            }


            if (((x1_Bullet1 >= x1_Tank2 & x1_Bullet1 <= x2_Tank2) | (x2_Bullet1 >= x1_Tank2 & x2_Bullet1 <= x2_Tank2)) & ((y1_Bullet1 >= y1_Tank2 & y1_Bullet1 <= y2_Tank2) | (y2_Bullet1 >= y1_Tank2 & y2_Bullet1 <= y2_Tank2)))
            {
                _flagBullet = true;

                p3 = new Point(Tank1.Location.X + Tank1.Width / 2, Panel_Main.Height + Tank1.Location.Y);
                Bullet1.Location = p3;
                Bullet1.Image = Properties.Resources.boom;
                Bullet1.Visible = false;

                if (_count > 0)
                    _count = _count - 1;
                Lab_Life.Text = _count.ToString();

                if (_count == 0)
                {
                    Timer1.Enabled = false;
                    _end = true;
                    Button2.Visible = false;
                    PlaySound("boom.wav", BufferPlayFlags.Default);
                    Tank2.Image = Properties.Resources.boom;
                    //Timer2.Enabled = True

                    MessageBox.Show("You Win!!!!!!!");
                    return;
                }

            }









            if (Bullet1.Location.Y <= 0)
            {
                _flagBullet = true;
                GetBullet1DefaultLocation();
                Bullet1.Visible = false;
            }
            if (_flagBullet == false)
            {
                Bullet1.Location = new Point(p3.X, Bullet1.Location.Y - 10);
            }




            //bullet2
            if (Bullet2.Location.Y >= Panel_Main.Height)
            {
                p2 = new Point(Tank2.Location.X + Tank2.Width / 2, Tank2.Location.Y + Tank2.Height);
                Bullet2.Location = p2;
                PlaySound("tank2_ok.wav", BufferPlayFlags.Default);
            }
            Bullet2.Location = new Point(p2.X, Bullet2.Location.Y + 2);







        }


        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (_end == false)
            {
                Keys key = keyData;

                switch (key)
                {

                    case Keys.A:
                        if (Tank1.Location.X > 0)
                        {
                            Tank1.Location = new Point(Tank1.Location.X - _stepSpace, Tank1.Location.Y);
                            if (_flagBullet == true)
                            {
                                GetBullet1DefaultLocation();
                            }
                        }

                        break;
                    case Keys.D:
                        if (Tank1.Location.X + Tank1.Width < Panel_Main.Width)
                        {
                            Tank1.Location = new Point(Tank1.Location.X + _stepSpace, Tank1.Location.Y);
                            if (_flagBullet == true)
                            {
                                GetBullet1DefaultLocation();
                            }
                        }

                        break;
                    case Keys.W:
                        if (Tank1.Location.Y > 0)
                        {
                            Tank1.Location = new Point(Tank1.Location.X, Tank1.Location.Y - _stepSpace);
                            if (_flagBullet == true)
                            {
                                GetBullet1DefaultLocation();
                            }
                        }
                        break;
                    case Keys.S:
                        if (Tank1.Location.Y + Tank1.Height < Panel_Main.Height)
                        {
                            Tank1.Location = new Point(Tank1.Location.X, Tank1.Location.Y + _stepSpace);
                            if (_flagBullet == true)
                            {
                                GetBullet1DefaultLocation();
                            }

                        }

                        break;
                    case Keys.J:
                        if (_flagBullet == true)
                        {
                            PlaySound("tank1_ok.wav", BufferPlayFlags.Default);

                            GetBullet1DefaultLocation();

                            Bullet1.Image = Properties.Resources.Bullet2;
                            Bullet1.Visible = true;
                            _flagBullet = false;
                        }

                        break;
                }



            }
            if (keyData == Keys.A | keyData == Keys.D | keyData == Keys.W | keyData == Keys.S)
            {
                return false;
            }
            else
            {
                return base.ProcessDialogKey(keyData);
            }
        }

        private void GetBullet1DefaultLocation()
        {
            p3 = new Point(Tank1.Location.X + Tank1.Width / 2, Tank1.Location.Y);
            Bullet1.Location = p3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReSet();
            //背景音乐
            //PlaySound("1.wav", BufferPlayFlags.Looping);
            _audio = new Audio("back.mp3");
            //_audio.Stopping += new EventHandler(BackMusic_Stopping);
            _audio.Ending += new EventHandler(BackMusic_Ending);
            _audio.Play();
        }

        private void BackMusic_Ending(object sender, EventArgs e)
        {
            _audio.CurrentPosition = 0;
            _audio.Play();
        }
        Audio _audio;
        private void Button1_Click(object sender, EventArgs e)
        {
            GetBullet1DefaultLocation();
            Tank2.Image = Properties.Resources.airplaneRight;
            Tank1.Image = Properties.Resources.mytank;
            ReSet();
            Timer1.Enabled = true;
            Tank1.Visible = true;
            _count = 3;
            Lab_Life.Text = _count.ToString();
            Tank2.Visible = true;
        }



        //重置

        private void ReSet()
        {
            PictureBox pic = new PictureBox();
            pic.Image = Properties.Resources.airplane1;
            Tank1.Image = Properties.Resources.airplane1;
            Tank1.Location = new Point(Panel_Main.Width / 2, Panel_Main.Height - Tank1.Height);
            Tank2.Image = Properties.Resources.airplaneRight;
            Tank2.Location = new Point(0, 0);

            Button2.Text = "Stop";
            Button2.Visible = true;
            _end = false;
            Bullet1.Visible = false;
            p2 = new Point(Tank2.Location.X + Tank2.Width / 2, Tank2.Location.Y + Tank2.Height);
            Bullet2.Location = p2;
            p3 = new Point(Tank1.Location.X + Tank1.Width / 2, Tank1.Location.Y);
            Bullet1.Location = p3;
        }


        SecondaryBuffer backBuffer;
        Device backDev = new Device();
        //播放音乐

        public void PlaySound(string path, BufferPlayFlags playState)
        {
            backDev.SetCooperativeLevel(this, CooperativeLevel.Normal);
            backBuffer = new SecondaryBuffer(path, backDev);
            backBuffer.Play(0, playState);

        }
         
        private void Button2_Click(object sender, EventArgs e)
        {
            if (Timer1.Enabled == true)
            {
                Timer1.Enabled = false;
                Button2.Text = "Play";
            }
            else
            {
                Timer1.Enabled = true;
                Button2.Text = "Stop";
            }

        }

    }
}
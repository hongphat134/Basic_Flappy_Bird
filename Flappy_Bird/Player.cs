using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    class Player
    {
        private PictureBox[] mangOngTren;

        public PictureBox[] MangOngTren
        {
            get { return mangOngTren; }
            set { mangOngTren = value; }
        }


        private PictureBox[] mangOngDuoi;

        public PictureBox[] MangOngDuoi
        {
            get { return mangOngDuoi; }
            set { mangOngDuoi = value; }
        }


        private Size size_Ong;

        public Size Size_Ong
        {
            get { return size_Ong; }
            set { size_Ong = value; }
        }

        private int khoangCach;

       

        public int KhoangCach
        {
            get { return khoangCach; }
            set { khoangCach = value; }
        }

        
        private int khoangCachTrenDuoi;

        private Panel frmPlayer;
        Random r;
        public Player(Panel frm)
        {
            MangOngDuoi = new PictureBox[4];
            MangOngTren = new PictureBox[4];
            size_Ong = new Size(80, 400);
            khoangCach = 400;
            khoangCachTrenDuoi = 200;
            frmPlayer = frm;
            r = new Random();
        }

        private Point ChieuCaoNgauNhien()
        {
            int ChieuCaoOngTren, ChieuCaoOngDuoi;
            ChieuCaoOngTren = r.Next(-size_Ong.Height+50, -50);
            ChieuCaoOngDuoi = ChieuCaoOngTren + size_Ong.Height + khoangCachTrenDuoi;
            return new Point(ChieuCaoOngTren, ChieuCaoOngDuoi);
        }
        public void StartGame()
        {
                       
            for (int i = 0; i < MangOngTren.Length; i++)
            {
                Point RanHeight = ChieuCaoNgauNhien();
                //Tạo mảng ống trên
                MangOngTren[i] = new PictureBox()
                {
                    Location = new Point(khoangCach * (i + 1),RanHeight.X),
                    Size = size_Ong,
                    BackgroundImage = Image.FromFile("image/ongtren.png"),
                    BackgroundImageLayout = ImageLayout.Stretch
                };

                //Tạo mảng ống dưới
                MangOngDuoi[i] = new PictureBox()
                {
                    Location = new Point(khoangCach * (i + 1),RanHeight.Y),
                    Size = size_Ong,
                    BackgroundImage = Image.FromFile("image/ongduoi.png"),
                    BackgroundImageLayout = ImageLayout.Stretch
                };
            }

            frmPlayer.Controls.AddRange(MangOngTren);     
            frmPlayer.Controls.AddRange(MangOngDuoi);


            
        }
        
        public void TaoOng(int vitri)
        {
            Point RanHeight = ChieuCaoNgauNhien();
            MangOngDuoi[vitri].Location = new Point(frmPlayer.Width, RanHeight.Y);
            MangOngTren[vitri].Location = new Point(frmPlayer.Width, RanHeight.X);
        }
    }
}

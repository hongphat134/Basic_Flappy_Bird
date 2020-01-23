using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class frmFlappyBird : Form
    {
        enum State { Start, Stop };
        State trangthai;
        int VT;
        int dem;
        int vitriXetDiem;
        int NhipGame;

        Player plr;
        public frmFlappyBird()
        {
            
            InitializeComponent();
            
            pnlGame.Size = new System.Drawing.Size(1100, 600);
            pnlGame.Location = new Point(0, 0);
            pnlUnderGround.Size = new System.Drawing.Size(1100, 100);
            pnlUnderGround.Location = new Point(0, 600);
            plr=new Player(pnlGame);
            plr.StartGame();
            lblTitle.BackColor = Color.Transparent;
            NhipGame = 20;
            DiemSo = 0;
            vitriXetDiem = 0;
            trangthai = State.Start;
            VT = plr.MangOngDuoi.Length - 1;
            lblScore.Text = "Score: " + DiemSo.ToString();
        }
      
        double DiemSo;
        private void timerPlay_Tick(object sender, EventArgs e)
        {
            // DoubleBuffer => hiệu chỉnh không bị giựt màn hình.
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);


            foreach (PictureBox ptr in plr.MangOngDuoi)
            {
                ptr.Location = new Point(ptr.Location.X - 10, ptr.Location.Y);
            }

            foreach (PictureBox ptr in plr.MangOngTren)
            {
                ptr.Location = new Point(ptr.Location.X - 10, ptr.Location.Y);
            }


            

            //Xử lý tính điểm
            if(ptrIcon.Location.X==(plr.MangOngDuoi[vitriXetDiem].Location.X+plr.Size_Ong.Width))
            {
                DiemSo++;
                lblScore.Text = "Score: " + DiemSo.ToString();
                vitriXetDiem++;
                if (vitriXetDiem == plr.MangOngDuoi.Length) vitriXetDiem = 0;
            }

            if(Width-plr.MangOngDuoi[VT].Location.X==plr.KhoangCach){
                
                if (VT == plr.MangOngDuoi.Length - 1) VT = 0;
                else VT++;
                plr.TaoOng(VT);                                      
            }
           

            
        }

       
        private void frmFlappyBird_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (trangthai == State.Start)
                {
                    timerPlay.Start();
                    timerIcon.Start();
                    timerBirdMove.Start();
                    
                    lblTitle.Visible = false;
                    trangthai=State.Stop;
                }
                else if(trangthai==State.Stop)
                {
                    timerPlay.Stop();
                    timerIcon.Stop();
                    timerBirdMove.Stop();
                    lblTitle.Visible = true;
                    trangthai = State.Start;
                }
            }
            else
            {
                ptrIcon.Location = new Point(ptrIcon.Location.X, ptrIcon.Location.Y - (NhipGame*4));
                ptrIcon.BackgroundImage = Image.FromFile("image/up.png");
                dem = 0;
            }
        }

        private void timerIcon_Tick(object sender, EventArgs e)
        {
            ptrIcon.Location = new Point(ptrIcon.Location.X, ptrIcon.Location.Y + NhipGame);

            // DoubleBuffer => hiệu chỉnh không bị giựt màn hình.
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            //điều kiện vào phạm vi va chạm
            if (ptrIcon.Location.X+ptrIcon.Size.Width>=plr.MangOngDuoi[vitriXetDiem].Location.X)
            {
                //xét va chạm ống dưới
                if (ptrIcon.Location.Y > plr.MangOngDuoi[vitriXetDiem].Location.Y - ptrIcon.Size.Height || ptrIcon.Location.Y < plr.MangOngTren[vitriXetDiem].Location.Y + plr.Size_Ong.Height)
                {
                    ptrIcon.BackgroundImage = Image.FromFile("image/birdfall.jpg");
                    timerPlay.Stop();
                    timerBirdMove.Stop();
                    this.KeyPress -= frmFlappyBird_KeyPress;
                }
            }

            
           
            if (ptrIcon.Location.Y + ptrIcon.Size.Height >=pnlGame.Height)
            {
                timerIcon.Stop();
                timerBirdMove.Stop();
                MessageBox.Show("You lose!");
                Close();
            }
         }

        
        private void timerBirdMove_Tick(object sender, EventArgs e)
        {
            if (dem>1&&dem<3) {
                ptrIcon.BackgroundImage = Image.FromFile("image/icon.png");
            }
            else if(dem>3)
            {
                ptrIcon.BackgroundImage = Image.FromFile("image/down.png");
            }
            dem++;
        }
    }
}

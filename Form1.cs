using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public class CActor
    {
        public int X , Y , N ,C;
        public int W , H ;
        public Color cl;
    }
    public partial class Form1 : Form
    {
        List<CActor> el3moooods = new List<CActor>();
        List<CActor> el3mooood0 = new List<CActor>();
        List<CActor> el3mooood1 = new List<CActor>();
        List<CActor> el3mooood2 = new List<CActor>();
        List<CActor> elmoka3bat = new List<CActor>();

        
        int margin = 10;

        bool isDrag = false;
        int xOld, yOld;

        int bigx , bigw , bigy;

        int iWhich = -1;

        int originalX;
        int originalY;
        int z;

        int originalXX;
        int originalYY;

        public Form1()
        {
            this.Paint += Form1_Paint;
            this.Load += Form1_Load;
            this.WindowState = FormWindowState.Maximized;
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
            this.Paint += Form1_Paint;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                CActor ptrav = elmoka3bat[elmoka3bat[iWhich].N];
                if (e.X >= el3moooods[0].X
                    && e.X <= el3moooods[0].X + el3moooods[0].W
                    && e.Y >= el3moooods[0].Y
                    && e.Y <= el3moooods[0].Y + el3moooods[0].H
                    && ptrav.C != 0 
                    )
                {
                    if (el3mooood0.Count == 0)
                    {
                        if (ptrav.C == 1)
                        {
                            el3mooood1.RemoveAt(el3mooood1.Count - 1);
                        }
                        else
                        {
                            el3mooood2.RemoveAt(el3mooood2.Count - 1);
                        }
                        ptrav.C = 0;
                        ptrav.X = el3moooods[0].X - (ptrav.N * 10);
                        ptrav.W = (ptrav.N * 20) + 40;
                        ptrav.Y = this.ClientSize.Height - (el3mooood0.Count * 50) - 50;
                        ptrav.H = 40;
                        ptrav.cl = Color.Yellow;
                        el3mooood0.Add(ptrav);
                    }
                    else
                    {
                        if (el3mooood0[el3mooood0.Count - 1].N > ptrav.N)
                        {
                            if (ptrav.C == 1)
                            {
                                el3mooood1.RemoveAt(el3mooood1.Count - 1);
                            }
                            else
                            {
                                el3mooood2.RemoveAt(el3mooood2.Count - 1);
                            }
                            ptrav.C = 0;
                            ptrav.X = el3moooods[0].X - (ptrav.N * 10);
                            ptrav.W = (ptrav.N * 20) + 40;
                            ptrav.Y = this.ClientSize.Height - (el3mooood0.Count * 50) - 50;
                            ptrav.H = 40;
                            ptrav.cl = Color.Yellow;
                            el3mooood0.Add(ptrav);
                        }
                        else
                        {
                            ptrav.X = originalXX;
                            ptrav.Y = originalYY;
                        }
                    }
                }
                else if (e.X >= el3moooods[1].X
                    && e.X <= el3moooods[1].X + el3moooods[1].W
                    && e.Y >= el3moooods[1].Y
                    && e.Y <= el3moooods[1].Y + el3moooods[1].H
                    && ptrav.C != 1
                    )
                {


                    if (el3mooood1.Count == 0)
                    {
                        if (ptrav.C == 0)
                        {
                            el3mooood0.RemoveAt(el3mooood0.Count - 1);
                        }
                        else
                        {
                            el3mooood2.RemoveAt(el3mooood2.Count - 1);
                        }
                        ptrav.C = 1;
                        ptrav.X = el3moooods[1].X - (ptrav.N * 10);
                        ptrav.W = (ptrav.N * 20) + 40;
                        ptrav.Y = this.ClientSize.Height - (el3mooood1.Count * 50) - 50;
                        ptrav.H = 40;
                        ptrav.cl = Color.Yellow;
                        el3mooood1.Add(ptrav);
                    }
                    else 
                    {
                        if (el3mooood1[el3mooood1.Count - 1].N > ptrav.N)
                        {
                            if (ptrav.C == 0)
                            {
                                el3mooood0.RemoveAt(el3mooood0.Count - 1);
                            }
                            else
                            {
                                el3mooood2.RemoveAt(el3mooood2.Count - 1);
                            }
                            ptrav.C = 1;
                            ptrav.X = el3moooods[1].X - (ptrav.N * 10);
                            ptrav.W = (ptrav.N * 20) + 40;
                            ptrav.Y = this.ClientSize.Height - (el3mooood1.Count * 50) - 50;
                            ptrav.H = 40;
                            ptrav.cl = Color.Yellow;
                            el3mooood1.Add(ptrav);
                        }
                        else
                        {
                            ptrav.X = originalXX;
                            ptrav.Y = originalYY;
                        }
                    }
                }
                else if (e.X >= el3moooods[2].X
                    && e.X <= el3moooods[2].X + el3moooods[2].W
                    && e.Y >= el3moooods[2].Y
                    && e.Y <= el3moooods[2].Y + el3moooods[2].H
                    && ptrav.C != 2
                    )
                {
                    if (el3mooood2.Count == 0)
                    {
                        if (ptrav.C == 1)
                        {
                            el3mooood1.RemoveAt(el3mooood1.Count - 1);
                        }
                        else
                        {
                            el3mooood0.RemoveAt(el3mooood0.Count - 1);
                        }
                        ptrav.C = 2;
                        ptrav.X = el3moooods[2].X - (ptrav.N * 10);
                        ptrav.W = (ptrav.N * 20) + 40;
                        ptrav.Y = this.ClientSize.Height - (el3mooood2.Count * 50) - 50;
                        ptrav.H = 40;
                        ptrav.cl = Color.Yellow;
                        el3mooood2.Add(ptrav);
                    }
                    else
                    {
                        if (el3mooood2[el3mooood2.Count - 1].N > ptrav.N)
                        {
                            if (ptrav.C == 1)
                            {
                                el3mooood1.RemoveAt(el3mooood1.Count - 1);
                            }
                            else
                            {
                                el3mooood0.RemoveAt(el3mooood0.Count - 1);
                            }
                            ptrav.C = 2;
                            ptrav.X = el3moooods[2].X - (ptrav.N * 10);
                            ptrav.W = (ptrav.N * 20) + 40;
                            ptrav.Y = this.ClientSize.Height - (el3mooood2.Count * 50) - 50;
                            ptrav.H = 40;
                            ptrav.cl = Color.Yellow;
                            el3mooood2.Add(ptrav);
                        }
                        else
                        {
                            ptrav.X = originalXX;
                            ptrav.Y = originalYY;
                        }
                    }
                }
                else 
                {
                    
                    ptrav.X = originalXX;
                    ptrav.Y = originalYY;
                }
            }
            isDrag = false;
            iWhich = -1;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                int dx = e.X - xOld;
                int dy = e.Y - yOld;

                CActor ptrav = elmoka3bat[elmoka3bat[iWhich].N];/////////////////////////////////////////////
                ptrav.X += dx;
                ptrav.Y += dy;

                xOld = e.X;
                yOld = e.Y;
                //DrawScene(this.CreateGraphics());
            }

            DrawScene();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                iWhich = isHit(e.X, e.Y,ref z, elmoka3bat ,el3mooood0 , el3mooood1 , el3mooood2);
                //MessageBox.Show("i >>" + iWhich );

                if (iWhich != -1)
                {
                    xOld = e.X;
                    yOld = e.Y;
                    isDrag = true;
                    originalX = e.X;
                    originalY = e.Y;
                    originalXX = elmoka3bat[elmoka3bat[iWhich].N].X;
                    originalYY = elmoka3bat[elmoka3bat[iWhich].N].Y;
                }
            }
        }

        int isHit(int XM, int YM,ref int z , List<CActor> L, List<CActor> c0, List<CActor> c1, List<CActor> c2)
        {
            int k =0;
            for (int i = 0; i < L.Count; i++)
            {
                CActor ptrav = L[i];
                if (
                            XM > ptrav.X
                        && XM <= (ptrav.X + ptrav.W)
                        && YM > ptrav.Y
                        && YM <= (ptrav.Y + ptrav.H)
                    )
                {
                    if (ptrav.C == 0 && ptrav == el3mooood0[el3mooood0.Count - 1])
                    {

                        for (int k0 = 0; k0 < c0.Count; k0++)
                        {
                            CActor ptrav2 = c0[k0];

                            if (ptrav == ptrav2)
                            {
                                k = c0[k0].N; z = 0;
                                return k;
                                break;
                            }
                        }
                    }
                    else if (ptrav.C == 1 && ptrav == el3mooood1[el3mooood1.Count - 1])
                    {

                        for (int k0 = 0; k0 < c1.Count; k0++)
                        {
                            CActor ptrav2 = c1[k0];

                            if (ptrav == ptrav2)
                            {
                                k = c1[k0].N; z = 1;
                                return k;
                                break;
                            }
                        }
                    }
                    else if (ptrav.C == 2 && ptrav == el3mooood2[el3mooood2.Count - 1])
                    {

                        for (int k0 = 0; k0 < c2.Count; k0++)
                        {
                            CActor ptrav2 = c2[k0];

                            if (ptrav == ptrav2)
                            {
                                k = c2[k0].N; z = 2;
                                return k;
                                break;
                            }
                        }
                    }
                    
                    //break;
                }
            }
            return -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            create3moood();
            createmoka3bat();
            DrawScene();
        }
        void create3moood()
        {
            CActor pnn = new CActor();
            pnn.X = (this.ClientSize.Width / 4 ) - 25;
            pnn.Y = this.ClientSize.Height - 510;
            pnn.W = 40;
            pnn.H = 510;
            pnn.cl = Color.Blue;
            el3moooods.Add(pnn);

            pnn = new CActor();
            pnn.X = (this.ClientSize.Width * 2 / 4) - 25;
            pnn.Y = this.ClientSize.Height - 510;
            pnn.W = 40;
            pnn.H = 510;
            pnn.cl = Color.Blue;
            el3moooods.Add(pnn);

            pnn = new CActor();
            pnn.X = (this.ClientSize.Width * 3 / 4) - 25;
            pnn.Y = this.ClientSize.Height - 510;
            pnn.W = 40;
            pnn.H = 510;
            pnn.cl = Color.Blue;
            el3moooods.Add(pnn);

        }

        void createmoka3bat ()
        {
            CActor pnn;
            int n = 10;
            bigx = el3moooods[0].X - 100;
            int newx = bigx;
            bigw = 240;
            int neww = bigw;
            bigy = this.ClientSize.Height - 50;
            int newy = bigy;
            for (int i = 0; i < 10; i++)
            {
                pnn = new CActor();
                pnn.X = el3moooods[0].X - (n * 10) ;
                pnn.W = (n * 20) + 40 ;
                pnn.Y = newy ;
                pnn.H = 40 ;
                pnn.cl = Color.Yellow;
                pnn.N = n - 1 ;
                pnn.C = 0;

                elmoka3bat.Add(pnn);
                el3mooood0.Add(pnn);

                newx += 10;
                neww -= 20;
                newy -= 50;
                n--;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawScene();
        }
        void DrawScene ()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);

            SolidBrush brsh;
            Pen p = new Pen(Color.Orange, 5);
            
            for (int i = 0; i < el3moooods.Count; i++) 
            {
                CActor ptrav = el3moooods[i];
                brsh = new SolidBrush(Color.Blue);
                g.FillRectangle(brsh , ptrav.X , ptrav.Y , ptrav .W , ptrav.H );
                //g.DrawRectangle(p, ptrav.X, ptrav.Y, ptrav.W, ptrav.H);
            }

            for (int i = 0; i < el3mooood0.Count; i++)
            {
                CActor ptrav = el3mooood0[i];
                brsh = new SolidBrush(ptrav.cl);
                g.FillRectangle(brsh, ptrav.X, ptrav.Y , ptrav.W, ptrav.H);
               // g.DrawRectangle(p, ptrav.X, ptrav.Y, ptrav.W, ptrav.H);
            }

            for (int i = 0; i < el3mooood1.Count; i++)
            {
                CActor ptrav = el3mooood1[i];
                brsh = new SolidBrush(ptrav.cl);
                g.FillRectangle(brsh, ptrav.X, ptrav.Y, ptrav.W, ptrav.H);
               // g.DrawRectangle(p, ptrav.X, ptrav.Y, ptrav.W, ptrav.H);
            }

            for (int i = 0; i < el3mooood2.Count; i++)
            {
                CActor ptrav = el3mooood2[i];
                brsh = new SolidBrush(ptrav.cl);
                g.FillRectangle(brsh, ptrav.X, ptrav.Y, ptrav.W, ptrav.H);
                //g.DrawRectangle(p, ptrav.X, ptrav.Y, ptrav.W, ptrav.H);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame1
{
    public partial class Form1 : Form
    {
        
        Random location = new Random();  // selektira random vrednost i dodeluva nova lokacija na sekoj otvoren broj
        List<Point> points = new List<Point>(); 
        PictureBox PendingNumber1;// se skladira prviot otvoren broj vo ovaa varijabla
        PictureBox PendingNumber2;//se skladira vtoriot otvoren broj vo ovaa varijabla
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Broj1.Enabled = false;
            DupBroj1.Enabled = false;
            Broj2.Enabled = false;
            DupBroj2.Enabled = false;
            Broj3.Enabled = false;
            DupBroj3.Enabled = false;
            Broj4.Enabled = false;
            DupBroj4.Enabled = false;
            Broj5.Enabled = false;
            DupBroj5.Enabled = false;
            Broj6.Enabled = false;
            DupBroj6.Enabled = false;
            Broj7.Enabled = false;
            DupBroj7.Enabled = false;
            Broj8.Enabled = false;
            DupBroj8.Enabled = false;
            Broj9.Enabled = false;
            DupBroj9.Enabled = false;
            Broj10.Enabled = false;
            DupBroj10.Enabled = false;
            Broj11.Enabled = false;
            DupBroj11.Enabled = false;
            Broj12.Enabled = false;
            DupBroj12.Enabled = false;
            Broj13.Enabled = false;
            DupBroj13.Enabled = false;
            Broj14.Enabled = false;
            DupBroj14.Enabled = false;
            Broj15.Enabled = false;
            DupBroj15.Enabled = false;
            Broj16.Enabled = false;
            DupBroj16.Enabled = false;
            Broj17.Enabled = false;
            DupBroj17.Enabled = false;
            Broj18.Enabled = false;
            DupBroj18.Enabled = false;
            label3.Text = "155";
            foreach(PictureBox picture in panel1.Controls)
            {
                points.Add(picture.Location);
            }
            foreach(PictureBox picture in panel1.Controls)
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }
            
           
            

            foreach (PictureBox picture in panel1.Controls)
            {
                picture.Image = Properties.Resources.Cover;
                picture.Cursor = Cursors.Hand;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label3.Text);
            timer = timer - 1;
            label3.Text = Convert.ToString(timer);
            if(timer==0)
            {
                timer2.Stop();
                foreach(PictureBox picture in panel1.Controls)
                {
                    picture.Enabled = false;
                }
                
            }
                

        }
        #region Broevi
        private void Broj1_Click(object sender, EventArgs e)
        {
            Broj1.Image = Properties.Resources._1;
            if(PendingNumber1 == null)
            {
                PendingNumber1 = Broj1;
            }
            else if(PendingNumber1!=null && PendingNumber2==null)
            {
                PendingNumber2 = Broj1;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj1.Enabled = false;
                    DupBroj1.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                   
                }
                else
                {
                    timer3.Start();
                }
              
            }
        }

        private void DupBroj1_Click(object sender, EventArgs e)
        {
            DupBroj1.Image = Properties.Resources._1;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj1;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj1;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj1.Enabled = false;
                    DupBroj1.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj2_Click(object sender, EventArgs e)
        {
            Broj2.Image = Properties.Resources._2;
            if(PendingNumber1 == null)
            {
                PendingNumber1 = Broj2;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj2;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj2.Enabled = false;
                    DupBroj2.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj2_Click(object sender, EventArgs e)
        {
            DupBroj2.Image = Properties.Resources._2;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj2;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj2;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj2.Enabled = false;
                    DupBroj2.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj3_Click(object sender, EventArgs e)
        {
            Broj3.Image = Properties.Resources._3;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj3;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj3;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj3.Enabled = false;
                    DupBroj3.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj3_Click(object sender, EventArgs e)
        {
            DupBroj3.Image = Properties.Resources._3;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj3;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj3;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj3.Enabled = false;
                    DupBroj3.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj4_Click(object sender, EventArgs e)
        {
            Broj4.Image = Properties.Resources._4;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj4;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj4;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj4.Enabled = false;
                    DupBroj4.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj4_Click(object sender, EventArgs e)
        {
            DupBroj4.Image = Properties.Resources._4;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj4;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj4;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj4.Enabled = false;
                    DupBroj4.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj5_Click(object sender, EventArgs e)
        {
            Broj5.Image = Properties.Resources._5;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj5;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj5;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj5.Enabled = false;
                    DupBroj5.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj5_Click(object sender, EventArgs e)
        {
            DupBroj5.Image = Properties.Resources._5;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj5;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj5;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj5.Enabled = false;
                    DupBroj5.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj6_Click(object sender, EventArgs e)
        {
            Broj6.Image = Properties.Resources._6;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj6;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj6;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj6.Enabled = false;
                    DupBroj6.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj6_Click(object sender, EventArgs e)
        {
            DupBroj6.Image = Properties.Resources._6;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj6;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj6;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj6.Enabled = false;
                    DupBroj6.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj7_Click(object sender, EventArgs e)
        {
            Broj7.Image = Properties.Resources._7;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj7;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj7;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj7.Enabled = false;
                    DupBroj7.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj7_Click(object sender, EventArgs e)
        {
            DupBroj7.Image = Properties.Resources._7;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj7;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj7;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj7.Enabled = false;
                    DupBroj7.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj8_Click(object sender, EventArgs e)
        {
            Broj8.Image = Properties.Resources._8;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj8;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj8;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj8.Enabled = false;
                    DupBroj8.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj8_Click(object sender, EventArgs e)
        {
            DupBroj8.Image = Properties.Resources._8;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj8;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj8;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj8.Enabled = false;
                    DupBroj8.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj9_Click(object sender, EventArgs e)
        {
            Broj9.Image = Properties.Resources._9;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj9;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj9;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj9.Enabled = false;
                    DupBroj9.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj9_Click(object sender, EventArgs e)
        {
            DupBroj9.Image = Properties.Resources._9;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj9;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj9;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj9.Enabled = false;
                    DupBroj9.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj10_Click(object sender, EventArgs e)
        {
            Broj10.Image = Properties.Resources._10;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj10;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj10;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj10.Enabled = false;
                    DupBroj10.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj10_Click(object sender, EventArgs e)
        {
            DupBroj10.Image = Properties.Resources._10;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj10;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj10;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj10.Enabled = false;
                    DupBroj10.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj11_Click(object sender, EventArgs e)
        {
            Broj11.Image = Properties.Resources._11;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj11;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj11;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj11.Enabled = false;
                    DupBroj11.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj11_Click(object sender, EventArgs e)
        {
            DupBroj11.Image = Properties.Resources._11;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj11;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj11;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj11.Enabled = false;
                    DupBroj11.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj12_Click(object sender, EventArgs e)
        {
            Broj12.Image = Properties.Resources._12;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj12;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj12;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj12.Enabled = false;
                    DupBroj12.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj12_Click(object sender, EventArgs e)
        {
            DupBroj12.Image = Properties.Resources._12;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj12;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj12;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj12.Enabled = false;
                    DupBroj12.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj13_Click(object sender, EventArgs e)
        {
            Broj13.Image = Properties.Resources._13;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj13;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj13;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj13.Enabled = false;
                    DupBroj13.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj13_Click(object sender, EventArgs e)
        {
            DupBroj13.Image = Properties.Resources._13;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj13;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj13;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj13.Enabled = false;
                    DupBroj13.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj14_Click(object sender, EventArgs e)
        {
            Broj14.Image = Properties.Resources._14;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj14;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj14;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj14.Enabled = false;
                    DupBroj14.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj14_Click(object sender, EventArgs e)
        {
            DupBroj14.Image = Properties.Resources._14;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj14;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj14;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj14.Enabled = false;
                    DupBroj14.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj15_Click(object sender, EventArgs e)
        {
            Broj15.Image = Properties.Resources._15;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj15;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj15;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj15.Enabled = false;
                    DupBroj15.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj15_Click(object sender, EventArgs e)
        {
            DupBroj15.Image = Properties.Resources._15;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj15;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj15;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj15.Enabled = false;
                    DupBroj15.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj16_Click(object sender, EventArgs e)
        {
            Broj16.Image = Properties.Resources._16;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj16;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj16;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj16.Enabled = false;
                    DupBroj16.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj16_Click(object sender, EventArgs e)
        {
            DupBroj16.Image = Properties.Resources._16;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj16;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj16;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj16.Enabled = false;
                    DupBroj16.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj17_Click(object sender, EventArgs e)
        {
            Broj17.Image = Properties.Resources._17;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj17;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj17;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj17.Enabled = false;
                    DupBroj17.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj17_Click(object sender, EventArgs e)
        {
            DupBroj17.Image = Properties.Resources._17;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj17;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj17;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj17.Enabled = false;
                    DupBroj17.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void Broj18_Click(object sender, EventArgs e)
        {
            Broj18.Image = Properties.Resources._18;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = Broj18;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = Broj18;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj18.Enabled = false;
                    DupBroj18.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void DupBroj18_Click(object sender, EventArgs e)
        {
            DupBroj18.Image = Properties.Resources._18;
            if (PendingNumber1 == null)
            {
                PendingNumber1 = DupBroj18;
            }
            else if (PendingNumber1 != null && PendingNumber2 == null)
            {
                PendingNumber2 = DupBroj18;
            }
            if (PendingNumber1 != null && PendingNumber2 != null)
            {
                if (PendingNumber1.Tag == PendingNumber2.Tag)
                {
                    PendingNumber1 = null;
                    PendingNumber2 = null;
                    Broj18.Enabled = false;
                    DupBroj18.Enabled = false;
                    brPoeni.Text = Convert.ToString(Convert.ToInt32(brPoeni.Text) + 10);
                    if (brPoeni.Text == "180")
                    {
                        timer2.Stop();
                        MessageBox.Show("Честитки! Ги отворивте сите броеви!");
                    }
                }
                else
                {
                    timer3.Start();
                }

            }
        }
        #endregion

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PendingNumber1.Image = Properties.Resources.Cover;
            PendingNumber2.Image = Properties.Resources.Cover;
            PendingNumber1 = null;
            PendingNumber2 = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Broj1.Image = Properties.Resources._1;
            DupBroj1.Image = Properties.Resources._1;
            Broj2.Image = Properties.Resources._2;
            DupBroj2.Image = Properties.Resources._2;
            Broj3.Image = Properties.Resources._3;
            DupBroj3.Image = Properties.Resources._3;
            Broj4.Image = Properties.Resources._4;
            DupBroj4.Image = Properties.Resources._4;
            Broj5.Image = Properties.Resources._5;
            DupBroj5.Image = Properties.Resources._5;
            Broj6.Image = Properties.Resources._6;
            DupBroj6.Image = Properties.Resources._6;
            Broj7.Image = Properties.Resources._7;
            DupBroj7.Image = Properties.Resources._7;
            Broj8.Image = Properties.Resources._8;
            DupBroj8.Image = Properties.Resources._8;
            Broj9.Image = Properties.Resources._9;
            DupBroj9.Image = Properties.Resources._9;
            Broj10.Image = Properties.Resources._10;
            DupBroj10.Image = Properties.Resources._10;
            Broj11.Image = Properties.Resources._11;
            DupBroj11.Image = Properties.Resources._11;
            Broj12.Image = Properties.Resources._12;
            DupBroj12.Image = Properties.Resources._12;
            Broj13.Image = Properties.Resources._13;
            DupBroj13.Image = Properties.Resources._13;
            Broj14.Image = Properties.Resources._14;
            DupBroj14.Image = Properties.Resources._14;
            Broj15.Image = Properties.Resources._15;
            DupBroj15.Image = Properties.Resources._15;
            Broj16.Image = Properties.Resources._16;
            DupBroj16.Image = Properties.Resources._16;
            Broj17.Image = Properties.Resources._17;
            DupBroj17.Image = Properties.Resources._17;
            Broj18.Image = Properties.Resources._18;
            DupBroj18.Image = Properties.Resources._18;
            timer2.Start();
            timer1.Start();
            label3.Text = "155";
            Broj1.Enabled = true;
            DupBroj1.Enabled = true;
            Broj2.Enabled = true;
            DupBroj2.Enabled = true;
            Broj3.Enabled = true;
            DupBroj3.Enabled = true;
            Broj4.Enabled = true;
            DupBroj4.Enabled = true;
            Broj5.Enabled = true;
            DupBroj5.Enabled = true;
            Broj6.Enabled = true;
            DupBroj6.Enabled = true;
            Broj7.Enabled = true;
            DupBroj7.Enabled = true;
            Broj8.Enabled = true;
            DupBroj8.Enabled = true;
            Broj9.Enabled = true;
            DupBroj9.Enabled = true;
            Broj10.Enabled = true;
            DupBroj10.Enabled = true;
            Broj11.Enabled = true;
            DupBroj11.Enabled = true;
            Broj12.Enabled = true;
            DupBroj12.Enabled = true;
            Broj13.Enabled = true;
            DupBroj13.Enabled = true;
            Broj14.Enabled = true;
            DupBroj14.Enabled = true;
            Broj15.Enabled = true;
            DupBroj15.Enabled = true;
            Broj16.Enabled = true;
            DupBroj16.Enabled = true;
            Broj17.Enabled = true;
            DupBroj17.Enabled = true;
            Broj18.Enabled = true;
            DupBroj18.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox picture in panel1.Controls)
            {
                picture.Image = Properties.Resources.Cover;
                picture.Cursor = Cursors.Hand;
            }

            timer1.Stop();
            timer2.Start();
        }
    }
}

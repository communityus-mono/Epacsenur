using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Epacsenur.Features.Client;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Epacsenur
{
    public partial class Form1 : Form
    {
        //global variables
        int TogMove;
        int MValx;
        int MValy;

        int sleepForPicBox = 35;

        //all the web broswers created
        WebBrowser osrsWiki = new WebBrowser();
        WebBrowser redditBrowser = new WebBrowser();

        public ChromiumWebBrowser merchPlat;

        public Form1()
        {
            InitializeComponent();
        }
        //anmation for side
        private void Max(PictureBox name)
        {
            name.Invoke((MethodInvoker)delegate
            {
                int start = 0;
                int countX = 20;
                int countY = 20;

                while (start <= 2)
                {
                    countX += 1;
                    countY += 1;

                    name.Size = new Size(countX, countY);
                    start += 1;
                    Thread.Sleep(sleepForPicBox);
                }
            });
        }
        //animation for side
        private void Min(PictureBox name)
        {
            name.Invoke((MethodInvoker)delegate
            {
                int start = 0;
                int countX = 22;
                int countY = 22;

                while (start <= 2)
                {
                    countX -= 1;
                    countY -= 1;

                    name.Size = new Size(countX, countY);
                    start += 1;
                    Thread.Sleep(sleepForPicBox);
                }
            });
        }

        private void webAppear(WebBrowser web, string url)
        {
            if (!Holder.Controls.Contains(web))
            {
                MinimizeFootPrint();
                Holder.Controls.Clear();

                Holder.Controls.Add(web);
                //sets it to pannel size
                web.Size = new Size(Holder.Size.Width, Holder.Size.Height);
                web.AllowNavigation = true;
                web.ScriptErrorsSuppressed = true;
                web.Navigate(url);
            }
        }

        private void webAppearC(ChromiumWebBrowser web, string url)
        {
            if (!Holder.Controls.Contains(web))
            {
                MinimizeFootPrint();

                Holder.Controls.Clear();

                //Cef.Initialize(new CefSettings());

                web = new ChromiumWebBrowser(url);

                Holder.Controls.Add(web);

                //sets it to pannel size
                web.Size = new Size(Holder.Size.Width, Holder.Size.Height);
            }
        }

        public void makePicturebox(PictureBox picName, int lX, int lY, int Sx, int Sy, Bitmap image)
        {
            picName = new PictureBox();
            picName.Location = new System.Drawing.Point(lX, lY);
            picName.Size = new System.Drawing.Size(Sx, Sy);
            picName.BackgroundImage = image;
            picName.BackgroundImageLayout = ImageLayout.Stretch;

            Holder.Controls.Add(picName);
        }

        //minimize button
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            Minimize.Visible = true;

        }

        //exit client button
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //move window start
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValx, MousePosition.Y - MValy);

            }
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValx = e.X;
            MValy = e.Y;
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
        //move window end
        private void Minimize_Click(object sender, EventArgs e)
        {
            Show();
        }

        [DllImport("psapi.dll")]
        static extern int EmptyWorkingSet(IntPtr hwProc);

        static void MinimizeFootPrint()
        {
            EmptyWorkingSet(Process.GetCurrentProcess().Handle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MinimizeFootPrint();

            osrs.ScrollBarsEnabled = false;
            osrs.AllowNavigation = true;
            osrs.Navigate("https://oldschool.runescape.com/game?world=393");

        }

        //closes the side bar
        private void Contract_Click(object sender, EventArgs e)
        {
            int counter_exit = pictureBox1.Location.X;
            int counter_min = pictureBox2.Location.X;
            int counter_size = Contract.Location.X;

            Form1.ActiveForm.Invoke((MethodInvoker)delegate
            {
                if (Epacsenur.Form1.ActiveForm.Width == 1405)
                {
                    Contract.BackgroundImage = Epacsenur.Properties.Resources.Right;

                    while (Epacsenur.Form1.ActiveForm.Width != 800)
                    {
                        Epacsenur.Form1.ActiveForm.Width -= 5;

                        counter_exit -= 5;
                        pictureBox1.Location = new Point(counter_exit, 3);

                        counter_min -= 5;
                        pictureBox2.Location = new Point(counter_min, 3);

                        counter_size -= 5;
                        Contract.Location = new Point(counter_size, 0);
                    }

                }
                else if (Epacsenur.Form1.ActiveForm.Width == 800)
                {
                    Contract.BackgroundImage = Epacsenur.Properties.Resources.Left;

                    while (Epacsenur.Form1.ActiveForm.Width != 1405)
                    {
                        Epacsenur.Form1.ActiveForm.Width += 5;

                        counter_exit += 5;
                        pictureBox1.Location = new Point(counter_exit, 3);

                        counter_min += 5;
                        pictureBox2.Location = new Point(counter_min, 3);

                        counter_size += 5;
                        Contract.Location = new Point(counter_size, 0);
                    }

                }
            });
        }


        private void Osrs_wiki_Click(object sender, EventArgs e)
        {
            webAppear(osrsWiki, "https://oldschool.runescape.wiki/");
        }
        //hover animation start for wiki
        private void Osrs_wiki_MouseEnter(object sender, EventArgs e)
        {
            Max(osrs_wiki);
        }

        private void Osrs_wiki_MouseLeave(object sender, EventArgs e)
        {
            Min(osrs_wiki);
        }

        //hover end animation for wiki

        private void Merch_MouseEnter(object sender, EventArgs e)
        {
            Max(Merch);
        }

        private void Merch_MouseLeave(object sender, EventArgs e)
        {
            Min(Merch);
        }

        private void Merch_Click(object sender, EventArgs e)
        {
            webAppearC(merchPlat, "https://platinumtokens.com/");
        }

        private void ZulrahPlugin_MouseEnter(object sender, EventArgs e)
        {
            Max(zulrahPlugin);
        }

        private void ZulrahPlugin_MouseLeave(object sender, EventArgs e)
        {
            Min(zulrahPlugin);
        }

        PictureBox zulStart;
        PictureBox rangePhase;
        PictureBox magicPhase;
        PictureBox magicB;
        PictureBox R1;
        PictureBox R2;
        PictureBox zulKeyFrame;

        Bitmap zulStartPic = new Bitmap(Properties.Resources.phase1);
        Bitmap zulKey = new Bitmap(Properties.Resources.Zulrah_Key);

        Bitmap phase2Range = new Bitmap(Properties.Resources.phase2Range);
        Bitmap phase2Mage = new Bitmap(Properties.Resources.phase2Mage);
        Bitmap phase2Melee = new Bitmap(Properties.Resources.phase2Melee);

        Bitmap range3 = new Bitmap(Properties.Resources.range3);
        Bitmap mage3 = new Bitmap(Properties.Resources.mage3);

        Bitmap mageB = new Bitmap(Properties.Resources.magicB);
        Bitmap range1B = new Bitmap(Properties.Resources.range1);
        Bitmap range2R = new Bitmap(Properties.Resources.range2B);

        Bitmap R1B = new Bitmap(Properties.Resources.R1);
        Bitmap R2B = new Bitmap(Properties.Resources.R2B);
        private void ZulrahPlugin_Click(object sender, EventArgs e)
        {
            Holder.Controls.Clear();
            MinimizeFootPrint();

            makePicturebox(zulKeyFrame, 0, 0, 400, 80, zulKey);
            makePicturebox(zulStart, 62, 190, 112, 112, zulStartPic);

            PictureBox range2 = new PictureBox();
            range2.Location = new System.Drawing.Point(62, 330);
            range2.Size = new System.Drawing.Size(112, 112);
            range2.BackgroundImage = phase2Range;
            range2.BackgroundImageLayout = ImageLayout.Stretch;
            range2.Click += range2_Click;
            Holder.Controls.Add(range2);

            PictureBox mage2 = new PictureBox();
            mage2.Location = new System.Drawing.Point(190, 330);
            mage2.Size = new System.Drawing.Size(112, 112);
            mage2.BackgroundImage = phase2Mage;
            mage2.BackgroundImageLayout = ImageLayout.Stretch;
            mage2.Click += mage2_Click;
            Holder.Controls.Add(mage2);

            PictureBox melee2 = new PictureBox();
            melee2.Location = new System.Drawing.Point(318, 330);
            melee2.Size = new System.Drawing.Size(112, 112);
            melee2.BackgroundImage = phase2Melee;
            melee2.BackgroundImageLayout = ImageLayout.Stretch;
            melee2.Click += melee2_Click;
            Holder.Controls.Add(melee2);


        }

        private void melee2_Click(object sender, EventArgs e)
        {
            Holder.Controls.Clear();
            makePicturebox(magicB, 62, 190, 112, 112, mageB);

            PictureBox range1 = new PictureBox();
            range1.Location = new System.Drawing.Point(62, 330);
            range1.Size = new System.Drawing.Size(112, 112);
            range1.BackgroundImage = range1B;
            range1.BackgroundImageLayout = ImageLayout.Stretch;
            range1.Click += range1_Click;
            Holder.Controls.Add(range1);

            PictureBox range2 = new PictureBox();
            range2.Location = new System.Drawing.Point(190, 330);
            range2.Size = new System.Drawing.Size(112, 112);
            range2.BackgroundImage = range2R;
            range2.BackgroundImageLayout = ImageLayout.Stretch;
            range2.Click += range2R_Click;
            Holder.Controls.Add(range2);
        }

        private void range2R_Click(object sender, EventArgs e)
        {
            Holder.Controls.Clear();
            makePicturebox(R2, 0, 0, 573, 80, R2B);
        }

        private void range1_Click(object sender, EventArgs e)
        {
            Holder.Controls.Clear();
            makePicturebox(R1, 0, 0, 573, 161, R1B);
        }

        private void mage2_Click(object sender, EventArgs e)
        {
            Holder.Controls.Clear();
            makePicturebox(rangePhase, 0, 0, 573, 161, mage3);
        }

        private void range2_Click(object sender, EventArgs e)
        {
            Holder.Controls.Clear();
            makePicturebox(rangePhase, 0, 0, 573, 161, range3);
        }

        private void Reddit_MouseEnter(object sender, EventArgs e)
        {
            Max(reddit);
        }

        private void Reddit_MouseLeave(object sender, EventArgs e)
        {
            Min(reddit);
        }

        private void Reddit_Click(object sender, EventArgs e)
        {
            MinimizeFootPrint();
            webAppear(redditBrowser, "https://www.reddit.com/r/2007scape/");
        }
    }
}
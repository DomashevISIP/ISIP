using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int Score = 0;

        static int Col = 8, Row = 15;

        Random RND = new Random();

        Image[] img =
        {
            global::WindowsFormsApp2.Properties.Resources.Green1,
            global::WindowsFormsApp2.Properties.Resources.Grey1,
            global::WindowsFormsApp2.Properties.Resources.Red1,
            global::WindowsFormsApp2.Properties.Resources.Yello1,
        };

        List<Point> Pretindent = new List<Point>();

        PictureBox[,] Pole = new PictureBox[Col, Row];
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Score = 0;
            panel2.Visible = true;
            CreatePole();
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void MoverDown()
        {
            
                for (int yy = 0; yy < Row; yy++)
                {
                    for (int xx = 0; xx < Col; xx++)
                    {
                        if (Pole[xx, yy].Image == null)
                        {
                             if (yy + 1 < Row)
                             {
                               Pole[xx, yy].Image = Pole[xx, yy + 1].Image;
                               Pole[xx, yy + 1].Image = null;
                             }
                             else
                             {
                              Pole[xx, yy].Image = img[RND.Next(img.Length)];
                             }
                        }
                    }
                }
            
        }

        List<Point> IndexList(Point coord)
        {
            List<Point> P = new List<Point>();

            Point T;

            //точка с лева
            if ((coord.X - 1) >= 0) { T = new Point(coord.X - 1, coord.Y); P.Add(T); }
            //точка с права 
            if ((coord.X + 1) < Col) { T = new Point(coord.X + 1, coord.Y); P.Add(T); };
            //точка с верху
            if ((coord.Y - 1) >= 0) { T = new Point(coord.X, coord.Y - 1); P.Add(T); };
            // точка с низу
            if ((coord.Y + 1) < Row) { T = new Point(coord.X, coord.Y + 1); P.Add(T); };

            return P;
        }

        void TestPole(Point coord, Image Color)
        {
            //проверяем есть ли точка в списке
            int Index = Pretindent.IndexOf(coord);
            //если точки нет в списке то проверяем
            if (Index == -1)
            {
                //проверяем того ли она цвета
                if (Pole[coord.X, coord.Y].Image == Color)
                {
                    //если она нужного цвета то добавляем ее в список
                    Pretindent.Add(coord);
                    //рассчитываем координаты для поиска далее 
                    List<Point> Test = IndexList(coord);
                    //создаем для точки набор соседей
                    foreach (Point T in Test)
                    {
                        //проверяем соседей
                        TestPole(T, Color);
                    }
                }
            }
        }

        void Click(object sender, EventArgs e)
        {
            Pretindent.Clear();

            PictureBox PicClik = sender as PictureBox;
            Image CurrentPic = PicClik.Image;


            string[] NamePars = PicClik.Name.Split('_');

            int _X_ = Convert.ToInt32(NamePars[1]);
            int _Y_ = Convert.ToInt32(NamePars[2]);

            Point I = new Point(_X_, _Y_);

           List<Point> L = IndexList(I);

            TestPole(I, CurrentPic);

            if (Pretindent.Count > 2)

                foreach (Point ClearPoint in Pretindent)
                {
                
                  Pole[ClearPoint.X, ClearPoint.Y].Image = null;

                }
                Score += Pretindent.Count;


        }

        void CreatePole()
        {
            int X = 0, Y = panel2.Height - 50;
            panel2.Controls.Clear();
            Pole = new PictureBox[Col, Row];

            for (int yy = 0; yy < Row; yy++)
            {
                X = 0;
                for (int xx = 0; xx < Col; xx++)
                {
                    PictureBox pic = new PictureBox()
                    {
                        Image = img [RND.Next(img.Length)],
                        Location = new System.Drawing.Point(X, Y),
                        Name = "_" + xx + "_" + yy,
                        Size = new System.Drawing.Size(50, 50),
                        SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage

                    };

                    pic.Click += Click;

                    panel2.Controls.Add(pic);

                    Pole[xx, yy] = pic;
                    X = X + 50;
                }
                Y = Y - 50;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoverDown();
            label2.Text = "Набраные очки " + Score;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //показываем меню игры
            panel1.Visible = true;
            //прячем игровое поле
            panel2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}

/*
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Green;
            this.pictureBox1.Location = new System.Drawing.Point(3, 482);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
*/

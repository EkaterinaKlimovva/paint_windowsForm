using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curves
{
    public partial class Form1 : Form
    {
        public List<Point> arPoints = new List<Point>(); //Координаты точки
        public List<Point> arOffsets = new List<Point>(); //Массив точек
        public Timer moveTimer = new Timer(); //Таймер для движения
        public Color ColorPoint { get; set; } = Color.Black;
        public Color ColorLine { get; set; } = Color.Black;
        public Size SizePoint { get; set; } = new Size(10, 10);
        public float Radius { get; set; } = 10;
        public int WidthLine = 10;
        public bool fPoints = true;
        public bool fDrag = false;
        public bool fMove = false;
        public int iPointToDrag;
        public enum LineType { None, Curve, Bezier, Polygone, FilledCurve };
        public LineType LineTypeToShow;

        public Form1()
        {
            InitializeComponent();

            Paint += new PaintEventHandler(Form1_Paint);
            MouseClick += new MouseEventHandler(Form1_MouseClick);
            MouseMove += new MouseEventHandler(Form1_MouseMove);
            MouseUp += new MouseEventHandler(Form1_MouseUp);
            MouseDown += new MouseEventHandler(Form1_MouseDown);
            KeyPreview = true;
            KeyDown += new KeyEventHandler(Form1_KeyDown);

            moveTimer.Interval = 10;
            moveTimer.Tick += new EventHandler(TimerTickHandler);

            btPoint.Click += new EventHandler(btPoint_Click_1);
            btParametrs.Click += new EventHandler(btParametrs_Click_1);
            btCurve.Click += new EventHandler(btCurve_Click_1);
            btPolyline.Click += new EventHandler(btPolyline_Click_1);
            btBeziers.Click += new EventHandler(btBeziers_Click_1);
            btFilled.Click += new EventHandler(btFilled_Click_1);
            btMovement.Click += new EventHandler(btMovement_Click_1);
            btClear.Click += new EventHandler(btClear_Click_1);
            btSave.Click += new EventHandler(btSave_Click);

            //Доп
            btMovement.Enabled = false;
            btPolyline.Enabled = false;
            btSave.Enabled = false;
            btClear.Enabled = false;
            btCurve.Enabled = false;
            btFilled.Enabled = false;
            btBeziers.Enabled = false;
        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (arPoints.Count > 0)
            {
                PrintPoints(g);
                if (LineTypeToShow != LineType.None)
                    PrintLine(g, LineTypeToShow);
            }
        }

        void MovePoints()
        {
            int _x, _y;
            if (fPoints)
                btPoint.PerformClick();
            for (int i = 0; i < arPoints.Count; i++)
            {
                _x = arPoints[i].X + arOffsets[i].X;
                if (_x >= this.ClientRectangle.Width || _x <= 200)
                {
                    arOffsets[i] = new Point(-arOffsets[i].X, arOffsets[i].Y);
                    _x = arPoints[i].X + arOffsets[i].X;
                }
                _y = arPoints[i].Y + arOffsets[i].Y;
                if (_y >= this.ClientRectangle.Height || _y <= 0)
                {
                    arOffsets[i] = new Point(arOffsets[i].X, -arOffsets[i].Y);
                    _y = arPoints[i].Y + arOffsets[i].Y;
                }
                arPoints[i] = new Point(_x, _y);
            }
        }

        bool IsPoint(Point pP, Point pM)
        {
            if (pM.X >= pP.X - SizePoint.Width / 2 && pM.Y <= pP.Y + SizePoint.Height / 2 && pM.X <= pP.X + SizePoint.Width / 2 && pM.Y >= pP.Y - SizePoint.Height / 2)
                return true;
            else
                return false;
        }

        void TimerTickHandler(object sender, EventArgs e)
        {
            MovePoints();
            Refresh();
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Space):
                    btMovement_Click_1(sender, e);
                    e.Handled = true;
                    break;
                case (Keys.Oemplus):
                    if (arOffsets.Count > 0)
                    {
                        int _x = 0, _y = 0;
                        for (int i = 0; i < arOffsets.Count; i++)
                        {
                            if (arOffsets[i].X > 0)
                                _x = 1;
                            if (arOffsets[i].X < 0)
                                _x = -1;
                            if (arOffsets[i].Y > 0)
                                _y = 1;
                            if (arOffsets[i].Y < 0)
                                _y = -1;
                            arOffsets[i] = new Point(arOffsets[i].X + _x, arOffsets[i].Y + _y);
                        }
                    }
                    e.Handled = true;
                    break;
                case (Keys.OemMinus):
                    if (arOffsets.Count > 0 && fMove == true)
                    {
                        int _x = 0, _y = 0;
                        for (int i = 0; i < arOffsets.Count; i++)
                        {
                            if (arOffsets[i].X > 1)
                                _x = -1;
                            if (arOffsets[i].X < -1)
                                _x = 1;
                            if (arOffsets[i].Y > 1)
                                _y = -1;
                            if (arOffsets[i].Y < -1)
                                _y = 1;
                            arOffsets[i] = new Point(arOffsets[i].X + _x, arOffsets[i].Y + _y);
                        }
                    }
                    e.Handled = true;
                    break;
                case (Keys.Escape):
                    btClear_Click_1(sender, e);
                    e.Handled = true;
                    break;
                default:
                    break;
            }

        }

        void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point p;
            if (e.X > 200)
            {
                p = e.Location;
                if (fPoints)
                {
                    arPoints.Add(p);
                    LineTypeToShow = LineType.None;
                    if (arPoints.Count == 0)
                    {
                    }
                    else
                    {
                        //Доп
                        if (arPoints.Count > 3 && (arPoints.Count - 1) % 3 == 0)
                            btBeziers.Enabled = true;
                        else
                            btBeziers.Enabled = false;

                        if (arPoints.Count > 2)
                        {
                            btFilled.Enabled = true;
                            btCurve.Enabled = true;
                        }

                        if (arPoints.Count > 1)
                            btPolyline.Enabled = true;

                        btMovement.Enabled = true;
                        btSave.Enabled = true;
                        btClear.Enabled = true;
                    }
                    Refresh();
                }
            }
        }

        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (fDrag)
            {
                arPoints[iPointToDrag] = new Point(e.Location.X, e.Location.Y);
                Refresh();
            }
        }

        void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            fDrag = false;
        }

        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < arPoints.Count; i++)
            {
                if (IsPoint(arPoints[i], e.Location))
                {
                    fDrag = true;
                    iPointToDrag = i;
                    break;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool IsHandled = true;
            switch (keyData)
            {
                case Keys.Up:
                    if (!fMove)
                    {
                        for (int i = 0; i < arPoints.Count; i++)
                        {
                            if (arPoints.Min(a => a.Y) == 0)
                                break;
                            arPoints[i] = new Point(arPoints[i].X, arPoints[i].Y - 1);
                        }
                        Refresh();
                    }
                    break;
                case Keys.Down:
                    if (!fMove)
                    {
                        for (int i = 0; i < arPoints.Count; i++)
                        {
                            if (arPoints.Max(a => a.Y) == this.ClientRectangle.Height - WidthLine)
                                break;
                            arPoints[i] = new Point(arPoints[i].X, arPoints[i].Y + 1);
                        }
                        Refresh();
                    }
                    break;
                case Keys.Left:
                    if (!fMove)
                    {
                        for (int i = 0; i < arPoints.Count; i++)
                        {
                            if (arPoints.Min(a => a.X) == 0)
                                break;
                            arPoints[i] = new Point(arPoints[i].X - 1, arPoints[i].Y);
                        }
                        Refresh();
                    }
                    break;
                case Keys.Right:
                    if (!fMove)
                    {
                        for (int i = 0; i < arPoints.Count; i++)
                        {
                            if (arPoints.Max(a => a.X) == this.ClientRectangle.Width - WidthLine)
                                break;
                            arPoints[i] = new Point(arPoints[i].X + 1, arPoints[i].Y);
                        }
                        Refresh();
                    }
                    break;
                default:
                    IsHandled = false;
                    break;
            }
            return IsHandled;
        }

        public void PrintPoints(Graphics g)
        {
            Brush br = new SolidBrush(ColorPoint);
            foreach (var c in arPoints)
                g.FillEllipse(br, c.X, c.Y, SizePoint.Width, SizePoint.Height);
        }

        public void PrintLine(Graphics g, LineType line)
        {
            SolidBrush brush = new SolidBrush(ColorLine);
            Pen pen = new Pen(brush, WidthLine);
            switch (line)
            {
                case LineType.Bezier:
                    if (arPoints.Count > 3 && (arPoints.Count - 1) % 3 == 0)
                        g.DrawBeziers(pen, arPoints.ToArray());
                    break;
                case LineType.Curve:
                    g.DrawClosedCurve(pen, arPoints.ToArray());
                    break;
                case LineType.FilledCurve:
                    g.FillClosedCurve(brush, arPoints.ToArray());
                    break;
                case LineType.Polygone:
                    g.DrawPolygon(pen, arPoints.ToArray());
                    break;
                default:
                    break;
            }
        }

        private void btPoint_Click_1(object sender, EventArgs e)
        {
            fPoints = !fPoints;
            fDrag = false;
            fMove = false;
            Refresh();
        }

        private void btParametrs_Click_1(object sender, EventArgs e)
        {
            fPoints = false;
            fDrag = false;
            fMove = false;
            Form2 form1 = new Form2(this);
            form1.Show();
        }

        private void btCurve_Click_1(object sender, EventArgs e)
        {
            btSave.Enabled = true; //Доп
            if (LineTypeToShow != LineType.Curve)
                LineTypeToShow = LineType.Curve;
            else
                LineTypeToShow = LineType.None;
            if (fPoints)
                btPoint.PerformClick();
            Refresh();
        }

        private void btPolyline_Click_1(object sender, EventArgs e)
        {
            btSave.Enabled = true; //Доп
            if (LineTypeToShow != LineType.Polygone)
                LineTypeToShow = LineType.Polygone;
            else
                LineTypeToShow = LineType.None;
            if (fPoints)
                btPoint.PerformClick();
            Refresh();
        }

        private void btBeziers_Click_1(object sender, EventArgs e)
        {
            btSave.Enabled = true; //Доп
            if (LineTypeToShow != LineType.Bezier)
                LineTypeToShow = LineType.Bezier;
            else
                LineTypeToShow = LineType.None;
            if (fPoints)
                btPoint.PerformClick();
        }

        private void btFilled_Click_1(object sender, EventArgs e)
        {
            btSave.Enabled = true; //Доп
            if (LineTypeToShow != LineType.FilledCurve)
                LineTypeToShow = LineType.FilledCurve;
            else
                LineTypeToShow = LineType.None;
            if (fPoints)
                btPoint.PerformClick();
            Refresh();
        }

        private void btMovement_Click_1(object sender, EventArgs e)
        {
            btSave.Enabled = true; //Доп

            fDrag = false;
            if (arPoints.Count == 0)
            {
                fMove = false;
            }
            else
            {
                btMovement.Enabled = true;
                fMove = !fMove;
            }

            if (fMove)
            {
                btPoint.Enabled = false;
                arOffsets = new List<Point>();
                int _x, _y;
                Random rnd = new Random((int)DateTime.Now.Ticks);
                _x = rnd.Next(1, 10);
                _y = rnd.Next(1, 10);
                for (int i = 0; i < arPoints.Count; i++)
                {
                    arOffsets.Add(new Point(_x, _y));
                }
                moveTimer.Start();
            }
            else
            {
                btPoint.Enabled = true;
                moveTimer.Stop();
            }
        }

        private void btClear_Click_1(object sender, EventArgs e)
        {
            moveTimer.Stop();
            fPoints = false;
            fDrag = false;
            fMove = false;
            arPoints.Clear();
            arOffsets.Clear();
            ColorPoint = Color.Black;
            ColorLine = Color.Black;
            LineTypeToShow = LineType.None;
            //Доп
            btMovement.Enabled = false;
            btPolyline.Enabled = false;
            btSave.Enabled = false;
            btClear.Enabled = false;
            btCurve.Enabled = false;
            btFilled.Enabled = false;
            btBeziers.Enabled = false;
            Refresh();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            moveTimer.Stop();
            fPoints = false;
            fDrag = false;
            fMove = false;
            //Доп
            btSave.Enabled = false;
            Refresh();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


//Доп
//в параметрах при закрытии по умолчанию цвет
//цвет сразу менялся
//добавить неактивность кнопок
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace VitalSigns.nView
{
    public partial class ControlView : UserControl
    {
        private Color _BackColor;
        private Color _LineColor;
        private int _DataX;
        private int _DataY;
        private Graphics _gfx;
        private Timer _dT = new Timer();
        private int _DataYTemp = 0;
        private int _OffSetX;
        private int _OffSetY;

        /// <summary>
        /// Gets or sets the background color
        /// </summary>
        public Color BackgroundColor
        {
            get { return _BackColor; }
            set { _BackColor = value; }
        }

        /// <summary>
        /// Gets or sets the line color
        /// </summary>
        public Color LineColor
        {
            get { return _LineColor; }
            set { _LineColor = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int DataX
        {
            get { return _DataX; }
            set { _DataX = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int DataY
        {
            get { return _DataY; }
            set { _DataY = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Graphics g
        {
            get { return _gfx; }
            set { _gfx = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int TimeInterval
        {
            get { return _dT.Interval; }
            set { _dT.Interval = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int OffSetX
        {
            get { return _OffSetX; }
            set { _OffSetX = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int OffSetY
        {
            get { return _OffSetY; }
            set { _OffSetY = value; }
        }

        public ControlView()
        {
            InitializeComponent();
            this._dT.Tick += new EventHandler(_dT_Tick);

            g = this.CreateGraphics();
            this.BackColor = BackgroundColor;
            //TimeInterval = 100;
            DataX = 0;
            DataY = this.Height / 2;
        }

        private void _dT_Tick(object sender, EventArgs e)
        {
            if (DataX >= this.Width)
            {
                DataX = 0;
                g.Clear(BackgroundColor);
            }
            else
            {
                DataX++;
            }

            if (_DataYTemp == 0)
                _DataYTemp = this.Height / 2;

            Point p1 = new Point(DataX, _DataYTemp);

            //if (_DataYTemp == DataY)
            //    DataX++;

            DataX++;
            DataX += OffSetX;

            DataY += OffSetY;

            Point p2 = new Point(DataX, DataY);

            _DataYTemp = DataY;
            //Point p3 = new Point(DataX + 2, this.Height / 2);
            //Point p3 = new Point(DataX + 2, DataY);


            g.DrawLine(new Pen(LineColor), p1, p2);
            //g.DrawLine(new Pen(LineColor), p2, p3);
            g.Save();
        }

        /// <summary>
        /// Starts the visualization
        /// </summary>
        public void Start()
        {
            g = this.CreateGraphics();
            _dT.Interval = TimeInterval;
            _dT.Enabled = true;
            _dT.Start();
        }

        /// <summary>
        /// Stops the visualization
        /// </summary>
        public void Stop()
        {
            _dT.Stop();
            _dT.Enabled = false;
        }

        private void nView_Load(object sender, EventArgs e)
        {

        }
    }
}

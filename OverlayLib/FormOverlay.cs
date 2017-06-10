using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPMTK;

namespace WOTK {
    #region Structs
    /*
    public struct RECT {
        public int left, top, right, bottom;
    }
    */

    /// <summary>
    /// A struct for an arc.
    /// </summary>
    public struct Arc {
        public float x, y, width, height, startAngle, sweepAngle;

        public Arc(float x, float y, float width,
            float height, float startAngle, float sweepAngle) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }
    }

    /// <summary>
    /// A struct for a closed curve.
    /// </summary>
    public struct ClosedCurve {
        public List<PointF> points;

        public ClosedCurve(List<PointF> points) {
            this.points = points;
        }
    }

    /// <summary>
    /// A struct for a curve.
    /// </summary>
    public struct Curve {
        public List<PointF> points;
        public int offset, numberOfSegments;
        public float tension;

        public Curve(List<PointF> points, int offset, int numberOfSegments,
            float tension) {
            this.points = points;
            this.offset = offset;
            this.numberOfSegments = numberOfSegments;
            this.tension = tension;
        }
    }

    /// <summary>
    /// A struct for an icon.
    /// </summary>
    public struct IconStruct {
        public Icon icon;
        public Rectangle rectangle;
        public bool isUnstretched;

        public IconStruct(Icon icon, Rectangle rectangle, bool isUnstretched) {
            this.icon = icon;
            this.rectangle = rectangle;
            this.isUnstretched = isUnstretched;
        }
    }

    /// <summary>
    /// A struct for an image.
    /// </summary>
    public struct ImageStruct {
        public Image image;
        public Rectangle rectangle;
        public bool ifUnscaled;
        public bool ifClipped;

        public ImageStruct(Image image, Rectangle rectangle,
            bool ifUnscaled, bool ifClipped) {
            this.image = image;
            this.rectangle = rectangle;
            this.ifUnscaled = ifUnscaled;
            if (ifClipped) {
                this.ifUnscaled = true;
                this.ifClipped = true;
            } else {
                this.ifClipped = false;
            }
        }
    }

    /// <summary>
    /// A struct for a pie shape.
    /// </summary>
    public struct Pie {
        public RectangleF rectangle;
        public float startAngle;
        public float sweepAngle;

        public Pie(RectangleF rectangle, float startAngle, float sweepAngle) {
            this.rectangle = rectangle;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }
    }

    /// <summary>
    /// A struct for a polygon shape.
    /// </summary>
    public struct Polygon {
        public List<PointF> points;

        public Polygon(List<PointF> points) {
            this.points = points;
        }
    }

    /// <summary>
    /// A struct for a string.
    /// </summary>
    public struct StringStruct {
        public string text;
        public Font font;
        public Brush brush;
        public PointF location;
        public StringFormat format;

        public StringStruct(string text, Font font, Brush brush,
            PointF location, StringFormat format) {
            this.text = text;
            this.font = font;
            this.brush = brush;
            this.location = location;
            this.format = format;
        }
    }
    #endregion

    /// <summary>
    /// The overlay form.
    /// </summary>
    public partial class FormOverlay : Form {
        #region Fields
        private readonly bool isBorderless;
        private readonly string WINDOW_NAME;
        private bool autoUpdate;
        private NativeMethods.RECT rect;
        private IntPtr handle;
        private Graphics graphics;
        private Pen myPen;
        #endregion

        #region Graphic Draw Fields
        List<PointF> points;
        List<RectangleF> rectangles;
        List<Arc> arcs;
        List<PointF> beziers;
        List<ClosedCurve> closedCurves;
        List<Curve> curves;
        List<RectangleF> ellipses;
        List<IconStruct> icons;
        List<ImageStruct> images;
        List<GraphicsPath> graphicsPaths;
        List<Pie> pies;
        List<Polygon> polygons;
        List<StringStruct> strings;
        #endregion

        #region Properties
        /// <summary>
        /// Checks if the form should update for every change
        /// </summary>
        public bool AutoRefresh { get => autoUpdate; set => autoUpdate = value; }

        /// <summary>
        /// This is the pen. You are free to use it whenever you wish.
        /// </summary>
        public Pen MyPen { get => myPen; set => myPen = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// The overlay's constructor.
        /// </summary>
        /// <param name="windowName">The name of the program's window</param>
        /// <param name="isBorderless">In case you want the overlay borderless</param>
        public FormOverlay(Process process, bool isBorderless = false) {
            InitializeComponent();
            // fields
            WINDOW_NAME = process.GetWindowTitle();
            handle = process.GethWnd();
            this.isBorderless = isBorderless;
            // init shapes
            points = new List<PointF>();
            rectangles = new List<RectangleF>();
            arcs = new List<Arc>();
            beziers = new List<PointF>();
            closedCurves = new List<ClosedCurve>();
            curves = new List<Curve>();
            ellipses = new List<RectangleF>();
            icons = new List<IconStruct>();
            graphicsPaths = new List<GraphicsPath>();
            pies = new List<Pie>();
            polygons = new List<Polygon>();
            strings = new List<StringStruct>();
            images = new List<ImageStruct>();
            MyPen = new Pen(Color.Red);
        }

        /// <summary>
        /// The overlay's constructor.
        /// </summary>
        /// <param name="windowName">The name of the program's window</param>
        /// <param name="pen">Your specified pen type</param>
        /// <param name="isBorderless">In case you want the overlay borderless</param>
        public FormOverlay(Process process, Pen pen, bool isBorderless = false) : 
            this(process, isBorderless) {
            MyPen = pen;
        }
        #endregion

        #region Form Control
        private void FormOverlay_Load(object sender, EventArgs e) {
            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.TopMost = true;
            if (isBorderless) {
                this.FormBorderStyle = FormBorderStyle.None;
            }

            int initialStyle = NativeMethods.GetWindowLong(this.Handle, -20);
            NativeMethods.SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
            NativeMethods.GetWindowRect(this.handle, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
            this.Top = rect.top;
            this.Left = rect.left;
        }

        private void FormOverlay_Paint(object sender, PaintEventArgs e) {
            graphics = e.Graphics;
            if (rectangles.Count != 0) graphics.DrawRectangles(MyPen, rectangles.ToArray());
            if (points.Count != 0) graphics.DrawLines(MyPen, points.ToArray());
            if (beziers.Count != 0) graphics.DrawBeziers(MyPen, beziers.ToArray());
            if (graphicsPaths.Count != 0) graphicsPaths.ForEach(graphicsPath => { graphics.DrawPath(MyPen, graphicsPath); });
            if (polygons.Count != 0) polygons.ForEach(polygon => { graphics.DrawPolygon(MyPen, polygon.points.ToArray()); });
            if (strings.Count != 0) strings.ForEach(text => {
                graphics.DrawString(text.text, text.font, text.brush, text.location);
            });
            if (pies.Count != 0) pies.ForEach(pie => {
                graphics.DrawPie(MyPen, pie.rectangle, pie.startAngle, pie.sweepAngle);
            });
            if (ellipses.Count != 0) ellipses.ForEach(ellipse => {
                graphics.DrawEllipse(MyPen, ellipse);
            });
            if (arcs.Count != 0) arcs.ForEach(arc => {
                graphics.DrawArc(MyPen, arc.x, arc.y, arc.width,
                    arc.height, arc.startAngle, arc.sweepAngle);
            });
            if (curves.Count != 0) curves.ForEach(curve => {
                graphics.DrawCurve(MyPen, curve.points.ToArray(), curve.offset,
                    curve.numberOfSegments, curve.tension);
            });
            if (closedCurves.Count != 0) closedCurves.ForEach(closedCurve => {
                graphics.DrawClosedCurve(MyPen, closedCurve.points.ToArray());
            });
            if (icons.Count != 0) icons.ForEach(icon => {
                if (icon.isUnstretched) {
                    graphics.DrawIconUnstretched(icon.icon, icon.rectangle);
                } else {
                    graphics.DrawIcon(icon.icon, icon.rectangle);
                }
            });
            if (images.Count != 0) images.ForEach(image => {
                if (image.ifClipped && image.ifUnscaled) {
                    graphics.DrawImageUnscaledAndClipped(image.image, image.rectangle);
                } else if (image.ifUnscaled) {
                    graphics.DrawImageUnscaled(image.image, image.rectangle);
                } else {
                    graphics.DrawImage(image.image, image.rectangle);
                }
            });
        }
        #endregion
        
        #region Painting Methods
        /// <summary>
        /// Refresh the overlay/form after painting.
        /// Basically, the "Update" method.
        /// </summary>
        public void RefreshForm() {
            this.Refresh();
        }

        /// <summary>
        /// Refresh the form, based on the update check.
        /// </summary>
        private void RefreshFormChecked() {
            if (autoUpdate) {
                RefreshForm();
            }
        }

        /// <summary>
        /// Adds a rectangle to the form.
        /// </summary>
        /// <param name="rectangle">The float version of Rectangle class</param>
        public void AddRectangle(RectangleF rectangle) {
            rectangles.Add(rectangle);
            RefreshFormChecked();
        }
        
        /// <summary>
        /// Adds a linear line to the form.
        /// </summary>
        /// <param name="point">The float version of Point class</param>
        public void AddLine(PointF point) {
            points.Add(point);
            RefreshFormChecked();
        }

        /// <summary>
        /// Adds an arc representing a portion of an eclipse.
        /// </summary>
        /// <param name="arc">Arc class</param>
        public void AddArc(Arc arc) {
            arcs.Add(arc);
            RefreshFormChecked();
        }


        public void AddBezier(PointF bezier) {
            beziers.Add(bezier);
            RefreshFormChecked();
        }

        public void AddClosedCurve(ClosedCurve closedCurve) {
            closedCurves.Add(closedCurve);
            RefreshFormChecked();
        }

        public void AddCurve(Curve curve) {
            curves.Add(curve);
            RefreshFormChecked();
        }

        public void AddEllipse(RectangleF ellipse) {
            ellipses.Add(ellipse);
            RefreshFormChecked();
        }

        public void AddIcon(IconStruct icon) {
            icons.Add(icon);
            RefreshFormChecked();
        }

        public void AddImage(ImageStruct image) {
            images.Add(image);
            RefreshFormChecked();
        }

        public void AddGraphicsPaths(GraphicsPath graphicsPath) {
            graphicsPaths.Add(graphicsPath);
            RefreshFormChecked();
        }

        public void AddPie(Pie pie) {
            pies.Add(pie);
            RefreshFormChecked();
        }

        /// <summary>
        /// Adds a polygon shape.
        /// </summary>
        /// <param name="polygon">Polygon class</param>
        public void AddPolygon(Polygon polygon) {
            polygons.Add(polygon);
            RefreshFormChecked();
        }

        /// <summary>
        /// Adds a string of text.
        /// </summary>
        /// <param name="text">StringStruct class</param>
        public void AddString(StringStruct text) {
            strings.Add(text);
            RefreshFormChecked();
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e) {
            IntPtr hWnd = NativeMethods.FindWindow(null, WINDOW_NAME);
            NativeMethods.RECT rect;
            NativeMethods.GetWindowRect(hWnd, out rect);
            if (rect.left == -32000) {
                // the game is minimized
                this.WindowState = FormWindowState.Minimized;
            } else {
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(rect.left + 10, rect.top + 10);
            }
        }
    }
}

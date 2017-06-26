using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WPMTK;

namespace WOTK
{
    #region Structs
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
    /// The form <see cref="Overlay"/> manipulates.
    /// </summary>
    public partial class FormOverlay : Form {
        #region Fields
        private Process process; // WINDOW_TITLE and handle have been replaced by GetWindowTitle() and GethWnd()
                                 // Also, there's a new function within Process: GetWindowRect() returns RECT
        private readonly bool isBorderless;
        private bool autoUpdate;
        private NativeMethods.RECT rect;
        private Graphics graphics;
        private Pen myPen;
        private Action<FormOverlay> update;
        #endregion

        #region Graphic Draw Fields
        internal List<PointF> points;
        internal List<RectangleF> rectangles;
        internal List<Arc> arcs;
        internal List<PointF> beziers;
        internal List<ClosedCurve> closedCurves;
        internal List<Curve> curves;
        internal List<RectangleF> ellipses;
        internal List<IconStruct> icons;
        internal List<ImageStruct> images;
        internal List<GraphicsPath> graphicsPaths;
        internal List<Pie> pies;
        internal List<Polygon> polygons;
        internal List<StringStruct> strings;
        #endregion

        #region Properties
        /// <summary>
        /// Checks if the form should update for every change.
        /// </summary>
        public bool AutoRefresh { get => autoUpdate; set => autoUpdate = value; }

        /// <summary>
        /// The <see cref="Pen"/> is used to specify fill and stroke colors, as well as more. It's a necessity to do any fancy painting.
        /// </summary>
        public Pen MyPen { get => myPen; set => myPen = value; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initialize a new Overlay.
        /// </summary>
        /// <param name="process">A <see cref="Process"/> object is required to attach the overlay to the program.</param>
        /// <param name="isBorderless">If you want the overlay visible. (Mostly used for testing)</param>
        public FormOverlay(Process process, bool isBorderless = true) {
            InitializeComponent();
            // fields
            this.process = process;
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
        /// Initialize a new Overlay.
        /// </summary>
        /// <param name="process">A <see cref="Process"/> object is required to attach the overlay to the program.</param>
        /// <param name="pen">A pen to initialize with.</param>
        /// <param name="isBorderless">If you want the overlay visible. (Mostly used for testing)</param>
        public FormOverlay(Process process, Pen pen, bool isBorderless = true) :
            this(process, isBorderless) {
            MyPen = pen;
        }

        /// <summary>
        /// Initialize a new Overlay.
        /// </summary>
        /// <param name="process">A <see cref="Process"/> object is required to attach the overlay to the program.</param>
        /// <param name="pen">A pen to initialize with.</param>
        /// <param name="update"></param>
        /// <param name="isBorderless">If you want the overlay visible. (Mostly used for testing)</param>
        public FormOverlay(Process process, Pen pen, Action<FormOverlay> update, bool isBorderless = true) :
            this(process, pen, isBorderless)
        {
            this.update = update;
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
            rect = process.GetWindowRect();
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

        private void timer1_Tick(object sender, EventArgs e) {
            //IntPtr hWnd = NativeMethods.FindWindow(null, process.GetWindowTitle());
            //NativeMethods.GetWindowRect(hWnd, out rect);
            NativeMethods.RECT rect = process.GetWindowRect();
            if (rect.left == -32000) {
                // the game is minimized
                WindowState = FormWindowState.Minimized;
            } else {
                WindowState = FormWindowState.Normal;
                //Location = new Point(rect.left + 10, rect.top + 10);
                Location = new Point(rect.left, rect.top);
            }
            update?.Invoke(this);
            rect = process.GetWindowRect();
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
            this.Top = rect.top;
            this.Left = rect.left;
        }
        #endregion

        #region Painting Methods
        /// <summary>
        /// Update the form/overlay after painting.
        /// Does not require <see cref="AutoRefresh"/> to be active.
        /// </summary>
        public void RefreshForm() {
            this.Refresh();
        }
        
        private void RefreshFormChecked() {
            if (autoUpdate) {
                RefreshForm();
            }
        }

        /// <summary>
        /// Draws a rectangle to the form.
        /// </summary>
        /// <param name="rectangle">The float version of Rectangle class</param>
        public void AddRectangle(RectangleF rectangle) {
            rectangles.Add(rectangle);
            RefreshFormChecked();
        }
        
        /// <summary>
        /// Draws a linear line to the form.
        /// </summary>
        /// <param name="point">The float version of Point class</param>
        public void AddLine(PointF point) {
            points.Add(point);
            RefreshFormChecked();
        }

        /// <summary>
        /// Draws an arc -- a portion of an eclipse.
        /// </summary>
        /// <param name="arc">Arc class</param>
        public void AddArc(Arc arc) {
            arcs.Add(arc);
            RefreshFormChecked();
        }

        /// <summary>
        /// Draws a bezier -- a complicated curving line.
        /// </summary>
        /// <param name="bezier"></param>
        public void AddBezier(PointF bezier) {
            beziers.Add(bezier);
            RefreshFormChecked();
        }

        /// <summary>
        /// Draws a closed curve.
        /// </summary>
        /// <param name="closedCurve"></param>
        public void AddClosedCurve(ClosedCurve closedCurve) {
            closedCurves.Add(closedCurve);
            RefreshFormChecked();
        }

        /// <summary>
        /// Draws a curve.
        /// </summary>
        /// <param name="curve"></param>
        public void AddCurve(Curve curve) {
            curves.Add(curve);
            RefreshFormChecked();
        }

        /// <summary>
        /// Draws an ellipse.
        /// </summary>
        /// <param name="ellipse">Ellipses use <see cref="RectangleF"/> struct like the <seealso cref="AddRectangle(RectangleF)"/> method.</param>
        public void AddEllipse(RectangleF ellipse) {
            ellipses.Add(ellipse);
            RefreshFormChecked();
        }

        /// <summary>
        /// Draws an icon.
        /// </summary>
        /// <param name="icon"></param>
        public void AddIcon(IconStruct icon) {
            icons.Add(icon);
            RefreshFormChecked();
        }

        /// <summary>
        /// Draws an image.
        /// </summary>
        /// <param name="image"></param>
        public void AddImage(ImageStruct image) {
            images.Add(image);
            RefreshFormChecked();
        }

        public void AddGraphicsPaths(GraphicsPath graphicsPath) {
            graphicsPaths.Add(graphicsPath);
            RefreshFormChecked();
        }

        /// <summary>
        /// Draws a pie.
        /// </summary>
        /// <param name="pie"></param>
        public void AddPie(Pie pie) {
            pies.Add(pie);
            RefreshFormChecked();
        }

        /// <summary>
        /// Draws a polygon shape.
        /// </summary>
        /// <param name="polygon">Polygon class</param>
        public void AddPolygon(Polygon polygon) {
            polygons.Add(polygon);
            RefreshFormChecked();
        }

        /// <summary>
        /// Draws text.
        /// </summary>
        /// <param name="text">StringStruct class</param>
        public void AddString(StringStruct text) {
            strings.Add(text);
            RefreshFormChecked();
        }
        #endregion
    }
}

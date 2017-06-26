using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTK.Templates {
    public abstract class ITemplate {
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
        internal MethodDelegate.Update update;

        public abstract void Update(int updateRate);

        public ITemplate() {
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
            update = Update;
        }

        public void AddRectangle(RectangleF rectangle) {
            rectangles.Add(rectangle);
        }

        /// <summary>
        /// Adds a linear line to the form.
        /// </summary>
        /// <param name="point">The float version of Point class</param>
        public void AddLine(PointF point) {
            points.Add(point);
        }

        /// <summary>
        /// Adds an arc representing a portion of an eclipse.
        /// </summary>
        /// <param name="arc">Arc class</param>
        public void AddArc(Arc arc) {
            arcs.Add(arc);
        }


        public void AddBezier(PointF bezier) {
            beziers.Add(bezier);
        }

        public void AddClosedCurve(ClosedCurve closedCurve) {
            closedCurves.Add(closedCurve);
        }

        public void AddCurve(Curve curve) {
            curves.Add(curve);
        }

        public void AddEllipse(RectangleF ellipse) {
            ellipses.Add(ellipse);
        }

        public void AddIcon(IconStruct icon) {
            icons.Add(icon);
        }

        public void AddImage(ImageStruct image) {
            images.Add(image);
        }

        public void AddGraphicsPaths(GraphicsPath graphicsPath) {
            graphicsPaths.Add(graphicsPath);
        }

        public void AddPie(Pie pie) {
            pies.Add(pie);
        }

        /// <summary>
        /// Adds a polygon shape.
        /// </summary>
        /// <param name="polygon">Polygon class</param>
        public void AddPolygon(Polygon polygon) {
            polygons.Add(polygon);
        }

        /// <summary>
        /// Adds a string of text.
        /// </summary>
        /// <param name="text">StringStruct class</param>
        public void AddString(StringStruct text) {
            strings.Add(text);
        }
    }
}

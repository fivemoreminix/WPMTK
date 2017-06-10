using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTK {
    enum Shapes {
        Rectangle,
        Arc,
        Bezier,
        ClosedCurve,
        Curve,
        Ellipse,
        Icon,
        Image,
        GraphicPath,
        Pie,
        Polygon,
        String
    }

    class Overlay {
        private FormOverlay formOverlay;
        private string windowName;

        public Overlay() {
            windowName = string.Empty;
            formOverlay = new FormOverlay(windowName, true);
        }

        public Overlay(string windowName) {
            this.windowName = windowName;
            formOverlay = new FormOverlay(windowName, true);
        }

        public Overlay(string windowName, bool isBorderless) {
            this.windowName = windowName;
            formOverlay = new FormOverlay(windowName, isBorderless);
        }

        public void AddShape(Shapes shape, object structData) {
            switch (shape) {
                case Shapes.Rectangle:
                    if (structData is RectangleF) {
                        formOverlay.AddRectangle((RectangleF)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Arc:
                    if (structData is Arc) {
                        formOverlay.AddArc((Arc)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Bezier:
                    if (structData is PointF) {
                        formOverlay.AddBezier((PointF)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.ClosedCurve:
                    if (structData is ClosedCurve) {
                        formOverlay.AddClosedCurve((ClosedCurve)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Curve:
                    if (structData is Curve) {

                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Ellipse:
                    if (structData is RectangleF) {

                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Icon:
                    if (structData is IconStruct) {

                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Image:
                    if (structData is ImageStruct) {

                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.GraphicPath:
                    if (structData is GraphicsPath) {

                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Pie:

                    break;
                case Shapes.Polygon:
                    break;
                case Shapes.String:
                    break;
            }
        }




    }
}

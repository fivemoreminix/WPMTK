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
        internal WPMTK.Process process;

        public Overlay(WPMTK.Process process)
        {
            this.process = process;
            formOverlay = new FormOverlay(process, true);
        }

        public Overlay(WPMTK.Process process, bool isBorderless)
        {
            this.process = process;
            formOverlay = new FormOverlay(process, isBorderless);
        }

        public void IsOverlayShown(bool overlaySwitch) {
            if (overlaySwitch) {
                formOverlay.Show();
            } else {
                formOverlay.Hide();
            }
        }
            
        #region Old Constructors
        /*
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
        */
        #endregion

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
                        formOverlay.AddCurve((Curve)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Ellipse:
                    if (structData is RectangleF) {
                        formOverlay.AddEllipse((RectangleF)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Icon:
                    if (structData is IconStruct) {
                        formOverlay.AddIcon((IconStruct)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Image:
                    if (structData is ImageStruct) {
                        formOverlay.AddImage((ImageStruct)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.GraphicPath:
                    if (structData is GraphicsPath) {
                        formOverlay.AddGraphicsPaths((GraphicsPath)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Pie:
                    if (structData is Pie) {
                        formOverlay.AddPie((Pie)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Polygon:
                    if (structData is Polygon) {
                        formOverlay.AddPolygon((Polygon)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.String:
                    if (structData is StringStruct) {
                        formOverlay.AddString((StringStruct)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
            }
        }




    }
}

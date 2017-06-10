using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTK {
    public enum Shapes {
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

    public class Overlay {
        private FormOverlay formOverlay;
        internal WPMTK.Process process;

        /// <summary>
        /// In case you want to edit the form manually, you can do it here.
        /// </summary>
        public FormOverlay FormOverlay { get => formOverlay; set => formOverlay = value; }

        public Overlay(WPMTK.Process process)
        {
            this.process = process;
            FormOverlay = new FormOverlay(process, false);
        }

        public Overlay(WPMTK.Process process, bool isBorderless)
        {
            this.process = process;
            FormOverlay = new FormOverlay(process, isBorderless);
        }

        public void IsOverlayShown(bool overlaySwitch) {
            if (overlaySwitch) {
                FormOverlay.Show();
            } else {
                FormOverlay.Hide();
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
                        FormOverlay.AddRectangle((RectangleF)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Arc:
                    if (structData is Arc) {
                        FormOverlay.AddArc((Arc)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Bezier:
                    if (structData is PointF) {
                        FormOverlay.AddBezier((PointF)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.ClosedCurve:
                    if (structData is ClosedCurve) {
                        FormOverlay.AddClosedCurve((ClosedCurve)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Curve:
                    if (structData is Curve) {
                        FormOverlay.AddCurve((Curve)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Ellipse:
                    if (structData is RectangleF) {
                        FormOverlay.AddEllipse((RectangleF)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Icon:
                    if (structData is IconStruct) {
                        FormOverlay.AddIcon((IconStruct)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Image:
                    if (structData is ImageStruct) {
                        FormOverlay.AddImage((ImageStruct)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.GraphicPath:
                    if (structData is GraphicsPath) {
                        FormOverlay.AddGraphicsPaths((GraphicsPath)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Pie:
                    if (structData is Pie) {
                        FormOverlay.AddPie((Pie)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.Polygon:
                    if (structData is Polygon) {
                        FormOverlay.AddPolygon((Polygon)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
                case Shapes.String:
                    if (structData is StringStruct) {
                        FormOverlay.AddString((StringStruct)structData);
                    } else {
                        throw new InvalidOperationException("structData object does not match the required object.");
                    }
                    break;
            }
            formOverlay.RefreshForm();
        }




    }
}

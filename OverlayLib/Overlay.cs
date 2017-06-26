using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTK {
    /// <summary>
    /// Every shape supported by the overlay.
    /// </summary>
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

    /// <summary>
    /// An Overlay object creates a FormOverlay window and draws shapes over it. You need to specify a <see cref="WPMTK.Process"/> object in the constructor.
    /// </summary>
    public class Overlay {
        private FormOverlay formOverlay;
        internal bool isLocked;
        internal WPMTK.Process process;

        /// <summary>
        /// In case you want to edit the form manually, you can do it here.
        /// </summary>
        public FormOverlay FormOverlay {
            get => !isLocked ? formOverlay : throw new InvalidOperationException("Overlay is locked from modification.");
            set { if (!isLocked) formOverlay = value; else throw new InvalidOperationException("Overlay is locked from modification."); }
        }

        /// <summary>
        /// Draw a new overlay above the specified Process's main window.
        /// </summary>
        /// <param name="process"></param>
        public Overlay(WPMTK.Process process)
        {
            this.process = process;
            FormOverlay = new FormOverlay(process, true);
        }

        /// <summary>
        /// Draw a new overlay above the specified Process's main window.
        /// </summary>
        /// <param name="process"></param>
        /// <param name="isBorderless">You can specify false to keep your overlay window from drawing borderless. (Useful for testing)</param>
        public Overlay(WPMTK.Process process, bool isBorderless)
        {
            this.process = process;
            FormOverlay = new FormOverlay(process, isBorderless);
        }

        /// <summary>
        /// After creating the overlay, you need to specify whether it's visible or not.
        /// </summary>
        /// <param name="visible"></param>
        public void IsOverlayShown(bool visible) {
            if (visible) {
                FormOverlay.Show();
            } else {
                FormOverlay.Hide();
            }
        }

        /// <summary>
        /// Draws a shape onto the overlay.
        /// </summary>
        /// <param name="shape">Shape from <see cref="Shapes"/> to define the type of supported shape.</param>
        /// <param name="shape_struct">Shape struct from <see cref="System.Drawing"/> to define the attributes of the shape. Must match the specified <see cref="Shapes"/> shape.</param>
        public void AddShape(Shapes shape, object shape_struct) {
            if (!isLocked) {
                switch (shape) {
                    case Shapes.Rectangle:
                        if (shape_struct is RectangleF) {
                            FormOverlay.AddRectangle((RectangleF)shape_struct);
                        } else {
                            throw new InvalidOperationException("structData object does not match the required object.");
                        }
                        break;
                    case Shapes.Arc:
                        if (shape_struct is Arc) {
                            FormOverlay.AddArc((Arc)shape_struct);
                        } else {
                            throw new InvalidOperationException("structData object does not match the required object.");
                        }
                        break;
                    case Shapes.Bezier:
                        if (shape_struct is PointF) {
                            FormOverlay.AddBezier((PointF)shape_struct);
                        } else {
                            throw new InvalidOperationException("structData object does not match the required object.");
                        }
                        break;
                    case Shapes.ClosedCurve:
                        if (shape_struct is ClosedCurve) {
                            FormOverlay.AddClosedCurve((ClosedCurve)shape_struct);
                        } else {
                            throw new InvalidOperationException("structData object does not match the required object.");
                        }
                        break;
                    case Shapes.Curve:
                        if (shape_struct is Curve) {
                            FormOverlay.AddCurve((Curve)shape_struct);
                        } else {
                            throw new InvalidOperationException("structData object does not match the required object.");
                        }
                        break;
                    case Shapes.Ellipse:
                        if (shape_struct is RectangleF) {
                            FormOverlay.AddEllipse((RectangleF)shape_struct);
                        } else {
                            throw new InvalidOperationException("structData object does not match the required object.");
                        }
                        break;
                    case Shapes.Icon:
                        if (shape_struct is IconStruct) {
                            FormOverlay.AddIcon((IconStruct)shape_struct);
                        } else {
                            throw new InvalidOperationException("structData object does not match the required object.");
                        }
                        break;
                    case Shapes.Image:
                        if (shape_struct is ImageStruct) {
                            FormOverlay.AddImage((ImageStruct)shape_struct);
                        } else {
                            throw new InvalidOperationException("structData object does not match the required object.");
                        }
                        break;
                    case Shapes.GraphicPath:
                        if (shape_struct is GraphicsPath) {
                            FormOverlay.AddGraphicsPaths((GraphicsPath)shape_struct);
                        } else {
                            throw new InvalidOperationException("structData object does not match the required object.");
                        }
                        break;
                    case Shapes.Pie:
                        if (shape_struct is Pie) {
                            FormOverlay.AddPie((Pie)shape_struct);
                        } else {
                            throw new InvalidOperationException("structData object does not match the required object.");
                        }
                        break;
                    case Shapes.Polygon:
                        if (shape_struct is Polygon) {
                            FormOverlay.AddPolygon((Polygon)shape_struct);
                        } else {
                            throw new InvalidOperationException("structData object does not match the required object.");
                        }
                        break;
                    case Shapes.String:
                        if (shape_struct is StringStruct) {
                            FormOverlay.AddString((StringStruct)shape_struct);
                        } else {
                            throw new InvalidOperationException("structData object does not match the required object.");
                        }
                        break;
                }
                formOverlay.RefreshForm();
            } else {
                throw new InvalidOperationException("Overlay is locked from modification.");
            }
        }
    }
}

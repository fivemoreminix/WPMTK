using System;
using System.Collections.Generic;
using System.Drawing;
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
                    }
                    break;
                case Shapes.Arc:
                    if (structData is Arc) {
                        formOverlay.AddArc((Arc)structData);
                    }
                    break;
                case Shapes.Bezier:
                    break;
                case Shapes.ClosedCurve:
                    break;
                case Shapes.Curve:
                    break;
                case Shapes.Ellipse:
                    break;
                case Shapes.Icon:
                    break;
                case Shapes.Image:
                    break;
                case Shapes.GraphicPath:
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

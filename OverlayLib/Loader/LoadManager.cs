using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOTK.Templates;

namespace WOTK.Loader {
    public static class LoadManager {
        public static void GrantManager(this Overlay overlay) {
            overlay.isLocked = true;
        }

        public static void LoadTemplate(this FormOverlay formOverlay, ITemplate template) {
            formOverlay.points = template.points;
            formOverlay.rectangles = template.rectangles;
            formOverlay.arcs = template.arcs;
            formOverlay.beziers = template.beziers;
            formOverlay.closedCurves = template.closedCurves;
            formOverlay.curves = template.curves;
            formOverlay.ellipses = template.ellipses;
            formOverlay.icons = template.icons;
            formOverlay.images = template.images;
            formOverlay.graphicsPaths = template.graphicsPaths;
            formOverlay.pies = template.pies;
            formOverlay.polygons = template.polygons;
            formOverlay.strings = template.strings;
            
        }

        public static void ImplementTemplate(this Overlay overlay, ITemplate template) {
            FormOverlay formOverlay = new FormOverlay(overlay.process);
            



        }
    }
}

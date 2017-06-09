using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOTK {
    public class Overlay {
        private List<string> text;
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



    }
}

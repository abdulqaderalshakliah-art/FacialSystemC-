using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class IconButton
    {
        public string Text { get; internal set; }
        public Size Size { get; internal set; }
        public Point Location { get; internal set; }
        public ContentAlignment TextAlign { get; internal set; }
        public object IconChar { get; internal set; }
        public int IconSize { get; internal set; }
        public Color IconColor { get; internal set; }
        public FlatStyle FlatStyle { get; internal set; }
        public Color ForeColor { get; internal set; }
        public Color BackColor { get; internal set; }
        public string Tag { get; internal set; }
        public object FlatAppearance { get; internal set; }
        public Action<object, EventArgs> Click { get; internal set; }
    }
}
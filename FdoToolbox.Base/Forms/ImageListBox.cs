#region LGPL Header
// Copyright (C) 2009, Jackie Ng
// http://code.google.com/p/fdotoolbox, jumpinjackie@gmail.com
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
// 
//
// See license.txt for more/additional licensing information
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

// Based on GListBox
//
// http://www.codeproject.com/KB/combobox/glistbox.aspx

namespace FdoToolbox.Base.Forms
{
    // ImageListBoxItem class 
    internal class ImageListBoxItem
    {
        private string _myText;
        private int _myImageIndex;
        // properties 
        public string Text
        {
            get { return _myText; }
            set { _myText = value; }
        }
        public int ImageIndex
        {
            get { return _myImageIndex; }
            set { _myImageIndex = value; }
        }
        //constructor
        public ImageListBoxItem(string text, int index)
        {
            _myText = text;
            _myImageIndex = index;
        }
        public ImageListBoxItem(string text) : this(text, -1) { }
        public ImageListBoxItem() : this("") { }

        private object _tag;

        public object Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        public override string ToString()
        {
            return _myText;
        }
    }//End of ImageListBoxItem class

    // ImageListBox class 
    internal class ImageListBox : ListBox
    {
        private ImageList _myImageList;
        public ImageList ImageList
        {
            get { return _myImageList; }
            set { _myImageList = value; }
        }
        public ImageListBox()
        {
            // Set owner draw mode
            this.DrawMode = DrawMode.OwnerDrawFixed;
        }
        protected override void OnDrawItem(System.Windows.Forms.DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            ImageListBoxItem item;
            Rectangle bounds = e.Bounds;
            Size imageSize = _myImageList.ImageSize;
            try
            {
                item = (ImageListBoxItem)Items[e.Index];
                if (item.ImageIndex != -1)
                {
                    _myImageList.Draw(e.Graphics, bounds.Left, bounds.Top, item.ImageIndex);
                    e.Graphics.DrawString(item.Text, e.Font, new SolidBrush(e.ForeColor),
                        bounds.Left + imageSize.Width, bounds.Top);
                }
                else
                {
                    e.Graphics.DrawString(item.Text, e.Font, new SolidBrush(e.ForeColor),
                        bounds.Left, bounds.Top);
                }
            }
            catch
            {
                if (e.Index != -1)
                {
                    e.Graphics.DrawString(Items[e.Index].ToString(), e.Font,
                        new SolidBrush(e.ForeColor), bounds.Left, bounds.Top);
                }
                else
                {
                    e.Graphics.DrawString(Text, e.Font, new SolidBrush(e.ForeColor),
                        bounds.Left, bounds.Top);
                }
            }
            base.OnDrawItem(e);
        }
    }//End of ImageListBox class
}

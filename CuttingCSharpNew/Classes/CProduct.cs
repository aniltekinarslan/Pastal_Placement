using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingCSharpNew.Classes
{
    class CProduct
    {
        public List<SCoord> coordList = new List<SCoord>();
        public bool rotated;
        public SCoord coord;
        public SSize size;
        public string name;
        public Color _color;
        public CProduct(string name_c, SCoord coord_c, SSize size_c, Color color_c)
        {
            name = name_c;
            coord = coord_c;
            size = size_c;
            _color = color_c;
            rotated = false;
        }

        public void Rotate()
        {
            rotated = !rotated;
            size = new SSize(size.h, size.w);
        }

        public int GetArea()
        {
            return size.h * size.w;
        }
        public int GetPerimeter()
        {
            return (size.h + size.w) * 2;
        }

        public bool intersects(CProduct that)
        {
            if (coord.x >= (that.coord.x + that.size.w)
             || that.coord.x >= (coord.x + size.w)
             || coord.y >= (that.coord.y + that.size.h)
             || that.coord.y >= (coord.y + size.h))
                return false;

            return true;
        }


        public void FillMyCoordList()
        {
            coordList.Clear();

            for (int i = coord.x; i <= coord.x + size.w; i++)
            {
                coordList.Add(new SCoord(i, coord.y));
                coordList.Add(new SCoord(i, coord.y + size.h));
            }

            for (int i = coord.y; i <= coord.y + size.h; i++)
            {
                coordList.Add(new SCoord(coord.x, i));
                coordList.Add(new SCoord(coord.x + size.w, i));
            }

            coordList = coordList.Distinct().OrderBy(c => c.x).ThenBy(c => c.y).ToList();
        }
    }
}

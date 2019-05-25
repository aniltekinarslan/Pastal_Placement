using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingCSharpNew.Classes
{
    class CCanvas
    {
        List<SCoord> willPlaceCoordList = new List<SCoord>();
        public List<CProduct> placedProducts = new List<CProduct>();
        public int w, h, totalArea, totalPlacedArea;
        public List<SCoord> edgesCoords = new List<SCoord>();

        public CCanvas(int width, int height)
        {
            w = width;
            h = height;
            totalArea = w * h;
            totalPlacedArea = 0;

            willPlaceCoordList.Add(new SCoord(0, 0));
        }

        public void PlaceProducts(List<CProduct> productList)
        {
            foreach (var p in productList)
                Place(p);
        }

        public void Place(CProduct p)
        {
            if ((totalArea - totalPlacedArea) < p.GetArea())
                return;

            int area1 = -1, area2 = -1, perimeter1 = -1, perimeter2 = -1;
            SCoord bestCoord1 = new SCoord();
            SCoord bestCoord2 = new SCoord();

            foreach (var coord in willPlaceCoordList)
            {
                p.coord = coord;

                p.Rotate();

                if (Fits(p))
                {
                    bestCoord1 = p.coord = findClosestProductXYCoord(p);

                    placedProducts.Add(p);
                    area1 = GetCurrentCanvasArea();
                    p.FillMyCoordList();
                    perimeter1 = GetProductIntersectingEdges(p);
                    placedProducts.Remove(p);
                }

                p.Rotate();

                if (Fits(p))
                {
                    bestCoord2 = p.coord = findClosestProductXYCoord(p);

                    placedProducts.Add(p);
                    area2 = GetCurrentCanvasArea();
                    p.FillMyCoordList();
                    perimeter2 = GetProductIntersectingEdges(p);
                    placedProducts.Remove(p);
                }
            }

            if (area1 == -1 && area2 == -1)
                return;

            if (area1 == area2)
            {
                if (perimeter1 == perimeter2)
                {
                    if (bestCoord1.x <= bestCoord2.x && bestCoord1.y <= bestCoord2.y)
                    {
                        p.Rotate();
                        p.coord = bestCoord1;
                    }
                    else
                        p.coord = bestCoord2;
                }
                else if ((perimeter1 > -1 && perimeter1 > perimeter2) || perimeter2 == -1)
                {
                    p.Rotate();
                    p.coord = bestCoord1;
                }
                else
                    p.coord = bestCoord2;
            }
            else
            {
                if ((area1 > -1 && area1 <= area2) || area2 == -1)
                {
                    p.Rotate();
                    p.coord = bestCoord1;
                }
                else
                    p.coord = bestCoord2;
            }

            AddToPlacedProducts(p);
        }

        public int GetCurrentCanvasArea()
        {
            int maxW = 0, maxH = 0;
            foreach (var p in placedProducts)
            {
                int curX = p.coord.x + p.size.w;
                if (curX > maxW)
                    maxW = curX;

                int curY = p.coord.y + p.size.h;
                if (curY > maxH)
                    maxH = curY;
            }

            return maxW * maxH;
        }


        public int GetProductIntersectingEdges(CProduct p)
        {
            return edgesCoords.Intersect(p.coordList).Count();
        }

        bool Fits(CProduct p)
        {
            if ((p.coord.x + p.size.w) > w)
                return false;

            if ((p.coord.y + p.size.h) > h)
                return false;

            foreach (var itr in placedProducts)
            {
                if (p.intersects(itr))
                    return false;
            }

            return true;
        }

        SCoord findClosestProductXYCoord(CProduct my)
        {
            var closestX = placedProducts.Where(pl => (my.coord.x >= (pl.coord.x + pl.size.w))
                                                                 && ((pl.coord.y + pl.size.h) >= my.coord.y
                                                                 && pl.coord.y <= (my.coord.y + my.size.h))).OrderByDescending(pa => (pa.coord.x + pa.size.w)).FirstOrDefault();
            if (closestX != null)
                my.coord.x = closestX.coord.x + closestX.size.w;



            var closestY = placedProducts.Where(pl => (my.coord.y >= (pl.coord.y + pl.size.h))
                                                   && ((pl.coord.x + pl.size.w) >= my.coord.x
                                                   && pl.coord.x <= (my.coord.x + my.size.w))).OrderByDescending(pa => (pa.coord.y + pa.size.h)).FirstOrDefault();
            if (closestY != null)
                my.coord.y = closestY.coord.y + closestY.size.h;



            return new SCoord(my.coord.x, my.coord.y);
        }

        void AddToPlacedProducts(CProduct p)
        {
            p.coord = findClosestProductXYCoord(p);
            placedProducts.Add(p);

            var c1 = new SCoord(p.coord.x + p.size.w, p.coord.y);
            var c2 = new SCoord(p.coord.x, p.coord.y + p.size.h);

            willPlaceCoordList.Remove(p.coord);
            willPlaceCoordList.Add(c1);
            willPlaceCoordList.Add(c2);
            willPlaceCoordList.Sort(CoordSort);

            totalPlacedArea += p.GetArea();

            edgesCoords.AddRange(p.coordList);
            edgesCoords = edgesCoords.Distinct().OrderBy(c => c.x).ThenBy(c => c.y).ToList();
        }

        private static int CoordSort(SCoord x, SCoord y)
        {
            if (x.y != y.y)
                return (x.y > y.y) ? -1 : 1;

            return (x.x > y.x) ? -1 : 1;
        }
        public Image ToImage()
        {
            Image canvas = new Bitmap(w, h);
            foreach (var p in placedProducts)
            {
                Bitmap b = new Bitmap(p.size.w, p.size.h);
                using (Graphics g = Graphics.FromImage(b))
                    g.Clear(p._color);

                using (TextureBrush brush = new TextureBrush(b, System.Drawing.Drawing2D.WrapMode.Tile))
                {
                    using (Graphics g = Graphics.FromImage(canvas))
                    {
                        g.FillRectangle(brush, Convert.ToSingle(p.coord.x), Convert.ToSingle(p.coord.y),
                            Convert.ToSingle(p.size.w), Convert.ToSingle(p.size.h));
                    }
                }
            }

            return canvas;
        }
    }
}

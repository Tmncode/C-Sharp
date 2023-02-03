using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilingDemo
{
    class Program
    {
        class Room
        {
            private double _floorArea;
            private int _numberBoxesRequiredToTile;

            public int Length { get; }
            public int Width { get; }


            public Room(int length, int width)
            {
                this.Length = length;
                this.Width = width;
                this._calculateFloorArea();
                this._calculateNumberBoxesTiles();
            }

            private void _calculateFloorArea()
            {
                this._floorArea = this.Length * this.Width;
            }
            private void _calculateNumberBoxesTiles()
            {
                int fullSqFtBoxes = Convert.ToInt32(this._floorArea / 12);
                int extraSqFtBox = (this._floorArea % 12 != 0) ? 1 : 0;
                this._numberBoxesRequiredToTile = fullSqFtBoxes + extraSqFtBox + 1;
            }

            public override string ToString()
            {
                return string.Format("Length: {0}\nWidth: {1}\nArea: {2}\nNumber Boxes Tiles Needed: {3}",
                    this.Length, this.Width, this._floorArea, this._numberBoxesRequiredToTile);
            }
            static void Main()
            {
                Room[] roomArr = new Room[10];
                Random ranNumGen = new Random();

                for (int i = 0; i < roomArr.Length; i++)
                {
                    roomArr[i] = new Room(ranNumGen.Next(0, 100), ranNumGen.Next(0, 100));
                }


                foreach (Room room in roomArr)
                {
                    WriteLine(room);
                }
                Read();
            }
        }
    }
}

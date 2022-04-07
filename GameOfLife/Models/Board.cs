namespace GameOfLife.Models
{
    public class Board
    {
        public int width { get; }
        public int height { get; }
        public Cell[,] items { get; set; }

        public Board(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void init()
        {
            items = new Cell[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    //items[i, j] = new Cell(DeadOrAlive());
                    items[i, j] = new Cell(false);
                }
            }

            items[2, 1] = new Cell(true);
            items[2, 2] = new Cell(true);
            items[2, 3] = new Cell(true);


            items[4, 6] = new Cell(true);
            items[4, 7] = new Cell(true);
            items[4, 8] = new Cell(true);
            items[3, 8] = new Cell(true);
            items[2, 7] = new Cell(true);
            // items[0, 1] = new Cell(true);

            iterateThroughGrid(true);
        }

        public void NextGeneration()
        {
            Cell[,] tmp_items = new Cell[width, height];


            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    tmp_items[i, j] = new Cell(items[i, j].WillExistInNextGen(countAliveNeighbourCells(i, j)));
            items = tmp_items;
        }

        private void  iterateThroughGrid(bool init)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    items[i, j].aliveNeighbours = countAliveNeighbourCells(i, j);
                }
            }
        }


        private bool DeadOrAlive()
        {
            var rand = new Random();
            return rand.Next(2) == 1 ? true : false;
        }

        private int countAliveNeighbourCells(int x, int y)
        {
            int aliveNeighbours = 0;
            for (int _x = -1; _x <= 1; _x++)
            {
                for (int _y = -1; _y <= 1; _y++)
                {
                    var tmp_x = x + _x;
                    var tmp_y = y + _y;
                    if (_y == 0 && _x == 0)
                        continue;

                    if ((tmp_x >= 0 && tmp_x < width) &&
                        (tmp_y >= 0 && tmp_y < height))
                        aliveNeighbours += items[tmp_x, tmp_y].alive ? 1 : 0;
                }
            }
            return aliveNeighbours;
        }

    }
}
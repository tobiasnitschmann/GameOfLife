namespace GameOfLife.Models
{
    public class Cell
    {
        public bool alive { get; set; }
        public int aliveNeighbours { set;  get; }

        public Cell(bool alive)
        {
            this.alive = alive;
        }


        public bool WillExistInNextGen(int aliveNeighbours)
        {
            if (this.alive)
                return existenceWhenCellIsAlive(aliveNeighbours);
            else
                return existenceWhenCellIsDead(aliveNeighbours);
        }

        private bool existenceWhenCellIsAlive(int aliveNeighbours)
        {
            switch (aliveNeighbours)
            {
                case < 2:
                    return false;
                case > 3:
                    return false;
                case 2:
                case 3:
                    return true;
            }
        }

        private bool existenceWhenCellIsDead(int aliveNeighbours)
        {
            switch (aliveNeighbours)
            {
                case 3:
                    return true;
                default:
                    return false;
            }
        }

    }
}
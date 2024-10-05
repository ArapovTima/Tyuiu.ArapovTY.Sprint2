using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ArapovTY.Sprint2.Task2.V2.Lib
{
    public class DataService : ISprint2Task2V2
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x >= 3) && (x <= 13) && (y >= 3) && (y <= 13))
            {
                res = true;
                if ((x == 3) && ((y == 4) || (y == 5) || (y == 8) || (y == 9) || (y == 10) || (y == 12) || (y == 13))) res = false;
                if ((x == 4) && ((y == 4) || (y == 5) || (y == 8) || (y == 9) || (y == 10))) res = false;
                if ((x == 5) && ((y == 7) || (y == 8) || (y == 9) || (y == 10))) res = false;
                if ((x == 6) && ((y == 3) || (y == 4) || (y == 7) || (y == 8) || (y == 9) || (y == 10))) res = false;
                if ((x == 7) && ((y == 3) || (y == 4) || (y == 7) || (y == 8) || (y == 10))) res = false;
                if ((x == 8) && ((y == 3) || (y == 4) || (y == 12) || (y == 13))) res = false;
                if ((x == 9) && ((y == 12) || (y == 13))) res = false;
                if ((x == 10) && ((y == 10) || (y == 11) || (y == 12) || (y == 13))) res = false;
                if ((x == 11) && ((y == 3) || (y == 4) || (y == 5) || (y == 6) || (y == 10) || (y == 11) || (y == 12) || (y == 13))) res = false;
                if ((x == 12) && ((y == 10) || (y == 11) || (y == 12) || (y == 13))) res = false;
                if ((x == 13) && ((y == 3) || (y == 4) || (y == 5) || (y == 9) || (y == 10) || (y == 11) || (y == 12) || (y == 13))) res = false;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}

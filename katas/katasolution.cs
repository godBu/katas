using System;
namespace katas
{
    public class katasolution
    {
        public bool kataSolution(int num)
        {
            for (int i = 1; i*i <= num; i++)
            {
                if (i * i == num)
                    return true;
            }
            return false;
        }
       
    }
}
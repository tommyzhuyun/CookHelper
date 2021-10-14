using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookHelper.Data
{
    public class Statistic
    {
        public readonly Sorting Sorting;
        public readonly Status Status;
        public int Amount { private set; get; }
        public Statistic(Sorting Sorting,Status Status)
        {
            this.Sorting = Sorting;
            this.Status = Status;
            Amount = 1;
        }

        public void CountOn()
        {
            Amount++;
        }
    }

    public enum Status
    {
        CanBuy,
        CanMission,
        CanSkill,
        CanCook,
        UnKown
    }

}

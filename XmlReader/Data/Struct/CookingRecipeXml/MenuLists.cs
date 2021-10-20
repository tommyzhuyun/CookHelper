using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookHelper.Data
{
    public class MenuLists
    {
        public MENUSOURCE m1;
        public MENUSOURCE m2;
        public MENUSOURCE m3;
        public MenuLists(MENUSOURCE[] ms)
        {
            if (ms.Length != 3)
                throw new Exception("MENUSOURCE should have 3 member");
            m1 = ms[0];
            m2 = ms[1];
            m3 = ms[2];
        }
        public MenuLists(List<MENUSOURCE> ms)
        {
            if (ms.Count > 0)
                m1 = ms[0];
            else
                m1 = null;
            if (ms.Count > 1)
                m2 = ms[1];
            else
                m2 = null;
            if (ms.Count > 2)
                m3 = ms[2];
            else
                m3 = null;
        }
        public MenuLists(MENUSOURCE ms1, MENUSOURCE ms2, MENUSOURCE ms3)
        {
            m1 = ms1;
            m2 = ms2;
            m3 = ms3;
        }

        public void Switch12()
        {
            if (m2 == null)
                return;
            MENUSOURCE d = m2;
            m2 = m1;
            m1 = d;
        }
        public void Switch23()
        {
            if (m3 == null)
                return;
            MENUSOURCE d = m3;
            m3 = m2;
            m2 = d;
        }

        public double[] Amount
        {
            get
            {
                double[] a = new double[Count];
                int sum = SumAmount;
                if (m1 != null)
                    a[0] = (double)m1.AmountInt * 100 / sum;
                if (m2 != null)
                    a[1] = (double)m2.AmountInt * 100 / sum;
                if (m3 != null)
                    a[2] = (double)m3.AmountInt * 100 / sum;
                return a;
            }
        }

        public int M1Amount
        {
            get
            {
                if (m1 != null)
                    return m1.AmountInt;
                else
                    return 0;
            }
        }

        public int M2Amount
        {
            get
            {
                if (m2 != null)
                    return m2.AmountInt;
                else
                    return 0;
            }
        }
        public int M3Amount
        {
            get
            {
                if (m3 != null)
                    return m3.AmountInt;
                else
                    return 0;
            }
        }

        public int SumAmount
        {
            get
            {
                int c = 0;
                if (m1 != null)
                    c += m1.AmountInt;
                if (m2 != null)
                    c += m2.AmountInt;
                if (m3 != null)
                    c += m3.AmountInt;
                return c;
            }
        }

        public int Count
        {
            get
            {
                int c = 0;
                if (m1 != null)
                    c++;
                if (m2 != null)
                    c++;
                if (m3 != null)
                    c++;
                return c;
            }
        }


    }
}

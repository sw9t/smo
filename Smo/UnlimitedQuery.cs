using System;

namespace SMO
{
    public class UnlimitedQuery
    {
        private static int factorial(int numb)
        {
            int res = 1;
            for (int i = numb; i > 1; i--)
            {
                res *= i;
            }
            return res;
        }
        public static double get_miu(double t_obslujivania)
        {
            return 1 / t_obslujivania;
        }
        public static double get_ro(double t_obslujivania, double lambda)
        {
            return lambda * t_obslujivania;
        }
        public static double[] get_Pi(int n_kanalov, double ro)
        {
            double[] array_P_i = new double[n_kanalov+1];
            double temp = 1;
            for (int i = 1; i <= n_kanalov; i++)
            {
                temp += Math.Pow(ro, i) / factorial(i);
            }
            double temp1 = Math.Pow(ro, n_kanalov + 1) / (factorial((int)(n_kanalov)) * (n_kanalov - ro));
            temp += temp1;
            array_P_i[0] = 1 / temp;
            for (int i = 1; i <= n_kanalov; i++)
            {
                array_P_i[i] = Math.Pow(ro, i) / factorial(i) * array_P_i[0];
            }
            return array_P_i;
        }
        public static double get_r(double[] Pi, int n_kanalov, double ro)
        {
            return (Math.Pow(ro, n_kanalov + 1) * Pi[0]) / (n_kanalov * factorial((int)n_kanalov) * Math.Pow(1 - ro / n_kanalov, 2));
        }
        public static double get_t_oj(double r, double lambda)
        {
            return r / lambda;
        }
        public static double get_t_sist(double t_oj, double t_obs)
        {
            return t_obs + t_oj;
        }

    }
}

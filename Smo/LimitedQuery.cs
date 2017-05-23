using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMO
{
    public class LimitedQuery
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
        public static double get_ro_stat(double ro, double n_kanalov)
        {
            return ro / n_kanalov;
        }
        public static double[] get_Pi(int n_kanalov, double ro, int m_kanalov)
        {
            double[] array_P_i = new double[n_kanalov + m_kanalov + 1];
            double temp = 1;
            for (int i = 1; i <= n_kanalov; i++)
            {
                temp += Math.Pow(ro, i) / factorial(i);
            }
            array_P_i[0] = 1 / temp;
            for (int i = 1; i <= n_kanalov; i++)
            {
                array_P_i[i] = Math.Pow(ro, i) / factorial(i) * array_P_i[0];
            }
            for (int i = (int)n_kanalov + 1, j = 1; i <= n_kanalov + m_kanalov; i++, j++)
            {
                array_P_i[i] = Math.Pow(ro, i) / (factorial((int)n_kanalov) * Math.Pow(n_kanalov, j)) * array_P_i[0];
            }
            return array_P_i;
        }
        public static double get_r(double[] Pi, int n_kanalov, int m_kanalov, double ro)
        {
            double r = 0;
            for (int i = (int)n_kanalov + 1, j = 1; i <= n_kanalov + m_kanalov; i++, j++)
            {
                r += j * Pi[i];
            }
            return r;
        }
        public static double get_p_oblujivania(double[] Pi, int n_kanalov, int m_kanalov)
        {
            return Pi[n_kanalov + m_kanalov];
        }
        public static double get_p_otkaza(double[] Pi, int n_kanalov, int m_kanalov)
        {
            return 1 - Pi[n_kanalov + m_kanalov];
        }
        public static double get_A(double lambda, double P_obslujivania)
        {
            return lambda * P_obslujivania;
        }
        public static double get_n_zaneatih(double A, double t_obslujivania)
        {
            return A * t_obslujivania;
        }
        public static double get_n_svobodnih(int n_kanalov, double n_zaneatih)
        {
            return n_kanalov - n_zaneatih;
        }
        public static double get_k_zaneatih(int n_kanalov, double n_zaneatih)
        {
            return n_zaneatih / n_kanalov;
        }
        public static double get_k_prostoia(double k_zaneatih)
        {
            return 1 - k_zaneatih;
        }
        public static double get_t_oj(double r, double lambda)
        {
            return r / lambda;
        }
        public static double get_t_sist(double t_oj, double t_obs, double p_obslujivania)
        {
            return t_obs * p_obslujivania + t_oj;
        }

    }
}

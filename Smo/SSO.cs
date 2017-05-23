using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smo
{
    public class SSO
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
        public static string Smo_s_otkazami(double Q, double g, double t_obslujivanie, double d, double day, double n_kanalov)
        {
            double lambda = Q / (g * day);
            double miu=1/t_obslujivanie;
            double ro = lambda * t_obslujivanie;
            double[] array_P_i = new double[20];
            double temp = 1;
            double P_otkaza, P_obsluhivania, A, N_zaneatih, N_svobodnih, K_zan, K_prost, s;
            for (int i = 1; i <= n_kanalov; i++)
            {
                temp += Math.Pow(ro, i) / factorial(i);
            }
            array_P_i[0] = 1 / temp;
            for (int i = 1; i <= n_kanalov; i++)
            {
                array_P_i[i] = Math.Pow(ro, i) / factorial(i) * array_P_i[0];
            }
            P_otkaza = array_P_i[(int)n_kanalov];
            P_obsluhivania = 1 - P_otkaza;
            A = lambda * P_obsluhivania;
            N_zaneatih = A * t_obslujivanie;
            N_svobodnih = n_kanalov - N_zaneatih;
            K_zan = N_zaneatih / n_kanalov;
            K_prost = 1 - K_zan;
            s = (g * n_kanalov) / d;
            string label=Smo_s_otkazami_label(Q, g, t_obslujivanie, d, day, n_kanalov, lambda, miu, ro, array_P_i, temp, P_otkaza, P_obsluhivania, A, N_zaneatih, N_svobodnih, K_zan, K_prost, s);

            return label;
        
        }
        public static string Smo_s_ogranicennoi_ocerediu(double lambda, double t_obslujivanie, double n_kanalov,double m_kanalov)
        {
            double ro = lambda * t_obslujivanie;
            double[] array_P_i = new double[20];
            double temp = 1;
            double t_sistema;
            double P_otkaza, P_obsluhivania, A, N_zaneatih, N_svobodnih, K_zan, K_prost, s,r=0,t_ojidania;
            for (int i = 1; i <= n_kanalov; i++)
            {
                temp += Math.Pow(ro, i) / factorial(i);
            }
            array_P_i[0] = 1 / temp;
            for (int i = 1; i <= n_kanalov; i++)
            {
                array_P_i[i] = Math.Pow(ro, i) / factorial(i) * array_P_i[0];
            }
            for (int i = (int)n_kanalov+1,j=1; i <= n_kanalov+m_kanalov; i++,j++)
            {
                array_P_i[i] = Math.Pow(ro, i) / (factorial((int)n_kanalov)*Math.Pow(n_kanalov,j) )* array_P_i[0];
            }
            P_otkaza = array_P_i[(int)(n_kanalov + m_kanalov)];
            P_obsluhivania = 1 - P_otkaza;
            A = lambda * P_obsluhivania;
            N_zaneatih = A * t_obslujivanie;
            N_svobodnih = n_kanalov - N_zaneatih;
            K_zan = N_zaneatih / n_kanalov;
            K_prost = 1 - K_zan;
            for (int i = (int)n_kanalov + 1, j = 1; i <= n_kanalov + m_kanalov; i++, j++)
            {
                r += j * array_P_i[i];
            }
            t_ojidania = r / lambda;
            t_sistema = t_ojidania + t_obslujivanie * P_obsluhivania;
            string label = Smo_s_otkazami_label(Q, g, t_obslujivanie, d, day, n_kanalov, lambda, miu, ro, array_P_i, temp, P_otkaza, P_obsluhivania, A, N_zaneatih, N_svobodnih, K_zan, K_prost, s);
            return label;
        }
        private static string Smo_s_ocerediu_label(double lambda, double t_obslujivanie, double n_kanalov,double m_kanalov,double ro,double []array_Pi,double t_sistema,double t_ojidania,double p_otkaza,double p_obsl,double A,double N_zaneatih,double N_svobodnih,double K_zan,double K_prost,double r)
        {
            string label;
            label = "Ответ:\r\nЧисло партий в день:\r\nλ=Q/(g*day)=  " + lambda.ToString();
            label += "\r\nρ=λ*t_обслуживания= " + ro.ToString();
            label += "\r\n\r\nРассмотрим СМО с отказами с числом каналов n= " + n_kanalov.ToString();
            label += "\r\nВозможные состояния системы: ";
            label += "\r\n\tX0 - все "+n_kanalov.ToString()+" каналов не работают, свободны;";  
            for (int i = 1,j=(int)n_kanalov-1; i < n_kanalov; i++,j--)
            {
                label += "\r\n\tX"+i.ToString()+" - "+i.ToString()+" каналов работают, "+j.ToString()+" каналов свободны;";  
            }
            label += "\r\n\tX" + n_kanalov.ToString() + "- все " + n_kanalov.ToString() + " каналов работают, заняты;";
            label+="\r\n\r\nНайдем вероятности состояний:";
            for (int i = 0; i <= n_kanalov; i++)
			{
                label += "\r\nP" + i.ToString() + "=" + array_P_i[i].ToString();
			}
            label += "\r\nВероятность отказа: P_отказа=P_" + n_kanalov.ToString() + "=" +P_otkaza;
            label += "\r\nВероятность обслуживания: P_обслуживания=1-Р_отказа="+P_obsluhivania+"="+Math.Round(P_obsluhivania*100)+"%";
            label += "\nНайдем абсолютную пропускную способность";
            label += "\r\nА= " + A.ToString();
            label  += "\r\nСреднее число занятых площадок";
            label  += "\r\nnз= " + N_zaneatih.ToString();
            label  += "\r\nСреднее число свободных площадок";
            label += "\r\nnсв= " + N_svobodnih.ToString();
            label  += "\r\nКоэффициенты загрузки";
            label  += "\r\nkз= " + K_zan.ToString();
            label  += "\r\nkпр= " + K_prost.ToString();
            label  += "\r\nПолезная площадь склада";
            label  += "\r\ns= " + s.ToString();

            return label;
        }
        public static string Smo_s_neogranicennoi(double lambda, double t_obslujivania, double max_oceredi_r,double n_kanalov)
        {
            string label="";
            double r;
            double ro,ro_stationar;
            double[] massP = new double[20];
            double temp = 1;
            ro = lambda * t_obslujivania;
            ro_stationar = ro / n_kanalov;            
            if (ro_stationar>=1)
	        {
	        	  return "При заданном количестве каналов не существует стационарный режим.";
	        }
            for (int i = 1; i <= n_kanalov; i++)
            {
                temp += Math.Pow(ro, i) / factorial(i);
            }
            double temp1 = Math.Pow(ro, n_kanalov + 1) / (factorial((int)(n_kanalov))*(n_kanalov-ro));
            temp += temp1;
            massP[0]=1/temp;
            for (int i = 1; i <= n_kanalov; i++)
            {
                massP[i] = Math.Pow(ro, i + 1) / factorial(i) * massP[0];
            }
            r=(Math.Pow(ro,n_kanalov+1)*massP[0])/(n_kanalov*factorial((int)n_kanalov)*Math.Pow(1-ro/n_kanalov,2));

            return label=Smo_s_neogranicennoi_label(lambda,t_obslujivania,max_oceredi_r,n_kanalov,massP,r,ro,ro_stationar,temp1);
        
        }
        private static string Smo_s_neogranicennoi_label(double lambda, double t_obslujivania, double max_oceredi_r, double n_kanalov, double[] massP, double r, double ro, double ro_stationar,double temp1)
        {
            string label;
            label = "Ответ: ";
            label += temp1.ToString();
            label += "\r\nρ=λ*t_обслуживания= " + ro.ToString();
            label += "\r\n\r\nРассмотрим СМО с неограниченной очередью, при n= " + n_kanalov.ToString();
            label += "\r\nρ_=ρ/n = " + ro_stationar.ToString();
            label += "\r\nρ_<1 следовательно стационарный режим есть";
            label += "\r\nВозможные состояния системы: ";
            label += "\r\n\tX0 - все " + n_kanalov.ToString() + " каналов не работают, свободны;";
            for (int i = 1, j = (int)n_kanalov-1; i < n_kanalov; i++, j--)
            {
                label += "\r\n\tX" + i.ToString() + " - " + i.ToString() + " каналов работают, " + j.ToString() + " каналов свободны;";
            }
            label += "\r\n\tX" + n_kanalov.ToString() + "- все " + n_kanalov.ToString() + " каналов работают,заняты;";
            for (int i = (int)n_kanalov+1; i < (int)n_kanalov+2; i++)
            {
                label += "\r\n\tX" + i.ToString() + " - " + n_kanalov.ToString() + " каналов работают, " + i.ToString() + " заявка в очереди;";
            }
            label += "\r\n\t.........................................................\r\n";

            label += "\r\n\r\nНайдем вероятности состояний:";
            for (int i = 0; i <= n_kanalov; i++)
            {
                label += "\r\nP" + i.ToString() + "=" + massP[i].ToString();
            }
            label += "\r\nВероятность отказа: P_отказа=0";
            label += "\r\nВероятность обслуживания: P_обслуживания=1";
            label += "\r\nСредняя длина очереди:r_="+r.ToString();
            label += "\nАбсолютная пропускная  способность";
            label += "\r\nА=λ=" + lambda.ToString();
            label += "\r\nСреднее число занятых касс";
            label += "\r\nnз=ρ " + ro.ToString();
            label += "\r\nСреднее число свободных касс";
            label += "\r\nn_св= " + (n_kanalov-ro).ToString();
            label += "\r\nКоэффициенты загрузки";
            label += "\r\nk_з= " + (ro/n_kanalov).ToString();
            label += "\r\nСреднее время ожидания";
            label += "\r\nt_ожидания_среднее= " + (r/lambda).ToString();
            label += "\r\nСреднее время пребывания с учетом ожидания и обслуживания";
            label+="t_системы=t_ожидания+t_обслуживания"+(r/lambda+t_obslujivania);

            return label;

        }



        private static string Smo_s_otkazami_label(double Q, double g, double t_obslujivanie, double d, double day, double n_kanalov, double lambda, double miu, double ro, double[] array_P_i, double temp,
            double P_otkaza, double P_obsluhivania, double A, double N_zaneatih, double N_svobodnih, double K_zan, double K_prost, double s)
        {
            string label;
            label = "Ответ:\r\nЧисло партий в день:\r\nλ=Q/(g*day)=  " + lambda.ToString();
            label += "\r\nρ=λ*t_обслуживания= " + ro.ToString();
            label += "\r\n\r\nРассмотрим СМО с отказами с числом каналов n= " + n_kanalov.ToString();
            label += "\r\nВозможные состояния системы: ";
            label += "\r\n\tX0 - все "+n_kanalov.ToString()+" каналов не работают, свободны;";  
            for (int i = 1,j=(int)n_kanalov-1; i < n_kanalov; i++,j--)
            {
                label += "\r\n\tX"+i.ToString()+" - "+i.ToString()+" каналов работают, "+j.ToString()+" каналов свободны;";  
            }
            label += "\r\n\tX" + n_kanalov.ToString() + "- все " + n_kanalov.ToString() + " каналов работают, заняты;";
            label+="\r\n\r\nНайдем вероятности состояний:";
            for (int i = 0; i <= n_kanalov; i++)
			{
                label += "\r\nP" + i.ToString() + "=" + array_P_i[i].ToString();
			}
            label += "\r\nВероятность отказа: P_отказа=P_" + n_kanalov.ToString() + "=" +P_otkaza;
            label += "\r\nВероятность обслуживания: P_обслуживания=1-Р_отказа="+P_obsluhivania+"="+Math.Round(P_obsluhivania*100)+"%";
            label += "\nНайдем абсолютную пропускную способность";
            label += "\r\nА= " + A.ToString();
            label  += "\r\nСреднее число занятых площадок";
            label  += "\r\nnз= " + N_zaneatih.ToString();
            label  += "\r\nСреднее число свободных площадок";
            label += "\r\nnсв= " + N_svobodnih.ToString();
            label  += "\r\nКоэффициенты загрузки";
            label  += "\r\nkз= " + K_zan.ToString();
            label  += "\r\nkпр= " + K_prost.ToString();
            label  += "\r\nПолезная площадь склада";
            label  += "\r\ns= " + s.ToString();

            return label;
        
        
        
        }
    }
}

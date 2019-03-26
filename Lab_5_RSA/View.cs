using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Lab_5_RSA
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        public static bool IsSimple(int a)
        {
            int rez = 0;
            if (a == 1) return false;
            else if(a==2) return false;
            else
            {
                if (a > 2)
                {
                    for (int i = 2; i < a; i++)
                        if (a % i == 0) rez++;
                    if (rez == 0) return true;
                    else return false;
                }
                else return false;
            } 
        }

        public static int Find_D(int m)
        {
            int d = m - 1;
            for (int i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0)) 
                {
                    d--;
                    i = 1;
                }
            return d;
        }

        public static int Find_E(int d, int m)
        {
            int e = 1;
            while (true)
            {
                if ((e * d) % m == 1 && e!=d) break;
                else e++;
            }
            return e;
        }
        static char[] alfavit = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я' };

        public static string Encryptor(string sms, long e, long n)
        {
            znach_encrypt_letter.Clear();
            string rez = "";
            for (int i = 0; i < sms.Length; i++)
            {
                if (sms[i] == ' ') { rez += " "; znach_encrypt_letter.Add(-1);}
                else
                {
                    BigInteger c;
                    int index = Array.IndexOf(alfavit, sms[i]);
                    c = new BigInteger(index);
                    c = BigInteger.Pow(c, (int)e);
                    BigInteger n_ = new BigInteger((int)n);
                    c = c % n_;
                    string end_index = c.ToString();
                    znach_encrypt_letter.Add(Convert.ToInt32(end_index));
                    rez += alfavit[Convert.ToInt32(end_index)%33];
                }
            }
            return rez;
        }

        public static string DeEncryptor(long d, long n)
        {
            string rez = "";
            BigInteger c;
            foreach (var item in znach_encrypt_letter)
            {
                if (item == -1) rez += " ";
                else
                {
                    c = new BigInteger(Convert.ToDouble(item));
                    c = BigInteger.Pow(c, (int)d);
                    BigInteger n_ = new BigInteger((int)n);
                    c = c % n_;
                    int index = Convert.ToInt32(c.ToString());
                    rez += alfavit[index].ToString();
                }
            }
            return rez;
        }

        static List<long> znach_encrypt_letter= new List<long>();
        int p, q, d, e_1, N;

        private void btn_DeEncrypt_Click(object sender, EventArgs e)
        {
            if (crypt_text_box.Text != "")
            {
                if (d != 0 && N != 0)
                {
                   Deencrypt_text= DeEncryptor(d, N);
                    End_text_box.Text = Deencrypt_text;
                }
                else MessageBox.Show("Отсутсвуют секретные ключи!", "Error :(");
            }
            else MessageBox.Show("Отсутсвует сообщение для расшифровки!", "Error :(");
        }

        string sms;
        string encrypt; string Deencrypt_text;
        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            if (sms_text_box.Text!="")
            {
                if (P_text_Box.Text != "" || Q_text_Box.Text != "")
                {
                    try
                    {
                        sms = sms_text_box.Text.ToLower();
                        p = Convert.ToInt32(P_text_Box.Text); q = Convert.ToInt32(Q_text_Box.Text);
                        if (IsSimple(p) && IsSimple(q))
                        {
                            if (p == q) throw new Exception("Введите различные значения p и q!!!");
                            N = p * q;
                            int m = (p - 1) * (q - 1);
                            d = Find_D(m);
                            D_text_Box.Text = d.ToString();
                            e_1 = Find_E(d, m);
                            E_text_box.Text = e_1.ToString();
                            N_text_box.Text = N.ToString();
                            encrypt = Encryptor(sms, e_1, N);
                            crypt_text_box.Text = encrypt;
                        }
                        else MessageBox.Show("Число P или Q не является простым", "Error :(");
                    }
                    catch
                    {
                        MessageBox.Show("Возникла ошибка, возможно вы ввели неверные значения!", "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else MessageBox.Show("Введите простые числа P и Q", "Error :(");
            }
            else MessageBox.Show("Введите смс для шифрования", "Error :(");
        }
    }
}

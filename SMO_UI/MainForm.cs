using System;
using System.Drawing;
using System.Windows.Forms;
using SMO;

namespace SMO_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        TextBox lambda_TB, Q_TB, g_TB, d_TB, t_TB, day_TB;
        NumericUpDown ChannelsNUD, PercentsNUD, QueryLengthNUD;
        CheckBox lambdaCheck;
        void CreateControlsForRejections()
        {
            DataInputGB.Controls.Clear();
            lambdaCheck = new CheckBox { Location = new Point(5, 15), Text = "Дана интенсивность потока (λ)", Size = new Size(190, 20) };
            lambdaCheck.CheckedChanged += new EventHandler(Check_CheckedChanged);
            DataInputGB.Controls.Add(lambdaCheck);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 35), Text = "Интенсивность потока (λ):", Size = new Size(190, 15) });
            lambda_TB = new TextBox { Location = new Point(5, 50), Size = new Size(190, 25) };
            lambda_TB.KeyPress += new KeyPressEventHandler(TB_KeyPress);
            DataInputGB.Controls.Add(lambda_TB);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 80), Text = "Грузооборот склада (Q):", Size = new Size(190, 15) });
            Q_TB = new TextBox { Location = new Point(5, 95), Size = new Size(190, 25) };
            Q_TB.KeyPress += new KeyPressEventHandler(TB_KeyPress);
            DataInputGB.Controls.Add(Q_TB);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 125), Text = "Средний вес груза (g):", Size = new Size(190, 15) });
            g_TB = new TextBox { Location = new Point(5, 140), Size = new Size(190, 25) };
            g_TB.KeyPress += new KeyPressEventHandler(TB_KeyPress);
            DataInputGB.Controls.Add(g_TB);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 170), Text = "Ср. нагрузка на площ. склада (d):", Size = new Size(190, 15) });
            d_TB = new TextBox { Location = new Point(5, 185), Size = new Size(190, 25) };
            d_TB.KeyPress += new KeyPressEventHandler(TB_KeyPress);
            DataInputGB.Controls.Add(d_TB);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 215), Text = "Время обслуживания (t):", Size = new Size(190, 15) });
            t_TB = new TextBox { Location = new Point(5, 230), Size = new Size(190, 25) };
            t_TB.KeyPress += new KeyPressEventHandler(TB_KeyPress);
            DataInputGB.Controls.Add(t_TB);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 260), Text = "Период для грузооборота (дни):", Size = new Size(190, 15) });
            day_TB = new TextBox { Location = new Point(5, 275), Size = new Size(190, 25), Text = "365" };
            day_TB.KeyPress += new KeyPressEventHandler(TB_KeyPress);
            DataInputGB.Controls.Add(day_TB);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 305), Text = "Количество каналов (n):", Size = new Size(190, 15) });
            ChannelsNUD = new NumericUpDown { Location = new Point(5, 320), Size = new Size(190, 25), Maximum = 100, Minimum = 1, Value = 5 };
            DataInputGB.Controls.Add(ChannelsNUD);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 350), Text = "Необх. вероятность обслуживания:", Size = new Size(190, 15) });
            PercentsNUD = new NumericUpDown { Location = new Point(5, 365), Size = new Size(190, 25), Maximum = 100, Minimum = 1, Value = 95 };
            DataInputGB.Controls.Add(PercentsNUD);

            Check_CheckedChanged(null, null);
        }
        void CreateControlsForLimitedQuery()
        {
            DataInputGB.Controls.Clear();
            DataInputGB.Controls.Add(new Label { Location = new Point(5, 15), Text = "Интенсивность потока (λ):", Size = new Size(190, 15) });
            lambda_TB = new TextBox { Location = new Point(5, 30), Size = new Size(190, 25) };
            lambda_TB.KeyPress += new KeyPressEventHandler(TB_KeyPress);
            DataInputGB.Controls.Add(lambda_TB);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 60), Text = "Вместимость предприятия (n+m):", Size = new Size(190, 15) });
            QueryLengthNUD = new NumericUpDown { Location = new Point(5, 75), Size = new Size(190, 25), Maximum = 100, Minimum = 1, Value = 10 };
            QueryLengthNUD.ValueChanged += new EventHandler(Query_ValueChanged);
            DataInputGB.Controls.Add(QueryLengthNUD);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 105), Text = "Время обслуживания (t):", Size = new Size(190, 15) });
            t_TB = new TextBox { Location = new Point(5, 120), Size = new Size(190, 25) };
            t_TB.KeyPress += new KeyPressEventHandler(TB_KeyPress);
            DataInputGB.Controls.Add(t_TB);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 150), Text = "Количество каналов (n):", Size = new Size(190, 15) });
            ChannelsNUD = new NumericUpDown { Location = new Point(5, 165), Size = new Size(190, 25), Maximum = 10, Minimum = 1, Value = 4 };
            ChannelsNUD.ValueChanged += new EventHandler(Query_ValueChanged);
            DataInputGB.Controls.Add(ChannelsNUD);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 195), Text = "Количество мест в очереди (m):", Size = new Size(190, 15) });
            g_TB = new TextBox { Location = new Point(5, 210), Size = new Size(190, 25), Enabled = false }; 
            DataInputGB.Controls.Add(g_TB);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 240), Text = "Необход. процент обслуживания:", Size = new Size(190, 15) });
            PercentsNUD = new NumericUpDown { Location = new Point(5, 255), Size = new Size(190, 25), Maximum = 100, Minimum = 1, Value = 95 };
            DataInputGB.Controls.Add(PercentsNUD);

            Query_ValueChanged(null, null);
        }
        void CreateControlsForUnlimitedQuery()
        {
            DataInputGB.Controls.Clear();
            DataInputGB.Controls.Add(new Label { Location = new Point(5, 15), Text = "Интенсивность потока (λ):", Size = new Size(190, 15) });
            lambda_TB = new TextBox { Location = new Point(5, 30), Size = new Size(190, 25) };
            lambda_TB.KeyPress += new KeyPressEventHandler(TB_KeyPress);
            DataInputGB.Controls.Add(lambda_TB);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 60), Text = "Время обслуживания (t):", Size = new Size(190, 15) });
            t_TB = new TextBox { Location = new Point(5, 75), Size = new Size(190, 25) };
            t_TB.KeyPress += new KeyPressEventHandler(TB_KeyPress);
            DataInputGB.Controls.Add(t_TB);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 105), Text = "Количество каналов (n):", Size = new Size(190, 15) });
            ChannelsNUD = new NumericUpDown { Location = new Point(5, 120), Size = new Size(190, 25), Maximum = 100, Minimum = 1, Value = 8 };
            DataInputGB.Controls.Add(ChannelsNUD);

            DataInputGB.Controls.Add(new Label { Location = new Point(5, 150), Text = "Максимальная длина очереди (r):", Size = new Size(190, 15) });
            QueryLengthNUD = new NumericUpDown { Location = new Point(5, 165), Size = new Size(190, 25), Maximum = 100, Minimum = 1, Value = 2 };
            DataInputGB.Controls.Add(QueryLengthNUD);
        }


        void SolveRejections()
        {
            double Q, g, day, lambda, d, t;
            try
            {
                Q = double.Parse(Q_TB.Text);
                g = double.Parse(g_TB.Text);
                day = double.Parse(day_TB.Text);
                if (lambdaCheck.Checked)
                {
                    lambda = double.Parse(lambda_TB.Text);
                }
                else
                {
                    lambda = Q / (g * day);
                    lambda_TB.Text = lambda.ToString();
                }
                d = double.Parse(d_TB.Text);
                t = double.Parse(t_TB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Были введены недопустимые данные. Проверьте корректность вводимых данных.",
                    "Ошибка распознавания данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int channels = (int)ChannelsNUD.Value;
            int percents = (int)PercentsNUD.Value;
            double ro = Rejections.get_ro(t, lambda);
            double[] Pi = Rejections.get_Pi(channels, ro);
            for (int i = 0; i < channels + 1; i++)
            {
                SysStatesLV.Items.Add(new ListViewItem("X" + i) { SubItems = { i + " каналов", channels - i + " каналов" } });
            }
            for (int i = 0; i < Pi.Length; i++)
            {
                SysProbabilitesLV.Items.Add(new ListViewItem("P" + i) { SubItems = { Pi[i].ToString() } });
            }
            p_otk.Text = Rejections.get_p_otkaza(Pi, channels).ToString();
            p_obs.Text = Rejections.get_p_obslujivania(double.Parse(p_otk.Text)).ToString() + " ≈ " +
                Math.Round(Rejections.get_p_obslujivania(double.Parse(p_otk.Text)) * 100) + "%";
            if (Math.Round(Rejections.get_p_obslujivania(double.Parse(p_otk.Text)) * 100) < percents)
            {
                p_obs.ForeColor = Color.DarkRed;
                AddChannelBtn.Visible = true;
            }
            else
            {
                p_obs.ForeColor = Color.Lime;
                AddChannelBtn.Visible = false;
            }
            A.Text = Rejections.get_A(lambda, Rejections.get_p_obslujivania(double.Parse(p_otk.Text))).ToString();
            nz.Text = Rejections.get_n_zaneatih(double.Parse(A.Text), t).ToString();
            ns.Text = Rejections.get_n_svobodnih(channels, double.Parse(nz.Text)).ToString();
            kz.Text = Rejections.get_k_zaneatih(channels, double.Parse(nz.Text)) + " ≈ " +
                Math.Round(Rejections.get_k_zaneatih(channels, double.Parse(nz.Text)) * 100) + "%";
            kpr.Text = Rejections.get_k_prostoia(Rejections.get_k_zaneatih(channels, double.Parse(nz.Text))) + " ≈ " +
                Math.Round(Rejections.get_k_prostoia(Rejections.get_k_zaneatih(channels, double.Parse(nz.Text))) * 100) + "%";
            t_ozh.Text = "-";
            t_ozh.Enabled = t_ozh_lbl.Enabled = false;
            t_sist.Text = "-";
            t_sist.Enabled = t_sist_lbl.Enabled = false;
            r.Text = "-";
            r.Enabled = r_lbl.Enabled = false;
            S.Text = Rejections.get_s(channels, g, d).ToString();
        }
        void SolveLimitedQuery()
        {
            double lambda, ro, t;
            int m, n = (int)ChannelsNUD.Value, query = (int)QueryLengthNUD.Value, percents = (int)PercentsNUD.Value;
            try
            {
                lambda = double.Parse(lambda_TB.Text);
                t = double.Parse(t_TB.Text);
                m = int.Parse(g_TB.Text);
                ro = LimitedQuery.get_ro(t, lambda);
            }
            catch (Exception)
            {
                MessageBox.Show("Были введены недопустимые данные. Проверьте корректность вводимых данных.",
                    "Ошибка распознавания данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double[] Pi = LimitedQuery.get_Pi(n, ro, m);
            for (int i = 0; i < n + 1; i++)
            {
                SysStatesLV.Items.Add(new ListViewItem("X" + i) { SubItems = { i + " каналов", n - i + " каналов" } });
            }
            for (int i = 1; i < m + 1; i++)
            {
                SysStatesLV.Items.Add(new ListViewItem("X" + (n + i)) { SubItems = { n + " каналов", i + " заявок в очереди" } });
            }
            for (int i = 0; i < Pi.Length; i++)
            {
                SysProbabilitesLV.Items.Add(new ListViewItem("P" + i) { SubItems = { Pi[i].ToString() } });
            }

            p_otk.Text = LimitedQuery.get_p_otkaza(Pi, n, m).ToString();
            p_obs.Text = LimitedQuery.get_p_obslujivania(Pi, n, m) + " ≈ " +
                Math.Round(LimitedQuery.get_p_obslujivania(Pi, n, m) * 100) + "%";
            A.Text = LimitedQuery.get_A(lambda, LimitedQuery.get_p_obslujivania(Pi, n, m)).ToString();
            nz.Text = LimitedQuery.get_n_zaneatih(double.Parse(A.Text), t).ToString();
            ns.Text = LimitedQuery.get_n_svobodnih(n, double.Parse(nz.Text)).ToString();
            kz.Text = LimitedQuery.get_k_zaneatih(n, double.Parse(nz.Text)) + " ≈ " +
                Math.Round(LimitedQuery.get_k_zaneatih(n, double.Parse(nz.Text)) * 100) + "%";
            kpr.Text = LimitedQuery.get_k_prostoia(LimitedQuery.get_k_zaneatih(n, double.Parse(nz.Text))) + " ≈ " +
                Math.Round(LimitedQuery.get_k_prostoia(LimitedQuery.get_k_zaneatih(n, double.Parse(nz.Text))) * 100) + "%";
            r.Text = LimitedQuery.get_r(Pi, n, m, ro).ToString();
            t_ozh.Text = LimitedQuery.get_t_oj(double.Parse(r.Text), lambda).ToString();
            t_sist.Text = LimitedQuery.get_t_sist(double.Parse(t_ozh.Text), t, 
                LimitedQuery.get_p_obslujivania(Pi, n, m)).ToString();
            if (Math.Round(LimitedQuery.get_p_obslujivania(Pi, n, m) * 100) < percents)
            {
                p_obs.ForeColor = Color.DarkRed;
                AddChannelBtn.Visible = true;
            }
            else
            {
                p_obs.ForeColor = Color.Lime;
                AddChannelBtn.Visible = false;
            }
            S.Text = "-";
            S.Enabled = S_lbl.Enabled = false;


        }
        void SolveUnlimitedQuery()
        {
            double lambda, t, ro;
            int channels = (int)ChannelsNUD.Value;
            int query = (int)QueryLengthNUD.Value;
            try
            {
                lambda = double.Parse(lambda_TB.Text);
                t = double.Parse(t_TB.Text);
                ro = UnlimitedQuery.get_ro(t, lambda);
                if ((ro / channels) >= 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("В данной системе отстутствует стационарный режим. Требуется увеличить число каналов",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Были введены недопустимые данные. Проверьте корректность вводимых данных.",
                    "Ошибка распознавания данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double[] Pi = UnlimitedQuery.get_Pi(channels, ro);
            for (int i = 0; i < channels + 1; i++)
            {
                SysStatesLV.Items.Add(new ListViewItem("X" + i) { SubItems = { i + " каналов", channels - i + " каналов" } });
            }
            SysStatesLV.Items.Add(new ListViewItem("X" + (channels + 1)) { SubItems = { channels + " каналов", "1 завяка в очереди" } });
            SysStatesLV.Items.Add(new ListViewItem("X" + (channels + 2)) { SubItems = { channels + " каналов", "2 завяки в очереди" } });
            SysStatesLV.Items.Add(new ListViewItem("...") { SubItems = { "...", "..." } });
            for (int i = 0; i < Pi.Length; i++)
            {
                SysProbabilitesLV.Items.Add(new ListViewItem("P" + i) { SubItems = { Pi[i].ToString() } });
            }
            p_otk.Text = "0 = 0%";
            p_obs.Text = "1 = 100%";
            A.Text = lambda.ToString();
            double n_z = Math.Round(ro);
            nz.Text = ro.ToString() + " ≈ " + n_z;
            ns.Text = (channels - n_z).ToString();
            kz.Text = (ro / channels).ToString() + " ≈ " + Math.Round((ro / channels) * 100) + "%";
            kpr.Text = (1 - ro / channels).ToString() + " ≈ " + Math.Round((1 - ro / channels) * 100) + "%";
            t_ozh.Text = UnlimitedQuery.get_t_oj(UnlimitedQuery.get_r(Pi, channels, ro), lambda).ToString();
            t_sist.Text = UnlimitedQuery.get_t_sist(double.Parse(t_ozh.Text), t).ToString();
            r.Text = UnlimitedQuery.get_r(Pi, channels, ro).ToString();
            if (Math.Round(UnlimitedQuery.get_r(Pi, channels, ro)) > query)
            {
                r.ForeColor = Color.DarkRed;
                AddRChannelsBtn.Visible = true;
            }
            else
            {
                r.ForeColor = Color.Lime;
                AddRChannelsBtn.Visible = false;
            }
            S.Text = "-";
            S.Enabled = S_lbl.Enabled = false;


        }

        private void SolveBtn_Click(object sender, EventArgs e)
        {
            SysStatesLV.Items.Clear();
            SysProbabilitesLV.Items.Clear();
            p_obs.ForeColor = r.ForeColor = SystemColors.ControlText;
            t_ozh_lbl.Enabled = t_ozh.Enabled = t_sist_lbl.Enabled = t_sist_lbl.Enabled = 
            r_lbl.Enabled = r.Enabled =  S_lbl.Enabled = S.Enabled = true;
            AddChannelBtn.Visible = AddRChannelsBtn.Visible = false;
            switch (TypeSelectCB.SelectedIndex)
            {
                case 0: SolveRejections(); break;
                case 1: SolveLimitedQuery(); break;
                case 2: SolveUnlimitedQuery(); break;
                default: break;
            }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            DataInputGB.Controls.Clear();
            SysStatesLV.Items.Clear();
            SysProbabilitesLV.Items.Clear(); 
            p_otk.Text = p_obs.Text = A.Text = nz.Text = ns.Text = kz.Text = 
                kpr.Text = r.Text = t_ozh.Text = t_sist.Text = S.Text = "";
            S.Enabled = S_lbl.Enabled = 
            r.Enabled = r_lbl.Enabled = 
            t_ozh.Enabled = t_ozh_lbl.Enabled = 
            t_sist.Enabled = t_sist_lbl.Enabled = true;
            p_obs.ForeColor = r.ForeColor = SystemColors.ControlText;
            AddChannelBtn.Visible = AddRChannelsBtn.Visible = false;
        }

        private void TypeSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TypeSelectCB.SelectedIndex)
            {
                case 0: CreateControlsForRejections(); break;
                case 1: CreateControlsForLimitedQuery(); break;
                case 2: CreateControlsForUnlimitedQuery(); break;
                default: break;
            }
        }
        private void Query_ValueChanged(object sender, EventArgs e)
        {
            ChannelsNUD.Maximum = QueryLengthNUD.Value;
            g_TB.Text = (ChannelsNUD.Maximum - ChannelsNUD.Value).ToString();
        }
        private void TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (!Char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == ',' || e.KeyChar == '-' || e.KeyChar == 8) e.Handled = false;
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(",")) e.Handled = true;
            if (e.KeyChar == '-' && (sender as TextBox).Text.Contains("-")) e.Handled = true;
        }
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            if (lambdaCheck.Checked)
            {
                lambda_TB.Enabled = true;
                Q_TB.Enabled = g_TB.Enabled = day_TB.Enabled = false;
            }
            else
            {
                lambda_TB.Enabled = false;
                Q_TB.Enabled = g_TB.Enabled = day_TB.Enabled = true;
            }
        }
        private void сМОСОтказамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeSelectCB.SelectedIndex = 0;
            сМОСОграниченнойОчередьюToolStripMenuItem.Checked =
                сМОСНеограниченнойОчередьюToolStripMenuItem.Checked =
                false;
        }
        private void сМОСОграниченнойОчередьюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeSelectCB.SelectedIndex = 1;
            сМОСОтказамиToolStripMenuItem.Checked =
                сМОСНеограниченнойОчередьюToolStripMenuItem.Checked =
                false;
        }
        private void сМОСНеограниченнойОчередьюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeSelectCB.SelectedIndex = 2;
            сМОСОтказамиToolStripMenuItem.Checked =
                сМОСОграниченнойОчередьюToolStripMenuItem.Checked =
                false;
        }
        private void AddChannelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ChannelsNUD.Value++;
                SolveBtn.PerformClick();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

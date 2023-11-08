using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            string strOrder = " ";
            lblOrder.Text = " ";

            if (ckbSoon.Checked == true)
                strOrder += ckbSoon.Text + "\n";

            if (ckbPasta.Checked == true)
                strOrder += ckbPasta.Text + "\n";

            if (ckbSteak.Checked == true)
                strOrder += ckbSteak.Text + "\n";

            if (ckbTang.Checked == true)
                strOrder += (ckbTang.Text + "\n");

            if (ckbNudle.Checked == true)
                strOrder += (ckbNudle.Text + "\n");

            if (ckbRice.Checked == true)
                strOrder += (ckbRice.Text + "\n");

            lblOrder.Text = strOrder + "메뉴를 요청하였습니다";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;

            if (ckbSoon.Checked == true)

                a += int.Parse(label2.Text);

            if (ckbPasta.Checked == true)
                a += int.Parse(label3.Text);

            if (ckbSteak.Checked == true)
                a += int.Parse(label4.Text);

            if (ckbTang.Checked == true)
                a += int.Parse(label5.Text);

            if (ckbNudle.Checked == true)
                a += int.Parse(label6.Text);
            if (ckbRice.Checked == true)
                a += int.Parse(label7.Text);

            if (rdCoke.Checked != false || rdJuice.Checked != false || rdSprite.Checked != false || rdX.Checked != false)
            {
                button2_Click(this, e);
                textBox1.Text = a.ToString();
            }
            else
            {
                MessageBox.Show("음료 미선택");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ckbSoon.Checked = false;
            ckbPasta.Checked = false;
            ckbSteak.Checked = false;
            ckbTang.Checked = false;
            ckbNudle.Checked = false;
            ckbRice.Checked = false;
            textBox1.Text = " ";    //  " "는string.Empty와 같음
            lblOrder.Text = string.Empty;   //" "; 와 같음
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (radioAgree.Checked == true)
                MessageBox.Show("개인정보에 동의 하셨습니다.");
            else
                MessageBox.Show("개인정보에 동의 하지 않으셨습니다.");
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            string strText = textBox2.Text + "\n라고 요구사항이 접수되었습니다.";
            MessageBox.Show(strText);
        }

        private void btnEnter1_Click(object sender, EventArgs e)
        {
            if (radioAgree1.Checked == true)
                MessageBox.Show("회원가입에 동의 하셨습니다.");

            else
                MessageBox.Show("회원가입에 동의 하지 않으셨습니다.");
        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPayInfo.Items.Clear();

            if (cbPay.SelectedIndex == 0)
            {
                lbPayInfo.Items.Add("일시불");
                lbPayInfo.Items.Add("3개월 할부");
                lbPayInfo.Items.Add("6개월 할부");
            }

            else if (cbPay.SelectedIndex == 1)
            {
                lbPayInfo.Items.Add("k은행");
                lbPayInfo.Items.Add("n은행");
                lbPayInfo.Items.Add("s은행");
            }

            else if (cbPay.SelectedIndex == 2)
            {
                lbPayInfo.Items.Add("N포인트");
                lbPayInfo.Items.Add("해피포인트");
                lbPayInfo.Items.Add("주유포인트");
            }


        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cbPay.Text == "" || lbPayInfo.Text == "")
            {
                MessageBox.Show("결재방법 및 정보를 다시 확인해 주세요.");
                return;
            }

            string str = cbPay.Text + "(으)로" + lbPayInfo.Text + "결재방법을" + "\n선택하셨습니다.";
            MessageBox.Show(str);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdCoke.Checked == true)
            {
                MessageBox.Show("콜라를 선택했습니다.");
            }

            else if (rdSprite.Checked == true)
            {
                MessageBox.Show("사이다를 선택했습니다.");
            }

            else if (rdJuice.Checked == true)
            {
                MessageBox.Show("쥬스를 선택했습니다.");
            }

            else if (rdX.Checked == true)
            {
                MessageBox.Show("음료 선택 안함.");
            }

            else
            {
                MessageBox.Show("체크 하지 않았습니다 창을 닫습니다.");
            }
        }
    }
}

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        List<DomainUpDown> domainUpDownList = new List<DomainUpDown>();
        //새로 메뉴를 추가하고 삭제 할 때마다 관리를 위한 배열리스트
        List<NumericUpDown> numericUpDownList = new List<NumericUpDown>();
        //새로 메뉴를 추가 할 때 메뉴의 수량을 정하는 객체의 배열
        int y = 30;
        //새로 만드는 객체의 로케이션을 정하기위한 변수
        int cnt = 0;
        //배열의 인덱스 또는 배열의 개수 
        string strOrder = " ";
        //메뉴 계산서
        public Form2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //요구 사항 이벤트
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            string strText = textBox1.Text + "\n라고 요구사항이 접수되었습니다.";
            MessageBox.Show(strText);
        }
        //폼에서 배열의 마지막에 있는 객체 지우기
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Controls.Remove(domainUpDownList[cnt - 1]);
            Controls.Remove(numericUpDownList[cnt - 1]);
            cnt--;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //결제 이벤트
        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbPay.Items.Clear();

            if (cbPay.SelectedIndex == 0)
            {
                listbPay.Items.Add(" 일시불 ");
                listbPay.Items.Add(" 3개월 할부 ");
                listbPay.Items.Add(" 6개월 할부 ");
            }

            else if (cbPay.SelectedIndex == 1)
            {
                listbPay.Items.Add(" K은행 ");
                listbPay.Items.Add(" S은행 ");
                listbPay.Items.Add(" W은행 ");

            }

            else if (cbPay.SelectedIndex == 2)
            {
                listbPay.Items.Add(" N포인트 ");
                listbPay.Items.Add(" 해피포인트 ");
                listbPay.Items.Add(" L포인트 ");

            }

            else if (cbPay.SelectedIndex == 3)
            {
                listbPay.Items.Add(" N페이 ");
                listbPay.Items.Add(" A페이 ");
                listbPay.Items.Add(" S페이 ");
            }

        }
        //결제 이벤트
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cbPay.Text == "" || listbPay.Text == "")
            {
                MessageBox.Show("결재방법 및 정보를 다시 확인해 주세요.");
                return;
            }

            string str = cbPay.Text + "(으)로" + listbPay.Text + "결재방법을" + "\n선택하셨습니다.";
            MessageBox.Show(str);
        }
        //메뉴 계산서 띄우기 이벤트
        private void btnEvent_Click(object sender, EventArgs e)
        {
            lblOrder.Text = " ";
            for (int i = 0; i < domainUpDownList.Count; i++)
            {
                strOrder += domainUpDownList[i].Text + "는(은) " + numericUpDownList[i].Text + "개 주문되었습니다.\n";
            }
            lblOrder.Text = strOrder + "\n메뉴를 요청하였습니다.";
        }
        //메뉴 추가 이벤트
        private void button8_Click(object sender, EventArgs e)
        {
            DomainUpDown a = new DomainUpDown();
            //배열에 넣기 위한 새로운 객체 생성
            NumericUpDown b = new NumericUpDown();
            //배열에 넣기 위한 새로운 객체 생성

            for (int i = 0; i < domainUpDown1.Items.Count; i++)
            {
                a.Items.Add(domainUpDown1.Items[i]);
                //숨겨놓은 데이터 박스에서 데이터 가져오기
            }
            a.Text = "탕수육";
            a.Location = new System.Drawing.Point(559, 52 + y);
            b.Location = new System.Drawing.Point(692, 52 + y);
            //각 객체의 위치조정
            y += 30;

            domainUpDownList.Add(a);
            numericUpDownList.Add(b);
            //각 객체를 배열에 삽입
            cnt++;

            for (int i = 0; i < domainUpDownList.Count; i++)
            {
                Controls.Add(domainUpDownList[i]);
                Controls.Add(numericUpDownList[i]);
                //폼에 각 배열의 있는 객체 그리기 
            }

            //textBox2.Text += (int.Parse(//textBox2.Text)+(int.Parse(label16.Text) * int.Parse(numericUpDownList[0].Text))).ToString();
        }
        //이하 메뉴 추가 이벤트
        private void button7_Click(object sender, EventArgs e)
        {
            DomainUpDown a = new DomainUpDown();
            NumericUpDown b = new NumericUpDown();


            for (int i = 0; i < domainUpDown1.Items.Count; i++)
            {
                a.Items.Add(domainUpDown1.Items[i]);
            }
            a.Text = "깐풍기";
            a.Location = new System.Drawing.Point(559, 52 + y);
            b.Location = new System.Drawing.Point(692, 52 + y);

            y += 30;

            domainUpDownList.Add(a);
            numericUpDownList.Add(b);
            cnt++;

            for (int i = 0; i < domainUpDownList.Count; i++)
            {
                Controls.Add(domainUpDownList[i]);
                Controls.Add(numericUpDownList[i]);
            }

            //textBox2.Text += (int.Parse(//textBox2.Text) + (int.Parse(label24.Text) * int.Parse(numericUpDownList[1].Text))).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DomainUpDown a = new DomainUpDown();
            NumericUpDown b = new NumericUpDown();


            for (int i = 0; i < domainUpDown1.Items.Count; i++)
            {
                a.Items.Add(domainUpDown1.Items[i]);
            }
            a.Text = "팔보채";
            a.Location = new System.Drawing.Point(559, 52 + y);
            b.Location = new System.Drawing.Point(692, 52 + y);

            y += 30;

            domainUpDownList.Add(a);
            numericUpDownList.Add(b);
            cnt++;

            for (int i = 0; i < domainUpDownList.Count; i++)
            {
                Controls.Add(domainUpDownList[i]);
                Controls.Add(numericUpDownList[i]);
            }

            //textBox2.Text += (int.Parse(//textBox2.Text) + (int.Parse(label22.Text) * int.Parse(numericUpDownList[2].Text))).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DomainUpDown a = new DomainUpDown();
            NumericUpDown b = new NumericUpDown();


            for (int i = 0; i < domainUpDown1.Items.Count; i++)
            {
                a.Items.Add(domainUpDown1.Items[i]);
            }
            a.Text = "깐쇼새우";
            a.Location = new System.Drawing.Point(559, 52 + y);
            b.Location = new System.Drawing.Point(692, 52 + y);

            y += 30;

            domainUpDownList.Add(a);
            numericUpDownList.Add(b);
            cnt++;

            for (int i = 0; i < domainUpDownList.Count; i++)
            {
                Controls.Add(domainUpDownList[i]);
                Controls.Add(numericUpDownList[i]);
            }
            //textBox2.Text += (int.Parse(//textBox2.Text) + (int.Parse(label23.Text) * int.Parse(numericUpDownList[3].Text))).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DomainUpDown a = new DomainUpDown();
            NumericUpDown b = new NumericUpDown();


            for (int i = 0; i < domainUpDown1.Items.Count; i++)
            {
                a.Items.Add(domainUpDown1.Items[i]);
            }
            a.Text = "양장피";
            a.Location = new System.Drawing.Point(559, 52 + y);
            b.Location = new System.Drawing.Point(692, 52 + y);

            y += 30;

            domainUpDownList.Add(a);
            numericUpDownList.Add(b);
            cnt++;

            for (int i = 0; i < domainUpDownList.Count; i++)
            {
                Controls.Add(domainUpDownList[i]);
                Controls.Add(numericUpDownList[i]);
            }
    //textBox2.Text += (int.Parse(//textBox2.Text) + (int.Parse(label20.Text) * int.Parse(numericUpDownList[4].Text))).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DomainUpDown a = new DomainUpDown();
            NumericUpDown b = new NumericUpDown();


            for (int i = 0; i < domainUpDown1.Items.Count; i++)
            {
                a.Items.Add(domainUpDown1.Items[i]);
            }
            a.Text = "자장면";
            a.Location = new System.Drawing.Point(559, 52 + y);
            b.Location = new System.Drawing.Point(692, 52 + y);

            y += 30;

            domainUpDownList.Add(a);
            numericUpDownList.Add(b);
            cnt++;

            for (int i = 0; i < domainUpDownList.Count; i++)
            {
                Controls.Add(domainUpDownList[i]);
                Controls.Add(numericUpDownList[i]);
            }

            //textBox2.Text += (int.Parse(//textBox2.Text) + (int.Parse(label14.Text) * int.Parse(numericUpDownList[5].Text))).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DomainUpDown a = new DomainUpDown();
            NumericUpDown b = new NumericUpDown();


            for (int i = 0; i < domainUpDown1.Items.Count; i++)
            {
                a.Items.Add(domainUpDown1.Items[i]);
            }
            a.Text = "짬뽕";
            a.Location = new System.Drawing.Point(559, 52 + y);
            b.Location = new System.Drawing.Point(692, 52 + y);

            y += 30;

            domainUpDownList.Add(a);
            numericUpDownList.Add(b);
            cnt++;

            for (int i = 0; i < domainUpDownList.Count; i++)
            {
                Controls.Add(domainUpDownList[i]);
                Controls.Add(numericUpDownList[i]);
            }

            //textBox2.Text += (int.Parse(//textBox2.Text) + (int.Parse(label4.Text) * int.Parse(numericUpDownList[6].Text))).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DomainUpDown a = new DomainUpDown();
            NumericUpDown b = new NumericUpDown();


            for (int i = 0; i < domainUpDown1.Items.Count; i++)
            {
                a.Items.Add(domainUpDown1.Items[i]);
            }
            a.Text = "볶음밥";
            a.Location = new System.Drawing.Point(559, 52 + y);
            b.Location = new System.Drawing.Point(692, 52 + y);

            y += 30;

            domainUpDownList.Add(a);
            numericUpDownList.Add(b);
            cnt++;

            for (int i = 0; i < domainUpDownList.Count; i++)
            {
                Controls.Add(domainUpDownList[i]);
                Controls.Add(numericUpDownList[i]);
            }

            //textBox2.Text += (int.Parse(//textBox2.Text) + (int.Parse(label1.Text) * int.Parse(numericUpDownList[7].Text))).ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DomainUpDown a = new DomainUpDown();
            NumericUpDown b = new NumericUpDown();


            for (int i = 0; i < domainUpDown1.Items.Count; i++)
            {
                a.Items.Add(domainUpDown1.Items[i]);
            }
            a.Text = "콜라";
            a.Location = new System.Drawing.Point(559, 52 + y);
            b.Location = new System.Drawing.Point(692, 52 + y);

            y += 30;

            domainUpDownList.Add(a);
            numericUpDownList.Add(b);
            cnt++;

            for (int i = 0; i < domainUpDownList.Count; i++)
            {
                Controls.Add(domainUpDownList[i]);
                Controls.Add(numericUpDownList[i]);
            }

            //textBox2.Text += (int.Parse(//textBox2.Text) + (int.Parse(label25.Text) * int.Parse(numericUpDownList[8].Text))).ToString();
        }
    }
}

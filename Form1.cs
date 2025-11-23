using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Struct
{
    public partial class Form1 : Form
    {
        private BindingList<Student> _student = new BindingList<Student>;

        public Form1()
        {
            InitializeComponent();
        }

        private int InputScore(string text)
        {
            int value;
            if (!int.TryParse(text, out value))
            { 
                throw new ??? // FormatException 발생시켜서 "점수는 숫자이어야 합니다"
            }

            if (value < 0 || value > 100)
            {
                throw new InvalidScoreException("점수는 0~100 사이이어야 합니다");
            }

            return value;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string name ???
                string korStr ???
                string engStr ???
                string mathStr ???

                if (string.IsNullOrWhiteSpace(id))
                {
                    throw new FormatException("ID를 바르게 입력하세요.");
                }
                // 이름, 국어점수, 영어점수, 수학점수 : 값이 입력이 되었는지 체크, 아니면 예외처리 FormatException
                if (???)
                {
                    ???
                }
                if (???)
                {
                    ???
                }
                if (???)
                {
                    ???
                }
                if (???)
                {
                    ???
                }

                int kor = InputScore(korStr);
                int eng = InputScore(engStr);
                int math = InputScore(mathStr);

                // 1번째 학생 값을 입력받은 후에 stu 를 새로 생성 => TotalCount = 0;
                // 2번째 학생 값을 입력받은 후에 stu 를 새로 생성 => TotalCount = 0;
                Student stu = new Student();  // 제대로 수정
                // 데이터그리드뷰에 학생 추가 : 강사 제공
                _student.Add(stu);

                // 총학생수 lblTot 값을 입력한 학생의 수로 업데이트
                // ??? 를 Student class 에서 필드(변수)로 선언
                stu.TotalCount++;   // 1, 1
                lblTot.Text = stu.TotalCount.ToString();

                ClearInputs();
            }
            // 각 예외상황에서 전달받은 string 메세지를 Messagebox 로 보여줌
            catch (FormatException ex)
            {
                ???
            }
            catch (InvalidScoreException ex)
            {
                ???
            }
        }

        // 모든 텍스트박스의 내용을 초기화
        private void ClearInputs() 
        {
            ???
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WinForm_Struct
{
    public struct Score
    {
        public int Kor;
        public int Eng;
        public int Math;

        public Score(int k, int e, int m)
        {
            Kor = k;
            Eng = e;
            Math = m;
        }

        // 아래 메서드는 모두 람다식으로 변형
        public int Total() => Kor + Eng + Math;

        public double Avg() => Total() / 3.0;
    }

    public interface IPerson
    {
        string GetInfo();
    }

    public class Person : IPerson
    { 
        public string Id { get; set; }
        public string Name { get; set; }

        public Person(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public virtual string GetInfo()
        { 
            return $"ID : {Id}, 이름: {Name}";
        }
    }

    public class Student : Person 
    { 
        public Score Score { get; set; }
        // 변수 : 총 학생수 저장
        public static int TotalCount = 0;  // 수정해야 총 학생수로 동작함

        public Student(string id, string name, int kor, int eng, int math) : base(id, name)
        {
            Score = new Score(kor, eng, math);
        }

        public override string GetInfo()
        {
            return $"";     // ID, 이름, 총점, 평균
        }
    }
}

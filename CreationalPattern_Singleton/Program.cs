using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Singleton 패턴
 * - 카테고리 : 생성 패턴 (Creational Pattern)
 * - 개요 : Singleton 디자인 패턴은 하나의 클래스가 단지 하나의 인스턴스만 갖도록 제한하고, 전역 범위에서 그 인스턴스를 엑세르할 수 있게 하는 패턴이다. 
 *          이 패턴은 시스템 전체에 걸쳐 하나의 인스턴스가 모든 처리를 조율해야 하는 곳에 유용하다.
 * - GoF : "Ensure a class only has one instance, and provide a global point of access to it."
 */
namespace CreationalPattern_Singleton
{
    /* 라이브러리 :  Singleton */
    public sealed class Singleton
    {
        // private 생성자를 호출해서 하나의 인스턴스 생성
        // 인스턴스를 생성함과 동시에 생성된 인스턴스를 외부에서 엑세스할 수 있게 Instance 필드를 public으로 선언.
        public static readonly Singleton Instance = new Singleton();

        // 다른 외부 클래스가 사용할 수 없도록
        // 생성자를 private로 설정
        private Singleton()
        {

        }

        public void Method()
        {
            Console.WriteLine("...");
        }
    }

    /* 메인 */
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Method();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.net
{
    class Rxnet8
    {
        static void Main(string[] args)
        {
            BehaviorSubjectExample();
            Console.Read();
        }
        public static void BehaviorSubjectExample()
        {
            var subject = new BehaviorSubject<string>("a");
            subject.OnNext("b");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("c");
            subject.OnNext("d");
        }
    }
}

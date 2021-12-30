using System;

namespace Modul_3_HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            var b = new B();

            b.ShowHandler = Show;
            b.ShowHandler(a.Calc(b.Pow, 2, 3).Invoke(2));
        }

        private static void Show(bool res)
        {
            Console.WriteLine(res);
        }
    }

    public class A
    {
        private double _powResult;
        private bool _isResult;

        public Predicate<double> Calc(Func<double, double, double> powHandler, double x, double y)
        {
            _powResult = powHandler(x, y);
            Predicate<double> calcDelega=Res;
            return calcDelega;
        }

        private bool Res(double x)
        {
            return this._powResult % x == 0;
        }
    }

    public class B
    {
        public Action<bool> ShowHandler;

        public double Pow(double x, double y)
        {
            return x * y;
        }
    }
}

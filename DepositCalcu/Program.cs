namespace DepositCalcu
{
    class Program
    {
        static void Main(string[] args)
        {
            double interest;
            int nStartYear;
            int nCurrentYear;
            int nDeposit;
            int period;
            double nCurrentDeposit;
            double currentDeposit1, currentDeposit2;

            //int type = 1;

            Console.Write("저축 시작 년도를 입력 하세요");
            nStartYear = int.Parse(Console.ReadLine());

            Console.Write("현재 년도를 입력하세요");
            nCurrentYear = int.Parse(Console.ReadLine());

            Console.Write("저축 금액을 입력하세요");
            nDeposit = int.Parse(Console.ReadLine());

            Console.Write("이자율 :");
            interest = Double.Parse(Console.ReadLine());
            period = nCurrentYear - nStartYear + 1;

            int i;
            for (i = 1; i < period; i++)
            {
                currentDeposit1 = nDeposit * (1 + interest * i);
                currentDeposit2 = nDeposit * Math.Pow(1 + interest, i);
                Console.WriteLine("{0}년도 예상 저축 금액 : 단리={1,2:F}원, 복리 = {2,2:F}원 입니다", nStartYear + i, currentDeposit1, currentDeposit2);
            }
            Console.Read();
            //    if (type == 1)
            //    {
            //        nCurrentDeposit = nDeposit * (1 + interest * period);
            //    }
            //    else
            //    {
            //        nCurrentDeposit = nDeposit+Math.Pow(1 + interest,period
            //            );
            //    }
            //    Console.WriteLine("현재 잔액은 {0,2:F}원 입니다",nCurrentDeposit);
            //    Console.Read();
            //}
        }
    }
}

namespace Course
{
    class Calculator
    {
        public static int Sum(params int[] numbers)// params para avisar ao compilador que a variavel pode receber qualquer tipo de valor
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
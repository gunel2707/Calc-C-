namespace ConsoleApp1
{
    internal class Program
    {
           private static object deximal;

        private static void Main(string[] args)
        {
            Console.WriteLine("         Emeliyyatlar bunlardir:");
            Console.WriteLine("  1:Toplama  2:Cixma  3:Vurma  4:Bolme  5:Quvvete yukseltme  6.Kokalti");
            Console.WriteLine("  7:Ededin sade ve ya murekkeb olmasi  8:Ededin tam bolenleri ve sayi  9:Ededin tek ve ya cut olmasi");
            Console.WriteLine("  10:Ededin reqemlerinin cemi  11:Ededin yuvarlaqlasdirilmasi");
            string value;
            do
            {
                Console.Write("    Emeliyyati secin:");
                byte e = byte.Parse(Console.ReadLine());
                switch (e)
                {
                    case 1:
                        {
                            Console.WriteLine("Birinci ededi daxil edin:");
                            int var1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ikinci ededi daxil edin:");
                            int var4 = int.Parse(Console.ReadLine());
                            Console.WriteLine("result:" + Sum(var1, var4));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Birinci ededi daxil edin:");
                            int var5 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ikinci ededi daxil edin:");
                            int var6 = int.Parse(Console.ReadLine());
                            Console.WriteLine("result:" + (var5 - var6));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Birinci ededi daxil edin:");
                            int var7 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ikinci ededi daxil edin:");
                            int var8 = int.Parse(Console.ReadLine());
                            Console.WriteLine("result:" + var7 * var8);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Boluneni  daxil edin:");
                            int var9 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Boleni daxil edin:");
                            int var10 = int.Parse(Console.ReadLine());
                            Console.WriteLine("result:" + var9 / var10);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Ededi  daxil edin:");
                            int var11 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ededin derecesini daxil edin:");
                            int var12 = int.Parse(Console.ReadLine());
                            Console.WriteLine("result:" + Math.Pow(var11, var12));
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Ededi daxil edin:");
                            int var13 = int.Parse(Console.ReadLine());
                            Console.WriteLine("result:" + Math.Sqrt(var13));
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Ededi daxil edin:");
                            int s = 0;
                            int var14 = int.Parse(Console.ReadLine());
                            for (int i = 1; i <= var14 / 2; i++)
                            {
                                if (var14 % i == 0)
                                {
                                    s++;
                                }
                            }
                            if (s > 2)
                            {
                                Console.WriteLine("Eded murekkebdir");
                            }
                            else
                            {
                                Console.WriteLine("Eded sadedir");
                            }
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Ededi daxil edin:");
                            int s3 = 0;
                            int var15 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Tam bolenleri:");
                            for (int j = 1; j <= var15; j++)
                            {
                                if (var15 % j == 0)
                                {
                                    s3++;
                                    Console.WriteLine(j.ToString());
                                }
                            }
                            Console.WriteLine("Eded tam bolenlerinin sayi:" + s3);
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Ededi daxil edin:");
                            int var16 = int.Parse(Console.ReadLine());
                            if (var16 % 2 == 0)
                            {
                                Console.WriteLine("Eded cutdur");
                            }
                            else
                            {
                                Console.WriteLine("Eded tekdir");
                            }
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("Ededi daxil edin:");
                            int s2 = 0;
                            int r = 0;
                            int var2 = int.Parse(Console.ReadLine());
                            while (var2 > 0)
                            {
                                int k = var2 % 10;
                                s2++;
                                var2 /= 10;
                                r += k;
                            }
                            Console.WriteLine("Ededin reqemlerinin cemi:" + r + ";  reqemlerin sayi ise," + s2);
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine("Ededi daxil edin:");
                            double var3 = double.Parse(Console.ReadLine());
                            Console.WriteLine("result:" + Math.Round(var3, 1));
                            break;
                        }
                    default:
                        Console.WriteLine(e + "Emeliyyat nomresi deyil");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do You Want To Continue(Press y for Yes Press and n for No)");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
        private static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}

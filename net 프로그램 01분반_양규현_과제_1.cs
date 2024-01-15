using System;

namespace Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keep = true;
            int chose = 0;
            int chose_convert;
            char chose_operator;
            string chose_name = "";
            string convert_name = "";                       
            string number_1;
            string number_2;
            double double_result;
            float float_result;
            long long_result;
            int int_result;
            int char_result;
            while (true)
            {
                Console.WriteLine("메뉴를 선택하세요.");
                Console.Write("1.double, 2.float, 3.long, 4.int, 5.char, 6. 종료 : ");
                chose = int.Parse(Console.ReadLine());

                while (keep)
                {

                    switch (chose)
                    {
                        case 1:
                            chose_name = "double";
                            break;
                        case 2:
                            chose_name = "float";
                            break;
                        case 3:
                            chose_name = "long";
                            break;
                        case 4:
                            chose_name = "int";
                            break;
                        case 5:
                            chose_name = "char";
                            break;
                        case 6:
                            return;
                        default:
                            Console.WriteLine("잘못된 메뉴 번호입니다.\n");
                            Console.WriteLine("메뉴를 선택하세요.");
                            Console.Write("1.double, 2.float, 3.long, 4.int, 5.char, 6. 종료 : ");
                            chose = int.Parse(Console.ReadLine());
                            continue;
                    }
                    break;
                }

                Console.WriteLine(chose_name + "값 2개를 입력하세요");

                Console.Write("입력 1 : ");
                number_1 = Console.ReadLine();
                Console.Write("입력 2 : ");
                number_2 = Console.ReadLine();

                Console.Write("연산 종류를 입력하시오(+,-,*,/,%) : ");
                chose_operator = char.Parse(Console.ReadLine());
                while (true)
                {
                    switch (chose_operator)
                    {
                        case '+':
                            break;
                        case '-':
                            break;
                        case '*':
                            break;
                        case '/':
                            break;
                        case '%':
                            break;
                        default:
                            Console.WriteLine("잘못된 연산 기호입니다.");
                            Console.Write("연산 종류를 입력하시오(+,-,*,/,%) : ");
                            chose_operator = char.Parse(Console.ReadLine());
                            continue;

                    }
                    break;


                }

                Console.WriteLine("결과의 type을 선택하세요.");
                Console.Write("1.double, 2.float, 3.long, 4.int, 5.char : ");
                chose_convert = int.Parse(Console.ReadLine());

                while (keep)
                {

                    switch (chose_convert)
                    {
                        case 1:
                            convert_name = "double";
                            break;
                        case 2:
                            convert_name = "float";
                            break;
                        case 3:
                            convert_name = "long";
                            break;
                        case 4:
                            convert_name = "int";
                            break;
                        case 5:
                            convert_name = "char";
                            break;
                        default:
                            Console.WriteLine("잘못된 타입입니다.\n");
                            Console.WriteLine("결과의 type을 선택하세요.");
                            Console.Write("1.double, 2.float, 3.long, 4.int, 5.char : ");
                            chose_convert = int.Parse(Console.ReadLine());
                            continue;
                    }
                    break;
                }

                while (true)
                {
                    Console.Write("원결과: ");
                    if (chose_operator == '+')
                    {
                        switch (chose)
                        {
                            case 1:
                                double_result = double.Parse(number_1) + double.Parse(number_2);
                                Console.WriteLine(double_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine(double_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)double_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)double_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)double_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)double_result);
                                        break;

                                }
                                break;
                            case 2:
                                float_result = float.Parse(number_1) + float.Parse(number_2);
                                Console.WriteLine(float_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)float_result);
                                        break;
                                    case 2:
                                        Console.WriteLine(float_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)float_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)float_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)float_result);
                                        break;

                                }
                                break;
                            case 3:
                                long_result = long.Parse(number_1) + long.Parse(number_2);
                                Console.WriteLine(long_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)long_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)long_result);
                                        break;
                                    case 3:
                                        Console.WriteLine(long_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)long_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)long_result);
                                        break;

                                }
                                break;
                            case 4:
                                int_result = int.Parse(number_1) + int.Parse(number_2);
                                Console.WriteLine(int_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)int_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)int_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)int_result);
                                        break;
                                    case 4:
                                        Console.WriteLine(int_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)int_result);
                                        break;

                                }
                                break;
                            case 5:
                                char_result = char.Parse(number_1) + char.Parse(number_2);
                                Console.WriteLine((char)char_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)char_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)char_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)char_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)char_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)char_result);
                                        break;

                                }
                                break;

                        }
                        break;
                    }

                    else if (chose_operator == '-')
                    {
                        switch (chose)
                        {
                            case 1:
                                double_result = double.Parse(number_1) - double.Parse(number_2);
                                Console.WriteLine(double_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine(double_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)double_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)double_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)double_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)double_result);
                                        break;

                                }
                                break;
                            case 2:
                                float_result = float.Parse(number_1) - float.Parse(number_2);
                                Console.WriteLine(float_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)float_result);
                                        break;
                                    case 2:
                                        Console.WriteLine(float_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)float_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)float_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)float_result);
                                        break;

                                }
                                break;
                            case 3:
                                long_result = long.Parse(number_1) - long.Parse(number_2);
                                Console.WriteLine(long_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)long_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)long_result);
                                        break;
                                    case 3:
                                        Console.WriteLine(long_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)long_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)long_result);
                                        break;

                                }
                                break;
                            case 4:
                                int_result = int.Parse(number_1) - int.Parse(number_2);
                                Console.WriteLine(int_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)int_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)int_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)int_result);
                                        break;
                                    case 4:
                                        Console.WriteLine(int_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)int_result);
                                        break;

                                }
                                break;
                            case 5:
                                char_result = char.Parse(number_1) - char.Parse(number_2);
                                Console.WriteLine((char)char_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)char_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)char_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)char_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)char_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)char_result);
                                        break;

                                }
                                break;

                        }
                        break;
                    }

                    else if (chose_operator == '*')
                    {
                        switch (chose)
                        {
                            case 1:
                                double_result = double.Parse(number_1) * double.Parse(number_2);
                                Console.WriteLine(double_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine(double_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)double_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)double_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)double_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)double_result);
                                        break;

                                }
                                break;
                            case 2:
                                float_result = float.Parse(number_1) * float.Parse(number_2);
                                Console.WriteLine(float_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)float_result);
                                        break;
                                    case 2:
                                        Console.WriteLine(float_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)float_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)float_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)float_result);
                                        break;

                                }
                                break;
                            case 3:
                                long_result = long.Parse(number_1) * long.Parse(number_2);
                                Console.WriteLine(long_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)long_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)long_result);
                                        break;
                                    case 3:
                                        Console.WriteLine(long_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)long_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)long_result);
                                        break;

                                }
                                break;
                            case 4:
                                int_result = int.Parse(number_1) * int.Parse(number_2);
                                Console.WriteLine(int_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)int_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)int_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)int_result);
                                        break;
                                    case 4:
                                        Console.WriteLine(int_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)int_result);
                                        break;

                                }
                                break;
                            case 5:
                                char_result = char.Parse(number_1) * char.Parse(number_2);
                                Console.WriteLine((char)char_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)char_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)char_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)char_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)char_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)char_result);
                                        break;

                                }
                                break;

                        }
                        break;
                    }

                    else if (chose_operator == '/')
                    {
                        switch (chose)
                        {
                            case 1:
                                double_result = double.Parse(number_1) / double.Parse(number_2);
                                Console.WriteLine(double_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine(double_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)double_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)double_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)double_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)double_result);
                                        break;

                                }
                                break;
                            case 2:
                                float_result = float.Parse(number_1) / float.Parse(number_2);
                                Console.WriteLine(float_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)float_result);
                                        break;
                                    case 2:
                                        Console.WriteLine(float_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)float_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)float_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)float_result);
                                        break;

                                }
                                break;
                            case 3:
                                long_result = long.Parse(number_1) / long.Parse(number_2);
                                Console.WriteLine(long_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)long_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)long_result);
                                        break;
                                    case 3:
                                        Console.WriteLine(long_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)long_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)long_result);
                                        break;

                                }
                                break;
                            case 4:
                                int_result = int.Parse(number_1) / int.Parse(number_2);
                                Console.WriteLine(int_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)int_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)int_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)int_result);
                                        break;
                                    case 4:
                                        Console.WriteLine(int_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)int_result);
                                        break;

                                }
                                break;
                            case 5:
                                char_result = char.Parse(number_1) / char.Parse(number_2);
                                Console.WriteLine((char)char_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)char_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)char_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)char_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)char_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)char_result);
                                        break;

                                }
                                break;

                        }
                        break;
                    }

                    else if (chose_operator == '%')
                    {
                        switch (chose)
                        {
                            case 1:
                                double_result = double.Parse(number_1) % double.Parse(number_2);
                                Console.WriteLine(double_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine(double_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)double_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)double_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)double_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)double_result);
                                        break;

                                }
                                break;
                            case 2:
                                float_result = float.Parse(number_1) % float.Parse(number_2);
                                Console.WriteLine(float_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)float_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)float_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)float_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)float_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)float_result);
                                        break;

                                }
                                break;
                            case 3:
                                long_result = long.Parse(number_1) % long.Parse(number_2);
                                Console.WriteLine(long_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)long_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)long_result);
                                        break;
                                    case 3:
                                        Console.WriteLine(long_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)long_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)long_result);
                                        break;

                                }
                                break;
                            case 4:
                                int_result = int.Parse(number_1) % int.Parse(number_2);
                                Console.WriteLine(int_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)int_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)int_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)int_result);
                                        break;
                                    case 4:
                                        Console.WriteLine(int_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)int_result);
                                        break;

                                }
                                break;
                            case 5:
                                char_result = char.Parse(number_1) % char.Parse(number_2);
                                Console.WriteLine((char)char_result);
                                Console.Write("형 변환 결과: " + convert_name + ":");
                                switch (chose_convert)
                                {
                                    case 1:
                                        Console.WriteLine((double)char_result);
                                        break;
                                    case 2:
                                        Console.WriteLine((float)char_result);
                                        break;
                                    case 3:
                                        Console.WriteLine((long)char_result);
                                        break;
                                    case 4:
                                        Console.WriteLine((int)char_result);
                                        break;
                                    case 5:
                                        Console.WriteLine((char)char_result);
                                        break;

                                }
                                break;

                        }
                        break;

                    }
                }
                Console.WriteLine();
            }




        }            
    }
}

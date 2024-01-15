using System;
using System.Collections.Generic;

namespace ConsoleApp9
{
    class Person
    {
        public static int counter = 0;
        public int id;
        public string name;
        public string birth_year;

        public Person()
        {
            id = counter++;

        }

        public void printperson()
        {
            Console.Write("탑승번호: " + id + ", 이름:" + name + ", 생년:" + birth_year + " ");

        }

}

class Employee : Person
    {
        public int em_num;
        private int salary;
        private string grade;
        public string job_type;

        public int Em_num
        {
            get { return em_num; }
            set
            {
                if (value <= 0) 
                {
                    Console.WriteLine("0보다 큰 값을 입력하시오");
                    this.em_num = 0;

                }
                else
                {
                    this.em_num = value;
                }
            }
        }
        public void printemployee()
        {
            Console.Write(" 사번 :" + em_num + ", 급여:" + salary + ", 연말평가:" + grade + ", 직종 : " + job_type);

        }

        public int getsalary()
        { return salary; }

        public string getgrade()
        {
          return grade;
        }
        public void setsalarygrade(string grade)
        {
            if (grade == "S" || grade == "A" || grade == "B" || grade == "C")
                this.grade = grade;
            else
            {
                while (grade != "S" && grade != "A" && grade != "B" && grade != "C")
                {
                    Console.WriteLine("연말 평가는 S, A, B, C 중 하나여야 합니다.");
                    Console.Write("연말 평가 : ");
                    grade = Console.ReadLine();
                }
                this.grade = grade;
            }

        }
        public void setsalarygrade(int salary)
        {
            if (salary <= 0)
            {
                while (salary <= 0)
                {
                    Console.WriteLine("급여는 0보다 커야합니다.");
                    Console.Write("급여 : ");
                    salary = int.Parse(Console.ReadLine());
                }
                this.salary = salary;
            }

        }

    }
    class Pilot : Employee
    {
        public int flight_distant;
        public int license_num;
        public const int max_pilot_num = 2;
        public static int pilot_num = 0;

        public void printpilot()
        {
            Console.WriteLine(" 총 비행거리 :" + flight_distant + ", 면허번호:" + license_num);
        }

        public int Flight_distant
        {
            get { return flight_distant; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("0보다 큰 값을 입력하시오");
                    this.flight_distant = 0;
                }
                else
                {
                    flight_distant = value;
                }
            }
        }

        public Pilot()
        {
            pilot_num++;
            this.job_type = "파일럿";
            
        }
    }
    class Attendant : Employee
    {
        public string service_class;
        public string service_area;
        public const int max_attendant_num = 3;
        public static int attendant_num = 0;

        public void printattendant()
        {
            Console.WriteLine(" 서비스 클래스:" + service_class + ", 서비스 구역:" + service_area);
        }
        public string Service_class
        {
            get { return service_class; }
            set
            {
                if ((service_class == "First") || (service_class == "Business")||(service_class == "Economy"))
                {
                    this.service_class = value;
                }
                else
                {
                    Console.WriteLine("First, Business, Economy 중 하나를 입력하시오");
                    this.service_class = null;

                }
            }

        }

        
        public Attendant()
        {
            attendant_num++;
            this.job_type = "승무원";
           
        }
    }
    class Passenger : Person
    {
        public string seat_num;
        public int total_mile;
        public const int max_passenger_num = 5;
        public static int passenger_num = 0;

        public void printpassenger()
        {
            Console.WriteLine(" 좌석 번호:" + seat_num + ", 총 마일리지:" + total_mile);
        }
        public Passenger()
        {
            passenger_num++;


        }
    }
    class Program
    {
        public static void menu()
        {
            int chose;
            List<Person> list = new List<Person>
            { new Passenger(){name = "승객1", birth_year = "1998", seat_num = "1A", total_mile = 1000 },
              new Passenger(){name = "승객2", birth_year = "1995", seat_num = "2A", total_mile = 10000 },
              new Passenger(){name = "승객3", birth_year = "1967", seat_num = "3A", total_mile = 15000 },
              new Passenger(){name = "승객4", birth_year = "1988", seat_num = "4A", total_mile = 20000},
              new Attendant(){name = "승무원1", birth_year = "1990", em_num = 1, service_class = "Economy", service_area = "A" },
              new Attendant(){name = "승무원2", birth_year = "1989", em_num = 2, service_class = "Business", service_area = "B" },
              new Pilot(){name = "파일럿1", birth_year = "1974", em_num = 3, flight_distant = 45200, license_num = 1234 }
            };
            ((Employee)list[4]).setsalarygrade(10000);
            ((Employee)list[4]).setsalarygrade("B");
            ((Employee)list[5]).setsalarygrade(12000);
            ((Employee)list[5]).setsalarygrade("A");
            ((Employee)list[6]).setsalarygrade(18000);
            ((Employee)list[6]).setsalarygrade("S");


            while (true) {
                Console.WriteLine("1. 파일럿추가, 2. 승무원추가, 3. 승객추가, 4.현황 출력, 5. 종료");
                chose = int.Parse(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        if (Pilot.pilot_num < Pilot.max_pilot_num)
                        {
                            Console.WriteLine("------파일럿 추가 -----");
                            Pilot pilot = new Pilot();
                            Console.Write("이름 : ");
                            pilot.name = Console.ReadLine();
                            Console.Write("생년 : ");
                            pilot.birth_year = Console.ReadLine();
                            Console.Write("사번 : ");
                            pilot.em_num = int.Parse(Console.ReadLine());
                            while (pilot.em_num <= 0)
                            {
                                pilot.Em_num = pilot.em_num;
                                pilot.em_num = int.Parse(Console.ReadLine());
                            }
                            Console.Write("급여 : ");
                            pilot.setsalarygrade(int.Parse(Console.ReadLine()));
                            Console.Write("연말평가 : ");
                            pilot.setsalarygrade(Console.ReadLine());
                            Console.Write("총 비행 거리 : ");
                            pilot.flight_distant = int.Parse(Console.ReadLine());
                            while (pilot.flight_distant <= 0)
                            {
                                pilot.Flight_distant = pilot.flight_distant;
                                pilot.flight_distant = int.Parse(Console.ReadLine());
                            }
                            Console.Write("면허번호 : ");
                            pilot.license_num = int.Parse(Console.ReadLine());
                            list.Add(pilot);
                            Console.WriteLine("파일럿이 성공적으로 추가되었습니다.");


                        }

                        else
                            Console.WriteLine("더이상 파일럿을 추가할 수 없습니다!");
                        break;
                    case 2:
                        if (Attendant.attendant_num < Attendant.max_attendant_num)
                        {
                            Console.WriteLine("------승무원 추가 -----");
                            Attendant attendant = new Attendant();
                            Console.Write("이름 : ");
                            attendant.name = Console.ReadLine();
                            Console.Write("생년 : ");
                            attendant.birth_year = Console.ReadLine();
                            Console.Write("사번 : ");
                            attendant.Em_num = int.Parse(Console.ReadLine());
                            while (attendant.em_num <= 0)
                            {
                                attendant.Em_num = attendant.em_num;
                                attendant.em_num = int.Parse(Console.ReadLine());
                            }
                            Console.Write("급여 : ");
                            attendant.setsalarygrade(int.Parse(Console.ReadLine()));
                            Console.Write("연말평가 : ");
                            attendant.setsalarygrade(Console.ReadLine());
                            Console.Write("서비스 클래스 : ");
                            attendant.service_class = Console.ReadLine();
                            while ((attendant.service_class != ("First")) && (attendant.service_class != ("Business")) && (attendant.service_class != ("Economy")))
                            {
                                attendant.Service_class = attendant.service_class;
                                attendant.service_class = Console.ReadLine();
                            }
                            Console.Write("서비스 구역 : ");
                            attendant.service_area = Console.ReadLine();
                            attendant.job_type = "승무원";
                            list.Add(attendant);
                            Console.WriteLine("승무원이 성공적으로 추가되었습니다.");

                        }
                            
                        else
                            Console.WriteLine("더이상 승무원을 추가할 수 없습니다!");
                        break;
                    case 3:
                        if (Passenger.passenger_num < Passenger.max_passenger_num)
                        {
                            Console.WriteLine("------승객 추가 -----");
                            Passenger passenger = new Passenger();
                            Console.Write("이름 : ");
                            passenger.name = Console.ReadLine();
                            Console.Write("생년 : ");
                            passenger.birth_year = Console.ReadLine();
                            Console.Write("좌석번호 : ");
                            passenger.seat_num = Console.ReadLine();
                            Console.Write("총 마일리지 : ");
                            passenger.total_mile = int.Parse(Console.ReadLine());
                            list.Add(passenger);
                            Console.WriteLine("승객이 추가되었습니다.");

                        }

                        else
                            Console.WriteLine("더이상 승객을 추가할 수 없습니다!");
                        break;
                    case 4:
                        foreach(var item in list)
                        {
                            if(item is Pilot)
                            {
                                item.printperson();
                                ((Employee)item).printemployee();
                                ((Pilot)item).printpilot();
                            }
                        }
                        foreach(var item in list)
                        {
                            if(item is Attendant)
                            {
                                item.printperson();
                                ((Employee)item).printemployee();
                                ((Attendant)item).printattendant();
                            }
                        }
                        foreach(var item in list)
                        {
                            if(item is Passenger)
                            {
                                item.printperson();
                                ((Passenger)item).printpassenger();
                            }
                        }
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("다시 입력해주세요.");
                        continue;

                }
            }
        }
        static void Main(string[] args)
        {
            Program.menu();
        }
    }
}
    

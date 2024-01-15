using System;
using System.Collections.Generic;

namespace HumanResourceManage

{

    class Human
    {
        public static int counter= 1;
        public readonly int id;
        public string member_name;
        public string member_sex;
        public int member_phone;
        public string member_address;
        public string member_job;
        private string member_resident_number;

        public string Member_resident_number //주민번호 검증부분
        {
            get
            {
                return member_resident_number;
            }
            set
            {
                while (true)
                {
                    int birth_month = ((value[2] - 48) * 10 + (value[3] - 48));
                    int birth_day = ((value[4] - 48) * 10 + (value[5] - 48));
                    if ((birth_month > 12) || (birth_month < 1) || (birth_day > 31) || (birth_month < 1))
                    {
                        Console.WriteLine("정확한 형식의 주민번호가 아닙니다.");
                        Console.WriteLine("주민등록번호를 입력해주세요.");
                        member_resident_number = Console.ReadLine();
                        value = member_resident_number;
                        continue;
                    }
                    else
                    {
                        member_resident_number = value;
                        break;
                    }
                }
            }
        }

        public Human(string member_name, string member_sex, int member_phone, string member_address, string member_job, string member_resident_number)
        {
            this.id = counter++;
            this.member_name = member_name;
            this.member_sex = member_sex;
            this.member_phone = member_phone;
            this.member_address = member_address;
            this.member_job = member_job;
            this.member_resident_number = member_resident_number;

        }
        public Human(string member_name, string member_sex, int member_phone, string member_address, string member_resident_number) //직업이 없는 생성자
        {
            this.id = counter++;
            this.member_name = member_name;
            this.member_sex = member_sex;
            this.member_phone = member_phone;
            this.member_address = member_address;
            this.member_resident_number = member_resident_number;

        }
        public Human(string member_name, string member_sex, string member_job, string member_address, string member_resident_number) //전화번호가 없는 생성자
        {
            this.id = counter++;
            this.member_name = member_name;
            this.member_sex = member_sex;
            this.member_job = member_job;
            this.member_address = member_address;
            this.member_resident_number = member_resident_number;

        }

        public Human(string member_name, string member_sex, string member_address, string member_resident_number) //직업, 전화번호가 없는 생성자
        {
            this.id = counter++;
            this.member_name = member_name;
            this.member_sex = member_sex;
            this.member_address = member_address;
            this.member_resident_number = member_resident_number;

        }

        public static Human join_member()
        {
            Console.WriteLine("이름을 입력해주세요.");
            string member_name = Console.ReadLine();
            Console.WriteLine("성별을 입력해주세요(남/여).");
            string member_sex = Console.ReadLine();
            Console.WriteLine("휴대폰번호를 입력해주세요( - 없이 입력)");
            int member_phone = int.Parse(Console.ReadLine());
            Console.WriteLine("주민등록번호를 입력해주세요.");
            string member_resident_number = Console.ReadLine();
            while (true)
            {
                int birth_month = ((member_resident_number[2]-48) * 10 + (member_resident_number[3]-48));
                int birth_day = ((member_resident_number[4]-48) * 10 + (member_resident_number[5]-48));
                if ((birth_month >12)||(birth_month < 1)||(birth_day > 31) || (birth_month < 1))
                {
                    Console.WriteLine("정확한 형식의 주민번호가 아닙니다.");
                    Console.WriteLine("주민등록번호를 입력해주세요.");
                    member_resident_number = Console.ReadLine();
                    continue;

                }
                else
                {
                    break;
                }

            }
            Console.WriteLine("주소를 입력해주세요");
            string member_address = Console.ReadLine();
            Console.WriteLine("직업을 입력해주세요");
            string member_job = Console.ReadLine();
            Human human = new Human(member_name, member_sex, member_phone, member_address, member_job, member_resident_number);
            return human;
        }
        public static void print_member(Human human)
        {
            Console.WriteLine(human.id+"." + human.member_name);
            Console.WriteLine("성별 : " + human.member_sex);
            Console.WriteLine("휴대폰 : 0" + human.member_phone);
            Console.WriteLine("주민등록번호 : " + human.member_resident_number);
            Console.WriteLine("주소 : " + human.member_address);
            Console.WriteLine("직업 : " + human.member_job + "\n");

        }
        ~Human()
        {
            Console.WriteLine(this.id + "." + this.member_name);
            Console.WriteLine("성별 : " + this.member_sex);
            Console.WriteLine("휴대폰 : 0" + this.member_phone);
            Console.WriteLine("주민등록번호 : " + this.member_resident_number);
            Console.WriteLine("주소 : " + this.member_address);
            Console.WriteLine("직업 : " + this.member_job + "\n");
        }

        public static void delete_member(List<Human> list)
        {
            int del_number;
            string del_res_num;
            int chose;
            Console.WriteLine("검색할 회원의 정보를 선택해주세요");
            Console.WriteLine("1.전화번호, 2.주민번호");
            chose = int.Parse(Console.ReadLine());
            while (true)
            {
                switch (chose)
                {
                    case 1:
                        Console.WriteLine("검색할 회원의 전화번호를 입력해주세요.( - 없이)");
                        del_number = int.Parse(Console.ReadLine());
                        for (int i = list.Count - 1; i >= 0; i--)
                        {
                            if (del_number == list[i].member_phone)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("삭제된 항목");
                                Console.WriteLine(list[i].id + "." + list[i].member_name);
                                Console.WriteLine("성별 : " + list[i].member_sex);
                                Console.WriteLine("휴대폰 : 0" + list[i].member_phone);
                                Console.WriteLine("주민등록번호 : " + list[i].member_resident_number);
                                Console.WriteLine("주소 : " + list[i].member_address);
                                Console.WriteLine("직업 : " + list[i].member_job + "\n");
                                list.RemoveAt(i);
                            }
                        }
                            break;
                    case 2:
                        Console.WriteLine("검색할 회원의 주민번호를 입력해주세요.( - 포함)");
                        del_res_num = Console.ReadLine();
                        for (int i = list.Count - 1; i >= 0; i--)
                        {
    
                            if (del_res_num == list[i].member_resident_number)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("삭제된 항목");
                                Console.WriteLine(list[i].id + "." + list[i].member_name);
                                Console.WriteLine("성별 : " + list[i].member_sex);
                                Console.WriteLine("휴대폰 : 0" + list[i].member_phone);
                                Console.WriteLine("주민등록번호 : " + list[i].member_resident_number);
                                Console.WriteLine("주소 : " + list[i].member_address);
                                Console.WriteLine("직업 : " + list[i].member_job + "\n");
                                list.RemoveAt(i);

                            }
                        }
                        break;
                    default:
                        Console.WriteLine("올바른 번호가 아닙니다.");
                        continue;
                }
                break;
            }
        }

        public static void change_member(List<Human> list)
        {
            int search_number;
            string search_res_num;
            int chose; 
            Console.WriteLine("검색할 회원의 정보를 선택해주세요");
            Console.WriteLine("1.전화번호, 2.주민번호");
            chose = int.Parse(Console.ReadLine());
            while (true)
            {
                switch (chose)
                {
                    case 1:
                        Console.WriteLine("검색할 회원의 전화번호를 입력해주세요.( - 없이)");
                        search_number = int.Parse(Console.ReadLine());
                        for (int i = list.Count - 1; i >= 0; i--)
                        {
                            if (search_number == list[i].member_phone)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("검색된 항목");
                                Console.WriteLine(list[i].id + "." + list[i].member_name);
                                Console.WriteLine("성별 : " + list[i].member_sex);
                                Console.WriteLine("휴대폰 : 0" + list[i].member_phone);
                                Console.WriteLine("주민등록번호 : " + list[i].member_resident_number);
                                Console.WriteLine("주소 : " + list[i].member_address);
                                Console.WriteLine("직업 : " + list[i].member_job + "\n");
                                while (true)
                                {
                                    Console.WriteLine("변경하실 정보를 선택해주세요");
                                    Console.WriteLine("1.이름, 2.성별, 3.전화번호, 4.주민번호, 5.주소, 6.직업, 7.변경없음");
                                    int chose_change = int.Parse(Console.ReadLine());
                                    switch (chose_change)
                                    {
                                        case 1:
                                            Console.WriteLine("변경하실 이름을 입력해주세요.");
                                            list[i].member_name = Console.ReadLine();
                                            break;
                                        case 2:
                                            Console.WriteLine("변경하실 성별을 입력해주세요.");
                                            list[i].member_sex = Console.ReadLine();
                                            break;
                                        case 3:
                                            Console.WriteLine("변경하실 전화번호를 입력해주세요.( - 없이)");
                                            list[i].member_phone = int.Parse(Console.ReadLine());
                                            break;
                                        case 4:
                                            Console.WriteLine("변경하실 주민번호를 입력해주세요.");
                                            list[i].Member_resident_number = Console.ReadLine();
                                            break;

                                        case 5:
                                            Console.WriteLine("변경하실 주소를 입력해주세요.");
                                            list[i].member_address = Console.ReadLine();
                                            break;
                                        case 6:
                                            Console.WriteLine("변경하실 직업을 입력해주세요.");
                                            list[i].member_job = Console.ReadLine();
                                            break;
                                        case 7:
                                            return;

                                    }
                                    break;
                                }
                            }
                        }
                        Console.WriteLine("변경되었습니다.");
                        return;

                    case 2:
                        Console.WriteLine("검색할 회원의 주민번호를 입력해주세요.( - 포함)");
                        search_res_num = Console.ReadLine();
                        for (int i = list.Count - 1; i >= 0; i--)
                        {

                            if (search_res_num == list[i].member_resident_number)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("검색된 항목");
                                Console.WriteLine(list[i].id + "." + list[i].member_name);
                                Console.WriteLine("성별 : " + list[i].member_sex);
                                Console.WriteLine("휴대폰 : 0" + list[i].member_phone);
                                Console.WriteLine("주민등록번호 : " + list[i].member_resident_number);
                                Console.WriteLine("주소 : " + list[i].member_address);
                                Console.WriteLine("직업 : " + list[i].member_job + "\n");
                                while (true)
                                {
                                    Console.WriteLine("변경하실 정보를 선택해주세요");
                                    Console.WriteLine("1.이름, 2.성별, 3.전화번호, 4.주민번호, 5.주소, 6.직업, 7.변경없음");
                                    int chose_change = int.Parse(Console.ReadLine());
                                    switch (chose_change)
                                    {
                                        case 1:
                                            Console.WriteLine("변경하실 이름을 입력해주세요.");
                                            list[i].member_name = Console.ReadLine();
                                            break;
                                        case 2:
                                            Console.WriteLine("변경하실 성별을 입력해주세요.");
                                            list[i].member_sex = Console.ReadLine();
                                            break;
                                        case 3:
                                            Console.WriteLine("변경하실 전화번호를 입력해주세요.( - 없이)");
                                            list[i].member_phone = int.Parse(Console.ReadLine());
                                            break;
                                        case 4:
                                            Console.WriteLine("변경하실 주민번호를 입력해주세요.");
                                            list[i].Member_resident_number = Console.ReadLine();
                                            break;
                                        case 5:
                                            Console.WriteLine("변경하실 주소를 입력해주세요.");
                                            list[i].member_address = Console.ReadLine();
                                            break;
                                        case 6:
                                            Console.WriteLine("변경하실 직업을 입력해주세요.");
                                            list[i].member_job = Console.ReadLine();
                                            break;
                                        case 7:
                                            return;

                                    }
                                    break;
                                }
                            }
                        }
                        Console.WriteLine("변경되었습니다.\n");
                        return;
                    default:
                        Console.WriteLine("올바른 번호가 아닙니다.");
                        continue;
                }
                break;
            }
        }

        public static void search_member(List<Human> list)
        {
            string search_name;
            string search_sex;
            int search_number;
            string search_res_num;
            string search_address;
            string search_job;
            int chose;
            Console.WriteLine("검색할 회원의 정보를 선택해주세요");
            Console.WriteLine("1.이름, 2.성별, 3.전화번호, 4.주민번호, 5.주소, 6.직업");
            chose = int.Parse(Console.ReadLine());
            while (true)
            {
                switch (chose)
                {
                    case 1:
                        Console.WriteLine("검색할 회원의 이름를 입력해주세요.");
                        search_name = Console.ReadLine();
                        Console.WriteLine("검색된 항목");
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (search_name == list[i].member_name)
                            {
                                Console.WriteLine(list[i].id + "." + list[i].member_name);
                                Console.WriteLine("성별 : " + list[i].member_sex);
                                Console.WriteLine("휴대폰 : 0" + list[i].member_phone);
                                Console.WriteLine("주민등록번호 : " + list[i].member_resident_number);
                                Console.WriteLine("주소 : " + list[i].member_address);
                                Console.WriteLine("직업 : " + list[i].member_job + "\n");
                            }
                        }
                        Console.WriteLine("------------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("검색할 회원의 성별을 입력해주세요.(남/여)");
                        search_sex = Console.ReadLine();
                        Console.WriteLine("검색된 항목");
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (search_sex == list[i].member_sex)
                            {
                                Console.WriteLine(list[i].id + "." + list[i].member_name);
                                Console.WriteLine("성별 : " + list[i].member_sex);
                                Console.WriteLine("휴대폰 : 0" + list[i].member_phone);
                                Console.WriteLine("주민등록번호 : " + list[i].member_resident_number);
                                Console.WriteLine("주소 : " + list[i].member_address);
                                Console.WriteLine("직업 : " + list[i].member_job + "\n");
                            }
                        }
                        Console.WriteLine("------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("검색할 회원의 전화번호를 입력해주세요.( - 없이)");
                        search_number = int.Parse(Console.ReadLine());
                        Console.WriteLine("검색된 항목");
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (search_number == list[i].member_phone)
                            {
                                Console.WriteLine(list[i].id + "." + list[i].member_name);
                                Console.WriteLine("성별 : " + list[i].member_sex);
                                Console.WriteLine("휴대폰 : 0" + list[i].member_phone);
                                Console.WriteLine("주민등록번호 : " + list[i].member_resident_number);
                                Console.WriteLine("주소 : " + list[i].member_address);
                                Console.WriteLine("직업 : " + list[i].member_job + "\n");
                            }
                        }
                        Console.WriteLine("------------------------------------");
                        break;
                    case 4:
                        Console.WriteLine("검색할 회원의 주민번호를 입력해주세요.( - 포함)");
                        search_res_num = Console.ReadLine();
                        Console.WriteLine("검색된 항목");
                        for (int i = 0; i < list.Count; i++)
                        {

                            if (search_res_num == list[i].member_resident_number)
                            {
                                Console.WriteLine(list[i].id + "." + list[i].member_name);
                                Console.WriteLine("성별 : " + list[i].member_sex);
                                Console.WriteLine("휴대폰 : 0" + list[i].member_phone);
                                Console.WriteLine("주민등록번호 : " + list[i].member_resident_number);
                                Console.WriteLine("주소 : " + list[i].member_address);
                                Console.WriteLine("직업 : " + list[i].member_job + "\n");

                            }
                        }
                        Console.WriteLine("------------------------------------");
                        break;
                    case 5:
                        Console.WriteLine("검색할 회원의 주소를 입력해주세요.");
                        search_address = Console.ReadLine();
                        Console.WriteLine("검색된 항목");
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (search_address == list[i].member_address)
                            {
                                Console.WriteLine(list[i].id + "." + list[i].member_name);
                                Console.WriteLine("성별 : " + list[i].member_sex);
                                Console.WriteLine("휴대폰 : 0" + list[i].member_phone);
                                Console.WriteLine("주민등록번호 : " + list[i].member_resident_number);
                                Console.WriteLine("주소 : " + list[i].member_address);
                                Console.WriteLine("직업 : " + list[i].member_job + "\n");
                            }
                        }
                        Console.WriteLine("------------------------------------");
                        break;
                    case 6:
                        Console.WriteLine("검색할 회원의 직업을 입력해주세요.");
                        search_job = Console.ReadLine();
                        Console.WriteLine("검색된 항목");
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (search_job == list[i].member_job)
                            {
                                Console.WriteLine(list[i].id + "." + list[i].member_name);
                                Console.WriteLine("성별 : " + list[i].member_sex);
                                Console.WriteLine("휴대폰 : 0" + list[i].member_phone);
                                Console.WriteLine("주민등록번호 : " + list[i].member_resident_number);
                                Console.WriteLine("주소 : " + list[i].member_address);
                                Console.WriteLine("직업 : " + list[i].member_job + "\n");
                            }
                        }
                        Console.WriteLine("------------------------------------");
                        break;

                    default:
                        Console.WriteLine("올바른 번호가 아닙니다.");
                        continue;
                }
                break;
            }
        }


    }

    class Program

    {
        static int chose;
        static void Main(string[] args)
        {
            List<Human> list = new List<Human>();
            list.Add(new Human("홍길동", "남", 01000000000, "월평동 황실아파트 101동 101호", "학생", "000101-1000001"));
            list.Add(new Human("김영희", "여", 01000000001, "월평동 황실아파트 101동 102호", "학생", "000102-2000002"));
            list.Add(new Human("이지은", "여", 01000000002, "월평동 황실아파트 101동 103호", "가수", "000103-2000003"));
            list.Add(new Human("이상혁", "남", "월평동 황실아파트 101동 104호", "프로게이머", "000104-1000004"));
            list.Add(new Human("조혜련", "여", 01000000004, "월평동 황실아파트 101동 105호", "000105-2000005"));
            list.Add(new Human("유재석", "남", "월평동 황실아파트 101동 106호",  "000106-100006"));
            list.Add(new Human("정형돈", "남", 01000000006, "월평동 황실아파트 101동 107호", "개그맨", "000107-1000007"));
            list.Add(new Human("정준하", "남", 01000000007, "월평동 황실아파트 101동 108호", "방송인", "000108-1000008"));
            list.Add(new Human("하하", "남", 01000000008, "월평동 황실아파트 101동 109호", "가수", "000109-1000009"));
            list.Add(new Human("박명수", "남", 01000000009, "월평동 황실아파트 101동 110호", "개그맨", "000110-1000010"));

            while (true)
            {
                Console.WriteLine("1.회원가입, 2.회원전체출력, 3.회원삭제, 4.회원정보변경, 5.회원정보검색, 6.종료");
                chose = int.Parse(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        list.Add(Human.join_member());
                        continue;
                    case 2:
                        for(int i= 0; i<list.Count; i++)
                            Human.print_member(list[i]);
                        continue;
                    case 3:
                        Human.delete_member(list);
                        continue;
                    case 4:
                        Human.change_member(list);
                        continue;
                    case 5:
                        Human.search_member(list);
                        continue;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("정확한 번호를 입력해주세요");
                        continue;

                }
                break;
            }

        }

    }

}

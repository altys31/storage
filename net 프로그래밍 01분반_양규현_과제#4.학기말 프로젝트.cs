using System;
using System.Collections.Generic;

namespace ConsoleApp11
{

    interface addperson
    {


        public void add_name()
        {

        }
        public void add_email()
        {

        }
        public void add_phone()
        {

        }

    }
    interface changeperson
    {
        public void change_name()
        {

        }
        public void change_email()
        {

        }
        public void change_phone()
        {

        }

    }
    interface changestudent : changeperson
    {
        public void change_student_num()
        {


        }
        public void change_department()
        {


        }
        public void change_scholarship()
        {

        }

    }
    interface addstudent : addperson
    {
        public void add_student_num()
        {

        }
        public void add_department()
        {

        }

        public void add_scholarship()
        {

        }
    }
    interface addprofessor : addperson
    {
        public void add_salary()
        {
        }
        public void add_fac_num()
        {

        }
        public void add_join_date()
        {
        }
        public void add_department()
        {

        }
        public void add_rank()
        {

        }
    }
    interface changeprofessor : changeperson
    {
        public void change_salary()
        {

        }
        public void change_fac_num()
        {

        }
        public void change_join_date()
        {

        }
        public void change_department()
        {

        }
        public void change_rank()
        {

        }


    }
    interface addstaff : addperson
    {
        public void add_salary()
        {
        }
        public void add_fac_num()
        {

        }
        public void add_join_date()
        {
        }
        public void add_rank()
        {

        }
        public void add_department()
        {


        }

    }
    interface changestaff : changeperson
    {
        public void change_salary()
        {

        }
        public void change_fac_num()
        {

        }
        public void change_join_date()
        {

        }
        public void change_department()
        {

        }
        public void change_rank()
        {

        }


    }

    interface addassistant : addperson
    {
        public void add_salary()
        {
        }
        public void add_fac_num()
        {

        }
        public void add_join_date()
        {
        }
        public void add_department()
        {

        }

    }
    interface changeassistant : changeperson
    {
        public void change_salary()
        {

        }
        public void change_fac_num()
        {

        }
        public void change_join_date()
        {

        }
        public void change_department()
        {

        }
        public void change_rank()
        {

        }


    }



    class Person :  addperson, changeperson
    {
        public string phone_number; //전화번호
        public string name; //이름
        public string email; // 이메일

        public static List<Person> person_list = new List<Person>();


        public static Person find_person_byname(string name) // 이름으로 Person 객체 찾는 매서드
        {
            Person person = new Person();
            foreach (var item in person_list)
            {

                if (name == item.name)
                {
                    person = item;

                }
            }
            return person;

        }
        public static Person find_person_byphone(string phone_number)
        {
            Person person = new Person();
            foreach (var item in person_list)
            {
                if (phone_number.Equals(item.phone_number))
                    person = item;
            }
            return person;
        }
        public static Person find_person_byemail(string email)
        {
            Person person = new Person();
            foreach (var item in person_list)
            {
                if (email.Equals(item.email))
                    person = item;
            }
            return person;
        }

        public Person(string phone_number, string name, string email)
        {
            this.phone_number = phone_number;
            this.name = name;
            this.email = email;
        }
        public Person()
        {

        }
        public void add_name()
        {
            Console.WriteLine("추가할 대상의 이름을 입력해주세요");
            Console.Write("입력 :");
            this.name = Console.ReadLine();
            Console.Clear();

        }
        public void add_email()
        {
            Console.WriteLine("추가할 대상의 이메일을 입력해주세요");
            Console.Write("입력 :");
            this.email = Console.ReadLine();
            Console.Clear();
        }
        public void add_phone()
        {
            Console.WriteLine("추가할 대상의 휴대전화번호를 입력해주세요");
            Console.Write("입력 :");
            this.phone_number = Console.ReadLine();
            Console.Clear();
        }

        public void change_name()
        {
            Console.WriteLine("변경할 이름을 입력해주세요");
            Console.WriteLine("현재값 : " + this.name);
            Console.Write("입력 :");
            this.name = Console.ReadLine();
            Console.Clear();

        }
        public void change_email()
        {
            Console.WriteLine("변경할 이메일을 입력해주세요");
            Console.WriteLine("현재값 : " + this.email);
            Console.Write("입력 :");
            this.email = Console.ReadLine();
            Console.Clear();

        }
        public void change_phone()
        {
            Console.WriteLine("변경할 전화번호를 입력해주세요");
            Console.WriteLine("현재값 : " + this.phone_number);
            Console.Write("입력 :");
            this.phone_number = Console.ReadLine();
            Console.Clear();

        }
    }
    class Student : Person, addstudent, changestudent
    {
        public string student_num; // 학번
        public Department department;  //소속학과
        public string scholarship; // 수혜 장학금 내역

        public static List<Student> student_list = new List<Student>();
        public List<Subject> subject_list = new List<Subject>();
        public List<SubjectEnd> subjectend_list = new List<SubjectEnd>();

        public Student(string name, string phone_number, string email, string student_num, Department department, string scholarship)
        {
            this.name = name;
            this.phone_number = phone_number;
            this.email = email;
            this.student_num = student_num;
            this.department = department;
            this.scholarship = scholarship;
        }
        public Student()
        {

        }
        public static Student search_student_byname(string name)
        {
            Student student = new Student();

                foreach (var item in Student.student_list)
                {
                    if (name == item.name)
                    {
                        student = item;

                    }
                }
            

            return student;

        }
        public static Student search_student_byphone(string phone_number)
        {
            Student student = new Student();

                foreach (var item in Student.student_list)
                {
                    if (phone_number.Equals(item.phone_number))
                        student = item;
                }

            
            return student;
        }
        public static Student search_student_byemail(string email)
        {
            Student student = new Student();
                foreach (var item in Student.student_list)
                {
                    if (email.Equals(item.email))
                        student = item;
                }
            return student;
        }
        public static Student search_student_bystudentnum(string student_num)
        {
            Student student = new Student();
            foreach (var item in Student.student_list)
            {

                if (student_num == item.student_num)
                {
                    student = item;

                }
            }
            return student;

        }

        public static Student search_student_bydepartment(Department department)
        {
            int chose;
            
            Student student = new Student();
            while (true)
            {
                int i = 1;
                foreach (var item in department.student_list)
                {
                    Console.WriteLine(i++ + "." + item.name);

                }
                Console.Write("번호 입력 :");

                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if (chose > Department.department_list.Count || chose < 1)
                {
                    Console.Clear();
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    continue;
                }
                student = department.student_list[chose - 1];
                return student;
            }


            }

        public void add_student_num()
        {
            Console.WriteLine("추가할 학생의 학번을 입력해주세요 : ");
            this.student_num = Console.ReadLine();
            Console.Clear();
        }
        public void add_department()
        {
            int department_chose;
            while (true)
            {
                Console.WriteLine("추가할 학생의 학과를 입력해주세요 : ");
                Department department = new Department();
                foreach (var item in Department.department_list)
                {
                    Console.WriteLine(item.number + "." + item.name);

                }
                Console.Write("번호 입력 :");

                try
                {
                    department_chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if (department_chose > Department.department_list.Count || department_chose < 1)
                {
                    Console.Clear();
                    Console.WriteLine("※올바른 숫자를 입력해주세요\n");
                    continue;
                }

                foreach (var item in Department.department_list)
                {
                    if (department_chose == item.number)
                        department = item;
                }
                this.department = department;
                department.student_list.Add(this);
                Console.Clear();
                break;
            }
        }
        public void add_scholarship()
        {
            Console.WriteLine("추가할 대상의 장학금내역을 입력해주세요 : ");
            this.scholarship = Console.ReadLine();
            Console.Clear();
        }

        public void print_student()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("학생 '" + this.name + "'의 정보");
            Console.WriteLine("학번 : " + this.student_num);
            Console.WriteLine("전화번호 : " + this.phone_number);
            Console.WriteLine("이메일 : " + this.email);
            Console.WriteLine("소속학과: " + this.department.name);
            Console.WriteLine("수혜 장학금 내역 : " + this.scholarship);
            Console.WriteLine("-----------------------------------");
        }
        public void change_student_num()
        {
            Console.WriteLine("변경할 학번을 입력해주세요");
            Console.WriteLine("현재값 : " + this.student_num);
            Console.Write("입력 :");
            this.student_num = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("변경되었습니다.");
        }
        public void change_department()
        {
            while (true)
            {
                Console.WriteLine("변경할 학과의 번호를 입력해주세요");
                Console.WriteLine("현재값 : " + this.department.name);
                foreach (var item in Department.department_list)
                {
                    Console.WriteLine(item.number + "." + item.name);

                }
                Console.Write("번호 입력:");
                try
                {
                    int department_chose = int.Parse(Console.ReadLine());
                    if ((department_chose > Department.department_list.Count) || (department_chose < 1))
                    {
                        Console.Clear();
                        Console.WriteLine("※ 정확한 숫자를 입력해주세요");
                        continue;
                    }
                    Console.Clear();

                    foreach (var item in Department.department_list)
                    {
                        if (item.number == department_chose)
                        {
                            Console.WriteLine(item.number + "." + item.name);
                            this.department = item;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("※ 숫자를 입력해주세요");
                    continue;
                }

                Console.Clear();
                Console.WriteLine("※ 변경되었습니다.\n");
            }

        }
        public void change_scholarship()
        {
            Console.WriteLine("변경할 수혜 장학금 내역을 입력해주세요");
            Console.WriteLine("현재값 : " + this.scholarship);
            Console.Write("입력 :");
            this.scholarship = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("※ 변경되었습니다.\n");

        }
        public static void add_student()
        {
            addstudent student = new Student();
            student.add_name();
            student.add_email();
            student.add_phone();
            student.add_student_num();
            student.add_department();
            student.add_scholarship();
            student_list.Add((Student)student);
            Console.WriteLine("정상적으로 추가되었습니다.");

        } // 학생 추가 매서드 
        public void change_student()
        {
            int chose;
            changestudent student = new Student();
            Console.Clear();
            while (true)
            {
                this.print_student();
                Console.WriteLine("변경할 사항을 선택해주세요");
                Console.WriteLine("1.이름  2.학번  3.전화번호  4.이메일  5.학과  6. 수혜 장학금 내역  7.처음으로");
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }

                switch (chose)
                {

                    case 1:
                        student.change_name();
                        break;
                    case 2:
                        student.change_student_num();
                        break;
                    case 3:
                        student.change_phone();
                        break;
                    case 4:
                        student.change_email();
                        break;
                    case 5:
                        student.change_department();
                        break;
                    case 6:
                        student.change_scholarship();
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("※ 정확한 숫자를 입력해주세요\n");
                        continue;

                }
                Console.Clear();
                Console.WriteLine("※ 변경되었습니다\n");
                break;
            }
        } // 학생 변경 매서드
        public static void delete_student()
        {
            
            int chose;
            while (true)
            {
                int i = 1;
                Console.WriteLine("삭제하실 학생의 번호를 입력해주세요");
                Console.WriteLine("학생 목록");
                foreach (var item in student_list)
                {
                    Console.WriteLine(i++ + "." + item.name);
                }
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                Console.Clear();
                while (chose > student_list.Count)
                {

                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    Console.Write("번호 : ");
                    try
                    {
                        chose = int.Parse(Console.ReadLine());
                    }
                    catch
                    {

                        Console.Clear();
                        Console.WriteLine("※ 숫자로 입력해주세요\n");
                        continue;
                    }
                    Console.Clear();
                }
                Console.Clear();
                Student student = new Student();
                student = Student.student_list[chose - 1];
                Console.WriteLine(student_list[chose - 1].name + " 삭제되었습니다.\n");
                Student.student_list.Remove(student);
                foreach (var item in Department.department_list)
                    item.student_list.Remove(student);
                foreach (var item in Subject.subject_list)
                    item.student_list.Remove(student);
                break;

            }

        } // 학생 삭제 매서드
        public static Student chose_student()
        {
            Student student = new Student();
            int chose;
            while (true)
            {
                int i = 1;
                Console.WriteLine("학생의 번호를 입력해주세요");
                foreach (var item in Student.student_list)
                {
                    Console.WriteLine(i + "." + item.name);
                    i++;
                }
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if ((chose > Student.student_list.Count) || (chose == 0))
                {
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    Console.Clear();
                    continue;
                }
                else
                    student = Student.student_list[chose - 1];
                Console.Clear();
                break;
            }

            return student;
        }
        public static void search_student()
        {
            while (true)
            {
                int chose;
              
                Console.WriteLine("검색할 수단을 선택해주세요");
                Console.WriteLine("1. 학번   2.전화번호   3. 이메일  4.이름   5.소속학과  6.처음으로");
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                Console.Clear();
                
                switch (chose)
                {
                    case 1:
                        string student_num;
                        Student student1 = new Student();
                        Console.WriteLine("검색하려는 학생의 학번을 입력해주세요");
                        Console.Write("입력 : ");
                        student_num = Console.ReadLine();
                        student1 = Student.search_student_bystudentnum(student_num);
                        if (student1.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        student1.print_student();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        string phone_num;
                        Console.WriteLine("검색하려는 학생의 전화번호을 입력해주세요");
                        Console.Write("입력 : ");
                        phone_num = Console.ReadLine();
                        Student student2 = new Student();
                        student2 = Student.search_student_byphone(phone_num);
                        if (student2.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        student2.print_student();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        string email;
                        Console.WriteLine("검색하려는 학생의 이메일을 입력해주세요");
                        Console.Write("입력 : ");
                        email = Console.ReadLine();
                        Student student3 = new Student();
                        student3 = Student.search_student_byemail(email);
                        if (student3.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        student3.print_student();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        string name;
                        Console.WriteLine("검색하려는 학생의 이름을 입력해주세요");
                        Console.Write("입력 : ");
                        name = Console.ReadLine();
                        Student student4 = new Student();
                        student4 = Student.search_student_byname(name);
                        if (student4.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        student4.print_student();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        int department_chose;
                        Department department = new Department();
                        Console.WriteLine("검색하려는 학생의 학과를 선택해주세요");
                        Student student5 = new Student();
                        while (true)
                        {
                            foreach (var item in Department.department_list)
                            {
                                Console.WriteLine(item.number + "." + item.name);

                            }
                            Console.Write("번호 입력 :");

                            try
                            {
                                department_chose = int.Parse(Console.ReadLine());
                            }
                            catch
                            {

                                Console.Clear();
                                Console.WriteLine("※ 숫자로 입력해주세요\n");
                                continue;
                            }
                            Console.Clear();
                            if (department_chose > Department.department_list.Count || department_chose < 1)
                            {
                                Console.Clear();
                                Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                continue;
                            }

                            foreach (var item in Department.department_list)
                            {
                                if (department_chose == item.number)
                                    department = item;
                            }
                            Console.Clear();
                            break;
                        }
                        student5 = Student.search_student_bydepartment(department);
                        if (student5.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        student5.print_student();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("※올바른 숫자를 입력해주세요\n");
                        continue;


                }
                break;

            }

        }

    }
    class Faculty : Person
    {
        public int salary; //월급여
        public string fac_num; //사번
        public string join_date; //입사일

        public void add_salary()
        {
            while (true)
            {
                Console.WriteLine("추가할 대상의 월급여를 입력해주세요(* 만단위의 숫자)");
                Console.Write("입력 :");
                try
                {
                    this.salary = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※급여는 숫자로 입력해주세요\n");
                    continue;
                }
                Console.Clear();
                break;
            }
        }
        public void add_fac_num()
        {
            Console.WriteLine("추가할 대상의 사번을 입력해주세요 : ");
            Console.Write("입력 :");
            this.fac_num = Console.ReadLine();
            Console.Clear();
        }
        public void add_join_date()
        {
            Console.WriteLine("추가할 대상의 입사일를 입력해주세요 : ");
            Console.Write("입력 :");
            this.join_date = Console.ReadLine();
            Console.Clear();

        }
        public void change_salary()
        {
            while (true)
            {
                Console.WriteLine("추가할 대상의 월급여를 입력해주세요(* 만단위의 숫자)");
                Console.WriteLine("현재값 : " + this.salary);

                Console.Write("입력 :");
                try
                {
                    this.salary = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※급여는 숫자로 입력해주세요\n");
                    continue;
                }
                Console.Clear();
                break;
            }

        }
        public void change_fac_num()
        {
            Console.WriteLine("변경할 사번을 입력해주세요");
            Console.WriteLine("현재값 : " + this.fac_num);
            Console.Write("입력 :");
            this.fac_num = Console.ReadLine();
            Console.Clear();

        }
        public void change_join_date()
        {
            Console.WriteLine("변경할 입사일을 입력해주세요");
            Console.WriteLine("현재값 : " + this.join_date);
            Console.Write("입력 :");
            this.join_date = Console.ReadLine();

        }
    }


    class Professor : Faculty, addprofessor, changeprofessor
    {

        public Department department; //학과
        public string rank; //직급
        public static List<Professor> professor_list = new List<Professor>();
        public List<Subject> subject_list = new List<Subject>(); //강의 과목

        public Professor()
        {

        }

        public void add_department()
        {
            while (true)
            {
                int department_chose;
                Console.WriteLine("추가할 교수의 학과를 입력해주세요 : ");
                Department department = new Department();
                foreach (var item in Department.department_list)
                {
                    Console.WriteLine(item.number + "." + item.name);

                }
                Console.WriteLine("번호 입력 :");

                try
                {
                    department_chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if (department_chose > Department.department_list.Count || department_chose < 0)
                {
                    Console.Clear();
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    continue;
                }

                foreach (var item in Department.department_list)
                {
                    if (department_chose == item.number)
                        department = item;
                }
                this.department = department;
                Console.Clear();
                break;
            }

        }
        public void add_rank()
        {
            Console.WriteLine("추가할 교수의 직급를 입력해주세요");
            Console.Write("입력 :");
            this.rank = Console.ReadLine();
            Console.Clear();

        }

        public void change_department()
        {
            while (true)
            {
                Console.WriteLine("변경할 학과의 번호를 입력해주세요");
                if (this.department != null)
                    Console.WriteLine("현재값 : " + this.department.name);
                else
                    Console.WriteLine("현재값 : " + "없음");
                foreach (var item in Department.department_list)
                {
                    Console.WriteLine(item.number + "." + item.name);

                }

                try
                {
                    int department_chose = int.Parse(Console.ReadLine());
                    if ((department_chose > Department.department_list.Count) || (department_chose < 1))
                    {
                        Console.Clear();
                        Console.WriteLine("※ 정확한 숫자를 입력해주세요");
                        continue;
                    }
                    if (this.department != null)
                        this.department.professor_list.Remove(this);
                    Console.Clear();

                    foreach (var item in Department.department_list)
                    {
                        if (item.number == department_chose)
                        {
                            Console.WriteLine(item.number + "." + item.name);
                            this.department = item;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("※ 숫자를 입력해주세요");
                    continue;
                }
                this.department.professor_list.Add(this);
                break;
            }


        }
        public void change_rank()
        {
            Console.WriteLine("변경할 대상의 직급을 입력해주세요");
            Console.WriteLine("현재값 : " + this.rank);
            Console.Write("입력 :");
            this.rank = Console.ReadLine();
        }

        public static void add_professor()
        {
            addprofessor professor = new Professor();
            professor.add_name();
            professor.add_email();
            professor.add_phone();
            professor.add_fac_num();
            professor.add_salary();
            professor.add_join_date();
            professor.add_department();
            professor.add_rank();
            professor_list.Add((Professor)professor);
            Console.WriteLine("정상적으로 추가되었습니다.");

        } // 교수 추가 매서드 
        public void change_professor()
        {
            int chose;
            Console.Clear();
            while (true)
            {
                this.print_professor();
                Console.WriteLine("변경할 사항을 선택해주세요");
                Console.WriteLine("1.이름  2.사번  3.전화번호  4.이메일  5.학과  6. 월급여  7. 직급  8. 입사일 ");
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                Console.Clear();
                switch (chose)
                {

                    case 1:
                        this.change_name();
                        break;
                    case 2:
                        this.change_fac_num();
                        break;
                    case 3:
                        this.change_phone();
                        break;
                    case 4:
                        this.change_email();
                        break;
                    case 5:
                        this.change_department();
                        break;
                    case 6:
                        this.change_salary();
                        break;
                    case 7:
                        this.change_salary();
                        break;
                    case 8:
                        this.change_join_date();
                        break;
                    default:
                        Console.WriteLine("※정확한 숫자를 입력해주세요\n");
                        continue;

                }
                Console.Clear();
                Console.WriteLine("※ 변경되었습니다\n");
                break;
            }
        } // 교수 변경 매서드
        public static void delete_professor()
        {
            while (true)
            {
                
                Console.WriteLine("삭제하실 교수의 번호를 입력해주세요");
                Professor professor = new Professor();
                professor = Professor.chose_professor();
                Console.WriteLine("교수 '" + professor.name + "' 삭제되었습니다.\n");

                foreach (var item in Subject.subject_list)
                    if (item.professor == professor)
                        item.professor = null;
                foreach (var item in Department.department_list)
                {
                    item.professor_list.Remove(professor);
                    if (item.professor == professor)
                        item.professor = null;
                }
                Professor.professor_list.Remove(professor);
                break;

            }

        } // 교수 삭제 매서드
        public static Professor chose_professor()
        {
            Professor professor = new Professor();
            int chose;
            while (true)
            {
                int i = 1;
                Console.WriteLine("교수의 번호를 선택해주세요");
                foreach (var item in Professor.professor_list)
                {
                    Console.WriteLine(i + "." + item.name);
                    i++;
                }
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if ((chose > Professor.professor_list.Count) || (chose < 1))
                {
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    Console.Clear();
                    continue;
                }
                else
                {
                    professor = Professor.professor_list[chose - 1];
                    Console.Clear();
                    return professor;
                }

            }
        } //교수 선택 매서드
        public static Professor search_professor_byname(string name)
        {
            Professor professor = new Professor();

            foreach (var item in Professor.professor_list)
            {
                if (name == item.name)
                {
                    professor = item;

                }
            }


            return professor;

        }
        public static Professor search_professor_byphone(string phone_number)
        {
            Professor professor = new Professor();

            foreach (var item in Professor.professor_list)
            {
                if (phone_number.Equals(item.phone_number))
                    professor = item;
            }


            return professor;
        }
        public static Professor search_professor_byemail(string email)
        {
            Professor professor = new Professor();
            foreach (var item in Professor.professor_list)
            {
                if (email.Equals(item.email))
                    professor = item;
            }
            return professor;
        }
        public static Professor search_professor_byfacnum(string fac_num)
        {
            Professor professor = new Professor();
            foreach (var item in Professor.professor_list)
            {

                if (fac_num == item.fac_num)
                {
                    professor = item;

                }
            }
            return professor;

        }
        public static Professor search_professor_bydepartment(Department department)
        {
            int chose;     
            Professor professor = new Professor();
            while (true)
            {
                int i = 1;
                foreach (var item in department.professor_list)
                {
                    Console.WriteLine(i++ + "." + item.name);

                }
                Console.Write("번호 입력 :");

                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if (chose > Department.department_list.Count || chose < 1)
                {
                    Console.Clear();
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    continue;
                }
                professor = department.professor_list[chose - 1];
                return professor;
            }


        }
        public static void search_professor()
        {
            while (true)
            {
                int chose;

                Console.WriteLine("검색할 수단을 선택해주세요");
                Console.WriteLine("1. 사번   2.전화번호   3. 이메일  4.이름   5.소속학과  6.처음으로");
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                Console.Clear();

                switch (chose)
                {
                    case 1:
                        string fac_num;
                        Professor professor1 = new Professor();
                        Console.WriteLine("검색하려는 교수의 사번을 입력해주세요");
                        Console.Write("입력 : ");
                        fac_num = Console.ReadLine();
                        professor1 = Professor.search_professor_byfacnum(fac_num);
                        if (professor1.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        else
                        professor1.print_professor();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        string phone_num;
                        Console.WriteLine("검색하려는 교수의 전화번호을 입력해주세요");
                        Console.Write("입력 : ");
                        phone_num = Console.ReadLine();
                        Professor professor2 = new Professor();
                        professor2 = Professor.search_professor_byphone(phone_num);
                        if (professor2.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        else
                        professor2.print_professor();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        string email;
                        Console.WriteLine("검색하려는 교수의 이메일을 입력해주세요");
                        Console.Write("입력 : ");
                        email = Console.ReadLine();
                        Professor professor3 = new Professor();
                        professor3 = Professor.search_professor_byemail(email);
                        if (professor3.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        else
                        professor3.print_professor();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        string name;
                        Console.WriteLine("검색하려는 교수의 이름을 입력해주세요");
                        Console.Write("입력 : ");
                        name = Console.ReadLine();
                        Professor professor4 = new Professor();
                        professor4 = Professor.search_professor_byname(name);
                        if (professor4.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        else
                        professor4.print_professor();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        int department_chose;
                        Department department = new Department();
                        Console.WriteLine("검색하려는 교수의 학과를 선택해주세요");
                        Professor professor5 = new Professor();
                        while (true)
                        {
                            foreach (var item in Department.department_list)
                            {
                                Console.WriteLine(item.number + "." + item.name);

                            }
                            Console.Write("번호 입력 :");

                            try
                            {
                                department_chose = int.Parse(Console.ReadLine());
                            }
                            catch
                            {

                                Console.Clear();
                                Console.WriteLine("※ 숫자로 입력해주세요\n");
                                continue;
                            }
                            Console.Clear();
                            if (department_chose > Department.department_list.Count || department_chose < 1)
                            {
                                Console.Clear();
                                Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                continue;
                            }

                            foreach (var item in Department.department_list)
                            {
                                if (department_chose == item.number)
                                    department = item;
                            }
                            Console.Clear();
                            break;
                        }
                        professor5 = Professor.search_professor_bydepartment(department);
                        if (professor5.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        else
                        professor5.print_professor();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                        continue;


                }
                break;


            }

        }
        public void print_professor()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("교수 '" + this.name + "'의 정보");
            Console.WriteLine("사번 : " + this.fac_num);
            Console.WriteLine("전화번호 : " + this.phone_number);
            Console.WriteLine("이메일 : " + this.email);
            Console.WriteLine("소속학과: " + this.department.name);
            Console.WriteLine("월급여 : " + this.salary);
            Console.WriteLine("입사일 : " + this.join_date);
            Console.WriteLine("-----------------------------------");

        }
    }

    class Staff : Faculty, addstaff, changestaff
    {
        public string rank; //직급
        public Department department;  //소속부서
        public static List<Staff> staff_list = new List<Staff>();
        public Staff(string name, string phone_number, string email, string fac_num, int salary, string join_date, Department department, string rank)
        {
            this.name = name;
            this.phone_number = phone_number;
            this.email = email;
            this.fac_num = fac_num;
            this.salary = salary;
            this.join_date = join_date;
            this.department = department;
            this.rank = rank;
        }
        public Staff()
        {

        }
        public void add_rank()
        {
            Console.WriteLine("추가할 직원의 직급를 입력해주세요");
            Console.Write("입력 :");
            this.rank = Console.ReadLine();
            Console.Clear();

        }
        public void add_department()
        {
            while (true)
            {
                int department_chose;
                Console.WriteLine("추가할 직원의 학과를 입력해주세요 : ");
                Department department = new Department();
                foreach (var item in Department.department_list)
                {
                    Console.WriteLine(item.number + "." + item.name);

                }
                Console.WriteLine("번호 입력 :");

                try
                {
                    department_chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if (department_chose > Department.department_list.Count || department_chose < 0)
                {
                    Console.Clear();
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    continue;
                }

                foreach (var item in Department.department_list)
                {
                    if (department_chose == item.number)
                        department = item;
                }
                this.department = department;
                department.staff_list.Add(this);
                Console.Clear();
                break;
            }

        }
        public void change_rank()
        {
            Console.WriteLine("변경할 대상의 직급을 입력해주세요");
            Console.WriteLine("현재값 : " + this.rank);
            Console.Write("입력 :");
            this.rank = Console.ReadLine();
        }
        public void change_department()
        {
            while (true)
            {
                Console.WriteLine("변경할 학과의 번호를 입력해주세요");
                if (this.department != null)
                    Console.WriteLine("현재값 : " + this.department.name);
                else
                    Console.WriteLine("현재값 : " + "없음");
                foreach (var item in Department.department_list)
                {
                    Console.WriteLine(item.number + "." + item.name);

                }

                try
                {
                    int department_chose = int.Parse(Console.ReadLine());
                    if ((department_chose > Department.department_list.Count) || (department_chose < 1))
                    {
                        Console.Clear();
                        Console.WriteLine("※ 정확한 숫자를 입력해주세요");
                        continue;
                    }
                    Console.Clear();

                    foreach (var item in Department.department_list)
                    {
                        if (item.number == department_chose)
                        {
                            Console.WriteLine(item.number + "." + item.name);
                            this.department = item;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("※ 숫자를 입력해주세요");
                    continue;
                }
                break;
            }

        }
        public static Staff chose_staff()
        {
            Staff staff = new Staff();
            int chose;
            while (true)
            {
                int i = 1;
                Console.WriteLine("직원의 번호를 선택해주세요");
                foreach (var item in Staff.staff_list)
                {
                    Console.WriteLine(i + "." + item.name);
                    i++;
                }
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if ((chose > Staff.staff_list.Count) || (chose == 0))
                {
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    Console.Clear();
                    continue;
                }
                else
                {
                    staff = Staff.staff_list[chose - 1];
                    return staff;
                }

            }
        } //직원 검색후 반환 메서드

        public static void add_staff()
        {
            addstaff staff = new Staff();
            staff.add_name();
            staff.add_email();
            staff.add_phone();
            staff.add_fac_num();
            staff.add_salary();
            staff.add_join_date();
            staff.add_department();
            staff.add_rank();
            Staff.staff_list.Add((Staff)staff);
            Console.WriteLine("정상적으로 추가되었습니다.");

        }
        public void change_staff()
        {
            int chose;
            Console.Clear();
            while (true)
            {
                this.print_staff();
                Console.WriteLine("변경할 사항을 선택해주세요");
                Console.WriteLine("1.이름  2.사번  3.전화번호  4.이메일  5.학과  6. 월급여  7. 직급  8. 입사일  9.처음으로 ");
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                Console.Clear();
                switch (chose)
                {

                    case 1:
                        this.change_name();
                        break;
                    case 2:
                        this.change_fac_num();
                        break;
                    case 3:
                        this.change_phone();
                        break;
                    case 4:
                        this.change_email();
                        break;
                    case 5:
                        this.change_department();
                        break;
                    case 6:
                        this.change_salary();
                        break;
                    case 7:
                        this.change_salary();
                        break;
                    case 8:
                        this.change_join_date();
                        break;
                    case 9:
                    default:
                        Console.WriteLine("※정확한 숫자를 입력해주세요\n");
                        continue;

                }
                Console.Clear();
                Console.WriteLine("※ 변경되었습니다\n");
                break;
            }
        } // 직원 변경 매서드

        public static void delete_staff()
        {
            
            int chose;
            while (true)
            {
                int i = 1;
                Console.WriteLine("삭제하실 직원의 번호를 입력해주세요");
                Console.WriteLine("직원 목록");
                foreach (var item in staff_list)
                {
                    Console.WriteLine(i++ + "." + item.name);
                }
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                Console.Clear();
                while (chose > staff_list.Count)
                {

                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    Console.Write("번호 : ");
                    try
                    {
                        chose = int.Parse(Console.ReadLine());
                    }
                    catch
                    {

                        Console.Clear();
                        Console.WriteLine("※ 숫자로 입력해주세요\n");
                        continue;
                    }
                    Console.Clear();
                }
                Console.Clear();
                Console.WriteLine("직원 " + staff_list[chose - 1].name + "이 삭제되었습니다.\n");
                staff_list.RemoveAt(chose - 1);
                break;
            }

        } // 직원 삭제 매서드
        public static Staff search_staff_byname(string name)
        {
            Staff staff = new Staff();

            foreach (var item in Staff.staff_list)
            {
                if (name == item.name)
                {
                    staff = item;

                }
            }


            return staff;

        }
        public static Staff search_staff_byphone(string phone_number)
        {
            Staff staff = new Staff();

            foreach (var item in Staff.staff_list)
            {
                if (phone_number.Equals(item.phone_number))
                    staff = item;
            }


            return staff;
        }
        public static Staff search_staff_byemail(string email)
        {
            Staff staff = new Staff();
            foreach (var item in Staff.staff_list)
            {
                if (email.Equals(item.email))
                    staff = item;
            }
            return staff;
        }
        public static Staff search_staff_byfacnum(string fac_num)
        {
            Staff staff = new Staff();
            foreach (var item in Staff.staff_list)
            {

                if (fac_num == item.fac_num)
                {
                    staff = item;

                }
            }
            return staff;

        }
        public static Staff search_staff_bydepartment(Department department)
        {
            int chose;
            
            Staff staff = new Staff();
            while (true)
            {
                int i = 1;
                foreach (var item in department.staff_list)
                {
                    Console.WriteLine(i++ + "." + item.name);

                }
                Console.Write("번호 입력 :");

                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if (chose > Department.department_list.Count || chose < 1)
                {
                    Console.Clear();
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    continue;
                }
                staff = department.staff_list[chose - 1];
                return staff;
            }


        }
        public static void search_staff()
        {
            while (true)
            {
                int chose;

                Console.WriteLine("검색할 수단을 선택해주세요");
                Console.WriteLine("1. 사번   2.전화번호   3. 이메일  4.이름   5.소속학과  6.처음으로");
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                Console.Clear();

                switch (chose)
                {
                    case 1:
                        string fac_num;
                        Staff staff1 = new Staff();
                        Console.WriteLine("검색하려는 직원의 학번을 입력해주세요");
                        Console.Write("입력 : ");
                        fac_num = Console.ReadLine();
                        staff1 = Staff.search_staff_byfacnum(fac_num);
                        if (staff1.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        staff1.print_staff();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        string phone_num;
                        Console.WriteLine("검색하려는 직원의 전화번호을 입력해주세요");
                        Console.Write("입력 : ");
                        phone_num = Console.ReadLine();
                        Staff staff2 = new Staff();
                        staff2 = Staff.search_staff_byphone(phone_num);
                        if (staff2.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        staff2.print_staff();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        string email;
                        Console.WriteLine("검색하려는 직원의 이메일을 입력해주세요");
                        Console.Write("입력 : ");
                        email = Console.ReadLine();
                        Staff staff3 = new Staff();
                        staff3 = Staff.search_staff_byemail(email);
                        if (staff3.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        staff3.print_staff();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        string name;
                        Console.WriteLine("검색하려는 직원의 이름을 입력해주세요");
                        Console.Write("입력 : ");
                        name = Console.ReadLine();
                        Staff staff4 = new Staff();
                        staff4 = Staff.search_staff_byname(name);
                        if (staff4.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        staff4.print_staff();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        int department_chose;
                        Department department = new Department();
                        Console.WriteLine("검색하려는 직원의 학과를 선택해주세요");
                        Staff staff5 = new Staff();
                        while (true)
                        {
                            foreach (var item in Department.department_list)
                            {
                                Console.WriteLine(item.number + "." + item.name);

                            }
                            Console.Write("번호 입력 :");

                            try
                            {
                                department_chose = int.Parse(Console.ReadLine());
                            }
                            catch
                            {

                                Console.Clear();
                                Console.WriteLine("※ 숫자로 입력해주세요\n");
                                continue;
                            }
                            Console.Clear();
                            if (department_chose > Department.department_list.Count || department_chose < 1)
                            {
                                Console.Clear();
                                Console.WriteLine("올바른 숫자를 입력해주세요\n");
                                continue;
                            }

                            foreach (var item in Department.department_list)
                            {
                                if (department_chose == item.number)
                                    department = item;
                            }
                            Console.Clear();
                            break;
                        }
                        staff5 = Staff.search_staff_bydepartment(department);
                        if (staff5.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        staff5.print_staff();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("※올바른 숫자를 입력해주세요\n");
                        continue;


                }
                break;

            }

        }
        public void print_staff()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("직원 '" + this.name + "'의 정보");
            Console.WriteLine("사번 : " + this.fac_num);
            Console.WriteLine("전화번호 : " + this.phone_number);
            Console.WriteLine("이메일 : " + this.email);
            Console.WriteLine("소속학과: " + this.department.name);
            Console.WriteLine("월급여 : " + this.salary);
            Console.WriteLine("입사일 : " + this.join_date);
            Console.WriteLine("-----------------------------------");
        }


    }

    class Assistant : Faculty, addassistant, changeassistant
    {
        public Department department; // 소속부서
        public Subject subject; // 조교 배당 과목
        public static List<Assistant> assistant_list = new List<Assistant>();

        public Assistant(string name, string phone_number, string email, string fac_num, int salary, string join_date, Department department, string rank)
        {
            this.name = name;
            this.phone_number = phone_number;
            this.email = email;
            this.fac_num = fac_num;
            this.salary = salary;
            this.join_date = join_date;
            this.department = department;
        }
        public Assistant()
        {

        }
        public static Assistant chose_assistant()
        {
            Assistant assistant = new Assistant();
            int chose;
            while (true)
            {
                int i = 1;
                Console.WriteLine("직원의 번호를 선택해주세요");
                foreach (var item in Assistant.assistant_list)
                {
                    Console.WriteLine(i + "." + item.name);
                    i++;
                }
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if ((chose > Assistant.assistant_list.Count) || (chose == 0))
                {
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    Console.Clear();
                    continue;
                }
                else
                {
                    assistant = Assistant.assistant_list[chose - 1];
                    return assistant;
                }

            }
        } //조교 검색후 반환 메서드
        public void add_department()
        {
            while (true)
            {
                int department_chose;
                Console.WriteLine("추가할 조교의 학과를 입력해주세요 : ");
                Department department = new Department();
                foreach (var item in Department.department_list)
                {
                    Console.WriteLine(item.number + "." + item.name);

                }
                Console.WriteLine("번호 입력 :");

                try
                {
                    department_chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if (department_chose > Department.department_list.Count || department_chose < 0)
                {
                    Console.Clear();
                    Console.WriteLine("올바른 숫자를 입력해주세요\n");
                    continue;
                }

                foreach (var item in Department.department_list)
                {
                    if (department_chose == item.number)
                        department = item;
                }
                this.department = department;
                Console.Clear();
                break;
            }

        }
        public void change_department()
        {
            while (true)
            {
                Console.WriteLine("변경할 학과의 번호를 입력해주세요");
                if (this.department != null)
                    Console.WriteLine("현재값 : " + this.department.name);
                else
                    Console.WriteLine("현재값 : " + "없음");
                foreach (var item in Department.department_list)
                {
                    Console.WriteLine(item.number + "." + item.name);

                }

                try
                {
                    int department_chose = int.Parse(Console.ReadLine());
                    if ((department_chose > Department.department_list.Count) || (department_chose < 1))
                    {
                        Console.Clear();
                        Console.WriteLine("※ 정확한 숫자를 입력해주세요");
                        continue;
                    }
                    Console.Clear();

                    foreach (var item in Department.department_list)
                    {
                        if (item.number == department_chose)
                        {
                            Console.WriteLine(item.number + "." + item.name);
                            this.department = item;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("※ 숫자를 입력해주세요");
                    continue;
                }
                break;
            }

        }

        public static void add_assistant()
        {
            addassistant assistant = new Assistant();
            assistant.add_name();
            assistant.add_email();
            assistant.add_phone();
            assistant.add_fac_num();
            assistant.add_salary();
            assistant.add_join_date();
            assistant.add_department();
            Assistant.assistant_list.Add((Assistant)assistant);
            ((Assistant)assistant).department.assistant_list.Add((Assistant)assistant);
            Console.WriteLine("정상적으로 추가되었습니다.");

        }
        public void change_assistant()
        {
            int chose;
            Console.Clear();
            while (true)
            {
                this.print_assistant();
                Console.WriteLine("변경할 사항을 선택해주세요");
                Console.WriteLine("1.이름  2.사번  3.전화번호  4.이메일  5.학과  6. 월급여 7. 입사일 ");
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                Console.Clear();
                switch (chose)
                {

                    case 1:
                        this.change_name();
                        break;
                    case 2:
                        this.change_fac_num();
                        break;
                    case 3:
                        this.change_phone();
                        break;
                    case 4:
                        this.change_email();
                        break;
                    case 5:
                        this.change_department();
                        break;
                    case 6:
                        this.change_salary();
                        break;
                    case 7:
                        this.change_join_date();
                        break;
                    default:
                        Console.WriteLine("※ 정확한 숫자를 입력해주세요\n");
                        continue;

                }
                Console.Clear();
                Console.WriteLine("※ 변경되었습니다\n");
                break;
            }

        }
        public static void delete_assistant()
        {
            
            int chose;
            Assistant assistant = new Assistant();
            while (true)
            {
                int i = 1;
                Console.WriteLine("삭제하실 조교의 번호를 입력해주세요");
                Console.WriteLine("조교 목록");
                foreach (var item in Assistant.assistant_list)
                {
                    Console.WriteLine(i++ + "." + item.name);
                }
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                Console.Clear();
                while (chose > Assistant.assistant_list.Count || chose < 1)
                {

                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    Console.Write("번호 : ");
                    try
                    {
                        chose = int.Parse(Console.ReadLine());
                    }
                    catch
                    {

                        Console.Clear();
                        Console.WriteLine("※ 숫자로 입력해주세요\n");
                        continue;
                    }
                    Console.Clear();
                }
                Console.Clear();
                assistant = Assistant.assistant_list[chose - 1];
                Console.WriteLine("※ 조교 " + assistant_list[chose - 1].name + "이 삭제되었습니다.\n");
                foreach(var item in Subject.subject_list)
                {
                    if (item.assistant == assistant)
                        item.assistant = null;
                }
                assistant.department.assistant = null;
                assistant_list.RemoveAt(chose - 1);
                break;
            }

        } // 조교 삭제 메서드
        public static Assistant search_assistant_byname(string name)
        {
            Assistant assistant = new Assistant();

            foreach (var item in Assistant.assistant_list)
            {
                if (name == item.name)
                {
                    assistant = item;

                }
            }


            return assistant;

        }
        public static Assistant search_assistant_byphone(string phone_number)
        {
            Assistant assistant = new Assistant();

            foreach (var item in Assistant.assistant_list)
            {
                if (phone_number.Equals(item.phone_number))
                    assistant = item;
            }


            return assistant;
        }
        public static Assistant search_assistant_byemail(string email)
        {
            Assistant assistant = new Assistant();
            foreach (var item in Assistant.assistant_list)
            {
                if (email.Equals(item.email))
                    assistant = item;
            }
            return assistant;
        }
        public static Assistant search_assistant_byfacnum(string fac_num)
        {
            Assistant assistant = new Assistant();
            foreach (var item in Assistant.assistant_list)
            {

                if (fac_num == item.fac_num)
                {
                    assistant = item;

                }
            }
            return assistant;

        }
        public static Assistant search_assistant_bydepartment(Department department)
        {
            int chose;
            
            Assistant assistant = new Assistant();
            while (true)
            {
                int i = 1;
                foreach (var item in department.assistant_list)
                {
                    Console.WriteLine(i++ + "." + item.name);

                }
                Console.Write("번호 입력 :");

                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if (chose > Department.department_list.Count || chose < 1)
                {
                    Console.Clear();
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    continue;
                }
                assistant = department.assistant_list[chose - 1];
                return assistant;
            }


        }
        public static void search_assistant()
        {
            while (true)
            {
                int chose;

                Console.WriteLine("검색할 수단을 선택해주세요");
                Console.WriteLine("1. 사번   2.전화번호   3. 이메일  4.이름   5.소속학과  6.처음으로");
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                Console.Clear();

                switch (chose)
                {
                    case 1:
                        string fac_num;
                        Assistant assistant1 = new Assistant();
                        Console.WriteLine("검색하려는 조교의 사번을 입력해주세요");
                        Console.Write("입력 : ");
                        fac_num = Console.ReadLine();
                        assistant1 = Assistant.search_assistant_byfacnum(fac_num);
                        if (assistant1.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        else
                            assistant1.print_assistant();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        string phone_num;
                        Console.WriteLine("검색하려는 조교의 전화번호을 입력해주세요");
                        Console.Write("입력 : ");
                        phone_num = Console.ReadLine();
                        Assistant assistant2 = new Assistant();
                        assistant2 = Assistant.search_assistant_byphone(phone_num);
                        if (assistant2.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        else
                            assistant2.print_assistant();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        string email;
                        Console.WriteLine("검색하려는 조교의 이메일을 입력해주세요");
                        Console.Write("입력 : ");
                        email = Console.ReadLine();
                        Assistant assistant3 = new Assistant();
                        assistant3 = Assistant.search_assistant_byemail(email);
                        if (assistant3.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        else
                        assistant3.print_assistant();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        string name;
                        Console.WriteLine("검색하려는 조교의 이름을 입력해주세요");
                        Console.Write("입력 : ");
                        name = Console.ReadLine();
                        Assistant assistant4 = new Assistant();
                        assistant4 = Assistant.search_assistant_byname(name);
                        if (assistant4.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        else
                        assistant4.print_assistant();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        int department_chose;
                        Department department = new Department();
                        Console.WriteLine("검색하려는 조교의 학과를 선택해주세요");
                        Assistant assistant5 = new Assistant();
                        while (true)
                        {
                            foreach (var item in Department.department_list)
                            {
                                Console.WriteLine(item.number + "." + item.name);

                            }
                            Console.Write("번호 입력 :");

                            try
                            {
                                department_chose = int.Parse(Console.ReadLine());
                            }
                            catch
                            {

                                Console.Clear();
                                Console.WriteLine("※ 숫자로 입력해주세요\n");
                                continue;
                            }
                            Console.Clear();
                            if (department_chose > Department.department_list.Count || department_chose < 1)
                            {
                                Console.Clear();
                                Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                continue;
                            }

                            foreach (var item in Department.department_list)
                            {
                                if (department_chose == item.number)
                                    department = item;
                            }
                            Console.Clear();
                            break;
                        }
                        assistant5 = Assistant.search_assistant_bydepartment(department);
                        if (assistant5.name == null)
                        {
                            Console.Clear();
                            Console.WriteLine("※ 검색 결과가 없습니다\n");
                            continue;

                        }
                        else
                        assistant5.print_assistant();
                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                        continue;


                }
                break;


            }

        }
        public void print_assistant()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("조교 '" + this.name + "'의 정보");
            Console.WriteLine("사번 : " + this.fac_num);
            Console.WriteLine("전화번호 : " + this.phone_number);
            Console.WriteLine("이메일 : " + this.email);
            Console.WriteLine("소속학과: " + this.department.name);
            Console.WriteLine("월급여 : " + this.salary);
            Console.WriteLine("입사일 : " + this.join_date);

        }

    }

    class Department
    {
        public static int counter = 1;
        public int number = counter;
        public string name; //학과 명
        public string address; //학과 주소
        public string tel_num; // 학과 전화번호 
        public Person assistant;  //학과 조교명
        public Person professor; //학과장명
        public string department_email; //학과 이메일
        public string department_web; // 학과 웹사이트
        public List<Professor> professor_list = new List<Professor>();
        public List<Student> student_list = new List<Student>();
        public List<Subject> subject_list = new List<Subject>();
        public List<Assistant> assistant_list = new List<Assistant>();
        public List<Staff> staff_list = new List<Staff>();
        public static List<Department> department_list = new List<Department>();

        public Department()
        {
            this.number = counter++;
        }

        public static void add_department()
        {
            Department department = new Department();
            Console.WriteLine("추가할 학과의 이름을 입력해주세요 : ");
            department.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("추가할 학과의 주소를 입력해주세요 : ");
            department.address = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("추가할 학과의 전화번호를 입력해주세요 : ");
            department.tel_num = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("추가할 학과의 이메일을 입력해주세요 : ");
            department.department_email = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("추가할 학과의 조교를 선택해주세요");
            Assistant assistant = new Assistant();
            assistant = Assistant.chose_assistant();
            department.assistant = assistant;
            Console.WriteLine("추가할 학과의 학과장을 선택해주세요 : ");
            Professor professor = new Professor();
            professor = Professor.chose_professor();
            department.professor = professor;
            Console.Clear();
            Console.WriteLine("추가할 학과의 웹사이트를 입력해주세요 : ");
            department.department_web = Console.ReadLine();
            Console.Clear();
            department_list.Add(department);
            Console.WriteLine("성공적으로 추가되었습니다.\n");
        }
        public static Department chose_department()
        {
            int chose;
            Department department = new Department();
            while (true)
            {

                Console.WriteLine("변경할 학과를 선택해주세요. ");
                foreach (var item in Department.department_list)
                {
                    Console.WriteLine(item.number + "." + item.name);

                }
                Console.WriteLine("번호 입력 :");
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }

                if ((chose > Department.department_list.Count) || chose < 1)
                {
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    Console.Clear();
                    continue;
                }
                department = department_list[chose - 1];
                Console.Clear();
                break;
            }
            return department;
        } 
        
        public void change_name()
        {
            Console.WriteLine("변경할 이름을 입력해주세요");
            Console.WriteLine("현재값 : " + this.name);
            Console.Write("입력 :");
            this.name = Console.ReadLine();   
            Console.Clear();
        }
        public void change_address()
        {
            Console.WriteLine("변경할 이름을 입력해주세요");
            Console.WriteLine("현재값 : " + this.address);
            Console.Write("입력 :");
            this.address = Console.ReadLine();
            Console.Clear();
        }
        public void change_tel_num()
        {
            Console.WriteLine("변경할 이름을 입력해주세요");
            Console.WriteLine("현재값 : " + this.tel_num);
            Console.Write("입력 :");
            this.tel_num = Console.ReadLine();
            Console.Clear();
        }
        public void change_department_professor() //학과장 변경
        {
            
            int chose;
            while (true)
            {
                int i = 1;
                Console.WriteLine(this.name + "의 교수목록");
                foreach (var item in professor_list)
                {
                    Console.WriteLine(i++ + "." + item.name);
                }
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if ((chose > this.professor_list.Count) || (chose < 1))
                {
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    Console.Clear();
                    continue;
                }
                else
                {
                    this.professor = this.professor_list[chose - 1];
                    Console.Clear();
                }
                break;
            }

        }
        public void change_assistant() //학과 조교 변경
        {
            
            int chose;
            while (true)
            {
                int i = 1;
                Console.WriteLine(this.name + "의 조교목록");
                foreach (var item in assistant_list)
                {
                    Console.WriteLine(i++ + "." + item.name);
                }
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if ((chose > this.assistant_list.Count) || (chose < 1))
                {
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    Console.Clear();
                    continue;
                }
                else
                {
                    this.assistant = this.assistant_list[chose - 1];
                    Console.Clear();
                }
                break;
            }
        }
        public void change_department_email()
        {
            Console.WriteLine("변경할 학과 이메일을 입력해주세요");
            Console.WriteLine("현재값 : " + this.department_email);
            Console.Write("입력 :");
            this.department_email = Console.ReadLine();
            Console.Clear();
        }
        public void change_web()
        {
            Console.WriteLine("변경할 학과 웹사이트 주소을 입력해주세요");
            Console.WriteLine("현재값 : " + this.department_web);
            Console.Write("입력 :");
            this.department_web = Console.ReadLine();
            Console.Clear();
        }

        public void change_student() //학과 소속 학생 변경
        {
            int chose;
            changestudent student = new Student();
            while (true)
            {
                int i = 1;
                Console.WriteLine("변경할 학생의 번호를 입력해주세요");
                Console.WriteLine("학생 목록");
                foreach (var item in this.student_list)
                {
                    Console.WriteLine(i++ + "." + item.name);
                }
                Console.Write("번호 : ");
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                try
                {
                    student = this.student_list[chose - 1];
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 맞는 번호를 입력해주세요\n");
                    continue;
                }
                break;
            }
            Console.Clear();
            while (true)
            {
                Console.WriteLine("변경할 사항을 선택해주세요");
            Console.WriteLine("1.이름  2.학번  3.전화번호  4.이메일  5.학과  6. 수혜 장학금 내역  7.처음으로");
            chose = int.Parse(Console.ReadLine());
            Console.Clear();
            
                switch (chose)
                {

                    case 1:
                        student.change_name();
                        break;
                    case 2:
                        student.change_student_num();
                        break;
                    case 3:
                        student.change_phone();
                        break;
                    case 4:
                        student.change_email();
                        break;
                    case 5:
                        student.change_department();
                        break;
                    case 6:
                        student.change_scholarship();
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("※ 정확한 숫자를 입력해주세요\n");
                        continue;

                }
                Console.Clear();
                Console.WriteLine("※ 변경되었습니다.\n");
                break;
            }
        }
        public void change_professor() //학과 소속 교수 변경
        {
            int chose;
            changeprofessor professor = new Professor();
            professor = Professor.chose_professor();
            Console.Clear();
            while (true)
            {
                Console.WriteLine("변경할 사항을 선택해주세요");
                Console.WriteLine("1.이름  2.사번  3.전화번호  4.이메일  5.학과  6. 월급여  7. 직급  8. 입사일 ");
                chose = int.Parse(Console.ReadLine());
                Console.Clear();
            
                switch (chose)
                {

                    case 1:
                        professor.change_name();
                        break;
                    case 2:
                        professor.change_fac_num();
                        break;
                    case 3:
                        professor.change_phone();
                        break;
                    case 4:
                        professor.change_email();
                        break;
                    case 5:
                        professor.change_department();
                        break;
                    case 6:
                        professor.change_salary();
                        break;
                    case 7:
                        professor.change_rank();
                        break;
                    case 8:
                        professor.change_join_date();
                        break;
                    default:
                        Console.WriteLine("※ 정확한 숫자를 입력해주세요\n");
                        continue;

                }
                Console.Clear();
                Console.WriteLine("※ 변경되었습니다\n");
                break;
            }
        }

        public void change_department_info() //학과 정보 변경 메서드{
        {
            int chose;
            Console.Clear();
            while (true)
            {
                this.print_department();
                Console.WriteLine("변경할 사항을 선택해주세요");
                Console.WriteLine("1.이름  2.학과 주소  3.학과 전화번호  4.학과장  5.학과조교  6.이메일  7. 웹사이트 ");
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                Console.Clear();
                switch (chose)
                {

                    case 1:
                        this.change_name();
                        break;
                    case 2:
                        this.change_address();
                        break;
                    case 3:
                        this.change_tel_num();
                        break;
                    case 4:
                        this.change_department_professor();
                        break;
                    case 5:
                        this.change_assistant();
                        break;
                    case 6:
                        this.change_department_email();
                        break;
                    case 7:
                        this.change_web();
                        break;
                    default:
                        Console.WriteLine("※ 정확한 숫자를 입력해주세요\n");
                        continue;

                }
                Console.Clear();
                Console.WriteLine("※ 변경되었습니다\n");
                break;
            }
        }
        public void print_department()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("학과 '" + this.name + "'의 정보");
            Console.WriteLine("주소 : " + this.address);
            Console.WriteLine("전화번호 : " + this.tel_num);
            Console.Write("학과장 : ");
            if (professor == null)
                Console.WriteLine("null");
            else
                Console.WriteLine(this.professor.name);
            Console.Write("학과조교 : ");
            if (assistant == null)
                Console.WriteLine("null");
            else
                Console.WriteLine(this.assistant.name);
            Console.WriteLine("이메일 : " + this.department_email);
            Console.WriteLine("웹사이트 : " + this.department_web);
            Console.WriteLine("-----------------------------------");

        }

        public static Department search_department(string name)
        {
            
            Department department = new Department();
            foreach (var item in Department.department_list)   
            {
                if (name == item.name)   
                {
                    department = item;
                }    
            }
            return department;
            
        } 
        public Student chose_student()
        {
            Student student = new Student();
            int chose;
            while (true)
            {
                int i = 1;
                Console.WriteLine("학생의 번호를 선택해주세요");
                foreach (var item in this.student_list)
                {
                    Console.WriteLine(i + "." + item.name);
                    i++;
                }
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if ((chose > this.student_list.Count) || (chose == 0))
                {
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    Console.Clear();
                    continue;
                }
                else
                    student = Student.student_list[chose - 1];
                break;
            }
            return student;
        } //학과 소속 검색
    }

    class Subject
    {
        public string name; // 과목 이름
        public Professor professor; //과목 담당 교수
        public string classroom_num; //강의실번호
        public string grade; // 성적 (학생전용)
        public string credit; //학점단위
        public Department department;
        public Assistant assistant; //담당 조교
        public string subject_kind;
        public static List<Subject> subject_list = new List<Subject>();
        public List<Student> student_list = new List<Student>();


        public void add_name()
        {
            Console.WriteLine("추가할 과목의 이름을 입력해주세요.");
            Console.Write("입력 :");
            this.name = Console.ReadLine();
            Console.Clear();
        }
        public void add_credit()
        {
            while (true)
            {
                Console.WriteLine("추가할 과목의 학점단위를 입력해주세요");
                Console.Write("입력 :");
                this.credit = Console.ReadLine();
                Console.Clear();
                if (!(string.Equals(this.credit, "0") || string.Equals(this.credit, "1") || string.Equals(this.credit, "2") || string.Equals(this.credit, "3") || string.Equals(this.credit, "4")))
                {
                    Console.Clear();
                    Console.WriteLine("※정확한 학점단위를 입력해주세요(0 ~ 4)\n");
                    continue;
                }
                break;
            }
        }
        public void add_subject_kind()
        {
            Console.WriteLine("추가할 과목의 이수구분을 입력해주세요 (교선/교필/전선/전필)");
            Console.Write("입력 :");
            this.subject_kind = Console.ReadLine();
            Console.Clear();
            while (!(string.Equals(this.subject_kind, "교선") || string.Equals(this.subject_kind, "교필") || string.Equals(this.subject_kind, "전선") || string.Equals(this.subject_kind, "전필")))
            {
                Console.WriteLine("정확한 이수구분을 입력 해주세요 (교선/교필/전선/전필)");
                Console.Write("입력 :");
                this.subject_kind = Console.ReadLine();
                Console.Clear();
            }
        }

        public void add_department()
        {
            while (true)
            {
                int department_chose;
                Console.WriteLine("추가할 과목의 담당 학과를 입력해주세요 : ");
                Department department = new Department();
                foreach (var item in Department.department_list)
                {
                    Console.WriteLine(item.number + "." + item.name);

                }
                Console.WriteLine("번호 입력 :");

                try
                {
                    department_chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if (department_chose > Department.department_list.Count || department_chose < 0)
                {
                    Console.Clear();
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    continue;
                }

                foreach (var item in Department.department_list)
                {
                    if (department_chose == item.number)
                        department = item;
                }
                this.department = department;
                department.subject_list.Add(this);
                Console.Clear();
                break;
            }

        }
        public void add_professor()
        {
            while (true)
            {

                Console.WriteLine("과목의 담당 교수를 선택해주세요");
                Professor professor = new Professor();
                professor = Professor.chose_professor();
                Console.Clear();
                this.professor = professor;
                professor.subject_list.Add(this);
                break;
            }

        }
        public void add_classroom_num()
        {
            Console.WriteLine("과목의 강의실 번호를 입력해주세요");
            Console.Write("입력 :");
            this.classroom_num = Console.ReadLine();
            Console.Clear();

        }
        public void add_assistant()
        {
            while (true)
            {
                Console.WriteLine("과목의 담당 조교를 선택해주세요");
                int i = 1;
                int chose;
                Assistant assistant = new Assistant();
                foreach (var item in Assistant.assistant_list)
                {
                    Console.WriteLine(i + "." + item.name);
                    i++;
                }
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                assistant = Assistant.assistant_list[chose - 1];
                Console.Clear();
                break;
            }

        }

        public void change_name()
        {
            Console.WriteLine("변경할 과목의 이름을 입력해주세요.");
            Console.Write("입력 :");
            this.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("※ 변경되었습니다. \n");
        }
        public void change_credit()
        {
            while (true)
            {
                Console.WriteLine("변경할 과목의 학점단위을 입력해주세요.");
                Console.Write("입력 :");
                this.credit = Console.ReadLine();
                Console.Clear();
                if (!(string.Equals(this.credit, "0") || string.Equals(this.credit, "1") || string.Equals(this.credit, "2") || string.Equals(this.credit, "3") || string.Equals(this.credit, "4")))
                {
                    Console.Clear();
                    Console.WriteLine("※ 올바른 학점단위를 입력해주세요(0 ~ 4)\n");
                    continue;
                }
                Console.Clear();
                Console.WriteLine("※ 변경되었습니다. \n");
                break;
            }
        }
        public void change_subject_kind()
        {
            Console.WriteLine("변경할 과목의 이수구분을 입력해주세요 (교선/교필/전선/전필)");
            Console.Write("입력 :");
            this.subject_kind = Console.ReadLine();
            Console.Clear();
            while (!(string.Equals(this.subject_kind, "교선") || string.Equals(this.subject_kind, "교필") || string.Equals(this.subject_kind, "전선") || string.Equals(this.subject_kind, "전필")))
            {
                Console.WriteLine("※ 올바른 이수구분을 입력 해주세요 (교선/교필/전선/전필)");
                Console.WriteLine("입력 :");
                this.subject_kind = Console.ReadLine();
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("※ 변경되었습니다. \n");
        }
        public void change_classroom_num()
        {
            Console.WriteLine("변경할 과목의 강의실 번호를 입력해주세요");
            Console.Write("입력 :");
            this.classroom_num = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("※ 변경되었습니다. \n");

        }
        public void change_department()
        {
            this.department.subject_list.Remove(this);
            while (true)
            {
                int department_chose;
                Console.WriteLine("추가할 과목의 담당 학과를 입력해주세요 : ");
                Department department = new Department();
                foreach (var item in Department.department_list)
                {
                    Console.WriteLine(item.number + "." + item.name);

                }
                Console.WriteLine("번호 입력 :");

                try
                {
                    department_chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if (department_chose > Department.department_list.Count || department_chose < 0)
                {
                    Console.Clear();
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    continue;
                }

                foreach (var item in Department.department_list)
                {
                    if (department_chose == item.number)
                        department = item;
                }
                this.department = department;
                
                Console.Clear();
                break;
            }
            department.subject_list.Add(this);

        }
        public static void add_subject()
        {
            Subject subject = new Subject();
            subject.add_name();
            subject.add_subject_kind();
            subject.add_credit();
            subject.add_professor();
            subject.add_assistant();
            subject.add_classroom_num();
            Subject.subject_list.Add(subject);
            Console.Clear();
            Console.WriteLine("정상적으로 생성되었습니다.\n");
        } //과목 생성
        public static void change_subject()
        {
            while (true)
            {
                int chose;
                int i = 1;
                Console.WriteLine("변경할 과목을 선택해주세요");
                foreach(var item in Subject.subject_list)
                {
                    Console.WriteLine(i++ + "." + item.name);
                }
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if(chose > subject_list.Count || chose <1)
                {
                    Console.Clear();
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    continue;
                }
                Subject subject = new Subject();
                subject = Subject.subject_list[chose - 1];
                Console.Clear();
                while (true)
                {
                    subject.print_subject();
                    Console.WriteLine("변경할 내용을 선택해주세요");
                    Console.WriteLine("1.과목이름  2. 학점단위  3. 이수구분  4. 강의실번호  5. 담당학과  6. 처음으로");
                    try
                    {
                        chose = int.Parse(Console.ReadLine());
                    }
                    catch
                    {

                        Console.Clear();
                        Console.WriteLine("※ 숫자로 입력해주세요\n");
                        continue;
                    }
                    Console.Clear();
                    switch (chose)
                    {
                        case 1:
                            subject.change_name();
                            break;
                        case 2:
                            subject.change_credit();
                            break;
                        case 3:
                            subject.change_subject_kind();
                            break;
                        case 4:
                            subject.change_classroom_num();
                            break;
                        case 5:
                            subject.change_department();
                            break;
                        case 6:
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                            continue;
                    }
                    break;
                }
                break;
            }
        }
        public void print_subject()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("과목 '" + this.name + "'의 정보");
            Console.WriteLine("학점단위 : " + this.credit);
            Console.WriteLine("이수구분 : " + this.subject_kind);
            Console.Write("교수 : ");
            if (professor == null)
                Console.WriteLine("null");
            else
                Console.WriteLine(this.professor.name);
            Console.Write("조교 : ");
            if (assistant== null)
                Console.WriteLine("null");
            else
                Console.WriteLine(this.assistant.name);
            Console.WriteLine("담당학과 : " + this.department.name);
            Console.WriteLine("강의실 : " + this.classroom_num);
            Console.WriteLine("-----------------------------------");

        }

        public static void delete_subject()
        {
            Subject subject = new Subject();
            subject = Subject.chose_subject();
            foreach (var item in Student.student_list)
                item.subject_list.Remove(subject);
            foreach (var item in Professor.professor_list)
                item.subject_list.Remove(subject);
            foreach (var item in Department.department_list)
                item.subject_list.Remove(subject);
            Console.Clear();
            Console.WriteLine(subject.name + "이 삭제되었습니다.");
            subject = null;

        }

        public static Subject chose_subject()
        {
            while (true)
            {
                int i = 1;
                int chose;
                Subject subject = new Subject();
                Console.WriteLine("과목의 번호를 선택해주세요");
                foreach (var item in Subject.subject_list)
                {
                    Console.WriteLine(i + "." + item.name);
                    i++;
                }
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                if ((chose > Subject.subject_list.Count) || chose < 1)
                {
                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.Clear();
                    subject = Subject.subject_list[chose - 1];
                }
                return subject;
            }

        } //과목 찾기 매서드


    }

    struct SubjectEnd
    {
        public readonly string name; // 과목 이름
        public readonly Professor professor; //과목 담당 교수
        public readonly string classroom_num; //강의실번호
        public readonly string grade; // 성적 (학생전용)
        public readonly string credit; //학점단위
        public readonly Assistant assistant; //담당 조교
        public readonly string subject_kind;

        public SubjectEnd(Subject subject)
        {
            this.name = subject.name;
            this.professor = subject.professor;
            this.classroom_num = subject.classroom_num;
            this.grade = subject.grade;
            this.credit = subject.credit;
            this.assistant = subject.assistant;
            this.subject_kind = subject.subject_kind;
        }

    }

    class Data
    {
        public static void data_input()
        {
            //학과 데이터

            Department department1 = new Department();
            department1.name = "컴퓨터공학과";
            department1.address = "대전광역시 대덕구 한남로 70 한남대학교 공과대학 212호 컴퓨터공학과";
            department1.tel_num = "0426297544";
            department1.department_email = "hnu7544@hnu.kr";
            department1.department_web = "http://ce.hannam.ac.kr/main/";
            Department department2 = new Department();
            department2.name = "정보통신공학과";
            department2.address = "대전광역시 대덕구 한남로 70 한남대학교 공과대학 417호 정보통신공학과";
            department2.tel_num = "042-629-7567";
            department2.department_email = "ice@hnu.kr";
            department2.department_web = "http://ice.hannam.ac.kr/main/";

            Department.department_list.Add(department1);
            Department.department_list.Add(department2);

            //교수 데이터
            Professor professor1 = new Professor();
            professor1.name = "이강수";
            professor1.phone_number = "042-629-7549";
            professor1.email = "gslee @hnu.kr";
            professor1.fac_num = "0000000";
            professor1.salary = 5000;
            professor1.join_date = "2000.01.01";
            professor1.department = department1;
            professor1.rank = "교수";
            department1.professor_list.Add(professor1);

            Professor professor2 = new Professor();
            professor2.name = "이극";
            professor2.phone_number = "042-629-7550";
            professor2.email = "leegeuk@hnu.kr";
            professor2.fac_num = "0000001";
            professor2.salary = 5000;
            professor2.join_date = "2000.01.02";
            professor2.department = department1;
            professor2.rank = "교수";
            department1.professor_list.Add(professor2);

            Professor professor3 = new Professor();
            professor3.name = "이만희";
            professor3.phone_number = "042-629-7623";
            professor3.email = "manheelee @hnu.kr";
            professor3.fac_num = "0000002";
            professor3.salary = 5000;
            professor3.join_date = "2000.01.03";
            professor3.department = department1;
            professor3.rank = "교수(학과장)";
            department1.professor_list.Add(professor3);
            department1.professor = professor3;

            Professor professor4 = new Professor();
            professor4.name = "윤영선";
            professor4.phone_number = "042-629-7569";
            professor4.email = "ysyun@hnu.kr";
            professor4.fac_num = "0000003";
            professor4.salary = 5000;
            professor4.join_date = "2000.01.04";
            professor4.department = department2;
            professor4.rank = "교수(학과장)";
            department2.professor_list.Add(professor4);
            department2.professor = professor4;

            Professor professor5 = new Professor();
            professor5.name = "유동호";
            professor5.phone_number = "042-629-8532";
            professor5.email = "dongho.you@hnu.kr";
            professor5.fac_num = "0000004";
            professor5.salary = 5000;
            professor5.join_date = "2000.01.05";
            professor5.department = department2;
            professor5.rank = "조교수";
            department2.professor_list.Add(professor5);

            Professor professor6 = new Professor();
            professor6.name = "박성우";
            professor6.phone_number = "042-629-7398";
            professor6.email = "swpark@hnu.kr";
            professor6.fac_num = "0000005";
            professor6.salary = 5000;
            professor6.join_date = "2000.01.06";
            professor6.department = department2;
            professor6.rank = "교수";
            department2.professor_list.Add(professor6);

            Professor.professor_list.Add(professor1);
            Professor.professor_list.Add(professor2);
            Professor.professor_list.Add(professor3);
            Professor.professor_list.Add(professor4);
            Professor.professor_list.Add(professor5);
            Professor.professor_list.Add(professor6);

            //학생 데이터
            Student student1 = new Student();
            student1.name = "학생1";
            student1.phone_number = "010-0000-0001";
            student1.email = "st1@hun.kr";
            student1.student_num = "1000001";
            student1.department = department1;
            student1.scholarship = "없음";
            department1.student_list.Add(student1);

            Student student2 = new Student();
            student2.name = "학생2";
            student2.phone_number = "010-0000-0002";
            student2.email = "st2@hun.kr";
            student2.student_num = "1000002";
            student2.department = department1;
            student2.scholarship = "2021-1학기 전액장학금";
            department1.student_list.Add(student2);

            Student student3 = new Student();
            student3.name = "학생3";
            student3.phone_number = "010-0000-0003";
            student3.email = "st3@hun.kr";
            student3.student_num = "1000003";
            student3.department = department1;
            student3.scholarship = "없음";
            department1.student_list.Add(student3);

            Student student4 = new Student();
            student4.name = "학생4";
            student4.phone_number = "010-0000-0004";
            student4.email = "st4@hun.kr";
            student4.student_num = "1000004";
            student4.department = department1;
            student4.scholarship = "없음";
            department1.student_list.Add(student4);

            Student student5 = new Student();
            student5.name = "학생5";
            student5.phone_number = "010-0000-0005";
            student5.email = "st5@hun.kr";
            student5.student_num = "1000005";
            student5.department = department1;
            student5.scholarship = "없음";
            department1.student_list.Add(student5);

            Student student6 = new Student();
            student6.name = "학생6";
            student6.phone_number = "010-0000-0006";
            student6.email = "st6@hun.kr";
            student6.student_num = "1000006";
            student6.department = department1;
            student6.scholarship = "없음";
            department1.student_list.Add(student6);

            Student student7 = new Student();
            student7.name = "학생7";
            student7.phone_number = "010-0000-0007";
            student7.email = "st7@hun.kr";
            student7.student_num = "1000007";
            student7.department = department1;
            student7.scholarship = "없음";
            department1.student_list.Add(student7);

            Student student8 = new Student();
            student8.name = "학생8";
            student8.phone_number = "010-0000-0008";
            student8.email = "st8@hun.kr";
            student8.student_num = "1000008";
            student8.department = department1;
            student8.scholarship = "없음";
            department1.student_list.Add(student8);

            Student student9 = new Student();
            student9.name = "학생9";
            student9.phone_number = "010-0000-0009";
            student9.email = "st9@hun.kr";
            student9.student_num = "1000009";
            student9.department = department1;
            student9.scholarship = "없음";
            department1.student_list.Add(student9);

            Student student10 = new Student();
            student10.name = "학생10";
            student10.phone_number = "010-0000-0010";
            student10.email = "st10@hun.kr";
            student10.student_num = "10000010";
            student10.department = department1;
            student10.scholarship = "없음";
            department1.student_list.Add(student10);

            Student student11 = new Student();
            student11.name = "학생11";
            student11.phone_number = "010-0000-0011";
            student11.email = "st11@hun.kr";
            student11.student_num = "1000005";
            student11.department = department2;
            student11.scholarship = "없음";
            department2.student_list.Add(student11);

            Student student12 = new Student();
            student12.name = "학생12";
            student12.phone_number = "010-0000-0012";
            student12.email = "st12@hun.kr";
            student12.student_num = "1000005";
            student12.department = department2;
            student12.scholarship = "없음";
            department2.student_list.Add(student12);

            Student student13 = new Student();
            student13.name = "학생13";
            student13.phone_number = "010-0000-0013";
            student13.email = "st13@hun.kr";
            student13.student_num = "1000005";
            student13.department = department2;
            student13.scholarship = "없음";
            department2.student_list.Add(student13);

            Student student14 = new Student();
            student14.name = "학생14";
            student14.phone_number = "010-0000-0014";
            student14.email = "st14@hun.kr";
            student14.student_num = "1000005";
            student14.department = department2;
            student14.scholarship = "없음";
            department2.student_list.Add(student14);

            Student student15 = new Student();
            student15.name = "학생15";
            student15.phone_number = "010-0000-0015";
            student15.email = "st15@hun.kr";
            student15.student_num = "1000005";
            student15.department = department2;
            student15.scholarship = "없음";
            department2.student_list.Add(student15);

            Student student16 = new Student();
            student16.name = "학생16";
            student16.phone_number = "010-0000-0016";
            student16.email = "st16@hun.kr";
            student16.student_num = "1000005";
            student16.department = department2;
            student16.scholarship = "없음";
            department2.student_list.Add(student16);

            Student student17 = new Student();
            student17.name = "학생17";
            student17.phone_number = "010-0000-0017";
            student17.email = "st17@hun.kr";
            student17.student_num = "1000005";
            student17.department = department2;
            student17.scholarship = "없음";
            department2.student_list.Add(student17);

            Student student18 = new Student();
            student18.name = "학생18";
            student18.phone_number = "010-0000-0018";
            student18.email = "st18@hun.kr";
            student18.student_num = "1000005";
            student18.department = department2;
            student18.scholarship = "없음";
            department2.student_list.Add(student18);

            Student student19 = new Student();
            student19.name = "학생19";
            student19.phone_number = "010-0000-0019";
            student19.email = "st19@hun.kr";
            student19.student_num = "1000005";
            student19.department = department2;
            student19.scholarship = "없음";
            department2.student_list.Add(student19);

            Student student20 = new Student();
            student20.name = "학생20";
            student20.phone_number = "010-0000-0020";
            student20.email = "st20@hun.kr";
            student20.student_num = "1000005";
            student20.department = department2;
            student20.scholarship = "없음";
            department2.student_list.Add(student20);

            Student.student_list.Add(student1);
            Student.student_list.Add(student2);
            Student.student_list.Add(student3);
            Student.student_list.Add(student4);
            Student.student_list.Add(student5);
            Student.student_list.Add(student6);
            Student.student_list.Add(student7);
            Student.student_list.Add(student8);
            Student.student_list.Add(student9);
            Student.student_list.Add(student10);
            Student.student_list.Add(student11);
            Student.student_list.Add(student12);
            Student.student_list.Add(student13);
            Student.student_list.Add(student14);
            Student.student_list.Add(student15);
            Student.student_list.Add(student16);
            Student.student_list.Add(student17);
            Student.student_list.Add(student18);
            Student.student_list.Add(student19);
            Student.student_list.Add(student20);

            //조교 데이터
            Assistant assistant1 = new Assistant();
            assistant1.name = "조교1";
            assistant1.phone_number = "010-0000-1001";
            assistant1.email = "as1@hnu.kr";
            assistant1.fac_num = "2000001";
            assistant1.salary = 3000;
            assistant1.join_date = "2000.02.01";
            assistant1.department = department1;
            department1.assistant_list.Add(assistant1);
            department1.assistant = assistant1;

            Assistant assistant2 = new Assistant();
            assistant2.name = "조교2";
            assistant2.phone_number = "010-0000-1002";
            assistant2.email = "as2@hnu.kr";
            assistant2.fac_num = "2000002";
            assistant2.salary = 3000;
            assistant2.join_date = "2000.02.02";
            assistant2.department = department1;
            department1.assistant_list.Add(assistant2);

            Assistant assistant3 = new Assistant();
            assistant3.name = "조교3";
            assistant3.phone_number = "010-0000-1003";
            assistant3.email = "as3@hnu.kr";
            assistant3.fac_num = "2000003";
            assistant3.salary = 3000;
            assistant3.join_date = "2000.02.03";
            assistant3.department = department2;
            department1.assistant_list.Add(assistant3);
            department2.assistant = assistant3;

            Assistant assistant4 = new Assistant();
            assistant4.name = "조교4";
            assistant4.phone_number = "010-0000-1004";
            assistant4.email = "as4@hnu.kr";
            assistant4.fac_num = "2000004";
            assistant4.salary = 3000;
            assistant4.join_date = "2000.02.04";
            assistant4.department = department2;
            department1.assistant_list.Add(assistant4);

            Assistant.assistant_list.Add(assistant1);
            Assistant.assistant_list.Add(assistant2);
            Assistant.assistant_list.Add(assistant3);
            Assistant.assistant_list.Add(assistant4);

            //직원 데이터
            Staff staff1 = new Staff();
            staff1.name = "직원1";
            staff1.phone_number = "010-0000-2001";
            staff1.email = "stf1@hnu.kr";
            staff1.fac_num = "3000001";
            staff1.salary = 3000;
            staff1.join_date = "2000.03.01";
            staff1.department = department1;
            department1.staff_list.Add(staff1);

            Staff staff2 = new Staff();
            staff2.name = "직원2";
            staff2.phone_number = "010-0000-2001";
            staff2.email = "stf1@hnu.kr";
            staff2.fac_num = "3000001";
            staff2.salary = 3000;
            staff2.join_date = "2000.03.01";
            staff2.department = department1;
            department1.staff_list.Add(staff2);

            Staff.staff_list.Add(staff1);
            Staff.staff_list.Add(staff2);

            //과목 데이터
            //컴퓨터공학과 과목
            Subject subject1 = new Subject();
            subject1.name = "공학과경영";
            subject1.professor = professor1;
            subject1.department = department1;
            subject1.credit = "3";
            subject1.subject_kind = "교필";
            subject1.classroom_num = "090425";
            subject1.assistant = assistant1;
            department1.subject_list.Add(subject1);
            professor1.subject_list.Add(subject1);

            Subject subject2 = new Subject();
            subject2.name = "컴퓨터구조";
            subject2.professor = professor3;
            subject2.department = department1;
            subject2.credit = "3";
            subject2.subject_kind = "전선";
            subject2.classroom_num = "090320";
            subject2.assistant = assistant2;
            department1.subject_list.Add(subject2);
            professor3.subject_list.Add(subject2);

            Subject subject3 = new Subject();
            subject3.name = "인공지능";
            subject3.professor = professor2;
            subject3.department = department1;
            subject3.credit = "3";
            subject3.subject_kind = "전선";
            subject3.classroom_num = "090221";
            subject3.assistant = assistant1;
            department1.subject_list.Add(subject3);
            professor2.subject_list.Add(subject3);

            Subject subject4 = new Subject();
            subject4.name = "정보보호개론";
            subject4.professor = professor3;
            subject4.department = department1;
            subject4.credit = "3";
            subject4.subject_kind = "전선";
            subject4.classroom_num = "090320";
            subject4.assistant = assistant2;
            department1.subject_list.Add(subject4);
            professor3.subject_list.Add(subject4);

            // 정보통신공학과 과목
            Subject subject5 = new Subject();
            subject5.name = "확률및통계";
            subject5.professor = professor5;
            subject5.department = department2;
            subject5.credit = "3";
            subject5.subject_kind = "교필";
            subject5.classroom_num = "090517";
            department2.subject_list.Add(subject5);
            professor5.subject_list.Add(subject5);

            Subject subject6 = new Subject();
            subject6.name = "데이터구조";
            subject6.professor = professor4;
            subject6.department = department2;
            subject6.credit = "3";
            subject6.subject_kind = "전선";
            subject6.classroom_num = "090517";
            department2.subject_list.Add(subject6);
            professor4.subject_list.Add(subject6);

            Subject subject7 = new Subject();
            subject7.name = "데이터통신";
            subject7.professor = professor6;
            subject7.department = department2;
            subject7.credit = "3";
            subject7.subject_kind = "전선";
            subject7.classroom_num = "090517";
            department2.subject_list.Add(subject7);
            professor6.subject_list.Add(subject7);

            Subject subject8 = new Subject();
            subject8.name = "임베디드OS";
            subject8.professor = professor4;
            subject8.department = department2;
            subject8.credit = "3";
            subject8.subject_kind = "전선";
            subject8.classroom_num = "090425";
            department2.subject_list.Add(subject8);
            professor4.subject_list.Add(subject8);

            Subject.subject_list.Add(subject1);
            Subject.subject_list.Add(subject2);
            Subject.subject_list.Add(subject3);
            Subject.subject_list.Add(subject4);
            Subject.subject_list.Add(subject5);
            Subject.subject_list.Add(subject6);
            Subject.subject_list.Add(subject7);
            Subject.subject_list.Add(subject8);


            subject1.student_list.Add(student1);
            subject2.student_list.Add(student1);
            subject3.student_list.Add(student1);
            student1.subject_list.Add(subject1);
            student1.subject_list.Add(subject2);
            student1.subject_list.Add(subject3);

            subject1.student_list.Add(student2);
            subject2.student_list.Add(student2);
            subject4.student_list.Add(student2);
            student2.subject_list.Add(subject1);
            student2.subject_list.Add(subject2);
            student2.subject_list.Add(subject4);

            subject1.student_list.Add(student3);
            subject3.student_list.Add(student3);
            subject4.student_list.Add(student3);
            student3.subject_list.Add(subject1);
            student3.subject_list.Add(subject3);
            student3.subject_list.Add(subject4);

            subject2.student_list.Add(student4);
            subject3.student_list.Add(student4);
            subject4.student_list.Add(student4);
            student4.subject_list.Add(subject2);
            student4.subject_list.Add(subject3);
            student4.subject_list.Add(subject4);

            subject1.student_list.Add(student5);
            subject2.student_list.Add(student5);
            subject3.student_list.Add(student5);
            student5.subject_list.Add(subject1);
            student5.subject_list.Add(subject2);
            student5.subject_list.Add(subject3);

            subject1.student_list.Add(student6);
            subject2.student_list.Add(student6);
            subject4.student_list.Add(student6);
            student6.subject_list.Add(subject1);
            student6.subject_list.Add(subject2);
            student6.subject_list.Add(subject4);

            subject1.student_list.Add(student7);
            subject3.student_list.Add(student7);
            subject4.student_list.Add(student7);
            student7.subject_list.Add(subject1);
            student7.subject_list.Add(subject3);
            student7.subject_list.Add(subject4);

            subject2.student_list.Add(student8);
            subject3.student_list.Add(student8);
            subject4.student_list.Add(student8);
            student8.subject_list.Add(subject2);
            student8.subject_list.Add(subject3);
            student8.subject_list.Add(subject4);

            subject1.student_list.Add(student9);
            subject2.student_list.Add(student9);
            subject3.student_list.Add(student9);
            student9.subject_list.Add(subject1);
            student9.subject_list.Add(subject2);
            student9.subject_list.Add(subject3);

            subject1.student_list.Add(student10);
            subject2.student_list.Add(student10);
            subject4.student_list.Add(student10);
            student10.subject_list.Add(subject1);
            student10.subject_list.Add(subject2);
            student10.subject_list.Add(subject4);

            subject5.student_list.Add(student11);
            subject6.student_list.Add(student11);
            subject7.student_list.Add(student11);
            student11.subject_list.Add(subject5);
            student11.subject_list.Add(subject6);
            student11.subject_list.Add(subject7);

            subject5.student_list.Add(student12);
            subject6.student_list.Add(student12);
            subject8.student_list.Add(student12);
            student12.subject_list.Add(subject5);
            student12.subject_list.Add(subject6);
            student12.subject_list.Add(subject8);

            subject5.student_list.Add(student13);
            subject7.student_list.Add(student13);
            subject8.student_list.Add(student13);
            student13.subject_list.Add(subject5);
            student13.subject_list.Add(subject7);
            student13.subject_list.Add(subject8);

            subject6.student_list.Add(student14);
            subject7.student_list.Add(student14);
            subject8.student_list.Add(student14);
            student14.subject_list.Add(subject6);
            student14.subject_list.Add(subject7);
            student14.subject_list.Add(subject8);

            subject5.student_list.Add(student15);
            subject6.student_list.Add(student15);
            subject7.student_list.Add(student15);
            student15.subject_list.Add(subject5);
            student15.subject_list.Add(subject6);
            student15.subject_list.Add(subject7);

            subject5.student_list.Add(student16);
            subject6.student_list.Add(student16);
            subject8.student_list.Add(student16);
            student16.subject_list.Add(subject5);
            student16.subject_list.Add(subject6);
            student16.subject_list.Add(subject8);

            subject5.student_list.Add(student17);
            subject7.student_list.Add(student17);
            subject8.student_list.Add(student17);
            student17.subject_list.Add(subject5);
            student17.subject_list.Add(subject7);
            student17.subject_list.Add(subject8);

            subject6.student_list.Add(student18);
            subject7.student_list.Add(student18);
            subject8.student_list.Add(student18);
            student18.subject_list.Add(subject6);
            student18.subject_list.Add(subject7);
            student18.subject_list.Add(subject8);

            subject5.student_list.Add(student19);
            subject6.student_list.Add(student19);
            subject7.student_list.Add(student19);
            student19.subject_list.Add(subject5);
            student19.subject_list.Add(subject6);
            student19.subject_list.Add(subject7);

            subject5.student_list.Add(student20);
            subject6.student_list.Add(student20);
            subject8.student_list.Add(student20);
            student20.subject_list.Add(subject5);
            student20.subject_list.Add(subject6);
            student20.subject_list.Add(subject8);



        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int chose;
            Data.data_input();


            while (true)
            {
                Console.WriteLine("로그인 할 계정을 선택해주세요.");
                Console.Write("1.학교 admin  2.학과 admin    3.교수   4.학생   5.검색   6.종료 : ");
                try
                {
                    chose = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.Clear();
                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                    continue;
                }
                Console.Clear();
                switch (chose)
                {
                    case 1:
                        
                        while (true)
                        {
                            Console.WriteLine("-------- 현재 로그인 계정 : 학교 admin -----------\n");
                            Console.WriteLine("실행하실 작업을 선택해주세요.");
                            Console.WriteLine("1. 학과관리  2. 교수관리  3. 학생관리  4. 교과목 관리  5. 조교관리  6. 직원관리  7. 처음으로: ");
                            try
                            {
                                chose = int.Parse(Console.ReadLine());
                            }
                            catch
                            {

                                Console.Clear();
                                Console.WriteLine("※ 숫자로 입력해주세요\n");
                                continue;
                            }
                            Console.Clear();

                            switch (chose)
                            {
                                case 1:
                                    while (true)
                                    {
                                        Console.WriteLine("학과 관리 - 실행할 작업을 선택해주세요 ");
                                        Console.WriteLine("1. 추가  2. 변경  3.처음으로");
                                        try
                                        {
                                            chose = int.Parse(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.Clear();
                                            Console.WriteLine("※ 숫자로 입력해주세요\n");
                                            continue;
                                        }
                                        Console.Clear();

                                        switch (chose)
                                        {
                                            case 1:
                                                Department.add_department();
                                                break;
                                            case 2:
                                                Department.chose_department().change_department_info();
                                                break;
                                            case 3:
                                                break;
                                            default:
                                                Console.WriteLine("※ 올바른 번호를 입력해주세요 \n");
                                                continue;
                                        }
                                        break;

                                    }
                                    break;

                                case 2:
                                    while (true)
                                    {
                                        Console.WriteLine("교수 관리 - 실행할 작업을 선택해주세요 ");
                                        Console.WriteLine("1. 추가  2. 변경  3. 삭제  4.처음으로");
                                        try
                                        {
                                            chose = int.Parse(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.Clear();
                                            Console.WriteLine("※ 숫자로 입력해주세요\n");
                                            continue;
                                        }
                                        Console.Clear();
                                        switch (chose)
                                        {
                                            case 1:
                                                Professor.add_professor();
                                                break;
                                            case 2:
                                                Professor.chose_professor().change_professor();
                                                break;
                                            case 3:
                                                Professor.delete_professor();
                                                break;
                                            case 4:
                                                break;
                                            default:
                                                Console.WriteLine("※ 정확한 숫자를 입력해주세요\n");
                                                continue;

                                        }
                                        break;
                                    }
                                    break;
                                case 3:
                                    while (true)
                                    {
                                        Console.WriteLine("학생 관리 - 실행할 작업을 선택해주세요 ");
                                        Console.WriteLine("1. 추가  2. 변경  3. 삭제  4.처음으로");
                                        try
                                        {
                                            chose = int.Parse(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.Clear();
                                            Console.WriteLine("※ 숫자로 입력해주세요\n");
                                            continue;
                                        }
                                        Console.Clear();

                                        switch (chose)
                                        {
                                            case 1:
                                                Student.add_student();
                                                break;
                                            case 2:
                                                Student.chose_student().change_student();
                                                break;
                                            case 3:
                                                Student.delete_student();
                                                break;
                                            case 4:
                                                break;
                                            default:
                                                Console.Clear();
                                                Console.WriteLine("※ 정확한 숫자를 입력해주세요\n");
                                                continue;

                                        }
                                        break;
                                    }
                                    break;
                                case 4:
                                    while (true)
                                    {
                                        Console.WriteLine("교과목 관리 - 실행할 작업을 선택해주세요 ");
                                        Console.WriteLine("1. 추가  2. 변경  3. 삭제  4.처음으로");
                                        try
                                        {
                                            chose = int.Parse(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.Clear();
                                            Console.WriteLine("※ 숫자로 입력해주세요\n");
                                            continue;
                                        }
                                        Console.Clear();
                                        switch (chose)
                                        {
                                            case 1:
                                                Subject.add_subject();
                                                break;
                                            case 2:
                                                Subject.change_subject();
                                                break;
                                            case 3:
                                                Subject.delete_subject();
                                                break;
                                            case 4:
                                                break;
                                            default:
                                                Console.Clear();
                                                Console.WriteLine("※ 정확한 숫자를 입력해주세요\n");
                                                continue;

                                        }
                                        break;

                                    }
                                    break;
                                case 5:
                                    while (true)
                                    {
                                        Console.WriteLine("실행하실 작업을 선택해주세요.");
                                        Console.WriteLine("1. 추가  2. 변경  3. 삭제  4. 처음으로");
                                        try
                                        {
                                            chose = int.Parse(Console.ReadLine());
                                        }
                                        catch
                                        {

                                            Console.Clear();
                                            Console.WriteLine("※ 숫자로 입력해주세요\n");
                                            continue;
                                        }
                                        Console.Clear();
                                        switch (chose)
                                        {
                                            case 1:
                                                Assistant.add_assistant();
                                                break;
                                            case 2:
                                                Assistant.chose_assistant().change_assistant();
                                                break;
                                            case 3:
                                                Assistant.delete_assistant();
                                                break;
                                            case 4:
                                                break;
                                            default:
                                                Console.Clear();
                                                Console.WriteLine("※올바른 숫자를 입력해주세요\n");
                                                continue;
                                        }
                                        break;
                                    }
                                    break;
                                case 6:
                                    while (true)
                                    {
                                        Console.WriteLine("실행하실 작업을 선택해주세요.");
                                        Console.WriteLine("1. 추가  2. 변경  3. 삭제  4. 처음으로");
                                        try
                                        {
                                            chose = int.Parse(Console.ReadLine());
                                        }
                                        catch
                                        {

                                            Console.Clear();
                                            Console.WriteLine("※ 숫자로 입력해주세요\n");
                                            continue;
                                        }
                                        Console.Clear();
                                        switch (chose)
                                        {
                                            case 1:
                                                Staff.add_staff();
                                                break;
                                            case 2:
                                                Staff.chose_staff().change_staff();
                                                break;
                                            case 3:
                                                Staff.delete_staff();
                                                break;
                                            case 4:
                                                break;
                                            default:
                                                Console.Clear();
                                                Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                                continue;
                                        }
                                        break;
                                    }
                                    break;
                                case 7:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                    continue;

                            }
                            break;
                        }
                        break;

                    case 2:
                        Department login_department = new Department();
                        while (true)
                        {
                            Console.WriteLine("로그인할 학과를 선택해주세요");
                            foreach (var item in Department.department_list)
                            {
                                Console.WriteLine(item.number + "." + item.name);
                            }
                            Console.Write("번호 입력 :");
                            try
                            {
                                int department_chose = int.Parse(Console.ReadLine());
                                if ((department_chose > Department.department_list.Count) || (department_chose == 0))
                                {
                                    Console.Clear();
                                    Console.WriteLine("※ 정확한 숫자를 입력해주세요\n");
                                    continue;
                                }
                                foreach (var item in Department.department_list)
                                {
                                    if (department_chose == item.number)
                                    {
                                        login_department = item;
                                    }
                                }
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("※잘못된 입력입니다, 숫자를 입력해주세요\n");
                                continue;
                            }
                            Console.Clear();
                            break;
                        }
                        while (true)
                        {
                            Console.WriteLine("-------- 현재 로그인 계정 : " + login_department.name + " admin -----------\n");
                            Console.WriteLine("실행하실 작업을 선택해주세요.");
                            Console.WriteLine("1. 학생관리(변경)  2. 교수관리(변경)  3. 수강관리  4. 처음으로");
                            try
                            {
                                chose = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("※ 숫자로 입력해주세요\n");
                                continue;
                            }
                            Console.Clear();

                            switch (chose)
                            {
                                case 1:
                                    if (login_department.student_list.Count < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("존재하는 학생이 없습니다.");
                                        continue;
                                    }
                                    while (true)
                                    {
                                        login_department.change_student();
                                        break;
                                    }
                                    break;
                                case 2:
                                    if (login_department.professor_list.Count < 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("존재하는 교수가 없습니다.");
                                        continue;
                                    }
                                    while (true)
                                    {
                                        login_department.change_professor();
                                        break;
                                    }
                                    break;
                                case 3:
                                    while (true)
                                    {
                                        int m = 1;
                                        Console.WriteLine(login_department.name + " 강의 목록");
                                        foreach(var item in login_department.subject_list)
                                        {
                                            Console.WriteLine(m++ + "." + item.name);

                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("실행하실 작업을 선택해주세요.");
                                        Console.WriteLine("1.과목개설  2. 교수 배정  3. 강의실변경  4. 학생 수강 등록 및 제거  5. 처음으로");
                                        try
                                        {
                                            chose = int.Parse(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.Clear();
                                            Console.WriteLine("※ 숫자로 입력해주세요\n");
                                            continue;
                                        }
                                        Console.Clear();
                                        switch (chose)
                                        {
                                            case 1:
                                                Subject.add_subject();
                                                break;
                                            case 2:
                                                while (true)
                                                {
                                                    int i = 1;
                                                    Subject subject = new Subject();
                                                    if (Subject.subject_list.Count == 0)
                                                    {
                                                        Console.WriteLine("※ 개설된 강의가 없습니다! (학과 admin으로 과목 개설)\n");
                                                        break;
                                                    }
                                                    Console.WriteLine("과목의 번호를 선택해주세요");
                                                    foreach (var item in Subject.subject_list)
                                                    {
                                                        Console.WriteLine(i + "." + item.name);
                                                        i++;
                                                    }
                                                    try
                                                    {
                                                        chose = int.Parse(Console.ReadLine());
                                                    }
                                                    catch
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("※ 숫자로 입력해주세요\n");
                                                        continue;
                                                    }
                                                    if ((chose > Subject.subject_list.Count) || (chose == 0))
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                                        continue;
                                                    }
                                                    else
                                                        subject = Subject.subject_list[chose - 1];
                                                    Console.Clear();
                                                    subject.add_professor();
                                                    Console.WriteLine("배정 되었습니다");
                                                    break;

                                                }
                                                break;
                                            case 3:
                                                while (true)
                                                {
                                                    Subject subject = new Subject();
                                                    subject = Subject.chose_subject();
                                                    subject.change_classroom_num();
                                                    Console.WriteLine("※ 변경되었습니다.\n");
                                                    break;
                                                }

                                                break;
                                            case 4:
                                                Student student = new Student();
                                                student = login_department.chose_student();
                                                Console.Clear();
                                                while (true)
                                                {
                                                    Console.WriteLine("작업할 학생 :" + student.name);
                                                    Console.WriteLine("실행하실 작업을 선택해주세요.");
                                                    Console.WriteLine("1. 수강 등록, 2. 수강 제거  3. 처음으로");
                                                    try
                                                    {
                                                        chose = int.Parse(Console.ReadLine());
                                                    }
                                                    catch
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("※ 숫자로 입력해주세요\n");
                                                        continue;
                                                    }
                                                    Console.Clear();
                                                    switch (chose)
                                                    {
                                                        case 1:
                                                            Subject subject = new Subject();
                                                            subject = Subject.chose_subject();
                                                            if (student.subject_list.Contains(subject))
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("이미 신청된 강의입니다.\n");
                                                                continue;
                                                            }
                                                            student.subject_list.Add(subject);
                                                            subject.student_list.Add(student);
                                                            Console.Clear();
                                                            Console.WriteLine(subject.name + "가 등록되었습니다.\n");
                                                            break;
                                                        case 2:
                                                            while (true)
                                                            {
                                                                int i = 1;
                                                                Subject subject1 = new Subject();
                                                                if (student.subject_list.Count < 1)
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("※ 존재하는 과목이 없습니다\n");
                                                                    break;
                                                                }
                                                                Console.WriteLine("제거할 과목을 선택해주세요");
                                                                foreach (var item in student.subject_list)
                                                                {
                                                                    Console.WriteLine(i + "." + item.name);
                                                                }
                                                                try
                                                                {
                                                                    chose = int.Parse(Console.ReadLine());
                                                                }
                                                                catch
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                                                                    continue;
                                                                }
                                                                Console.Clear();
                                                                if ((chose > student.subject_list.Count) || (chose == 0))
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                                                    continue;
                                                                }
                                                                subject1 = student.subject_list[chose - 1];
                                                                student.subject_list.RemoveAt(chose - 1);
                                                                subject1.student_list.Remove(student);

                                                                Console.WriteLine("성공적으로 제거되었습니다");
                                                                break;
                                                            }
                                                            break;
                                                        case 3:
                                                            break;

                                                        default:
                                                            Console.Clear();
                                                            Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                                            continue;
                                                    }
                                                    break;
                                                }
                                                break;
                                            case 5:
                                                break;
                                            default:
                                                Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                                continue;
                                        }
                                        break;
                                    }
                                    break;
                                case 4:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                    continue;
                            }
                            break;
                        }
                        break;
                    case 3:
                        Professor professor = new Professor();
                        professor = Professor.chose_professor();
                        while (true)
                        {
                            Console.WriteLine("-------- 현재 로그인 계정 : " + professor.name + " 교수 -----------\n");
                            Console.WriteLine("실행하실 작업을 선택해주세요.");
                            Console.WriteLine("1. 본인 정보 변경  2. 강의과목 관리  3. 돌아가기 : ");
                            try
                            {
                                chose = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("※ 숫자로 입력해주세요\n");
                                continue;
                            }
                            Console.Clear();
                            switch (chose)
                            {
                                case 1:
                                    professor.change_professor();
                                    break;
                                case 2:
                                    while (true)
                                    {
                                        Console.WriteLine("실행하실 작업을 선택해주세요.");
                                        Console.WriteLine("1. 강의 과목 확인  2. 수강생 정보 확인  3. 과목별, 학생별 성적기입 : ");
                                        try
                                        {
                                            chose = int.Parse(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.Clear();
                                            Console.WriteLine("※ 숫자로 입력해주세요\n");
                                            continue;
                                        }
                                        Console.Clear();
                                        switch (chose)
                                        {
                                            case 1:
                                                
                                                Console.WriteLine("교수 " + professor.name + "의 과목목록");
                                                Console.WriteLine("조회할 과목의 번호를 입력해주세요");
                                                int a = 1;
                                                if(professor.subject_list.Count == 0)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("강의 목록이 없습니다!\n");
                                                    break;
                                                }
                                                foreach (var item in professor.subject_list)
                                                {
                                                    Console.WriteLine(a + "." + item.name);

                                                }
                                                try
                                                {
                                                    chose = int.Parse(Console.ReadLine());
                                                }
                                                catch
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                                                    continue;
                                                }
                                                Console.Clear();
                                                Console.WriteLine("과목 이름 :" + professor.subject_list[chose - 1].name);
                                                Console.WriteLine("이수 구분 :" + professor.subject_list[chose - 1].subject_kind);
                                                Console.WriteLine("담당 교수 :" + professor.subject_list[chose - 1].professor.name);
                                                Console.WriteLine("강의실 번호 :" + professor.subject_list[chose - 1].classroom_num);
                                                Console.WriteLine("학점 단위 :" + professor.subject_list[chose - 1].credit);
                                                Console.WriteLine("담당 조교 :" + professor.subject_list[chose - 1].assistant.name);
                                                Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                                                Console.ReadLine();
                                                Console.Clear();

                                                break;
                                            case 2:
                                                int k = 1;
                                                if (professor.subject_list.Count == 0)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("강의 목록이 없습니다!\n");
                                                    break;
                                                }
                                                Console.WriteLine("수강생 정보를 확인할 과목을 선택해주세요");
                                                foreach (var item in professor.subject_list)
                                                {
                                                    Console.WriteLine(k + "." + item.name);
                                                    k++;
                                                }
                                                try
                                                {
                                                    chose = int.Parse(Console.ReadLine());
                                                }
                                                catch
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("※ 숫자로 입력해주세요\n");
                                                    continue;
                                                }
                                                Console.Clear();
                                                Console.WriteLine("수강생 목록");
                                                k = 1;
                                                foreach (var item in professor.subject_list[chose - 1].student_list)
                                                {
                                                    Console.WriteLine(k++ + "." + item.name);

                                                }
                                                Console.WriteLine("\n엔터를 누르면 처음으로 돌아갑니다.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case 3:
                                                if (professor.subject_list.Count == 0)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("강의 목록이 없습니다!\n");
                                                    break;
                                                }
                                                while (true)
                                                {
                                                    int j = 1;
                                                    Subject subject = new Subject();
                                                    Student student = new Student();
                                                    Console.WriteLine("성적 입력을 진행할 과목을 선택해주세요");
                                                    foreach (var item in professor.subject_list)
                                                    {
                                                        Console.WriteLine(j + "." + item.name);
                                                        j++;
                                                    }
                                                    try
                                                    {
                                                        chose = int.Parse(Console.ReadLine());
                                                    }
                                                    catch
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("※ 숫자로 입력해주세요\n");
                                                        continue;
                                                    }
                                                    try
                                                    {
                                                        subject = professor.subject_list[chose - 1];
                                                    }
                                                    catch
                                                    {
                                                        Console.WriteLine("※올바른 숫자를 입력해주세요\n");
                                                    }
                                                    while (true)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("성적 입력을 진행할 수강생을 선택해주세요");
                                                        Console.WriteLine("수강생 목록");
                                                        k = 1;
                                                        foreach (var item in professor.subject_list[chose - 1].student_list)
                                                        {
                                                            Console.WriteLine(k++ + "." + item.name);
                                                        }
                                                        try
                                                        {
                                                            chose = int.Parse(Console.ReadLine());

                                                        }
                                                        catch
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("※ 숫자로 입력해주세요\n");
                                                            continue;
                                                        }
                                                        try
                                                        {
                                                            student = subject.student_list[chose - 1];
                                                        }
                                                        catch
                                                        {
                                                            Console.WriteLine("※정확한 번호를 입력해주세요\n");
                                                            continue;
                                                        }
                                                        Console.Clear();
                                                        Console.WriteLine(student.name + "의 성적을 입력해주세요. (A+ ~ F) ");
                                                        subject.grade = Console.ReadLine();
                                                        while (!(subject.grade.Equals("A+") || subject.grade.Equals("A") || subject.grade.Equals("A-") || subject.grade.Equals("B+") || subject.grade.Equals("B") || subject.grade.Equals("B-") || subject.grade.Equals("C+") || subject.grade.Equals("C") || subject.grade.Equals("C-") || subject.grade.Equals("D+") || subject.grade.Equals("D") || subject.grade.Equals("D-") || subject.grade.Equals("F")))
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("A+ ~ F의 성적을 입력해주세요\n");
                                                            Console.WriteLine(student.name + "의 성적을 입력해주세요. (A+ ~ F) ");
                                                            subject.grade = Console.ReadLine();

                                                        }
                                                        student.subjectend_list.Add(new SubjectEnd(subject));
                                                        student.subject_list.Remove(subject);
                                                        subject.student_list.Remove(student);
                                                        Console.Clear();
                                                        Console.WriteLine("※ " + student.name + "의 성적이 입력되었습니다.\n");
                                                        break;
                                                    }
                                                    break;
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                        break;
                                    }
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("※ 올바른 번호를 입력해주세요\n");
                                    continue;

                            }


                            break;
                        }
                        break;
                    case 4:
                        Student student1 = new Student();
                        student1 = Student.chose_student();
                        while (true)
                        {

                            Console.WriteLine("-------- 현재 로그인 계정 : " + student1.name + " 학생 -----------\n");
                            Console.WriteLine("실행하실 작업을 선택해주세요.");
                            Console.WriteLine("1. 본인 정보 변경  2. 수강 관리  3. 성적 확인  4. 돌아가기 : ");
                            try
                            {
                                chose = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("※ 숫자로 입력해주세요\n");
                                continue;
                            }
                            Console.Clear();
                            switch (chose)
                            {
                                case 1:
                                    student1.change_student();
                                    break;
                                case 2:
                                    while (true)
                                    {
                                        int q = 1; 
                                        Console.WriteLine("작업할 학생 :" + student1.name);
                                        Console.WriteLine("수강중인 과목");
                                        foreach (var item in student1.subject_list)
                                        {
                                            Console.WriteLine(q++ + "." + item.name);
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine("실행하실 작업을 선택해주세요.");
                                        Console.WriteLine("1. 수강 등록, 2. 수강 제거  3. 처음으로");
                                        try
                                        {
                                            chose = int.Parse(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.Clear();
                                            Console.WriteLine("※ 숫자로 입력해주세요\n");
                                            continue;
                                        }
                                        Console.Clear();
                                        switch (chose)
                                        {
                                            case 1:
                                                Subject subject = new Subject();
                                                subject = Subject.chose_subject();
                                                if (student1.subject_list.Contains(subject))
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("이미 신청된 강의입니다.\n");
                                                    continue;
                                                }
                                                student1.subject_list.Add(subject);
                                                subject.student_list.Add(student1);
                                                Console.Clear();
                                                Console.WriteLine("※ '"+subject.name +"'"+ " 등록되었습니다.\n");
                                                break;
                                            case 2:
                                                while (true)
                                                {
                                                    int i = 1;
                                                    Subject subject1 = new Subject();
                                                    if (student1.subject_list.Count < 1)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("※ 존재하는 과목이 없습니다\n");
                                                        break;
                                                    }
                                                    Console.WriteLine("제거할 과목을 선택해주세요");
                                                    foreach (var item in student1.subject_list)
                                                    {
                                                        Console.WriteLine(i + "." + item.name);
                                                    }
                                                    try
                                                    {
                                                        chose = int.Parse(Console.ReadLine());
                                                    }
                                                    catch
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("※ 숫자로 입력해주세요\n");
                                                        continue;
                                                    }
                                                    Console.Clear();
                                                    if ((chose > student1.subject_list.Count) || (chose == 0))
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                                        continue;
                                                    }
                                                    subject1 = student1.subject_list[chose - 1];
                                                    student1.subject_list.RemoveAt(chose - 1);
                                                    subject1.student_list.Remove(student1);

                                                    Console.WriteLine("※ 성공적으로 제거되었습니다.\n");
                                                    break;
                                                }
                                                break;
                                            case 3:
                                                break;

                                            default:
                                                Console.Clear();
                                                Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                                continue;
                                        }
                                        break;
                                    }
                                    break;
                                case 3:
                                    while (true)
                                    {
                                        Console.WriteLine("실행할 작업을 선택해주세요.");
                                        Console.WriteLine("1.과거 수강 과목 및 성적 확인  2. 평점 평균 확인 3. 처음으로");
                                        try
                                        {
                                            chose = int.Parse(Console.ReadLine());
                                        }
                                        catch
                                        {
                                            Console.Clear();
                                            Console.WriteLine("※ 숫자로 입력해주세요\n");
                                            continue;
                                        }
                                        Console.Clear();
                                        switch (chose)

                                        {
                                            case 1:
                                                while (true)
                                                {
                                                    if (student1.subjectend_list.Count < 1)
                                                    {
                                                        Console.WriteLine("※ 수강 과목이 없습니다!\n");
                                                        break;
                                                    }
                                                    Console.WriteLine("조회할 과목의 번호를 입력해주세요");
                                                    int a = 1;
                                                    foreach (var item in student1.subjectend_list)
                                                    {
                                                        Console.WriteLine(a + "." + item.name);

                                                    }
                                                    try
                                                    {
                                                        chose = int.Parse(Console.ReadLine());
                                                    }
                                                    catch
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("※ 숫자로 입력해주세요\n");
                                                        continue;
                                                    }
                                                    Console.Clear();
                                                    Console.WriteLine("과목 이름 : " + student1.subjectend_list[chose - 1].name);
                                                    Console.WriteLine("이수 구분 : " + student1.subjectend_list[chose - 1].subject_kind);
                                                    Console.WriteLine("담당 교수 : " + student1.subjectend_list[chose - 1].professor.name);
                                                    Console.WriteLine("강의실 번호 : " + student1.subjectend_list[chose - 1].classroom_num);
                                                    Console.WriteLine("학점 단위 : " + student1.subjectend_list[chose - 1].credit);
                                                    Console.WriteLine("담당 조교 : " + student1.subjectend_list[chose - 1].assistant.name);
                                                    Console.WriteLine("성적 : " + student1.subjectend_list[chose - 1].grade);
                                                    Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                                break;
                                            case 2:
                                                double avg_grade = 0;
                                                int subject_num = 0;
                                                foreach (var item in student1.subjectend_list)
                                                {
                                                    if (item.grade.Equals("A+"))
                                                        avg_grade += 4.5;
                                                    else if (item.grade.Equals("A"))
                                                        avg_grade += 4.3;
                                                    else if (item.grade.Equals("A-"))
                                                        avg_grade += 4.0;
                                                    else if (item.grade.Equals("B+"))
                                                        avg_grade += 3.5;
                                                    else if (item.grade.Equals("B"))
                                                        avg_grade += 3.3;
                                                    else if (item.grade.Equals("B-"))
                                                        avg_grade += 3.0;
                                                    else if (item.grade.Equals("C+"))
                                                        avg_grade += 2.5;
                                                    else if (item.grade.Equals("C"))
                                                        avg_grade += 2.3;
                                                    else if (item.grade.Equals("C-"))
                                                        avg_grade += 2.0;
                                                    else if (item.grade.Equals("D+"))
                                                        avg_grade += 1.5;
                                                    else if (item.grade.Equals("D"))
                                                        avg_grade += 1.3;
                                                    else if (item.grade.Equals("D-"))
                                                        avg_grade += 1.0;
                                                    subject_num++;
                                                }
                                                Console.WriteLine(student1.name + "의 평점 평균 : " + avg_grade / subject_num);
                                                Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                                                Console.ReadLine();
                                                Console.Clear();
                                                break;
                                            case 3:
                                                break;
                                            default:
                                                Console.Clear();
                                                Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                                continue;

                                        }
                                        break;
                                    }
                                    break;

                                case 4:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                    continue;

                            }
                            break;

                        }
                        break;
                    case 5:
                        while (true)
                        {
                            Console.WriteLine("검색할 대상을 선택해주세요");
                            Console.WriteLine("1. 교수  2. 조교  3. 직원  4. 학생  5. 학과  6. 처음으로");
                            try
                            {
                                chose = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("※ 숫자로 입력해주세요\n");
                                continue;
                            }
                            Console.Clear();
                            switch (chose)
                            {
                                case 1:
                                    Professor.search_professor();
                                    break;
                                case 2:
                                    Assistant.search_assistant();
                                    break;
                                case 3:
                                    Staff.search_staff();
                                    break;
                                case 4:
                                    Student.search_student();
                                    break;
                                case 5:
                                    while (true)
                                    {
                                        string name;
                                        Console.WriteLine("검색하려는 학과의 이름을 입력해주세요");
                                        Console.Write("입력 : ");
                                        name = Console.ReadLine();
                                        Department department = new Department();
                                        department = Department.search_department(name);
                                        if (department.name == null)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("※ 검색 결과가 없습니다\n");

                                        }
                                        else
                                            department.print_department();
                                        Console.WriteLine("\n엔터를 눌러 처음으로 돌아갑니다");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    }
                                    break;
                                case 6:
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                                    continue;

                            }
                            break;
                        }
                        break;
                    case 6:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("※ 올바른 숫자를 입력해주세요\n");
                        continue;
                }
            }
        }
    }
}

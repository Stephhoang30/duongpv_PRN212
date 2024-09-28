namespace Slot4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ls_stds = new List<Student>
            {
            new Student(1, "HE150001", "Nguyen Van A", new DateOnly(2000, 1, 15), 3.5),
            new Student(2, "HE150002", "Nguyen Thi B", new DateOnly(2001, 2, 20), 3.6),
            new Student(3, "HE150003", "Nguyen Van C", new DateOnly(2002, 3, 25), 3.7),
            new Student(4, "HE150004", "Tran Thi D", new DateOnly(2003, 4, 30), 3.3),
            new Student(5, "HE150005", "Le Van E", new DateOnly(2000, 5, 5), 3.4),
            new Student(6, "HE150006", "Pham Thi F", new DateOnly(2001, 6, 10), 3.5),
            new Student(7, "HE150007", "Vo Thi G", new DateOnly(2002, 7, 15), 3.6),
            new Student(8, "HE150008", "Hoang Van H", new DateOnly(2003, 8, 20), 3.7),
            new Student(9, "HE150009", "Bui Thi I", new DateOnly(2000, 9, 25), 2.4),
            new Student(10, "HE150010", "Duong Van J", new DateOnly(2001, 10, 30), 2.3)
            };

            //foreach (var s in ls_stds)
            //{
            //    if(2024 - s.DateOfBirth.Year > 20)
            //    {
            //        Console.WriteLine(s.FullName);
            //    }
            //}

            //Console.WriteLine("==============================================================");
            //var rs = from s in ls_stds
            //         where (2024-s.DateOfBirth.Year > 20)
            //         select s;
            //foreach (var s in rs.ToList())
            //{
            //    Console.WriteLine(s.FullName);
            //}

            //Console.WriteLine("==============================================================");
            //var rs1 = ls_stds.Where(s => 2024 - s.DateOfBirth.Year > 20).ToList();
            //foreach (var s in rs1)
            //{
            //    Console.WriteLine(s.FullName);
            //}

            //Console.WriteLine("==============================================================");
            //var rsHoNguyen = ls_stds.Where(s => s.FullName.StartsWith("Nguyen")).ToList();
            //foreach (var s in rsHoNguyen)
            //{
            //    Console.WriteLine(s);
            //}

            List<int> ls = new List<int>() {3, 5, 7, 2, 8};

            ls_stds.Sort(new StudentByFullName());
            foreach (var s in ls_stds)
            {
                Console.WriteLine(s.FullName);
            }

            //var ls_stds_by_Ho = getStudentsByHo(ls_stds);

            //foreach (var student in ls_stds_by_Ho)
            //{
            //    Console.WriteLine(student);
            //}

            //var ls_stds_by_CPA = getStudentByCPA(ls_stds);

            //foreach (var student in ls_stds_by_CPA)
            //{
            //    Console.WriteLine(student);
            //}

            //var ls_stds_by_age = getStudentByAge(ls_stds);

            //foreach (var student in ls_stds_by_age)
            //{
            //    Console.WriteLine(student);
            //}

        }

        private static List<Student> getStudentsByHo(List<Student> ls_stds)
        {
            Console.Write("Nhap ho can tim: ");
            string ho = Console.ReadLine();
            var result = new List<Student>();

            foreach (var student in ls_stds)
            {
                if (student.FullName.StartsWith(ho))
                {
                    result.Add(student);
                }
            }

            return result;
        }

        private static List<Student> getStudentByCPA(List<Student> ls_stds)
        {
            Console.Write("Nhap diem CPA:");
            double cpa = double.Parse(Console.ReadLine());

            var result = new List<Student>();

            foreach (var student in ls_stds)
            {
                if (student.CPA > cpa)
                {
                    result.Add((student));
                }

            }
            return result;
        }

        private static List<Student> getStudentByAge(List<Student> ls_stds)
        {
            Console.Write("Nhap tuoi: ");
            int age = int.Parse(Console.ReadLine());

            var result = new List<Student>();

            foreach (var student in ls_stds)
            {
                if ((2024 - student.DateOfBirth.Year) < age)
                {
                    result.Add((student));
                }
            }

            return result;
        }

    }
}

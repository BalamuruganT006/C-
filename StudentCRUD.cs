using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentCRUD
{
    class Student
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
    }

    class StudentRepository
    {
        private List<Student> _students = new List<Student>
        {
            new Student { RegNo = "73152313001", Name = "AARTHI K" },
            new Student { RegNo = "73152313005", Name = "AKILAN I" },
            new Student { RegNo = "73152313006", Name = "ANANDHA KUMARAN M S" },
            new Student { RegNo = "73152313008", Name = "ANUSRI S" },
            new Student { RegNo = "73152313009", Name = "ARUL M" },
            new Student { RegNo = "73152313010", Name = "ASWINTHRAJ DEVARAJ" },
            new Student { RegNo = "73152313011", Name = "BAARHAVI M D" },
            new Student { RegNo = "73152313012", Name = "BALAMURUGAN T" },
            new Student { RegNo = "73152313013", Name = "BHARANI M" },
            new Student { RegNo = "73152313014", Name = "BHARANIDHARAN R" },
            new Student { RegNo = "73152313017", Name = "CHANDRAPRADEEP R" },
            new Student { RegNo = "73152313018", Name = "CHERALATHAN B N" },
            new Student { RegNo = "73152313019", Name = "DEENADHAYALAN A" },
            new Student { RegNo = "73152313020", Name = "DEENATHAYALAN P" },
            new Student { RegNo = "73152313021", Name = "DEEPANA M" },
            new Student { RegNo = "73152313023", Name = "DHANUSHPRIYAN T" },
            new Student { RegNo = "73152313024", Name = "DHARSANKUMAR R K" },
            new Student { RegNo = "73152313026", Name = "DHARSHINI J" },
            new Student { RegNo = "73152313027", Name = "DHARSHINI V" },
            new Student { RegNo = "73152313029", Name = "DHIVAGAR P R" },
            new Student { RegNo = "73152313030", Name = "DINESH KUMAR S" },
            new Student { RegNo = "73152313032", Name = "GAYATHRI K" },
            new Student { RegNo = "73152313033", Name = "GISHNU B" },
            new Student { RegNo = "73152313034", Name = "GOKUL PRASATH R" },
            new Student { RegNo = "73152313035", Name = "GOPIKA M" },
            new Student { RegNo = "73152313036", Name = "GOPIKA P" },
            new Student { RegNo = "73152313039", Name = "GOWSHIGAN T" },
            new Student { RegNo = "73152313040", Name = "GOWTHAM M" },
            new Student { RegNo = "73152313041", Name = "HARISHKUMAR D" },
            new Student { RegNo = "73152313042", Name = "HARSHAVARDINI T" },
            new Student { RegNo = "73152313043", Name = "HEMASHRI T K" },
            new Student { RegNo = "73152313044", Name = "IMMANUEL FRANKLIN S" },
            new Student { RegNo = "73152313045", Name = "JAYASUDHAN N" },
            new Student { RegNo = "73152313046", Name = "JEEVITH K" },
            new Student { RegNo = "73152313047", Name = "JEEVITHA P" },
            new Student { RegNo = "73152313048", Name = "JEGAN D" },
            new Student { RegNo = "73152313049", Name = "JOTHILAKSHMI M" },
            new Student { RegNo = "73152313051", Name = "KAMALESH V" },
            new Student { RegNo = "73152313055", Name = "KAVIYARASAN S" },
            new Student { RegNo = "73152313057", Name = "KEERTHIKA K" },
            new Student { RegNo = "73152313058", Name = "KEERTHIKA P" },
            new Student { RegNo = "73152313060", Name = "KIRUTHIKKAILASH S" },
            new Student { RegNo = "73152313061", Name = "KISHORE R" },
            new Student { RegNo = "73152313062", Name = "KISHORE KUMAR M" },
            new Student { RegNo = "73152313063", Name = "KOKILA V" },
            new Student { RegNo = "73152313064", Name = "KRISHNA KUMAR K N" },
            new Student { RegNo = "73152313501", Name = "KAVIN M" },
            new Student { RegNo = "73152313502", Name = "KESAVAN SITHAN" },
        };

        // ✅ CREATE (Insert)
        public void Insert(string regNo, string name)
        {
            if (_students.Any(s => s.RegNo == regNo))
            {
                Console.WriteLine($"\n❌ RegNo {regNo} already exists!");
                return;
            }
            _students.Add(new Student { RegNo = regNo, Name = name });
            Console.WriteLine($"\n✅ Inserted: {regNo} - {name}");
        }

        // 📖 READ ALL
        public void ReadAll()
        {
            var sorted = _students.OrderBy(s => s.RegNo).ToList();
            Console.WriteLine($"\n{"S.No",-6} {"Reg. No",-15} {"Name"}");
            Console.WriteLine(new string('-', 50));
            for (int i = 0; i < sorted.Count; i++)
                Console.WriteLine($"{i + 1,-6} {sorted[i].RegNo,-15} {sorted[i].Name}");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Total: {sorted.Count} students\n");
        }

        // 📖 READ BY RegNo
        public void ReadOne(string regNo)
        {
            var s = _students.FirstOrDefault(x => x.RegNo == regNo);
            if (s != null)
                Console.WriteLine($"\n📖 Found: {s.RegNo} - {s.Name}");
            else
                Console.WriteLine($"\n❌ RegNo {regNo} not found!");
        }

        // ✏️ UPDATE
        public void Update(string regNo, string newName)
        {
            var s = _students.FirstOrDefault(x => x.RegNo == regNo);
            if (s != null)
            {
                string old = s.Name;
                s.Name = newName;
                Console.WriteLine($"\n✏️  Updated: {regNo} | {old} → {newName}");
            }
            else
                Console.WriteLine($"\n❌ RegNo {regNo} not found!");
        }

        // 🗑️ DELETE
        public void Delete(string regNo)
        {
            var s = _students.FirstOrDefault(x => x.RegNo == regNo);
            if (s != null)
            {
                _students.Remove(s);
                Console.WriteLine($"\n🗑️  Deleted: {regNo} - {s.Name}");
            }
            else
                Console.WriteLine($"\n❌ RegNo {regNo} not found!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var repo = new StudentRepository();

            Console.WriteLine("========== STUDENT CRUD OPERATIONS ==========");

            // 📖 READ ALL
            Console.WriteLine("\n--- READ ALL (Sorted by Reg.No) ---");
            repo.ReadAll();

            // ✅ INSERT
            Console.WriteLine("--- INSERT ---");
            repo.Insert("73152313065", "LAVANYA R");
            repo.Insert("73152313030", "DINESH KUMAR S"); // duplicate test

            // 📖 READ ONE
            Console.WriteLine("--- READ ONE ---");
            repo.ReadOne("73152313065");
            repo.ReadOne("73152313999"); // not found test

            // ✏️ UPDATE
            Console.WriteLine("--- UPDATE ---");
            repo.Update("73152313065", "LAVANYA RAJESH");
            repo.Update("73152313999", "NOBODY");  // not found test

            // 🗑️ DELETE
            Console.WriteLine("--- DELETE ---");
            repo.Delete("73152313065");
            repo.Delete("73152313999"); // not found test

            // 📖 READ ALL AFTER OPERATIONS
            Console.WriteLine("\n--- FINAL LIST ---");
            repo.ReadAll();

            Console.WriteLine("========== DONE ==========");
        }
    }
}
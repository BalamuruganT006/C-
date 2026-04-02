# 🎓 Student CRUD Operations - C#

A simple C# console application that performs **CRUD operations** (Create, Read, Update, Delete) on a student list, sorted in ascending order by Register Number.

---

## 📋 Project Overview

This program manages a list of students with their **Register Number** and **Name**. It demonstrates all four CRUD operations using an in-memory list in C#.

---

## 🗂️ Project Structure

```
StudentCRUD/
│
├── StudentCRUD.cs      # Main program file
└── README.md           # Project documentation
```

---

## 🧱 Classes

### `Student`
Represents a student entity.

| Property | Type   | Description          |
|----------|--------|----------------------|
| `RegNo`  | string | Register Number      |
| `Name`   | string | Full Name of Student |

### `StudentRepository`
Handles all CRUD operations on the student list.

### `Program`
Entry point — demonstrates all CRUD operations.

---

## ⚙️ CRUD Operations

### ✅ INSERT (Create)
Adds a new student to the list.
- Checks for **duplicate** Register Numbers before inserting.

```csharp
repo.Insert("73152313065", "LAVANYA R");
```

---

### 📖 READ (Read All / Read One)
Displays all students sorted by Register Number in **ascending order**.

```csharp
repo.ReadAll();          // Lists all students
repo.ReadOne("73152313001");  // Find by Reg.No
```

---

### ✏️ UPDATE
Updates the name of an existing student by Register Number.

```csharp
repo.Update("73152313065", "LAVANYA RAJESH");
```

---

### 🗑️ DELETE
Removes a student from the list by Register Number.

```csharp
repo.Delete("73152313065");
```

---

## 🖥️ Sample Output

```
========== STUDENT CRUD OPERATIONS ==========

--- READ ALL (Sorted by Reg.No) ---

S.No   Reg. No         Name
--------------------------------------------------
1      73152313001     AARTHI K
2      73152313005     AKILAN I
3      73152313006     ANANDHA KUMARAN M S
...
48     73152313502     KESAVAN SITHAN
--------------------------------------------------
Total: 48 students

--- INSERT ---
✅ Inserted: 73152313065 - LAVANYA R
❌ RegNo 73152313030 already exists!

--- READ ONE ---
📖 Found: 73152313065 - LAVANYA R
❌ RegNo 73152313999 not found!

--- UPDATE ---
✏️  Updated: 73152313065 | LAVANYA R → LAVANYA RAJESH
❌ RegNo 73152313999 not found!

--- DELETE ---
🗑️  Deleted: 73152313065 - LAVANYA RAJESH
❌ RegNo 73152313999 not found!

========== DONE ==========
```

---

## 👨‍🎓 Student List

Total of **48 unique students** from two class lists, merged and sorted by Register Number.

| S.No | Reg. No       | Name                  |
|------|---------------|-----------------------|
| 1    | 73152313001   | AARTHI K              |
| 2    | 73152313005   | AKILAN I              |
| 3    | 73152313006   | ANANDHA KUMARAN M S   |
| 4    | 73152313008   | ANUSRI S              |
| 5    | 73152313009   | ARUL M                |
| 6    | 73152313010   | ASWINTHRAJ DEVARAJ    |
| 7    | 73152313011   | BAARHAVI M D          |
| 8    | 73152313012   | BALAMURUGAN T         |
| 9    | 73152313013   | BHARANI M             |
| 10   | 73152313014   | BHARANIDHARAN R       |
| 11   | 73152313017   | CHANDRAPRADEEP R      |
| 12   | 73152313018   | CHERALATHAN B N       |
| 13   | 73152313019   | DEENADHAYALAN A       |
| 14   | 73152313020   | DEENATHAYALAN P       |
| 15   | 73152313021   | DEEPANA M             |
| 16   | 73152313023   | DHANUSHPRIYAN T       |
| 17   | 73152313024   | DHARSANKUMAR R K      |
| 18   | 73152313026   | DHARSHINI J           |
| 19   | 73152313027   | DHARSHINI V           |
| 20   | 73152313029   | DHIVAGAR P R          |
| 21   | 73152313030   | DINESH KUMAR S        |
| 22   | 73152313032   | GAYATHRI K            |
| 23   | 73152313033   | GISHNU B              |
| 24   | 73152313034   | GOKUL PRASATH R       |
| 25   | 73152313035   | GOPIKA M              |
| 26   | 73152313036   | GOPIKA P              |
| 27   | 73152313039   | GOWSHIGAN T           |
| 28   | 73152313040   | GOWTHAM M             |
| 29   | 73152313041   | HARISHKUMAR D         |
| 30   | 73152313042   | HARSHAVARDINI T       |
| 31   | 73152313043   | HEMASHRI T K          |
| 32   | 73152313044   | IMMANUEL FRANKLIN S   |
| 33   | 73152313045   | JAYASUDHAN N          |
| 34   | 73152313046   | JEEVITH K             |
| 35   | 73152313047   | JEEVITHA P            |
| 36   | 73152313048   | JEGAN D               |
| 37   | 73152313049   | JOTHILAKSHMI M        |
| 38   | 73152313051   | KAMALESH V            |
| 39   | 73152313055   | KAVIYARASAN S         |
| 40   | 73152313057   | KEERTHIKA K           |
| 41   | 73152313058   | KEERTHIKA P           |
| 42   | 73152313060   | KIRUTHIKKAILASH S     |
| 43   | 73152313061   | KISHORE R             |
| 44   | 73152313062   | KISHORE KUMAR M       |
| 45   | 73152313063   | KOKILA V              |
| 46   | 73152313064   | KRISHNA KUMAR K N     |
| 47   | 73152313501   | KAVIN M               |
| 48   | 73152313502   | KESAVAN SITHAN        |

---

## 🚀 How to Run

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) installed

### Steps

```bash
# Clone the repository
git clone https://github.com/your-username/StudentCRUD.git

# Navigate into the project folder
cd StudentCRUD

# Run the program
dotnet run
```

---

## 🔧 Git Push Commands

```bash
git init
git add .
git commit -m "Add Student CRUD operations with sorted list"
git remote add origin https://github.com/your-username/StudentCRUD.git
git push -u origin main
```

---

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET Console Application
- **Data Storage:** In-Memory List (`List<Student>`)
- **Concepts:** LINQ, OOP, CRUD Operations

---

## 📄 License

This project is open source and available for educational purposes.
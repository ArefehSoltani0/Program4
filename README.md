🔢 Factorial Calculator (C#)

A simple, educational C# console application that reads **6 integers** from the user and computes the **factorial** of each using a dedicated method — demonstrating core programming concepts like modularity, input validation, and error handling.

---

 📌 Features

- Accepts 6 non-negative integers from console input  
- Computes factorial via a reusable `Factorial()` method  
- Validates input (rejects negative or non-numeric entries)  
- Graceful error handling with user-friendly feedback  
- Re-prompts on invalid input (no program crash!)

---

 🛠 How to Run
 Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (v6.0 or later recommended)

Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/factorial-calculator-csharp.git
   cd factorial-calculator-csharp
   ```
2. Run the program:
   ```bash
   dotnet run
   ```
3. Follow the on-screen prompts.

---

🧪 Sample Output

```
Please enter 6 non-negative integers:
Number 1: 5
Factorial of 5 = 120
Number 2: 0
Factorial of 0 = 1
Number 3: -2
Error: Factorial is only defined for non-negative integers.
Number 3: abc
Invalid input. Please enter an integer.
Number 3: 3
Factorial of 3 = 6
...

using System;
using System.Collections.Generic;
using System.Text;
using System;
// Name : Mokhtar saleh Elhadidy
// ID : 225114881
namespace Cse111Task1
{
    public class StudentList
    {
        public Student? First;
        public Student? Last;
        public int Count;

        public StudentList()
        {
            First = null;
            Last = null;
            Count = 0;
        }
        public void AddFront(int id)
        {
            Student newStudent = new Student(id);

            newStudent.Next = First;
            First = newStudent;

            if (Last == null)
            {
                Last = newStudent;
            }

            Count++;
        }
        public void AddEnd(int id)
        {
            Student newStudent = new Student(id);

            if (First == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                Last!.Next = newStudent;
                Last = newStudent;
            }

            Count++;
        }
        public bool Remove(int id)
        {
            if (First == null)
            {
                return false;
            }

            if (First.Id == id)
            {
                First = First.Next;
                Count--;

                if (First == null)
                {
                    Last = null;
                }

                return true;
            }

            Student previous = First;
            Student? current = First.Next;

            while (current != null && current.Id != id)
            {
                previous = current;
                current = current.Next;
            }

            if (current == null)
            {
                return false;
            }

            previous.Next = current.Next;

            if (current == Last)
            {
                Last = previous;
            }

            Count--;

            return true;
        }
        public void Reverse()
        {
            Student? previous = null;
            Student? current = First;

            Last = First;

            while (current != null)
            {
                Student? next = current.Next;

                current.Next = previous;

                previous = current;
                current = next;
            }

            First = previous;
        }
        public void Print()
        {
            Student? current = First;
            bool firstStudent = true;

            while (current != null)
            {
                if (!firstStudent)
                {
                    Console.Write(" ");
                }

                Console.Write(current.Id);

                firstStudent = false;
                current = current.Next;
            }

            Console.WriteLine();
        }
    }
}



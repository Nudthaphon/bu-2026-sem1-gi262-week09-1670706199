using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment
{
    public class StudentSolution
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        public (int Count, int Popped, int Peek, int CountAfterPeek) LCT01_StackSyntax()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3); //ออก

            int count = stack.Count;
            Debug.Log($"Count: {count}");

            int popped = stack.Pop(); //3
            Debug.Log($"Popped: {popped}");

            int peek = stack.Peek(); //2
            Debug.Log($"Peek: {peek}");

            int countAfterPeek = stack.Count;
            Debug.Log($"Count after Peek: {countAfterPeek}");

            return (count, popped, peek, countAfterPeek);
        }

        public (int Count, int Dequeued, int Peek, int CountAfterPeek) LCT02_QueueSyntax()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1); // จากปกติจะเอา 3 ออก dequeue จะเปลียนเป็นเอา 1 ออก
            queue.Enqueue(2);
            queue.Enqueue(3);

            int count = queue.Count;
            Debug.Log($"Count: {count}");

            int dequeued = queue.Dequeue();
            Debug.Log($"Dequeued: {dequeued}");

            int peek = queue.Peek();
            Debug.Log($"Peek: {peek}");

            int countAfterPeek = queue.Count;
            Debug.Log($"Count after Peek: {countAfterPeek}");

            return (count, dequeued, peek, countAfterPeek);
        }

        public string[] LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

            Stack<Action> actionStack = new Stack<Action>();
            actionStack.Push(action1);
            actionStack.Push(action2);
            actionStack.Push(action3);

            string[] poppedNames = new string[actionStack.Count];
            for (int i = 0; i < poppedNames.Length; i++)
            {
                var poppedAction = actionStack.Pop();
                poppedNames[i] = poppedAction.Name;
                Debug.Log($"Popped: {poppedNames[i]}");
            }

            return poppedNames;
        }

        public string[] LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };
            
            
            Queue<Action> queue = new Queue<Action>();
            queue.Enqueue(action1);
            queue.Enqueue(action2);
            queue.Enqueue(action3);

            string[] dequeuedNames = new string[queue.Count];
            for (int i = 0; i < dequeuedNames.Length; i++)
            {
                var dequeuedAction = queue.Dequeue();
                dequeuedNames[i] = dequeuedAction.Name;
                Debug.Log($"Dequeued: {dequeuedNames[i]}");
            }

            return (dequeuedNames);
        }

        #endregion

        #region Assignment

        public string ASN01_ReverseString(string str)
        {
            throw new NotImplementedException();
        }

        public bool ASN02_StackPalindrome(string str)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Extra

        public bool EX01_ParenthesesChecker(string str)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

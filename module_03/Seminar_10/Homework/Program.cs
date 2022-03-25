using System;
using System.Collections.Generic;

namespace Homework_10
{
    // BinaryTree<ElemType> содержит в качестве поля ссылку на корень дерева.
    // Методы: конструктор без параметров; метод Insert() для добавления в дерево
    // нового значения; метод Preorder() выполняющий вывод в порядке слева направо значений из узлов,
    // начиная с заданного; метод Print() для печати дерева и свойство IsEmpty для проверки пустоты дерева.
    //
    
    class BinaryTree<ElemType>
    {
        internal BTnode<ElemType> Root;
        public BinaryTree() { }

        //internal Queue<BTnode<ElemType>> leafs = new();

        public void Insert(ElemType value)
        {
            Root.InsertValue(value);
            
            
            
            
            //BTnode<ElemType> anc = leafs.Peek();
            //if (anc.Left == null)
            //{
            //    BTnode<ElemType> elem = new BTnode<ElemType>(value, anc);
            //    leafs.Enqueue(elem);
            //    anc.Left = elem;
            //}
            //else
            //{
            //    BTnode<ElemType> elem = new BTnode<ElemType>(value, anc);
            //    leafs.Enqueue(elem);
            //    anc.Right = elem;
            //    leafs.Dequeue();
            //}
        }

        public void Preorder(BTnode<ElemType> from, bool inorder=false)
        {
            if (from == null)
            {
                return;
            }
            Console.WriteLine(from + " ");
            if (!from.isLeaf)
            {
                if (!inorder)
                {
                    Preorder(from.Left);
                    Preorder(from.Right);
                }
                else
                {
                    Preorder(from.Right, inorder);
                    Preorder(from.Left, inorder);
                }
            }
            
        }

        public bool IsEmpty => Root == null;

        public void Print()
        {
            if (IsEmpty)
                return;
            else
            {
                Preorder(Root);
            }
        }

        public void Delete(ElemType value)
        {
            var elem = Find(value);
            if(elem != null)
            {
                if (elem.Ancestor.Left.Equals(elem))
                    elem.Ancestor.Left = null;
                else
                    elem.Ancestor.Right = null;
            }
        }

        public BTnode<ElemType> Find(ElemType value, BTnode<ElemType> a = null)
        {
            if (a == null)
                a = Root;
            
            if (a.Value.Equals(value))
            {
                return a;
            }
            else
            {
                if (a.Left == null && a.Right == null)
                {
                    return null;
                }
                else if (a.Left != null)
                {
                    if (a.Right == null)
                    {
                        if (a.Left.Value.Equals(value))
                            return a.Left;
                        else
                            return null;
                    }
                    else
                    {
                        return Find(value, a.Left);
                    }
                }
                else if(a.Right != null)
                {
                    return Find(value, a.Right);
                }
            }

            return null;
        }

        public void Clear()
        {
            Root = null;
        }

        public void Inorder()
        {
            Preorder(Root, true);
        }

        public void Postorder(int iteration = 0, BTnode<ElemType> anc = null)
        {
            if(iteration == 0)
                Console.WriteLine(Root);
            if (anc == null)
                anc = Root;
            Console.WriteLine(anc.Left);
            Console.WriteLine(anc.Right);
            Postorder(iteration + 1, anc.Left);
            Postorder(iteration + 1, anc.Right);
        }



    }

    class BTnode<ValType>
    {
        public BTnode<ValType> Ancestor = null;
        public BTnode<ValType> Left = null;
        public BTnode<ValType> Right = null;

        public BinaryTree<ValType> BT;

        public ValType Value;

        public bool IsRoot = false;
        public bool isLeaf => Left == null && Right == null;
        
        public BTnode(ValType value, BinaryTree<ValType> tree)
        {
            Value = value;
            IsRoot = true;
            BT = tree;
            tree.Root = this;
        }

        public BTnode(ValType value, BTnode<ValType> ancestor)
        {
            Value = value;
            Ancestor = ancestor;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public void InsertValue(ValType value)
        {
            if (Value.Equals(value))
            {
                return;
            }
            else
            {
                if(Left == null && Right == null)
                {
                    Left = new BTnode<ValType>(value, this);
                }
                if(Left != null)
                {
                    if(Right == null)
                    {
                        if (Left.Value.Equals(value))
                            return;
                        else
                            Right = new BTnode<ValType>(value, this);
                    }
                    else
                    {
                        Left.InsertValue(value);
                    }
                }
            }


        }

        //private bool Check(BTnode<ValType> node, ValType value) => node.Left.Value.Equals(value) || node.Right.Equals(value);
    }



    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace k164058_Q5
{



        class dynamicarray<T> : IList<T>
            // not inherited by any other class
        {

            public T[] arr
            {
                get;
                set;
            }
            public int size
            {
                get;
                set;
            }
            public int capacity
            { get; set; }

            dynamicarray()  //Default
            {
                this.capacity = 10;
                this.size = 0;
                this.arr = new T[this.capacity];
            }

            dynamicarray(int capacity)
            {
                this.capacity = capacity;
                this.size = 0;  //one question: Without this its giving me error and abbhi BHII
                arr = new T[this.capacity];

            }


            //implementing.add's functionality ; 
            void add(T num)
            {
                //more memory is allocated to extend the capacity of the array so, taking it in exception

                if (size == capacity)
                {
                    //Console.Read.
                    this.arr[size] = num;
                    capacity += 1;
                    size += 1;

                }
                else
                {
                    this.arr[size] = num;
                    size += 1;
                }

            }




            //  g) returns element value of index specified by argument
            T get(int index)
            {
                // if (index > size || index < 0)   // shall I do index>capacity in place of size
                //   throw new IndexOutOfRangeException("ERROORRRR!");
                return this.arr[index];
            }


            int indexOf(T num)  //h) finds  element value specified by the argument 
            {
                for (int j = 0; j < size; j++)
                {
                    if (num.Equals(this.arr[j]))
                    {
                        return j;
                    }
                }
                return -1;
            }


            public static void Main(string[] args)
            {

                try
                {
                    dynamicarray<String> arr1 = new dynamicarray<String>();
                    dynamicarray<int> arr2 = new dynamicarray<int>(26);
                    arr2.add(26);

                    Console.WriteLine(arr2.indexOf(26));

                }


                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }

            public int IndexOf(T item)
            {
                throw new NotImplementedException();
            }

            public void Insert(int index, T item)
            {
                this[index] = item;
            }

            public void RemoveAt(int index)
            {
                int recieve = index;
                this[recieve] = default;
            }

            public T this[int index]
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public void Add(T item)
            {
                throw new NotImplementedException();
            }

            public void Clear()
            {
                for (int i = 0; i < size; i++)
            {
                this[i] = default;
            }
                }

            public bool Contains(T item)
            {
                for (int i = 0; i < size; i++)
                {
                    if (this[i].ToString() == item.ToString())
                    {
                        return true;
                    }

                }

                return false;
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                int j = 0;
                for (int i = arrayIndex; i < count; i++)
                {
                    array[j] = this[i];
                    j++;
                }
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                for (int i = 0; i < size; i++)
                {

                }
            }


            public int Count
            {
                get { throw new NotImplementedException(); }
            }

            public bool IsReadOnly
            {
                get { throw new NotImplementedException(); }
            }

            public bool Remove(T item)
            {
                
                bool a;
                a =Contains(item);
                for (int i = 0; i < size; i++)
              {
                if (this[i].ToString() == item.ToString())
                {
                    this[i] = default;
                    return true;
                }

              }
            return false;

            }

            public IEnumerator<T> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }
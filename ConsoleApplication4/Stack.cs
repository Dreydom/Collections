using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Stack<T> : ClassVariable<T>
    {
        public Stack() //конструктор стека с размером по умолчанию
        {
            this._array = new T[defaultCapacity];
        }

        public Stack(int Capacity) //конструктор стека заданного размера
        {
            this._array = new T[Capacity];
        }

        public Stack(IEnumerable<T> collection)
        {
            index = collection.Count();
            this._array = new T[index];
            for(int i = 0; i < _array.Count(); i++)
            {
                _array[i] = collection.ElementAt(i);
            }
        }

        public T Pop() //Удаляет и возвращает объект, находящийся в начале Stack.
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException(); //вброс ошибки при взятии с пустого стека
            }
            return this._array[--index];
        }

        public void Push(T obj) //добавление элемента в стек
        {
            if (index == _array.Length) //переполнение стека
            {
                T[] tmp = _array;
                _array = null;
                _array = new T[2 * tmp.Length];
                for (int i = 0; i < tmp.Length; i++)
                {
                    T temp = tmp[i];
                    _array[i] = temp;
                }
            }
            _array[index] = obj;
            index++;
        }
    }
    
}

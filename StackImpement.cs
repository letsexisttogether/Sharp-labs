
    class Stack <_T>
    {
        private _T[] mainArray;
        private int elemenstCount;
        // Количество всех созданых стэков
        static private int countOfStacks;
        static public int GetStackCount()
        {
            return countOfStacks;
        }

        public Stack()
        {
            mainArray = new _T[elemenstCount++];
            ++countOfStacks;
        }

        public void push(_T val)
        {
            // Переопределение памяти для массива и увеличение текущего количества элементов
            Array.Resize<_T>(ref mainArray, ++elemenstCount);
            mainArray[elemenstCount - 1] = val;
        }
        public void pop()
        {
            if(elemenstCount != 0)
                Array.Resize<_T>(ref mainArray, --elemenstCount);

        }
        public _T top()
        {
            return mainArray[elemenstCount - 1];
        }
        public void clear()
        {
            mainArray = null;
            elemenstCount = 0;
        }
        public bool empty()
        {
            return elemenstCount == 0;
        }
          
        // Перегрузка операторов в планах
       
    }

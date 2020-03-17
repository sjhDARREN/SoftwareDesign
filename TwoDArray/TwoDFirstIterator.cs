//
// ICT2106 Software Design - 2D array example
//
// Concrete row-major iterator for two-dimensional arrays.
//
// Author: Nicholas Sheppard
//
namespace TwoDArray
{
    class TwoDFirstIterator<T> : ITwoDIterator<T>
    {
        // the collection being iterated through
        TwoDArrayGeneric<T> collection;

        // counters
        private int i, j;

        // constructor
        public TwoDFirstIterator(TwoDArrayGeneric<T> collectionIn)
        {
            collection = collectionIn;
            i = 0;
            j = 0;
        }

        // get the current element of the iteration
        public T Current()
        {
            return collection.Get(i, j);
        }

        // move to the next element of the iteration
        public void Next()
        {
            //row 0/2/4... next number is left to right
            if (i == 0 || i%2==0){
                j++;
            }
            //row 1/3/5.. next number is right to left 
            else {
                j--;
            }
            
            //index more than colum refering to row 0,2,4... turn to next row and start from last
            if (j >= collection.Columns())
            {
                j = collection.Columns()-1;
                i++;
            }
            //index negative number more than colum refering to row 1,3,5 ... turn to next row and start from first
            if (j <= -1) {
                j = 0;
                i++;
            }
        }

        // test whether or not the iteration has finished
        public bool IsDone()
        {
            return i >= collection.Rows();
        }
    }
}

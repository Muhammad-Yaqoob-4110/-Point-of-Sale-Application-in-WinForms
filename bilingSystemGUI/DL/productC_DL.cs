using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bilingSystemGUI.BL;
using System.IO;
using System.Collections;
using System.Drawing;

namespace bilingSystemGUI.DL
{
    class productC_DL
    {
        private static List<productC_BL> BuyProductlst = new List<productC_BL>(); 
        private static string path = "productsFile.txt";
        public static void addProductToFile(productC_BL product)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(product.Name + "," + product.Price + "," + product.Discount + "," + product.Quantity);
            f.Close();
        }
        public static List<productC_BL> getProductList()
        {
            List<productC_BL> lst = new List<productC_BL>();
            StreamReader f = new StreamReader(path);
            string line;
            string[] productInfo;
            while ((line = f.ReadLine()) != null)
            {
                productInfo = line.Split(',');
                productC_BL p = new productC_BL();
                p.Name = productInfo[0];
                p.Price = float.Parse(productInfo[1]);
                p.Discount = float.Parse(productInfo[2]);
                p.Quantity = float.Parse(productInfo[3]);
                lst.Add(p);
            }
            f.Close();
            return lst;
        }
        public static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
        public static int findMinimum(IList<productC_BL> lst, int start, int end)
        {
            float min = lst[start].Price;
            int minIndex = start;
            for (int x = start; x < end; x++)
            {
                if (min > lst[x].Price)
                {
                    min = lst[x].Price;
                    minIndex = x;
                }
            }
            return minIndex;
        }
        public static void mergeSort(List<productC_BL>lst, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                mergeSort(lst, start, mid);
                mergeSort(lst, mid + 1, end);
                merge(lst, start, mid, end);
            }
        }
        public static void merge(List<productC_BL> lst, int start, int mid, int end)
        {
            int i = start;
            int j = mid + 1;
            Queue<productC_BL> tempArr = new Queue<productC_BL>();
            /*queue<Organization_Data> tempArr;*/
            while (i <= mid && j <= end)
            {
                /*Organization_Data temp1 = arr[i];
                Organization_Data temp2 = arr[j];*/
                if (lst[i].Price < lst[j].Price)
                {
                    tempArr.Enqueue(lst[i]);
                    i++;
                }
                else
                {
                    tempArr.Enqueue(lst[j]);
                    j++;
                }
            }
            while (i <= mid)
            {
                tempArr.Enqueue(lst[i]);
                i++;
            }
            while (j <= end)
            {
                tempArr.Enqueue(lst[j]);
                j++;
            }
            for (int x = start; x <= end; x++)
            {
                productC_BL p = new productC_BL();
                /*p = tempArr.Peek();*/
                lst[x] = tempArr.Peek();
                tempArr.Dequeue();
            }
        }
        public static int partition(List<productC_BL> lst, int low, int high)
        {
            //select the rightmost element as pivot
            /*Organization_Data pivotTemp = array[high];
            productC_BL p = new productC_BL();*/
            float pivot = lst[high].Price;
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                /*Organization_Data temp = array[j];*/
                if (lst[j].Price <= pivot)
                {
                    i++;
                    Swap(lst,i, j);
                }
            }
            Swap(lst,i + 1, high);
            return (i + 1);
        }

        public static void quickSort(List<productC_BL> lst, int low, int high)
        {
            /*vector<int> stack(high -low + 1);*/
            /*List<int> stack = new List<int>();*/
            int[] stack = new int[high - low + 1];
            int top = -1;
            stack[++top] = low;
            stack[++top] = high;
            while (top >= 0)
            {
                high = stack[top--];
                low = stack[top--];
                int p = partition(lst, low, high);
                if (p - 1 > low)
                {
                    stack[++top] = low;
                    stack[++top] = p - 1;
                }
                if (p + 1 < high)
                {
                    stack[++top] = p + 1;
                    stack[++top] = high;
                }
            }
        }
        public static int parentIndex(int i)
        {
            return (i - 1) / 2;
        }

        public static int leftChildIndex(int i)
        {
            return (2 * i) + 1;
        }

        public static int rightChildIndex(int i)
        {
            return (2 * i) + 2;
        }
        public static void heapify(List<productC_BL> lst, int size, int index)
        {
            int maxIndex;
            while (true)
            {
                int lIdx = leftChildIndex(index);
                int rIdx = rightChildIndex(index);
                if (rIdx >= size)
                {
                    if (lIdx >= size)
                        return;
                    else
                        maxIndex = lIdx;
                }
                else
                {
                    /*Organization_Data temp1 = heapArr[lIdx];
                    Organization_Data temp2 = heapArr[rIdx];*/
                    if (lst[lIdx].Price >= lst[rIdx].Price)
                        maxIndex = lIdx;
                    else
                        maxIndex = rIdx;
                }
                /*Organization_Data temp1 = heapArr[index];
                Organization_Data temp2 = heapArr[maxIndex];*/
                if (lst[index].Price < lst[maxIndex].Price)
                {
                    Swap(lst, index, maxIndex);
                    index = maxIndex;
                }
                else
                    return;
            }
        }
        public static void heapSort(List<productC_BL> lst)
        {
            int size = lst.Count();
            for (int x = (size / 2) - 1; x >= 0; x--)
            {
                heapify(lst, size, x);
            }
            for (int x = size - 1; x > 0; x--)
            {
                Swap(lst,0,x);
                heapify(lst, x, 0);
            }
        }
        public static float getMax(List<productC_BL> lst, int size)
        {
            /*Organization_Data tempo = organization_vector[0];*/
            float max = lst[0].Price;
            for (int i = 1; i < size; i++)
            {
                /*Organization_Data temp = array[i];*/
                if (lst[i].Price > max)
                    max = lst[i].Price;
            }
            return max;
        }
        public static void countSort(List<productC_BL> lst)
        {
            int size = lst.Count();
            float max = getMax(lst,lst.Count());

            productC_BL[] output = new productC_BL[size];
            /*List<productC_BL> output = new List<productC_BL>();*/
            float[] count = new float[(int)max + 1];
            for (int i = 0; i <= max; i++)
                count[i] = 0;

            //		increase number count in count array.	
            for (int i = 0; i < size; i++)
            {
                /*Organization_Data temp = organization_vector[i];*/
                count[(int)lst[i].Price]++;
            }

            //		find cumulative frequency
            for (int i = 1; i <= max; i++)
                count[i] += count[i - 1];

            for (int i = size - 1; i >= 0; i--)
            {
                /*Organization_Data temp = organization_vector[i];*/
                int cont = (int)count[(int)lst[i].Price - 1];
                output[(int)count[(int)lst[i].Price - 1]] = lst[i];
                count[(int)lst[i].Price] -= 1;
            }
            for (int i = 0; i < size; i++)
            {
                lst[i] = output[i];

            }
        }
        public static void countSort_Radix(List<productC_BL> lst, int exp)
        {
            int size = lst.Count();
            float max = getMax(lst, size);
            /*vector<Organization_Data> output(size);*/
            productC_BL[] output = new productC_BL[size];
            int[] count = new int[(int)max + 1];
            /*vector<int> count(max+1,0);*/
            for (int i = 0; i < lst.Count(); i++)
            {
                /*Organization_Data temp = array[i];*/
                count[(int)(lst[i].Price / exp) % 10]++;
            }
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = lst.Count() - 1; i >= 0; i--)
            {
                /*Organization_Data temp = array[i];*/
                output[count[((int)lst[i].Price / exp) % 10] - 1] = lst[i];
                count[(int)lst[i].Price / exp % 10]--;
            }
            for (int i = 0; i < lst.Count(); i++)
            {
                lst[i] = output[i];
            }
        }
        public static void radixsort(List<productC_BL> lst)
        {
            float max = getMax(lst, lst.Count());
            for (int exp = 1; max / exp > 0; exp *= 10)
                countSort_Radix(lst, exp);
        }
        
        public static List<productC_BL> sorted_Algorithms(int index)
        {
            List<productC_BL> lst = new List<productC_BL>();
            StreamReader f = new StreamReader(path);
            string line;
            string[] productInfo;
            while ((line = f.ReadLine()) != null)
            {
                productInfo = line.Split(',');
                productC_BL p = new productC_BL();
                p.Name = productInfo[0];
                p.Price = float.Parse(productInfo[1]);
                p.Discount = float.Parse(productInfo[2]);
                p.Quantity = float.Parse(productInfo[3]);
                lst.Add(p);
            }
            f.Close();
            if (index == 1)
            {
                /*bubble Sort*/
                int n = lst.Count();
                bool isSwapped = false;
                for (int x = 0; x < n - 1; x++)
                {
                    for (int y = 0; y < n - x - 1; y++)
                    {
                        if (lst[y].Price > lst[y + 1].Price)
                        {
                            Swap(lst, y, y + 1);
                            isSwapped = true;
                        }
                    }
                    if (!isSwapped)
                    {
                        break;
                    }

                }
                return lst;
            }
            else if (index == 2)
            {
                /*Selection Sort*/
                int n = lst.Count();
                for (int x = 0; x < n - 1; x++)
                {
                    int minIndex = findMinimum(lst, x, n);
                    Swap(lst, x, minIndex);
                }
                return lst;

            }
            else if (index == 3)
            {
                /*Insertion Sort*/
                for (int i = 1; i < lst.Count(); i++)
                {
                    float key = lst[i].Price;
                    productC_BL p = new productC_BL();
                    p = lst[i];
                    int j;
                    if (key < lst[i - 1].Price)
                    {
                        for (j = i - 1; j >= 0; j--)
                        {
                            lst[j + 1] = lst[j];
                            if (key > lst[j].Price)
                                break;
                        }
                        lst[j + 1] = p;
                    }
                }
                return lst;
            }
            else if(index == 4)
            {
                /*Merge Sort*/
                mergeSort(lst, 0, lst.Count() - 1);
                return lst;
            }
            else if(index == 5)
            {
                /*Quick Sort*/
                quickSort(lst, 0, lst.Count() - 1);
                return lst;
            }
            else if(index == 6)
            {
                /*Heap Sort*/
                heapSort(lst);
                return lst;
            }
            else if(index == 7)
            {
                /*Count Sort*/
                countSort(lst);
                return lst;
            }
            else if(index == 8)
            {
                /*Radix Sort*/
                radixsort(lst);
                return lst;
            }
            else if (index == 9)
            {
                /*Bucket Sort*/
                radixsort(lst);
                return lst;
            }
            return null;
        }
        public static List<productC_BL> deleteProductFromList(productC_BL temp)
        {
            List<productC_BL> lst = getProductList();
            for(int i =0; i< lst.Count; i++)
            {
                productC_BL product = lst[i];
                
                if(temp.Name == product.Name && temp.Price == product.Price && temp.Discount == product.Discount &&  temp.Quantity == temp.Quantity)
                {
                    lst.RemoveAt(i);
                }
            }
            return lst;
        }
        public static void storeDataInFile(List<productC_BL> lst)
        {
            StreamWriter f = new StreamWriter(path);
            foreach(productC_BL product in lst)
            {
                f.WriteLine(product.Name + "," + product.Price + "," + product.Discount + "," + product.Quantity);
            }
            f.Flush();
            f.Close();
        }
        public static List<productC_BL> editProductInList(productC_BL previous, productC_BL update)
        {
            List<productC_BL> lst = getProductList();
            for ( int i =0; i< lst.Count; i++)
            {
                productC_BL temp = new productC_BL();
                temp = lst[i];
                if (temp.Name == previous.Name && temp.Price == previous.Price && temp.Discount == previous.Discount && temp.Quantity == previous.Quantity)
                {
                    lst.RemoveAt(i);
                    lst.Insert(i, update);
                }
            }
            return lst;
        }
        public static void buyerList(productC_BL product)
        {
            BuyProductlst.Add(product);
        }
        public static List<productC_BL> getBuyedProductList()
        {
            foreach(productC_BL p in BuyProductlst)
            {
                p.Quantity = 1;
            }
            return BuyProductlst;
        }
        public static List<productC_BL> getBuyedProductList2()
        {
            return BuyProductlst;
        }
        public static List<productC_BL> deleteProductFromBuyedList(productC_BL product)
        {
            for(int i = 0; i<BuyProductlst.Count; i++ )
            {
                productC_BL temp = BuyProductlst[i];
                if (temp.Name == product.Name && temp.Price == product.Price && temp.Discount == product.Discount)
                {
                    BuyProductlst.RemoveAt(i);
                }
            }
            return BuyProductlst;
        }
        public static List<productC_BL> editProductInBuyedList(productC_BL previous, productC_BL update)
        {
            for (int i = 0; i < BuyProductlst.Count; i++)
            {
                productC_BL temp = new productC_BL();
                temp = BuyProductlst[i];
                if (temp.Name == previous.Name && temp.Price == previous.Price && temp.Discount == previous.Discount)
                {
                    BuyProductlst.RemoveAt(i);
                    BuyProductlst.Insert(i, update);
                }
            }
            return BuyProductlst;
        }
        public static void storeBuyedDataINList(List<productC_BL> lst)
        {
            BuyProductlst = lst;
        }
        public static float getBill()
        {
            List<productC_BL> lst = productC_DL.getBuyedProductList2();
            float bill = 0;
            foreach (productC_BL product in lst)
            {
                if (product.Discount > 0)
                {
                    bill = bill + (product.Price * product.Quantity) - (product.Price * product.Discount) / 100;
                }
                else
                {
                    bill = bill + product.Price * product.Quantity;
                }
            }
            return bill;
        }
        public static void makeListEmpty()
        {
            BuyProductlst.Clear();
        }
    }
}

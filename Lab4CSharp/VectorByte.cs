using System;
namespace Lab4CSharp
{
    internal class VectorByte
    {
        protected byte[] BArray;
        protected uint n;
        protected int codeError;
        protected static uint num_vec;

public VectorByte()
        {
            n = 0;
            BArray = new byte[n];
            codeError = 0;
            num_vec++;
        }
public VectorByte(uint size)
        {
            n = size;
            BArray = new byte[n];
            codeError = 0;
            for (int i = 0; i < n; i++)
            {
                BArray[i] = 0;
            }
            num_vec++;
        }
public VectorByte(uint size, byte init)
        {
            n = size;
            BArray = new byte[n];
            codeError = 0;
            for (int i = 0; i < n; i++)
            {
                BArray[i] = init;
            }
            num_vec++;
        }
~VectorByte()
        {
            console.WriteLine("Конструктор було викликано.");
        }


 public void Input()
        {
            for (int i = 0; i < n; i++) {
                console.WriteLine("Введiть число: ");
                BArray[i] = byte.Parse(console.ReadLine());
                    }
        }
    

public void Output()
        {
            for(int i = 0; i < n; i++)
            {
                console.WriteLine($"{BArray[i]}");
            }
        }

public void SetValue(byte value)
        {
            for(int i = 0; i < n; i++)
            {
                BArray[i] = value;
            }
        }

        public static uint NumVec
        {
            get { return num_vec; }
        }

        public uint Size
        {
            get { return n; }
        }

        public int CodeError
        {
            get { return codeError; }
            set { codeError = value; }
        }

        public byte this[int index]
        {
            get
            {
                if (index < 0 || index >= n)
                {
                    codeError = -1;
                    return 0;
                }
                else
                {
                    codeError = 0;
                    return BArray[index];
                }
            }

            set
            {
                if (index < 0 || index >= n)
                    codeError = -1;
                else
                {
                    codeError = 0;
                    BArray[index] = value;
                }
            }
        }


        public static VectorByte operator ++(VectorByte vb)
        {
            for(int i = 0; i < n; i++)
            {
                ++vb.BArray[n];
            }
            return vb;
        }
public static VectorByte operator --(VectorByte vb)
        {
            for (int i = 0; i < n; i++)
            {
                --vb.BArray[n];
            }
            return vb;
        }

public static bool operator true(VectorByte vb)
        {
            if (vb.Size == 0)
            {
                return false;
            }
            for(int i = 0; i < vb.n; i++)
            {
                if (vb.BArray[i] == 0)
                {
                    return false;
                }
                return true;
            }
        }

public static bool operator false(VectorByte vb)
        {
            if (vb.Size == 0)
            {
                return true;
            }
            for(int i = 0; i < vb.n; i++)
            {
                if (vb.BArray[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }

public static bool operator !(VectorByte vb)
        {
            if (vb.Size == 0)
            {
                return true;
            }

            for(int i = 0; i < vb.n; i++)
            {
                if (vb.BArray[i] == 0)
                {
                    return false;
                }
            }
            return true;
        }
public static VectorByte operator +(VectorByte vb1,VectorByte vb2)
        {
            if (vb1.Size != vb2.Size)
            {
                throw new ArgumentException("Вектори мають бути однаковi за розмiром");
            }
            VectorByte result = new VectorByte(vb1.Size);
            for(int i = 0; i < vb1.n; i++)
            {
                result[i] = (byte)(vb1[i] + vb2[i]);
            }
            return result;
        }

public static VectorByte operator +(VectorByte vb1, byte scalar)
        {

            VectorByte result = new VectorByte(vb1.Size);
            for (int i = 0; i < vb1.n; i++)
            {
                result[i] = (byte)(vb1[i] + scalar);
            }
            return result;
        }
public static VectorByte operator -(VectorByte v1, VectorByte v2)
        {
            if (v1.Size != v2.Size)
                throw new ArgumentException("Вектори мають бути однаковi за розмiром");

            VectorByte result = new VectorByte(v1.Size);
            for (int i = 0; i < v1.n; i++)
                result[i] = (byte)(v1[i] - v2[i]);
            return result;
        }

 public static VectorByte operator -(VectorByte v, byte scalar)
        {
            VectorByte result = new VectorByte(v.Size);
            for (int i = 0; i < v.n; i++)
                result[i] = (byte)(v[i] - scalar);
            return result;
        }

public static VectorByte operator *(VectorByte v1, VectorByte v2)
        {
            if (v1.Size != v2.Size)
                throw new ArgumentException("Вектори мають бути однаковi за розмiром");

            VectorByte result = new VectorByte(v1.Size);
            for (int i = 0; i < v1.n; i++)
                result[i] = (byte)(v1[i] * v2[i]);
            return result;
        }

public static VectorByte operator *(VectorByte v, byte scalar)
        {
            VectorByte result = new VectorByte(v.Size);
            for (int i = 0; i < v.n; i++)
                result[i] = (byte)(v[i] * scalar);
            return result;
        }

public static VectorByte operator /(VectorByte v1, VectorByte v2)
        {
            if (v1.Size != v2.Size)
                throw new ArgumentException("Вектори мають бути однаковi за розмiром");

            VectorByte result = new VectorByte(v1.Size);
            for (int i = 0; i < v1.n; i++)
            {
                if (v2[i] == 0)
                    throw new DivideByZeroException("Дiлення на нуль");
                result[i] = (byte)(v1[i] / v2[i]);
            }
            return result;
        }

public static VectorByte operator /(VectorByte v, byte scalar)
        {
            if (scalar == 0)
                throw new DivideByZeroException("Дiлення на нуль");

            VectorByte result = new VectorByte(v.Size);
            for (int i = 0; i < v.n; i++)
                result[i] = (byte)(v[i] / scalar);
            return result;
        }

public static VectorByte operator %(VectorByte v1, VectorByte v2)
        {
            if (v1.Size != v2.Size)
                throw new ArgumentException("Вектори мають бути однаковi за розмiром");

            VectorByte result = new VectorByte(v1.Size);
            for (int i = 0; i < v1.n; i++)
            {
                if (v2[i] == 0)
                    throw new DivideByZeroException("Дiлення на нуль");
                result[i] = (byte)(v1[i] % v2[i]);
            }
            return result;
        }

public static VectorByte operator %(VectorByte v, byte scalar)
        {
            if (scalar == 0)
                throw new DivideByZeroException("Дiлення на нуль");

            VectorByte result = new VectorByte(v.Size);
            for (int i = 0; i < v.n; i++)
                result[i] = (byte)(v[i] % scalar);
            return result;
        }

        // Побітові бінарні операції
public static VectorByte operator |(VectorByte v1, VectorByte v2)
        {
            if (v1.Size != v2.Size)
            {
                throw new ArgumentException("Вектори мають бути однаковi за розмiром");
            }
                

            VectorByte result = new VectorByte(v1.Size);
            for (int i = 0; i < v1.n; i++)
                result[i] = (byte)(v1[i] | v2[i]);
            return result;
        }

public static VectorByte operator |(VectorByte v, byte scalar)
        {
            VectorByte result = new VectorByte(v.Size);
            for (int i = 0; i < v.n; i++)
                result[i] = (byte)(v[i] | scalar);
            return result;
        }

public static VectorByte operator ^(VectorByte v1, VectorByte v2)
        {
            if (v1.Size != v2.Size)
                throw new ArgumentException("Вектори мають бути однаковi за розмiром");

            VectorByte result = new VectorByte(v1.Size);
            for (int i = 0; i < v1.n; i++)
                result[i] = (byte)(v1[i] ^ v2[i]);
            return result;
        }

public static VectorByte operator ^(VectorByte v, byte scalar)
        {
            VectorByte result = new VectorByte(v.Size);
            for (int i = 0; i < v.n; i++)
                result[i] = (byte)(v[i] ^ scalar);
            return result;
        }

public static VectorByte operator &(VectorByte v1, VectorByte v2)
        {
            if (v1.Size != v2.Size)
                throw new ArgumentException("Вектори мають бути однаковi за розмiром");

            VectorByte result = new VectorByte(v1.Size);
            for (int i = 0; i < v1.n; i++)
                result[i] = (byte)(v1[i] & v2[i]);
            return result;
        }

public static VectorByte operator &(VectorByte v, byte scalar)
        {
            VectorByte result = new VectorByte(v.Size);
            for (int i = 0; i < v.n; i++)
                result[i] = (byte)(v[i] & scalar);
            return result;
        }

public static VectorByte operator >>(VectorByte v1, int shift)
        {
            VectorByte result = new VectorByte(v1.Size);
            for (int i = 0; i < v1.n; i++)
                result[i] = (byte)(v1[i] >> shift);
            return result;
        }

 public static VectorByte operator >>(VectorByte v1, VectorByte v2)
        {
            if (v1.Size != v2.Size)
                throw new ArgumentException("Vectors must have the same size");

            VectorByte result = new VectorByte(v1.Size);
            for (int i = 0; i < v1.n; i++)
                result[i] = (byte)(v1[i] >> v2[i]);
            return result;
        }

        public static VectorByte operator <<(VectorByte v1, int shift)
        {
            VectorByte result = new VectorByte(v1.Size);
            for (int i = 0; i < v1.n; i++)
                result[i] = (byte)(v1[i] << shift);
            return result;
        }

public static VectorByte operator <<(VectorByte v1, VectorByte v2)
        {
            if (v1.Size != v2.Size)
                throw new ArgumentException("Vectors must have the same size");

            VectorByte result = new VectorByte(v1.Size);
            for (int i = 0; i < v1.n; i++)
                result[i] = (byte)(v1[i] << v2[i]);
            return result;
        }

        // Операції порівняння
        public static bool operator ==(VectorByte v1, VectorByte v2)
        {
            if (v1.Size != v2.Size)
                return false;

            for (int i = 0; i < v1.n; i++)
            {
                if (v1[i] != v2[i])
                    return false;
            }
            return true;
        }

public static bool operator !=(VectorByte v1, VectorByte v2)
        {
            return !(v1 == v2);
        }

public static bool operator >(VectorByte v1, VectorByte v2)
        {
            if (v1.Size != v2.Size)
            {
                throw new ArgumentException("Вектори мають бути однаковi за розмiром");
            }
                

            for (int i = 0; i < v1.n; i++)
            {
                if (v1[i] <= v2[i])
                    return false;
            }
            return true;
        }

public static bool operator >=(VectorByte v1, VectorByte v2)
        {
            if (v1.Size != v2.Size) 
            { 
                    throw new ArgumentException("Вектори мають бути однаковi за розмiром");
            }
                

            for (int i = 0; i < v1.n; i++)
            {
                if (v1[i] < v2[i])
                    return false;
            }
            return true;
        }

        public static bool operator <(VectorByte v1, VectorByte v2)
        {
            if (v1.Size != v2.Size)
            { 
                    throw new ArgumentException("Вектори мають бути однаковi за розмiром");
            }   
            for (int i = 0; i < v1.n; i++)
            {
                if (v1[i] >= v2[i])
                    return false;
            }
            return true;
        }

public static bool operator <=(VectorByte v1, VectorByte v2)
        {
            if (v1.Size != v2.Size)
            {
                throw new ArgumentException("Вектори мають бути однаковi за розмiром");
            }
                

            for (int i = 0; i < v1.n; i++)
            {
                if (v1[i] > v2[i])
                    return false;
            }
            return true;
        }
    }


    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ALEM
{
    class ALEM
    {
        static byte[] Encode(string s)
        {
            List<byte> bytes = new List<byte>();
            for(int i = 0; i < s.Length; i++)
            {
                switch(s[i])
                {
                    case 'a':
                        bytes.Add(0); break;
                    case 'b':
                        bytes.Add(1); break;
                    case 'c':
                        bytes.Add(2); break;
                    case 'd':
                        bytes.Add(3); break;
                    case 'e':
                        bytes.Add(4); break;
                    case 'f':
                        bytes.Add(5); break;
                    case 'g':
                        bytes.Add(6); break;
                    case 'h':
                        bytes.Add(7); break;
                    case 'i':
                        bytes.Add(8); break;
                    case 'j':
                        bytes.Add(9); break;
                    case 'k':
                        bytes.Add(10); break;
                    case 'l':
                        bytes.Add(11); break;
                    case 'm':
                        bytes.Add(12); break;
                    case 'n':
                        bytes.Add(13); break;
                    case 'o':
                        bytes.Add(14); break;
                    case 'p':
                        bytes.Add(15); break;
                    case 'q':
                        bytes.Add(16); break;
                    case 'r':
                        bytes.Add(17); break;
                    case 's':
                        bytes.Add(18); break;
                    case 't':
                        bytes.Add(19); break;
                    case 'u':
                        bytes.Add(20); break;
                    case 'v':
                        bytes.Add(21); break;
                    case 'w':
                        bytes.Add(22); break;
                    case 'x':
                        bytes.Add(23); break;
                    case 'y':
                        bytes.Add(24); break;
                    case 'z':
                        bytes.Add(25); break;
                    case 'A':
                        bytes.Add(26); break;
                    case 'B':
                        bytes.Add(27); break;
                    case 'C':
                        bytes.Add(28); break;
                    case 'D':
                        bytes.Add(29); break;
                    case 'E':
                        bytes.Add(30); break;
                    case 'F':
                        bytes.Add(31); break;
                    case 'G':
                        bytes.Add(32); break;
                    case 'H':
                        bytes.Add(33); break;
                    case 'I':
                        bytes.Add(34); break;
                    case 'J':
                        bytes.Add(35); break;
                    case 'K':
                        bytes.Add(36); break;
                    case 'L':
                        bytes.Add(37); break;
                    case 'M':
                        bytes.Add(38); break;
                    case 'N':
                        bytes.Add(39); break;
                    case 'O':
                        bytes.Add(40); break;
                    case 'P':
                        bytes.Add(41); break;
                    case 'Q':
                        bytes.Add(42); break;
                    case 'R':
                        bytes.Add(43); break;
                    case 'S':
                        bytes.Add(44); break;
                    case 'T':
                        bytes.Add(45); break;
                    case 'U':
                        bytes.Add(46); break;
                    case 'V':
                        bytes.Add(47); break;
                    case 'W':
                        bytes.Add(48); break;
                    case 'X':
                        bytes.Add(49); break;
                    case 'Y':
                        bytes.Add(50); break;
                    case 'Z':
                        bytes.Add(51); break;
                    case '1':
                        bytes.Add(52); break;
                    case '2':
                        bytes.Add(53); break;
                    case '3':
                        bytes.Add(54); break;
                    case '4':
                        bytes.Add(55); break;
                    case '5':
                        bytes.Add(56); break;
                    case '6':
                        bytes.Add(57); break;
                    case '7':
                        bytes.Add(58); break;
                    case '8':
                        bytes.Add(59); break;
                    case '9':
                        bytes.Add(60); break;
                    case '0':
                        bytes.Add(61); break;
                    case ',':
                        bytes.Add(62); break;
                    case '.':
                        bytes.Add(63); break;
                    case '-':
                        bytes.Add(64); break;
                    case '_':
                        bytes.Add(65); break;

                    //254 = New Line
                    default:
                        bytes.Add(255); break;
                }
            }
            byte[] content = bytes.ToArray();
            return content;
        }
        static void WriteAllLines(string[] array, string path)
        {
            if (File.Exists(path))
            {
                List<byte> bytes = new List<byte>();
                byte[] content;
                for(int i = 0; i < array.Length; i++)
                {
                    try
                    {
                        content = Encode(array[i]);
                        for(int j = 0; j < content.Length; j++)
                        {
                            bytes.Add(content[j]);
                        }
                    }
                    catch
                    {
                        throw new Exception($"Line = {i} :Array contained forbidden characters!");
                    }
                    if(i !=  array.Length - 1)
                    {
                        bytes.Add(254);
                    }
                }
                File.WriteAllBytes(path, bytes.ToArray());
            }
            else
            {
                throw new Exception("File does not exist!");
            }
        }
    }
}

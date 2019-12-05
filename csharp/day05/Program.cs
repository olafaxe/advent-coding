using System;

namespace day05
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1,0,0,0,99 becomes 2,0,0,0,99 (1 + 1 = 2).
            // 2,3,0,3,99 becomes 2,3,0,6,99 (3 * 2 = 6).
            // 2,4,4,5,99,0 becomes 2,4,4,5,99,9801 (99 * 99 = 9801).
            // 1,1,1,4,99,5,6,0,99 becomes 30,1,1,4,2,5,6,0,99.

            int[] array1 = { 1, 0, 0, 0, 99 };
            int[] array2 = { 2, 3, 0, 3, 99 };
            int[] array3 = { 2, 4, 4, 5, 99, 0 };
            int[] array4 = { 1, 1, 1, 4, 99, 5, 6, 0, 99 };
            int[] array5 = { 1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 1, 6, 19, 1, 5, 19, 23, 1, 23, 6, 27, 1, 5, 27, 31, 1, 31, 6, 35, 1, 9, 35, 39, 2, 10, 39, 43, 1, 43, 6, 47, 2, 6, 47, 51, 1, 5, 51, 55, 1, 55, 13, 59, 1, 59, 10, 63, 2, 10, 63, 67, 1, 9, 67, 71, 2, 6, 71, 75, 1, 5, 75, 79, 2, 79, 13, 83, 1, 83, 5, 87, 1, 87, 9, 91, 1, 5, 91, 95, 1, 5, 95, 99, 1, 99, 13, 103, 1, 10, 103, 107, 1, 107, 9, 111, 1, 6, 111, 115, 2, 115, 13, 119, 1, 10, 119, 123, 2, 123, 6, 127, 1, 5, 127, 131, 1, 5, 131, 135, 1, 135, 6, 139, 2, 139, 10, 143, 2, 143, 9, 147, 1, 147, 6, 151, 1, 151, 13, 155, 2, 155, 9, 159, 1, 6, 159, 163, 1, 5, 163, 167, 1, 5, 167, 171, 1, 10, 171, 175, 1, 13, 175, 179, 1, 179, 2, 183, 1, 9, 183, 0, 99, 2, 14, 0, 0 };
            int[] array6 = { 3, 0, 4, 0, 99 };
            int[] array7 = { 1002, 4, 3, 4, 33 };
            int[] array8 = { 3, 225, 1, 225, 6, 6, 1100, 1, 238, 225, 104, 0, 1102, 78, 40, 225, 1102, 52, 43, 224, 1001, 224, -2236, 224, 4, 224, 102, 8, 223, 223, 101, 4, 224, 224, 1, 224, 223, 223, 1, 191, 61, 224, 1001, 224, -131, 224, 4, 224, 102, 8, 223, 223, 101, 4, 224, 224, 1, 223, 224, 223, 1101, 86, 74, 225, 1102, 14, 76, 225, 1101, 73, 83, 224, 101, -156, 224, 224, 4, 224, 102, 8, 223, 223, 101, 6, 224, 224, 1, 224, 223, 223, 1102, 43, 82, 225, 2, 196, 13, 224, 101, -6162, 224, 224, 4, 224, 102, 8, 223, 223, 101, 5, 224, 224, 1, 223, 224, 223, 1001, 161, 51, 224, 101, -70, 224, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 1, 224, 1, 224, 223, 223, 102, 52, 187, 224, 1001, 224, -832, 224, 4, 224, 102, 8, 223, 223, 101, 1, 224, 224, 1, 224, 223, 223, 1102, 19, 79, 225, 101, 65, 92, 224, 1001, 224, -147, 224, 4, 224, 1002, 223, 8, 223, 101, 4, 224, 224, 1, 223, 224, 223, 1102, 16, 90, 225, 1102, 45, 44, 225, 1102, 92, 79, 225, 1002, 65, 34, 224, 101, -476, 224, 224, 4, 224, 102, 8, 223, 223, 1001, 224, 5, 224, 1, 224, 223, 223, 4, 223, 99, 0, 0, 0, 677, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1105, 0, 99999, 1105, 227, 247, 1105, 1, 99999, 1005, 227, 99999, 1005, 0, 256, 1105, 1, 99999, 1106, 227, 99999, 1106, 0, 265, 1105, 1, 99999, 1006, 0, 99999, 1006, 227, 274, 1105, 1, 99999, 1105, 1, 280, 1105, 1, 99999, 1, 225, 225, 225, 1101, 294, 0, 0, 105, 1, 0, 1105, 1, 99999, 1106, 0, 300, 1105, 1, 99999, 1, 225, 225, 225, 1101, 314, 0, 0, 106, 0, 0, 1105, 1, 99999, 107, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 329, 1001, 223, 1, 223, 1007, 226, 226, 224, 102, 2, 223, 223, 1005, 224, 344, 101, 1, 223, 223, 1008, 226, 226, 224, 102, 2, 223, 223, 1005, 224, 359, 1001, 223, 1, 223, 8, 226, 677, 224, 102, 2, 223, 223, 1006, 224, 374, 101, 1, 223, 223, 1107, 226, 677, 224, 1002, 223, 2, 223, 1006, 224, 389, 101, 1, 223, 223, 1108, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 404, 101, 1, 223, 223, 107, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 419, 1001, 223, 1, 223, 7, 677, 226, 224, 102, 2, 223, 223, 1005, 224, 434, 101, 1, 223, 223, 1007, 677, 677, 224, 102, 2, 223, 223, 1005, 224, 449, 1001, 223, 1, 223, 108, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 464, 1001, 223, 1, 223, 108, 226, 226, 224, 102, 2, 223, 223, 1006, 224, 479, 101, 1, 223, 223, 107, 226, 677, 224, 102, 2, 223, 223, 1006, 224, 494, 1001, 223, 1, 223, 7, 226, 226, 224, 1002, 223, 2, 223, 1006, 224, 509, 101, 1, 223, 223, 1108, 677, 226, 224, 102, 2, 223, 223, 1005, 224, 524, 101, 1, 223, 223, 1107, 677, 226, 224, 102, 2, 223, 223, 1005, 224, 539, 101, 1, 223, 223, 1008, 677, 226, 224, 102, 2, 223, 223, 1005, 224, 554, 101, 1, 223, 223, 1008, 677, 677, 224, 1002, 223, 2, 223, 1006, 224, 569, 101, 1, 223, 223, 1107, 677, 677, 224, 102, 2, 223, 223, 1006, 224, 584, 1001, 223, 1, 223, 1108, 226, 226, 224, 1002, 223, 2, 223, 1006, 224, 599, 101, 1, 223, 223, 7, 226, 677, 224, 102, 2, 223, 223, 1006, 224, 614, 101, 1, 223, 223, 108, 677, 677, 224, 1002, 223, 2, 223, 1006, 224, 629, 101, 1, 223, 223, 1007, 677, 226, 224, 102, 2, 223, 223, 1006, 224, 644, 101, 1, 223, 223, 8, 677, 677, 224, 1002, 223, 2, 223, 1006, 224, 659, 101, 1, 223, 223, 8, 677, 226, 224, 102, 2, 223, 223, 1005, 224, 674, 101, 1, 223, 223, 4, 223, 99, 226 };
            int[] array9 = { 1101, 100, -1, 4, 0 };
            static void runProgram(int[] array)
            {
                int[] newArray = array;
                int inc = 1;
                int mode1;
                int mode2;
                int location1;
                int location2;
                int location3;
                int num1;
                int num2;

                for (int i = 0; i < array.Length; i += inc)
                {
                    int opcode = array[i];
                    if (opcode == 99)
                    {
                        Console.WriteLine("");
                        // Console.WriteLine("Final value at index 0: " + array[0]);
                        // Console.WriteLine("Final value at index 1: " + array[1]);
                        // Console.WriteLine("Final value at index 2: " + array[2]);
                        // Console.WriteLine("Final value at index 3: " + array[3]);
                        // for (int y = 0; y < array.Length; y++)
                        // {
                        //     Console.WriteLine(array[y]);
                        // }

                        Console.WriteLine("Stopping...");
                        Console.ReadLine();
                        return;
                    }

                    if (opcode > 99)
                    {
                        int number = array[i];
                        string opcodeStringify = number.ToString();


                        if (opcode < 1000)
                        {
                            opcode = int.Parse(opcodeStringify[1].ToString() + opcodeStringify[2].ToString());
                            mode1 = int.Parse(opcodeStringify[0].ToString());
                            mode2 = int.Parse("0");
                        }
                        else
                        {
                            opcode = int.Parse(opcodeStringify[2].ToString() + opcodeStringify[3].ToString());
                            mode1 = int.Parse(opcodeStringify[1].ToString());
                            mode2 = int.Parse(opcodeStringify[0].ToString());

                        }

                        inc = 4;

                        if (opcode == 1)
                        {
                            int sum = opCode1(array, array[i + 1], array[i + 2], mode1, mode2);
                            array[array[i + 3]] = sum;
                            inc = 4;
                        }

                        if (opcode == 2)
                        {
                            int sum = opCode2(array, array[i + 1], array[i + 2], mode1, mode2);
                            array[array[i + 3]] = sum;
                            inc = 4;
                        }
                        if (opcode == 3)
                        {
                            opCode3();
                            inc = 2;
                        }
                        if (opcode == 4)
                        {
                            opCode4(array, i, mode1);
                            inc = 2;

                        }
                    }
                    else
                    {
                        if (opcode == 1)
                        {
                            int sum = opCode1(array, array[i + 1], array[i + 2]);
                            array[array[i + 3]] = sum;
                            inc = 4;
                        }
                        else if (array[i] == 2)
                        {
                            int sum = opCode2(array, array[i + 1], array[i + 2]);
                            array[array[i + 3]] = sum;
                            inc = 4;
                        }
                        else if (opcode == 3)
                        {
                            int inputValue = opCode3();
                            array[array[i + 1]] = inputValue;
                            inc = 2;
                        }
                        else if (opcode == 4)
                        {
                            opCode4(array, i);
                            inc = 2;
                        }

                    }

                }
            }

            static int addInts(int num1, int num2)
            {

                return num1 + num2;
            }

            static int multiplyInts(int num1, int num2)
            {
                return num1 * num2;
            }

            static int opCode1(int[] array, int location1, int location2, int mode1 = 0, int mode2 = 0)
            {
                if (mode1 == 0 && mode2 == 0)
                {
                    return addInts(array[location1], array[location2]);
                }
                else if (mode1 == 1 && mode2 == 0)
                {
                    return addInts(location1, array[location2]);
                }
                else if (mode1 == 0 && mode2 == 1)
                {
                    return addInts(array[location1], location2);
                }
                else if (mode1 == 1 && mode2 == 1)
                {
                    return addInts(location1, location2);
                }

                return 0;

            }

            static int opCode2(int[] array, int location1, int location2, int mode1 = 0, int mode2 = 0)
            {
                if (mode1 == 0 && mode2 == 0)
                {
                    return multiplyInts(array[location1], array[location2]);
                }
                else if (mode1 == 1 && mode2 == 0)
                {
                    return multiplyInts(location1, array[location2]);
                }
                else if (mode1 == 0 && mode2 == 1)
                {
                    return multiplyInts(array[location1], location2);
                }
                else if (mode1 == 1 && mode2 == 1)
                {
                    return multiplyInts(location1, location2);
                }

                return 0;

            }

            static int opCode3()
            {
                Console.Write("Please input number: ");
                string input = Console.ReadLine();
                int value;
                if (int.TryParse(input, out value))
                {
                    return int.Parse(input);
                }
                else
                {
                    return opCode3();
                }
            }

            static void opCode4(int[] array, int i, int mode1 = 0)
            {
                Console.WriteLine("opcode 4 " + array[i] + " " + array[i + 1]);

                if (mode1 == 0)
                {
                    Console.WriteLine("output: " + array[array[i + 1]]);
                }
                if (mode1 == 1)
                {
                    Console.WriteLine("output: " + array[i + 1]);

                }
            }

            // runProgram(array1);
            // runProgram(array2);
            // runProgram(array3);
            // runProgram(array4);
            // runProgram(array6);
            // runProgram(array7);
            runProgram(array8);
            // runProgram(array9);
        }
    }
}

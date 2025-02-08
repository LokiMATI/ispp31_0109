enum Season { Spring, Summer, Autumn, Winter }

enum SummerMonth : byte
{
    June = 6,
    Jule = 7,
    August = 8
}

[Flags]
enum Color
{
    Black = 0,
    Red = 1,
    Yellow =2,
    Blue =4,
    Orange = Red | Yellow, // 3
    Green = Blue | Yellow, // 6
    White = Red | Yellow | Black, // 7
}
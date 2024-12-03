using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using DefaultNamespace;

public class Test1 : MonoBehaviour
{
    void Literals()
    {
        Debug.Log(1 + 2);
        Debug.Log(3.14);
        Debug.Log('A');
        Debug.Log("Test\nNext Row\tTab");
        Debug.Log("C:\\Desktop\\Test\\Next Row\\Tab");
    }

    void TypeDates()
    {
        System.Boolean test = false; // 1 byte
        bool test0 = false;
        
        byte test1 = 0; // 1 byte
        sbyte test2 = -56;
        
        short test3 = -234; // 2 bytes
        ushort test4 = 3456;
        
        int test5 = -123456; // 4 bytes
        uint test6 = 123456;
        
        long test7 = -123456; // 8 bytes
        ulong test8 = 123456;
        
        float test9 = -123456f; // 4 bytes

        double test10 = -123456.0; // 8 bytes
        
        string test11 = "test11";
        string test12 = "Привет, Мир!";
        
        var test13 = "test13";
        var test14 = 2;
        var test15 = -3;
        var test16 = 3.14;
        var test17 = 3.14f;
        var test18 = 3.14d;
        
        decimal test19 = -123456m;
        
        int[] test20 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        List<int> test21 = new List<int>();
        test21.Add(3);
        test21.Add(4);

        test21.Contains(3);
        
        object[] test22 = new object[]{1, -2, 3.14f, 3.14d, "QWE", new Test1()};
    }

    void Cycles()
    {
        int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (var i = 0; i < 10; i++)
        {
            Debug.Log(test[i]);
        }

        foreach (var elem in test)
        {
            Debug.Log(elem);
        }

        int a = 3;
        while (a > 0)
        {
            --a;
        }

        do
        {
            --a;
        } while (a > 0);
    }

    void Classes()
    {
        Test2 a = new Test2
        {
            Qwe = 33
        };

        Test2 b = new Test2();
        
        b.SayHello();
    }

    void Collections()
    {
        List<int> test21 = new List<int>();
        test21.Add(3);
        test21.Add(4);
        PrintCollections(test21);
        
        LinkedList<int> test22 = new LinkedList<int>();
        test22.AddFirst(3);
        test22.AddFirst(4);
        PrintCollections(test22);
        
        Queue<int> test23 = new Queue<int>();
        Stack<int> test24 = new Stack<int>();
        
        Dictionary<string, int> test25 = new Dictionary<string, int>();
        test25["a"] = 0;
        test25["b"] = 2;

        foreach (KeyValuePair<string, int> pair in test25)
        {
            Debug.Log(pair);
        }
    }

    void PrintCollections(IEnumerable collection)
    {
        StringBuilder builder = new StringBuilder();
        
        foreach (var elem in collection)
        {
            builder.Append($"{elem} ");
        }
        
        Debug.Log(builder.ToString());
    }

    void Interfaces()
    {
        IEnumerable test = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //IClonable
        //IDisposable
        //IComrable
        //
    }

    void Files()
    {
        StreamWriter writer = new StreamWriter("Assets/Test1.txt", true);
        writer.WriteLine("Hello World");
        writer.Close();
        
        StreamReader reader = new StreamReader("Assets/Test1.txt");
        Debug.Log(reader.ReadToEnd());
        reader.Close();
        using (BinaryWriter writer2 = new BinaryWriter(File.Open("Assets/Test1.bin", FileMode.OpenOrCreate)))
        {
            writer2.Write("Hello World");
        }
    }

    void TestPlayerPrefs()
    {
        PlayerPrefs.SetInt("Test1", 1);
        PlayerPrefs.Save();
        
        Debug.Log(PlayerPrefs.GetInt("Test1"));
    }
    
    // Start is called before the first frame update
    void Start()
    {
        // Collections();
        Files();
        // TestPlayerPrefs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

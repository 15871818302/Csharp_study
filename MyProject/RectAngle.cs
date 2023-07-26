using System;
using System.Text;

namespace RectAngleApplication {
  class RectAngle {
    // 成员变量
    double length;
    double width;
    object obj;
    dynamic d = 20;
    string str = @"xxxxx"; // @可将一些转义字符看作是普通字符
    int a = 12;
    byte c = 10;
    public const string str2 = "2222222"; // c# 中也是用 const 来定义常量
    public int[] arr = new int[] {1,2,33,4,5,6,7,8,9};
    public void AcceptDetails() {
      length = 3.5;
      width = 4.5;
      obj = 100; // 对象的装箱(值类型转换为对象类型)
    }
    public double GetArea() {
      return length * width;
    }
    public void Display() {
      double d = 5300.6;
      int i;
      i = (int)d;
      foreach (int item in arr)
      {
        System.Console.WriteLine(item);
      }
      Console.WriteLine("Length: {0}", length);
      Console.WriteLine("Width: {0}", width);
      Console.WriteLine("Area: {0}", GetArea());
      Console.WriteLine(i);
    }
  }

  // 结构跟类的用法很相似，但是结构中不能赋予初始值，而且结构是直接储存在栈中，内存占用小，访问快，但是功能没有类那么全
  // 类是存储在堆中，占用内存较多，访问比较慢，功能很全
  struct Books {
    public string title;
    public string author;
    public string subject;
    public int books_id;
    public void setValues(string t, string a, string s, int id) {
      title = t;
      author = a;
      subject = s;
      books_id = id;
    }
    public void excute() {
      Console.WriteLine("title: {0}", title);
      Console.WriteLine("author: {0}", author);
      Console.WriteLine("subject: {0}", subject);
      Console.WriteLine("id: {0}", books_id);
    }
  }
  class ExcuteRectangle {
    static void Main() {
      RectAngle r = new RectAngle();
      Books book1 = new Books(); // 声明类型
      Books book2 = new Books();
      book1.setValues("a", "b", "c", 11);
      book2.setValues("q", "w", "e", 22);
      book1.excute();
      book2.excute();
      r.AcceptDetails();
      r.Display();
      Console.ReadLine();
    }
  }
}
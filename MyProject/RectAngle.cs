using System;

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
      Console.WriteLine("Length: {0}", length);
      Console.WriteLine("Width: {0}", width);
      Console.WriteLine("Area: {0}", GetArea());
      Console.WriteLine(i);
    }
  }

  class ExcuteRectangle {
    static void Main() {
      RectAngle r = new RectAngle();
      r.AcceptDetails();
      r.Display();
      Console.ReadLine();
    }
  }
}
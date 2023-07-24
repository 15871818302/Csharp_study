using System;

namespace RectAngleApplication {
  class RectAngle {
    // 成员变量
    double length;
    double width;
    public void AcceptDetails() {
      length = 3.5;
      width = 4.5;
    }
    public double GetArea() {
      return length * width;
    }
    public void Display() {
      Console.WriteLine("Length: {0}", length);
      Console.WriteLine("Width: {0}", width);
      Console.WriteLine("Area: {0}", GetArea());
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
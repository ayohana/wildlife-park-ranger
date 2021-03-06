using System;

namespace WildlifePark.Wildlife
{
  public class Animal
  {
    private string _name;
    private int _age;
    private int _id;
    private static int _currentID = 0;
    private static string _ranger;

    public Animal(string name, int age)
    {
      _name = name;
      _age = age;
      _currentID ++;
      _id = _currentID;
    }

    public string GetName()
    {
      return _name;
    }

    public int GetAge()
    {
      return _age;
    }

    public int GetID()
    {
      return _id;
    }

    public static string RangerMessage()
    {
      return $"Today's park ranger is {GetRanger()}.";
    }

    public static void SetRanger(string name)
    {
      _ranger = name;
    }

    public static string GetRanger()
    {
      return _ranger;
    }

    public static bool IsThereARanger()
    {
      return (_ranger != "");
    }
  }
}
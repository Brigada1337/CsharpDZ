using System;
using System.Xml.Serialization;

namespace Variant_F1
{
  
[Serializable] 
public class Musician
  {
      public string fname;
      public string lname;
      
      public Musician(string f, string l)
      {
        fname = f;
        lname = l;
      }
  }
  
[Serializable]   
public class Song
  {
      public string name;
      public int year;
      public string[] genre;
      public Musician[] musicians;
      
      public Song(string n, int y, string[] g)
      {
        name = n;
        year = y;
        genre = g;
        musicians = null;
      }
  }
  
[Serializable]  
public class Album
  {
      public string name;
      public int year;
      public Song[] songs;
      
      public Album(string n, int y)
      {
        name = n;
        year = y;
        songs = songs;
      }
  }
  
class Program
  {
    static void Main(string[] args)
    {
      Person person = new Person("Tom", 29);
}

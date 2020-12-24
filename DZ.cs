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
  
      public Song()
      {
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
      Album alb = new Album("Tommy", 1929);
      alb.songs = new Song[6]
      for (int i = 0; i < length; ++i)
        {
         alb.songs[i] = new Song();
         alb.songs[i].musicians = new Musician("Вячеслав", "Хартов")
        }
      
      XmlSerializer formatter = new XmlSerializer(typeof(Album));
      using (FileStream fs = new FileStream("alb.xml", FileMode.OpenOrCreate))
            {
               formatter.Serialize(fs, alb);
 
                Console.WriteLine("Объект сериализован");
            }
}

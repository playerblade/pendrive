using System;

namespace Tecnology{

  public class File
  {

    private string name;
    private string format;


      public File(string name, string format){
        this.name=name;
        this.format=format;
      }

      public void setName(string newName){
        this.name=newName;
      }

      public void setFormat(string newFormat){
        this.format=newFormat;
      }

      public getname(string name){
        this.name=name;
      }
      public getFormat(string format){
        this.format=format;
      }
  }

}

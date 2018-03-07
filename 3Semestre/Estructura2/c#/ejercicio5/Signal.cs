using System;
namespace Tecnology{
public class Signal
{
  private int flag;

  public Signal(int flag){
    this.flag=flag;
  }

  public string verifySignal(){
    string message;

    if(flag == 0){
      message = "Pendrive no se puede Introducir";
    }else{
      message = "Pendrive conectado"
    }
  }

}
}
